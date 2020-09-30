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
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonMobile : IAmazonService, IDisposable
    {
                
        #region  CreateProject



        /// <summary>
        /// Creates an AWS Mobile Hub project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.LimitExceededException">
        /// There are too many AWS Mobile Hub projects in the account or the account has exceeded
        /// the maximum number of resources in some AWS service. You should create another sub-account
        /// using AWS Organizations or remove some resources and retry your request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/CreateProject">REST API Reference for CreateProject Operation</seealso>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProject



        /// <summary>
        /// Delets a project in AWS Mobile Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBundle



        /// <summary>
        /// Get the bundle details for the requested bundle id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBundle service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DescribeBundle">REST API Reference for DescribeBundle Operation</seealso>
        Task<DescribeBundleResponse> DescribeBundleAsync(DescribeBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProject



        /// <summary>
        /// Gets details about a project in AWS Mobile Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportBundle



        /// <summary>
        /// Generates customized software development kit (SDK) and or tool packages used to
        /// integrate mobile web or mobile app clients with backend AWS resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportBundle service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ExportBundle">REST API Reference for ExportBundle Operation</seealso>
        Task<ExportBundleResponse> ExportBundleAsync(ExportBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportProject



        /// <summary>
        /// Exports project configuration to a snapshot which can be downloaded and shared. Note
        /// that mobile app push credentials are encrypted in exported projects, so they can only
        /// be shared successfully within the same AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportProject service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ExportProject">REST API Reference for ExportProject Operation</seealso>
        Task<ExportProjectResponse> ExportProjectAsync(ExportProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBundles



        /// <summary>
        /// List all available bundles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBundles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBundles service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ListBundles">REST API Reference for ListBundles Operation</seealso>
        Task<ListBundlesResponse> ListBundlesAsync(ListBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjects



        /// <summary>
        /// Lists projects in AWS Mobile Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProject



        /// <summary>
        /// Update an existing project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.AccountActionRequiredException">
        /// Account Action is required in order to continue the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.LimitExceededException">
        /// There are too many AWS Mobile Hub projects in the account or the account has exceeded
        /// the maximum number of resources in some AWS service. You should create another sub-account
        /// using AWS Organizations or remove some resources and retry your request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}