/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MediaPackageVod.Model;

namespace Amazon.MediaPackageVod
{
    /// <summary>
    /// Interface for accessing MediaPackageVod
    ///
    /// AWS Elemental MediaPackage VOD
    /// </summary>
    public partial interface IAmazonMediaPackageVod : IAmazonService, IDisposable
    {
                
        #region  CreateAsset



        /// <summary>
        /// Creates a new MediaPackage VOD Asset resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAsset service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        Task<CreateAssetResponse> CreateAssetAsync(CreateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePackagingConfiguration



        /// <summary>
        /// Creates a new MediaPackage VOD PackagingConfiguration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackagingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePackagingConfiguration service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingConfiguration">REST API Reference for CreatePackagingConfiguration Operation</seealso>
        Task<CreatePackagingConfigurationResponse> CreatePackagingConfigurationAsync(CreatePackagingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePackagingGroup



        /// <summary>
        /// Creates a new MediaPackage VOD PackagingGroup resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackagingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePackagingGroup service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingGroup">REST API Reference for CreatePackagingGroup Operation</seealso>
        Task<CreatePackagingGroupResponse> CreatePackagingGroupAsync(CreatePackagingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAsset



        /// <summary>
        /// Deletes an existing MediaPackage VOD Asset resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePackagingConfiguration



        /// <summary>
        /// Deletes a MediaPackage VOD PackagingConfiguration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackagingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePackagingConfiguration service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingConfiguration">REST API Reference for DeletePackagingConfiguration Operation</seealso>
        Task<DeletePackagingConfigurationResponse> DeletePackagingConfigurationAsync(DeletePackagingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePackagingGroup



        /// <summary>
        /// Deletes a MediaPackage VOD PackagingGroup resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackagingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePackagingGroup service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingGroup">REST API Reference for DeletePackagingGroup Operation</seealso>
        Task<DeletePackagingGroupResponse> DeletePackagingGroupAsync(DeletePackagingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAsset



        /// <summary>
        /// Returns a description of a MediaPackage VOD Asset resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAsset service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribeAsset">REST API Reference for DescribeAsset Operation</seealso>
        Task<DescribeAssetResponse> DescribeAssetAsync(DescribeAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePackagingConfiguration



        /// <summary>
        /// Returns a description of a MediaPackage VOD PackagingConfiguration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackagingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackagingConfiguration service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingConfiguration">REST API Reference for DescribePackagingConfiguration Operation</seealso>
        Task<DescribePackagingConfigurationResponse> DescribePackagingConfigurationAsync(DescribePackagingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePackagingGroup



        /// <summary>
        /// Returns a description of a MediaPackage VOD PackagingGroup resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackagingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackagingGroup service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingGroup">REST API Reference for DescribePackagingGroup Operation</seealso>
        Task<DescribePackagingGroupResponse> DescribePackagingGroupAsync(DescribePackagingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssets



        /// <summary>
        /// Returns a collection of MediaPackage VOD Asset resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssets service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListAssets">REST API Reference for ListAssets Operation</seealso>
        Task<ListAssetsResponse> ListAssetsAsync(ListAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPackagingConfigurations



        /// <summary>
        /// Returns a collection of MediaPackage VOD PackagingConfiguration resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackagingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPackagingConfigurations service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingConfigurations">REST API Reference for ListPackagingConfigurations Operation</seealso>
        Task<ListPackagingConfigurationsResponse> ListPackagingConfigurationsAsync(ListPackagingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPackagingGroups



        /// <summary>
        /// Returns a collection of MediaPackage VOD PackagingGroup resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackagingGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPackagingGroups service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingGroups">REST API Reference for ListPackagingGroups Operation</seealso>
        Task<ListPackagingGroupsResponse> ListPackagingGroupsAsync(ListPackagingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}