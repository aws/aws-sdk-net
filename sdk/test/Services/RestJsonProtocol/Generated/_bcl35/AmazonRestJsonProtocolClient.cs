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

        /// <summary>
        /// This example uses all query string types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllQueryStringTypes service method.</param>
        /// 
        /// <returns>The response from the AllQueryStringTypes service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the AllQueryStringTypes operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllQueryStringTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
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
        /// <returns>Returns a  AllQueryStringTypesResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        public virtual AllQueryStringTypesResponse EndAllQueryStringTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<AllQueryStringTypesResponse>(asyncResult);
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
        /// <returns>The response from the ConstantAndVariableQueryString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ConstantAndVariableQueryString operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConstantAndVariableQueryString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
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
        /// <returns>Returns a  ConstantAndVariableQueryStringResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
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
        /// <returns>The response from the ConstantQueryString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ConstantQueryString operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConstantQueryString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
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
        /// <returns>Returns a  ConstantQueryStringResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
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
        /// <returns>The response from the ContentTypeParameters service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ContentTypeParameters operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndContentTypeParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
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
        /// <returns>Returns a  ContentTypeParametersResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
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
        /// <returns>The response from the DatetimeOffsets service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDatetimeOffsets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
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
        /// <returns>Returns a  DatetimeOffsetsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual DatetimeOffsetsResponse EndDatetimeOffsets(IAsyncResult asyncResult)
        {
            return EndInvoke<DatetimeOffsetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DocumentType

        /// <summary>
        /// This example serializes a document as part of the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentType service method.</param>
        /// 
        /// <returns>The response from the DocumentType service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentType">REST API Reference for DocumentType Operation</seealso>
        public virtual DocumentTypeResponse DocumentType(DocumentTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DocumentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeResponseUnmarshaller.Instance;

            return Invoke<DocumentTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DocumentType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DocumentType operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDocumentType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentType">REST API Reference for DocumentType Operation</seealso>
        public virtual IAsyncResult BeginDocumentType(DocumentTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DocumentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DocumentType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDocumentType.</param>
        /// 
        /// <returns>Returns a  DocumentTypeResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentType">REST API Reference for DocumentType Operation</seealso>
        public virtual DocumentTypeResponse EndDocumentType(IAsyncResult asyncResult)
        {
            return EndInvoke<DocumentTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DocumentTypeAsMapValue

        /// <summary>
        /// This example serializes documents as the value of maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentTypeAsMapValue service method.</param>
        /// 
        /// <returns>The response from the DocumentTypeAsMapValue service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsMapValue">REST API Reference for DocumentTypeAsMapValue Operation</seealso>
        public virtual DocumentTypeAsMapValueResponse DocumentTypeAsMapValue(DocumentTypeAsMapValueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DocumentTypeAsMapValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeAsMapValueResponseUnmarshaller.Instance;

            return Invoke<DocumentTypeAsMapValueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DocumentTypeAsMapValue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DocumentTypeAsMapValue operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDocumentTypeAsMapValue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsMapValue">REST API Reference for DocumentTypeAsMapValue Operation</seealso>
        public virtual IAsyncResult BeginDocumentTypeAsMapValue(DocumentTypeAsMapValueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DocumentTypeAsMapValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeAsMapValueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DocumentTypeAsMapValue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDocumentTypeAsMapValue.</param>
        /// 
        /// <returns>Returns a  DocumentTypeAsMapValueResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsMapValue">REST API Reference for DocumentTypeAsMapValue Operation</seealso>
        public virtual DocumentTypeAsMapValueResponse EndDocumentTypeAsMapValue(IAsyncResult asyncResult)
        {
            return EndInvoke<DocumentTypeAsMapValueResponse>(asyncResult);
        }

        #endregion
        
        #region  DocumentTypeAsPayload

        /// <summary>
        /// This example serializes a document as the entire HTTP payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentTypeAsPayload service method.</param>
        /// 
        /// <returns>The response from the DocumentTypeAsPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsPayload">REST API Reference for DocumentTypeAsPayload Operation</seealso>
        public virtual DocumentTypeAsPayloadResponse DocumentTypeAsPayload(DocumentTypeAsPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DocumentTypeAsPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeAsPayloadResponseUnmarshaller.Instance;

            return Invoke<DocumentTypeAsPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DocumentTypeAsPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DocumentTypeAsPayload operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDocumentTypeAsPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsPayload">REST API Reference for DocumentTypeAsPayload Operation</seealso>
        public virtual IAsyncResult BeginDocumentTypeAsPayload(DocumentTypeAsPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DocumentTypeAsPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DocumentTypeAsPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DocumentTypeAsPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDocumentTypeAsPayload.</param>
        /// 
        /// <returns>Returns a  DocumentTypeAsPayloadResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsPayload">REST API Reference for DocumentTypeAsPayload Operation</seealso>
        public virtual DocumentTypeAsPayloadResponse EndDocumentTypeAsPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<DocumentTypeAsPayloadResponse>(asyncResult);
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
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyInputAndEmptyOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
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
        /// <returns>Returns a  EmptyInputAndEmptyOutputResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
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
        /// <returns>The response from the EndpointOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
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
        /// <returns>Returns a  EndpointOperationResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
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
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
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
        /// <returns>Returns a  EndpointWithHostLabelOperationResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
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
        /// <returns>The response from the FractionalSeconds service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFractionalSeconds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
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
        /// <returns>Returns a  FractionalSecondsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        public virtual FractionalSecondsResponse EndFractionalSeconds(IAsyncResult asyncResult)
        {
            return EndInvoke<FractionalSecondsResponse>(asyncResult);
        }

        #endregion
        
        #region  GreetingWithErrors

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
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGreetingWithErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
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
        /// <returns>Returns a  GreetingWithErrorsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
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
        /// <returns>The response from the HostWithPathOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHostWithPathOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
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
        /// <returns>Returns a  HostWithPathOperationResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual HostWithPathOperationResponse EndHostWithPathOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<HostWithPathOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpChecksumRequired

        /// <summary>
        /// This example tests httpChecksumRequired trait
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpChecksumRequired service method.</param>
        /// 
        /// <returns>The response from the HttpChecksumRequired service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpChecksumRequired">REST API Reference for HttpChecksumRequired Operation</seealso>
        public virtual HttpChecksumRequiredResponse HttpChecksumRequired(HttpChecksumRequiredRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpChecksumRequiredRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpChecksumRequiredResponseUnmarshaller.Instance;

            return Invoke<HttpChecksumRequiredResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpChecksumRequired operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpChecksumRequired operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpChecksumRequired
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpChecksumRequired">REST API Reference for HttpChecksumRequired Operation</seealso>
        public virtual IAsyncResult BeginHttpChecksumRequired(HttpChecksumRequiredRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpChecksumRequiredRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpChecksumRequiredResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpChecksumRequired operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpChecksumRequired.</param>
        /// 
        /// <returns>Returns a  HttpChecksumRequiredResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpChecksumRequired">REST API Reference for HttpChecksumRequired Operation</seealso>
        public virtual HttpChecksumRequiredResponse EndHttpChecksumRequired(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpChecksumRequiredResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpEmptyPrefixHeaders

        /// <summary>
        /// Clients that perform this test extract all headers from the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEmptyPrefixHeaders service method.</param>
        /// 
        /// <returns>The response from the HttpEmptyPrefixHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEmptyPrefixHeaders">REST API Reference for HttpEmptyPrefixHeaders Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpEmptyPrefixHeaders operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpEmptyPrefixHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEmptyPrefixHeaders">REST API Reference for HttpEmptyPrefixHeaders Operation</seealso>
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
        /// <returns>Returns a  HttpEmptyPrefixHeadersResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEmptyPrefixHeaders">REST API Reference for HttpEmptyPrefixHeaders Operation</seealso>
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
        /// <returns>The response from the HttpEnumPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpEnumPayload operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpEnumPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
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
        /// <returns>Returns a  HttpEnumPayloadResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
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
        /// In this example, no JSON document is synthesized because the payload is not a structure
        /// or a union type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadTraits service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadTraits service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadTraits operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadTraits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
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
        /// <returns>Returns a  HttpPayloadTraitsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        public virtual HttpPayloadTraitsResponse EndHttpPayloadTraits(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPayloadTraitsResponse>(asyncResult);
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
        /// <returns>The response from the HttpPayloadWithStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithStructure operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithStructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
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
        /// <returns>Returns a  HttpPayloadWithStructureResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
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
        /// <returns>The response from the HttpPayloadWithUnion service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithUnion operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithUnion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
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
        /// <returns>Returns a  HttpPayloadWithUnionResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        public virtual HttpPayloadWithUnionResponse EndHttpPayloadWithUnion(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPayloadWithUnionResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpPrefixHeaders

        /// <summary>
        /// This examples adds headers to the input of a request and response by prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeaders service method.</param>
        /// 
        /// <returns>The response from the HttpPrefixHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeaders operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPrefixHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
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
        /// <returns>Returns a  HttpPrefixHeadersResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        public virtual HttpPrefixHeadersResponse EndHttpPrefixHeaders(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPrefixHeadersResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpPrefixHeadersInResponse

        /// <summary>
        /// Clients that perform this test extract all headers from the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeadersInResponse service method.</param>
        /// 
        /// <returns>The response from the HttpPrefixHeadersInResponse service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeadersInResponse">REST API Reference for HttpPrefixHeadersInResponse Operation</seealso>
        public virtual HttpPrefixHeadersInResponseResponse HttpPrefixHeadersInResponse(HttpPrefixHeadersInResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPrefixHeadersInResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPrefixHeadersInResponseResponseUnmarshaller.Instance;

            return Invoke<HttpPrefixHeadersInResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPrefixHeadersInResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeadersInResponse operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPrefixHeadersInResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeadersInResponse">REST API Reference for HttpPrefixHeadersInResponse Operation</seealso>
        public virtual IAsyncResult BeginHttpPrefixHeadersInResponse(HttpPrefixHeadersInResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpPrefixHeadersInResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpPrefixHeadersInResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPrefixHeadersInResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPrefixHeadersInResponse.</param>
        /// 
        /// <returns>Returns a  HttpPrefixHeadersInResponseResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeadersInResponse">REST API Reference for HttpPrefixHeadersInResponse Operation</seealso>
        public virtual HttpPrefixHeadersInResponseResponse EndHttpPrefixHeadersInResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpPrefixHeadersInResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpRequestWithFloatLabels

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithFloatLabels service method.</param>
        /// 
        /// <returns>The response from the HttpRequestWithFloatLabels service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithFloatLabels operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithFloatLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
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
        /// <returns>Returns a  HttpRequestWithFloatLabelsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
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
        /// <returns>The response from the HttpRequestWithGreedyLabelInPath service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithGreedyLabelInPath operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithGreedyLabelInPath
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
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
        /// <returns>Returns a  HttpRequestWithGreedyLabelInPathResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
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
        /// <returns>The response from the HttpRequestWithLabels service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabels operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
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
        /// <returns>Returns a  HttpRequestWithLabelsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
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
        /// <returns>The response from the HttpRequestWithLabelsAndTimestampFormat service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabelsAndTimestampFormat operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithLabelsAndTimestampFormat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
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
        /// <returns>Returns a  HttpRequestWithLabelsAndTimestampFormatResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        public virtual HttpRequestWithLabelsAndTimestampFormatResponse EndHttpRequestWithLabelsAndTimestampFormat(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpRequestWithLabelsAndTimestampFormatResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpRequestWithRegexLiteral

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithRegexLiteral service method.</param>
        /// 
        /// <returns>The response from the HttpRequestWithRegexLiteral service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithRegexLiteral">REST API Reference for HttpRequestWithRegexLiteral Operation</seealso>
        public virtual HttpRequestWithRegexLiteralResponse HttpRequestWithRegexLiteral(HttpRequestWithRegexLiteralRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithRegexLiteralRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithRegexLiteralResponseUnmarshaller.Instance;

            return Invoke<HttpRequestWithRegexLiteralResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HttpRequestWithRegexLiteral operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithRegexLiteral operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithRegexLiteral
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithRegexLiteral">REST API Reference for HttpRequestWithRegexLiteral Operation</seealso>
        public virtual IAsyncResult BeginHttpRequestWithRegexLiteral(HttpRequestWithRegexLiteralRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpRequestWithRegexLiteralRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpRequestWithRegexLiteralResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HttpRequestWithRegexLiteral operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpRequestWithRegexLiteral.</param>
        /// 
        /// <returns>Returns a  HttpRequestWithRegexLiteralResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithRegexLiteral">REST API Reference for HttpRequestWithRegexLiteral Operation</seealso>
        public virtual HttpRequestWithRegexLiteralResponse EndHttpRequestWithRegexLiteral(IAsyncResult asyncResult)
        {
            return EndInvoke<HttpRequestWithRegexLiteralResponse>(asyncResult);
        }

        #endregion
        
        #region  HttpResponseCode

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpResponseCode service method.</param>
        /// 
        /// <returns>The response from the HttpResponseCode service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpResponseCode operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpResponseCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
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
        /// <returns>Returns a  HttpResponseCodeResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
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
        /// <returns>The response from the HttpStringPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the HttpStringPayload operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpStringPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
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
        /// <returns>Returns a  HttpStringPayloadResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
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
        /// <returns>The response from the IgnoreQueryParamsInResponse service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the IgnoreQueryParamsInResponse operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIgnoreQueryParamsInResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
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
        /// <returns>Returns a  IgnoreQueryParamsInResponseResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
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
        /// <returns>The response from the InputAndOutputWithHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the InputAndOutputWithHeaders operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInputAndOutputWithHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
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
        /// <returns>Returns a  InputAndOutputWithHeadersResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        public virtual InputAndOutputWithHeadersResponse EndInputAndOutputWithHeaders(IAsyncResult asyncResult)
        {
            return EndInvoke<InputAndOutputWithHeadersResponse>(asyncResult);
        }

        #endregion
        
        #region  JsonBlobs

        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonBlobs service method.</param>
        /// 
        /// <returns>The response from the JsonBlobs service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonBlobs">REST API Reference for JsonBlobs Operation</seealso>
        public virtual JsonBlobsResponse JsonBlobs(JsonBlobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonBlobsResponseUnmarshaller.Instance;

            return Invoke<JsonBlobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the JsonBlobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonBlobs operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonBlobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonBlobs">REST API Reference for JsonBlobs Operation</seealso>
        public virtual IAsyncResult BeginJsonBlobs(JsonBlobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonBlobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  JsonBlobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginJsonBlobs.</param>
        /// 
        /// <returns>Returns a  JsonBlobsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonBlobs">REST API Reference for JsonBlobs Operation</seealso>
        public virtual JsonBlobsResponse EndJsonBlobs(IAsyncResult asyncResult)
        {
            return EndInvoke<JsonBlobsResponse>(asyncResult);
        }

        #endregion
        
        #region  JsonEnums

        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonEnums service method.</param>
        /// 
        /// <returns>The response from the JsonEnums service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the JsonEnums operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
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
        /// <returns>Returns a  JsonEnumsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
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
        /// <returns>The response from the JsonIntEnums service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonIntEnums">REST API Reference for JsonIntEnums Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the JsonIntEnums operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonIntEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonIntEnums">REST API Reference for JsonIntEnums Operation</seealso>
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
        /// <returns>Returns a  JsonIntEnumsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonIntEnums">REST API Reference for JsonIntEnums Operation</seealso>
        public virtual JsonIntEnumsResponse EndJsonIntEnums(IAsyncResult asyncResult)
        {
            return EndInvoke<JsonIntEnumsResponse>(asyncResult);
        }

        #endregion
        
        #region  JsonLists

        /// <summary>
        /// This test case serializes JSON lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal JSON lists.</li> <li>Normal JSON sets.</li> <li>JSON lists of lists.</li>
        /// <li>Lists of structures.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonLists service method.</param>
        /// 
        /// <returns>The response from the JsonLists service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonLists">REST API Reference for JsonLists Operation</seealso>
        public virtual JsonListsResponse JsonLists(JsonListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonListsResponseUnmarshaller.Instance;

            return Invoke<JsonListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the JsonLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonLists operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonLists">REST API Reference for JsonLists Operation</seealso>
        public virtual IAsyncResult BeginJsonLists(JsonListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  JsonLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginJsonLists.</param>
        /// 
        /// <returns>Returns a  JsonListsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonLists">REST API Reference for JsonLists Operation</seealso>
        public virtual JsonListsResponse EndJsonLists(IAsyncResult asyncResult)
        {
            return EndInvoke<JsonListsResponse>(asyncResult);
        }

        #endregion
        
        #region  JsonMaps

        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonMaps service method.</param>
        /// 
        /// <returns>The response from the JsonMaps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonMaps">REST API Reference for JsonMaps Operation</seealso>
        public virtual JsonMapsResponse JsonMaps(JsonMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonMapsResponseUnmarshaller.Instance;

            return Invoke<JsonMapsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the JsonMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonMaps operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonMaps">REST API Reference for JsonMaps Operation</seealso>
        public virtual IAsyncResult BeginJsonMaps(JsonMapsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonMapsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  JsonMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginJsonMaps.</param>
        /// 
        /// <returns>Returns a  JsonMapsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonMaps">REST API Reference for JsonMaps Operation</seealso>
        public virtual JsonMapsResponse EndJsonMaps(IAsyncResult asyncResult)
        {
            return EndInvoke<JsonMapsResponse>(asyncResult);
        }

        #endregion
        
        #region  JsonTimestamps

        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonTimestamps service method.</param>
        /// 
        /// <returns>The response from the JsonTimestamps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonTimestamps">REST API Reference for JsonTimestamps Operation</seealso>
        public virtual JsonTimestampsResponse JsonTimestamps(JsonTimestampsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonTimestampsResponseUnmarshaller.Instance;

            return Invoke<JsonTimestampsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the JsonTimestamps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonTimestamps operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonTimestamps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonTimestamps">REST API Reference for JsonTimestamps Operation</seealso>
        public virtual IAsyncResult BeginJsonTimestamps(JsonTimestampsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonTimestampsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  JsonTimestamps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginJsonTimestamps.</param>
        /// 
        /// <returns>Returns a  JsonTimestampsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonTimestamps">REST API Reference for JsonTimestamps Operation</seealso>
        public virtual JsonTimestampsResponse EndJsonTimestamps(IAsyncResult asyncResult)
        {
            return EndInvoke<JsonTimestampsResponse>(asyncResult);
        }

        #endregion
        
        #region  JsonUnions

        /// <summary>
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions service method.</param>
        /// 
        /// <returns>The response from the JsonUnions service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonUnions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
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
        /// <returns>Returns a  JsonUnionsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        public virtual JsonUnionsResponse EndJsonUnions(IAsyncResult asyncResult)
        {
            return EndInvoke<JsonUnionsResponse>(asyncResult);
        }

        #endregion
        
        #region  MediaTypeHeader

        /// <summary>
        /// This example ensures that mediaType strings are base64 encoded in headers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MediaTypeHeader service method.</param>
        /// 
        /// <returns>The response from the MediaTypeHeader service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/MediaTypeHeader">REST API Reference for MediaTypeHeader Operation</seealso>
        public virtual MediaTypeHeaderResponse MediaTypeHeader(MediaTypeHeaderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MediaTypeHeaderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MediaTypeHeaderResponseUnmarshaller.Instance;

            return Invoke<MediaTypeHeaderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MediaTypeHeader operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MediaTypeHeader operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMediaTypeHeader
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/MediaTypeHeader">REST API Reference for MediaTypeHeader Operation</seealso>
        public virtual IAsyncResult BeginMediaTypeHeader(MediaTypeHeaderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MediaTypeHeaderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MediaTypeHeaderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MediaTypeHeader operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMediaTypeHeader.</param>
        /// 
        /// <returns>Returns a  MediaTypeHeaderResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/MediaTypeHeader">REST API Reference for MediaTypeHeader Operation</seealso>
        public virtual MediaTypeHeaderResponse EndMediaTypeHeader(IAsyncResult asyncResult)
        {
            return EndInvoke<MediaTypeHeaderResponse>(asyncResult);
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
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndNoOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
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
        /// <returns>Returns a  NoInputAndNoOutputResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
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
        /// <returns>The response from the NoInputAndOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
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
        /// <returns>Returns a  NoInputAndOutputResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
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
        /// <returns>The response from the NullAndEmptyHeadersClient service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersClient operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNullAndEmptyHeadersClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
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
        /// <returns>Returns a  NullAndEmptyHeadersClientResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
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
        /// <returns>The response from the NullAndEmptyHeadersServer service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersServer operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNullAndEmptyHeadersServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
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
        /// <returns>Returns a  NullAndEmptyHeadersServerResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
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
        /// <returns>The response from the OmitsNullSerializesEmptyString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the OmitsNullSerializesEmptyString operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOmitsNullSerializesEmptyString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
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
        /// <returns>Returns a  OmitsNullSerializesEmptyStringResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        public virtual OmitsNullSerializesEmptyStringResponse EndOmitsNullSerializesEmptyString(IAsyncResult asyncResult)
        {
            return EndInvoke<OmitsNullSerializesEmptyStringResponse>(asyncResult);
        }

        #endregion
        
        #region  OmitsSerializingEmptyLists

        /// <summary>
        /// Omits serializing empty lists. Because empty strings are serilized as <c>Foo=</c>,
        /// empty lists cannot also be serialized as <c>Foo=</c> and instead must be omitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OmitsSerializingEmptyLists service method.</param>
        /// 
        /// <returns>The response from the OmitsSerializingEmptyLists service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsSerializingEmptyLists">REST API Reference for OmitsSerializingEmptyLists Operation</seealso>
        public virtual OmitsSerializingEmptyListsResponse OmitsSerializingEmptyLists(OmitsSerializingEmptyListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OmitsSerializingEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OmitsSerializingEmptyListsResponseUnmarshaller.Instance;

            return Invoke<OmitsSerializingEmptyListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the OmitsSerializingEmptyLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OmitsSerializingEmptyLists operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOmitsSerializingEmptyLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsSerializingEmptyLists">REST API Reference for OmitsSerializingEmptyLists Operation</seealso>
        public virtual IAsyncResult BeginOmitsSerializingEmptyLists(OmitsSerializingEmptyListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OmitsSerializingEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OmitsSerializingEmptyListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  OmitsSerializingEmptyLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOmitsSerializingEmptyLists.</param>
        /// 
        /// <returns>Returns a  OmitsSerializingEmptyListsResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsSerializingEmptyLists">REST API Reference for OmitsSerializingEmptyLists Operation</seealso>
        public virtual OmitsSerializingEmptyListsResponse EndOmitsSerializingEmptyLists(IAsyncResult asyncResult)
        {
            return EndInvoke<OmitsSerializingEmptyListsResponse>(asyncResult);
        }

        #endregion
        
        #region  PostUnionWithJsonName

        /// <summary>
        /// This operation defines a union that uses jsonName on some members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostUnionWithJsonName service method.</param>
        /// 
        /// <returns>The response from the PostUnionWithJsonName service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PostUnionWithJsonName">REST API Reference for PostUnionWithJsonName Operation</seealso>
        public virtual PostUnionWithJsonNameResponse PostUnionWithJsonName(PostUnionWithJsonNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostUnionWithJsonNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostUnionWithJsonNameResponseUnmarshaller.Instance;

            return Invoke<PostUnionWithJsonNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PostUnionWithJsonName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostUnionWithJsonName operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostUnionWithJsonName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PostUnionWithJsonName">REST API Reference for PostUnionWithJsonName Operation</seealso>
        public virtual IAsyncResult BeginPostUnionWithJsonName(PostUnionWithJsonNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostUnionWithJsonNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostUnionWithJsonNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PostUnionWithJsonName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostUnionWithJsonName.</param>
        /// 
        /// <returns>Returns a  PostUnionWithJsonNameResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PostUnionWithJsonName">REST API Reference for PostUnionWithJsonName Operation</seealso>
        public virtual PostUnionWithJsonNameResponse EndPostUnionWithJsonName(IAsyncResult asyncResult)
        {
            return EndInvoke<PostUnionWithJsonNameResponse>(asyncResult);
        }

        #endregion
        
        #region  PutWithContentEncoding

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWithContentEncoding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
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
        /// <returns>Returns a  PutWithContentEncodingResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
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
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryIdempotencyTokenAutoFill
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
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
        /// <returns>Returns a  QueryIdempotencyTokenAutoFillResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
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
        /// <returns>The response from the QueryParamsAsStringListMap service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the QueryParamsAsStringListMap operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryParamsAsStringListMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
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
        /// <returns>Returns a  QueryParamsAsStringListMapResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
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
        /// <returns>The response from the QueryPrecedence service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the QueryPrecedence operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryPrecedence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
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
        /// <returns>Returns a  QueryPrecedenceResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        public virtual QueryPrecedenceResponse EndQueryPrecedence(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryPrecedenceResponse>(asyncResult);
        }

        #endregion
        
        #region  RecursiveShapes

        /// <summary>
        /// Recursive shapes
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveShapes service method.</param>
        /// 
        /// <returns>The response from the RecursiveShapes service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        public virtual RecursiveShapesResponse RecursiveShapes(RecursiveShapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecursiveShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecursiveShapesResponseUnmarshaller.Instance;

            return Invoke<RecursiveShapesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RecursiveShapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecursiveShapes operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecursiveShapes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        public virtual IAsyncResult BeginRecursiveShapes(RecursiveShapesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecursiveShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecursiveShapesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RecursiveShapes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecursiveShapes.</param>
        /// 
        /// <returns>Returns a  RecursiveShapesResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        public virtual RecursiveShapesResponse EndRecursiveShapes(IAsyncResult asyncResult)
        {
            return EndInvoke<RecursiveShapesResponse>(asyncResult);
        }

        #endregion
        
        #region  ResponseCodeHttpFallback

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResponseCodeHttpFallback service method.</param>
        /// 
        /// <returns>The response from the ResponseCodeHttpFallback service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ResponseCodeHttpFallback">REST API Reference for ResponseCodeHttpFallback Operation</seealso>
        public virtual ResponseCodeHttpFallbackResponse ResponseCodeHttpFallback(ResponseCodeHttpFallbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResponseCodeHttpFallbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResponseCodeHttpFallbackResponseUnmarshaller.Instance;

            return Invoke<ResponseCodeHttpFallbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResponseCodeHttpFallback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResponseCodeHttpFallback operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResponseCodeHttpFallback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ResponseCodeHttpFallback">REST API Reference for ResponseCodeHttpFallback Operation</seealso>
        public virtual IAsyncResult BeginResponseCodeHttpFallback(ResponseCodeHttpFallbackRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResponseCodeHttpFallbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResponseCodeHttpFallbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResponseCodeHttpFallback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResponseCodeHttpFallback.</param>
        /// 
        /// <returns>Returns a  ResponseCodeHttpFallbackResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ResponseCodeHttpFallback">REST API Reference for ResponseCodeHttpFallback Operation</seealso>
        public virtual ResponseCodeHttpFallbackResponse EndResponseCodeHttpFallback(IAsyncResult asyncResult)
        {
            return EndInvoke<ResponseCodeHttpFallbackResponse>(asyncResult);
        }

        #endregion
        
        #region  ResponseCodeRequired

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResponseCodeRequired service method.</param>
        /// 
        /// <returns>The response from the ResponseCodeRequired service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ResponseCodeRequired">REST API Reference for ResponseCodeRequired Operation</seealso>
        public virtual ResponseCodeRequiredResponse ResponseCodeRequired(ResponseCodeRequiredRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResponseCodeRequiredRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResponseCodeRequiredResponseUnmarshaller.Instance;

            return Invoke<ResponseCodeRequiredResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResponseCodeRequired operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResponseCodeRequired operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResponseCodeRequired
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ResponseCodeRequired">REST API Reference for ResponseCodeRequired Operation</seealso>
        public virtual IAsyncResult BeginResponseCodeRequired(ResponseCodeRequiredRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResponseCodeRequiredRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResponseCodeRequiredResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResponseCodeRequired operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResponseCodeRequired.</param>
        /// 
        /// <returns>Returns a  ResponseCodeRequiredResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ResponseCodeRequired">REST API Reference for ResponseCodeRequired Operation</seealso>
        public virtual ResponseCodeRequiredResponse EndResponseCodeRequired(IAsyncResult asyncResult)
        {
            return EndInvoke<ResponseCodeRequiredResponse>(asyncResult);
        }

        #endregion
        
        #region  SimpleScalarProperties

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleScalarProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
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
        /// <returns>Returns a  SimpleScalarPropertiesResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual SimpleScalarPropertiesResponse EndSimpleScalarProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<SimpleScalarPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  TestBodyStructure

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
        /// 
        /// <returns>The response from the TestBodyStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestBodyStructure">REST API Reference for TestBodyStructure Operation</seealso>
        public virtual TestBodyStructureResponse TestBodyStructure(TestBodyStructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestBodyStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBodyStructureResponseUnmarshaller.Instance;

            return Invoke<TestBodyStructureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestBodyStructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestBodyStructure operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestBodyStructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestBodyStructure">REST API Reference for TestBodyStructure Operation</seealso>
        public virtual IAsyncResult BeginTestBodyStructure(TestBodyStructureRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestBodyStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBodyStructureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestBodyStructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestBodyStructure.</param>
        /// 
        /// <returns>Returns a  TestBodyStructureResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestBodyStructure">REST API Reference for TestBodyStructure Operation</seealso>
        public virtual TestBodyStructureResponse EndTestBodyStructure(IAsyncResult asyncResult)
        {
            return EndInvoke<TestBodyStructureResponse>(asyncResult);
        }

        #endregion
        
        #region  TestGetNoInputNoPayload

        /// <summary>
        /// This example GET operation has no input and serializes a request without a HTTP body.
        /// 
        ///  
        /// <para>
        /// These tests are to ensure we do not attach a body or related headers (Content-Length,
        /// Content-Type) to operations that semantically cannot produce an HTTP body.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestGetNoInputNoPayload service method.</param>
        /// 
        /// <returns>The response from the TestGetNoInputNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestGetNoInputNoPayload">REST API Reference for TestGetNoInputNoPayload Operation</seealso>
        public virtual TestGetNoInputNoPayloadResponse TestGetNoInputNoPayload(TestGetNoInputNoPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestGetNoInputNoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestGetNoInputNoPayloadResponseUnmarshaller.Instance;

            return Invoke<TestGetNoInputNoPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestGetNoInputNoPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestGetNoInputNoPayload operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestGetNoInputNoPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestGetNoInputNoPayload">REST API Reference for TestGetNoInputNoPayload Operation</seealso>
        public virtual IAsyncResult BeginTestGetNoInputNoPayload(TestGetNoInputNoPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestGetNoInputNoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestGetNoInputNoPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestGetNoInputNoPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestGetNoInputNoPayload.</param>
        /// 
        /// <returns>Returns a  TestGetNoInputNoPayloadResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestGetNoInputNoPayload">REST API Reference for TestGetNoInputNoPayload Operation</seealso>
        public virtual TestGetNoInputNoPayloadResponse EndTestGetNoInputNoPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<TestGetNoInputNoPayloadResponse>(asyncResult);
        }

        #endregion
        
        #region  TestGetNoPayload

        /// <summary>
        /// This example GET operation serializes a request without a modeled HTTP body.
        /// 
        ///  
        /// <para>
        /// These tests are to ensure we do not attach a body or related headers (Content-Length,
        /// Content-Type) to operations that semantically cannot produce an HTTP body.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestGetNoPayload service method.</param>
        /// 
        /// <returns>The response from the TestGetNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestGetNoPayload">REST API Reference for TestGetNoPayload Operation</seealso>
        public virtual TestGetNoPayloadResponse TestGetNoPayload(TestGetNoPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestGetNoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestGetNoPayloadResponseUnmarshaller.Instance;

            return Invoke<TestGetNoPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestGetNoPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestGetNoPayload operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestGetNoPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestGetNoPayload">REST API Reference for TestGetNoPayload Operation</seealso>
        public virtual IAsyncResult BeginTestGetNoPayload(TestGetNoPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestGetNoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestGetNoPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestGetNoPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestGetNoPayload.</param>
        /// 
        /// <returns>Returns a  TestGetNoPayloadResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestGetNoPayload">REST API Reference for TestGetNoPayload Operation</seealso>
        public virtual TestGetNoPayloadResponse EndTestGetNoPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<TestGetNoPayloadResponse>(asyncResult);
        }

        #endregion
        
        #region  TestPayloadBlob

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
        /// 
        /// <returns>The response from the TestPayloadBlob service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadBlob">REST API Reference for TestPayloadBlob Operation</seealso>
        public virtual TestPayloadBlobResponse TestPayloadBlob(TestPayloadBlobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPayloadBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadBlobResponseUnmarshaller.Instance;

            return Invoke<TestPayloadBlobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestPayloadBlob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestPayloadBlob operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestPayloadBlob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadBlob">REST API Reference for TestPayloadBlob Operation</seealso>
        public virtual IAsyncResult BeginTestPayloadBlob(TestPayloadBlobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPayloadBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadBlobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestPayloadBlob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestPayloadBlob.</param>
        /// 
        /// <returns>Returns a  TestPayloadBlobResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadBlob">REST API Reference for TestPayloadBlob Operation</seealso>
        public virtual TestPayloadBlobResponse EndTestPayloadBlob(IAsyncResult asyncResult)
        {
            return EndInvoke<TestPayloadBlobResponse>(asyncResult);
        }

        #endregion
        
        #region  TestPayloadStructure

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
        /// 
        /// <returns>The response from the TestPayloadStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadStructure">REST API Reference for TestPayloadStructure Operation</seealso>
        public virtual TestPayloadStructureResponse TestPayloadStructure(TestPayloadStructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPayloadStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadStructureResponseUnmarshaller.Instance;

            return Invoke<TestPayloadStructureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestPayloadStructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestPayloadStructure operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestPayloadStructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadStructure">REST API Reference for TestPayloadStructure Operation</seealso>
        public virtual IAsyncResult BeginTestPayloadStructure(TestPayloadStructureRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPayloadStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadStructureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestPayloadStructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestPayloadStructure.</param>
        /// 
        /// <returns>Returns a  TestPayloadStructureResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadStructure">REST API Reference for TestPayloadStructure Operation</seealso>
        public virtual TestPayloadStructureResponse EndTestPayloadStructure(IAsyncResult asyncResult)
        {
            return EndInvoke<TestPayloadStructureResponse>(asyncResult);
        }

        #endregion
        
        #region  TestPostNoInputNoPayload

        /// <summary>
        /// This example POST operation has no input and serializes a request without a HTTP body.
        /// 
        ///  
        /// <para>
        /// These tests are to ensure we do not attach a body or related headers (Content-Type)
        /// to a POST operation with no modeled input.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPostNoInputNoPayload service method.</param>
        /// 
        /// <returns>The response from the TestPostNoInputNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPostNoInputNoPayload">REST API Reference for TestPostNoInputNoPayload Operation</seealso>
        public virtual TestPostNoInputNoPayloadResponse TestPostNoInputNoPayload(TestPostNoInputNoPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPostNoInputNoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPostNoInputNoPayloadResponseUnmarshaller.Instance;

            return Invoke<TestPostNoInputNoPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestPostNoInputNoPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestPostNoInputNoPayload operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestPostNoInputNoPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPostNoInputNoPayload">REST API Reference for TestPostNoInputNoPayload Operation</seealso>
        public virtual IAsyncResult BeginTestPostNoInputNoPayload(TestPostNoInputNoPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPostNoInputNoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPostNoInputNoPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestPostNoInputNoPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestPostNoInputNoPayload.</param>
        /// 
        /// <returns>Returns a  TestPostNoInputNoPayloadResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPostNoInputNoPayload">REST API Reference for TestPostNoInputNoPayload Operation</seealso>
        public virtual TestPostNoInputNoPayloadResponse EndTestPostNoInputNoPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<TestPostNoInputNoPayloadResponse>(asyncResult);
        }

        #endregion
        
        #region  TestPostNoPayload

        /// <summary>
        /// This example POST operation serializes a request without a modeled HTTP body.
        /// 
        ///  
        /// <para>
        /// These tests are to ensure we do not attach a body or related headers (Content-Type)
        /// to a POST operation with no modeled payload.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPostNoPayload service method.</param>
        /// 
        /// <returns>The response from the TestPostNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPostNoPayload">REST API Reference for TestPostNoPayload Operation</seealso>
        public virtual TestPostNoPayloadResponse TestPostNoPayload(TestPostNoPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPostNoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPostNoPayloadResponseUnmarshaller.Instance;

            return Invoke<TestPostNoPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestPostNoPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestPostNoPayload operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestPostNoPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPostNoPayload">REST API Reference for TestPostNoPayload Operation</seealso>
        public virtual IAsyncResult BeginTestPostNoPayload(TestPostNoPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPostNoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPostNoPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestPostNoPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestPostNoPayload.</param>
        /// 
        /// <returns>Returns a  TestPostNoPayloadResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPostNoPayload">REST API Reference for TestPostNoPayload Operation</seealso>
        public virtual TestPostNoPayloadResponse EndTestPostNoPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<TestPostNoPayloadResponse>(asyncResult);
        }

        #endregion
        
        #region  TimestampFormatHeaders

        /// <summary>
        /// This example tests how timestamp request and response headers are serialized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders service method.</param>
        /// 
        /// <returns>The response from the TimestampFormatHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTimestampFormatHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
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
        /// <returns>Returns a  TimestampFormatHeadersResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        public virtual TimestampFormatHeadersResponse EndTimestampFormatHeaders(IAsyncResult asyncResult)
        {
            return EndInvoke<TimestampFormatHeadersResponse>(asyncResult);
        }

        #endregion
        
        #region  UnitInputAndOutput

        /// <summary>
        /// This test is similar to NoInputAndNoOutput, but uses explicit Unit types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnitInputAndOutput service method.</param>
        /// 
        /// <returns>The response from the UnitInputAndOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/UnitInputAndOutput">REST API Reference for UnitInputAndOutput Operation</seealso>
        public virtual UnitInputAndOutputResponse UnitInputAndOutput(UnitInputAndOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnitInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnitInputAndOutputResponseUnmarshaller.Instance;

            return Invoke<UnitInputAndOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnitInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnitInputAndOutput operation on AmazonRestJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnitInputAndOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/UnitInputAndOutput">REST API Reference for UnitInputAndOutput Operation</seealso>
        public virtual IAsyncResult BeginUnitInputAndOutput(UnitInputAndOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnitInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnitInputAndOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnitInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnitInputAndOutput.</param>
        /// 
        /// <returns>Returns a  UnitInputAndOutputResult from RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/UnitInputAndOutput">REST API Reference for UnitInputAndOutput Operation</seealso>
        public virtual UnitInputAndOutputResponse EndUnitInputAndOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<UnitInputAndOutputResponse>(asyncResult);
        }

        #endregion
        
    }
}