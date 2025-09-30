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
 * Do not modify this file. This file is generated from the rest-json-test-2016-04-12.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.RestJsonTest.Model;
using Amazon.RestJsonTest.Model.Internal.MarshallTransformations;
using Amazon.RestJsonTest.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.RestJsonTest
{
    /// <summary>
    /// <para>Implementation for accessing RestJsonTest</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonRestJsonTestClient : AmazonServiceClient, IAmazonRestJsonTest
    {
        private static IServiceMetadata serviceMetadata = new AmazonRestJsonTestMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with the credentials loaded from the application's
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
        public AmazonRestJsonTestClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRestJsonTestConfig()) { }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with the credentials loaded from the application's
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
        public AmazonRestJsonTestClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRestJsonTestConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(AmazonRestJsonTestConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRestJsonTestClient(AWSCredentials credentials)
            : this(credentials, new AmazonRestJsonTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonTestClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRestJsonTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Credentials and an
        /// AmazonRestJsonTestClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(AWSCredentials credentials, AmazonRestJsonTestConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestJsonTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestJsonTestConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestJsonTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRestJsonTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestJsonTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestJsonTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestJsonTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRestJsonTestConfig clientConfig)
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


        #region  MemberRefOp

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MemberRefOp service method.</param>
        /// 
        /// <returns>The response from the MemberRefOp service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        public virtual MemberRefOpResponse MemberRefOp(MemberRefOpRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MemberRefOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MemberRefOpResponseUnmarshaller.Instance;

            return Invoke<MemberRefOpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MemberRefOp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MemberRefOp operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMemberRefOp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        public virtual IAsyncResult BeginMemberRefOp(MemberRefOpRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MemberRefOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MemberRefOpResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MemberRefOp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMemberRefOp.</param>
        /// 
        /// <returns>Returns a  MemberRefOpResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        public virtual MemberRefOpResponse EndMemberRefOp(IAsyncResult asyncResult)
        {
            return EndInvoke<MemberRefOpResponse>(asyncResult);
        }

        #endregion
        
        #region  NoPayload

        /// <summary>
        /// Request without a body
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoPayload service method.</param>
        /// 
        /// <returns>The response from the NoPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayload">REST API Reference for NoPayload Operation</seealso>
        public virtual NoPayloadResponse NoPayload(NoPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadResponseUnmarshaller.Instance;

            return Invoke<NoPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NoPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoPayload operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayload">REST API Reference for NoPayload Operation</seealso>
        public virtual IAsyncResult BeginNoPayload(NoPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NoPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoPayload.</param>
        /// 
        /// <returns>Returns a  NoPayloadResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayload">REST API Reference for NoPayload Operation</seealso>
        public virtual NoPayloadResponse EndNoPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<NoPayloadResponse>(asyncResult);
        }

        #endregion
        
        #region  NoPayloadPost

        /// <summary>
        /// A POST request without a body, for verifying that we don't set a Content-Type even
        /// though a POST could have a body
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoPayloadPost service method.</param>
        /// 
        /// <returns>The response from the NoPayloadPost service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayloadPost">REST API Reference for NoPayloadPost Operation</seealso>
        public virtual NoPayloadPostResponse NoPayloadPost(NoPayloadPostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoPayloadPostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadPostResponseUnmarshaller.Instance;

            return Invoke<NoPayloadPostResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NoPayloadPost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoPayloadPost operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoPayloadPost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayloadPost">REST API Reference for NoPayloadPost Operation</seealso>
        public virtual IAsyncResult BeginNoPayloadPost(NoPayloadPostRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoPayloadPostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadPostResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NoPayloadPost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoPayloadPost.</param>
        /// 
        /// <returns>Returns a  NoPayloadPostResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayloadPost">REST API Reference for NoPayloadPost Operation</seealso>
        public virtual NoPayloadPostResponse EndNoPayloadPost(IAsyncResult asyncResult)
        {
            return EndInvoke<NoPayloadPostResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryBooleanList

        /// <summary>
        /// Handles query string lists of boolean
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryBooleanList service method.</param>
        /// 
        /// <returns>The response from the QueryBooleanList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryBooleanList">REST API Reference for QueryBooleanList Operation</seealso>
        public virtual QueryBooleanListResponse QueryBooleanList(QueryBooleanListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryBooleanListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryBooleanListResponseUnmarshaller.Instance;

            return Invoke<QueryBooleanListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryBooleanList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryBooleanList operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryBooleanList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryBooleanList">REST API Reference for QueryBooleanList Operation</seealso>
        public virtual IAsyncResult BeginQueryBooleanList(QueryBooleanListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryBooleanListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryBooleanListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryBooleanList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryBooleanList.</param>
        /// 
        /// <returns>Returns a  QueryBooleanListResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryBooleanList">REST API Reference for QueryBooleanList Operation</seealso>
        public virtual QueryBooleanListResponse EndQueryBooleanList(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryBooleanListResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryIntegerList

        /// <summary>
        /// Handles query string lists of integer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIntegerList service method.</param>
        /// 
        /// <returns>The response from the QueryIntegerList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerList">REST API Reference for QueryIntegerList Operation</seealso>
        public virtual QueryIntegerListResponse QueryIntegerList(QueryIntegerListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIntegerListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIntegerListResponseUnmarshaller.Instance;

            return Invoke<QueryIntegerListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryIntegerList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryIntegerList operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryIntegerList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerList">REST API Reference for QueryIntegerList Operation</seealso>
        public virtual IAsyncResult BeginQueryIntegerList(QueryIntegerListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIntegerListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIntegerListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryIntegerList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryIntegerList.</param>
        /// 
        /// <returns>Returns a  QueryIntegerListResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerList">REST API Reference for QueryIntegerList Operation</seealso>
        public virtual QueryIntegerListResponse EndQueryIntegerList(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryIntegerListResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryIntegerListMap

        /// <summary>
        /// Handles query string maps of lists of integers
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIntegerListMap service method.</param>
        /// 
        /// <returns>The response from the QueryIntegerListMap service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerListMap">REST API Reference for QueryIntegerListMap Operation</seealso>
        public virtual QueryIntegerListMapResponse QueryIntegerListMap(QueryIntegerListMapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIntegerListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIntegerListMapResponseUnmarshaller.Instance;

            return Invoke<QueryIntegerListMapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryIntegerListMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryIntegerListMap operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryIntegerListMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerListMap">REST API Reference for QueryIntegerListMap Operation</seealso>
        public virtual IAsyncResult BeginQueryIntegerListMap(QueryIntegerListMapRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIntegerListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIntegerListMapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryIntegerListMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryIntegerListMap.</param>
        /// 
        /// <returns>Returns a  QueryIntegerListMapResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerListMap">REST API Reference for QueryIntegerListMap Operation</seealso>
        public virtual QueryIntegerListMapResponse EndQueryIntegerListMap(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryIntegerListMapResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryStringEscaping

        /// <summary>
        /// Handles query string escaping
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryStringEscaping service method.</param>
        /// 
        /// <returns>The response from the QueryStringEscaping service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringEscaping">REST API Reference for QueryStringEscaping Operation</seealso>
        public virtual QueryStringEscapingResponse QueryStringEscaping(QueryStringEscapingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringEscapingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringEscapingResponseUnmarshaller.Instance;

            return Invoke<QueryStringEscapingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryStringEscaping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryStringEscaping operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryStringEscaping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringEscaping">REST API Reference for QueryStringEscaping Operation</seealso>
        public virtual IAsyncResult BeginQueryStringEscaping(QueryStringEscapingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringEscapingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringEscapingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryStringEscaping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryStringEscaping.</param>
        /// 
        /// <returns>Returns a  QueryStringEscapingResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringEscaping">REST API Reference for QueryStringEscaping Operation</seealso>
        public virtual QueryStringEscapingResponse EndQueryStringEscaping(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryStringEscapingResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryStringList

        /// <summary>
        /// Handles query string lists of string
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryStringList service method.</param>
        /// 
        /// <returns>The response from the QueryStringList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringList">REST API Reference for QueryStringList Operation</seealso>
        public virtual QueryStringListResponse QueryStringList(QueryStringListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringListResponseUnmarshaller.Instance;

            return Invoke<QueryStringListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryStringList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryStringList operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryStringList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringList">REST API Reference for QueryStringList Operation</seealso>
        public virtual IAsyncResult BeginQueryStringList(QueryStringListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryStringList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryStringList.</param>
        /// 
        /// <returns>Returns a  QueryStringListResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringList">REST API Reference for QueryStringList Operation</seealso>
        public virtual QueryStringListResponse EndQueryStringList(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryStringListResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryStringListMap

        /// <summary>
        /// Handles query string maps of lists of string
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryStringListMap service method.</param>
        /// 
        /// <returns>The response from the QueryStringListMap service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringListMap">REST API Reference for QueryStringListMap Operation</seealso>
        public virtual QueryStringListMapResponse QueryStringListMap(QueryStringListMapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringListMapResponseUnmarshaller.Instance;

            return Invoke<QueryStringListMapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryStringListMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryStringListMap operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryStringListMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringListMap">REST API Reference for QueryStringListMap Operation</seealso>
        public virtual IAsyncResult BeginQueryStringListMap(QueryStringListMapRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryStringListMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryStringListMapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryStringListMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryStringListMap.</param>
        /// 
        /// <returns>Returns a  QueryStringListMapResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringListMap">REST API Reference for QueryStringListMap Operation</seealso>
        public virtual QueryStringListMapResponse EndQueryStringListMap(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryStringListMapResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryTimestampList

        /// <summary>
        /// Handles query string lists of timestamp
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryTimestampList service method.</param>
        /// 
        /// <returns>The response from the QueryTimestampList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryTimestampList">REST API Reference for QueryTimestampList Operation</seealso>
        public virtual QueryTimestampListResponse QueryTimestampList(QueryTimestampListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryTimestampListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryTimestampListResponseUnmarshaller.Instance;

            return Invoke<QueryTimestampListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryTimestampList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryTimestampList operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryTimestampList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryTimestampList">REST API Reference for QueryTimestampList Operation</seealso>
        public virtual IAsyncResult BeginQueryTimestampList(QueryTimestampListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryTimestampListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryTimestampListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryTimestampList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryTimestampList.</param>
        /// 
        /// <returns>Returns a  QueryTimestampListResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryTimestampList">REST API Reference for QueryTimestampList Operation</seealso>
        public virtual QueryTimestampListResponse EndQueryTimestampList(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryTimestampListResponse>(asyncResult);
        }

        #endregion
        
        #region  StaticOp

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StaticOp service method.</param>
        /// 
        /// <returns>The response from the StaticOp service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/StaticOp">REST API Reference for StaticOp Operation</seealso>
        public virtual StaticOpResponse StaticOp(StaticOpRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StaticOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StaticOpResponseUnmarshaller.Instance;

            return Invoke<StaticOpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StaticOp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StaticOp operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStaticOp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/StaticOp">REST API Reference for StaticOp Operation</seealso>
        public virtual IAsyncResult BeginStaticOp(StaticOpRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StaticOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StaticOpResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StaticOp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStaticOp.</param>
        /// 
        /// <returns>Returns a  StaticOpResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/StaticOp">REST API Reference for StaticOp Operation</seealso>
        public virtual StaticOpResponse EndStaticOp(IAsyncResult asyncResult)
        {
            return EndInvoke<StaticOpResponse>(asyncResult);
        }

        #endregion
        
        #region  TestBlobPayload

        /// <summary>
        /// Post a test blob payload request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBlobPayload service method.</param>
        /// 
        /// <returns>The response from the TestBlobPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBlobPayload">REST API Reference for TestBlobPayload Operation</seealso>
        public virtual TestBlobPayloadResponse TestBlobPayload(TestBlobPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestBlobPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBlobPayloadResponseUnmarshaller.Instance;

            return Invoke<TestBlobPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestBlobPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestBlobPayload operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestBlobPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBlobPayload">REST API Reference for TestBlobPayload Operation</seealso>
        public virtual IAsyncResult BeginTestBlobPayload(TestBlobPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestBlobPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBlobPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestBlobPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestBlobPayload.</param>
        /// 
        /// <returns>Returns a  TestBlobPayloadResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBlobPayload">REST API Reference for TestBlobPayload Operation</seealso>
        public virtual TestBlobPayloadResponse EndTestBlobPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<TestBlobPayloadResponse>(asyncResult);
        }

        #endregion
        
        #region  TestBody

        /// <summary>
        /// Post a test body request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBody service method.</param>
        /// 
        /// <returns>The response from the TestBody service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBody">REST API Reference for TestBody Operation</seealso>
        public virtual TestBodyResponse TestBody(TestBodyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestBodyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBodyResponseUnmarshaller.Instance;

            return Invoke<TestBodyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestBody operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestBody operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestBody
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBody">REST API Reference for TestBody Operation</seealso>
        public virtual IAsyncResult BeginTestBody(TestBodyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestBodyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBodyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestBody operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestBody.</param>
        /// 
        /// <returns>Returns a  TestBodyResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBody">REST API Reference for TestBody Operation</seealso>
        public virtual TestBodyResponse EndTestBody(IAsyncResult asyncResult)
        {
            return EndInvoke<TestBodyResponse>(asyncResult);
        }

        #endregion
        
        #region  TestPayload

        /// <summary>
        /// Post a test payload request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayload service method.</param>
        /// 
        /// <returns>The response from the TestPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestPayload">REST API Reference for TestPayload Operation</seealso>
        public virtual TestPayloadResponse TestPayload(TestPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadResponseUnmarshaller.Instance;

            return Invoke<TestPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestPayload operation on AmazonRestJsonTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestPayload">REST API Reference for TestPayload Operation</seealso>
        public virtual IAsyncResult BeginTestPayload(TestPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestPayload.</param>
        /// 
        /// <returns>Returns a  TestPayloadResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestPayload">REST API Reference for TestPayload Operation</seealso>
        public virtual TestPayloadResponse EndTestPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<TestPayloadResponse>(asyncResult);
        }

        #endregion
        
    }
}