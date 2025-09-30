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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.JSONRPC10.Model;
using Amazon.JSONRPC10.Model.Internal.MarshallTransformations;
using Amazon.JSONRPC10.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.JSONRPC10
{
    /// <summary>
    /// <para>Implementation for accessing JSONRPC10</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonJSONRPC10Client : AmazonServiceClient, IAmazonJSONRPC10
    {
        private static IServiceMetadata serviceMetadata = new AmazonJSONRPC10Metadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with the credentials loaded from the application's
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
        public AmazonJSONRPC10Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonJSONRPC10Config()) { }

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with the credentials loaded from the application's
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
        public AmazonJSONRPC10Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonJSONRPC10Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonJSONRPC10Client Configuration Object</param>
        public AmazonJSONRPC10Client(AmazonJSONRPC10Config config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonJSONRPC10Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonJSONRPC10Client(AWSCredentials credentials)
            : this(credentials, new AmazonJSONRPC10Config())
        {
        }

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonJSONRPC10Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonJSONRPC10Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with AWS Credentials and an
        /// AmazonJSONRPC10Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonJSONRPC10Client Configuration Object</param>
        public AmazonJSONRPC10Client(AWSCredentials credentials, AmazonJSONRPC10Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonJSONRPC10Config())
        {
        }

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonJSONRPC10Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonJSONRPC10Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonJSONRPC10Client Configuration Object</param>
        public AmazonJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonJSONRPC10Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonJSONRPC10Config())
        {
        }

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonJSONRPC10Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonJSONRPC10Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonJSONRPC10Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonJSONRPC10Client Configuration Object</param>
        public AmazonJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonJSONRPC10Config clientConfig)
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


        #region  ContentTypeParameters

        /// <summary>
        /// The example tests how servers must support requests containing a <c>Content-Type</c>
        /// header with parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContentTypeParameters service method.</param>
        /// 
        /// <returns>The response from the ContentTypeParameters service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
        public virtual ContentTypeParametersResponse ContentTypeParameters(ContentTypeParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ContentTypeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContentTypeParametersResponseUnmarshaller.Instance;

            return Invoke<ContentTypeParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ContentTypeParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ContentTypeParameters operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndContentTypeParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
        public virtual IAsyncResult BeginContentTypeParameters(ContentTypeParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ContentTypeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContentTypeParametersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ContentTypeParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginContentTypeParameters.</param>
        /// 
        /// <returns>Returns a  ContentTypeParametersResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
        public virtual ContentTypeParametersResponse EndContentTypeParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<ContentTypeParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  EmptyInputAndEmptyOutput

        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has an empty input and empty output structure
        /// that reuses the same shape. While this should be rare, code generators must support
        /// this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput service method.</param>
        /// 
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        public virtual EmptyInputAndEmptyOutputResponse EmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyInputAndEmptyOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;

            return Invoke<EmptyInputAndEmptyOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EmptyInputAndEmptyOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyInputAndEmptyOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        public virtual IAsyncResult BeginEmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyInputAndEmptyOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EmptyInputAndEmptyOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEmptyInputAndEmptyOutput.</param>
        /// 
        /// <returns>Returns a  EmptyInputAndEmptyOutputResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        public virtual EmptyInputAndEmptyOutputResponse EndEmptyInputAndEmptyOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<EmptyInputAndEmptyOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  EndpointOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual EndpointOperationResponse EndpointOperation(EndpointOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointOperationResponseUnmarshaller.Instance;

            return Invoke<EndpointOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual IAsyncResult BeginEndpointOperation(EndpointOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointOperation.</param>
        /// 
        /// <returns>Returns a  EndpointOperationResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual EndpointOperationResponse EndEndpointOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<EndpointOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  EndpointWithHostLabelOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual EndpointWithHostLabelOperationResponse EndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelOperationResponseUnmarshaller.Instance;

            return Invoke<EndpointWithHostLabelOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual IAsyncResult BeginEndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointWithHostLabelOperation.</param>
        /// 
        /// <returns>Returns a  EndpointWithHostLabelOperationResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual EndpointWithHostLabelOperationResponse EndEndpointWithHostLabelOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<EndpointWithHostLabelOperationResponse>(asyncResult);
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
        /// <returns>The response from the GreetingWithErrors service method, as returned by JSONRPC10.</returns>
        /// <exception cref="Amazon.JSONRPC10.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.JSONRPC10.Model.FooErrorException">
        /// This error has test cases that test some of the dark corners of Amazon service framework
        /// history. It should only be implemented by clients.
        /// </exception>
        /// <exception cref="Amazon.JSONRPC10.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GreetingWithErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;

            return Invoke<GreetingWithErrorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGreetingWithErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual IAsyncResult BeginGreetingWithErrors(GreetingWithErrorsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GreetingWithErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGreetingWithErrors.</param>
        /// 
        /// <returns>Returns a  GreetingWithErrorsResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual GreetingWithErrorsResponse EndGreetingWithErrors(IAsyncResult asyncResult)
        {
            return EndInvoke<GreetingWithErrorsResponse>(asyncResult);
        }

        #endregion
        
        #region  HostWithPathOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// 
        /// <returns>The response from the HostWithPathOperation service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual HostWithPathOperationResponse HostWithPathOperation(HostWithPathOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HostWithPathOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HostWithPathOperationResponseUnmarshaller.Instance;

            return Invoke<HostWithPathOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHostWithPathOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual IAsyncResult BeginHostWithPathOperation(HostWithPathOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HostWithPathOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HostWithPathOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHostWithPathOperation.</param>
        /// 
        /// <returns>Returns a  HostWithPathOperationResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual HostWithPathOperationResponse EndHostWithPathOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<HostWithPathOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  JsonUnions

        /// <summary>
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions service method.</param>
        /// 
        /// <returns>The response from the JsonUnions service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        public virtual JsonUnionsResponse JsonUnions(JsonUnionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonUnionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonUnionsResponseUnmarshaller.Instance;

            return Invoke<JsonUnionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the JsonUnions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonUnions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        public virtual IAsyncResult BeginJsonUnions(JsonUnionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonUnionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonUnionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  JsonUnions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginJsonUnions.</param>
        /// 
        /// <returns>Returns a  JsonUnionsResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        public virtual JsonUnionsResponse EndJsonUnions(IAsyncResult asyncResult)
        {
            return EndInvoke<JsonUnionsResponse>(asyncResult);
        }

        #endregion
        
        #region  NoInputAndNoOutput

        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output. While this should
        /// be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        public virtual NoInputAndNoOutputResponse NoInputAndNoOutput(NoInputAndNoOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndNoOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndNoOutputResponseUnmarshaller.Instance;

            return Invoke<NoInputAndNoOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NoInputAndNoOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndNoOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        public virtual IAsyncResult BeginNoInputAndNoOutput(NoInputAndNoOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndNoOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndNoOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NoInputAndNoOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoInputAndNoOutput.</param>
        /// 
        /// <returns>Returns a  NoInputAndNoOutputResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        public virtual NoInputAndNoOutputResponse EndNoInputAndNoOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<NoInputAndNoOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  NoInputAndOutput

        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input and the output is empty. While
        /// this should be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndOutput service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual NoInputAndOutputResponse NoInputAndOutput(NoInputAndOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;

            return Invoke<NoInputAndOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NoInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual IAsyncResult BeginNoInputAndOutput(NoInputAndOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NoInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoInputAndOutput.</param>
        /// 
        /// <returns>Returns a  NoInputAndOutputResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual NoInputAndOutputResponse EndNoInputAndOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<NoInputAndOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  PutWithContentEncoding

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual PutWithContentEncodingResponse PutWithContentEncoding(PutWithContentEncodingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWithContentEncodingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWithContentEncodingResponseUnmarshaller.Instance;

            return Invoke<PutWithContentEncodingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWithContentEncoding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual IAsyncResult BeginPutWithContentEncoding(PutWithContentEncodingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWithContentEncodingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWithContentEncodingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutWithContentEncoding.</param>
        /// 
        /// <returns>Returns a  PutWithContentEncodingResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual PutWithContentEncodingResponse EndPutWithContentEncoding(IAsyncResult asyncResult)
        {
            return EndInvoke<PutWithContentEncodingResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryIncompatibleOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIncompatibleOperation service method.</param>
        /// 
        /// <returns>The response from the QueryIncompatibleOperation service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/QueryIncompatibleOperation">REST API Reference for QueryIncompatibleOperation Operation</seealso>
        public virtual QueryIncompatibleOperationResponse QueryIncompatibleOperation(QueryIncompatibleOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIncompatibleOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIncompatibleOperationResponseUnmarshaller.Instance;

            return Invoke<QueryIncompatibleOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryIncompatibleOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryIncompatibleOperation operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryIncompatibleOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/QueryIncompatibleOperation">REST API Reference for QueryIncompatibleOperation Operation</seealso>
        public virtual IAsyncResult BeginQueryIncompatibleOperation(QueryIncompatibleOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIncompatibleOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIncompatibleOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryIncompatibleOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryIncompatibleOperation.</param>
        /// 
        /// <returns>Returns a  QueryIncompatibleOperationResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/QueryIncompatibleOperation">REST API Reference for QueryIncompatibleOperation Operation</seealso>
        public virtual QueryIncompatibleOperationResponse EndQueryIncompatibleOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryIncompatibleOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  SimpleScalarProperties

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;

            return Invoke<SimpleScalarPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleScalarProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual IAsyncResult BeginSimpleScalarProperties(SimpleScalarPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimpleScalarProperties.</param>
        /// 
        /// <returns>Returns a  SimpleScalarPropertiesResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual SimpleScalarPropertiesResponse EndSimpleScalarProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<SimpleScalarPropertiesResponse>(asyncResult);
        }

        #endregion
        
    }
}