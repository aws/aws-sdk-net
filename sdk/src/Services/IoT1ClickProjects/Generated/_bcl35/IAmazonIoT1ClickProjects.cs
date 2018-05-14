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
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithPlacement operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDeviceWithPlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/AssociateDeviceWithPlacement">REST API Reference for AssociateDeviceWithPlacement Operation</seealso>
        IAsyncResult BeginAssociateDeviceWithPlacement(AssociateDeviceWithPlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDeviceWithPlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDeviceWithPlacement.</param>
        /// 
        /// <returns>Returns a  AssociateDeviceWithPlacementResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/AssociateDeviceWithPlacement">REST API Reference for AssociateDeviceWithPlacement Operation</seealso>
        AssociateDeviceWithPlacementResponse EndAssociateDeviceWithPlacement(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacement operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreatePlacement">REST API Reference for CreatePlacement Operation</seealso>
        IAsyncResult BeginCreatePlacement(CreatePlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlacement.</param>
        /// 
        /// <returns>Returns a  CreatePlacementResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreatePlacement">REST API Reference for CreatePlacement Operation</seealso>
        CreatePlacementResponse EndCreatePlacement(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreateProject">REST API Reference for CreateProject Operation</seealso>
        IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse EndCreateProject(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacement operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeletePlacement">REST API Reference for DeletePlacement Operation</seealso>
        IAsyncResult BeginDeletePlacement(DeletePlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlacement.</param>
        /// 
        /// <returns>Returns a  DeletePlacementResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeletePlacement">REST API Reference for DeletePlacement Operation</seealso>
        DeletePlacementResponse EndDeletePlacement(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacement operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribePlacement">REST API Reference for DescribePlacement Operation</seealso>
        IAsyncResult BeginDescribePlacement(DescribePlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlacement.</param>
        /// 
        /// <returns>Returns a  DescribePlacementResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribePlacement">REST API Reference for DescribePlacement Operation</seealso>
        DescribePlacementResponse EndDescribePlacement(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        IAsyncResult BeginDescribeProject(DescribeProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProject.</param>
        /// 
        /// <returns>Returns a  DescribeProjectResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        DescribeProjectResponse EndDescribeProject(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDeviceFromPlacement operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDeviceFromPlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DisassociateDeviceFromPlacement">REST API Reference for DisassociateDeviceFromPlacement Operation</seealso>
        IAsyncResult BeginDisassociateDeviceFromPlacement(DisassociateDeviceFromPlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDeviceFromPlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDeviceFromPlacement.</param>
        /// 
        /// <returns>Returns a  DisassociateDeviceFromPlacementResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DisassociateDeviceFromPlacement">REST API Reference for DisassociateDeviceFromPlacement Operation</seealso>
        DisassociateDeviceFromPlacementResponse EndDisassociateDeviceFromPlacement(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the GetDevicesInPlacement operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicesInPlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/GetDevicesInPlacement">REST API Reference for GetDevicesInPlacement Operation</seealso>
        IAsyncResult BeginGetDevicesInPlacement(GetDevicesInPlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicesInPlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicesInPlacement.</param>
        /// 
        /// <returns>Returns a  GetDevicesInPlacementResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/GetDevicesInPlacement">REST API Reference for GetDevicesInPlacement Operation</seealso>
        GetDevicesInPlacementResponse EndGetDevicesInPlacement(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListPlacements operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlacements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListPlacements">REST API Reference for ListPlacements Operation</seealso>
        IAsyncResult BeginListPlacements(ListPlacementsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlacements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlacements.</param>
        /// 
        /// <returns>Returns a  ListPlacementsResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListPlacements">REST API Reference for ListPlacements Operation</seealso>
        ListPlacementsResponse EndListPlacements(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListProjects">REST API Reference for ListProjects Operation</seealso>
        IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse EndListProjects(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlacement operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdatePlacement">REST API Reference for UpdatePlacement Operation</seealso>
        IAsyncResult BeginUpdatePlacement(UpdatePlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePlacement.</param>
        /// 
        /// <returns>Returns a  UpdatePlacementResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdatePlacement">REST API Reference for UpdatePlacement Operation</seealso>
        UpdatePlacementResponse EndUpdatePlacement(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonIoT1ClickProjectsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from IoT1ClickProjects.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult);

        #endregion
        
    }
}