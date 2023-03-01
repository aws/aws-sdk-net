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
 * Do not modify this file. This file is generated from the s3outposts-2017-07-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.S3Outposts.Model;

namespace Amazon.S3Outposts
{
    /// <summary>
    /// Interface for accessing S3Outposts
    ///
    /// Amazon S3 on Outposts provides access to S3 on Outposts operations.
    /// </summary>
    public partial interface IAmazonS3Outposts : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IS3OutpostsPaginatorFactory Paginators { get; }

        
        #region  CreateEndpoint


        /// <summary>
        /// Creates an endpoint and associates it with the specified Outpost.
        /// 
        ///  <note> 
        /// <para>
        /// It can take up to 5 minutes for this action to finish.
        /// </para>
        ///  </note>  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_ListEndpoints.html">ListEndpoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);



        /// <summary>
        /// Creates an endpoint and associates it with the specified Outpost.
        /// 
        ///  <note> 
        /// <para>
        /// It can take up to 5 minutes for this action to finish.
        /// </para>
        ///  </note>  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_ListEndpoints.html">ListEndpoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Deletes an endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// It can take up to 5 minutes for this action to finish.
        /// </para>
        ///  </note>  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_ListEndpoints.html">ListEndpoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);



        /// <summary>
        /// Deletes an endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// It can take up to 5 minutes for this action to finish.
        /// </para>
        ///  </note>  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_ListEndpoints.html">ListEndpoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEndpoints


        /// <summary>
        /// Lists endpoints associated with the specified Outpost. 
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        ListEndpointsResponse ListEndpoints(ListEndpointsRequest request);



        /// <summary>
        /// Lists endpoints associated with the specified Outpost. 
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOutpostsWithS3


        /// <summary>
        /// Lists the Outposts with S3 on Outposts capacity for your Amazon Web Services account.
        /// Includes S3 on Outposts that you have access to as the Outposts owner, or as a shared
        /// user from Resource Access Manager (RAM).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutpostsWithS3 service method.</param>
        /// 
        /// <returns>The response from the ListOutpostsWithS3 service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListOutpostsWithS3">REST API Reference for ListOutpostsWithS3 Operation</seealso>
        ListOutpostsWithS3Response ListOutpostsWithS3(ListOutpostsWithS3Request request);



        /// <summary>
        /// Lists the Outposts with S3 on Outposts capacity for your Amazon Web Services account.
        /// Includes S3 on Outposts that you have access to as the Outposts owner, or as a shared
        /// user from Resource Access Manager (RAM).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutpostsWithS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOutpostsWithS3 service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListOutpostsWithS3">REST API Reference for ListOutpostsWithS3 Operation</seealso>
        Task<ListOutpostsWithS3Response> ListOutpostsWithS3Async(ListOutpostsWithS3Request request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSharedEndpoints


        /// <summary>
        /// Lists all endpoints associated with an Outpost that has been shared by Amazon Web
        /// Services Resource Access Manager (RAM).
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListSharedEndpoints service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListSharedEndpoints">REST API Reference for ListSharedEndpoints Operation</seealso>
        ListSharedEndpointsResponse ListSharedEndpoints(ListSharedEndpointsRequest request);



        /// <summary>
        /// Lists all endpoints associated with an Outpost that has been shared by Amazon Web
        /// Services Resource Access Manager (RAM).
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSharedEndpoints service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListSharedEndpoints">REST API Reference for ListSharedEndpoints Operation</seealso>
        Task<ListSharedEndpointsResponse> ListSharedEndpointsAsync(ListSharedEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}