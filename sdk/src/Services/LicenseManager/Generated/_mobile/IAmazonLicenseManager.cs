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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LicenseManager.Model;

namespace Amazon.LicenseManager
{
    /// <summary>
    /// Interface for accessing LicenseManager
    ///
    /// AWS License Manager  
    /// <para>
    ///  <i>This is the AWS License Manager API Reference.</i> It provides descriptions, syntax,
    /// and usage examples for each of the actions and data types for License Manager. The
    /// topic for each action shows the Query API request parameters and the XML response.
    /// You can also view the XML request elements in the WSDL. 
    /// </para>
    ///  
    /// <para>
    ///  Alternatively, you can use one of the AWS SDKs to access an API that's tailored to
    /// the programming language or platform that you're using. For more information, see
    /// <a href="http://aws.amazon.com/tools/#SDKs">AWS SDKs</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonLicenseManager : IAmazonService, IDisposable
    {
                
        #region  CreateLicenseConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        Task<CreateLicenseConfigurationResponse> CreateLicenseConfigurationAsync(CreateLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLicenseConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        Task<DeleteLicenseConfigurationResponse> DeleteLicenseConfigurationAsync(DeleteLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLicenseConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the GetLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        Task<GetLicenseConfigurationResponse> GetLicenseConfigurationAsync(GetLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServiceSettings


        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssociationsForLicenseConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociationsForLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        Task<ListAssociationsForLicenseConfigurationResponse> ListAssociationsForLicenseConfigurationAsync(ListAssociationsForLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLicenseConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        Task<ListLicenseConfigurationsResponse> ListLicenseConfigurationsAsync(ListLicenseConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLicenseSpecificationsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseSpecificationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        Task<ListLicenseSpecificationsForResourceResponse> ListLicenseSpecificationsForResourceAsync(ListLicenseSpecificationsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceInventory


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceInventory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        Task<ListResourceInventoryResponse> ListResourceInventoryAsync(ListResourceInventoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUsageForLicenseConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsageForLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        Task<ListUsageForLicenseConfigurationResponse> ListUsageForLicenseConfigurationAsync(ListUsageForLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLicenseConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        Task<UpdateLicenseConfigurationResponse> UpdateLicenseConfigurationAsync(UpdateLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLicenseSpecificationsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLicenseSpecificationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        Task<UpdateLicenseSpecificationsForResourceResponse> UpdateLicenseSpecificationsForResourceAsync(UpdateLicenseSpecificationsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServiceSettings


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        Task<UpdateServiceSettingsResponse> UpdateServiceSettingsAsync(UpdateServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}