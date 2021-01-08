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
        /// S3 on Outposts access points simplify managing data access at scale for shared datasets
        /// in Amazon S3 on Outposts. S3 on Outposts uses endpoints to connect to Outposts buckets
        /// so that you can perform actions within your virtual private cloud (VPC). 
        /// 
        ///  
        /// <para>
        /// This action creates an endpoint and associates it with the specified Outpost. 
        /// </para>
        ///   
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
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);



        /// <summary>
        /// S3 on Outposts access points simplify managing data access at scale for shared datasets
        /// in Amazon S3 on Outposts. S3 on Outposts uses endpoints to connect to Outposts buckets
        /// so that you can perform actions within your virtual private cloud (VPC). 
        /// 
        ///  
        /// <para>
        /// This action creates an endpoint and associates it with the specified Outpost. 
        /// </para>
        ///   
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
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// S3 on Outposts access points simplify managing data access at scale for shared datasets
        /// in Amazon S3 on Outposts. S3 on Outposts uses endpoints to connect to Outposts buckets
        /// so that you can perform actions within your virtual private cloud (VPC). 
        /// 
        ///  
        /// <para>
        /// This action deletes an endpoint. 
        /// </para>
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
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);



        /// <summary>
        /// S3 on Outposts access points simplify managing data access at scale for shared datasets
        /// in Amazon S3 on Outposts. S3 on Outposts uses endpoints to connect to Outposts buckets
        /// so that you can perform actions within your virtual private cloud (VPC). 
        /// 
        ///  
        /// <para>
        /// This action deletes an endpoint. 
        /// </para>
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
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEndpoints


        /// <summary>
        /// S3 on Outposts access points simplify managing data access at scale for shared datasets
        /// in Amazon S3 on Outposts. S3 on Outposts uses endpoints to connect to Outposts buckets
        /// so that you can perform actions within your virtual private cloud (VPC). 
        /// 
        ///  
        /// <para>
        /// This action lists endpoints associated with the Outpost. 
        /// </para>
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
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        ListEndpointsResponse ListEndpoints(ListEndpointsRequest request);



        /// <summary>
        /// S3 on Outposts access points simplify managing data access at scale for shared datasets
        /// in Amazon S3 on Outposts. S3 on Outposts uses endpoints to connect to Outposts buckets
        /// so that you can perform actions within your virtual private cloud (VPC). 
        /// 
        ///  
        /// <para>
        /// This action lists endpoints associated with the Outpost. 
        /// </para>
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
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}