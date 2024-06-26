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

using Amazon.Runtime;
using Amazon.RestJsonTest.Model;

#pragma warning disable CS1570
namespace Amazon.RestJsonTest
{
    /// <summary>
    /// <para>Interface for accessing RestJsonTest</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRestJsonTest : IAmazonService, IDisposable
    {




        
        #region  MemberRefOp


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MemberRefOp service method.</param>
        /// 
        /// <returns>The response from the MemberRefOp service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        MemberRefOpResponse MemberRefOp(MemberRefOpRequest request);

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
        IAsyncResult BeginMemberRefOp(MemberRefOpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MemberRefOp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMemberRefOp.</param>
        /// 
        /// <returns>Returns a  MemberRefOpResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        MemberRefOpResponse EndMemberRefOp(IAsyncResult asyncResult);

        #endregion
        
        #region  NoPayload


        /// <summary>
        /// Request without a body
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoPayload service method.</param>
        /// 
        /// <returns>The response from the NoPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayload">REST API Reference for NoPayload Operation</seealso>
        NoPayloadResponse NoPayload(NoPayloadRequest request);

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
        IAsyncResult BeginNoPayload(NoPayloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NoPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoPayload.</param>
        /// 
        /// <returns>Returns a  NoPayloadResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayload">REST API Reference for NoPayload Operation</seealso>
        NoPayloadResponse EndNoPayload(IAsyncResult asyncResult);

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
        NoPayloadPostResponse NoPayloadPost(NoPayloadPostRequest request);

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
        IAsyncResult BeginNoPayloadPost(NoPayloadPostRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NoPayloadPost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoPayloadPost.</param>
        /// 
        /// <returns>Returns a  NoPayloadPostResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayloadPost">REST API Reference for NoPayloadPost Operation</seealso>
        NoPayloadPostResponse EndNoPayloadPost(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryBooleanList


        /// <summary>
        /// Handles query string lists of boolean
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryBooleanList service method.</param>
        /// 
        /// <returns>The response from the QueryBooleanList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryBooleanList">REST API Reference for QueryBooleanList Operation</seealso>
        QueryBooleanListResponse QueryBooleanList(QueryBooleanListRequest request);

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
        IAsyncResult BeginQueryBooleanList(QueryBooleanListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryBooleanList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryBooleanList.</param>
        /// 
        /// <returns>Returns a  QueryBooleanListResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryBooleanList">REST API Reference for QueryBooleanList Operation</seealso>
        QueryBooleanListResponse EndQueryBooleanList(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryIntegerList


        /// <summary>
        /// Handles query string lists of integer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIntegerList service method.</param>
        /// 
        /// <returns>The response from the QueryIntegerList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerList">REST API Reference for QueryIntegerList Operation</seealso>
        QueryIntegerListResponse QueryIntegerList(QueryIntegerListRequest request);

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
        IAsyncResult BeginQueryIntegerList(QueryIntegerListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryIntegerList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryIntegerList.</param>
        /// 
        /// <returns>Returns a  QueryIntegerListResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerList">REST API Reference for QueryIntegerList Operation</seealso>
        QueryIntegerListResponse EndQueryIntegerList(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryIntegerListMap


        /// <summary>
        /// Handles query string maps of lists of integers
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIntegerListMap service method.</param>
        /// 
        /// <returns>The response from the QueryIntegerListMap service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerListMap">REST API Reference for QueryIntegerListMap Operation</seealso>
        QueryIntegerListMapResponse QueryIntegerListMap(QueryIntegerListMapRequest request);

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
        IAsyncResult BeginQueryIntegerListMap(QueryIntegerListMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryIntegerListMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryIntegerListMap.</param>
        /// 
        /// <returns>Returns a  QueryIntegerListMapResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryIntegerListMap">REST API Reference for QueryIntegerListMap Operation</seealso>
        QueryIntegerListMapResponse EndQueryIntegerListMap(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryStringEscaping


        /// <summary>
        /// Handles query string escaping
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryStringEscaping service method.</param>
        /// 
        /// <returns>The response from the QueryStringEscaping service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringEscaping">REST API Reference for QueryStringEscaping Operation</seealso>
        QueryStringEscapingResponse QueryStringEscaping(QueryStringEscapingRequest request);

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
        IAsyncResult BeginQueryStringEscaping(QueryStringEscapingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryStringEscaping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryStringEscaping.</param>
        /// 
        /// <returns>Returns a  QueryStringEscapingResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringEscaping">REST API Reference for QueryStringEscaping Operation</seealso>
        QueryStringEscapingResponse EndQueryStringEscaping(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryStringList


        /// <summary>
        /// Handles query string lists of string
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryStringList service method.</param>
        /// 
        /// <returns>The response from the QueryStringList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringList">REST API Reference for QueryStringList Operation</seealso>
        QueryStringListResponse QueryStringList(QueryStringListRequest request);

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
        IAsyncResult BeginQueryStringList(QueryStringListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryStringList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryStringList.</param>
        /// 
        /// <returns>Returns a  QueryStringListResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringList">REST API Reference for QueryStringList Operation</seealso>
        QueryStringListResponse EndQueryStringList(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryStringListMap


        /// <summary>
        /// Handles query string maps of lists of string
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryStringListMap service method.</param>
        /// 
        /// <returns>The response from the QueryStringListMap service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringListMap">REST API Reference for QueryStringListMap Operation</seealso>
        QueryStringListMapResponse QueryStringListMap(QueryStringListMapRequest request);

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
        IAsyncResult BeginQueryStringListMap(QueryStringListMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryStringListMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryStringListMap.</param>
        /// 
        /// <returns>Returns a  QueryStringListMapResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryStringListMap">REST API Reference for QueryStringListMap Operation</seealso>
        QueryStringListMapResponse EndQueryStringListMap(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryTimestampList


        /// <summary>
        /// Handles query string lists of timestamp
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryTimestampList service method.</param>
        /// 
        /// <returns>The response from the QueryTimestampList service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryTimestampList">REST API Reference for QueryTimestampList Operation</seealso>
        QueryTimestampListResponse QueryTimestampList(QueryTimestampListRequest request);

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
        IAsyncResult BeginQueryTimestampList(QueryTimestampListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryTimestampList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryTimestampList.</param>
        /// 
        /// <returns>Returns a  QueryTimestampListResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/QueryTimestampList">REST API Reference for QueryTimestampList Operation</seealso>
        QueryTimestampListResponse EndQueryTimestampList(IAsyncResult asyncResult);

        #endregion
        
        #region  StaticOp


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StaticOp service method.</param>
        /// 
        /// <returns>The response from the StaticOp service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/StaticOp">REST API Reference for StaticOp Operation</seealso>
        StaticOpResponse StaticOp(StaticOpRequest request);

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
        IAsyncResult BeginStaticOp(StaticOpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StaticOp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStaticOp.</param>
        /// 
        /// <returns>Returns a  StaticOpResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/StaticOp">REST API Reference for StaticOp Operation</seealso>
        StaticOpResponse EndStaticOp(IAsyncResult asyncResult);

        #endregion
        
        #region  TestBlobPayload


        /// <summary>
        /// Post a test blob payload request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBlobPayload service method.</param>
        /// 
        /// <returns>The response from the TestBlobPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBlobPayload">REST API Reference for TestBlobPayload Operation</seealso>
        TestBlobPayloadResponse TestBlobPayload(TestBlobPayloadRequest request);

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
        IAsyncResult BeginTestBlobPayload(TestBlobPayloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestBlobPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestBlobPayload.</param>
        /// 
        /// <returns>Returns a  TestBlobPayloadResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBlobPayload">REST API Reference for TestBlobPayload Operation</seealso>
        TestBlobPayloadResponse EndTestBlobPayload(IAsyncResult asyncResult);

        #endregion
        
        #region  TestBody


        /// <summary>
        /// Post a test body request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBody service method.</param>
        /// 
        /// <returns>The response from the TestBody service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBody">REST API Reference for TestBody Operation</seealso>
        TestBodyResponse TestBody(TestBodyRequest request);

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
        IAsyncResult BeginTestBody(TestBodyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestBody operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestBody.</param>
        /// 
        /// <returns>Returns a  TestBodyResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBody">REST API Reference for TestBody Operation</seealso>
        TestBodyResponse EndTestBody(IAsyncResult asyncResult);

        #endregion
        
        #region  TestPayload


        /// <summary>
        /// Post a test payload request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayload service method.</param>
        /// 
        /// <returns>The response from the TestPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestPayload">REST API Reference for TestPayload Operation</seealso>
        TestPayloadResponse TestPayload(TestPayloadRequest request);

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
        IAsyncResult BeginTestPayload(TestPayloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestPayload.</param>
        /// 
        /// <returns>Returns a  TestPayloadResult from RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestPayload">REST API Reference for TestPayload Operation</seealso>
        TestPayloadResponse EndTestPayload(IAsyncResult asyncResult);

        #endregion
        
    }
}