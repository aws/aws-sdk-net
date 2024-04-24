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
 * Do not modify this file. This file is generated from the cloudfront-keyvaluestore-2022-07-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudFrontKeyValueStore.Model;

#pragma warning disable CS1570
namespace Amazon.CloudFrontKeyValueStore
{
    /// <summary>
    /// <para>Interface for accessing CloudFrontKeyValueStore</para>
    ///
    /// Amazon CloudFront KeyValueStore Service to View and Update Data in a KVS Resource
    /// </summary>
    public partial interface IAmazonCloudFrontKeyValueStore : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudFrontKeyValueStorePaginatorFactory Paginators { get; }
#endif


        
        #region  DeleteKey


        /// <summary>
        /// Deletes the key value pair specified by the key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKey service method.</param>
        /// 
        /// <returns>The response from the DeleteKey service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ServiceQuotaExceededException">
        /// Limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        DeleteKeyResponse DeleteKey(DeleteKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKey operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        IAsyncResult BeginDeleteKey(DeleteKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKey.</param>
        /// 
        /// <returns>Returns a  DeleteKeyResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        DeleteKeyResponse EndDeleteKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeKeyValueStore


        /// <summary>
        /// Returns metadata information about Key Value Store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyValueStore service method.</param>
        /// 
        /// <returns>The response from the DescribeKeyValueStore service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        DescribeKeyValueStoreResponse DescribeKeyValueStore(DescribeKeyValueStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyValueStore operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKeyValueStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        IAsyncResult BeginDescribeKeyValueStore(DescribeKeyValueStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyValueStore.</param>
        /// 
        /// <returns>Returns a  DescribeKeyValueStoreResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        DescribeKeyValueStoreResponse EndDescribeKeyValueStore(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKey


        /// <summary>
        /// Returns a key value pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKey service method.</param>
        /// 
        /// <returns>The response from the GetKey service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/GetKey">REST API Reference for GetKey Operation</seealso>
        GetKeyResponse GetKey(GetKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKey operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/GetKey">REST API Reference for GetKey Operation</seealso>
        IAsyncResult BeginGetKey(GetKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKey.</param>
        /// 
        /// <returns>Returns a  GetKeyResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/GetKey">REST API Reference for GetKey Operation</seealso>
        GetKeyResponse EndGetKey(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKeys


        /// <summary>
        /// Returns a list of key value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/ListKeys">REST API Reference for ListKeys Operation</seealso>
        ListKeysResponse ListKeys(ListKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeys operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/ListKeys">REST API Reference for ListKeys Operation</seealso>
        IAsyncResult BeginListKeys(ListKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeys.</param>
        /// 
        /// <returns>Returns a  ListKeysResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/ListKeys">REST API Reference for ListKeys Operation</seealso>
        ListKeysResponse EndListKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  PutKey


        /// <summary>
        /// Creates a new key value pair or replaces the value of an existing key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKey service method.</param>
        /// 
        /// <returns>The response from the PutKey service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ServiceQuotaExceededException">
        /// Limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/PutKey">REST API Reference for PutKey Operation</seealso>
        PutKeyResponse PutKey(PutKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKey operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/PutKey">REST API Reference for PutKey Operation</seealso>
        IAsyncResult BeginPutKey(PutKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutKey.</param>
        /// 
        /// <returns>Returns a  PutKeyResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/PutKey">REST API Reference for PutKey Operation</seealso>
        PutKeyResponse EndPutKey(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKeys


        /// <summary>
        /// Puts or Deletes multiple key value pairs in a single, all-or-nothing operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeys service method.</param>
        /// 
        /// <returns>The response from the UpdateKeys service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ServiceQuotaExceededException">
        /// Limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/UpdateKeys">REST API Reference for UpdateKeys Operation</seealso>
        UpdateKeysResponse UpdateKeys(UpdateKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeys operation on AmazonCloudFrontKeyValueStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/UpdateKeys">REST API Reference for UpdateKeys Operation</seealso>
        IAsyncResult BeginUpdateKeys(UpdateKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKeys.</param>
        /// 
        /// <returns>Returns a  UpdateKeysResult from CloudFrontKeyValueStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/UpdateKeys">REST API Reference for UpdateKeys Operation</seealso>
        UpdateKeysResponse EndUpdateKeys(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}