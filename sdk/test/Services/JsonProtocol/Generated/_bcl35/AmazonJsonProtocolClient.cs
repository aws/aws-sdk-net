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
using System.Collections.Generic;
using System.Net;

using Amazon.JsonProtocol.Model;
using Amazon.JsonProtocol.Model.Internal.MarshallTransformations;
using Amazon.JsonProtocol.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonJsonProtocolConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonJsonProtocolConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Initiates the asynchronous execution of the ContentTypeParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ContentTypeParameters operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndContentTypeParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
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
        /// <returns>Returns a  ContentTypeParametersResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
        public virtual ContentTypeParametersResponse EndContentTypeParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<ContentTypeParametersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DatetimeOffsets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDatetimeOffsets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual IAsyncResult BeginDatetimeOffsets(DatetimeOffsetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DatetimeOffsetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DatetimeOffsetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DatetimeOffsets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDatetimeOffsets.</param>
        /// 
        /// <returns>Returns a  DatetimeOffsetsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual DatetimeOffsetsResponse EndDatetimeOffsets(IAsyncResult asyncResult)
        {
            return EndInvoke<DatetimeOffsetsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the EmptyOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EmptyOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EmptyOperation">REST API Reference for EmptyOperation Operation</seealso>
        public virtual IAsyncResult BeginEmptyOperation(EmptyOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EmptyOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEmptyOperation.</param>
        /// 
        /// <returns>Returns a  EmptyOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EmptyOperation">REST API Reference for EmptyOperation Operation</seealso>
        public virtual EmptyOperationResponse EndEmptyOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<EmptyOperationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
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
        /// <returns>Returns a  EndpointOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
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
        /// Initiates the asynchronous execution of the EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
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
        /// <returns>Returns a  EndpointWithHostLabelOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual EndpointWithHostLabelOperationResponse EndEndpointWithHostLabelOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<EndpointWithHostLabelOperationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the FractionalSeconds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFractionalSeconds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        public virtual IAsyncResult BeginFractionalSeconds(FractionalSecondsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FractionalSecondsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FractionalSecondsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FractionalSeconds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFractionalSeconds.</param>
        /// 
        /// <returns>Returns a  FractionalSecondsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        public virtual FractionalSecondsResponse EndFractionalSeconds(IAsyncResult asyncResult)
        {
            return EndInvoke<FractionalSecondsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGreetingWithErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
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
        /// <returns>Returns a  GreetingWithErrorsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
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
        /// Initiates the asynchronous execution of the HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHostWithPathOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
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
        /// <returns>Returns a  HostWithPathOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual HostWithPathOperationResponse EndHostWithPathOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<HostWithPathOperationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the JsonEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonEnums operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        public virtual IAsyncResult BeginJsonEnums(JsonEnumsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonEnumsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  JsonEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginJsonEnums.</param>
        /// 
        /// <returns>Returns a  JsonEnumsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        public virtual JsonEnumsResponse EndJsonEnums(IAsyncResult asyncResult)
        {
            return EndInvoke<JsonEnumsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the JsonIntEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonIntEnums operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonIntEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonIntEnums">REST API Reference for JsonIntEnums Operation</seealso>
        public virtual IAsyncResult BeginJsonIntEnums(JsonIntEnumsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonIntEnumsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  JsonIntEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginJsonIntEnums.</param>
        /// 
        /// <returns>Returns a  JsonIntEnumsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonIntEnums">REST API Reference for JsonIntEnums Operation</seealso>
        public virtual JsonIntEnumsResponse EndJsonIntEnums(IAsyncResult asyncResult)
        {
            return EndInvoke<JsonIntEnumsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the JsonUnions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonUnions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
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
        /// <returns>Returns a  JsonUnionsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        public virtual JsonUnionsResponse EndJsonUnions(IAsyncResult asyncResult)
        {
            return EndInvoke<JsonUnionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the KitchenSinkOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the KitchenSinkOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndKitchenSinkOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/KitchenSinkOperation">REST API Reference for KitchenSinkOperation Operation</seealso>
        public virtual IAsyncResult BeginKitchenSinkOperation(KitchenSinkOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = KitchenSinkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = KitchenSinkOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  KitchenSinkOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginKitchenSinkOperation.</param>
        /// 
        /// <returns>Returns a  KitchenSinkOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/KitchenSinkOperation">REST API Reference for KitchenSinkOperation Operation</seealso>
        public virtual KitchenSinkOperationResponse EndKitchenSinkOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<KitchenSinkOperationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the NullOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NullOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNullOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/NullOperation">REST API Reference for NullOperation Operation</seealso>
        public virtual IAsyncResult BeginNullOperation(NullOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NullOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNullOperation.</param>
        /// 
        /// <returns>Returns a  NullOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/NullOperation">REST API Reference for NullOperation Operation</seealso>
        public virtual NullOperationResponse EndNullOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<NullOperationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the OperationWithOptionalInputOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OperationWithOptionalInputOutput operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOperationWithOptionalInputOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/OperationWithOptionalInputOutput">REST API Reference for OperationWithOptionalInputOutput Operation</seealso>
        public virtual IAsyncResult BeginOperationWithOptionalInputOutput(OperationWithOptionalInputOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OperationWithOptionalInputOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OperationWithOptionalInputOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  OperationWithOptionalInputOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOperationWithOptionalInputOutput.</param>
        /// 
        /// <returns>Returns a  OperationWithOptionalInputOutputResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/OperationWithOptionalInputOutput">REST API Reference for OperationWithOptionalInputOutput Operation</seealso>
        public virtual OperationWithOptionalInputOutputResponse EndOperationWithOptionalInputOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<OperationWithOptionalInputOutputResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutAndGetInlineDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAndGetInlineDocuments operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAndGetInlineDocuments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutAndGetInlineDocuments">REST API Reference for PutAndGetInlineDocuments Operation</seealso>
        public virtual IAsyncResult BeginPutAndGetInlineDocuments(PutAndGetInlineDocumentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAndGetInlineDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAndGetInlineDocumentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAndGetInlineDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAndGetInlineDocuments.</param>
        /// 
        /// <returns>Returns a  PutAndGetInlineDocumentsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutAndGetInlineDocuments">REST API Reference for PutAndGetInlineDocuments Operation</seealso>
        public virtual PutAndGetInlineDocumentsResponse EndPutAndGetInlineDocuments(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAndGetInlineDocumentsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWithContentEncoding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
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
        /// <returns>Returns a  PutWithContentEncodingResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual PutWithContentEncodingResponse EndPutWithContentEncoding(IAsyncResult asyncResult)
        {
            return EndInvoke<PutWithContentEncodingResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleScalarProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
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
        /// <returns>Returns a  SimpleScalarPropertiesResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual SimpleScalarPropertiesResponse EndSimpleScalarProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<SimpleScalarPropertiesResponse>(asyncResult);
        }

        #endregion
        
    }
}