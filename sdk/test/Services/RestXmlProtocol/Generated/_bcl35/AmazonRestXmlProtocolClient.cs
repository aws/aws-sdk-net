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
using System.Collections.Generic;
using System.Net;

using Amazon.RestXmlProtocol.Model;
using Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations;
using Amazon.RestXmlProtocol.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRestXmlProtocolConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRestXmlProtocolConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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

        /// <summary>
        /// This example uses all query string types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllQueryStringTypes service method.</param>
        /// 
        /// <returns>The response from the AllQueryStringTypes service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        public virtual AllQueryStringTypesResponse AllQueryStringTypes(AllQueryStringTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AllQueryStringTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllQueryStringTypesResponseUnmarshaller.Instance;

            return Invoke<AllQueryStringTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllQueryStringTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllQueryStringTypes operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllQueryStringTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        public virtual IAsyncResult BeginAllQueryStringTypes(AllQueryStringTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AllQueryStringTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllQueryStringTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AllQueryStringTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllQueryStringTypes.</param>
        /// 
        /// <returns>Returns a  AllQueryStringTypesResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        public virtual AllQueryStringTypesResponse EndAllQueryStringTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<AllQueryStringTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  BodyWithXmlName

        /// <summary>
        /// The following example serializes a body that uses an XML name, changing the wrapper
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BodyWithXmlName service method.</param>
        /// 
        /// <returns>The response from the BodyWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/BodyWithXmlName">REST API Reference for BodyWithXmlName Operation</seealso>
        public virtual BodyWithXmlNameResponse BodyWithXmlName(BodyWithXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BodyWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BodyWithXmlNameResponseUnmarshaller.Instance;

            return Invoke<BodyWithXmlNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BodyWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BodyWithXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBodyWithXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/BodyWithXmlName">REST API Reference for BodyWithXmlName Operation</seealso>
        public virtual IAsyncResult BeginBodyWithXmlName(BodyWithXmlNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BodyWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BodyWithXmlNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BodyWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBodyWithXmlName.</param>
        /// 
        /// <returns>Returns a  BodyWithXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/BodyWithXmlName">REST API Reference for BodyWithXmlName Operation</seealso>
        public virtual BodyWithXmlNameResponse EndBodyWithXmlName(IAsyncResult asyncResult)
        {
            return EndInvoke<BodyWithXmlNameResponse>(asyncResult);
        }

        #endregion
        
        #region  ConstantAndVariableQueryString

        /// <summary>
        /// This example uses fixed query string params and variable query string params. The
        /// fixed query string parameters and variable parameters must both be serialized (implementations
        /// may need to merge them together).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantAndVariableQueryString service method.</param>
        /// 
        /// <returns>The response from the ConstantAndVariableQueryString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        public virtual ConstantAndVariableQueryStringResponse ConstantAndVariableQueryString(ConstantAndVariableQueryStringRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConstantAndVariableQueryStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConstantAndVariableQueryStringResponseUnmarshaller.Instance;

            return Invoke<ConstantAndVariableQueryStringResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConstantAndVariableQueryString operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConstantAndVariableQueryString operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConstantAndVariableQueryString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        public virtual IAsyncResult BeginConstantAndVariableQueryString(ConstantAndVariableQueryStringRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConstantAndVariableQueryStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConstantAndVariableQueryStringResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConstantAndVariableQueryString operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConstantAndVariableQueryString.</param>
        /// 
        /// <returns>Returns a  ConstantAndVariableQueryStringResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        public virtual ConstantAndVariableQueryStringResponse EndConstantAndVariableQueryString(IAsyncResult asyncResult)
        {
            return EndInvoke<ConstantAndVariableQueryStringResponse>(asyncResult);
        }

        #endregion
        
        #region  ConstantQueryString

        /// <summary>
        /// This example uses a constant query string parameters and a label. This simply tests
        /// that labels and query string parameters are compatible. The fixed query string parameter
        /// named &quot;hello&quot; should in no way conflict with the label, <c>{hello}</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantQueryString service method.</param>
        /// 
        /// <returns>The response from the ConstantQueryString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        public virtual ConstantQueryStringResponse ConstantQueryString(ConstantQueryStringRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConstantQueryStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConstantQueryStringResponseUnmarshaller.Instance;

            return Invoke<ConstantQueryStringResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConstantQueryString operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConstantQueryString operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConstantQueryString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        public virtual IAsyncResult BeginConstantQueryString(ConstantQueryStringRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConstantQueryStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConstantQueryStringResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConstantQueryString operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConstantQueryString.</param>
        /// 
        /// <returns>Returns a  ConstantQueryStringResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        public virtual ConstantQueryStringResponse EndConstantQueryString(IAsyncResult asyncResult)
        {
            return EndInvoke<ConstantQueryStringResponse>(asyncResult);
        }

        #endregion
        
        #region  ContentTypeParameters

        /// <summary>
        /// The example tests how servers must support requests containing a <c>Content-Type</c>
        /// header with parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContentTypeParameters service method.</param>
        /// 
        /// <returns>The response from the ContentTypeParameters service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ContentTypeParameters operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndContentTypeParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
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
        /// <returns>Returns a  ContentTypeParametersResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
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
        /// <returns>The response from the DatetimeOffsets service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDatetimeOffsets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
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
        /// <returns>Returns a  DatetimeOffsetsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual DatetimeOffsetsResponse EndDatetimeOffsets(IAsyncResult asyncResult)
        {
            return EndInvoke<DatetimeOffsetsResponse>(asyncResult);
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
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyInputAndEmptyOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
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
        /// <returns>Returns a  EmptyInputAndEmptyOutputResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
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
        /// <returns>The response from the EndpointOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
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
        /// <returns>Returns a  EndpointOperationResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual EndpointOperationResponse EndEndpointOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<EndpointOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  EndpointWithHostLabelHeaderOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelHeaderOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelHeaderOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelHeaderOperation">REST API Reference for EndpointWithHostLabelHeaderOperation Operation</seealso>
        public virtual EndpointWithHostLabelHeaderOperationResponse EndpointWithHostLabelHeaderOperation(EndpointWithHostLabelHeaderOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelHeaderOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelHeaderOperationResponseUnmarshaller.Instance;

            return Invoke<EndpointWithHostLabelHeaderOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointWithHostLabelHeaderOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelHeaderOperation operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelHeaderOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelHeaderOperation">REST API Reference for EndpointWithHostLabelHeaderOperation Operation</seealso>
        public virtual IAsyncResult BeginEndpointWithHostLabelHeaderOperation(EndpointWithHostLabelHeaderOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelHeaderOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelHeaderOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointWithHostLabelHeaderOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointWithHostLabelHeaderOperation.</param>
        /// 
        /// <returns>Returns a  EndpointWithHostLabelHeaderOperationResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelHeaderOperation">REST API Reference for EndpointWithHostLabelHeaderOperation Operation</seealso>
        public virtual EndpointWithHostLabelHeaderOperationResponse EndEndpointWithHostLabelHeaderOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<EndpointWithHostLabelHeaderOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  EndpointWithHostLabelOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
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
        /// <returns>Returns a  EndpointWithHostLabelOperationResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual EndpointWithHostLabelOperationResponse EndEndpointWithHostLabelOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<EndpointWithHostLabelOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  FlattenedXmlMap

        /// <summary>
        /// Flattened maps
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMap service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        public virtual FlattenedXmlMapResponse FlattenedXmlMap(FlattenedXmlMapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapResponseUnmarshaller.Instance;

            return Invoke<FlattenedXmlMapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        public virtual IAsyncResult BeginFlattenedXmlMap(FlattenedXmlMapRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMap.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        public virtual FlattenedXmlMapResponse EndFlattenedXmlMap(IAsyncResult asyncResult)
        {
            return EndInvoke<FlattenedXmlMapResponse>(asyncResult);
        }

        #endregion
        
        #region  FlattenedXmlMapWithXmlName

        /// <summary>
        /// Flattened maps with @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        public virtual FlattenedXmlMapWithXmlNameResponse FlattenedXmlMapWithXmlName(FlattenedXmlMapWithXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNameResponseUnmarshaller.Instance;

            return Invoke<FlattenedXmlMapWithXmlNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMapWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMapWithXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        public virtual IAsyncResult BeginFlattenedXmlMapWithXmlName(FlattenedXmlMapWithXmlNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMapWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMapWithXmlName.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapWithXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        public virtual FlattenedXmlMapWithXmlNameResponse EndFlattenedXmlMapWithXmlName(IAsyncResult asyncResult)
        {
            return EndInvoke<FlattenedXmlMapWithXmlNameResponse>(asyncResult);
        }

        #endregion
        
        #region  FlattenedXmlMapWithXmlNamespace

        /// <summary>
        /// Flattened maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        public virtual FlattenedXmlMapWithXmlNamespaceResponse FlattenedXmlMapWithXmlNamespace(FlattenedXmlMapWithXmlNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNamespaceResponseUnmarshaller.Instance;

            return Invoke<FlattenedXmlMapWithXmlNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMapWithXmlNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        public virtual IAsyncResult BeginFlattenedXmlMapWithXmlNamespace(FlattenedXmlMapWithXmlNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMapWithXmlNamespace.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapWithXmlNamespaceResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        public virtual FlattenedXmlMapWithXmlNamespaceResponse EndFlattenedXmlMapWithXmlNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<FlattenedXmlMapWithXmlNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  FractionalSeconds

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFractionalSeconds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
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
        /// <returns>Returns a  FractionalSecondsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
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
        /// InvalidGreeting error.</li> <li>A BadRequest error.</li> </ol> 
        /// <para>
        /// Implementations must be able to successfully take a response and properly (de)serialize
        /// successful and error responses based on the the presence of the
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by RestXmlProtocol.</returns>
        /// <exception cref="Amazon.RestXmlProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RestXmlProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGreetingWithErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
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
        /// <returns>Returns a  GreetingWithErrorsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual GreetingWithErrorsResponse EndGreetingWithErrors(IAsyncResult asyncResult)
        {
            return EndInvoke<GreetingWithErrorsResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpEmptyPrefixHeaders

        /// <summary>
        /// Clients that perform this test extract all headers from the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEmptyPrefixHeaders service method.</param>
        /// 
        /// <returns>The response from the HttpEmptyPrefixHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEmptyPrefixHeaders">REST API Reference for HttpEmptyPrefixHeaders Operation</seealso>
        public virtual HttpEmptyPrefixHeadersResponse HttpEmptyPrefixHeaders(HttpEmptyPrefixHeadersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpEmptyPrefixHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpEmptyPrefixHeadersResponseUnmarshaller.Instance;

            return Invoke<HttpEmptyPrefixHeadersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpEmptyPrefixHeaders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpEmptyPrefixHeaders operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpEmptyPrefixHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEmptyPrefixHeaders">REST API Reference for HttpEmptyPrefixHeaders Operation</seealso>
        public virtual IAsyncResult BeginHttpEmptyPrefixHeaders(HttpEmptyPrefixHeadersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpEmptyPrefixHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpEmptyPrefixHeadersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpEmptyPrefixHeaders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpEmptyPrefixHeaders.</param>
        /// 
        /// <returns>Returns a  HttpEmptyPrefixHeadersResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEmptyPrefixHeaders">REST API Reference for HttpEmptyPrefixHeaders Operation</seealso>
        public virtual HttpEmptyPrefixHeadersResponse EndHttpEmptyPrefixHeaders(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpEmptyPrefixHeadersResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpEnumPayload

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEnumPayload service method.</param>
        /// 
        /// <returns>The response from the HttpEnumPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        public virtual HttpEnumPayloadResponse HttpEnumPayload(HttpEnumPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpEnumPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpEnumPayloadResponseUnmarshaller.Instance;

            return Invoke<HttpEnumPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpEnumPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpEnumPayload operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpEnumPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        public virtual IAsyncResult BeginHttpEnumPayload(HttpEnumPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpEnumPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpEnumPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpEnumPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpEnumPayload.</param>
        /// 
        /// <returns>Returns a  HttpEnumPayloadResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        public virtual HttpEnumPayloadResponse EndHttpEnumPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpEnumPayloadResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpPayloadTraits

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
        /// 
        /// <returns>The response from the HttpPayloadTraits service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        public virtual HttpPayloadTraitsResponse HttpPayloadTraits(HttpPayloadTraitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadTraitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadTraitsResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadTraitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadTraits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadTraits operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadTraits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        public virtual IAsyncResult BeginHttpPayloadTraits(HttpPayloadTraitsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadTraitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadTraitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadTraits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadTraits.</param>
        /// 
        /// <returns>Returns a  HttpPayloadTraitsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        public virtual HttpPayloadTraitsResponse EndHttpPayloadTraits(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPayloadTraitsResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpPayloadWithMemberXmlName

        /// <summary>
        /// The following example serializes a payload that uses an XML name on the member, changing
        /// the wrapper name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithMemberXmlName service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithMemberXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithMemberXmlName">REST API Reference for HttpPayloadWithMemberXmlName Operation</seealso>
        public virtual HttpPayloadWithMemberXmlNameResponse HttpPayloadWithMemberXmlName(HttpPayloadWithMemberXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithMemberXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithMemberXmlNameResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithMemberXmlNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithMemberXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithMemberXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithMemberXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithMemberXmlName">REST API Reference for HttpPayloadWithMemberXmlName Operation</seealso>
        public virtual IAsyncResult BeginHttpPayloadWithMemberXmlName(HttpPayloadWithMemberXmlNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithMemberXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithMemberXmlNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithMemberXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithMemberXmlName.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithMemberXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithMemberXmlName">REST API Reference for HttpPayloadWithMemberXmlName Operation</seealso>
        public virtual HttpPayloadWithMemberXmlNameResponse EndHttpPayloadWithMemberXmlName(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPayloadWithMemberXmlNameResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpPayloadWithStructure

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
        /// 
        /// <returns>The response from the HttpPayloadWithStructure service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        public virtual HttpPayloadWithStructureResponse HttpPayloadWithStructure(HttpPayloadWithStructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithStructureResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithStructureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithStructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithStructure operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithStructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        public virtual IAsyncResult BeginHttpPayloadWithStructure(HttpPayloadWithStructureRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithStructureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithStructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithStructure.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithStructureResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        public virtual HttpPayloadWithStructureResponse EndHttpPayloadWithStructure(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPayloadWithStructureResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpPayloadWithUnion

        /// <summary>
        /// This example serializes a union in the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithUnion service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithUnion service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        public virtual HttpPayloadWithUnionResponse HttpPayloadWithUnion(HttpPayloadWithUnionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithUnionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithUnionResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithUnionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithUnion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithUnion operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithUnion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        public virtual IAsyncResult BeginHttpPayloadWithUnion(HttpPayloadWithUnionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithUnionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithUnionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithUnion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithUnion.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithUnionResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        public virtual HttpPayloadWithUnionResponse EndHttpPayloadWithUnion(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPayloadWithUnionResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpPayloadWithXmlName

        /// <summary>
        /// The following example serializes a payload that uses an XML name, changing the wrapper
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlName service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlName">REST API Reference for HttpPayloadWithXmlName Operation</seealso>
        public virtual HttpPayloadWithXmlNameResponse HttpPayloadWithXmlName(HttpPayloadWithXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNameResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithXmlNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlName">REST API Reference for HttpPayloadWithXmlName Operation</seealso>
        public virtual IAsyncResult BeginHttpPayloadWithXmlName(HttpPayloadWithXmlNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithXmlName.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlName">REST API Reference for HttpPayloadWithXmlName Operation</seealso>
        public virtual HttpPayloadWithXmlNameResponse EndHttpPayloadWithXmlName(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPayloadWithXmlNameResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpPayloadWithXmlNamespace

        /// <summary>
        /// The following example serializes a payload that uses an XML namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespace service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespace">REST API Reference for HttpPayloadWithXmlNamespace Operation</seealso>
        public virtual HttpPayloadWithXmlNamespaceResponse HttpPayloadWithXmlNamespace(HttpPayloadWithXmlNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNamespaceResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithXmlNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespace operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithXmlNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespace">REST API Reference for HttpPayloadWithXmlNamespace Operation</seealso>
        public virtual IAsyncResult BeginHttpPayloadWithXmlNamespace(HttpPayloadWithXmlNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithXmlNamespace.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithXmlNamespaceResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespace">REST API Reference for HttpPayloadWithXmlNamespace Operation</seealso>
        public virtual HttpPayloadWithXmlNamespaceResponse EndHttpPayloadWithXmlNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPayloadWithXmlNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpPayloadWithXmlNamespaceAndPrefix

        /// <summary>
        /// The following example serializes a payload that uses an XML namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespaceAndPrefix service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlNamespaceAndPrefix service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespaceAndPrefix">REST API Reference for HttpPayloadWithXmlNamespaceAndPrefix Operation</seealso>
        public virtual HttpPayloadWithXmlNamespaceAndPrefixResponse HttpPayloadWithXmlNamespaceAndPrefix(HttpPayloadWithXmlNamespaceAndPrefixRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNamespaceAndPrefixRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNamespaceAndPrefixResponseUnmarshaller.Instance;

            return Invoke<HttpPayloadWithXmlNamespaceAndPrefixResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithXmlNamespaceAndPrefix operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespaceAndPrefix operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithXmlNamespaceAndPrefix
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespaceAndPrefix">REST API Reference for HttpPayloadWithXmlNamespaceAndPrefix Operation</seealso>
        public virtual IAsyncResult BeginHttpPayloadWithXmlNamespaceAndPrefix(HttpPayloadWithXmlNamespaceAndPrefixRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPayloadWithXmlNamespaceAndPrefixRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPayloadWithXmlNamespaceAndPrefixResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithXmlNamespaceAndPrefix operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithXmlNamespaceAndPrefix.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithXmlNamespaceAndPrefixResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespaceAndPrefix">REST API Reference for HttpPayloadWithXmlNamespaceAndPrefix Operation</seealso>
        public virtual HttpPayloadWithXmlNamespaceAndPrefixResponse EndHttpPayloadWithXmlNamespaceAndPrefix(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPayloadWithXmlNamespaceAndPrefixResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpPrefixHeaders

        /// <summary>
        /// This examples adds headers to the input of a request and response by prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeaders service method.</param>
        /// 
        /// <returns>The response from the HttpPrefixHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        public virtual HttpPrefixHeadersResponse HttpPrefixHeaders(HttpPrefixHeadersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPrefixHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPrefixHeadersResponseUnmarshaller.Instance;

            return Invoke<HttpPrefixHeadersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPrefixHeaders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeaders operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPrefixHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        public virtual IAsyncResult BeginHttpPrefixHeaders(HttpPrefixHeadersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPrefixHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPrefixHeadersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPrefixHeaders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPrefixHeaders.</param>
        /// 
        /// <returns>Returns a  HttpPrefixHeadersResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        public virtual HttpPrefixHeadersResponse EndHttpPrefixHeaders(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPrefixHeadersResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpRequestWithFloatLabels

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithFloatLabels service method.</param>
        /// 
        /// <returns>The response from the HttpRequestWithFloatLabels service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        public virtual HttpRequestWithFloatLabelsResponse HttpRequestWithFloatLabels(HttpRequestWithFloatLabelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithFloatLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithFloatLabelsResponseUnmarshaller.Instance;

            return Invoke<HttpRequestWithFloatLabelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpRequestWithFloatLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithFloatLabels operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithFloatLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        public virtual IAsyncResult BeginHttpRequestWithFloatLabels(HttpRequestWithFloatLabelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithFloatLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithFloatLabelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpRequestWithFloatLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpRequestWithFloatLabels.</param>
        /// 
        /// <returns>Returns a  HttpRequestWithFloatLabelsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        public virtual HttpRequestWithFloatLabelsResponse EndHttpRequestWithFloatLabels(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpRequestWithFloatLabelsResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpRequestWithGreedyLabelInPath

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithGreedyLabelInPath service method.</param>
        /// 
        /// <returns>The response from the HttpRequestWithGreedyLabelInPath service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        public virtual HttpRequestWithGreedyLabelInPathResponse HttpRequestWithGreedyLabelInPath(HttpRequestWithGreedyLabelInPathRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithGreedyLabelInPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithGreedyLabelInPathResponseUnmarshaller.Instance;

            return Invoke<HttpRequestWithGreedyLabelInPathResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpRequestWithGreedyLabelInPath operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithGreedyLabelInPath operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithGreedyLabelInPath
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        public virtual IAsyncResult BeginHttpRequestWithGreedyLabelInPath(HttpRequestWithGreedyLabelInPathRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithGreedyLabelInPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithGreedyLabelInPathResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpRequestWithGreedyLabelInPath operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpRequestWithGreedyLabelInPath.</param>
        /// 
        /// <returns>Returns a  HttpRequestWithGreedyLabelInPathResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        public virtual HttpRequestWithGreedyLabelInPathResponse EndHttpRequestWithGreedyLabelInPath(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpRequestWithGreedyLabelInPathResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpRequestWithLabels

        /// <summary>
        /// The example tests how requests are serialized when there's no input payload but there
        /// are HTTP labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabels service method.</param>
        /// 
        /// <returns>The response from the HttpRequestWithLabels service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        public virtual HttpRequestWithLabelsResponse HttpRequestWithLabels(HttpRequestWithLabelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithLabelsResponseUnmarshaller.Instance;

            return Invoke<HttpRequestWithLabelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpRequestWithLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabels operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        public virtual IAsyncResult BeginHttpRequestWithLabels(HttpRequestWithLabelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithLabelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpRequestWithLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpRequestWithLabels.</param>
        /// 
        /// <returns>Returns a  HttpRequestWithLabelsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        public virtual HttpRequestWithLabelsResponse EndHttpRequestWithLabels(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpRequestWithLabelsResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpRequestWithLabelsAndTimestampFormat

        /// <summary>
        /// The example tests how requests serialize different timestamp formats in the URI path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabelsAndTimestampFormat service method.</param>
        /// 
        /// <returns>The response from the HttpRequestWithLabelsAndTimestampFormat service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        public virtual HttpRequestWithLabelsAndTimestampFormatResponse HttpRequestWithLabelsAndTimestampFormat(HttpRequestWithLabelsAndTimestampFormatRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithLabelsAndTimestampFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithLabelsAndTimestampFormatResponseUnmarshaller.Instance;

            return Invoke<HttpRequestWithLabelsAndTimestampFormatResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpRequestWithLabelsAndTimestampFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabelsAndTimestampFormat operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithLabelsAndTimestampFormat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        public virtual IAsyncResult BeginHttpRequestWithLabelsAndTimestampFormat(HttpRequestWithLabelsAndTimestampFormatRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithLabelsAndTimestampFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithLabelsAndTimestampFormatResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpRequestWithLabelsAndTimestampFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpRequestWithLabelsAndTimestampFormat.</param>
        /// 
        /// <returns>Returns a  HttpRequestWithLabelsAndTimestampFormatResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        public virtual HttpRequestWithLabelsAndTimestampFormatResponse EndHttpRequestWithLabelsAndTimestampFormat(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpRequestWithLabelsAndTimestampFormatResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpResponseCode

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpResponseCode service method.</param>
        /// 
        /// <returns>The response from the HttpResponseCode service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        public virtual HttpResponseCodeResponse HttpResponseCode(HttpResponseCodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpResponseCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpResponseCodeResponseUnmarshaller.Instance;

            return Invoke<HttpResponseCodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpResponseCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpResponseCode operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpResponseCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        public virtual IAsyncResult BeginHttpResponseCode(HttpResponseCodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpResponseCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpResponseCodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpResponseCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpResponseCode.</param>
        /// 
        /// <returns>Returns a  HttpResponseCodeResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        public virtual HttpResponseCodeResponse EndHttpResponseCode(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpResponseCodeResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpStringPayload

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpStringPayload service method.</param>
        /// 
        /// <returns>The response from the HttpStringPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        public virtual HttpStringPayloadResponse HttpStringPayload(HttpStringPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpStringPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpStringPayloadResponseUnmarshaller.Instance;

            return Invoke<HttpStringPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpStringPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpStringPayload operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpStringPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        public virtual IAsyncResult BeginHttpStringPayload(HttpStringPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpStringPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpStringPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpStringPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpStringPayload.</param>
        /// 
        /// <returns>Returns a  HttpStringPayloadResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        public virtual HttpStringPayloadResponse EndHttpStringPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpStringPayloadResponse>(asyncResult);
        }

        #endregion
        
        #region  IgnoreQueryParamsInResponse

        /// <summary>
        /// This example ensures that query string bound request parameters are serialized in
        /// the body of responses if the structure is used in both the request and response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IgnoreQueryParamsInResponse service method.</param>
        /// 
        /// <returns>The response from the IgnoreQueryParamsInResponse service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        public virtual IgnoreQueryParamsInResponseResponse IgnoreQueryParamsInResponse(IgnoreQueryParamsInResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IgnoreQueryParamsInResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IgnoreQueryParamsInResponseResponseUnmarshaller.Instance;

            return Invoke<IgnoreQueryParamsInResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the IgnoreQueryParamsInResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IgnoreQueryParamsInResponse operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIgnoreQueryParamsInResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        public virtual IAsyncResult BeginIgnoreQueryParamsInResponse(IgnoreQueryParamsInResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IgnoreQueryParamsInResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IgnoreQueryParamsInResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  IgnoreQueryParamsInResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIgnoreQueryParamsInResponse.</param>
        /// 
        /// <returns>Returns a  IgnoreQueryParamsInResponseResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        public virtual IgnoreQueryParamsInResponseResponse EndIgnoreQueryParamsInResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<IgnoreQueryParamsInResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  InputAndOutputWithHeaders

        /// <summary>
        /// The example tests how requests and responses are serialized when there is no input
        /// or output payload but there are HTTP header bindings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InputAndOutputWithHeaders service method.</param>
        /// 
        /// <returns>The response from the InputAndOutputWithHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        public virtual InputAndOutputWithHeadersResponse InputAndOutputWithHeaders(InputAndOutputWithHeadersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InputAndOutputWithHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InputAndOutputWithHeadersResponseUnmarshaller.Instance;

            return Invoke<InputAndOutputWithHeadersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InputAndOutputWithHeaders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InputAndOutputWithHeaders operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInputAndOutputWithHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        public virtual IAsyncResult BeginInputAndOutputWithHeaders(InputAndOutputWithHeadersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InputAndOutputWithHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InputAndOutputWithHeadersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InputAndOutputWithHeaders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInputAndOutputWithHeaders.</param>
        /// 
        /// <returns>Returns a  InputAndOutputWithHeadersResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        public virtual InputAndOutputWithHeadersResponse EndInputAndOutputWithHeaders(IAsyncResult asyncResult)
        {
            return EndInvoke<InputAndOutputWithHeadersResponse>(asyncResult);
        }

        #endregion
        
        #region  NestedXmlMaps

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NestedXmlMaps service method.</param>
        /// 
        /// <returns>The response from the NestedXmlMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMaps">REST API Reference for NestedXmlMaps Operation</seealso>
        public virtual NestedXmlMapsResponse NestedXmlMaps(NestedXmlMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NestedXmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NestedXmlMapsResponseUnmarshaller.Instance;

            return Invoke<NestedXmlMapsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NestedXmlMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NestedXmlMaps operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNestedXmlMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMaps">REST API Reference for NestedXmlMaps Operation</seealso>
        public virtual IAsyncResult BeginNestedXmlMaps(NestedXmlMapsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NestedXmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NestedXmlMapsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NestedXmlMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNestedXmlMaps.</param>
        /// 
        /// <returns>Returns a  NestedXmlMapsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMaps">REST API Reference for NestedXmlMaps Operation</seealso>
        public virtual NestedXmlMapsResponse EndNestedXmlMaps(IAsyncResult asyncResult)
        {
            return EndInvoke<NestedXmlMapsResponse>(asyncResult);
        }

        #endregion
        
        #region  NestedXmlMapWithXmlName

        /// <summary>
        /// Nested Xml Maps with key/values with @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NestedXmlMapWithXmlName service method.</param>
        /// 
        /// <returns>The response from the NestedXmlMapWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMapWithXmlName">REST API Reference for NestedXmlMapWithXmlName Operation</seealso>
        public virtual NestedXmlMapWithXmlNameResponse NestedXmlMapWithXmlName(NestedXmlMapWithXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NestedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NestedXmlMapWithXmlNameResponseUnmarshaller.Instance;

            return Invoke<NestedXmlMapWithXmlNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NestedXmlMapWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NestedXmlMapWithXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNestedXmlMapWithXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMapWithXmlName">REST API Reference for NestedXmlMapWithXmlName Operation</seealso>
        public virtual IAsyncResult BeginNestedXmlMapWithXmlName(NestedXmlMapWithXmlNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NestedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NestedXmlMapWithXmlNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NestedXmlMapWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNestedXmlMapWithXmlName.</param>
        /// 
        /// <returns>Returns a  NestedXmlMapWithXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMapWithXmlName">REST API Reference for NestedXmlMapWithXmlName Operation</seealso>
        public virtual NestedXmlMapWithXmlNameResponse EndNestedXmlMapWithXmlName(IAsyncResult asyncResult)
        {
            return EndInvoke<NestedXmlMapWithXmlNameResponse>(asyncResult);
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
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndNoOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
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
        /// <returns>Returns a  NoInputAndNoOutputResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
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
        /// <returns>The response from the NoInputAndOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
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
        /// <returns>Returns a  NoInputAndOutputResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual NoInputAndOutputResponse EndNoInputAndOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<NoInputAndOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  NullAndEmptyHeadersClient

        /// <summary>
        /// Null headers are not sent over the wire, empty headers are serialized to &quot;&quot;
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersClient service method.</param>
        /// 
        /// <returns>The response from the NullAndEmptyHeadersClient service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        public virtual NullAndEmptyHeadersClientResponse NullAndEmptyHeadersClient(NullAndEmptyHeadersClientRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersClientResponseUnmarshaller.Instance;

            return Invoke<NullAndEmptyHeadersClientResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NullAndEmptyHeadersClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersClient operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNullAndEmptyHeadersClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        public virtual IAsyncResult BeginNullAndEmptyHeadersClient(NullAndEmptyHeadersClientRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersClientResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NullAndEmptyHeadersClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNullAndEmptyHeadersClient.</param>
        /// 
        /// <returns>Returns a  NullAndEmptyHeadersClientResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        public virtual NullAndEmptyHeadersClientResponse EndNullAndEmptyHeadersClient(IAsyncResult asyncResult)
        {
            return EndInvoke<NullAndEmptyHeadersClientResponse>(asyncResult);
        }

        #endregion
        
        #region  NullAndEmptyHeadersServer

        /// <summary>
        /// Null headers are not sent over the wire, empty headers are serialized to &quot;&quot;
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersServer service method.</param>
        /// 
        /// <returns>The response from the NullAndEmptyHeadersServer service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        public virtual NullAndEmptyHeadersServerResponse NullAndEmptyHeadersServer(NullAndEmptyHeadersServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersServerResponseUnmarshaller.Instance;

            return Invoke<NullAndEmptyHeadersServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NullAndEmptyHeadersServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersServer operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNullAndEmptyHeadersServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        public virtual IAsyncResult BeginNullAndEmptyHeadersServer(NullAndEmptyHeadersServerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullAndEmptyHeadersServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullAndEmptyHeadersServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NullAndEmptyHeadersServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNullAndEmptyHeadersServer.</param>
        /// 
        /// <returns>Returns a  NullAndEmptyHeadersServerResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        public virtual NullAndEmptyHeadersServerResponse EndNullAndEmptyHeadersServer(IAsyncResult asyncResult)
        {
            return EndInvoke<NullAndEmptyHeadersServerResponse>(asyncResult);
        }

        #endregion
        
        #region  OmitsNullSerializesEmptyString

        /// <summary>
        /// Omits null, but serializes empty string value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OmitsNullSerializesEmptyString service method.</param>
        /// 
        /// <returns>The response from the OmitsNullSerializesEmptyString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        public virtual OmitsNullSerializesEmptyStringResponse OmitsNullSerializesEmptyString(OmitsNullSerializesEmptyStringRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OmitsNullSerializesEmptyStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OmitsNullSerializesEmptyStringResponseUnmarshaller.Instance;

            return Invoke<OmitsNullSerializesEmptyStringResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the OmitsNullSerializesEmptyString operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OmitsNullSerializesEmptyString operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOmitsNullSerializesEmptyString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        public virtual IAsyncResult BeginOmitsNullSerializesEmptyString(OmitsNullSerializesEmptyStringRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OmitsNullSerializesEmptyStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OmitsNullSerializesEmptyStringResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  OmitsNullSerializesEmptyString operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOmitsNullSerializesEmptyString.</param>
        /// 
        /// <returns>Returns a  OmitsNullSerializesEmptyStringResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        public virtual OmitsNullSerializesEmptyStringResponse EndOmitsNullSerializesEmptyString(IAsyncResult asyncResult)
        {
            return EndInvoke<OmitsNullSerializesEmptyStringResponse>(asyncResult);
        }

        #endregion
        
        #region  PutWithContentEncoding

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWithContentEncoding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
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
        /// <returns>Returns a  PutWithContentEncodingResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual PutWithContentEncodingResponse EndPutWithContentEncoding(IAsyncResult asyncResult)
        {
            return EndInvoke<PutWithContentEncodingResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryIdempotencyTokenAutoFill

        /// <summary>
        /// Automatically adds idempotency tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill service method.</param>
        /// 
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        public virtual QueryIdempotencyTokenAutoFillResponse QueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIdempotencyTokenAutoFillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIdempotencyTokenAutoFillResponseUnmarshaller.Instance;

            return Invoke<QueryIdempotencyTokenAutoFillResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryIdempotencyTokenAutoFill operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryIdempotencyTokenAutoFill
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        public virtual IAsyncResult BeginQueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIdempotencyTokenAutoFillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIdempotencyTokenAutoFillResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryIdempotencyTokenAutoFill operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryIdempotencyTokenAutoFill.</param>
        /// 
        /// <returns>Returns a  QueryIdempotencyTokenAutoFillResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        public virtual QueryIdempotencyTokenAutoFillResponse EndQueryIdempotencyTokenAutoFill(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryIdempotencyTokenAutoFillResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryParamsAsStringListMap

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryParamsAsStringListMap service method.</param>
        /// 
        /// <returns>The response from the QueryParamsAsStringListMap service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        public virtual QueryParamsAsStringListMapResponse QueryParamsAsStringListMap(QueryParamsAsStringListMapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryParamsAsStringListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryParamsAsStringListMapResponseUnmarshaller.Instance;

            return Invoke<QueryParamsAsStringListMapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryParamsAsStringListMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryParamsAsStringListMap operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryParamsAsStringListMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        public virtual IAsyncResult BeginQueryParamsAsStringListMap(QueryParamsAsStringListMapRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryParamsAsStringListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryParamsAsStringListMapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryParamsAsStringListMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryParamsAsStringListMap.</param>
        /// 
        /// <returns>Returns a  QueryParamsAsStringListMapResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        public virtual QueryParamsAsStringListMapResponse EndQueryParamsAsStringListMap(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryParamsAsStringListMapResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryPrecedence

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryPrecedence service method.</param>
        /// 
        /// <returns>The response from the QueryPrecedence service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        public virtual QueryPrecedenceResponse QueryPrecedence(QueryPrecedenceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryPrecedenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryPrecedenceResponseUnmarshaller.Instance;

            return Invoke<QueryPrecedenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryPrecedence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryPrecedence operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryPrecedence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        public virtual IAsyncResult BeginQueryPrecedence(QueryPrecedenceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryPrecedenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryPrecedenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryPrecedence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryPrecedence.</param>
        /// 
        /// <returns>Returns a  QueryPrecedenceResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        public virtual QueryPrecedenceResponse EndQueryPrecedence(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryPrecedenceResponse>(asyncResult);
        }

        #endregion
        
        #region  SimpleScalarProperties

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleScalarProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
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
        /// <returns>Returns a  SimpleScalarPropertiesResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual SimpleScalarPropertiesResponse EndSimpleScalarProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<SimpleScalarPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  TimestampFormatHeaders

        /// <summary>
        /// The example tests how timestamp request and response headers are serialized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders service method.</param>
        /// 
        /// <returns>The response from the TimestampFormatHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        public virtual TimestampFormatHeadersResponse TimestampFormatHeaders(TimestampFormatHeadersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TimestampFormatHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TimestampFormatHeadersResponseUnmarshaller.Instance;

            return Invoke<TimestampFormatHeadersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TimestampFormatHeaders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTimestampFormatHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        public virtual IAsyncResult BeginTimestampFormatHeaders(TimestampFormatHeadersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TimestampFormatHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TimestampFormatHeadersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TimestampFormatHeaders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTimestampFormatHeaders.</param>
        /// 
        /// <returns>Returns a  TimestampFormatHeadersResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        public virtual TimestampFormatHeadersResponse EndTimestampFormatHeaders(IAsyncResult asyncResult)
        {
            return EndInvoke<TimestampFormatHeadersResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlAttributes

        /// <summary>
        /// This example serializes an XML attributes on synthesized document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributes service method.</param>
        /// 
        /// <returns>The response from the XmlAttributes service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributes">REST API Reference for XmlAttributes Operation</seealso>
        public virtual XmlAttributesResponse XmlAttributes(XmlAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlAttributesResponseUnmarshaller.Instance;

            return Invoke<XmlAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributes operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributes">REST API Reference for XmlAttributes Operation</seealso>
        public virtual IAsyncResult BeginXmlAttributes(XmlAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlAttributes.</param>
        /// 
        /// <returns>Returns a  XmlAttributesResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributes">REST API Reference for XmlAttributes Operation</seealso>
        public virtual XmlAttributesResponse EndXmlAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlAttributesOnPayload

        /// <summary>
        /// This example serializes an XML attributes on a document targeted by httpPayload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributesOnPayload service method.</param>
        /// 
        /// <returns>The response from the XmlAttributesOnPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributesOnPayload">REST API Reference for XmlAttributesOnPayload Operation</seealso>
        public virtual XmlAttributesOnPayloadResponse XmlAttributesOnPayload(XmlAttributesOnPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlAttributesOnPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlAttributesOnPayloadResponseUnmarshaller.Instance;

            return Invoke<XmlAttributesOnPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlAttributesOnPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributesOnPayload operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlAttributesOnPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributesOnPayload">REST API Reference for XmlAttributesOnPayload Operation</seealso>
        public virtual IAsyncResult BeginXmlAttributesOnPayload(XmlAttributesOnPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlAttributesOnPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlAttributesOnPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlAttributesOnPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlAttributesOnPayload.</param>
        /// 
        /// <returns>Returns a  XmlAttributesOnPayloadResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributesOnPayload">REST API Reference for XmlAttributesOnPayload Operation</seealso>
        public virtual XmlAttributesOnPayloadResponse EndXmlAttributesOnPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlAttributesOnPayloadResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlBlobs

        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs service method.</param>
        /// 
        /// <returns>The response from the XmlBlobs service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        public virtual XmlBlobsResponse XmlBlobs(XmlBlobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlBlobsResponseUnmarshaller.Instance;

            return Invoke<XmlBlobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlBlobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlBlobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        public virtual IAsyncResult BeginXmlBlobs(XmlBlobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlBlobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlBlobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlBlobs.</param>
        /// 
        /// <returns>Returns a  XmlBlobsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        public virtual XmlBlobsResponse EndXmlBlobs(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlBlobsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlEmptyBlobs

        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyBlobs service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        public virtual XmlEmptyBlobsResponse XmlEmptyBlobs(XmlEmptyBlobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyBlobsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyBlobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyBlobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyBlobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        public virtual IAsyncResult BeginXmlEmptyBlobs(XmlEmptyBlobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyBlobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyBlobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyBlobs.</param>
        /// 
        /// <returns>Returns a  XmlEmptyBlobsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        public virtual XmlEmptyBlobsResponse EndXmlEmptyBlobs(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlEmptyBlobsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlEmptyLists

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyLists service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        public virtual XmlEmptyListsResponse XmlEmptyLists(XmlEmptyListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyListsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        public virtual IAsyncResult BeginXmlEmptyLists(XmlEmptyListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyLists.</param>
        /// 
        /// <returns>Returns a  XmlEmptyListsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        public virtual XmlEmptyListsResponse EndXmlEmptyLists(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlEmptyListsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlEmptyMaps

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        public virtual XmlEmptyMapsResponse XmlEmptyMaps(XmlEmptyMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyMapsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyMapsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        public virtual IAsyncResult BeginXmlEmptyMaps(XmlEmptyMapsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyMapsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyMaps.</param>
        /// 
        /// <returns>Returns a  XmlEmptyMapsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        public virtual XmlEmptyMapsResponse EndXmlEmptyMaps(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlEmptyMapsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlEmptyStrings

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyStrings service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyStrings service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyStrings">REST API Reference for XmlEmptyStrings Operation</seealso>
        public virtual XmlEmptyStringsResponse XmlEmptyStrings(XmlEmptyStringsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyStringsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyStringsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyStringsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyStrings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyStrings operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyStrings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyStrings">REST API Reference for XmlEmptyStrings Operation</seealso>
        public virtual IAsyncResult BeginXmlEmptyStrings(XmlEmptyStringsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyStringsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyStringsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyStrings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyStrings.</param>
        /// 
        /// <returns>Returns a  XmlEmptyStringsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyStrings">REST API Reference for XmlEmptyStrings Operation</seealso>
        public virtual XmlEmptyStringsResponse EndXmlEmptyStrings(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlEmptyStringsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlEnums

        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums service method.</param>
        /// 
        /// <returns>The response from the XmlEnums service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        public virtual XmlEnumsResponse XmlEnums(XmlEnumsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEnumsResponseUnmarshaller.Instance;

            return Invoke<XmlEnumsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        public virtual IAsyncResult BeginXmlEnums(XmlEnumsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEnumsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEnums.</param>
        /// 
        /// <returns>Returns a  XmlEnumsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        public virtual XmlEnumsResponse EndXmlEnums(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlEnumsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlIntEnums

        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums service method.</param>
        /// 
        /// <returns>The response from the XmlIntEnums service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        public virtual XmlIntEnumsResponse XmlIntEnums(XmlIntEnumsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlIntEnumsResponseUnmarshaller.Instance;

            return Invoke<XmlIntEnumsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlIntEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlIntEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        public virtual IAsyncResult BeginXmlIntEnums(XmlIntEnumsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlIntEnumsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlIntEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlIntEnums.</param>
        /// 
        /// <returns>Returns a  XmlIntEnumsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        public virtual XmlIntEnumsResponse EndXmlIntEnums(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlIntEnumsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlLists

        /// <summary>
        /// This test case serializes XML lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal XML lists.</li> <li>Normal XML sets.</li> <li>XML lists of lists.</li>
        /// <li>XML lists with @xmlName on its members</li> <li>Flattened XML lists.</li> <li>Flattened
        /// XML lists with @xmlName.</li> <li>Flattened XML lists with @xmlNamespace.</li> <li>Lists
        /// of structures.</li> <li>Flattened XML list of structures</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlLists service method.</param>
        /// 
        /// <returns>The response from the XmlLists service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlLists">REST API Reference for XmlLists Operation</seealso>
        public virtual XmlListsResponse XmlLists(XmlListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlListsResponseUnmarshaller.Instance;

            return Invoke<XmlListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlLists operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlLists">REST API Reference for XmlLists Operation</seealso>
        public virtual IAsyncResult BeginXmlLists(XmlListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlLists.</param>
        /// 
        /// <returns>Returns a  XmlListsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlLists">REST API Reference for XmlLists Operation</seealso>
        public virtual XmlListsResponse EndXmlLists(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlListsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlMaps

        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps service method.</param>
        /// 
        /// <returns>The response from the XmlMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        public virtual XmlMapsResponse XmlMaps(XmlMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsResponseUnmarshaller.Instance;

            return Invoke<XmlMapsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        public virtual IAsyncResult BeginXmlMaps(XmlMapsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlMaps.</param>
        /// 
        /// <returns>Returns a  XmlMapsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        public virtual XmlMapsResponse EndXmlMaps(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlMapsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlMapsXmlName

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName service method.</param>
        /// 
        /// <returns>The response from the XmlMapsXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        public virtual XmlMapsXmlNameResponse XmlMapsXmlName(XmlMapsXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsXmlNameResponseUnmarshaller.Instance;

            return Invoke<XmlMapsXmlNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlMapsXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlMapsXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        public virtual IAsyncResult BeginXmlMapsXmlName(XmlMapsXmlNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsXmlNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlMapsXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlMapsXmlName.</param>
        /// 
        /// <returns>Returns a  XmlMapsXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        public virtual XmlMapsXmlNameResponse EndXmlMapsXmlName(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlMapsXmlNameResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlMapWithXmlNamespace

        /// <summary>
        /// Maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapWithXmlNamespace service method.</param>
        /// 
        /// <returns>The response from the XmlMapWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapWithXmlNamespace">REST API Reference for XmlMapWithXmlNamespace Operation</seealso>
        public virtual XmlMapWithXmlNamespaceResponse XmlMapWithXmlNamespace(XmlMapWithXmlNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapWithXmlNamespaceResponseUnmarshaller.Instance;

            return Invoke<XmlMapWithXmlNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlMapWithXmlNamespace operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlMapWithXmlNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapWithXmlNamespace">REST API Reference for XmlMapWithXmlNamespace Operation</seealso>
        public virtual IAsyncResult BeginXmlMapWithXmlNamespace(XmlMapWithXmlNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapWithXmlNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlMapWithXmlNamespace.</param>
        /// 
        /// <returns>Returns a  XmlMapWithXmlNamespaceResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapWithXmlNamespace">REST API Reference for XmlMapWithXmlNamespace Operation</seealso>
        public virtual XmlMapWithXmlNamespaceResponse EndXmlMapWithXmlNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlMapWithXmlNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlNamespaces

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces service method.</param>
        /// 
        /// <returns>The response from the XmlNamespaces service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        public virtual XmlNamespacesResponse XmlNamespaces(XmlNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlNamespacesResponseUnmarshaller.Instance;

            return Invoke<XmlNamespacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        public virtual IAsyncResult BeginXmlNamespaces(XmlNamespacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlNamespacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlNamespaces.</param>
        /// 
        /// <returns>Returns a  XmlNamespacesResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        public virtual XmlNamespacesResponse EndXmlNamespaces(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlNamespacesResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlTimestamps

        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps service method.</param>
        /// 
        /// <returns>The response from the XmlTimestamps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        public virtual XmlTimestampsResponse XmlTimestamps(XmlTimestampsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlTimestampsResponseUnmarshaller.Instance;

            return Invoke<XmlTimestampsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlTimestamps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlTimestamps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        public virtual IAsyncResult BeginXmlTimestamps(XmlTimestampsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlTimestampsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlTimestamps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlTimestamps.</param>
        /// 
        /// <returns>Returns a  XmlTimestampsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        public virtual XmlTimestampsResponse EndXmlTimestamps(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlTimestampsResponse>(asyncResult);
        }

        #endregion
        
    }
}