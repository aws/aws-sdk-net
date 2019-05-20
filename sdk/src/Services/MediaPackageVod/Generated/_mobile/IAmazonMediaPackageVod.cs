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
        /// Initiates the asynchronous execution of the CreateAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        Task<CreateAssetResponse> CreateAssetAsync(CreateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePackagingConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackagingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingConfiguration">REST API Reference for CreatePackagingConfiguration Operation</seealso>
        Task<CreatePackagingConfigurationResponse> CreatePackagingConfigurationAsync(CreatePackagingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePackagingGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackagingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingGroup">REST API Reference for CreatePackagingGroup Operation</seealso>
        Task<CreatePackagingGroupResponse> CreatePackagingGroupAsync(CreatePackagingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAsset


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePackagingConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackagingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingConfiguration">REST API Reference for DeletePackagingConfiguration Operation</seealso>
        Task<DeletePackagingConfigurationResponse> DeletePackagingConfigurationAsync(DeletePackagingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePackagingGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackagingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingGroup">REST API Reference for DeletePackagingGroup Operation</seealso>
        Task<DeletePackagingGroupResponse> DeletePackagingGroupAsync(DeletePackagingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAsset


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAsset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribeAsset">REST API Reference for DescribeAsset Operation</seealso>
        Task<DescribeAssetResponse> DescribeAssetAsync(DescribeAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePackagingConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackagingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingConfiguration">REST API Reference for DescribePackagingConfiguration Operation</seealso>
        Task<DescribePackagingConfigurationResponse> DescribePackagingConfigurationAsync(DescribePackagingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePackagingGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackagingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingGroup">REST API Reference for DescribePackagingGroup Operation</seealso>
        Task<DescribePackagingGroupResponse> DescribePackagingGroupAsync(DescribePackagingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssets


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListAssets">REST API Reference for ListAssets Operation</seealso>
        Task<ListAssetsResponse> ListAssetsAsync(ListAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPackagingConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the ListPackagingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackagingConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingConfigurations">REST API Reference for ListPackagingConfigurations Operation</seealso>
        Task<ListPackagingConfigurationsResponse> ListPackagingConfigurationsAsync(ListPackagingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPackagingGroups


        /// <summary>
        /// Initiates the asynchronous execution of the ListPackagingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackagingGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingGroups">REST API Reference for ListPackagingGroups Operation</seealso>
        Task<ListPackagingGroupsResponse> ListPackagingGroupsAsync(ListPackagingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}