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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MediaStoreData.Model;

namespace Amazon.MediaStoreData
{
    /// <summary>
    /// Interface for accessing MediaStoreData
    ///
    /// An AWS Elemental MediaStore asset is an object, similar to an object in the Amazon
    /// S3 service. Objects are the fundamental entities that are stored in AWS Elemental
    /// MediaStore.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonMediaStoreData : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMediaStoreDataPaginatorFactory Paginators { get; }
#endif
                
        #region  DeleteObject



        /// <summary>
        /// Deletes an object at the specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.ObjectNotFoundException">
        /// Could not perform an operation on an object that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeObject



        /// <summary>
        /// Gets the headers for an object at the specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.ObjectNotFoundException">
        /// Could not perform an operation on an object that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/DescribeObject">REST API Reference for DescribeObject Operation</seealso>
        Task<DescribeObjectResponse> DescribeObjectAsync(DescribeObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetObject



        /// <summary>
        /// Downloads the object at the specified path. If the object’s upload availability is
        /// set to <code>streaming</code>, AWS Elemental MediaStore downloads the object even
        /// if it’s still uploading the object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.ObjectNotFoundException">
        /// Could not perform an operation on an object that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.RequestedRangeNotSatisfiableException">
        /// The requested content range is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/GetObject">REST API Reference for GetObject Operation</seealso>
        Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListItems



        /// <summary>
        /// Provides a list of metadata entries about folders and objects in the specified folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListItems service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/ListItems">REST API Reference for ListItems Operation</seealso>
        Task<ListItemsResponse> ListItemsAsync(ListItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutObject



        /// <summary>
        /// Uploads an object to the specified path. Object sizes are limited to 25 MB for standard
        /// upload availability and 10 MB for streaming upload availability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/PutObject">REST API Reference for PutObject Operation</seealso>
        Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}