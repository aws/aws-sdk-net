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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ARCZonalShift.Model;

#pragma warning disable CS1570
namespace Amazon.ARCZonalShift
{
    /// <summary>
    /// <para>Interface for accessing ARCZonalShift</para>
    ///
    /// Welcome to the API Reference Guide for zonal shift and zonal autoshift in Amazon Application
    /// Recovery Controller (ARC).
    /// 
    ///  
    /// <para>
    /// You can start a zonal shift to move traffic for a load balancer resource away from
    /// an Availability Zone to help your application recover quickly from an impairment in
    /// an Availability Zone. For example, you can recover your application from a developer's
    /// bad code deployment or from an Amazon Web Services infrastructure failure in a single
    /// Availability Zone.
    /// </para>
    ///  
    /// <para>
    /// You can also configure zonal autoshift for supported load balancer resources. Zonal
    /// autoshift is a capability in ARC where you authorize Amazon Web Services to shift
    /// away application resource traffic from an Availability Zone during events, on your
    /// behalf, to help reduce your time to recovery. Amazon Web Services starts an autoshift
    /// when internal telemetry indicates that there is an Availability Zone impairment that
    /// could potentially impact customers.
    /// </para>
    ///  
    /// <para>
    /// For more information about using zonal shift and zonal autoshift, see the <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/what-is-route53-recovery.html">Amazon
    /// Application Recovery Controller Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonARCZonalShift : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IARCZonalShiftPaginatorFactory Paginators { get; }
#endif


        
        #region  CancelPracticeRun


        /// <summary>
        /// Cancel an in-progress practice run zonal shift in Amazon Application Recovery Controller.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPracticeRun service method.</param>
        /// 
        /// <returns>The response from the CancelPracticeRun service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelPracticeRun">REST API Reference for CancelPracticeRun Operation</seealso>
        CancelPracticeRunResponse CancelPracticeRun(CancelPracticeRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelPracticeRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelPracticeRun operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelPracticeRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelPracticeRun">REST API Reference for CancelPracticeRun Operation</seealso>
        IAsyncResult BeginCancelPracticeRun(CancelPracticeRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelPracticeRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelPracticeRun.</param>
        /// 
        /// <returns>Returns a  CancelPracticeRunResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelPracticeRun">REST API Reference for CancelPracticeRun Operation</seealso>
        CancelPracticeRunResponse EndCancelPracticeRun(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelZonalShift


        /// <summary>
        /// Cancel a zonal shift in Amazon Application Recovery Controller. To cancel the zonal
        /// shift, specify the zonal shift ID.
        /// 
        ///  
        /// <para>
        /// A zonal shift can be one that you've started for a resource in your Amazon Web Services
        /// account in an Amazon Web Services Region, or it can be a zonal shift started by a
        /// practice run with zonal autoshift. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelZonalShift service method.</param>
        /// 
        /// <returns>The response from the CancelZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelZonalShift">REST API Reference for CancelZonalShift Operation</seealso>
        CancelZonalShiftResponse CancelZonalShift(CancelZonalShiftRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelZonalShift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelZonalShift operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelZonalShift
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelZonalShift">REST API Reference for CancelZonalShift Operation</seealso>
        IAsyncResult BeginCancelZonalShift(CancelZonalShiftRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelZonalShift operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelZonalShift.</param>
        /// 
        /// <returns>Returns a  CancelZonalShiftResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelZonalShift">REST API Reference for CancelZonalShift Operation</seealso>
        CancelZonalShiftResponse EndCancelZonalShift(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePracticeRunConfiguration


        /// <summary>
        /// A practice run configuration for zonal autoshift is required when you enable zonal
        /// autoshift. A practice run configuration includes specifications for blocked dates
        /// and blocked time windows, and for Amazon CloudWatch alarms that you create to use
        /// with practice runs. The alarms that you specify are an <i>outcome alarm</i>, to monitor
        /// application health during practice runs and, optionally, a <i>blocking alarm</i>,
        /// to block practice runs from starting.
        /// 
        ///  
        /// <para>
        /// When a resource has a practice run configuration, ARC starts zonal shifts for the
        /// resource weekly, to shift traffic for practice runs. Practice runs help you to ensure
        /// that shifting away traffic from an Availability Zone during an autoshift is safe for
        /// your application.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.considerations.html">
        /// Considerations when you configure zonal autoshift</a> in the Amazon Application Recovery
        /// Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePracticeRunConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreatePracticeRunConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CreatePracticeRunConfiguration">REST API Reference for CreatePracticeRunConfiguration Operation</seealso>
        CreatePracticeRunConfigurationResponse CreatePracticeRunConfiguration(CreatePracticeRunConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePracticeRunConfiguration operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePracticeRunConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CreatePracticeRunConfiguration">REST API Reference for CreatePracticeRunConfiguration Operation</seealso>
        IAsyncResult BeginCreatePracticeRunConfiguration(CreatePracticeRunConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePracticeRunConfiguration.</param>
        /// 
        /// <returns>Returns a  CreatePracticeRunConfigurationResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CreatePracticeRunConfiguration">REST API Reference for CreatePracticeRunConfiguration Operation</seealso>
        CreatePracticeRunConfigurationResponse EndCreatePracticeRunConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePracticeRunConfiguration


        /// <summary>
        /// Deletes the practice run configuration for a resource. Before you can delete a practice
        /// run configuration for a resource., you must disable zonal autoshift for the resource.
        /// Practice runs must be configured for zonal autoshift to be enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePracticeRunConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeletePracticeRunConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/DeletePracticeRunConfiguration">REST API Reference for DeletePracticeRunConfiguration Operation</seealso>
        DeletePracticeRunConfigurationResponse DeletePracticeRunConfiguration(DeletePracticeRunConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePracticeRunConfiguration operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePracticeRunConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/DeletePracticeRunConfiguration">REST API Reference for DeletePracticeRunConfiguration Operation</seealso>
        IAsyncResult BeginDeletePracticeRunConfiguration(DeletePracticeRunConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePracticeRunConfiguration.</param>
        /// 
        /// <returns>Returns a  DeletePracticeRunConfigurationResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/DeletePracticeRunConfiguration">REST API Reference for DeletePracticeRunConfiguration Operation</seealso>
        DeletePracticeRunConfigurationResponse EndDeletePracticeRunConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAutoshiftObserverNotificationStatus


        /// <summary>
        /// Returns the status of the autoshift observer notification. Autoshift observer notifications
        /// notify you through Amazon EventBridge when there is an autoshift event for zonal autoshift.
        /// The status can be <c>ENABLED</c> or <c>DISABLED</c>. When <c>ENABLED</c>, a notification
        /// is sent when an autoshift is triggered. When <c>DISABLED</c>, notifications are not
        /// sent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoshiftObserverNotificationStatus service method.</param>
        /// 
        /// <returns>The response from the GetAutoshiftObserverNotificationStatus service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetAutoshiftObserverNotificationStatus">REST API Reference for GetAutoshiftObserverNotificationStatus Operation</seealso>
        GetAutoshiftObserverNotificationStatusResponse GetAutoshiftObserverNotificationStatus(GetAutoshiftObserverNotificationStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutoshiftObserverNotificationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutoshiftObserverNotificationStatus operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutoshiftObserverNotificationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetAutoshiftObserverNotificationStatus">REST API Reference for GetAutoshiftObserverNotificationStatus Operation</seealso>
        IAsyncResult BeginGetAutoshiftObserverNotificationStatus(GetAutoshiftObserverNotificationStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutoshiftObserverNotificationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutoshiftObserverNotificationStatus.</param>
        /// 
        /// <returns>Returns a  GetAutoshiftObserverNotificationStatusResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetAutoshiftObserverNotificationStatus">REST API Reference for GetAutoshiftObserverNotificationStatus Operation</seealso>
        GetAutoshiftObserverNotificationStatusResponse EndGetAutoshiftObserverNotificationStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetManagedResource


        /// <summary>
        /// Get information about a resource that's been registered for zonal shifts with Amazon
        /// Application Recovery Controller in this Amazon Web Services Region. Resources that
        /// are registered for zonal shifts are managed resources in ARC. You can start zonal
        /// shifts and configure zonal autoshift for managed resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedResource service method.</param>
        /// 
        /// <returns>The response from the GetManagedResource service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetManagedResource">REST API Reference for GetManagedResource Operation</seealso>
        GetManagedResourceResponse GetManagedResource(GetManagedResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedResource operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetManagedResource">REST API Reference for GetManagedResource Operation</seealso>
        IAsyncResult BeginGetManagedResource(GetManagedResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedResource.</param>
        /// 
        /// <returns>Returns a  GetManagedResourceResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetManagedResource">REST API Reference for GetManagedResource Operation</seealso>
        GetManagedResourceResponse EndGetManagedResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAutoshifts


        /// <summary>
        /// Returns the autoshifts for an Amazon Web Services Region. By default, the call returns
        /// only <c>ACTIVE</c> autoshifts. Optionally, you can specify the <c>status</c> parameter
        /// to return <c>COMPLETED</c> autoshifts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoshifts service method.</param>
        /// 
        /// <returns>The response from the ListAutoshifts service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListAutoshifts">REST API Reference for ListAutoshifts Operation</seealso>
        ListAutoshiftsResponse ListAutoshifts(ListAutoshiftsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutoshifts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutoshifts operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutoshifts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListAutoshifts">REST API Reference for ListAutoshifts Operation</seealso>
        IAsyncResult BeginListAutoshifts(ListAutoshiftsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutoshifts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutoshifts.</param>
        /// 
        /// <returns>Returns a  ListAutoshiftsResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListAutoshifts">REST API Reference for ListAutoshifts Operation</seealso>
        ListAutoshiftsResponse EndListAutoshifts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListManagedResources


        /// <summary>
        /// Lists all the resources in your Amazon Web Services account in this Amazon Web Services
        /// Region that are managed for zonal shifts in Amazon Application Recovery Controller,
        /// and information about them. The information includes the zonal autoshift status for
        /// the resource, as well as the Amazon Resource Name (ARN), the Availability Zones that
        /// each resource is deployed in, and the resource name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedResources service method.</param>
        /// 
        /// <returns>The response from the ListManagedResources service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListManagedResources">REST API Reference for ListManagedResources Operation</seealso>
        ListManagedResourcesResponse ListManagedResources(ListManagedResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedResources operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListManagedResources">REST API Reference for ListManagedResources Operation</seealso>
        IAsyncResult BeginListManagedResources(ListManagedResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedResources.</param>
        /// 
        /// <returns>Returns a  ListManagedResourcesResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListManagedResources">REST API Reference for ListManagedResources Operation</seealso>
        ListManagedResourcesResponse EndListManagedResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListZonalShifts


        /// <summary>
        /// Lists all active and completed zonal shifts in Amazon Application Recovery Controller
        /// in your Amazon Web Services account in this Amazon Web Services Region. <c>ListZonalShifts</c>
        /// returns customer-initiated zonal shifts, as well as practice run zonal shifts that
        /// ARC started on your behalf for zonal autoshift.
        /// 
        ///  
        /// <para>
        /// For more information about listing autoshifts, see <a href="https://docs.aws.amazon.com/arc-zonal-shift/latest/api/API_ListAutoshifts.html">"&gt;ListAutoshifts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListZonalShifts service method.</param>
        /// 
        /// <returns>The response from the ListZonalShifts service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListZonalShifts">REST API Reference for ListZonalShifts Operation</seealso>
        ListZonalShiftsResponse ListZonalShifts(ListZonalShiftsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListZonalShifts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListZonalShifts operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListZonalShifts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListZonalShifts">REST API Reference for ListZonalShifts Operation</seealso>
        IAsyncResult BeginListZonalShifts(ListZonalShiftsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListZonalShifts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListZonalShifts.</param>
        /// 
        /// <returns>Returns a  ListZonalShiftsResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListZonalShifts">REST API Reference for ListZonalShifts Operation</seealso>
        ListZonalShiftsResponse EndListZonalShifts(IAsyncResult asyncResult);

        #endregion
        
        #region  StartPracticeRun


        /// <summary>
        /// Start an on-demand practice run zonal shift in Amazon Application Recovery Controller.
        /// With zonal autoshift enabled, you can start an on-demand practice run to verify preparedness
        /// at any time. Amazon Web Services also runs automated practice runs about weekly when
        /// you have enabled zonal autoshift.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.considerations.html">
        /// Considerations when you configure zonal autoshift</a> in the Amazon Application Recovery
        /// Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPracticeRun service method.</param>
        /// 
        /// <returns>The response from the StartPracticeRun service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartPracticeRun">REST API Reference for StartPracticeRun Operation</seealso>
        StartPracticeRunResponse StartPracticeRun(StartPracticeRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartPracticeRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPracticeRun operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPracticeRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartPracticeRun">REST API Reference for StartPracticeRun Operation</seealso>
        IAsyncResult BeginStartPracticeRun(StartPracticeRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartPracticeRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPracticeRun.</param>
        /// 
        /// <returns>Returns a  StartPracticeRunResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartPracticeRun">REST API Reference for StartPracticeRun Operation</seealso>
        StartPracticeRunResponse EndStartPracticeRun(IAsyncResult asyncResult);

        #endregion
        
        #region  StartZonalShift


        /// <summary>
        /// You start a zonal shift to temporarily move load balancer traffic away from an Availability
        /// Zone in an Amazon Web Services Region, to help your application recover immediately,
        /// for example, from a developer's bad code deployment or from an Amazon Web Services
        /// infrastructure failure in a single Availability Zone. You can start a zonal shift
        /// in ARC only for managed resources in your Amazon Web Services account in an Amazon
        /// Web Services Region. Resources are automatically registered with ARC by Amazon Web
        /// Services services.
        /// 
        ///  
        /// <para>
        /// Amazon Application Recovery Controller currently supports enabling the following resources
        /// for zonal shift and zonal autoshift:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.ec2-auto-scaling-groups.html">Amazon
        /// EC2 Auto Scaling groups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.eks.html">Amazon
        /// Elastic Kubernetes Service</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.app-load-balancers.html">Application
        /// Load Balancer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.network-load-balancers.html">Network
        /// Load Balancer</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you start a zonal shift, traffic for the resource is no longer routed to the
        /// Availability Zone. The zonal shift is created immediately in ARC. However, it can
        /// take a short time, typically up to a few minutes, for existing, in-progress connections
        /// in the Availability Zone to complete.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.html">Zonal
        /// shift</a> in the Amazon Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartZonalShift service method.</param>
        /// 
        /// <returns>The response from the StartZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartZonalShift">REST API Reference for StartZonalShift Operation</seealso>
        StartZonalShiftResponse StartZonalShift(StartZonalShiftRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartZonalShift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartZonalShift operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartZonalShift
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartZonalShift">REST API Reference for StartZonalShift Operation</seealso>
        IAsyncResult BeginStartZonalShift(StartZonalShiftRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartZonalShift operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartZonalShift.</param>
        /// 
        /// <returns>Returns a  StartZonalShiftResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartZonalShift">REST API Reference for StartZonalShift Operation</seealso>
        StartZonalShiftResponse EndStartZonalShift(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAutoshiftObserverNotificationStatus


        /// <summary>
        /// Update the status of autoshift observer notification. Autoshift observer notification
        /// enables you to be notified, through Amazon EventBridge, when there is an autoshift
        /// event for zonal autoshift.
        /// 
        ///  
        /// <para>
        /// If the status is <c>ENABLED</c>, ARC includes all autoshift events when you use the
        /// EventBridge pattern <c>Autoshift In Progress</c>. When the status is <c>DISABLED</c>,
        /// ARC includes only autoshift events for autoshifts when one or more of your resources
        /// is included in the autoshift.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.how-it-works.html#ZAShiftNotification">
        /// Notifications for practice runs and autoshifts</a> in the Amazon Application Recovery
        /// Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoshiftObserverNotificationStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAutoshiftObserverNotificationStatus service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateAutoshiftObserverNotificationStatus">REST API Reference for UpdateAutoshiftObserverNotificationStatus Operation</seealso>
        UpdateAutoshiftObserverNotificationStatusResponse UpdateAutoshiftObserverNotificationStatus(UpdateAutoshiftObserverNotificationStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutoshiftObserverNotificationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoshiftObserverNotificationStatus operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAutoshiftObserverNotificationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateAutoshiftObserverNotificationStatus">REST API Reference for UpdateAutoshiftObserverNotificationStatus Operation</seealso>
        IAsyncResult BeginUpdateAutoshiftObserverNotificationStatus(UpdateAutoshiftObserverNotificationStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAutoshiftObserverNotificationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutoshiftObserverNotificationStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAutoshiftObserverNotificationStatusResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateAutoshiftObserverNotificationStatus">REST API Reference for UpdateAutoshiftObserverNotificationStatus Operation</seealso>
        UpdateAutoshiftObserverNotificationStatusResponse EndUpdateAutoshiftObserverNotificationStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePracticeRunConfiguration


        /// <summary>
        /// Update a practice run configuration to change one or more of the following: add, change,
        /// or remove the blocking alarm; change the outcome alarm; or add, change, or remove
        /// blocking dates or time windows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePracticeRunConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdatePracticeRunConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdatePracticeRunConfiguration">REST API Reference for UpdatePracticeRunConfiguration Operation</seealso>
        UpdatePracticeRunConfigurationResponse UpdatePracticeRunConfiguration(UpdatePracticeRunConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePracticeRunConfiguration operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePracticeRunConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdatePracticeRunConfiguration">REST API Reference for UpdatePracticeRunConfiguration Operation</seealso>
        IAsyncResult BeginUpdatePracticeRunConfiguration(UpdatePracticeRunConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePracticeRunConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdatePracticeRunConfigurationResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdatePracticeRunConfiguration">REST API Reference for UpdatePracticeRunConfiguration Operation</seealso>
        UpdatePracticeRunConfigurationResponse EndUpdatePracticeRunConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateZonalAutoshiftConfiguration


        /// <summary>
        /// The zonal autoshift configuration for a resource includes the practice run configuration
        /// and the status for running autoshifts, zonal autoshift status. When a resource has
        /// a practice run configuration, ARC starts weekly zonal shifts for the resource, to
        /// shift traffic away from an Availability Zone. Weekly practice runs help you to make
        /// sure that your application can continue to operate normally with the loss of one Availability
        /// Zone.
        /// 
        ///  
        /// <para>
        /// You can update the zonal autoshift status to enable or disable zonal autoshift. When
        /// zonal autoshift is <c>ENABLED</c>, you authorize Amazon Web Services to shift away
        /// resource traffic for an application from an Availability Zone during events, on your
        /// behalf, to help reduce time to recovery. Traffic is also shifted away for the required
        /// weekly practice runs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalAutoshiftConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateZonalAutoshiftConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalAutoshiftConfiguration">REST API Reference for UpdateZonalAutoshiftConfiguration Operation</seealso>
        UpdateZonalAutoshiftConfigurationResponse UpdateZonalAutoshiftConfiguration(UpdateZonalAutoshiftConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateZonalAutoshiftConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalAutoshiftConfiguration operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateZonalAutoshiftConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalAutoshiftConfiguration">REST API Reference for UpdateZonalAutoshiftConfiguration Operation</seealso>
        IAsyncResult BeginUpdateZonalAutoshiftConfiguration(UpdateZonalAutoshiftConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateZonalAutoshiftConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateZonalAutoshiftConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateZonalAutoshiftConfigurationResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalAutoshiftConfiguration">REST API Reference for UpdateZonalAutoshiftConfiguration Operation</seealso>
        UpdateZonalAutoshiftConfigurationResponse EndUpdateZonalAutoshiftConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateZonalShift


        /// <summary>
        /// Update an active zonal shift in Amazon Application Recovery Controller in your Amazon
        /// Web Services account. You can update a zonal shift to set a new expiration, or edit
        /// or replace the comment for the zonal shift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalShift service method.</param>
        /// 
        /// <returns>The response from the UpdateZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalShift">REST API Reference for UpdateZonalShift Operation</seealso>
        UpdateZonalShiftResponse UpdateZonalShift(UpdateZonalShiftRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateZonalShift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalShift operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateZonalShift
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalShift">REST API Reference for UpdateZonalShift Operation</seealso>
        IAsyncResult BeginUpdateZonalShift(UpdateZonalShiftRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateZonalShift operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateZonalShift.</param>
        /// 
        /// <returns>Returns a  UpdateZonalShiftResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalShift">REST API Reference for UpdateZonalShift Operation</seealso>
        UpdateZonalShiftResponse EndUpdateZonalShift(IAsyncResult asyncResult);

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