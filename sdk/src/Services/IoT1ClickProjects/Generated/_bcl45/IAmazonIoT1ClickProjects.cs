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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoT1ClickProjects.Model;

namespace Amazon.IoT1ClickProjects
{
    /// <summary>
    /// Interface for accessing IoT1ClickProjects
    ///
    /// The AWS IoT 1-Click Project API Reference
    /// </summary>
    public partial interface IAmazonIoT1ClickProjects : IAmazonService, IDisposable
    {

        
        #region  AssociateDeviceWithPlacement


        /// <summary>
        /// Associates a physical device with a placement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithPlacement service method.</param>
        /// 
        /// <returns>The response from the AssociateDeviceWithPlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/AssociateDeviceWithPlacement">REST API Reference for AssociateDeviceWithPlacement Operation</seealso>
        AssociateDeviceWithPlacementResponse AssociateDeviceWithPlacement(AssociateDeviceWithPlacementRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDeviceWithPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/AssociateDeviceWithPlacement">REST API Reference for AssociateDeviceWithPlacement Operation</seealso>
        Task<AssociateDeviceWithPlacementResponse> AssociateDeviceWithPlacementAsync(AssociateDeviceWithPlacementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePlacement


        /// <summary>
        /// Creates an empty placement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacement service method.</param>
        /// 
        /// <returns>The response from the CreatePlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreatePlacement">REST API Reference for CreatePlacement Operation</seealso>
        CreatePlacementResponse CreatePlacement(CreatePlacementRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreatePlacement">REST API Reference for CreatePlacement Operation</seealso>
        Task<CreatePlacementResponse> CreatePlacementAsync(CreatePlacementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates an empty project with a placement template. A project contains zero or more
        /// placements that adhere to the placement template defined in the project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse CreateProject(CreateProjectRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreateProject">REST API Reference for CreateProject Operation</seealso>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePlacement


        /// <summary>
        /// Deletes a placement. To delete a placement, it must not have any devices associated
        /// with it.
        /// 
        ///  <note> 
        /// <para>
        /// When you delete a placement, all associated data becomes irretrievable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacement service method.</param>
        /// 
        /// <returns>The response from the DeletePlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeletePlacement">REST API Reference for DeletePlacement Operation</seealso>
        DeletePlacementResponse DeletePlacement(DeletePlacementRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeletePlacement">REST API Reference for DeletePlacement Operation</seealso>
        Task<DeletePlacementResponse> DeletePlacementAsync(DeletePlacementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes a project. To delete a project, it must not have any placements associated
        /// with it.
        /// 
        ///  <note> 
        /// <para>
        /// When you delete a project, all associated data becomes irretrievable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse DeleteProject(DeleteProjectRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePlacement


        /// <summary>
        /// Describes a placement in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacement service method.</param>
        /// 
        /// <returns>The response from the DescribePlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribePlacement">REST API Reference for DescribePlacement Operation</seealso>
        DescribePlacementResponse DescribePlacement(DescribePlacementRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribePlacement">REST API Reference for DescribePlacement Operation</seealso>
        Task<DescribePlacementResponse> DescribePlacementAsync(DescribePlacementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeProject


        /// <summary>
        /// Returns an object describing a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        DescribeProjectResponse DescribeProject(DescribeProjectRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateDeviceFromPlacement


        /// <summary>
        /// Removes a physical device from a placement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDeviceFromPlacement service method.</param>
        /// 
        /// <returns>The response from the DisassociateDeviceFromPlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DisassociateDeviceFromPlacement">REST API Reference for DisassociateDeviceFromPlacement Operation</seealso>
        DisassociateDeviceFromPlacementResponse DisassociateDeviceFromPlacement(DisassociateDeviceFromPlacementRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDeviceFromPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDeviceFromPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DisassociateDeviceFromPlacement">REST API Reference for DisassociateDeviceFromPlacement Operation</seealso>
        Task<DisassociateDeviceFromPlacementResponse> DisassociateDeviceFromPlacementAsync(DisassociateDeviceFromPlacementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDevicesInPlacement


        /// <summary>
        /// Returns an object enumerating the devices in a placement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicesInPlacement service method.</param>
        /// 
        /// <returns>The response from the GetDevicesInPlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/GetDevicesInPlacement">REST API Reference for GetDevicesInPlacement Operation</seealso>
        GetDevicesInPlacementResponse GetDevicesInPlacement(GetDevicesInPlacementRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicesInPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicesInPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/GetDevicesInPlacement">REST API Reference for GetDevicesInPlacement Operation</seealso>
        Task<GetDevicesInPlacementResponse> GetDevicesInPlacementAsync(GetDevicesInPlacementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPlacements


        /// <summary>
        /// Lists the placement(s) of a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlacements service method.</param>
        /// 
        /// <returns>The response from the ListPlacements service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListPlacements">REST API Reference for ListPlacements Operation</seealso>
        ListPlacementsResponse ListPlacements(ListPlacementsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListPlacements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlacements operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListPlacements">REST API Reference for ListPlacements Operation</seealso>
        Task<ListPlacementsResponse> ListPlacementsAsync(ListPlacementsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Lists the AWS IoT 1-Click project(s) associated with your AWS account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse ListProjects(ListProjectsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePlacement


        /// <summary>
        /// Updates a placement with the given attributes. To clear an attribute, pass an empty
        /// value (i.e., "").
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlacement service method.</param>
        /// 
        /// <returns>The response from the UpdatePlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdatePlacement">REST API Reference for UpdatePlacement Operation</seealso>
        UpdatePlacementResponse UpdatePlacement(UpdatePlacementRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdatePlacement">REST API Reference for UpdatePlacement Operation</seealso>
        Task<UpdatePlacementResponse> UpdatePlacementAsync(UpdatePlacementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Updates a project associated with your AWS account and region. With the exception
        /// of device template names, you can pass just the values that need to be updated because
        /// the update request will change only the values that are provided. To clear a value,
        /// pass the empty string (i.e., <code>""</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse UpdateProject(UpdateProjectRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}