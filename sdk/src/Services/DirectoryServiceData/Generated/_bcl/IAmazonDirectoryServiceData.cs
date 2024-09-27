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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DirectoryServiceData.Model;

#pragma warning disable CS1570
namespace Amazon.DirectoryServiceData
{
    /// <summary>
    /// <para>Interface for accessing DirectoryServiceData</para>
    ///
    /// Amazon Web Services Directory Service Data is an extension of Directory Service.
    /// This API reference provides detailed information about Directory Service Data operations
    /// and object types. 
    /// 
    ///  
    /// <para>
    ///  With Directory Service Data, you can create, read, update, and delete users, groups,
    /// and memberships from your Managed Microsoft AD without additional costs and without
    /// deploying dedicated management instances. You can also perform built-in object management
    /// tasks across directories without direct network connectivity, which simplifies provisioning
    /// and access management to achieve fully automated deployments. Directory Service Data
    /// supports user and group write operations, such as <c>CreateUser</c> and <c>CreateGroup</c>,
    /// within the organizational unit (OU) of your Managed Microsoft AD. Directory Service
    /// Data supports read operations, such as <c>ListUsers</c> and <c>ListGroups</c>, on
    /// all users, groups, and group memberships within your Managed Microsoft AD and across
    /// trusted realms. Directory Service Data supports adding and removing group members
    /// in your OU and the Amazon Web Services Delegated Groups OU, so you can grant and deny
    /// access to specific roles and permissions. For more information, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ms_ad_manage_users_groups.html">Manage
    /// users and groups</a> in the <i>Directory Service Administration Guide</i>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  Directory management operations and configuration changes made against the Directory
    /// Service API will also reflect in Directory Service Data API with eventual consistency.
    /// You can expect a short delay between management changes, such as adding a new directory
    /// trust and calling the Directory Service Data API for the newly created trusted realm.
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  Directory Service Data connects to your Managed Microsoft AD domain controllers and
    /// performs operations on underlying directory objects. When you create your Managed
    /// Microsoft AD, you choose subnets for domain controllers that Directory Service creates
    /// on your behalf. If a domain controller is unavailable, Directory Service Data uses
    /// an available domain controller. As a result, you might notice eventual consistency
    /// while objects replicate from one domain controller to another domain controller. For
    /// more information, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ms_ad_getting_started_what_gets_created.html">What
    /// gets created</a> in the <i>Directory Service Administration Guide</i>. Directory limits
    /// vary by Managed Microsoft AD edition: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Standard edition</b> – Supports 8 transactions per second (TPS) for read operations
    /// and 4 TPS for write operations per directory. There's a concurrency limit of 10 concurrent
    /// requests. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Enterprise edition</b> – Supports 16 transactions per second (TPS) for read operations
    /// and 8 TPS for write operations per directory. There's a concurrency limit of 10 concurrent
    /// requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Amazon Web Services Account</b> - Supports a total of 100 TPS for Directory Service
    /// Data operations across all directories.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  Directory Service Data only supports the Managed Microsoft AD directory type and
    /// is only available in the primary Amazon Web Services Region. For more information,
    /// see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/directory_microsoft_ad.html">Managed
    /// Microsoft AD</a> and <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/multi-region-global-primary-additional.html">Primary
    /// vs additional Regions</a> in the <i>Directory Service Administration Guide</i>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonDirectoryServiceData : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDirectoryServiceDataPaginatorFactory Paginators { get; }

        
        #region  AddGroupMember


        /// <summary>
        /// Adds an existing user, group, or computer as a group member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddGroupMember service method.</param>
        /// 
        /// <returns>The response from the AddGroupMember service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/AddGroupMember">REST API Reference for AddGroupMember Operation</seealso>
        AddGroupMemberResponse AddGroupMember(AddGroupMemberRequest request);



        /// <summary>
        /// Adds an existing user, group, or computer as a group member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddGroupMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddGroupMember service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/AddGroupMember">REST API Reference for AddGroupMember Operation</seealso>
        Task<AddGroupMemberResponse> AddGroupMemberAsync(AddGroupMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);



        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);



        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/CreateUser">REST API Reference for CreateUser Operation</seealso>
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);



        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);



        /// <summary>
        /// Deletes a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGroup


        /// <summary>
        /// Returns information about a specific group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        DescribeGroupResponse DescribeGroup(DescribeGroupRequest request);



        /// <summary>
        /// Returns information about a specific group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Returns information about a specific user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse DescribeUser(DescribeUserRequest request);



        /// <summary>
        /// Returns information about a specific user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableUser


        /// <summary>
        /// Deactivates an active user account. For information about how to enable an inactive
        /// user account, see <a href="https://docs.aws.amazon.com/directoryservice/latest/devguide/API_ResetUserPassword.html">ResetUserPassword</a>
        /// in the <i>Directory Service API Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableUser service method.</param>
        /// 
        /// <returns>The response from the DisableUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DisableUser">REST API Reference for DisableUser Operation</seealso>
        DisableUserResponse DisableUser(DisableUserRequest request);



        /// <summary>
        /// Deactivates an active user account. For information about how to enable an inactive
        /// user account, see <a href="https://docs.aws.amazon.com/directoryservice/latest/devguide/API_ResetUserPassword.html">ResetUserPassword</a>
        /// in the <i>Directory Service API Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DisableUser">REST API Reference for DisableUser Operation</seealso>
        Task<DisableUserResponse> DisableUserAsync(DisableUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroupMembers


        /// <summary>
        /// Returns member information for the specified group. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListGroupMembers.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListGroupMembers</c>.
        /// This retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers service method.</param>
        /// 
        /// <returns>The response from the ListGroupMembers service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        ListGroupMembersResponse ListGroupMembers(ListGroupMembersRequest request);



        /// <summary>
        /// Returns member information for the specified group. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListGroupMembers.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListGroupMembers</c>.
        /// This retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupMembers service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        Task<ListGroupMembersResponse> ListGroupMembersAsync(ListGroupMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Returns group information for the specified directory. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListGroups.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListGroups</c>. This
        /// retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);



        /// <summary>
        /// Returns group information for the specified directory. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListGroups.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListGroups</c>. This
        /// retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroupsForMember


        /// <summary>
        /// Returns group information for the specified member. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListGroupsForMember.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListGroupsForMember</c>.
        /// This retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForMember service method.</param>
        /// 
        /// <returns>The response from the ListGroupsForMember service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroupsForMember">REST API Reference for ListGroupsForMember Operation</seealso>
        ListGroupsForMemberResponse ListGroupsForMember(ListGroupsForMemberRequest request);



        /// <summary>
        /// Returns group information for the specified member. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListGroupsForMember.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListGroupsForMember</c>.
        /// This retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupsForMember service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroupsForMember">REST API Reference for ListGroupsForMember Operation</seealso>
        Task<ListGroupsForMemberResponse> ListGroupsForMemberAsync(ListGroupsForMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Returns user information for the specified directory. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListUsers.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListUsers</c>. This retrieves
        /// the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);



        /// <summary>
        /// Returns user information for the specified directory. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListUsers.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListUsers</c>. This retrieves
        /// the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveGroupMember


        /// <summary>
        /// Removes a member from a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveGroupMember service method.</param>
        /// 
        /// <returns>The response from the RemoveGroupMember service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/RemoveGroupMember">REST API Reference for RemoveGroupMember Operation</seealso>
        RemoveGroupMemberResponse RemoveGroupMember(RemoveGroupMemberRequest request);



        /// <summary>
        /// Removes a member from a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveGroupMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveGroupMember service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/RemoveGroupMember">REST API Reference for RemoveGroupMember Operation</seealso>
        Task<RemoveGroupMemberResponse> RemoveGroupMemberAsync(RemoveGroupMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchGroups


        /// <summary>
        /// Searches the specified directory for a group. You can find groups that match the
        /// <c>SearchString</c> parameter with the value of their attributes included in the <c>SearchString</c>
        /// parameter. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>SearchGroups.NextToken</c>
        /// member contains a token that you pass in the next call to <c>SearchGroups</c>. This
        /// retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroups service method.</param>
        /// 
        /// <returns>The response from the SearchGroups service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/SearchGroups">REST API Reference for SearchGroups Operation</seealso>
        SearchGroupsResponse SearchGroups(SearchGroupsRequest request);



        /// <summary>
        /// Searches the specified directory for a group. You can find groups that match the
        /// <c>SearchString</c> parameter with the value of their attributes included in the <c>SearchString</c>
        /// parameter. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>SearchGroups.NextToken</c>
        /// member contains a token that you pass in the next call to <c>SearchGroups</c>. This
        /// retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchGroups service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/SearchGroups">REST API Reference for SearchGroups Operation</seealso>
        Task<SearchGroupsResponse> SearchGroupsAsync(SearchGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchUsers


        /// <summary>
        /// Searches the specified directory for a user. You can find users that match the <c>SearchString</c>
        /// parameter with the value of their attributes included in the <c>SearchString</c> parameter.
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>SearchUsers.NextToken</c>
        /// member contains a token that you pass in the next call to <c>SearchUsers</c>. This
        /// retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers service method.</param>
        /// 
        /// <returns>The response from the SearchUsers service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        SearchUsersResponse SearchUsers(SearchUsersRequest request);



        /// <summary>
        /// Searches the specified directory for a user. You can find users that match the <c>SearchString</c>
        /// parameter with the value of their attributes included in the <c>SearchString</c> parameter.
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>SearchUsers.NextToken</c>
        /// member contains a token that you pass in the next call to <c>SearchUsers</c>. This
        /// retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchUsers service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        Task<SearchUsersResponse> SearchUsersAsync(SearchUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates group information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);



        /// <summary>
        /// Updates group information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates user information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);



        /// <summary>
        /// Updates user information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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