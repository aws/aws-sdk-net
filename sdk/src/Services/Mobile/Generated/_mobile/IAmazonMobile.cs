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
 * Do not modify this file. This file is generated from the mobile-2017-07-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Mobile.Model;

namespace Amazon.Mobile
{
    /// <summary>
    /// Interface for accessing Mobile
    ///
    /// AWS Mobile Service provides mobile app and website developers with capabilities required
    /// to configure AWS resources and bootstrap their developer desktop projects with the
    /// necessary SDKs, constants, tools and samples to make use of those resources.
    /// </summary>
    public partial interface IAmazonMobile : IAmazonService, IDisposable
    {
                
        #region  CreateProject


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/CreateProject">REST API Reference for CreateProject Operation</seealso>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProject


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBundle


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundle operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DescribeBundle">REST API Reference for DescribeBundle Operation</seealso>
        Task<DescribeBundleResponse> DescribeBundleAsync(DescribeBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProject


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportBundle


        /// <summary>
        /// Initiates the asynchronous execution of the ExportBundle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportBundle operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ExportBundle">REST API Reference for ExportBundle Operation</seealso>
        Task<ExportBundleResponse> ExportBundleAsync(ExportBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportProject


        /// <summary>
        /// Initiates the asynchronous execution of the ExportProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ExportProject">REST API Reference for ExportProject Operation</seealso>
        Task<ExportProjectResponse> ExportProjectAsync(ExportProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBundles


        /// <summary>
        /// Initiates the asynchronous execution of the ListBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBundles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ListBundles">REST API Reference for ListBundles Operation</seealso>
        Task<ListBundlesResponse> ListBundlesAsync(ListBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjects


        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProject


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}