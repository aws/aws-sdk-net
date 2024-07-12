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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ARCZonalShift.Model;

#pragma warning disable CS1570
namespace Amazon.ARCZonalShift
{
    /// <summary>
    /// <para>Interface for accessing ARCZonalShift</para>
    ///
    /// Welcome to the API Reference Guide for zonal shift and zonal autoshift in Amazon Route
    /// 53 Application Recovery Controller (Route 53 ARC).
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
    /// autoshift is a capability in Route 53 ARC where you authorize Amazon Web Services
    /// to shift away application resource traffic from an Availability Zone during events,
    /// on your behalf, to help reduce your time to recovery. Amazon Web Services starts an
    /// autoshift when internal telemetry indicates that there is an Availability Zone impairment
    /// that could potentially impact customers.
    /// </para>
    ///  
    /// <para>
    /// To help make sure that zonal autoshift is safe for your application, you must also
    /// configure practice runs when you enable zonal autoshift for a resource. Practice runs
    /// start weekly zonal shifts for a resource, to shift traffic for the resource away from
    /// an Availability Zone. Practice runs help you to make sure, on a regular basis, that
    /// you have enough capacity in all the Availability Zones in an Amazon Web Services Region
    /// for your application to continue to operate normally when traffic for a resource is
    /// shifted away from one Availability Zone.
    /// </para>
    ///  <important> 
    /// <para>
    /// Before you configure practice runs or enable zonal autoshift, we strongly recommend
    /// that you prescale your application resource capacity in all Availability Zones in
    /// the Region where your application resources are deployed. You should not rely on scaling
    /// on demand when an autoshift or practice run starts. Zonal autoshift, including practice
    /// runs, works independently, and does not wait for auto scaling actions to complete.
    /// Relying on auto scaling, instead of pre-scaling, can result in loss of availability.
    /// </para>
    ///  
    /// <para>
    /// If you use auto scaling to handle regular cycles of traffic, we strongly recommend
    /// that you configure the minimum capacity of your auto scaling to continue operating
    /// normally with the loss of an Availability Zone. 
    /// </para>
    ///  </important> 
    /// <para>
    /// Be aware that Route 53 ARC does not inspect the health of individual resources. Amazon
    /// Web Services only starts an autoshift when Amazon Web Services telemetry detects that
    /// there is an Availability Zone impairment that could potentially impact customers.
    /// In some cases, resources might be shifted away that are not experiencing impact.
    /// </para>
    ///  
    /// <para>
    /// For more information about using zonal shift and zonal autoshift, see the <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/what-is-route53-recovery.html">Amazon
    /// Route 53 Application Recovery Controller Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonARCZonalShift : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IARCZonalShiftPaginatorFactory Paginators { get; }
#endif
                
        #region  CancelZonalShift



        /// <summary>
        /// Cancel a zonal shift in Amazon Route 53 Application Recovery Controller. To cancel
        /// the zonal shift, specify the zonal shift ID.
        /// 
        ///  
        /// <para>
        /// A zonal shift can be one that you've started for a resource in your Amazon Web Services
        /// account in an Amazon Web Services Region, or it can be a zonal shift started by a
        /// practice run with zonal autoshift. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelZonalShift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CancelZonalShiftResponse> CancelZonalShiftAsync(CancelZonalShiftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// When a resource has a practice run configuration, Route 53 ARC starts zonal shifts
        /// for the resource weekly, to shift traffic for practice runs. Practice runs help you
        /// to ensure that shifting away traffic from an Availability Zone during an autoshift
        /// is safe for your application.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.considerations.html">
        /// Considerations when you configure zonal autoshift</a> in the Amazon Route 53 Application
        /// Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePracticeRunConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreatePracticeRunConfigurationResponse> CreatePracticeRunConfigurationAsync(CreatePracticeRunConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePracticeRunConfiguration



        /// <summary>
        /// Deletes the practice run configuration for a resource. Before you can delete a practice
        /// run configuration for a resource., you must disable zonal autoshift for the resource.
        /// Practice runs must be configured for zonal autoshift to be enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePracticeRunConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeletePracticeRunConfigurationResponse> DeletePracticeRunConfigurationAsync(DeletePracticeRunConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAutoshiftObserverNotificationStatus



        /// <summary>
        /// Returns the status of autoshift observer notification. Autoshift observer notification
        /// enables you to be notified, through Amazon EventBridge, when there is an autoshift
        /// event for zonal autoshift.
        /// 
        ///  
        /// <para>
        /// If the status is <c>ENABLED</c>, Route 53 ARC includes all autoshift events when you
        /// use the EventBridge pattern <c>Autoshift In Progress</c>. When the status is <c>DISABLED</c>,
        /// Route 53 ARC includes only autoshift events for autoshifts when one or more of your
        /// resources is included in the autoshift.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.how-it-works.html#ZAShiftNotification">
        /// Notifications for practice runs and autoshifts</a> in the Amazon Route 53 Application
        /// Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoshiftObserverNotificationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAutoshiftObserverNotificationStatusResponse> GetAutoshiftObserverNotificationStatusAsync(GetAutoshiftObserverNotificationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedResource



        /// <summary>
        /// Get information about a resource that's been registered for zonal shifts with Amazon
        /// Route 53 Application Recovery Controller in this Amazon Web Services Region. Resources
        /// that are registered for zonal shifts are managed resources in Route 53 ARC. You can
        /// start zonal shifts and configure zonal autoshift for managed resources.
        /// 
        ///  
        /// <para>
        /// At this time, you can only start a zonal shift or configure zonal autoshift for Network
        /// Load Balancers and Application Load Balancers with cross-zone load balancing turned
        /// off.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetManagedResourceResponse> GetManagedResourceAsync(GetManagedResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAutoshifts



        /// <summary>
        /// Returns a list of autoshifts for an Amazon Web Services Region. By default, the call
        /// returns only <c>ACTIVE</c> autoshifts. Optionally, you can specify the <c>status</c>
        /// parameter to return <c>COMPLETED</c> autoshifts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoshifts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAutoshiftsResponse> ListAutoshiftsAsync(ListAutoshiftsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListManagedResources



        /// <summary>
        /// Lists all the resources in your Amazon Web Services account in this Amazon Web Services
        /// Region that are managed for zonal shifts in Amazon Route 53 Application Recovery Controller,
        /// and information about them. The information includes the zonal autoshift status for
        /// the resource, as well as the Amazon Resource Name (ARN), the Availability Zones that
        /// each resource is deployed in, and the resource name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListManagedResourcesResponse> ListManagedResourcesAsync(ListManagedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListZonalShifts



        /// <summary>
        /// Lists all active and completed zonal shifts in Amazon Route 53 Application Recovery
        /// Controller in your Amazon Web Services account in this Amazon Web Services Region.
        /// <c>ListZonalShifts</c> returns customer-initiated zonal shifts, as well as practice
        /// run zonal shifts that Route 53 ARC started on your behalf for zonal autoshift.
        /// 
        ///  
        /// <para>
        /// The <c>ListZonalShifts</c> operation does not list autoshifts. For more information
        /// about listing autoshifts, see <a href="https://docs.aws.amazon.com/arc-zonal-shift/latest/api/API_ListAutoshifts.html">"&gt;ListAutoshifts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListZonalShifts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListZonalShiftsResponse> ListZonalShiftsAsync(ListZonalShiftsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartZonalShift



        /// <summary>
        /// You start a zonal shift to temporarily move load balancer traffic away from an Availability
        /// Zone in an Amazon Web Services Region, to help your application recover immediately,
        /// for example, from a developer's bad code deployment or from an Amazon Web Services
        /// infrastructure failure in a single Availability Zone. You can start a zonal shift
        /// in Route 53 ARC only for managed resources in your Amazon Web Services account in
        /// an Amazon Web Services Region. Resources are automatically registered with Route 53
        /// ARC by Amazon Web Services services.
        /// 
        ///  
        /// <para>
        /// At this time, you can only start a zonal shift for Network Load Balancers and Application
        /// Load Balancers with cross-zone load balancing turned off.
        /// </para>
        ///  
        /// <para>
        /// When you start a zonal shift, traffic for the resource is no longer routed to the
        /// Availability Zone. The zonal shift is created immediately in Route 53 ARC. However,
        /// it can take a short time, typically up to a few minutes, for existing, in-progress
        /// connections in the Availability Zone to complete.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.html">Zonal
        /// shift</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartZonalShift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartZonalShiftResponse> StartZonalShiftAsync(StartZonalShiftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAutoshiftObserverNotificationStatus



        /// <summary>
        /// Update the status of autoshift observer notification. Autoshift observer notification
        /// enables you to be notified, through Amazon EventBridge, when there is an autoshift
        /// event for zonal autoshift.
        /// 
        ///  
        /// <para>
        /// If the status is <c>ENABLED</c>, Route 53 ARC includes all autoshift events when you
        /// use the EventBridge pattern <c>Autoshift In Progress</c>. When the status is <c>DISABLED</c>,
        /// Route 53 ARC includes only autoshift events for autoshifts when one or more of your
        /// resources is included in the autoshift.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.how-it-works.html#ZAShiftNotification">
        /// Notifications for practice runs and autoshifts</a> in the Amazon Route 53 Application
        /// Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoshiftObserverNotificationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAutoshiftObserverNotificationStatusResponse> UpdateAutoshiftObserverNotificationStatusAsync(UpdateAutoshiftObserverNotificationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePracticeRunConfiguration



        /// <summary>
        /// Update a practice run configuration to change one or more of the following: add, change,
        /// or remove the blocking alarm; change the outcome alarm; or add, change, or remove
        /// blocking dates or time windows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePracticeRunConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdatePracticeRunConfigurationResponse> UpdatePracticeRunConfigurationAsync(UpdatePracticeRunConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateZonalAutoshiftConfiguration



        /// <summary>
        /// The zonal autoshift configuration for a resource includes the practice run configuration
        /// and the status for running autoshifts, zonal autoshift status. When a resource has
        /// a practice run configuation, Route 53 ARC starts weekly zonal shifts for the resource,
        /// to shift traffic away from an Availability Zone. Weekly practice runs help you to
        /// make sure that your application can continue to operate normally with the loss of
        /// one Availability Zone.
        /// 
        ///  
        /// <para>
        /// You can update the zonal autoshift autoshift status to enable or disable zonal autoshift.
        /// When zonal autoshift is <c>ENABLED</c>, you authorize Amazon Web Services to shift
        /// away resource traffic for an application from an Availability Zone during events,
        /// on your behalf, to help reduce time to recovery. Traffic is also shifted away for
        /// the required weekly practice runs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalAutoshiftConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateZonalAutoshiftConfigurationResponse> UpdateZonalAutoshiftConfigurationAsync(UpdateZonalAutoshiftConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateZonalShift



        /// <summary>
        /// Update an active zonal shift in Amazon Route 53 Application Recovery Controller in
        /// your Amazon Web Services account. You can update a zonal shift to set a new expiration,
        /// or edit or replace the comment for the zonal shift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalShift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateZonalShiftResponse> UpdateZonalShiftAsync(UpdateZonalShiftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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