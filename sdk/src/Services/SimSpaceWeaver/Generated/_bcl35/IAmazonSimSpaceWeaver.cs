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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SimSpaceWeaver.Model;

namespace Amazon.SimSpaceWeaver
{
    /// <summary>
    /// Interface for accessing SimSpaceWeaver
    ///
    /// Amazon Web Services SimSpace Weaver (SimSpace Weaver) is a managed service that you
    /// can use to build and operate large-scale spatial simulations in the Amazon Web Services
    /// Cloud. For example, you can create a digital twin of a city, crowd simulations with
    /// millions of people and objects, and massilvely-multiplayer games with hundreds of
    /// thousands of connected players. For more information about SimSpace Weaver, see the
    /// <i> <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/">Amazon
    /// Web Services SimSpace Weaver User Guide</a> </i>.
    /// 
    ///  
    /// <para>
    /// This API reference describes the API operations and data types that you can use to
    /// communicate directly with SimSpace Weaver.
    /// </para>
    ///  
    /// <para>
    /// SimSpace Weaver also provides the SimSpace Weaver app SDK, which you use for app development.
    /// The SimSpace Weaver app SDK API reference is included in the SimSpace Weaver app SDK
    /// documentation, which is part of the SimSpace Weaver app SDK distributable package.
    /// </para>
    /// </summary>
    public partial interface IAmazonSimSpaceWeaver : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISimSpaceWeaverPaginatorFactory Paginators { get; }
#endif


        
        #region  DeleteApp


        /// <summary>
        /// Deletes the instance of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        DeleteAppResponse DeleteApp(DeleteAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSimulation


        /// <summary>
        /// Deletes all SimSpace Weaver resources assigned to the given simulation.
        /// 
        ///  <note> 
        /// <para>
        /// Your simulation uses resources in other Amazon Web Services services. This API operation
        /// doesn't delete resources in other Amazon Web Services services.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulation service method.</param>
        /// 
        /// <returns>The response from the DeleteSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteSimulation">REST API Reference for DeleteSimulation Operation</seealso>
        DeleteSimulationResponse DeleteSimulation(DeleteSimulationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSimulation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulation operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSimulation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteSimulation">REST API Reference for DeleteSimulation Operation</seealso>
        IAsyncResult BeginDeleteSimulation(DeleteSimulationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSimulation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSimulation.</param>
        /// 
        /// <returns>Returns a  DeleteSimulationResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteSimulation">REST API Reference for DeleteSimulation Operation</seealso>
        DeleteSimulationResponse EndDeleteSimulation(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApp


        /// <summary>
        /// Returns the state of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        DescribeAppResponse DescribeApp(DescribeAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        IAsyncResult BeginDescribeApp(DescribeAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApp.</param>
        /// 
        /// <returns>Returns a  DescribeAppResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        DescribeAppResponse EndDescribeApp(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSimulation


        /// <summary>
        /// Returns the current state of the given simulation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulation service method.</param>
        /// 
        /// <returns>The response from the DescribeSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeSimulation">REST API Reference for DescribeSimulation Operation</seealso>
        DescribeSimulationResponse DescribeSimulation(DescribeSimulationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSimulation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulation operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSimulation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeSimulation">REST API Reference for DescribeSimulation Operation</seealso>
        IAsyncResult BeginDescribeSimulation(DescribeSimulationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSimulation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSimulation.</param>
        /// 
        /// <returns>Returns a  DescribeSimulationResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeSimulation">REST API Reference for DescribeSimulation Operation</seealso>
        DescribeSimulationResponse EndDescribeSimulation(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApps


        /// <summary>
        /// Lists all custom apps or service apps for the given simulation and domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListApps">REST API Reference for ListApps Operation</seealso>
        ListAppsResponse ListApps(ListAppsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApps operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListApps">REST API Reference for ListApps Operation</seealso>
        IAsyncResult BeginListApps(ListAppsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApps.</param>
        /// 
        /// <returns>Returns a  ListAppsResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListApps">REST API Reference for ListApps Operation</seealso>
        ListAppsResponse EndListApps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSimulations


        /// <summary>
        /// Lists the SimSpace Weaver simulations in the Amazon Web Services account used to make
        /// the API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulations service method.</param>
        /// 
        /// <returns>The response from the ListSimulations service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListSimulations">REST API Reference for ListSimulations Operation</seealso>
        ListSimulationsResponse ListSimulations(ListSimulationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSimulations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSimulations operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSimulations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListSimulations">REST API Reference for ListSimulations Operation</seealso>
        IAsyncResult BeginListSimulations(ListSimulationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSimulations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSimulations.</param>
        /// 
        /// <returns>Returns a  ListSimulationsResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListSimulations">REST API Reference for ListSimulations Operation</seealso>
        ListSimulationsResponse EndListSimulations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on a SimSpace Weaver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartApp


        /// <summary>
        /// Starts a custom app with the configuration specified in the simulation schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApp service method.</param>
        /// 
        /// <returns>The response from the StartApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartApp">REST API Reference for StartApp Operation</seealso>
        StartAppResponse StartApp(StartAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartApp operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartApp">REST API Reference for StartApp Operation</seealso>
        IAsyncResult BeginStartApp(StartAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartApp.</param>
        /// 
        /// <returns>Returns a  StartAppResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartApp">REST API Reference for StartApp Operation</seealso>
        StartAppResponse EndStartApp(IAsyncResult asyncResult);

        #endregion
        
        #region  StartClock


        /// <summary>
        /// Starts the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartClock service method.</param>
        /// 
        /// <returns>The response from the StartClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartClock">REST API Reference for StartClock Operation</seealso>
        StartClockResponse StartClock(StartClockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartClock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartClock operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartClock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartClock">REST API Reference for StartClock Operation</seealso>
        IAsyncResult BeginStartClock(StartClockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartClock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartClock.</param>
        /// 
        /// <returns>Returns a  StartClockResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartClock">REST API Reference for StartClock Operation</seealso>
        StartClockResponse EndStartClock(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSimulation


        /// <summary>
        /// Starts a simulation with the given name and schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSimulation service method.</param>
        /// 
        /// <returns>The response from the StartSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartSimulation">REST API Reference for StartSimulation Operation</seealso>
        StartSimulationResponse StartSimulation(StartSimulationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSimulation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSimulation operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSimulation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartSimulation">REST API Reference for StartSimulation Operation</seealso>
        IAsyncResult BeginStartSimulation(StartSimulationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSimulation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSimulation.</param>
        /// 
        /// <returns>Returns a  StartSimulationResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartSimulation">REST API Reference for StartSimulation Operation</seealso>
        StartSimulationResponse EndStartSimulation(IAsyncResult asyncResult);

        #endregion
        
        #region  StopApp


        /// <summary>
        /// Stops the given custom app and shuts down all of its allocated compute resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApp service method.</param>
        /// 
        /// <returns>The response from the StopApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopApp">REST API Reference for StopApp Operation</seealso>
        StopAppResponse StopApp(StopAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopApp operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopApp">REST API Reference for StopApp Operation</seealso>
        IAsyncResult BeginStopApp(StopAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopApp.</param>
        /// 
        /// <returns>Returns a  StopAppResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopApp">REST API Reference for StopApp Operation</seealso>
        StopAppResponse EndStopApp(IAsyncResult asyncResult);

        #endregion
        
        #region  StopClock


        /// <summary>
        /// Stops the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopClock service method.</param>
        /// 
        /// <returns>The response from the StopClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopClock">REST API Reference for StopClock Operation</seealso>
        StopClockResponse StopClock(StopClockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopClock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopClock operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopClock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopClock">REST API Reference for StopClock Operation</seealso>
        IAsyncResult BeginStopClock(StopClockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopClock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopClock.</param>
        /// 
        /// <returns>Returns a  StopClockResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopClock">REST API Reference for StopClock Operation</seealso>
        StopClockResponse EndStopClock(IAsyncResult asyncResult);

        #endregion
        
        #region  StopSimulation


        /// <summary>
        /// Stops the given simulation.
        /// 
        ///  <important> 
        /// <para>
        /// You can't restart a simulation after you stop it. If you need to restart a simulation,
        /// you must stop it, delete it, and start a new instance of it.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSimulation service method.</param>
        /// 
        /// <returns>The response from the StopSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopSimulation">REST API Reference for StopSimulation Operation</seealso>
        StopSimulationResponse StopSimulation(StopSimulationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopSimulation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSimulation operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSimulation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopSimulation">REST API Reference for StopSimulation Operation</seealso>
        IAsyncResult BeginStopSimulation(StopSimulationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopSimulation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSimulation.</param>
        /// 
        /// <returns>Returns a  StopSimulationResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopSimulation">REST API Reference for StopSimulation Operation</seealso>
        StopSimulationResponse EndStopSimulation(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a SimSpace Weaver resource. For more information about tags, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a SimSpace Weaver resource. For more information about tags, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
    }
}