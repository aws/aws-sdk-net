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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RestJsonProtocol.Model;
using Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations;
using Amazon.RestJsonProtocol.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.RestJsonProtocol
{
    /// <summary>
    /// <para>Implementation for accessing RestJsonProtocol</para>
    ///
    /// A REST JSON service that sends JSON requests and responses.
    /// </summary>
    public partial class AmazonRestJsonProtocolClient : AmazonServiceClient, IAmazonRestJsonProtocol
    {
        private static IServiceMetadata serviceMetadata = new AmazonRestJsonProtocolMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with the credentials loaded from the application's
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
        public AmazonRestJsonProtocolClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRestJsonProtocolConfig()) { }

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with the credentials loaded from the application's
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
        public AmazonRestJsonProtocolClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRestJsonProtocolConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRestJsonProtocolClient Configuration Object</param>
        public AmazonRestJsonProtocolClient(AmazonRestJsonProtocolConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRestJsonProtocolClient(AWSCredentials credentials)
            : this(credentials, new AmazonRestJsonProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonProtocolClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRestJsonProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with AWS Credentials and an
        /// AmazonRestJsonProtocolClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRestJsonProtocolClient Configuration Object</param>
        public AmazonRestJsonProtocolClient(AWSCredentials credentials, AmazonRestJsonProtocolConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRestJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestJsonProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestJsonProtocolConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestJsonProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRestJsonProtocolClient Configuration Object</param>
        public AmazonRestJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRestJsonProtocolConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRestJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestJsonProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestJsonProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestJsonProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRestJsonProtocolClient Configuration Object</param>
        public AmazonRestJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRestJsonProtocolConfig clientConfig)
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


        #region  AllQueryStringTypes

        internal virtual AllQueryStringTypesResponse AllQueryStringTypes(AllQueryStringTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllQueryStringTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllQueryStringTypesResponseUnmarshaller.Instance;

            return Invoke<AllQueryStringTypesResponse>(request, options);
        }



        /// <summary>
        /// This example uses all query string types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllQueryStringTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllQueryStringTypes service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        public virtual Task<AllQueryStringTypesResponse> AllQueryStringTypesAsync(AllQueryStringTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllQueryStringTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllQueryStringTypesResponseUnmarshaller.Instance;

            return InvokeAsync<AllQueryStringTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConstantAndVariableQueryString

        internal virtual ConstantAndVariableQueryStringResponse ConstantAndVariableQueryString(ConstantAndVariableQueryStringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConstantAndVariableQueryStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConstantAndVariableQueryStringResponseUnmarshaller.Instance;

            return Invoke<ConstantAndVariableQueryStringResponse>(request, options);
        }



        /// <summary>
        /// This example uses fixed query string params and variable query string params. The
        /// fixed query string parameters and variable parameters must both be serialized (implementations
        /// may need to merge them together).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantAndVariableQueryString service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConstantAndVariableQueryString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        public virtual Task<ConstantAndVariableQueryStringResponse> ConstantAndVariableQueryStringAsync(ConstantAndVariableQueryStringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConstantAndVariableQueryStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConstantAndVariableQueryStringResponseUnmarshaller.Instance;

            return InvokeAsync<ConstantAndVariableQueryStringResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConstantQueryString

        internal virtual ConstantQueryStringResponse ConstantQueryString(ConstantQueryStringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConstantQueryStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConstantQueryStringResponseUnmarshaller.Instance;

            return Invoke<ConstantQueryStringResponse>(request, options);
        }



        /// <summary>
        /// This example uses a constant query string parameters and a label. This simply tests
        /// that labels and query string parameters are compatible. The fixed query string parameter
        /// named &quot;hello&quot; should in no way conflict with the label, <c>{hello}</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantQueryString service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConstantQueryString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        public virtual Task<ConstantQueryStringResponse> ConstantQueryStringAsync(ConstantQueryStringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConstantQueryStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConstantQueryStringResponseUnmarshaller.Instance;

            return InvokeAsync<ConstantQueryStringResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DatetimeOffsets

        internal virtual DatetimeOffsetsResponse DatetimeOffsets(DatetimeOffsetsRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the DatetimeOffsets service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual Task<DatetimeOffsetsResponse> DatetimeOffsetsAsync(DatetimeOffsetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DatetimeOffsetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DatetimeOffsetsResponseUnmarshaller.Instance;

            return InvokeAsync<DatetimeOffsetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DocumentType

        internal virtual DocumentTypeResponse DocumentType(DocumentTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DocumentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeResponseUnmarshaller.Instance;

            return Invoke<DocumentTypeResponse>(request, options);
        }



        /// <summary>
        /// This example serializes a document as part of the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DocumentType service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentType">REST API Reference for DocumentType Operation</seealso>
        public virtual Task<DocumentTypeResponse> DocumentTypeAsync(DocumentTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DocumentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DocumentTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DocumentTypeAsMapValue

        internal virtual DocumentTypeAsMapValueResponse DocumentTypeAsMapValue(DocumentTypeAsMapValueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DocumentTypeAsMapValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeAsMapValueResponseUnmarshaller.Instance;

            return Invoke<DocumentTypeAsMapValueResponse>(request, options);
        }



        /// <summary>
        /// This example serializes documents as the value of maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentTypeAsMapValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DocumentTypeAsMapValue service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsMapValue">REST API Reference for DocumentTypeAsMapValue Operation</seealso>
        public virtual Task<DocumentTypeAsMapValueResponse> DocumentTypeAsMapValueAsync(DocumentTypeAsMapValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DocumentTypeAsMapValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeAsMapValueResponseUnmarshaller.Instance;

            return InvokeAsync<DocumentTypeAsMapValueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DocumentTypeAsPayload

        internal virtual DocumentTypeAsPayloadResponse DocumentTypeAsPayload(DocumentTypeAsPayloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DocumentTypeAsPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeAsPayloadResponseUnmarshaller.Instance;

            return Invoke<DocumentTypeAsPayloadResponse>(request, options);
        }



        /// <summary>
        /// This example serializes a document as the entire HTTP payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentTypeAsPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DocumentTypeAsPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsPayload">REST API Reference for DocumentTypeAsPayload Operation</seealso>
        public virtual Task<DocumentTypeAsPayloadResponse> DocumentTypeAsPayloadAsync(DocumentTypeAsPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DocumentTypeAsPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeAsPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<DocumentTypeAsPayloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EmptyInputAndEmptyOutput

        internal virtual EmptyInputAndEmptyOutputResponse EmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EmptyInputAndEmptyOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;

            return Invoke<EmptyInputAndEmptyOutputResponse>(request, options);
        }



        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has an empty input and empty output structure
        /// that reuses the same shape. While this should be rare, code generators must support
        /// this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        public virtual Task<EmptyInputAndEmptyOutputResponse> EmptyInputAndEmptyOutputAsync(EmptyInputAndEmptyOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EmptyInputAndEmptyOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;

            return InvokeAsync<EmptyInputAndEmptyOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EndpointOperation

        internal virtual EndpointOperationResponse EndpointOperation(EndpointOperationRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the EndpointOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual Task<EndpointOperationResponse> EndpointOperationAsync(EndpointOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EndpointOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointOperationResponseUnmarshaller.Instance;

            return InvokeAsync<EndpointOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EndpointWithHostLabelOperation

        internal virtual EndpointWithHostLabelOperationResponse EndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual Task<EndpointWithHostLabelOperationResponse> EndpointWithHostLabelOperationAsync(EndpointWithHostLabelOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelOperationResponseUnmarshaller.Instance;

            return InvokeAsync<EndpointWithHostLabelOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FractionalSeconds

        internal virtual FractionalSecondsResponse FractionalSeconds(FractionalSecondsRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the FractionalSeconds service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        public virtual Task<FractionalSecondsResponse> FractionalSecondsAsync(FractionalSecondsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FractionalSecondsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FractionalSecondsResponseUnmarshaller.Instance;

            return InvokeAsync<FractionalSecondsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GreetingWithErrors

        internal virtual GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GreetingWithErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;

            return Invoke<GreetingWithErrorsResponse>(request, options);
        }



        /// <summary>
        /// This operation has four possible return values:
        /// 
        ///  <ol> <li>A successful response in the form of GreetingWithErrorsOutput</li> <li>An
        /// InvalidGreeting error.</li> <li>A BadRequest error.</li> <li>A FooError.</li> </ol>
        /// 
        /// <para>
        /// Implementations must be able to successfully take a response and properly (de)serialize
        /// successful and error responses based on the the presence of the
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by RestJsonProtocol.</returns>
        /// <exception cref="Amazon.RestJsonProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RestJsonProtocol.Model.FooErrorException">
        /// This error has test cases that test some of the dark corners of Amazon service framework
        /// history. It should only be implemented by clients.
        /// </exception>
        /// <exception cref="Amazon.RestJsonProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual Task<GreetingWithErrorsResponse> GreetingWithErrorsAsync(GreetingWithErrorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GreetingWithErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;

            return InvokeAsync<GreetingWithErrorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HostWithPathOperation

        internal virtual HostWithPathOperationResponse HostWithPathOperation(HostWithPathOperationRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the HostWithPathOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual Task<HostWithPathOperationResponse> HostWithPathOperationAsync(HostWithPathOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HostWithPathOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HostWithPathOperationResponseUnmarshaller.Instance;

            return InvokeAsync<HostWithPathOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpChecksumRequired

        internal virtual HttpChecksumRequiredResponse HttpChecksumRequired(HttpChecksumRequiredRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpChecksumRequiredRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpChecksumRequiredResponseUnmarshaller.Instance;

            return Invoke<HttpChecksumRequiredResponse>(request, options);
        }



        /// <summary>
        /// This example tests httpChecksumRequired trait
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpChecksumRequired service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpChecksumRequired service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpChecksumRequired">REST API Reference for HttpChecksumRequired Operation</seealso>
        public virtual Task<HttpChecksumRequiredResponse> HttpChecksumRequiredAsync(HttpChecksumRequiredRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpChecksumRequiredRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpChecksumRequiredResponseUnmarshaller.Instance;

            return InvokeAsync<HttpChecksumRequiredResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpEnumPayload

        internal virtual HttpEnumPayloadResponse HttpEnumPayload(HttpEnumPayloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpEnumPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpEnumPayloadResponseUnmarshaller.Instance;

            return Invoke<HttpEnumPayloadResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEnumPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpEnumPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        public virtual Task<HttpEnumPayloadResponse> HttpEnumPayloadAsync(HttpEnumPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpEnumPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpEnumPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<HttpEnumPayloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpPayloadTraits

        internal virtual HttpPayloadTraitsResponse HttpPayloadTraits(HttpPayloadTraitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpPayloadTraitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadTraitsResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadTraitsResponse>(request, options);
        }



        /// <summary>
        /// This example serializes a blob shape in the payload.
        /// 
        ///  
        /// <para>
        /// In this example, no JSON document is synthesized because the payload is not a structure
        /// or a union type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadTraits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadTraits service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        public virtual Task<HttpPayloadTraitsResponse> HttpPayloadTraitsAsync(HttpPayloadTraitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpPayloadTraitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadTraitsResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPayloadTraitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpPayloadWithStructure

        internal virtual HttpPayloadWithStructureResponse HttpPayloadWithStructure(HttpPayloadWithStructureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithStructureResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithStructureResponse>(request, options);
        }



        /// <summary>
        /// This example serializes a structure in the payload.
        /// 
        ///  
        /// <para>
        /// Note that serializing a structure changes the wrapper element name to match the targeted
        /// structure.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithStructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        public virtual Task<HttpPayloadWithStructureResponse> HttpPayloadWithStructureAsync(HttpPayloadWithStructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithStructureResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPayloadWithStructureResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpPayloadWithUnion

        internal virtual HttpPayloadWithUnionResponse HttpPayloadWithUnion(HttpPayloadWithUnionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithUnionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithUnionResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithUnionResponse>(request, options);
        }



        /// <summary>
        /// This example serializes a union in the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithUnion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithUnion service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        public virtual Task<HttpPayloadWithUnionResponse> HttpPayloadWithUnionAsync(HttpPayloadWithUnionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithUnionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithUnionResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPayloadWithUnionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpPrefixHeaders

        internal virtual HttpPrefixHeadersResponse HttpPrefixHeaders(HttpPrefixHeadersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpPrefixHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPrefixHeadersResponseUnmarshaller.Instance;

            return Invoke<HttpPrefixHeadersResponse>(request, options);
        }



        /// <summary>
        /// This examples adds headers to the input of a request and response by prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPrefixHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        public virtual Task<HttpPrefixHeadersResponse> HttpPrefixHeadersAsync(HttpPrefixHeadersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpPrefixHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPrefixHeadersResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPrefixHeadersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpPrefixHeadersInResponse

        internal virtual HttpPrefixHeadersInResponseResponse HttpPrefixHeadersInResponse(HttpPrefixHeadersInResponseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpPrefixHeadersInResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPrefixHeadersInResponseResponseUnmarshaller.Instance;

            return Invoke<HttpPrefixHeadersInResponseResponse>(request, options);
        }



        /// <summary>
        /// Clients that perform this test extract all headers from the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeadersInResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPrefixHeadersInResponse service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeadersInResponse">REST API Reference for HttpPrefixHeadersInResponse Operation</seealso>
        public virtual Task<HttpPrefixHeadersInResponseResponse> HttpPrefixHeadersInResponseAsync(HttpPrefixHeadersInResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpPrefixHeadersInResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPrefixHeadersInResponseResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPrefixHeadersInResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpRequestWithFloatLabels

        internal virtual HttpRequestWithFloatLabelsResponse HttpRequestWithFloatLabels(HttpRequestWithFloatLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpRequestWithFloatLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithFloatLabelsResponseUnmarshaller.Instance;

            return Invoke<HttpRequestWithFloatLabelsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithFloatLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpRequestWithFloatLabels service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        public virtual Task<HttpRequestWithFloatLabelsResponse> HttpRequestWithFloatLabelsAsync(HttpRequestWithFloatLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpRequestWithFloatLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithFloatLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<HttpRequestWithFloatLabelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpRequestWithGreedyLabelInPath

        internal virtual HttpRequestWithGreedyLabelInPathResponse HttpRequestWithGreedyLabelInPath(HttpRequestWithGreedyLabelInPathRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpRequestWithGreedyLabelInPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithGreedyLabelInPathResponseUnmarshaller.Instance;

            return Invoke<HttpRequestWithGreedyLabelInPathResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithGreedyLabelInPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpRequestWithGreedyLabelInPath service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        public virtual Task<HttpRequestWithGreedyLabelInPathResponse> HttpRequestWithGreedyLabelInPathAsync(HttpRequestWithGreedyLabelInPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpRequestWithGreedyLabelInPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithGreedyLabelInPathResponseUnmarshaller.Instance;

            return InvokeAsync<HttpRequestWithGreedyLabelInPathResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpRequestWithLabels

        internal virtual HttpRequestWithLabelsResponse HttpRequestWithLabels(HttpRequestWithLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpRequestWithLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithLabelsResponseUnmarshaller.Instance;

            return Invoke<HttpRequestWithLabelsResponse>(request, options);
        }



        /// <summary>
        /// The example tests how requests are serialized when there's no input payload but there
        /// are HTTP labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpRequestWithLabels service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        public virtual Task<HttpRequestWithLabelsResponse> HttpRequestWithLabelsAsync(HttpRequestWithLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpRequestWithLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<HttpRequestWithLabelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpRequestWithLabelsAndTimestampFormat

        internal virtual HttpRequestWithLabelsAndTimestampFormatResponse HttpRequestWithLabelsAndTimestampFormat(HttpRequestWithLabelsAndTimestampFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpRequestWithLabelsAndTimestampFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithLabelsAndTimestampFormatResponseUnmarshaller.Instance;

            return Invoke<HttpRequestWithLabelsAndTimestampFormatResponse>(request, options);
        }



        /// <summary>
        /// The example tests how requests serialize different timestamp formats in the URI path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabelsAndTimestampFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpRequestWithLabelsAndTimestampFormat service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        public virtual Task<HttpRequestWithLabelsAndTimestampFormatResponse> HttpRequestWithLabelsAndTimestampFormatAsync(HttpRequestWithLabelsAndTimestampFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpRequestWithLabelsAndTimestampFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithLabelsAndTimestampFormatResponseUnmarshaller.Instance;

            return InvokeAsync<HttpRequestWithLabelsAndTimestampFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpRequestWithRegexLiteral

        internal virtual HttpRequestWithRegexLiteralResponse HttpRequestWithRegexLiteral(HttpRequestWithRegexLiteralRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpRequestWithRegexLiteralRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithRegexLiteralResponseUnmarshaller.Instance;

            return Invoke<HttpRequestWithRegexLiteralResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithRegexLiteral service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpRequestWithRegexLiteral service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithRegexLiteral">REST API Reference for HttpRequestWithRegexLiteral Operation</seealso>
        public virtual Task<HttpRequestWithRegexLiteralResponse> HttpRequestWithRegexLiteralAsync(HttpRequestWithRegexLiteralRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpRequestWithRegexLiteralRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithRegexLiteralResponseUnmarshaller.Instance;

            return InvokeAsync<HttpRequestWithRegexLiteralResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpResponseCode

        internal virtual HttpResponseCodeResponse HttpResponseCode(HttpResponseCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpResponseCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpResponseCodeResponseUnmarshaller.Instance;

            return Invoke<HttpResponseCodeResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpResponseCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpResponseCode service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        public virtual Task<HttpResponseCodeResponse> HttpResponseCodeAsync(HttpResponseCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpResponseCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpResponseCodeResponseUnmarshaller.Instance;

            return InvokeAsync<HttpResponseCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HttpStringPayload

        internal virtual HttpStringPayloadResponse HttpStringPayload(HttpStringPayloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpStringPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpStringPayloadResponseUnmarshaller.Instance;

            return Invoke<HttpStringPayloadResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpStringPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpStringPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        public virtual Task<HttpStringPayloadResponse> HttpStringPayloadAsync(HttpStringPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HttpStringPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpStringPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<HttpStringPayloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IgnoreQueryParamsInResponse

        internal virtual IgnoreQueryParamsInResponseResponse IgnoreQueryParamsInResponse(IgnoreQueryParamsInResponseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IgnoreQueryParamsInResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IgnoreQueryParamsInResponseResponseUnmarshaller.Instance;

            return Invoke<IgnoreQueryParamsInResponseResponse>(request, options);
        }



        /// <summary>
        /// This example ensures that query string bound request parameters are serialized in
        /// the body of responses if the structure is used in both the request and response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IgnoreQueryParamsInResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IgnoreQueryParamsInResponse service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        public virtual Task<IgnoreQueryParamsInResponseResponse> IgnoreQueryParamsInResponseAsync(IgnoreQueryParamsInResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IgnoreQueryParamsInResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IgnoreQueryParamsInResponseResponseUnmarshaller.Instance;

            return InvokeAsync<IgnoreQueryParamsInResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InputAndOutputWithHeaders

        internal virtual InputAndOutputWithHeadersResponse InputAndOutputWithHeaders(InputAndOutputWithHeadersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InputAndOutputWithHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InputAndOutputWithHeadersResponseUnmarshaller.Instance;

            return Invoke<InputAndOutputWithHeadersResponse>(request, options);
        }



        /// <summary>
        /// The example tests how requests and responses are serialized when there is no input
        /// or output payload but there are HTTP header bindings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InputAndOutputWithHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InputAndOutputWithHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        public virtual Task<InputAndOutputWithHeadersResponse> InputAndOutputWithHeadersAsync(InputAndOutputWithHeadersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InputAndOutputWithHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InputAndOutputWithHeadersResponseUnmarshaller.Instance;

            return InvokeAsync<InputAndOutputWithHeadersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JsonBlobs

        internal virtual JsonBlobsResponse JsonBlobs(JsonBlobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonBlobsResponseUnmarshaller.Instance;

            return Invoke<JsonBlobsResponse>(request, options);
        }



        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonBlobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JsonBlobs service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonBlobs">REST API Reference for JsonBlobs Operation</seealso>
        public virtual Task<JsonBlobsResponse> JsonBlobsAsync(JsonBlobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonBlobsResponseUnmarshaller.Instance;

            return InvokeAsync<JsonBlobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JsonEnums

        internal virtual JsonEnumsResponse JsonEnums(JsonEnumsRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the JsonEnums service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        public virtual Task<JsonEnumsResponse> JsonEnumsAsync(JsonEnumsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonEnumsResponseUnmarshaller.Instance;

            return InvokeAsync<JsonEnumsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JsonIntEnums

        internal virtual JsonIntEnumsResponse JsonIntEnums(JsonIntEnumsRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the JsonIntEnums service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonIntEnums">REST API Reference for JsonIntEnums Operation</seealso>
        public virtual Task<JsonIntEnumsResponse> JsonIntEnumsAsync(JsonIntEnumsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonIntEnumsResponseUnmarshaller.Instance;

            return InvokeAsync<JsonIntEnumsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JsonLists

        internal virtual JsonListsResponse JsonLists(JsonListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonListsResponseUnmarshaller.Instance;

            return Invoke<JsonListsResponse>(request, options);
        }



        /// <summary>
        /// This test case serializes JSON lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal JSON lists.</li> <li>Normal JSON sets.</li> <li>JSON lists of lists.</li>
        /// <li>Lists of structures.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JsonLists service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonLists">REST API Reference for JsonLists Operation</seealso>
        public virtual Task<JsonListsResponse> JsonListsAsync(JsonListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonListsResponseUnmarshaller.Instance;

            return InvokeAsync<JsonListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JsonMaps

        internal virtual JsonMapsResponse JsonMaps(JsonMapsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonMapsResponseUnmarshaller.Instance;

            return Invoke<JsonMapsResponse>(request, options);
        }



        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JsonMaps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonMaps">REST API Reference for JsonMaps Operation</seealso>
        public virtual Task<JsonMapsResponse> JsonMapsAsync(JsonMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonMapsResponseUnmarshaller.Instance;

            return InvokeAsync<JsonMapsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JsonTimestamps

        internal virtual JsonTimestampsResponse JsonTimestamps(JsonTimestampsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonTimestampsResponseUnmarshaller.Instance;

            return Invoke<JsonTimestampsResponse>(request, options);
        }



        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonTimestamps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JsonTimestamps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonTimestamps">REST API Reference for JsonTimestamps Operation</seealso>
        public virtual Task<JsonTimestampsResponse> JsonTimestampsAsync(JsonTimestampsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonTimestampsResponseUnmarshaller.Instance;

            return InvokeAsync<JsonTimestampsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JsonUnions

        internal virtual JsonUnionsResponse JsonUnions(JsonUnionsRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the JsonUnions service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        public virtual Task<JsonUnionsResponse> JsonUnionsAsync(JsonUnionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JsonUnionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonUnionsResponseUnmarshaller.Instance;

            return InvokeAsync<JsonUnionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MediaTypeHeader

        internal virtual MediaTypeHeaderResponse MediaTypeHeader(MediaTypeHeaderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MediaTypeHeaderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MediaTypeHeaderResponseUnmarshaller.Instance;

            return Invoke<MediaTypeHeaderResponse>(request, options);
        }



        /// <summary>
        /// This example ensures that mediaType strings are base64 encoded in headers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MediaTypeHeader service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MediaTypeHeader service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/MediaTypeHeader">REST API Reference for MediaTypeHeader Operation</seealso>
        public virtual Task<MediaTypeHeaderResponse> MediaTypeHeaderAsync(MediaTypeHeaderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MediaTypeHeaderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MediaTypeHeaderResponseUnmarshaller.Instance;

            return InvokeAsync<MediaTypeHeaderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NoInputAndNoOutput

        internal virtual NoInputAndNoOutputResponse NoInputAndNoOutput(NoInputAndNoOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NoInputAndNoOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndNoOutputResponseUnmarshaller.Instance;

            return Invoke<NoInputAndNoOutputResponse>(request, options);
        }



        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output. While this should
        /// be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        public virtual Task<NoInputAndNoOutputResponse> NoInputAndNoOutputAsync(NoInputAndNoOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NoInputAndNoOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndNoOutputResponseUnmarshaller.Instance;

            return InvokeAsync<NoInputAndNoOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NoInputAndOutput

        internal virtual NoInputAndOutputResponse NoInputAndOutput(NoInputAndOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NoInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;

            return Invoke<NoInputAndOutputResponse>(request, options);
        }



        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input and the output is empty. While
        /// this should be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoInputAndOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual Task<NoInputAndOutputResponse> NoInputAndOutputAsync(NoInputAndOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NoInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;

            return InvokeAsync<NoInputAndOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NullAndEmptyHeadersClient

        internal virtual NullAndEmptyHeadersClientResponse NullAndEmptyHeadersClient(NullAndEmptyHeadersClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersClientResponseUnmarshaller.Instance;

            return Invoke<NullAndEmptyHeadersClientResponse>(request, options);
        }



        /// <summary>
        /// Null and empty headers are not sent over the wire.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NullAndEmptyHeadersClient service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        public virtual Task<NullAndEmptyHeadersClientResponse> NullAndEmptyHeadersClientAsync(NullAndEmptyHeadersClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersClientResponseUnmarshaller.Instance;

            return InvokeAsync<NullAndEmptyHeadersClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NullAndEmptyHeadersServer

        internal virtual NullAndEmptyHeadersServerResponse NullAndEmptyHeadersServer(NullAndEmptyHeadersServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersServerResponseUnmarshaller.Instance;

            return Invoke<NullAndEmptyHeadersServerResponse>(request, options);
        }



        /// <summary>
        /// Null and empty headers are not sent over the wire.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NullAndEmptyHeadersServer service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        public virtual Task<NullAndEmptyHeadersServerResponse> NullAndEmptyHeadersServerAsync(NullAndEmptyHeadersServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersServerResponseUnmarshaller.Instance;

            return InvokeAsync<NullAndEmptyHeadersServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  OmitsNullSerializesEmptyString

        internal virtual OmitsNullSerializesEmptyStringResponse OmitsNullSerializesEmptyString(OmitsNullSerializesEmptyStringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OmitsNullSerializesEmptyStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OmitsNullSerializesEmptyStringResponseUnmarshaller.Instance;

            return Invoke<OmitsNullSerializesEmptyStringResponse>(request, options);
        }



        /// <summary>
        /// Omits null, but serializes empty string value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OmitsNullSerializesEmptyString service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OmitsNullSerializesEmptyString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        public virtual Task<OmitsNullSerializesEmptyStringResponse> OmitsNullSerializesEmptyStringAsync(OmitsNullSerializesEmptyStringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OmitsNullSerializesEmptyStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OmitsNullSerializesEmptyStringResponseUnmarshaller.Instance;

            return InvokeAsync<OmitsNullSerializesEmptyStringResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  OmitsSerializingEmptyLists

        internal virtual OmitsSerializingEmptyListsResponse OmitsSerializingEmptyLists(OmitsSerializingEmptyListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OmitsSerializingEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OmitsSerializingEmptyListsResponseUnmarshaller.Instance;

            return Invoke<OmitsSerializingEmptyListsResponse>(request, options);
        }



        /// <summary>
        /// Omits serializing empty lists. Because empty strings are serilized as <c>Foo=</c>,
        /// empty lists cannot also be serialized as <c>Foo=</c> and instead must be omitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OmitsSerializingEmptyLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OmitsSerializingEmptyLists service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsSerializingEmptyLists">REST API Reference for OmitsSerializingEmptyLists Operation</seealso>
        public virtual Task<OmitsSerializingEmptyListsResponse> OmitsSerializingEmptyListsAsync(OmitsSerializingEmptyListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OmitsSerializingEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OmitsSerializingEmptyListsResponseUnmarshaller.Instance;

            return InvokeAsync<OmitsSerializingEmptyListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PostUnionWithJsonName

        internal virtual PostUnionWithJsonNameResponse PostUnionWithJsonName(PostUnionWithJsonNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostUnionWithJsonNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostUnionWithJsonNameResponseUnmarshaller.Instance;

            return Invoke<PostUnionWithJsonNameResponse>(request, options);
        }



        /// <summary>
        /// This operation defines a union that uses jsonName on some members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostUnionWithJsonName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostUnionWithJsonName service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PostUnionWithJsonName">REST API Reference for PostUnionWithJsonName Operation</seealso>
        public virtual Task<PostUnionWithJsonNameResponse> PostUnionWithJsonNameAsync(PostUnionWithJsonNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostUnionWithJsonNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostUnionWithJsonNameResponseUnmarshaller.Instance;

            return InvokeAsync<PostUnionWithJsonNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutWithContentEncoding

        internal virtual PutWithContentEncodingResponse PutWithContentEncoding(PutWithContentEncodingRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the PutWithContentEncoding service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual Task<PutWithContentEncodingResponse> PutWithContentEncodingAsync(PutWithContentEncodingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutWithContentEncodingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWithContentEncodingResponseUnmarshaller.Instance;

            return InvokeAsync<PutWithContentEncodingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryIdempotencyTokenAutoFill

        internal virtual QueryIdempotencyTokenAutoFillResponse QueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        public virtual Task<QueryIdempotencyTokenAutoFillResponse> QueryIdempotencyTokenAutoFillAsync(QueryIdempotencyTokenAutoFillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryIdempotencyTokenAutoFillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIdempotencyTokenAutoFillResponseUnmarshaller.Instance;

            return InvokeAsync<QueryIdempotencyTokenAutoFillResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryParamsAsStringListMap

        internal virtual QueryParamsAsStringListMapResponse QueryParamsAsStringListMap(QueryParamsAsStringListMapRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryParamsAsStringListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryParamsAsStringListMapResponseUnmarshaller.Instance;

            return Invoke<QueryParamsAsStringListMapResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryParamsAsStringListMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryParamsAsStringListMap service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        public virtual Task<QueryParamsAsStringListMapResponse> QueryParamsAsStringListMapAsync(QueryParamsAsStringListMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryParamsAsStringListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryParamsAsStringListMapResponseUnmarshaller.Instance;

            return InvokeAsync<QueryParamsAsStringListMapResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryPrecedence

        internal virtual QueryPrecedenceResponse QueryPrecedence(QueryPrecedenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryPrecedenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryPrecedenceResponseUnmarshaller.Instance;

            return Invoke<QueryPrecedenceResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryPrecedence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryPrecedence service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        public virtual Task<QueryPrecedenceResponse> QueryPrecedenceAsync(QueryPrecedenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryPrecedenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryPrecedenceResponseUnmarshaller.Instance;

            return InvokeAsync<QueryPrecedenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecursiveShapes

        internal virtual RecursiveShapesResponse RecursiveShapes(RecursiveShapesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecursiveShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecursiveShapesResponseUnmarshaller.Instance;

            return Invoke<RecursiveShapesResponse>(request, options);
        }



        /// <summary>
        /// Recursive shapes
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveShapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecursiveShapes service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        public virtual Task<RecursiveShapesResponse> RecursiveShapesAsync(RecursiveShapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecursiveShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecursiveShapesResponseUnmarshaller.Instance;

            return InvokeAsync<RecursiveShapesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SimpleScalarProperties

        internal virtual SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual Task<SimpleScalarPropertiesResponse> SimpleScalarPropertiesAsync(SimpleScalarPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SimpleScalarPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<SimpleScalarPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestBodyStructure

        internal virtual TestBodyStructureResponse TestBodyStructure(TestBodyStructureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestBodyStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBodyStructureResponseUnmarshaller.Instance;

            return Invoke<TestBodyStructureResponse>(request, options);
        }



        /// <summary>
        /// This example operation serializes a structure in the HTTP body.
        /// 
        ///  
        /// <para>
        /// It should ensure Content-Type: application/json is used in all requests and that an
        /// &quot;empty&quot; body is an empty JSON document ({}).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBodyStructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestBodyStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestBodyStructure">REST API Reference for TestBodyStructure Operation</seealso>
        public virtual Task<TestBodyStructureResponse> TestBodyStructureAsync(TestBodyStructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestBodyStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBodyStructureResponseUnmarshaller.Instance;

            return InvokeAsync<TestBodyStructureResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestNoPayload

        internal virtual TestNoPayloadResponse TestNoPayload(TestNoPayloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestNoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestNoPayloadResponseUnmarshaller.Instance;

            return Invoke<TestNoPayloadResponse>(request, options);
        }



        /// <summary>
        /// This example operation serializes a request without an HTTP body.
        /// 
        ///  
        /// <para>
        /// These tests are to ensure we do not attach a body or related headers (Content-Length,
        /// Content-Type) to operations that semantically cannot produce an HTTP body.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestNoPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestNoPayload">REST API Reference for TestNoPayload Operation</seealso>
        public virtual Task<TestNoPayloadResponse> TestNoPayloadAsync(TestNoPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestNoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestNoPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<TestNoPayloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestPayloadBlob

        internal virtual TestPayloadBlobResponse TestPayloadBlob(TestPayloadBlobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestPayloadBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadBlobResponseUnmarshaller.Instance;

            return Invoke<TestPayloadBlobResponse>(request, options);
        }



        /// <summary>
        /// This example operation serializes a payload targeting a blob.
        /// 
        ///  
        /// <para>
        /// The Blob shape is not structured content and we cannot make assumptions about what
        /// data will be sent. This test ensures only a generic &quot;Content-Type: application/octet-stream&quot;
        /// header is used, and that we are not treating an empty body as an empty JSON document.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayloadBlob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestPayloadBlob service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadBlob">REST API Reference for TestPayloadBlob Operation</seealso>
        public virtual Task<TestPayloadBlobResponse> TestPayloadBlobAsync(TestPayloadBlobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestPayloadBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadBlobResponseUnmarshaller.Instance;

            return InvokeAsync<TestPayloadBlobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestPayloadStructure

        internal virtual TestPayloadStructureResponse TestPayloadStructure(TestPayloadStructureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestPayloadStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadStructureResponseUnmarshaller.Instance;

            return Invoke<TestPayloadStructureResponse>(request, options);
        }



        /// <summary>
        /// This example operation serializes a payload targeting a structure.
        /// 
        ///  
        /// <para>
        /// This enforces the same requirements as TestBodyStructure but with the body specified
        /// by the @httpPayload trait.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayloadStructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestPayloadStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadStructure">REST API Reference for TestPayloadStructure Operation</seealso>
        public virtual Task<TestPayloadStructureResponse> TestPayloadStructureAsync(TestPayloadStructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestPayloadStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadStructureResponseUnmarshaller.Instance;

            return InvokeAsync<TestPayloadStructureResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TimestampFormatHeaders

        internal virtual TimestampFormatHeadersResponse TimestampFormatHeaders(TimestampFormatHeadersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TimestampFormatHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TimestampFormatHeadersResponseUnmarshaller.Instance;

            return Invoke<TimestampFormatHeadersResponse>(request, options);
        }



        /// <summary>
        /// This example tests how timestamp request and response headers are serialized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TimestampFormatHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        public virtual Task<TimestampFormatHeadersResponse> TimestampFormatHeadersAsync(TimestampFormatHeadersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TimestampFormatHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TimestampFormatHeadersResponseUnmarshaller.Instance;

            return InvokeAsync<TimestampFormatHeadersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnitInputAndOutput

        internal virtual UnitInputAndOutputResponse UnitInputAndOutput(UnitInputAndOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnitInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnitInputAndOutputResponseUnmarshaller.Instance;

            return Invoke<UnitInputAndOutputResponse>(request, options);
        }



        /// <summary>
        /// This test is similar to NoInputAndNoOutput, but uses explicit Unit types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnitInputAndOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnitInputAndOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/UnitInputAndOutput">REST API Reference for UnitInputAndOutput Operation</seealso>
        public virtual Task<UnitInputAndOutputResponse> UnitInputAndOutputAsync(UnitInputAndOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnitInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnitInputAndOutputResponseUnmarshaller.Instance;

            return InvokeAsync<UnitInputAndOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}