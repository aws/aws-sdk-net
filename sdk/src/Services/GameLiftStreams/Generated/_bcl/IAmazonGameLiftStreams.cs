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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GameLiftStreams.Model;

#pragma warning disable CS1570
namespace Amazon.GameLiftStreams
{
    /// <summary>
    /// <para>Interface for accessing GameLiftStreams</para>
    ///
    /// Amazon GameLift Streams 
    /// <para>
    /// Amazon GameLift Streams provides a global cloud solution for content streaming experiences.
    /// Use Amazon GameLift Streams tools to upload and configure content for streaming, deploy
    /// and scale computing resources to host streams, and manage stream session placement
    /// to meet customer demand.
    /// 
    ///  
    /// <para>
    /// This Reference Guide describes the Amazon GameLift Streams service API. You can use
    /// the API through the Amazon Web Services SDK, the Command Line Interface (CLI), or
    /// by making direct REST calls through HTTPS.
    /// </para>
    ///  
    /// <para>
    /// See the <i>Amazon GameLift Streams Developer Guide</i> for more information on how
    /// Amazon GameLift Streams works and how to work with it.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonGameLiftStreams : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IGameLiftStreamsPaginatorFactory Paginators { get; }

        
        #region  AddStreamGroupLocations


        /// <summary>
        /// Add locations that can host stream sessions. You configure locations and their corresponding
        /// capacity for each stream group. Creating a stream group in a location that's nearest
        /// to your end users can help minimize latency and improve quality. 
        /// 
        ///  
        /// <para>
        ///  This operation provisions stream capacity at the specified locations. By default,
        /// all locations have 1 or 2 capacity, depending on the stream class option: 2 for 'High'
        /// and 1 for 'Ultra' and 'Win2022'. This operation also copies the content files of all
        /// associated applications to an internal S3 bucket at each location. This allows Amazon
        /// GameLift Streams to host performant stream sessions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddStreamGroupLocations service method.</param>
        /// 
        /// <returns>The response from the AddStreamGroupLocations service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ServiceQuotaExceededException">
        /// The request would cause the resource to exceed an allowed service quota. Resolve the
        /// issue before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/AddStreamGroupLocations">REST API Reference for AddStreamGroupLocations Operation</seealso>
        AddStreamGroupLocationsResponse AddStreamGroupLocations(AddStreamGroupLocationsRequest request);



        /// <summary>
        /// Add locations that can host stream sessions. You configure locations and their corresponding
        /// capacity for each stream group. Creating a stream group in a location that's nearest
        /// to your end users can help minimize latency and improve quality. 
        /// 
        ///  
        /// <para>
        ///  This operation provisions stream capacity at the specified locations. By default,
        /// all locations have 1 or 2 capacity, depending on the stream class option: 2 for 'High'
        /// and 1 for 'Ultra' and 'Win2022'. This operation also copies the content files of all
        /// associated applications to an internal S3 bucket at each location. This allows Amazon
        /// GameLift Streams to host performant stream sessions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddStreamGroupLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddStreamGroupLocations service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ServiceQuotaExceededException">
        /// The request would cause the resource to exceed an allowed service quota. Resolve the
        /// issue before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/AddStreamGroupLocations">REST API Reference for AddStreamGroupLocations Operation</seealso>
        Task<AddStreamGroupLocationsResponse> AddStreamGroupLocationsAsync(AddStreamGroupLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateApplications


        /// <summary>
        /// When you associate, or link, an application with a stream group, then Amazon GameLift
        /// Streams can launch the application using the stream group's allocated compute resources.
        /// The stream group must be in <c>ACTIVE</c> status. You can reverse this action by using
        /// <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_DisassociateApplications.html">DisassociateApplications</a>.
        /// 
        ///  
        /// <para>
        /// If a stream group does not already have a linked application, Amazon GameLift Streams
        /// will automatically assign the first application provided in <c>ApplicationIdentifiers</c>
        /// as the default.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplications service method.</param>
        /// 
        /// <returns>The response from the AssociateApplications service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ServiceQuotaExceededException">
        /// The request would cause the resource to exceed an allowed service quota. Resolve the
        /// issue before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        AssociateApplicationsResponse AssociateApplications(AssociateApplicationsRequest request);



        /// <summary>
        /// When you associate, or link, an application with a stream group, then Amazon GameLift
        /// Streams can launch the application using the stream group's allocated compute resources.
        /// The stream group must be in <c>ACTIVE</c> status. You can reverse this action by using
        /// <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_DisassociateApplications.html">DisassociateApplications</a>.
        /// 
        ///  
        /// <para>
        /// If a stream group does not already have a linked application, Amazon GameLift Streams
        /// will automatically assign the first application provided in <c>ApplicationIdentifiers</c>
        /// as the default.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateApplications service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ServiceQuotaExceededException">
        /// The request would cause the resource to exceed an allowed service quota. Resolve the
        /// issue before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        Task<AssociateApplicationsResponse> AssociateApplicationsAsync(AssociateApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an application resource in Amazon GameLift Streams, which specifies the application
        /// content you want to stream, such as a game build or other software, and configures
        /// the settings to run it.
        /// 
        ///  
        /// <para>
        ///  Before you create an application, upload your application content files to an Amazon
        /// Simple Storage Service (Amazon S3) bucket. For more information, see <b>Getting Started</b>
        /// in the Amazon GameLift Streams Developer Guide. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  Make sure that your files in the Amazon S3 bucket are the correct version you want
        /// to use. If you change the files at a later time, you will need to create a new Amazon
        /// GameLift Streams application. 
        /// </para>
        ///  </important> 
        /// <para>
        ///  If the request is successful, Amazon GameLift Streams begins to create an application
        /// and sets the status to <c>INITIALIZED</c>. When an application reaches <c>READY</c>
        /// status, you can use the application to set up stream groups and start streams. To
        /// track application status, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetApplication.html">GetApplication</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ServiceQuotaExceededException">
        /// The request would cause the resource to exceed an allowed service quota. Resolve the
        /// issue before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);



        /// <summary>
        /// Creates an application resource in Amazon GameLift Streams, which specifies the application
        /// content you want to stream, such as a game build or other software, and configures
        /// the settings to run it.
        /// 
        ///  
        /// <para>
        ///  Before you create an application, upload your application content files to an Amazon
        /// Simple Storage Service (Amazon S3) bucket. For more information, see <b>Getting Started</b>
        /// in the Amazon GameLift Streams Developer Guide. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  Make sure that your files in the Amazon S3 bucket are the correct version you want
        /// to use. If you change the files at a later time, you will need to create a new Amazon
        /// GameLift Streams application. 
        /// </para>
        ///  </important> 
        /// <para>
        ///  If the request is successful, Amazon GameLift Streams begins to create an application
        /// and sets the status to <c>INITIALIZED</c>. When an application reaches <c>READY</c>
        /// status, you can use the application to set up stream groups and start streams. To
        /// track application status, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetApplication.html">GetApplication</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ServiceQuotaExceededException">
        /// The request would cause the resource to exceed an allowed service quota. Resolve the
        /// issue before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStreamGroup


        /// <summary>
        /// Manage how Amazon GameLift Streams streams your applications by using a stream group.
        /// A stream group is a collection of resources that Amazon GameLift Streams uses to stream
        /// your application to end-users. When you create a stream group, you specify an application
        /// to stream by default and the type of hardware to use, such as the graphical processing
        /// unit (GPU). You can also link additional applications, which allows you to stream
        /// those applications using this stream group. Depending on your expected users, you
        /// also scale the number of concurrent streams you want to support at one time, and in
        /// what locations. 
        /// 
        ///  
        /// <para>
        ///  Stream capacity represents the number of concurrent streams that can be active at
        /// a time. You set stream capacity per location, per stream group. There are two types
        /// of capacity, always-on and on-demand: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Always-on</b>: The streaming capacity that is allocated and ready to handle stream
        /// requests without delay. You pay for this capacity whether it's in use or not. Best
        /// for quickest time from streaming request to streaming session. Default is 1 when creating
        /// a stream group or adding a location. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>On-demand</b>: The streaming capacity that Amazon GameLift Streams can allocate
        /// in response to stream requests, and then de-allocate when the session has terminated.
        /// This offers a cost control measure at the expense of a greater startup time (typically
        /// under 5 minutes). Default is 0 when creating a stream group or adding a location.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  To adjust the capacity of any <c>ACTIVE</c> stream group, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_UpdateStreamGroup.html">UpdateStreamGroup</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If the request is successful, Amazon GameLift Streams begins creating the stream
        /// group. Amazon GameLift Streams assigns a unique ID to the stream group resource and
        /// sets the status to <c>ACTIVATING</c>. When the stream group reaches <c>ACTIVE</c>
        /// status, you can start stream sessions by using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_StartStreamSession.html">StartStreamSession</a>.
        /// To check the stream group's status, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamGroup.html">GetStreamGroup</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamGroup service method.</param>
        /// 
        /// <returns>The response from the CreateStreamGroup service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ServiceQuotaExceededException">
        /// The request would cause the resource to exceed an allowed service quota. Resolve the
        /// issue before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/CreateStreamGroup">REST API Reference for CreateStreamGroup Operation</seealso>
        CreateStreamGroupResponse CreateStreamGroup(CreateStreamGroupRequest request);



        /// <summary>
        /// Manage how Amazon GameLift Streams streams your applications by using a stream group.
        /// A stream group is a collection of resources that Amazon GameLift Streams uses to stream
        /// your application to end-users. When you create a stream group, you specify an application
        /// to stream by default and the type of hardware to use, such as the graphical processing
        /// unit (GPU). You can also link additional applications, which allows you to stream
        /// those applications using this stream group. Depending on your expected users, you
        /// also scale the number of concurrent streams you want to support at one time, and in
        /// what locations. 
        /// 
        ///  
        /// <para>
        ///  Stream capacity represents the number of concurrent streams that can be active at
        /// a time. You set stream capacity per location, per stream group. There are two types
        /// of capacity, always-on and on-demand: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Always-on</b>: The streaming capacity that is allocated and ready to handle stream
        /// requests without delay. You pay for this capacity whether it's in use or not. Best
        /// for quickest time from streaming request to streaming session. Default is 1 when creating
        /// a stream group or adding a location. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>On-demand</b>: The streaming capacity that Amazon GameLift Streams can allocate
        /// in response to stream requests, and then de-allocate when the session has terminated.
        /// This offers a cost control measure at the expense of a greater startup time (typically
        /// under 5 minutes). Default is 0 when creating a stream group or adding a location.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  To adjust the capacity of any <c>ACTIVE</c> stream group, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_UpdateStreamGroup.html">UpdateStreamGroup</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If the request is successful, Amazon GameLift Streams begins creating the stream
        /// group. Amazon GameLift Streams assigns a unique ID to the stream group resource and
        /// sets the status to <c>ACTIVATING</c>. When the stream group reaches <c>ACTIVE</c>
        /// status, you can start stream sessions by using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_StartStreamSession.html">StartStreamSession</a>.
        /// To check the stream group's status, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamGroup.html">GetStreamGroup</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStreamGroup service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ServiceQuotaExceededException">
        /// The request would cause the resource to exceed an allowed service quota. Resolve the
        /// issue before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/CreateStreamGroup">REST API Reference for CreateStreamGroup Operation</seealso>
        Task<CreateStreamGroupResponse> CreateStreamGroupAsync(CreateStreamGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStreamSessionConnection


        /// <summary>
        /// Enables clients to reconnect to a stream session while preserving all session state
        /// and data in the disconnected session. This reconnection process can be initiated when
        /// a stream session is in either <c>PENDING_CLIENT_RECONNECTION</c> or <c>ACTIVE</c>
        /// status. The process works as follows: 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Initial disconnect:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When a client disconnects or loses connection, the stream session transitions from
        /// <c>CONNECTED</c> to <c>PENDING_CLIENT_RECONNECTION</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Reconnection time window:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Clients have <c>ConnectionTimeoutSeconds</c> (defined in <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_StartStreamSession.html">StartStreamSession</a>)
        /// to reconnect before session termination
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your backend server must call <b>CreateStreamSessionConnection</b> to initiate reconnection
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Session transitions to <c>RECONNECTING</c> status
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Reconnection completion:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// On successful <b>CreateStreamSessionConnection</b>, session status changes to <c>ACTIVE</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the new connection information to the requesting client
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Client must establish connection within <c>ConnectionTimeoutSeconds</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Session terminates automatically if client fails to connect in time
        /// </para>
        ///  </li> </ul> </li> </ol> 
        /// <para>
        /// For more information about the stream session lifecycle, see <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/stream-sessions.html">Stream
        /// sessions</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To begin re-connecting to an existing stream session, specify the stream group ID
        /// and stream session ID that you want to reconnect to, and the signal request to use
        /// with the stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamSessionConnection service method.</param>
        /// 
        /// <returns>The response from the CreateStreamSessionConnection service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/CreateStreamSessionConnection">REST API Reference for CreateStreamSessionConnection Operation</seealso>
        CreateStreamSessionConnectionResponse CreateStreamSessionConnection(CreateStreamSessionConnectionRequest request);



        /// <summary>
        /// Enables clients to reconnect to a stream session while preserving all session state
        /// and data in the disconnected session. This reconnection process can be initiated when
        /// a stream session is in either <c>PENDING_CLIENT_RECONNECTION</c> or <c>ACTIVE</c>
        /// status. The process works as follows: 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Initial disconnect:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When a client disconnects or loses connection, the stream session transitions from
        /// <c>CONNECTED</c> to <c>PENDING_CLIENT_RECONNECTION</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Reconnection time window:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Clients have <c>ConnectionTimeoutSeconds</c> (defined in <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_StartStreamSession.html">StartStreamSession</a>)
        /// to reconnect before session termination
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your backend server must call <b>CreateStreamSessionConnection</b> to initiate reconnection
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Session transitions to <c>RECONNECTING</c> status
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Reconnection completion:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// On successful <b>CreateStreamSessionConnection</b>, session status changes to <c>ACTIVE</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the new connection information to the requesting client
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Client must establish connection within <c>ConnectionTimeoutSeconds</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Session terminates automatically if client fails to connect in time
        /// </para>
        ///  </li> </ul> </li> </ol> 
        /// <para>
        /// For more information about the stream session lifecycle, see <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/stream-sessions.html">Stream
        /// sessions</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To begin re-connecting to an existing stream session, specify the stream group ID
        /// and stream session ID that you want to reconnect to, and the signal request to use
        /// with the stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamSessionConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStreamSessionConnection service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/CreateStreamSessionConnection">REST API Reference for CreateStreamSessionConnection Operation</seealso>
        Task<CreateStreamSessionConnectionResponse> CreateStreamSessionConnectionAsync(CreateStreamSessionConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Permanently deletes an Amazon GameLift Streams application resource. This also deletes
        /// the application content files stored with Amazon GameLift Streams. However, this does
        /// not delete the original files that you uploaded to your Amazon S3 bucket; you can
        /// delete these any time after Amazon GameLift Streams creates an application, which
        /// is the only time Amazon GameLift Streams accesses your Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        ///  You can only delete an application that meets the following conditions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The application is in <c>READY</c> or <c>ERROR</c> status. You cannot delete an application
        /// that's in <c>PROCESSING</c> or <c>INITIALIZED</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The application is not the default application of any stream groups. You must first
        /// delete the stream group by using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_DeleteStreamGroup.html">DeleteStreamGroup</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The application is not linked to any stream groups. You must first unlink the stream
        /// group by using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_DisassociateApplications.html">DisassociateApplications</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  An application is not streaming in any ongoing stream session. You must wait until
        /// the client ends the stream session or call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_TerminateStreamSession.html">TerminateStreamSession</a>
        /// to end the stream. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If any active stream groups exist for this application, this request returns a <c>ValidationException</c>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);



        /// <summary>
        /// Permanently deletes an Amazon GameLift Streams application resource. This also deletes
        /// the application content files stored with Amazon GameLift Streams. However, this does
        /// not delete the original files that you uploaded to your Amazon S3 bucket; you can
        /// delete these any time after Amazon GameLift Streams creates an application, which
        /// is the only time Amazon GameLift Streams accesses your Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        ///  You can only delete an application that meets the following conditions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The application is in <c>READY</c> or <c>ERROR</c> status. You cannot delete an application
        /// that's in <c>PROCESSING</c> or <c>INITIALIZED</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The application is not the default application of any stream groups. You must first
        /// delete the stream group by using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_DeleteStreamGroup.html">DeleteStreamGroup</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The application is not linked to any stream groups. You must first unlink the stream
        /// group by using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_DisassociateApplications.html">DisassociateApplications</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  An application is not streaming in any ongoing stream session. You must wait until
        /// the client ends the stream session or call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_TerminateStreamSession.html">TerminateStreamSession</a>
        /// to end the stream. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If any active stream groups exist for this application, this request returns a <c>ValidationException</c>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStreamGroup


        /// <summary>
        /// Permanently deletes all compute resources and information related to a stream group.
        /// To delete a stream group, specify the unique stream group identifier. During the deletion
        /// process, the stream group's status is <c>DELETING</c>. This operation stops streams
        /// in progress and prevents new streams from starting. As a best practice, before deleting
        /// the stream group, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_ListStreamSessions.html">ListStreamSessions</a>
        /// to check for streams in progress and take action to stop them. When you delete a stream
        /// group, any application associations referring to that stream group are automatically
        /// removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteStreamGroup service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/DeleteStreamGroup">REST API Reference for DeleteStreamGroup Operation</seealso>
        DeleteStreamGroupResponse DeleteStreamGroup(DeleteStreamGroupRequest request);



        /// <summary>
        /// Permanently deletes all compute resources and information related to a stream group.
        /// To delete a stream group, specify the unique stream group identifier. During the deletion
        /// process, the stream group's status is <c>DELETING</c>. This operation stops streams
        /// in progress and prevents new streams from starting. As a best practice, before deleting
        /// the stream group, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_ListStreamSessions.html">ListStreamSessions</a>
        /// to check for streams in progress and take action to stop them. When you delete a stream
        /// group, any application associations referring to that stream group are automatically
        /// removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStreamGroup service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/DeleteStreamGroup">REST API Reference for DeleteStreamGroup Operation</seealso>
        Task<DeleteStreamGroupResponse> DeleteStreamGroupAsync(DeleteStreamGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateApplications


        /// <summary>
        /// When you disassociate, or unlink, an application from a stream group, you can no
        /// longer stream this application by using that stream group's allocated compute resources.
        /// Any streams in process will continue until they terminate, which helps avoid interrupting
        /// an end-user's stream. Amazon GameLift Streams will not initiate new streams in the
        /// stream group using the disassociated application. The disassociate action does not
        /// affect the stream capacity of a stream group. 
        /// 
        ///  
        /// <para>
        ///  If you disassociate the default application, Amazon GameLift Streams will automatically
        /// choose a new default application from the remaining associated applications. To change
        /// which application is the default application, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_UpdateStreamGroup.html">UpdateStreamGroup</a>
        /// and specify a new <c>DefaultApplicationIdentifier</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplications service method.</param>
        /// 
        /// <returns>The response from the DisassociateApplications service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        DisassociateApplicationsResponse DisassociateApplications(DisassociateApplicationsRequest request);



        /// <summary>
        /// When you disassociate, or unlink, an application from a stream group, you can no
        /// longer stream this application by using that stream group's allocated compute resources.
        /// Any streams in process will continue until they terminate, which helps avoid interrupting
        /// an end-user's stream. Amazon GameLift Streams will not initiate new streams in the
        /// stream group using the disassociated application. The disassociate action does not
        /// affect the stream capacity of a stream group. 
        /// 
        ///  
        /// <para>
        ///  If you disassociate the default application, Amazon GameLift Streams will automatically
        /// choose a new default application from the remaining associated applications. To change
        /// which application is the default application, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_UpdateStreamGroup.html">UpdateStreamGroup</a>
        /// and specify a new <c>DefaultApplicationIdentifier</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateApplications service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        Task<DisassociateApplicationsResponse> DisassociateApplicationsAsync(DisassociateApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportStreamSessionFiles


        /// <summary>
        /// Export the files that your application modifies or generates in a stream session,
        /// which can help you debug or verify your application. When your application runs, it
        /// generates output files such as logs, diagnostic information, crash dumps, save files,
        /// user data, screenshots, and so on. The files can be defined by the engine or frameworks
        /// that your application uses, or information that you've programmed your application
        /// to output. 
        /// 
        ///  
        /// <para>
        ///  You can only call this action on a stream session that is in progress, specifically
        /// in one of the following statuses <c>ACTIVE</c>, <c>CONNECTED</c>, <c>PENDING_CLIENT_RECONNECTION</c>,
        /// and <c>RECONNECTING</c>. You must provide an Amazon Simple Storage Service (Amazon
        /// S3) bucket to store the files in. When the session ends, Amazon GameLift Streams produces
        /// a compressed folder that contains all of the files and directories that were modified
        /// or created by the application during the stream session. AWS uses your security credentials
        /// to authenticate and authorize access to your Amazon S3 bucket. 
        /// </para>
        ///  
        /// <para>
        /// Amazon GameLift Streams collects the following generated and modified files. Find
        /// them in the corresponding folders in the <c>.zip</c> archive.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application/</c>: The folder where your application or game is stored. 
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>profile/</c>: The user profile folder.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>temp/</c>: The system temp folder.
        /// </para>
        ///  </li> </ul>  
        /// <para>
        /// To verify the status of the exported files, use GetStreamSession. 
        /// </para>
        ///  
        /// <para>
        /// To delete the files, delete the object in the S3 bucket. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportStreamSessionFiles service method.</param>
        /// 
        /// <returns>The response from the ExportStreamSessionFiles service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ExportStreamSessionFiles">REST API Reference for ExportStreamSessionFiles Operation</seealso>
        ExportStreamSessionFilesResponse ExportStreamSessionFiles(ExportStreamSessionFilesRequest request);



        /// <summary>
        /// Export the files that your application modifies or generates in a stream session,
        /// which can help you debug or verify your application. When your application runs, it
        /// generates output files such as logs, diagnostic information, crash dumps, save files,
        /// user data, screenshots, and so on. The files can be defined by the engine or frameworks
        /// that your application uses, or information that you've programmed your application
        /// to output. 
        /// 
        ///  
        /// <para>
        ///  You can only call this action on a stream session that is in progress, specifically
        /// in one of the following statuses <c>ACTIVE</c>, <c>CONNECTED</c>, <c>PENDING_CLIENT_RECONNECTION</c>,
        /// and <c>RECONNECTING</c>. You must provide an Amazon Simple Storage Service (Amazon
        /// S3) bucket to store the files in. When the session ends, Amazon GameLift Streams produces
        /// a compressed folder that contains all of the files and directories that were modified
        /// or created by the application during the stream session. AWS uses your security credentials
        /// to authenticate and authorize access to your Amazon S3 bucket. 
        /// </para>
        ///  
        /// <para>
        /// Amazon GameLift Streams collects the following generated and modified files. Find
        /// them in the corresponding folders in the <c>.zip</c> archive.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application/</c>: The folder where your application or game is stored. 
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>profile/</c>: The user profile folder.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>temp/</c>: The system temp folder.
        /// </para>
        ///  </li> </ul>  
        /// <para>
        /// To verify the status of the exported files, use GetStreamSession. 
        /// </para>
        ///  
        /// <para>
        /// To delete the files, delete the object in the S3 bucket. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportStreamSessionFiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportStreamSessionFiles service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ExportStreamSessionFiles">REST API Reference for ExportStreamSessionFiles Operation</seealso>
        Task<ExportStreamSessionFilesResponse> ExportStreamSessionFilesAsync(ExportStreamSessionFilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApplication


        /// <summary>
        /// Retrieves properties for an Amazon GameLift Streams application resource. Specify
        /// the ID of the application that you want to retrieve. If the operation is successful,
        /// it returns properties for the requested application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse GetApplication(GetApplicationRequest request);



        /// <summary>
        /// Retrieves properties for an Amazon GameLift Streams application resource. Specify
        /// the ID of the application that you want to retrieve. If the operation is successful,
        /// it returns properties for the requested application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStreamGroup


        /// <summary>
        /// Retrieves properties for a Amazon GameLift Streams stream group resource. Specify
        /// the ID of the stream group that you want to retrieve. If the operation is successful,
        /// it returns properties for the requested stream group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamGroup service method.</param>
        /// 
        /// <returns>The response from the GetStreamGroup service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/GetStreamGroup">REST API Reference for GetStreamGroup Operation</seealso>
        GetStreamGroupResponse GetStreamGroup(GetStreamGroupRequest request);



        /// <summary>
        /// Retrieves properties for a Amazon GameLift Streams stream group resource. Specify
        /// the ID of the stream group that you want to retrieve. If the operation is successful,
        /// it returns properties for the requested stream group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamGroup service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/GetStreamGroup">REST API Reference for GetStreamGroup Operation</seealso>
        Task<GetStreamGroupResponse> GetStreamGroupAsync(GetStreamGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStreamSession


        /// <summary>
        /// Retrieves properties for a Amazon GameLift Streams stream session resource. Specify
        /// the Amazon Resource Name (ARN) of the stream session that you want to retrieve and
        /// its stream group ARN. If the operation is successful, it returns properties for the
        /// requested resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamSession service method.</param>
        /// 
        /// <returns>The response from the GetStreamSession service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/GetStreamSession">REST API Reference for GetStreamSession Operation</seealso>
        GetStreamSessionResponse GetStreamSession(GetStreamSessionRequest request);



        /// <summary>
        /// Retrieves properties for a Amazon GameLift Streams stream session resource. Specify
        /// the Amazon Resource Name (ARN) of the stream session that you want to retrieve and
        /// its stream group ARN. If the operation is successful, it returns properties for the
        /// requested resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamSession service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/GetStreamSession">REST API Reference for GetStreamSession Operation</seealso>
        Task<GetStreamSessionResponse> GetStreamSessionAsync(GetStreamSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Retrieves a list of all Amazon GameLift Streams applications that are associated with
        /// the Amazon Web Services account in use. This operation returns applications in all
        /// statuses, in no particular order. You can paginate the results as needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);



        /// <summary>
        /// Retrieves a list of all Amazon GameLift Streams applications that are associated with
        /// the Amazon Web Services account in use. This operation returns applications in all
        /// statuses, in no particular order. You can paginate the results as needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStreamGroups


        /// <summary>
        /// Retrieves a list of all Amazon GameLift Streams stream groups that are associated
        /// with the Amazon Web Services account in use. This operation returns stream groups
        /// in all statuses, in no particular order. You can paginate the results as needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamGroups service method.</param>
        /// 
        /// <returns>The response from the ListStreamGroups service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ListStreamGroups">REST API Reference for ListStreamGroups Operation</seealso>
        ListStreamGroupsResponse ListStreamGroups(ListStreamGroupsRequest request);



        /// <summary>
        /// Retrieves a list of all Amazon GameLift Streams stream groups that are associated
        /// with the Amazon Web Services account in use. This operation returns stream groups
        /// in all statuses, in no particular order. You can paginate the results as needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamGroups service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ListStreamGroups">REST API Reference for ListStreamGroups Operation</seealso>
        Task<ListStreamGroupsResponse> ListStreamGroupsAsync(ListStreamGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStreamSessions


        /// <summary>
        /// Retrieves a list of Amazon GameLift Streams stream sessions that a stream group is
        /// hosting.
        /// 
        ///  
        /// <para>
        /// To retrieve stream sessions, specify the stream group, and optionally filter by stream
        /// session status. You can paginate the results as needed.
        /// </para>
        ///  
        /// <para>
        /// This operation returns the requested stream sessions in no particular order.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamSessions service method.</param>
        /// 
        /// <returns>The response from the ListStreamSessions service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ListStreamSessions">REST API Reference for ListStreamSessions Operation</seealso>
        ListStreamSessionsResponse ListStreamSessions(ListStreamSessionsRequest request);



        /// <summary>
        /// Retrieves a list of Amazon GameLift Streams stream sessions that a stream group is
        /// hosting.
        /// 
        ///  
        /// <para>
        /// To retrieve stream sessions, specify the stream group, and optionally filter by stream
        /// session status. You can paginate the results as needed.
        /// </para>
        ///  
        /// <para>
        /// This operation returns the requested stream sessions in no particular order.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamSessions service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ListStreamSessions">REST API Reference for ListStreamSessions Operation</seealso>
        Task<ListStreamSessionsResponse> ListStreamSessionsAsync(ListStreamSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStreamSessionsByAccount


        /// <summary>
        /// Retrieves a list of Amazon GameLift Streams stream sessions that this user account
        /// has access to.
        /// 
        ///  
        /// <para>
        /// In the returned list of stream sessions, the <c>ExportFilesMetadata</c> property only
        /// shows the <c>Status</c> value. To get the <c>OutpurUri</c> and <c>StatusReason</c>
        /// values, use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamSession.html">GetStreamSession</a>.
        /// </para>
        ///  
        /// <para>
        /// We don't recommend using this operation to regularly check stream session statuses
        /// because it's costly. Instead, to check status updates for a specific stream session,
        /// use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamSession.html">GetStreamSession</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamSessionsByAccount service method.</param>
        /// 
        /// <returns>The response from the ListStreamSessionsByAccount service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ListStreamSessionsByAccount">REST API Reference for ListStreamSessionsByAccount Operation</seealso>
        ListStreamSessionsByAccountResponse ListStreamSessionsByAccount(ListStreamSessionsByAccountRequest request);



        /// <summary>
        /// Retrieves a list of Amazon GameLift Streams stream sessions that this user account
        /// has access to.
        /// 
        ///  
        /// <para>
        /// In the returned list of stream sessions, the <c>ExportFilesMetadata</c> property only
        /// shows the <c>Status</c> value. To get the <c>OutpurUri</c> and <c>StatusReason</c>
        /// values, use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamSession.html">GetStreamSession</a>.
        /// </para>
        ///  
        /// <para>
        /// We don't recommend using this operation to regularly check stream session statuses
        /// because it's costly. Instead, to check status updates for a specific stream session,
        /// use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamSession.html">GetStreamSession</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamSessionsByAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamSessionsByAccount service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ListStreamSessionsByAccount">REST API Reference for ListStreamSessionsByAccount Operation</seealso>
        Task<ListStreamSessionsByAccountResponse> ListStreamSessionsByAccountAsync(ListStreamSessionsByAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves all tags assigned to a Amazon GameLift Streams resource. To list tags for
        /// a resource, specify the ARN value for the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// Amazon Web Services Tagging Strategies</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Retrieves all tags assigned to a Amazon GameLift Streams resource. To list tags for
        /// a resource, specify the ARN value for the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// Amazon Web Services Tagging Strategies</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveStreamGroupLocations


        /// <summary>
        /// Removes a set of remote locations from this stream group. Amazon GameLift Streams
        /// works to release allocated compute resources in these location. Thus, stream sessions
        /// can no longer start from these locations by using this stream group. Amazon GameLift
        /// Streams also deletes the content files of all associated applications that were in
        /// Amazon GameLift Streams's internal S3 bucket at this location. 
        /// 
        ///  
        /// <para>
        ///  You cannot remove the region where you initially created this stream group, known
        /// as the primary location. However, you can set the stream capacity to zero. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveStreamGroupLocations service method.</param>
        /// 
        /// <returns>The response from the RemoveStreamGroupLocations service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/RemoveStreamGroupLocations">REST API Reference for RemoveStreamGroupLocations Operation</seealso>
        RemoveStreamGroupLocationsResponse RemoveStreamGroupLocations(RemoveStreamGroupLocationsRequest request);



        /// <summary>
        /// Removes a set of remote locations from this stream group. Amazon GameLift Streams
        /// works to release allocated compute resources in these location. Thus, stream sessions
        /// can no longer start from these locations by using this stream group. Amazon GameLift
        /// Streams also deletes the content files of all associated applications that were in
        /// Amazon GameLift Streams's internal S3 bucket at this location. 
        /// 
        ///  
        /// <para>
        ///  You cannot remove the region where you initially created this stream group, known
        /// as the primary location. However, you can set the stream capacity to zero. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveStreamGroupLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveStreamGroupLocations service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/RemoveStreamGroupLocations">REST API Reference for RemoveStreamGroupLocations Operation</seealso>
        Task<RemoveStreamGroupLocationsResponse> RemoveStreamGroupLocationsAsync(RemoveStreamGroupLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartStreamSession


        /// <summary>
        /// This action initiates a new stream session and outputs connection information that
        /// clients can use to access the stream. A stream session refers to an instance of a
        /// stream that Amazon GameLift Streams transmits from the server to the end-user. A stream
        /// session runs on a compute resource that a stream group has allocated. The start stream
        /// session process works as follows: 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must have a stream group in <c>ACTIVE</c> state
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have idle or on-demand capacity in a stream group in the location you want
        /// to stream from
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have at least one application associated to the stream group (use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_AssociateApplications.html">AssociateApplications</a>
        /// if needed)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Start stream request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your backend server calls <b>StartStreamSession</b> to initiate connection
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon GameLift Streams creates the stream session resource, assigns an Amazon Resource
        /// Name (ARN) value, and begins searching for available stream capacity to run the stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Session transitions to <c>ACTIVATING</c> status
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Placement completion:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If Amazon GameLift Streams is successful in finding capacity for the stream, the stream
        /// session status changes to <c>ACTIVE</c> status and <b>StartStreamSession</b> returns
        /// stream connection information
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If Amazon GameLift Streams was not successful in finding capacity within the placement
        /// timeout period (defined according to the capacity type and platform type), the stream
        /// session status changes to <c>ERROR</c> status and <b>StartStreamSession</b> returns
        /// a <c>StatusReason</c> of <c>placementTimeout</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Connection completion:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Provide the new connection information to the requesting client
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Client must establish connection within <c>ConnectionTimeoutSeconds</c> (specified
        /// in <b>StartStreamSession</b> parameters)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Session terminates automatically if client fails to connect in time
        /// </para>
        ///  </li> </ul> </li> </ol> 
        /// <para>
        /// For more information about the stream session lifecycle, see <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/stream-sessions.html">Stream
        /// sessions</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Timeouts to be aware of that affect a stream session:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Placement timeout</b>: The amount of time that Amazon GameLift Streams has to
        /// find capacity for a stream request. Placement timeout varies based on the capacity
        /// type used to fulfill your stream request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Always-on capacity</b>: 75 seconds
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>On-demand capacity</b>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux/Proton runtimes: 90 seconds
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows runtime: 10 minutes
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Connection timeout</b>: The amount of time that Amazon GameLift Streams waits
        /// for a client to connect to a stream session in <c>ACTIVE</c> status, or reconnect
        /// to a stream session in <c>PENDING_CLIENT_RECONNECTION</c> status, the latter of which
        /// occurs when a client disconnects or loses connection from a stream session. If no
        /// client connects before the timeout, Amazon GameLift Streams terminates the stream
        /// session. This value is specified by <c>ConnectionTimeoutSeconds</c> in the <c>StartStreamSession</c>
        /// parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Idle timeout</b>: A stream session will be terminated if no user input has been
        /// received for 60 minutes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Maximum session length</b>: A stream session will be terminated after this amount
        /// of time has elapsed since it started, regardless of any existing client connections.
        /// This value is specified by <c>SessionLengthSeconds</c> in the <c>StartStreamSession</c>
        /// parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To start a new stream session, specify a stream group ID and application ID, along
        /// with the transport protocol and signal request to use with the stream session.
        /// </para>
        ///  
        /// <para>
        /// For stream groups that have multiple locations, provide a set of locations ordered
        /// by priority using a <c>Locations</c> parameter. Amazon GameLift Streams will start
        /// a single stream session in the next available location. An application must be finished
        /// replicating to a remote location before the remote location can host a stream.
        /// </para>
        ///  
        /// <para>
        /// To reconnect to a stream session after a client disconnects or loses connection, use
        /// <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_CreateStreamSessionConnection.html">CreateStreamSessionConnection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamSession service method.</param>
        /// 
        /// <returns>The response from the StartStreamSession service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/StartStreamSession">REST API Reference for StartStreamSession Operation</seealso>
        StartStreamSessionResponse StartStreamSession(StartStreamSessionRequest request);



        /// <summary>
        /// This action initiates a new stream session and outputs connection information that
        /// clients can use to access the stream. A stream session refers to an instance of a
        /// stream that Amazon GameLift Streams transmits from the server to the end-user. A stream
        /// session runs on a compute resource that a stream group has allocated. The start stream
        /// session process works as follows: 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must have a stream group in <c>ACTIVE</c> state
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have idle or on-demand capacity in a stream group in the location you want
        /// to stream from
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have at least one application associated to the stream group (use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_AssociateApplications.html">AssociateApplications</a>
        /// if needed)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Start stream request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your backend server calls <b>StartStreamSession</b> to initiate connection
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon GameLift Streams creates the stream session resource, assigns an Amazon Resource
        /// Name (ARN) value, and begins searching for available stream capacity to run the stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Session transitions to <c>ACTIVATING</c> status
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Placement completion:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If Amazon GameLift Streams is successful in finding capacity for the stream, the stream
        /// session status changes to <c>ACTIVE</c> status and <b>StartStreamSession</b> returns
        /// stream connection information
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If Amazon GameLift Streams was not successful in finding capacity within the placement
        /// timeout period (defined according to the capacity type and platform type), the stream
        /// session status changes to <c>ERROR</c> status and <b>StartStreamSession</b> returns
        /// a <c>StatusReason</c> of <c>placementTimeout</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Connection completion:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Provide the new connection information to the requesting client
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Client must establish connection within <c>ConnectionTimeoutSeconds</c> (specified
        /// in <b>StartStreamSession</b> parameters)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Session terminates automatically if client fails to connect in time
        /// </para>
        ///  </li> </ul> </li> </ol> 
        /// <para>
        /// For more information about the stream session lifecycle, see <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/stream-sessions.html">Stream
        /// sessions</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Timeouts to be aware of that affect a stream session:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Placement timeout</b>: The amount of time that Amazon GameLift Streams has to
        /// find capacity for a stream request. Placement timeout varies based on the capacity
        /// type used to fulfill your stream request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Always-on capacity</b>: 75 seconds
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>On-demand capacity</b>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux/Proton runtimes: 90 seconds
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows runtime: 10 minutes
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Connection timeout</b>: The amount of time that Amazon GameLift Streams waits
        /// for a client to connect to a stream session in <c>ACTIVE</c> status, or reconnect
        /// to a stream session in <c>PENDING_CLIENT_RECONNECTION</c> status, the latter of which
        /// occurs when a client disconnects or loses connection from a stream session. If no
        /// client connects before the timeout, Amazon GameLift Streams terminates the stream
        /// session. This value is specified by <c>ConnectionTimeoutSeconds</c> in the <c>StartStreamSession</c>
        /// parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Idle timeout</b>: A stream session will be terminated if no user input has been
        /// received for 60 minutes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Maximum session length</b>: A stream session will be terminated after this amount
        /// of time has elapsed since it started, regardless of any existing client connections.
        /// This value is specified by <c>SessionLengthSeconds</c> in the <c>StartStreamSession</c>
        /// parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To start a new stream session, specify a stream group ID and application ID, along
        /// with the transport protocol and signal request to use with the stream session.
        /// </para>
        ///  
        /// <para>
        /// For stream groups that have multiple locations, provide a set of locations ordered
        /// by priority using a <c>Locations</c> parameter. Amazon GameLift Streams will start
        /// a single stream session in the next available location. An application must be finished
        /// replicating to a remote location before the remote location can host a stream.
        /// </para>
        ///  
        /// <para>
        /// To reconnect to a stream session after a client disconnects or loses connection, use
        /// <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_CreateStreamSessionConnection.html">CreateStreamSessionConnection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartStreamSession service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/StartStreamSession">REST API Reference for StartStreamSession Operation</seealso>
        Task<StartStreamSessionResponse> StartStreamSessionAsync(StartStreamSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags to a Amazon GameLift Streams resource. Use tags to organize
        /// Amazon Web Services resources for a range of purposes. You can assign tags to the
        /// following Amazon GameLift Streams resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Application
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// StreamGroup
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// Amazon Web Services Tagging Strategies</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns one or more tags to a Amazon GameLift Streams resource. Use tags to organize
        /// Amazon Web Services resources for a range of purposes. You can assign tags to the
        /// following Amazon GameLift Streams resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Application
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// StreamGroup
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// Amazon Web Services Tagging Strategies</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TerminateStreamSession


        /// <summary>
        /// Permanently terminates an active stream session. When called, the stream session status
        /// changes to <c>TERMINATING</c>. You can terminate a stream session in any status except
        /// <c>ACTIVATING</c>. If the stream session is in <c>ACTIVATING</c> status, an exception
        /// is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateStreamSession service method.</param>
        /// 
        /// <returns>The response from the TerminateStreamSession service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/TerminateStreamSession">REST API Reference for TerminateStreamSession Operation</seealso>
        TerminateStreamSessionResponse TerminateStreamSession(TerminateStreamSessionRequest request);



        /// <summary>
        /// Permanently terminates an active stream session. When called, the stream session status
        /// changes to <c>TERMINATING</c>. You can terminate a stream session in any status except
        /// <c>ACTIVATING</c>. If the stream session is in <c>ACTIVATING</c> status, an exception
        /// is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateStreamSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateStreamSession service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/TerminateStreamSession">REST API Reference for TerminateStreamSession Operation</seealso>
        Task<TerminateStreamSessionResponse> TerminateStreamSessionAsync(TerminateStreamSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a Amazon GameLift Streams resource. To remove tags,
        /// specify the Amazon GameLift Streams resource and a list of one or more tags to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from a Amazon GameLift Streams resource. To remove tags,
        /// specify the Amazon GameLift Streams resource and a list of one or more tags to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates the mutable configuration settings for a Amazon GameLift Streams application
        /// resource. You can change the <c>Description</c>, <c>ApplicationLogOutputUri</c>, and
        /// <c>ApplicationLogPaths</c>. 
        /// 
        ///  
        /// <para>
        /// To update application settings, specify the application ID and provide the new values.
        /// If the operation is successful, it returns the complete updated set of settings for
        /// the application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);



        /// <summary>
        /// Updates the mutable configuration settings for a Amazon GameLift Streams application
        /// resource. You can change the <c>Description</c>, <c>ApplicationLogOutputUri</c>, and
        /// <c>ApplicationLogPaths</c>. 
        /// 
        ///  
        /// <para>
        /// To update application settings, specify the application ID and provide the new values.
        /// If the operation is successful, it returns the complete updated set of settings for
        /// the application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStreamGroup


        /// <summary>
        /// Updates the configuration settings for an Amazon GameLift Streams stream group resource.
        /// You can change the description, the set of locations, and the requested capacity of
        /// a stream group per location. If you want to change the stream class, create a new
        /// stream group. 
        /// 
        ///  
        /// <para>
        ///  Stream capacity represents the number of concurrent streams that can be active at
        /// a time. You set stream capacity per location, per stream group. There are two types
        /// of capacity, always-on and on-demand: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Always-on</b>: The streaming capacity that is allocated and ready to handle stream
        /// requests without delay. You pay for this capacity whether it's in use or not. Best
        /// for quickest time from streaming request to streaming session. Default is 1 when creating
        /// a stream group or adding a location. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>On-demand</b>: The streaming capacity that Amazon GameLift Streams can allocate
        /// in response to stream requests, and then de-allocate when the session has terminated.
        /// This offers a cost control measure at the expense of a greater startup time (typically
        /// under 5 minutes). Default is 0 when creating a stream group or adding a location.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To update a stream group, specify the stream group's Amazon Resource Name (ARN) and
        /// provide the new values. If the request is successful, Amazon GameLift Streams returns
        /// the complete updated metadata for the stream group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateStreamGroup service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ServiceQuotaExceededException">
        /// The request would cause the resource to exceed an allowed service quota. Resolve the
        /// issue before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/UpdateStreamGroup">REST API Reference for UpdateStreamGroup Operation</seealso>
        UpdateStreamGroupResponse UpdateStreamGroup(UpdateStreamGroupRequest request);



        /// <summary>
        /// Updates the configuration settings for an Amazon GameLift Streams stream group resource.
        /// You can change the description, the set of locations, and the requested capacity of
        /// a stream group per location. If you want to change the stream class, create a new
        /// stream group. 
        /// 
        ///  
        /// <para>
        ///  Stream capacity represents the number of concurrent streams that can be active at
        /// a time. You set stream capacity per location, per stream group. There are two types
        /// of capacity, always-on and on-demand: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Always-on</b>: The streaming capacity that is allocated and ready to handle stream
        /// requests without delay. You pay for this capacity whether it's in use or not. Best
        /// for quickest time from streaming request to streaming session. Default is 1 when creating
        /// a stream group or adding a location. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>On-demand</b>: The streaming capacity that Amazon GameLift Streams can allocate
        /// in response to stream requests, and then de-allocate when the session has terminated.
        /// This offers a cost control measure at the expense of a greater startup time (typically
        /// under 5 minutes). Default is 0 when creating a stream group or adding a location.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To update a stream group, specify the stream group's Amazon Resource Name (ARN) and
        /// provide the new values. If the request is successful, Amazon GameLift Streams returns
        /// the complete updated metadata for the stream group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStreamGroup service method, as returned by GameLiftStreams.</returns>
        /// <exception cref="Amazon.GameLiftStreams.Model.AccessDeniedException">
        /// You don't have the required permissions to access this Amazon GameLift Streams resource.
        /// Correct the permissions before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.InternalServerException">
        /// The service encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found. Correct the request before you
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ServiceQuotaExceededException">
        /// The request would cause the resource to exceed an allowed service quota. Resolve the
        /// issue before you try again.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request after the suggested
        /// wait time.
        /// </exception>
        /// <exception cref="Amazon.GameLiftStreams.Model.ValidationException">
        /// One or more parameter values in the request fail to satisfy the specified constraints.
        /// Correct the invalid parameter values before retrying the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gameliftstreams-2018-05-10/UpdateStreamGroup">REST API Reference for UpdateStreamGroup Operation</seealso>
        Task<UpdateStreamGroupResponse> UpdateStreamGroupAsync(UpdateStreamGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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