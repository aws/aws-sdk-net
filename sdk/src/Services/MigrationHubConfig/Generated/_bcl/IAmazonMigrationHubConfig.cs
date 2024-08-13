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
 * Do not modify this file. This file is generated from the migrationhub-config-2019-06-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MigrationHubConfig.Model;

#pragma warning disable CS1570
namespace Amazon.MigrationHubConfig
{
    /// <summary>
    /// <para>Interface for accessing MigrationHubConfig</para>
    ///
    /// The AWS Migration Hub home region APIs are available specifically for working with
    /// your Migration Hub home region. You can use these APIs to determine a home region,
    /// as well as to create and work with controls that describe the home region.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You must make API calls for write actions (create, notify, associate, disassociate,
    /// import, or put) while in your home region, or a <c>HomeRegionNotSetException</c> error
    /// is returned.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// API calls for read actions (list, describe, stop, and delete) are permitted outside
    /// of your home region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call a write API outside the home region, an <c>InvalidInputException</c> is
    /// returned.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can call <c>GetHomeRegion</c> action to obtain the account's Migration Hub home
    /// region.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For specific API usage, see the sections that follow in this AWS Migration Hub Home
    /// Region API reference. 
    /// </para>
    /// </summary>
    public partial interface IAmazonMigrationHubConfig : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMigrationHubConfigPaginatorFactory Paginators { get; }

        
        #region  CreateHomeRegionControl


        /// <summary>
        /// This API sets up the home region for the calling account only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHomeRegionControl service method.</param>
        /// 
        /// <returns>The response from the CreateHomeRegionControl service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.DryRunOperationException">
        /// Exception raised to indicate that authorization of an action was successful, when
        /// the <c>DryRun</c> flag is set to true.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/CreateHomeRegionControl">REST API Reference for CreateHomeRegionControl Operation</seealso>
        CreateHomeRegionControlResponse CreateHomeRegionControl(CreateHomeRegionControlRequest request);



        /// <summary>
        /// This API sets up the home region for the calling account only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHomeRegionControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHomeRegionControl service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.DryRunOperationException">
        /// Exception raised to indicate that authorization of an action was successful, when
        /// the <c>DryRun</c> flag is set to true.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/CreateHomeRegionControl">REST API Reference for CreateHomeRegionControl Operation</seealso>
        Task<CreateHomeRegionControlResponse> CreateHomeRegionControlAsync(CreateHomeRegionControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteHomeRegionControl


        /// <summary>
        /// This operation deletes the home region configuration for the calling account. The
        /// operation does not delete discovery or migration tracking data in the home region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHomeRegionControl service method.</param>
        /// 
        /// <returns>The response from the DeleteHomeRegionControl service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/DeleteHomeRegionControl">REST API Reference for DeleteHomeRegionControl Operation</seealso>
        DeleteHomeRegionControlResponse DeleteHomeRegionControl(DeleteHomeRegionControlRequest request);



        /// <summary>
        /// This operation deletes the home region configuration for the calling account. The
        /// operation does not delete discovery or migration tracking data in the home region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHomeRegionControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHomeRegionControl service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/DeleteHomeRegionControl">REST API Reference for DeleteHomeRegionControl Operation</seealso>
        Task<DeleteHomeRegionControlResponse> DeleteHomeRegionControlAsync(DeleteHomeRegionControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeHomeRegionControls


        /// <summary>
        /// This API permits filtering on the <c>ControlId</c> and <c>HomeRegion</c> fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHomeRegionControls service method.</param>
        /// 
        /// <returns>The response from the DescribeHomeRegionControls service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/DescribeHomeRegionControls">REST API Reference for DescribeHomeRegionControls Operation</seealso>
        DescribeHomeRegionControlsResponse DescribeHomeRegionControls(DescribeHomeRegionControlsRequest request);



        /// <summary>
        /// This API permits filtering on the <c>ControlId</c> and <c>HomeRegion</c> fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHomeRegionControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHomeRegionControls service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/DescribeHomeRegionControls">REST API Reference for DescribeHomeRegionControls Operation</seealso>
        Task<DescribeHomeRegionControlsResponse> DescribeHomeRegionControlsAsync(DescribeHomeRegionControlsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHomeRegion


        /// <summary>
        /// Returns the calling account’s home region, if configured. This API is used by other
        /// AWS services to determine the regional endpoint for calling AWS Application Discovery
        /// Service and Migration Hub. You must call <c>GetHomeRegion</c> at least once before
        /// you call any other AWS Application Discovery Service and AWS Migration Hub APIs, to
        /// obtain the account's Migration Hub home region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHomeRegion service method.</param>
        /// 
        /// <returns>The response from the GetHomeRegion service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/GetHomeRegion">REST API Reference for GetHomeRegion Operation</seealso>
        GetHomeRegionResponse GetHomeRegion(GetHomeRegionRequest request);



        /// <summary>
        /// Returns the calling account’s home region, if configured. This API is used by other
        /// AWS services to determine the regional endpoint for calling AWS Application Discovery
        /// Service and Migration Hub. You must call <c>GetHomeRegion</c> at least once before
        /// you call any other AWS Application Discovery Service and AWS Migration Hub APIs, to
        /// obtain the account's Migration Hub home region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHomeRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHomeRegion service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/GetHomeRegion">REST API Reference for GetHomeRegion Operation</seealso>
        Task<GetHomeRegionResponse> GetHomeRegionAsync(GetHomeRegionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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