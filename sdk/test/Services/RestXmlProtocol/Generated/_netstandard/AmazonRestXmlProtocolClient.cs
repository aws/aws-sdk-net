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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RestXmlProtocol.Model;
using Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations;
using Amazon.RestXmlProtocol.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RestXmlProtocol
{
    /// <summary>
    /// <para>Implementation for accessing RestXmlProtocol</para>
    ///
    /// A REST XML service that sends XML requests and responses.
    /// </summary>
    public partial class AmazonRestXmlProtocolClient : AmazonServiceClient, IAmazonRestXmlProtocol
    {
        private static IServiceMetadata serviceMetadata = new AmazonRestXmlProtocolMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with the credentials loaded from the application's
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
        public AmazonRestXmlProtocolClient()
            : base(new AmazonRestXmlProtocolConfig()) { }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with the credentials loaded from the application's
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
        public AmazonRestXmlProtocolClient(RegionEndpoint region)
            : base(new AmazonRestXmlProtocolConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRestXmlProtocolClient Configuration Object</param>
        public AmazonRestXmlProtocolClient(AmazonRestXmlProtocolConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRestXmlProtocolClient(AWSCredentials credentials)
            : this(credentials, new AmazonRestXmlProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXmlProtocolClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRestXmlProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with AWS Credentials and an
        /// AmazonRestXmlProtocolClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRestXmlProtocolClient Configuration Object</param>
        public AmazonRestXmlProtocolClient(AWSCredentials credentials, AmazonRestXmlProtocolConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRestXmlProtocolClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestXmlProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXmlProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestXmlProtocolConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestXmlProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRestXmlProtocolClient Configuration Object</param>
        public AmazonRestXmlProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRestXmlProtocolConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRestXmlProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestXmlProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXmlProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestXmlProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestXmlProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRestXmlProtocolClient Configuration Object</param>
        public AmazonRestXmlProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRestXmlProtocolConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRestXmlProtocolAuthSchemeHandler());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the AllQueryStringTypes service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        public virtual Task<AllQueryStringTypesResponse> AllQueryStringTypesAsync(AllQueryStringTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AllQueryStringTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllQueryStringTypesResponseUnmarshaller.Instance;

            return InvokeAsync<AllQueryStringTypesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BodyWithXmlName

        internal virtual BodyWithXmlNameResponse BodyWithXmlName(BodyWithXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BodyWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BodyWithXmlNameResponseUnmarshaller.Instance;

            return Invoke<BodyWithXmlNameResponse>(request, options);
        }



        /// <summary>
        /// The following example serializes a body that uses an XML name, changing the wrapper
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BodyWithXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BodyWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/BodyWithXmlName">REST API Reference for BodyWithXmlName Operation</seealso>
        public virtual Task<BodyWithXmlNameResponse> BodyWithXmlNameAsync(BodyWithXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BodyWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BodyWithXmlNameResponseUnmarshaller.Instance;

            return InvokeAsync<BodyWithXmlNameResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ConstantAndVariableQueryString

        internal virtual ConstantAndVariableQueryStringResponse ConstantAndVariableQueryString(ConstantAndVariableQueryStringRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the ConstantAndVariableQueryString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        public virtual Task<ConstantAndVariableQueryStringResponse> ConstantAndVariableQueryStringAsync(ConstantAndVariableQueryStringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConstantAndVariableQueryStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConstantAndVariableQueryStringResponseUnmarshaller.Instance;

            return InvokeAsync<ConstantAndVariableQueryStringResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ConstantQueryString

        internal virtual ConstantQueryStringResponse ConstantQueryString(ConstantQueryStringRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the ConstantQueryString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        public virtual Task<ConstantQueryStringResponse> ConstantQueryStringAsync(ConstantQueryStringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConstantQueryStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConstantQueryStringResponseUnmarshaller.Instance;

            return InvokeAsync<ConstantQueryStringResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ContentTypeParameters

        internal virtual ContentTypeParametersResponse ContentTypeParameters(ContentTypeParametersRequest request)
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
        /// <returns>The response from the ContentTypeParameters service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
        public virtual Task<ContentTypeParametersResponse> ContentTypeParametersAsync(ContentTypeParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ContentTypeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContentTypeParametersResponseUnmarshaller.Instance;

            return InvokeAsync<ContentTypeParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DatetimeOffsets

        internal virtual DatetimeOffsetsResponse DatetimeOffsets(DatetimeOffsetsRequest request)
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
        /// <returns>The response from the DatetimeOffsets service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual Task<DatetimeOffsetsResponse> DatetimeOffsetsAsync(DatetimeOffsetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DatetimeOffsetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DatetimeOffsetsResponseUnmarshaller.Instance;

            return InvokeAsync<DatetimeOffsetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EmptyInputAndEmptyOutput

        internal virtual EmptyInputAndEmptyOutputResponse EmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        public virtual Task<EmptyInputAndEmptyOutputResponse> EmptyInputAndEmptyOutputAsync(EmptyInputAndEmptyOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyInputAndEmptyOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;

            return InvokeAsync<EmptyInputAndEmptyOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EndpointOperation

        internal virtual EndpointOperationResponse EndpointOperation(EndpointOperationRequest request)
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
        /// <returns>The response from the EndpointOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual Task<EndpointOperationResponse> EndpointOperationAsync(EndpointOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointOperationResponseUnmarshaller.Instance;

            return InvokeAsync<EndpointOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EndpointWithHostLabelHeaderOperation

        internal virtual EndpointWithHostLabelHeaderOperationResponse EndpointWithHostLabelHeaderOperation(EndpointWithHostLabelHeaderOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelHeaderOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelHeaderOperationResponseUnmarshaller.Instance;

            return Invoke<EndpointWithHostLabelHeaderOperationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelHeaderOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelHeaderOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelHeaderOperation">REST API Reference for EndpointWithHostLabelHeaderOperation Operation</seealso>
        public virtual Task<EndpointWithHostLabelHeaderOperationResponse> EndpointWithHostLabelHeaderOperationAsync(EndpointWithHostLabelHeaderOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelHeaderOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelHeaderOperationResponseUnmarshaller.Instance;

            return InvokeAsync<EndpointWithHostLabelHeaderOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EndpointWithHostLabelOperation

        internal virtual EndpointWithHostLabelOperationResponse EndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request)
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
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual Task<EndpointWithHostLabelOperationResponse> EndpointWithHostLabelOperationAsync(EndpointWithHostLabelOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelOperationResponseUnmarshaller.Instance;

            return InvokeAsync<EndpointWithHostLabelOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  FlattenedXmlMap

        internal virtual FlattenedXmlMapResponse FlattenedXmlMap(FlattenedXmlMapRequest request)
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
        /// <returns>The response from the FlattenedXmlMap service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        public virtual Task<FlattenedXmlMapResponse> FlattenedXmlMapAsync(FlattenedXmlMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapResponseUnmarshaller.Instance;

            return InvokeAsync<FlattenedXmlMapResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  FlattenedXmlMapWithXmlName

        internal virtual FlattenedXmlMapWithXmlNameResponse FlattenedXmlMapWithXmlName(FlattenedXmlMapWithXmlNameRequest request)
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
        /// <returns>The response from the FlattenedXmlMapWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        public virtual Task<FlattenedXmlMapWithXmlNameResponse> FlattenedXmlMapWithXmlNameAsync(FlattenedXmlMapWithXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNameResponseUnmarshaller.Instance;

            return InvokeAsync<FlattenedXmlMapWithXmlNameResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  FlattenedXmlMapWithXmlNamespace

        internal virtual FlattenedXmlMapWithXmlNamespaceResponse FlattenedXmlMapWithXmlNamespace(FlattenedXmlMapWithXmlNamespaceRequest request)
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
        /// <returns>The response from the FlattenedXmlMapWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        public virtual Task<FlattenedXmlMapWithXmlNamespaceResponse> FlattenedXmlMapWithXmlNamespaceAsync(FlattenedXmlMapWithXmlNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<FlattenedXmlMapWithXmlNamespaceResponse>(request, options, cancellationToken);
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
        /// <returns>The response from the FractionalSeconds service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
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
        /// InvalidGreeting error.</li> <li>A BadRequest error.</li> </ol> 
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
        /// <returns>The response from the GreetingWithErrors service method, as returned by RestXmlProtocol.</returns>
        /// <exception cref="Amazon.RestXmlProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RestXmlProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual Task<GreetingWithErrorsResponse> GreetingWithErrorsAsync(GreetingWithErrorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GreetingWithErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;

            return InvokeAsync<GreetingWithErrorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpEmptyPrefixHeaders

        internal virtual HttpEmptyPrefixHeadersResponse HttpEmptyPrefixHeaders(HttpEmptyPrefixHeadersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpEmptyPrefixHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpEmptyPrefixHeadersResponseUnmarshaller.Instance;

            return Invoke<HttpEmptyPrefixHeadersResponse>(request, options);
        }



        /// <summary>
        /// Clients that perform this test extract all headers from the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEmptyPrefixHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpEmptyPrefixHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEmptyPrefixHeaders">REST API Reference for HttpEmptyPrefixHeaders Operation</seealso>
        public virtual Task<HttpEmptyPrefixHeadersResponse> HttpEmptyPrefixHeadersAsync(HttpEmptyPrefixHeadersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpEmptyPrefixHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpEmptyPrefixHeadersResponseUnmarshaller.Instance;

            return InvokeAsync<HttpEmptyPrefixHeadersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpEnumPayload

        internal virtual HttpEnumPayloadResponse HttpEnumPayload(HttpEnumPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the HttpEnumPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        public virtual Task<HttpEnumPayloadResponse> HttpEnumPayloadAsync(HttpEnumPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpEnumPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpEnumPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<HttpEnumPayloadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpPayloadTraits

        internal virtual HttpPayloadTraitsResponse HttpPayloadTraits(HttpPayloadTraitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadTraitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadTraitsResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadTraitsResponse>(request, options);
        }



        /// <summary>
        /// This example serializes a blob shape in the payload.
        /// 
        ///  
        /// <para>
        /// In this example, no XML document is synthesized because the payload is not a structure
        /// or a union type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadTraits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadTraits service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        public virtual Task<HttpPayloadTraitsResponse> HttpPayloadTraitsAsync(HttpPayloadTraitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadTraitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadTraitsResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPayloadTraitsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpPayloadWithMemberXmlName

        internal virtual HttpPayloadWithMemberXmlNameResponse HttpPayloadWithMemberXmlName(HttpPayloadWithMemberXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithMemberXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithMemberXmlNameResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithMemberXmlNameResponse>(request, options);
        }



        /// <summary>
        /// The following example serializes a payload that uses an XML name on the member, changing
        /// the wrapper name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithMemberXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithMemberXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithMemberXmlName">REST API Reference for HttpPayloadWithMemberXmlName Operation</seealso>
        public virtual Task<HttpPayloadWithMemberXmlNameResponse> HttpPayloadWithMemberXmlNameAsync(HttpPayloadWithMemberXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithMemberXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithMemberXmlNameResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPayloadWithMemberXmlNameResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpPayloadWithStructure

        internal virtual HttpPayloadWithStructureResponse HttpPayloadWithStructure(HttpPayloadWithStructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the HttpPayloadWithStructure service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        public virtual Task<HttpPayloadWithStructureResponse> HttpPayloadWithStructureAsync(HttpPayloadWithStructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithStructureResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPayloadWithStructureResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpPayloadWithUnion

        internal virtual HttpPayloadWithUnionResponse HttpPayloadWithUnion(HttpPayloadWithUnionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the HttpPayloadWithUnion service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        public virtual Task<HttpPayloadWithUnionResponse> HttpPayloadWithUnionAsync(HttpPayloadWithUnionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithUnionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithUnionResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPayloadWithUnionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpPayloadWithXmlName

        internal virtual HttpPayloadWithXmlNameResponse HttpPayloadWithXmlName(HttpPayloadWithXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNameResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithXmlNameResponse>(request, options);
        }



        /// <summary>
        /// The following example serializes a payload that uses an XML name, changing the wrapper
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlName">REST API Reference for HttpPayloadWithXmlName Operation</seealso>
        public virtual Task<HttpPayloadWithXmlNameResponse> HttpPayloadWithXmlNameAsync(HttpPayloadWithXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNameResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPayloadWithXmlNameResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpPayloadWithXmlNamespace

        internal virtual HttpPayloadWithXmlNamespaceResponse HttpPayloadWithXmlNamespace(HttpPayloadWithXmlNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNamespaceResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithXmlNamespaceResponse>(request, options);
        }



        /// <summary>
        /// The following example serializes a payload that uses an XML namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespace">REST API Reference for HttpPayloadWithXmlNamespace Operation</seealso>
        public virtual Task<HttpPayloadWithXmlNamespaceResponse> HttpPayloadWithXmlNamespaceAsync(HttpPayloadWithXmlNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPayloadWithXmlNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpPayloadWithXmlNamespaceAndPrefix

        internal virtual HttpPayloadWithXmlNamespaceAndPrefixResponse HttpPayloadWithXmlNamespaceAndPrefix(HttpPayloadWithXmlNamespaceAndPrefixRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNamespaceAndPrefixRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNamespaceAndPrefixResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithXmlNamespaceAndPrefixResponse>(request, options);
        }



        /// <summary>
        /// The following example serializes a payload that uses an XML namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespaceAndPrefix service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlNamespaceAndPrefix service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespaceAndPrefix">REST API Reference for HttpPayloadWithXmlNamespaceAndPrefix Operation</seealso>
        public virtual Task<HttpPayloadWithXmlNamespaceAndPrefixResponse> HttpPayloadWithXmlNamespaceAndPrefixAsync(HttpPayloadWithXmlNamespaceAndPrefixRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNamespaceAndPrefixRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNamespaceAndPrefixResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPayloadWithXmlNamespaceAndPrefixResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpPrefixHeaders

        internal virtual HttpPrefixHeadersResponse HttpPrefixHeaders(HttpPrefixHeadersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the HttpPrefixHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        public virtual Task<HttpPrefixHeadersResponse> HttpPrefixHeadersAsync(HttpPrefixHeadersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPrefixHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPrefixHeadersResponseUnmarshaller.Instance;

            return InvokeAsync<HttpPrefixHeadersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpRequestWithFloatLabels

        internal virtual HttpRequestWithFloatLabelsResponse HttpRequestWithFloatLabels(HttpRequestWithFloatLabelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the HttpRequestWithFloatLabels service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        public virtual Task<HttpRequestWithFloatLabelsResponse> HttpRequestWithFloatLabelsAsync(HttpRequestWithFloatLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithFloatLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithFloatLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<HttpRequestWithFloatLabelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpRequestWithGreedyLabelInPath

        internal virtual HttpRequestWithGreedyLabelInPathResponse HttpRequestWithGreedyLabelInPath(HttpRequestWithGreedyLabelInPathRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the HttpRequestWithGreedyLabelInPath service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        public virtual Task<HttpRequestWithGreedyLabelInPathResponse> HttpRequestWithGreedyLabelInPathAsync(HttpRequestWithGreedyLabelInPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithGreedyLabelInPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithGreedyLabelInPathResponseUnmarshaller.Instance;

            return InvokeAsync<HttpRequestWithGreedyLabelInPathResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpRequestWithLabels

        internal virtual HttpRequestWithLabelsResponse HttpRequestWithLabels(HttpRequestWithLabelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the HttpRequestWithLabels service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        public virtual Task<HttpRequestWithLabelsResponse> HttpRequestWithLabelsAsync(HttpRequestWithLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<HttpRequestWithLabelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpRequestWithLabelsAndTimestampFormat

        internal virtual HttpRequestWithLabelsAndTimestampFormatResponse HttpRequestWithLabelsAndTimestampFormat(HttpRequestWithLabelsAndTimestampFormatRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the HttpRequestWithLabelsAndTimestampFormat service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        public virtual Task<HttpRequestWithLabelsAndTimestampFormatResponse> HttpRequestWithLabelsAndTimestampFormatAsync(HttpRequestWithLabelsAndTimestampFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithLabelsAndTimestampFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithLabelsAndTimestampFormatResponseUnmarshaller.Instance;

            return InvokeAsync<HttpRequestWithLabelsAndTimestampFormatResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpResponseCode

        internal virtual HttpResponseCodeResponse HttpResponseCode(HttpResponseCodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the HttpResponseCode service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        public virtual Task<HttpResponseCodeResponse> HttpResponseCodeAsync(HttpResponseCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpResponseCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpResponseCodeResponseUnmarshaller.Instance;

            return InvokeAsync<HttpResponseCodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpStringPayload

        internal virtual HttpStringPayloadResponse HttpStringPayload(HttpStringPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the HttpStringPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        public virtual Task<HttpStringPayloadResponse> HttpStringPayloadAsync(HttpStringPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpStringPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpStringPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<HttpStringPayloadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  IgnoreQueryParamsInResponse

        internal virtual IgnoreQueryParamsInResponseResponse IgnoreQueryParamsInResponse(IgnoreQueryParamsInResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the IgnoreQueryParamsInResponse service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        public virtual Task<IgnoreQueryParamsInResponseResponse> IgnoreQueryParamsInResponseAsync(IgnoreQueryParamsInResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IgnoreQueryParamsInResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IgnoreQueryParamsInResponseResponseUnmarshaller.Instance;

            return InvokeAsync<IgnoreQueryParamsInResponseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  InputAndOutputWithHeaders

        internal virtual InputAndOutputWithHeadersResponse InputAndOutputWithHeaders(InputAndOutputWithHeadersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the InputAndOutputWithHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        public virtual Task<InputAndOutputWithHeadersResponse> InputAndOutputWithHeadersAsync(InputAndOutputWithHeadersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InputAndOutputWithHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InputAndOutputWithHeadersResponseUnmarshaller.Instance;

            return InvokeAsync<InputAndOutputWithHeadersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NestedXmlMaps

        internal virtual NestedXmlMapsResponse NestedXmlMaps(NestedXmlMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NestedXmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NestedXmlMapsResponseUnmarshaller.Instance;

            return Invoke<NestedXmlMapsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NestedXmlMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NestedXmlMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMaps">REST API Reference for NestedXmlMaps Operation</seealso>
        public virtual Task<NestedXmlMapsResponse> NestedXmlMapsAsync(NestedXmlMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NestedXmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NestedXmlMapsResponseUnmarshaller.Instance;

            return InvokeAsync<NestedXmlMapsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NestedXmlMapWithXmlName

        internal virtual NestedXmlMapWithXmlNameResponse NestedXmlMapWithXmlName(NestedXmlMapWithXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NestedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NestedXmlMapWithXmlNameResponseUnmarshaller.Instance;

            return Invoke<NestedXmlMapWithXmlNameResponse>(request, options);
        }



        /// <summary>
        /// Nested Xml Maps with key/values with @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NestedXmlMapWithXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NestedXmlMapWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMapWithXmlName">REST API Reference for NestedXmlMapWithXmlName Operation</seealso>
        public virtual Task<NestedXmlMapWithXmlNameResponse> NestedXmlMapWithXmlNameAsync(NestedXmlMapWithXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NestedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NestedXmlMapWithXmlNameResponseUnmarshaller.Instance;

            return InvokeAsync<NestedXmlMapWithXmlNameResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NoInputAndNoOutput

        internal virtual NoInputAndNoOutputResponse NoInputAndNoOutput(NoInputAndNoOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        public virtual Task<NoInputAndNoOutputResponse> NoInputAndNoOutputAsync(NoInputAndNoOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndNoOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndNoOutputResponseUnmarshaller.Instance;

            return InvokeAsync<NoInputAndNoOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NoInputAndOutput

        internal virtual NoInputAndOutputResponse NoInputAndOutput(NoInputAndOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the NoInputAndOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual Task<NoInputAndOutputResponse> NoInputAndOutputAsync(NoInputAndOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;

            return InvokeAsync<NoInputAndOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NullAndEmptyHeadersClient

        internal virtual NullAndEmptyHeadersClientResponse NullAndEmptyHeadersClient(NullAndEmptyHeadersClientRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersClientResponseUnmarshaller.Instance;

            return Invoke<NullAndEmptyHeadersClientResponse>(request, options);
        }



        /// <summary>
        /// Null headers are not sent over the wire, empty headers are serialized to &quot;&quot;
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NullAndEmptyHeadersClient service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        public virtual Task<NullAndEmptyHeadersClientResponse> NullAndEmptyHeadersClientAsync(NullAndEmptyHeadersClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersClientResponseUnmarshaller.Instance;

            return InvokeAsync<NullAndEmptyHeadersClientResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NullAndEmptyHeadersServer

        internal virtual NullAndEmptyHeadersServerResponse NullAndEmptyHeadersServer(NullAndEmptyHeadersServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersServerResponseUnmarshaller.Instance;

            return Invoke<NullAndEmptyHeadersServerResponse>(request, options);
        }



        /// <summary>
        /// Null headers are not sent over the wire, empty headers are serialized to &quot;&quot;
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NullAndEmptyHeadersServer service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        public virtual Task<NullAndEmptyHeadersServerResponse> NullAndEmptyHeadersServerAsync(NullAndEmptyHeadersServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersServerResponseUnmarshaller.Instance;

            return InvokeAsync<NullAndEmptyHeadersServerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  OmitsNullSerializesEmptyString

        internal virtual OmitsNullSerializesEmptyStringResponse OmitsNullSerializesEmptyString(OmitsNullSerializesEmptyStringRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the OmitsNullSerializesEmptyString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        public virtual Task<OmitsNullSerializesEmptyStringResponse> OmitsNullSerializesEmptyStringAsync(OmitsNullSerializesEmptyStringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OmitsNullSerializesEmptyStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OmitsNullSerializesEmptyStringResponseUnmarshaller.Instance;

            return InvokeAsync<OmitsNullSerializesEmptyStringResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutWithContentEncoding

        internal virtual PutWithContentEncodingResponse PutWithContentEncoding(PutWithContentEncodingRequest request)
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
        /// <returns>The response from the PutWithContentEncoding service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual Task<PutWithContentEncodingResponse> PutWithContentEncodingAsync(PutWithContentEncodingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWithContentEncodingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWithContentEncodingResponseUnmarshaller.Instance;

            return InvokeAsync<PutWithContentEncodingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryIdempotencyTokenAutoFill

        internal virtual QueryIdempotencyTokenAutoFillResponse QueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request)
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
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        public virtual Task<QueryIdempotencyTokenAutoFillResponse> QueryIdempotencyTokenAutoFillAsync(QueryIdempotencyTokenAutoFillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIdempotencyTokenAutoFillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIdempotencyTokenAutoFillResponseUnmarshaller.Instance;

            return InvokeAsync<QueryIdempotencyTokenAutoFillResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryParamsAsStringListMap

        internal virtual QueryParamsAsStringListMapResponse QueryParamsAsStringListMap(QueryParamsAsStringListMapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the QueryParamsAsStringListMap service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        public virtual Task<QueryParamsAsStringListMapResponse> QueryParamsAsStringListMapAsync(QueryParamsAsStringListMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryParamsAsStringListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryParamsAsStringListMapResponseUnmarshaller.Instance;

            return InvokeAsync<QueryParamsAsStringListMapResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryPrecedence

        internal virtual QueryPrecedenceResponse QueryPrecedence(QueryPrecedenceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the QueryPrecedence service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        public virtual Task<QueryPrecedenceResponse> QueryPrecedenceAsync(QueryPrecedenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryPrecedenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryPrecedenceResponseUnmarshaller.Instance;

            return InvokeAsync<QueryPrecedenceResponse>(request, options, cancellationToken);
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
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual Task<SimpleScalarPropertiesResponse> SimpleScalarPropertiesAsync(SimpleScalarPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<SimpleScalarPropertiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TimestampFormatHeaders

        internal virtual TimestampFormatHeadersResponse TimestampFormatHeaders(TimestampFormatHeadersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TimestampFormatHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TimestampFormatHeadersResponseUnmarshaller.Instance;

            return Invoke<TimestampFormatHeadersResponse>(request, options);
        }



        /// <summary>
        /// The example tests how timestamp request and response headers are serialized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TimestampFormatHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        public virtual Task<TimestampFormatHeadersResponse> TimestampFormatHeadersAsync(TimestampFormatHeadersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TimestampFormatHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TimestampFormatHeadersResponseUnmarshaller.Instance;

            return InvokeAsync<TimestampFormatHeadersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlAttributes

        internal virtual XmlAttributesResponse XmlAttributes(XmlAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlAttributesResponseUnmarshaller.Instance;

            return Invoke<XmlAttributesResponse>(request, options);
        }



        /// <summary>
        /// This example serializes an XML attributes on synthesized document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlAttributes service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributes">REST API Reference for XmlAttributes Operation</seealso>
        public virtual Task<XmlAttributesResponse> XmlAttributesAsync(XmlAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<XmlAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlAttributesOnPayload

        internal virtual XmlAttributesOnPayloadResponse XmlAttributesOnPayload(XmlAttributesOnPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlAttributesOnPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlAttributesOnPayloadResponseUnmarshaller.Instance;

            return Invoke<XmlAttributesOnPayloadResponse>(request, options);
        }



        /// <summary>
        /// This example serializes an XML attributes on a document targeted by httpPayload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributesOnPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlAttributesOnPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributesOnPayload">REST API Reference for XmlAttributesOnPayload Operation</seealso>
        public virtual Task<XmlAttributesOnPayloadResponse> XmlAttributesOnPayloadAsync(XmlAttributesOnPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlAttributesOnPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlAttributesOnPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<XmlAttributesOnPayloadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlBlobs

        internal virtual XmlBlobsResponse XmlBlobs(XmlBlobsRequest request)
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
        /// <returns>The response from the XmlBlobs service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        public virtual Task<XmlBlobsResponse> XmlBlobsAsync(XmlBlobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlBlobsResponseUnmarshaller.Instance;

            return InvokeAsync<XmlBlobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlEmptyBlobs

        internal virtual XmlEmptyBlobsResponse XmlEmptyBlobs(XmlEmptyBlobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyBlobsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyBlobsResponse>(request, options);
        }



        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyBlobs service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        public virtual Task<XmlEmptyBlobsResponse> XmlEmptyBlobsAsync(XmlEmptyBlobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyBlobsResponseUnmarshaller.Instance;

            return InvokeAsync<XmlEmptyBlobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlEmptyLists

        internal virtual XmlEmptyListsResponse XmlEmptyLists(XmlEmptyListsRequest request)
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
        /// <returns>The response from the XmlEmptyLists service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        public virtual Task<XmlEmptyListsResponse> XmlEmptyListsAsync(XmlEmptyListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyListsResponseUnmarshaller.Instance;

            return InvokeAsync<XmlEmptyListsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlEmptyMaps

        internal virtual XmlEmptyMapsResponse XmlEmptyMaps(XmlEmptyMapsRequest request)
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
        /// <returns>The response from the XmlEmptyMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        public virtual Task<XmlEmptyMapsResponse> XmlEmptyMapsAsync(XmlEmptyMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyMapsResponseUnmarshaller.Instance;

            return InvokeAsync<XmlEmptyMapsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlEmptyStrings

        internal virtual XmlEmptyStringsResponse XmlEmptyStrings(XmlEmptyStringsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyStringsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyStringsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyStringsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyStrings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyStrings service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyStrings">REST API Reference for XmlEmptyStrings Operation</seealso>
        public virtual Task<XmlEmptyStringsResponse> XmlEmptyStringsAsync(XmlEmptyStringsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyStringsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyStringsResponseUnmarshaller.Instance;

            return InvokeAsync<XmlEmptyStringsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlEnums

        internal virtual XmlEnumsResponse XmlEnums(XmlEnumsRequest request)
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
        /// <returns>The response from the XmlEnums service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        public virtual Task<XmlEnumsResponse> XmlEnumsAsync(XmlEnumsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEnumsResponseUnmarshaller.Instance;

            return InvokeAsync<XmlEnumsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlIntEnums

        internal virtual XmlIntEnumsResponse XmlIntEnums(XmlIntEnumsRequest request)
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
        /// <returns>The response from the XmlIntEnums service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        public virtual Task<XmlIntEnumsResponse> XmlIntEnumsAsync(XmlIntEnumsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlIntEnumsResponseUnmarshaller.Instance;

            return InvokeAsync<XmlIntEnumsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlLists

        internal virtual XmlListsResponse XmlLists(XmlListsRequest request)
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
        /// XML lists with @xmlName.</li> <li>Flattened XML lists with @xmlNamespace.</li> <li>Lists
        /// of structures.</li> <li>Flattened XML list of structures</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlLists service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlLists">REST API Reference for XmlLists Operation</seealso>
        public virtual Task<XmlListsResponse> XmlListsAsync(XmlListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlListsResponseUnmarshaller.Instance;

            return InvokeAsync<XmlListsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlMaps

        internal virtual XmlMapsResponse XmlMaps(XmlMapsRequest request)
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
        /// <returns>The response from the XmlMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        public virtual Task<XmlMapsResponse> XmlMapsAsync(XmlMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsResponseUnmarshaller.Instance;

            return InvokeAsync<XmlMapsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlMapsXmlName

        internal virtual XmlMapsXmlNameResponse XmlMapsXmlName(XmlMapsXmlNameRequest request)
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
        /// <returns>The response from the XmlMapsXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        public virtual Task<XmlMapsXmlNameResponse> XmlMapsXmlNameAsync(XmlMapsXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsXmlNameResponseUnmarshaller.Instance;

            return InvokeAsync<XmlMapsXmlNameResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlMapWithXmlNamespace

        internal virtual XmlMapWithXmlNamespaceResponse XmlMapWithXmlNamespace(XmlMapWithXmlNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapWithXmlNamespaceResponseUnmarshaller.Instance;

            return Invoke<XmlMapWithXmlNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapWithXmlNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlMapWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapWithXmlNamespace">REST API Reference for XmlMapWithXmlNamespace Operation</seealso>
        public virtual Task<XmlMapWithXmlNamespaceResponse> XmlMapWithXmlNamespaceAsync(XmlMapWithXmlNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapWithXmlNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<XmlMapWithXmlNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlNamespaces

        internal virtual XmlNamespacesResponse XmlNamespaces(XmlNamespacesRequest request)
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
        /// <returns>The response from the XmlNamespaces service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        public virtual Task<XmlNamespacesResponse> XmlNamespacesAsync(XmlNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlNamespacesResponseUnmarshaller.Instance;

            return InvokeAsync<XmlNamespacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  XmlTimestamps

        internal virtual XmlTimestampsResponse XmlTimestamps(XmlTimestampsRequest request)
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
        /// <returns>The response from the XmlTimestamps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
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