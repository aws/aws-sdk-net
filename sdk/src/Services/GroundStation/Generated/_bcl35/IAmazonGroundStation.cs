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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GroundStation.Model;

namespace Amazon.GroundStation
{
    /// <summary>
    /// Interface for accessing GroundStation
    ///
    /// Welcome to the AWS Ground Station API Reference. AWS Ground Station is a fully managed
    /// service that enables you to control satellite communications, downlink and process
    /// satellite data, and scale your satellite operations efficiently and cost-effectively
    /// without having to build or manage your own ground station infrastructure.
    /// </summary>
    public partial interface IAmazonGroundStation : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IGroundStationPaginatorFactory Paginators { get; }
#endif


        
        #region  CancelContact


        /// <summary>
        /// Cancels a contact with a specified contact ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelContact service method.</param>
        /// 
        /// <returns>The response from the CancelContact service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CancelContact">REST API Reference for CancelContact Operation</seealso>
        CancelContactResponse CancelContact(CancelContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelContact operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CancelContact">REST API Reference for CancelContact Operation</seealso>
        IAsyncResult BeginCancelContact(CancelContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelContact.</param>
        /// 
        /// <returns>Returns a  CancelContactResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CancelContact">REST API Reference for CancelContact Operation</seealso>
        CancelContactResponse EndCancelContact(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfig


        /// <summary>
        /// Creates a <code>Config</code> with the specified <code>configData</code> parameters.
        /// 
        ///  
        /// <para>
        /// Only one type of <code>configData</code> can be specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfig service method.</param>
        /// 
        /// <returns>The response from the CreateConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceLimitExceededException">
        /// Account limits for this resource have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateConfig">REST API Reference for CreateConfig Operation</seealso>
        CreateConfigResponse CreateConfig(CreateConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfig operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateConfig">REST API Reference for CreateConfig Operation</seealso>
        IAsyncResult BeginCreateConfig(CreateConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfig.</param>
        /// 
        /// <returns>Returns a  CreateConfigResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateConfig">REST API Reference for CreateConfig Operation</seealso>
        CreateConfigResponse EndCreateConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataflowEndpointGroup


        /// <summary>
        /// Creates a <code>DataflowEndpoint</code> group containing the specified list of <code>DataflowEndpoint</code>
        /// objects.
        /// 
        ///  
        /// <para>
        /// The <code>name</code> field in each endpoint is used in your mission profile <code>DataflowEndpointConfig</code>
        /// to specify which endpoints to use during a contact.
        /// </para>
        ///  
        /// <para>
        /// When a contact uses multiple <code>DataflowEndpointConfig</code> objects, each <code>Config</code>
        /// must match a <code>DataflowEndpoint</code> in the same group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataflowEndpointGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDataflowEndpointGroup service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateDataflowEndpointGroup">REST API Reference for CreateDataflowEndpointGroup Operation</seealso>
        CreateDataflowEndpointGroupResponse CreateDataflowEndpointGroup(CreateDataflowEndpointGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataflowEndpointGroup operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataflowEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateDataflowEndpointGroup">REST API Reference for CreateDataflowEndpointGroup Operation</seealso>
        IAsyncResult BeginCreateDataflowEndpointGroup(CreateDataflowEndpointGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataflowEndpointGroup.</param>
        /// 
        /// <returns>Returns a  CreateDataflowEndpointGroupResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateDataflowEndpointGroup">REST API Reference for CreateDataflowEndpointGroup Operation</seealso>
        CreateDataflowEndpointGroupResponse EndCreateDataflowEndpointGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEphemeris


        /// <summary>
        /// Creates an Ephemeris with the specified <code>EphemerisData</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEphemeris service method.</param>
        /// 
        /// <returns>The response from the CreateEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateEphemeris">REST API Reference for CreateEphemeris Operation</seealso>
        CreateEphemerisResponse CreateEphemeris(CreateEphemerisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEphemeris operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEphemeris operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEphemeris
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateEphemeris">REST API Reference for CreateEphemeris Operation</seealso>
        IAsyncResult BeginCreateEphemeris(CreateEphemerisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEphemeris operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEphemeris.</param>
        /// 
        /// <returns>Returns a  CreateEphemerisResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateEphemeris">REST API Reference for CreateEphemeris Operation</seealso>
        CreateEphemerisResponse EndCreateEphemeris(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMissionProfile


        /// <summary>
        /// Creates a mission profile.
        /// 
        ///  
        /// <para>
        ///  <code>dataflowEdges</code> is a list of lists of strings. Each lower level list of
        /// strings has two elements: a <i>from</i> ARN and a <i>to</i> ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMissionProfile service method.</param>
        /// 
        /// <returns>The response from the CreateMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateMissionProfile">REST API Reference for CreateMissionProfile Operation</seealso>
        CreateMissionProfileResponse CreateMissionProfile(CreateMissionProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMissionProfile operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMissionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateMissionProfile">REST API Reference for CreateMissionProfile Operation</seealso>
        IAsyncResult BeginCreateMissionProfile(CreateMissionProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMissionProfile.</param>
        /// 
        /// <returns>Returns a  CreateMissionProfileResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateMissionProfile">REST API Reference for CreateMissionProfile Operation</seealso>
        CreateMissionProfileResponse EndCreateMissionProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfig


        /// <summary>
        /// Deletes a <code>Config</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteConfig">REST API Reference for DeleteConfig Operation</seealso>
        DeleteConfigResponse DeleteConfig(DeleteConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfig operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteConfig">REST API Reference for DeleteConfig Operation</seealso>
        IAsyncResult BeginDeleteConfig(DeleteConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfig.</param>
        /// 
        /// <returns>Returns a  DeleteConfigResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteConfig">REST API Reference for DeleteConfig Operation</seealso>
        DeleteConfigResponse EndDeleteConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataflowEndpointGroup


        /// <summary>
        /// Deletes a dataflow endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataflowEndpointGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDataflowEndpointGroup service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteDataflowEndpointGroup">REST API Reference for DeleteDataflowEndpointGroup Operation</seealso>
        DeleteDataflowEndpointGroupResponse DeleteDataflowEndpointGroup(DeleteDataflowEndpointGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataflowEndpointGroup operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataflowEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteDataflowEndpointGroup">REST API Reference for DeleteDataflowEndpointGroup Operation</seealso>
        IAsyncResult BeginDeleteDataflowEndpointGroup(DeleteDataflowEndpointGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataflowEndpointGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDataflowEndpointGroupResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteDataflowEndpointGroup">REST API Reference for DeleteDataflowEndpointGroup Operation</seealso>
        DeleteDataflowEndpointGroupResponse EndDeleteDataflowEndpointGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEphemeris


        /// <summary>
        /// Deletes an ephemeris
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEphemeris service method.</param>
        /// 
        /// <returns>The response from the DeleteEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteEphemeris">REST API Reference for DeleteEphemeris Operation</seealso>
        DeleteEphemerisResponse DeleteEphemeris(DeleteEphemerisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEphemeris operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEphemeris operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEphemeris
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteEphemeris">REST API Reference for DeleteEphemeris Operation</seealso>
        IAsyncResult BeginDeleteEphemeris(DeleteEphemerisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEphemeris operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEphemeris.</param>
        /// 
        /// <returns>Returns a  DeleteEphemerisResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteEphemeris">REST API Reference for DeleteEphemeris Operation</seealso>
        DeleteEphemerisResponse EndDeleteEphemeris(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMissionProfile


        /// <summary>
        /// Deletes a mission profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMissionProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteMissionProfile">REST API Reference for DeleteMissionProfile Operation</seealso>
        DeleteMissionProfileResponse DeleteMissionProfile(DeleteMissionProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMissionProfile operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMissionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteMissionProfile">REST API Reference for DeleteMissionProfile Operation</seealso>
        IAsyncResult BeginDeleteMissionProfile(DeleteMissionProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMissionProfile.</param>
        /// 
        /// <returns>Returns a  DeleteMissionProfileResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteMissionProfile">REST API Reference for DeleteMissionProfile Operation</seealso>
        DeleteMissionProfileResponse EndDeleteMissionProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeContact


        /// <summary>
        /// Describes an existing contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContact service method.</param>
        /// 
        /// <returns>The response from the DescribeContact service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        DescribeContactResponse DescribeContact(DescribeContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContact operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        IAsyncResult BeginDescribeContact(DescribeContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeContact.</param>
        /// 
        /// <returns>Returns a  DescribeContactResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        DescribeContactResponse EndDescribeContact(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEphemeris


        /// <summary>
        /// Describes an existing ephemeris.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEphemeris service method.</param>
        /// 
        /// <returns>The response from the DescribeEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeEphemeris">REST API Reference for DescribeEphemeris Operation</seealso>
        DescribeEphemerisResponse DescribeEphemeris(DescribeEphemerisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEphemeris operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEphemeris operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEphemeris
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeEphemeris">REST API Reference for DescribeEphemeris Operation</seealso>
        IAsyncResult BeginDescribeEphemeris(DescribeEphemerisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEphemeris operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEphemeris.</param>
        /// 
        /// <returns>Returns a  DescribeEphemerisResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeEphemeris">REST API Reference for DescribeEphemeris Operation</seealso>
        DescribeEphemerisResponse EndDescribeEphemeris(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAgentConfiguration


        /// <summary>
        /// Gets the latest configuration information for a registered agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAgentConfiguration service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetAgentConfiguration">REST API Reference for GetAgentConfiguration Operation</seealso>
        GetAgentConfigurationResponse GetAgentConfiguration(GetAgentConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentConfiguration operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetAgentConfiguration">REST API Reference for GetAgentConfiguration Operation</seealso>
        IAsyncResult BeginGetAgentConfiguration(GetAgentConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentConfiguration.</param>
        /// 
        /// <returns>Returns a  GetAgentConfigurationResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetAgentConfiguration">REST API Reference for GetAgentConfiguration Operation</seealso>
        GetAgentConfigurationResponse EndGetAgentConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfig


        /// <summary>
        /// Returns <code>Config</code> information.
        /// 
        ///  
        /// <para>
        /// Only one <code>Config</code> response can be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfig service method.</param>
        /// 
        /// <returns>The response from the GetConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetConfig">REST API Reference for GetConfig Operation</seealso>
        GetConfigResponse GetConfig(GetConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfig operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetConfig">REST API Reference for GetConfig Operation</seealso>
        IAsyncResult BeginGetConfig(GetConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfig.</param>
        /// 
        /// <returns>Returns a  GetConfigResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetConfig">REST API Reference for GetConfig Operation</seealso>
        GetConfigResponse EndGetConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataflowEndpointGroup


        /// <summary>
        /// Returns the dataflow endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowEndpointGroup service method.</param>
        /// 
        /// <returns>The response from the GetDataflowEndpointGroup service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetDataflowEndpointGroup">REST API Reference for GetDataflowEndpointGroup Operation</seealso>
        GetDataflowEndpointGroupResponse GetDataflowEndpointGroup(GetDataflowEndpointGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowEndpointGroup operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataflowEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetDataflowEndpointGroup">REST API Reference for GetDataflowEndpointGroup Operation</seealso>
        IAsyncResult BeginGetDataflowEndpointGroup(GetDataflowEndpointGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataflowEndpointGroup.</param>
        /// 
        /// <returns>Returns a  GetDataflowEndpointGroupResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetDataflowEndpointGroup">REST API Reference for GetDataflowEndpointGroup Operation</seealso>
        GetDataflowEndpointGroupResponse EndGetDataflowEndpointGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMinuteUsage


        /// <summary>
        /// Returns the number of minutes used by account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMinuteUsage service method.</param>
        /// 
        /// <returns>The response from the GetMinuteUsage service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMinuteUsage">REST API Reference for GetMinuteUsage Operation</seealso>
        GetMinuteUsageResponse GetMinuteUsage(GetMinuteUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMinuteUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMinuteUsage operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMinuteUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMinuteUsage">REST API Reference for GetMinuteUsage Operation</seealso>
        IAsyncResult BeginGetMinuteUsage(GetMinuteUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMinuteUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMinuteUsage.</param>
        /// 
        /// <returns>Returns a  GetMinuteUsageResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMinuteUsage">REST API Reference for GetMinuteUsage Operation</seealso>
        GetMinuteUsageResponse EndGetMinuteUsage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMissionProfile


        /// <summary>
        /// Returns a mission profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMissionProfile service method.</param>
        /// 
        /// <returns>The response from the GetMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMissionProfile">REST API Reference for GetMissionProfile Operation</seealso>
        GetMissionProfileResponse GetMissionProfile(GetMissionProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMissionProfile operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMissionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMissionProfile">REST API Reference for GetMissionProfile Operation</seealso>
        IAsyncResult BeginGetMissionProfile(GetMissionProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMissionProfile.</param>
        /// 
        /// <returns>Returns a  GetMissionProfileResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMissionProfile">REST API Reference for GetMissionProfile Operation</seealso>
        GetMissionProfileResponse EndGetMissionProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSatellite


        /// <summary>
        /// Returns a satellite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSatellite service method.</param>
        /// 
        /// <returns>The response from the GetSatellite service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetSatellite">REST API Reference for GetSatellite Operation</seealso>
        GetSatelliteResponse GetSatellite(GetSatelliteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSatellite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSatellite operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSatellite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetSatellite">REST API Reference for GetSatellite Operation</seealso>
        IAsyncResult BeginGetSatellite(GetSatelliteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSatellite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSatellite.</param>
        /// 
        /// <returns>Returns a  GetSatelliteResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetSatellite">REST API Reference for GetSatellite Operation</seealso>
        GetSatelliteResponse EndGetSatellite(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfigs


        /// <summary>
        /// Returns a list of <code>Config</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigs service method.</param>
        /// 
        /// <returns>The response from the ListConfigs service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListConfigs">REST API Reference for ListConfigs Operation</seealso>
        ListConfigsResponse ListConfigs(ListConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigs operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListConfigs">REST API Reference for ListConfigs Operation</seealso>
        IAsyncResult BeginListConfigs(ListConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigs.</param>
        /// 
        /// <returns>Returns a  ListConfigsResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListConfigs">REST API Reference for ListConfigs Operation</seealso>
        ListConfigsResponse EndListConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListContacts


        /// <summary>
        /// Returns a list of contacts.
        /// 
        ///  
        /// <para>
        /// If <code>statusList</code> contains AVAILABLE, the request must include <code>groundStation</code>,
        /// <code>missionprofileArn</code>, and <code>satelliteArn</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContacts service method.</param>
        /// 
        /// <returns>The response from the ListContacts service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListContacts">REST API Reference for ListContacts Operation</seealso>
        ListContactsResponse ListContacts(ListContactsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListContacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContacts operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListContacts">REST API Reference for ListContacts Operation</seealso>
        IAsyncResult BeginListContacts(ListContactsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContacts.</param>
        /// 
        /// <returns>Returns a  ListContactsResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListContacts">REST API Reference for ListContacts Operation</seealso>
        ListContactsResponse EndListContacts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataflowEndpointGroups


        /// <summary>
        /// Returns a list of <code>DataflowEndpoint</code> groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataflowEndpointGroups service method.</param>
        /// 
        /// <returns>The response from the ListDataflowEndpointGroups service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListDataflowEndpointGroups">REST API Reference for ListDataflowEndpointGroups Operation</seealso>
        ListDataflowEndpointGroupsResponse ListDataflowEndpointGroups(ListDataflowEndpointGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataflowEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataflowEndpointGroups operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataflowEndpointGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListDataflowEndpointGroups">REST API Reference for ListDataflowEndpointGroups Operation</seealso>
        IAsyncResult BeginListDataflowEndpointGroups(ListDataflowEndpointGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataflowEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataflowEndpointGroups.</param>
        /// 
        /// <returns>Returns a  ListDataflowEndpointGroupsResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListDataflowEndpointGroups">REST API Reference for ListDataflowEndpointGroups Operation</seealso>
        ListDataflowEndpointGroupsResponse EndListDataflowEndpointGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEphemerides


        /// <summary>
        /// List existing ephemerides.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEphemerides service method.</param>
        /// 
        /// <returns>The response from the ListEphemerides service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListEphemerides">REST API Reference for ListEphemerides Operation</seealso>
        ListEphemeridesResponse ListEphemerides(ListEphemeridesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEphemerides operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEphemerides operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEphemerides
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListEphemerides">REST API Reference for ListEphemerides Operation</seealso>
        IAsyncResult BeginListEphemerides(ListEphemeridesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEphemerides operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEphemerides.</param>
        /// 
        /// <returns>Returns a  ListEphemeridesResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListEphemerides">REST API Reference for ListEphemerides Operation</seealso>
        ListEphemeridesResponse EndListEphemerides(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroundStations


        /// <summary>
        /// Returns a list of ground stations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroundStations service method.</param>
        /// 
        /// <returns>The response from the ListGroundStations service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListGroundStations">REST API Reference for ListGroundStations Operation</seealso>
        ListGroundStationsResponse ListGroundStations(ListGroundStationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroundStations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroundStations operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroundStations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListGroundStations">REST API Reference for ListGroundStations Operation</seealso>
        IAsyncResult BeginListGroundStations(ListGroundStationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroundStations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroundStations.</param>
        /// 
        /// <returns>Returns a  ListGroundStationsResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListGroundStations">REST API Reference for ListGroundStations Operation</seealso>
        ListGroundStationsResponse EndListGroundStations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMissionProfiles


        /// <summary>
        /// Returns a list of mission profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMissionProfiles service method.</param>
        /// 
        /// <returns>The response from the ListMissionProfiles service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListMissionProfiles">REST API Reference for ListMissionProfiles Operation</seealso>
        ListMissionProfilesResponse ListMissionProfiles(ListMissionProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMissionProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMissionProfiles operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMissionProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListMissionProfiles">REST API Reference for ListMissionProfiles Operation</seealso>
        IAsyncResult BeginListMissionProfiles(ListMissionProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMissionProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMissionProfiles.</param>
        /// 
        /// <returns>Returns a  ListMissionProfilesResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListMissionProfiles">REST API Reference for ListMissionProfiles Operation</seealso>
        ListMissionProfilesResponse EndListMissionProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSatellites


        /// <summary>
        /// Returns a list of satellites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSatellites service method.</param>
        /// 
        /// <returns>The response from the ListSatellites service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListSatellites">REST API Reference for ListSatellites Operation</seealso>
        ListSatellitesResponse ListSatellites(ListSatellitesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSatellites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSatellites operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSatellites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListSatellites">REST API Reference for ListSatellites Operation</seealso>
        IAsyncResult BeginListSatellites(ListSatellitesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSatellites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSatellites.</param>
        /// 
        /// <returns>Returns a  ListSatellitesResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListSatellites">REST API Reference for ListSatellites Operation</seealso>
        ListSatellitesResponse EndListSatellites(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterAgent


        /// <summary>
        /// Registers a new agent with AWS Groundstation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAgent service method.</param>
        /// 
        /// <returns>The response from the RegisterAgent service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/RegisterAgent">REST API Reference for RegisterAgent Operation</seealso>
        RegisterAgentResponse RegisterAgent(RegisterAgentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAgent operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/RegisterAgent">REST API Reference for RegisterAgent Operation</seealso>
        IAsyncResult BeginRegisterAgent(RegisterAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAgent.</param>
        /// 
        /// <returns>Returns a  RegisterAgentResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/RegisterAgent">REST API Reference for RegisterAgent Operation</seealso>
        RegisterAgentResponse EndRegisterAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  ReserveContact


        /// <summary>
        /// Reserves a contact using specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReserveContact service method.</param>
        /// 
        /// <returns>The response from the ReserveContact service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ReserveContact">REST API Reference for ReserveContact Operation</seealso>
        ReserveContactResponse ReserveContact(ReserveContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReserveContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReserveContact operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReserveContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ReserveContact">REST API Reference for ReserveContact Operation</seealso>
        IAsyncResult BeginReserveContact(ReserveContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReserveContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReserveContact.</param>
        /// 
        /// <returns>Returns a  ReserveContactResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ReserveContact">REST API Reference for ReserveContact Operation</seealso>
        ReserveContactResponse EndReserveContact(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deassigns a resource tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAgentStatus


        /// <summary>
        /// Update the status of the agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentStatus service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        UpdateAgentStatusResponse UpdateAgentStatus(UpdateAgentStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentStatus operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        IAsyncResult BeginUpdateAgentStatus(UpdateAgentStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAgentStatusResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        UpdateAgentStatusResponse EndUpdateAgentStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfig


        /// <summary>
        /// Updates the <code>Config</code> used when scheduling contacts.
        /// 
        ///  
        /// <para>
        /// Updating a <code>Config</code> will not update the execution parameters for existing
        /// future contacts scheduled with this <code>Config</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateConfig">REST API Reference for UpdateConfig Operation</seealso>
        UpdateConfigResponse UpdateConfig(UpdateConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfig operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateConfig">REST API Reference for UpdateConfig Operation</seealso>
        IAsyncResult BeginUpdateConfig(UpdateConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfig.</param>
        /// 
        /// <returns>Returns a  UpdateConfigResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateConfig">REST API Reference for UpdateConfig Operation</seealso>
        UpdateConfigResponse EndUpdateConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEphemeris


        /// <summary>
        /// Updates an existing ephemeris
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEphemeris service method.</param>
        /// 
        /// <returns>The response from the UpdateEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateEphemeris">REST API Reference for UpdateEphemeris Operation</seealso>
        UpdateEphemerisResponse UpdateEphemeris(UpdateEphemerisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEphemeris operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEphemeris operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEphemeris
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateEphemeris">REST API Reference for UpdateEphemeris Operation</seealso>
        IAsyncResult BeginUpdateEphemeris(UpdateEphemerisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEphemeris operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEphemeris.</param>
        /// 
        /// <returns>Returns a  UpdateEphemerisResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateEphemeris">REST API Reference for UpdateEphemeris Operation</seealso>
        UpdateEphemerisResponse EndUpdateEphemeris(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMissionProfile


        /// <summary>
        /// Updates a mission profile.
        /// 
        ///  
        /// <para>
        /// Updating a mission profile will not update the execution parameters for existing future
        /// contacts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMissionProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateMissionProfile">REST API Reference for UpdateMissionProfile Operation</seealso>
        UpdateMissionProfileResponse UpdateMissionProfile(UpdateMissionProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMissionProfile operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMissionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateMissionProfile">REST API Reference for UpdateMissionProfile Operation</seealso>
        IAsyncResult BeginUpdateMissionProfile(UpdateMissionProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMissionProfile.</param>
        /// 
        /// <returns>Returns a  UpdateMissionProfileResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateMissionProfile">REST API Reference for UpdateMissionProfile Operation</seealso>
        UpdateMissionProfileResponse EndUpdateMissionProfile(IAsyncResult asyncResult);

        #endregion
        
    }
}