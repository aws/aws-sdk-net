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
 * Do not modify this file. This file is generated from the workspaces-thin-client-2023-08-22.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkSpacesThinClient.Model;

#pragma warning disable CS1570
namespace Amazon.WorkSpacesThinClient
{
    /// <summary>
    /// <para>Interface for accessing WorkSpacesThinClient</para>
    ///
    /// Amazon WorkSpaces Thin Client is an affordable device built to work with Amazon Web
    /// Services End User Computing (EUC) virtual desktops to provide users with a complete
    /// cloud desktop solution. WorkSpaces Thin Client is a compact device designed to connect
    /// up to two monitors and USB devices like a keyboard, mouse, headset, and webcam. To
    /// maximize endpoint security, WorkSpaces Thin Client devices do not allow local data
    /// storage or installation of unapproved applications. The WorkSpaces Thin Client device
    /// ships preloaded with device management software.
    /// 
    ///  
    /// <para>
    /// You can use these APIs to complete WorkSpaces Thin Client tasks, such as creating
    /// environments or viewing devices. For more information about WorkSpaces Thin Client,
    /// including the required permissions to use the service, see the <a href="https://docs.aws.amazon.com/workspaces-thin-client/latest/ag/">Amazon
    /// WorkSpaces Thin Client Administrator Guide</a>. For more information about using the
    /// Command Line Interface (CLI) to manage your WorkSpaces Thin Client resources, see
    /// the <a href="https://docs.aws.amazon.com/cli/latest/reference/workspaces-thin-client/index.html">WorkSpaces
    /// Thin Client section of the CLI Reference</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonWorkSpacesThinClient : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWorkSpacesThinClientPaginatorFactory Paginators { get; }

        
        #region  CreateEnvironment


        /// <summary>
        /// Creates an environment for your thin client devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request);



        /// <summary>
        /// Creates an environment for your thin client devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDevice


        /// <summary>
        /// Deletes a thin client device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
        /// 
        /// <returns>The response from the DeleteDevice service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request);



        /// <summary>
        /// Deletes a thin client device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDevice service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEnvironment


        /// <summary>
        /// Deletes an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request);



        /// <summary>
        /// Deletes an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterDevice


        /// <summary>
        /// Deregisters a thin client device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDevice service method.</param>
        /// 
        /// <returns>The response from the DeregisterDevice service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/DeregisterDevice">REST API Reference for DeregisterDevice Operation</seealso>
        DeregisterDeviceResponse DeregisterDevice(DeregisterDeviceRequest request);



        /// <summary>
        /// Deregisters a thin client device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterDevice service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/DeregisterDevice">REST API Reference for DeregisterDevice Operation</seealso>
        Task<DeregisterDeviceResponse> DeregisterDeviceAsync(DeregisterDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDevice


        /// <summary>
        /// Returns information for a thin client device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/GetDevice">REST API Reference for GetDevice Operation</seealso>
        GetDeviceResponse GetDevice(GetDeviceRequest request);



        /// <summary>
        /// Returns information for a thin client device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/GetDevice">REST API Reference for GetDevice Operation</seealso>
        Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEnvironment


        /// <summary>
        /// Returns information for an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request);



        /// <summary>
        /// Returns information for an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSoftwareSet


        /// <summary>
        /// Returns information for a software set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSoftwareSet service method.</param>
        /// 
        /// <returns>The response from the GetSoftwareSet service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/GetSoftwareSet">REST API Reference for GetSoftwareSet Operation</seealso>
        GetSoftwareSetResponse GetSoftwareSet(GetSoftwareSetRequest request);



        /// <summary>
        /// Returns information for a software set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSoftwareSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSoftwareSet service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/GetSoftwareSet">REST API Reference for GetSoftwareSet Operation</seealso>
        Task<GetSoftwareSetResponse> GetSoftwareSetAsync(GetSoftwareSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDevices


        /// <summary>
        /// Returns a list of thin client devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse ListDevices(ListDevicesRequest request);



        /// <summary>
        /// Returns a list of thin client devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/ListDevices">REST API Reference for ListDevices Operation</seealso>
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEnvironments


        /// <summary>
        /// Returns a list of environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request);



        /// <summary>
        /// Returns a list of environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSoftwareSets


        /// <summary>
        /// Returns a list of software sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSoftwareSets service method.</param>
        /// 
        /// <returns>The response from the ListSoftwareSets service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/ListSoftwareSets">REST API Reference for ListSoftwareSets Operation</seealso>
        ListSoftwareSetsResponse ListSoftwareSets(ListSoftwareSetsRequest request);



        /// <summary>
        /// Returns a list of software sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSoftwareSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSoftwareSets service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/ListSoftwareSets">REST API Reference for ListSoftwareSets Operation</seealso>
        Task<ListSoftwareSetsResponse> ListSoftwareSetsAsync(ListSoftwareSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDevice


        /// <summary>
        /// Updates a thin client device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice service method.</param>
        /// 
        /// <returns>The response from the UpdateDevice service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest request);



        /// <summary>
        /// Updates a thin client device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDevice service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        Task<UpdateDeviceResponse> UpdateDeviceAsync(UpdateDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEnvironment


        /// <summary>
        /// Updates an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request);



        /// <summary>
        /// Updates an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSoftwareSet


        /// <summary>
        /// Updates a software set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSoftwareSet service method.</param>
        /// 
        /// <returns>The response from the UpdateSoftwareSet service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/UpdateSoftwareSet">REST API Reference for UpdateSoftwareSet Operation</seealso>
        UpdateSoftwareSetResponse UpdateSoftwareSet(UpdateSoftwareSetRequest request);



        /// <summary>
        /// Updates a software set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSoftwareSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSoftwareSet service method, as returned by WorkSpacesThinClient.</returns>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesThinClient.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-thin-client-2023-08-22/UpdateSoftwareSet">REST API Reference for UpdateSoftwareSet Operation</seealso>
        Task<UpdateSoftwareSetResponse> UpdateSoftwareSetAsync(UpdateSoftwareSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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