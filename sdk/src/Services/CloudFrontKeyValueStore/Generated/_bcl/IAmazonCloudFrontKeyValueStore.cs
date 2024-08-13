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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudFrontKeyValueStorePaginatorFactory Paginators { get; }

        
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
        /// Deletes the key value pair specified by the key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteKeyResponse> DeleteKeyAsync(DeleteKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns metadata information about Key Value Store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyValueStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeKeyValueStoreResponse> DescribeKeyValueStoreAsync(DescribeKeyValueStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a key value pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetKeyResponse> GetKeyAsync(GetKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of key value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new key value pair or replaces the value of an existing key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutKeyResponse> PutKeyAsync(PutKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Puts or Deletes multiple key value pairs in a single, all-or-nothing operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateKeysResponse> UpdateKeysAsync(UpdateKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

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