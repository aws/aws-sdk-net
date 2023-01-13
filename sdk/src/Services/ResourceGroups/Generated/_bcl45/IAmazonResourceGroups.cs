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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ResourceGroups.Model;

namespace Amazon.ResourceGroups
{
    /// <summary>
    /// Interface for accessing ResourceGroups
    ///
    /// Resource Groups lets you organize Amazon Web Services resources such as Amazon Elastic
    /// Compute Cloud instances, Amazon Relational Database Service databases, and Amazon
    /// Simple Storage Service buckets into groups using criteria that you define as tags.
    /// A resource group is a collection of resources that match the resource types specified
    /// in a query, and share one or more tags or portions of tags. You can create a group
    /// of resources based on their roles in your cloud infrastructure, lifecycle stages,
    /// regions, application layers, or virtually any criteria. Resource Groups enable you
    /// to automate management tasks, such as those in Amazon Web Services Systems Manager
    /// Automation documents, on tag-related resources in Amazon Web Services Systems Manager.
    /// Groups of tagged resources also let you quickly view a custom console in Amazon Web
    /// Services Systems Manager that shows Config compliance and other monitoring data about
    /// member resources.
    /// 
    ///  
    /// <para>
    /// To create a resource group, build a resource query, and specify tags that identify
    /// the criteria that members of the group have in common. Tags are key-value pairs.
    /// </para>
    ///  
    /// <para>
    /// For more information about Resource Groups, see the <a href="https://docs.aws.amazon.com/ARG/latest/userguide/welcome.html">Resource
    /// Groups User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// Resource Groups uses a REST-compliant API that you can use to perform the following
    /// types of operations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Create, Read, Update, and Delete (CRUD) operations on resource groups and resource
    /// query entities
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Applying, editing, and removing tags from resource groups
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Resolving resource group member ARNs so they can be returned as search results
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Getting data about resources that are members of a group
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Searching Amazon Web Services resources based on a resource query
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonResourceGroups : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IResourceGroupsPaginatorFactory Paginators { get; }

        
        #region  CreateGroup


        /// <summary>
        /// Creates a resource group with the specified name and description. You can optionally
        /// include either a resource query or a service configuration. For more information about
        /// constructing a resource query, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/getting_started-query.html">Build
        /// queries and groups in Resource Groups</a> in the <i>Resource Groups User Guide</i>.
        /// For more information about service-linked groups and service configurations, see <a
        /// href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
        /// configurations for Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:CreateGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);



        /// <summary>
        /// Creates a resource group with the specified name and description. You can optionally
        /// include either a resource query or a service configuration. For more information about
        /// constructing a resource query, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/getting_started-query.html">Build
        /// queries and groups in Resource Groups</a> in the <i>Resource Groups User Guide</i>.
        /// For more information about service-linked groups and service configurations, see <a
        /// href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
        /// configurations for Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:CreateGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes the specified resource group. Deleting a resource group does not delete any
        /// resources that are members of the group; it only deletes the group structure.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:DeleteGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);



        /// <summary>
        /// Deletes the specified resource group. Deleting a resource group does not delete any
        /// resources that are members of the group; it only deletes the group structure.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:DeleteGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAccountSettings


        /// <summary>
        /// Retrieves the current status of optional features in Resource Groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request);



        /// <summary>
        /// Retrieves the current status of optional features in Resource Groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Returns information about a specified resource group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse GetGroup(GetGroupRequest request);



        /// <summary>
        /// Returns information about a specified resource group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGroupConfiguration


        /// <summary>
        /// Retrieves the service configuration associated with the specified resource group.
        /// For details about the service configuration syntax, see <a href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
        /// configurations for Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetGroupConfiguration</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetGroupConfiguration service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupConfiguration">REST API Reference for GetGroupConfiguration Operation</seealso>
        GetGroupConfigurationResponse GetGroupConfiguration(GetGroupConfigurationRequest request);



        /// <summary>
        /// Retrieves the service configuration associated with the specified resource group.
        /// For details about the service configuration syntax, see <a href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
        /// configurations for Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetGroupConfiguration</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupConfiguration service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupConfiguration">REST API Reference for GetGroupConfiguration Operation</seealso>
        Task<GetGroupConfigurationResponse> GetGroupConfigurationAsync(GetGroupConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGroupQuery


        /// <summary>
        /// Retrieves the resource query associated with the specified resource group. For more
        /// information about resource queries, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#gettingstarted-query-cli-tag">Create
        /// a tag-based group in Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetGroupQuery</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupQuery service method.</param>
        /// 
        /// <returns>The response from the GetGroupQuery service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupQuery">REST API Reference for GetGroupQuery Operation</seealso>
        GetGroupQueryResponse GetGroupQuery(GetGroupQueryRequest request);



        /// <summary>
        /// Retrieves the resource query associated with the specified resource group. For more
        /// information about resource queries, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#gettingstarted-query-cli-tag">Create
        /// a tag-based group in Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetGroupQuery</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupQuery service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupQuery">REST API Reference for GetGroupQuery Operation</seealso>
        Task<GetGroupQueryResponse> GetGroupQueryAsync(GetGroupQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTags


        /// <summary>
        /// Returns a list of tags that are associated with a resource group, specified by an
        /// ARN.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetTags</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetTags">REST API Reference for GetTags Operation</seealso>
        GetTagsResponse GetTags(GetTagsRequest request);



        /// <summary>
        /// Returns a list of tags that are associated with a resource group, specified by an
        /// ARN.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetTags</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetTags">REST API Reference for GetTags Operation</seealso>
        Task<GetTagsResponse> GetTagsAsync(GetTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GroupResources


        /// <summary>
        /// Adds the specified resources to the specified group.
        /// 
        ///  <important> 
        /// <para>
        /// You can use this operation with only resource groups that are configured with the
        /// following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS::EC2::HostManagement</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::EC2::CapacityReservationPool</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Other resource group type and resource types aren't currently supported by this operation.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GroupResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GroupResources service method.</param>
        /// 
        /// <returns>The response from the GroupResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GroupResources">REST API Reference for GroupResources Operation</seealso>
        GroupResourcesResponse GroupResources(GroupResourcesRequest request);



        /// <summary>
        /// Adds the specified resources to the specified group.
        /// 
        ///  <important> 
        /// <para>
        /// You can use this operation with only resource groups that are configured with the
        /// following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS::EC2::HostManagement</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::EC2::CapacityReservationPool</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Other resource group type and resource types aren't currently supported by this operation.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GroupResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GroupResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GroupResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GroupResources">REST API Reference for GroupResources Operation</seealso>
        Task<GroupResourcesResponse> GroupResourcesAsync(GroupResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroupResources


        /// <summary>
        /// Returns a list of ARNs of the resources that are members of a specified resource group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:ListGroupResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:DescribeStacks</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:ListStackResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag:GetResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupResources service method.</param>
        /// 
        /// <returns>The response from the ListGroupResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        ListGroupResourcesResponse ListGroupResources(ListGroupResourcesRequest request);



        /// <summary>
        /// Returns a list of ARNs of the resources that are members of a specified resource group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:ListGroupResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:DescribeStacks</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:ListStackResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag:GetResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        Task<ListGroupResourcesResponse> ListGroupResourcesAsync(ListGroupResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Returns a list of existing Resource Groups in your account.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:ListGroups</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);



        /// <summary>
        /// Returns a list of existing Resource Groups in your account.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:ListGroups</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutGroupConfiguration


        /// <summary>
        /// Attaches a service configuration to the specified group. This occurs asynchronously,
        /// and can take time to complete. You can use <a>GetGroupConfiguration</a> to check the
        /// status of the update.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:PutGroupConfiguration</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutGroupConfiguration service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/PutGroupConfiguration">REST API Reference for PutGroupConfiguration Operation</seealso>
        PutGroupConfigurationResponse PutGroupConfiguration(PutGroupConfigurationRequest request);



        /// <summary>
        /// Attaches a service configuration to the specified group. This occurs asynchronously,
        /// and can take time to complete. You can use <a>GetGroupConfiguration</a> to check the
        /// status of the update.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:PutGroupConfiguration</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutGroupConfiguration service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/PutGroupConfiguration">REST API Reference for PutGroupConfiguration Operation</seealso>
        Task<PutGroupConfigurationResponse> PutGroupConfigurationAsync(PutGroupConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchResources


        /// <summary>
        /// Returns a list of Amazon Web Services resource identifiers that matches the specified
        /// query. The query uses the same format as a resource query in a <a>CreateGroup</a>
        /// or <a>UpdateGroupQuery</a> operation.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:SearchResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:DescribeStacks</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:ListStackResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag:GetResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResources service method.</param>
        /// 
        /// <returns>The response from the SearchResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/SearchResources">REST API Reference for SearchResources Operation</seealso>
        SearchResourcesResponse SearchResources(SearchResourcesRequest request);



        /// <summary>
        /// Returns a list of Amazon Web Services resource identifiers that matches the specified
        /// query. The query uses the same format as a resource query in a <a>CreateGroup</a>
        /// or <a>UpdateGroupQuery</a> operation.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:SearchResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:DescribeStacks</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:ListStackResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag:GetResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/SearchResources">REST API Reference for SearchResources Operation</seealso>
        Task<SearchResourcesResponse> SearchResourcesAsync(SearchResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Tag


        /// <summary>
        /// Adds tags to a resource group with the specified ARN. Existing tags on a resource
        /// group are not changed if they are not specified in the request parameters.
        /// 
        ///  <important> 
        /// <para>
        /// Do not store personally identifiable information (PII) or other confidential or sensitive
        /// information in tags. We use tags to provide you with billing and administration services.
        /// Tags are not intended to be used for private or sensitive data.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:Tag</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Tag service method.</param>
        /// 
        /// <returns>The response from the Tag service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Tag">REST API Reference for Tag Operation</seealso>
        TagResponse Tag(TagRequest request);



        /// <summary>
        /// Adds tags to a resource group with the specified ARN. Existing tags on a resource
        /// group are not changed if they are not specified in the request parameters.
        /// 
        ///  <important> 
        /// <para>
        /// Do not store personally identifiable information (PII) or other confidential or sensitive
        /// information in tags. We use tags to provide you with billing and administration services.
        /// Tags are not intended to be used for private or sensitive data.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:Tag</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Tag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Tag service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Tag">REST API Reference for Tag Operation</seealso>
        Task<TagResponse> TagAsync(TagRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UngroupResources


        /// <summary>
        /// Removes the specified resources from the specified group. This operation works only
        /// with static groups that you populated using the <a>GroupResources</a> operation. It
        /// doesn't work with any resource groups that are automatically populated by tag-based
        /// or CloudFormation stack-based queries.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:UngroupResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UngroupResources service method.</param>
        /// 
        /// <returns>The response from the UngroupResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UngroupResources">REST API Reference for UngroupResources Operation</seealso>
        UngroupResourcesResponse UngroupResources(UngroupResourcesRequest request);



        /// <summary>
        /// Removes the specified resources from the specified group. This operation works only
        /// with static groups that you populated using the <a>GroupResources</a> operation. It
        /// doesn't work with any resource groups that are automatically populated by tag-based
        /// or CloudFormation stack-based queries.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:UngroupResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UngroupResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UngroupResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UngroupResources">REST API Reference for UngroupResources Operation</seealso>
        Task<UngroupResourcesResponse> UngroupResourcesAsync(UngroupResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Untag


        /// <summary>
        /// Deletes tags from a specified resource group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:Untag</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Untag service method.</param>
        /// 
        /// <returns>The response from the Untag service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Untag">REST API Reference for Untag Operation</seealso>
        UntagResponse Untag(UntagRequest request);



        /// <summary>
        /// Deletes tags from a specified resource group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:Untag</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Untag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Untag service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Untag">REST API Reference for Untag Operation</seealso>
        Task<UntagResponse> UntagAsync(UntagRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAccountSettings


        /// <summary>
        /// Turns on or turns off optional features in Resource Groups.
        /// 
        ///  
        /// <para>
        /// The preceding example shows that the request to turn on group lifecycle events is
        /// <code>IN_PROGRESS</code>. You can call the <a>GetAccountSettings</a> operation to
        /// check for completion by looking for <code>GroupLifecycleEventsStatus</code> to change
        /// to <code>ACTIVE</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request);



        /// <summary>
        /// Turns on or turns off optional features in Resource Groups.
        /// 
        ///  
        /// <para>
        /// The preceding example shows that the request to turn on group lifecycle events is
        /// <code>IN_PROGRESS</code>. You can call the <a>GetAccountSettings</a> operation to
        /// check for completion by looking for <code>GroupLifecycleEventsStatus</code> to change
        /// to <code>ACTIVE</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates the description for an existing group. You cannot update the name of a resource
        /// group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:UpdateGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);



        /// <summary>
        /// Updates the description for an existing group. You cannot update the name of a resource
        /// group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:UpdateGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGroupQuery


        /// <summary>
        /// Updates the resource query of a group. For more information about resource queries,
        /// see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#gettingstarted-query-cli-tag">Create
        /// a tag-based group in Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:UpdateGroupQuery</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupQuery service method.</param>
        /// 
        /// <returns>The response from the UpdateGroupQuery service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroupQuery">REST API Reference for UpdateGroupQuery Operation</seealso>
        UpdateGroupQueryResponse UpdateGroupQuery(UpdateGroupQueryRequest request);



        /// <summary>
        /// Updates the resource query of a group. For more information about resource queries,
        /// see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#gettingstarted-query-cli-tag">Create
        /// a tag-based group in Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:UpdateGroupQuery</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroupQuery service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroupQuery">REST API Reference for UpdateGroupQuery Operation</seealso>
        Task<UpdateGroupQueryResponse> UpdateGroupQueryAsync(UpdateGroupQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}