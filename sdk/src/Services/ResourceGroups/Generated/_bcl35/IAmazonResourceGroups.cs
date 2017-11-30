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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ResourceGroups.Model;

namespace Amazon.ResourceGroups
{
    /// <summary>
    /// Interface for accessing ResourceGroups
    ///
    /// AWS Resource Groups 
    /// <para>
    /// AWS Resource Groups lets you organize AWS resources such as Amazon EC2 instances,
    /// Amazon Relational Database Service databases, and Amazon S3 buckets into groups using
    /// criteria that you define as tags. A resource group is a collection of resources that
    /// match the resource types specified in a query, and share one or more tags or portions
    /// of tags. You can create a group of resources based on their roles in your cloud infrastructure,
    /// lifecycle stages, regions, application layers, or virtually any criteria. Resource
    /// groups enable you to automate management tasks, such as those in AWS Systems Manager
    /// Automation documents, on tag-related resources in AWS Systems Manager. Groups of tagged
    /// resources also let you quickly view a custom console in AWS Systems Manager that shows
    /// AWS Config compliance and other monitoring data about member resources.
    /// </para>
    ///  
    /// <para>
    /// To create a resource group, build a resource query, and specify tags that identify
    /// the criteria that members of the group have in common. Tags are key-value pairs.
    /// </para>
    ///  
    /// <para>
    /// For more information about Resource Groups, see the <a href="https://docs.aws.amazon.com/ARG/latest/userguide/welcome.html">AWS
    /// Resource Groups User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// AWS Resource Groups uses a REST-compliant API that you can use to perform the following
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
    /// Searching AWS resources based on a resource query
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonResourceGroups : IAmazonService, IDisposable
    {

        
        #region  CreateGroup


        /// <summary>
        /// Creates a group with a specified name, description, and resource query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a specified resource group. Deleting a resource group does not delete resources
        /// that are members of the group; it only deletes the group structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more resources specified in the request do not exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Returns information about a specified resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more resources specified in the request do not exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse GetGroup(GetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse EndGetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroupQuery


        /// <summary>
        /// Returns the resource query associated with the specified resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupQuery service method.</param>
        /// 
        /// <returns>The response from the GetGroupQuery service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more resources specified in the request do not exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupQuery">REST API Reference for GetGroupQuery Operation</seealso>
        GetGroupQueryResponse GetGroupQuery(GetGroupQueryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupQuery operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupQuery">REST API Reference for GetGroupQuery Operation</seealso>
        IAsyncResult BeginGetGroupQuery(GetGroupQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupQuery.</param>
        /// 
        /// <returns>Returns a  GetGroupQueryResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupQuery">REST API Reference for GetGroupQuery Operation</seealso>
        GetGroupQueryResponse EndGetGroupQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTags


        /// <summary>
        /// Returns a list of tags that are associated with a resource, specified by an ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more resources specified in the request do not exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetTags">REST API Reference for GetTags Operation</seealso>
        GetTagsResponse GetTags(GetTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTags operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetTags">REST API Reference for GetTags Operation</seealso>
        IAsyncResult BeginGetTags(GetTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTags.</param>
        /// 
        /// <returns>Returns a  GetTagsResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetTags">REST API Reference for GetTags Operation</seealso>
        GetTagsResponse EndGetTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupResources


        /// <summary>
        /// Returns a list of ARNs of resources that are members of a specified resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupResources service method.</param>
        /// 
        /// <returns>The response from the ListGroupResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more resources specified in the request do not exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.UnauthorizedException">
        /// The request has not been applied because it lacks valid authentication credentials
        /// for the target resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        ListGroupResourcesResponse ListGroupResources(ListGroupResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupResources operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        IAsyncResult BeginListGroupResources(ListGroupResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupResources.</param>
        /// 
        /// <returns>Returns a  ListGroupResourcesResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        ListGroupResourcesResponse EndListGroupResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Returns a list of existing resource groups in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchResources


        /// <summary>
        /// Returns a list of AWS resource identifiers that matches a specified query. The query
        /// uses the same format as a resource query in a CreateGroup or UpdateGroupQuery operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResources service method.</param>
        /// 
        /// <returns>The response from the SearchResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.UnauthorizedException">
        /// The request has not been applied because it lacks valid authentication credentials
        /// for the target resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/SearchResources">REST API Reference for SearchResources Operation</seealso>
        SearchResourcesResponse SearchResources(SearchResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchResources operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/SearchResources">REST API Reference for SearchResources Operation</seealso>
        IAsyncResult BeginSearchResources(SearchResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchResources.</param>
        /// 
        /// <returns>Returns a  SearchResourcesResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/SearchResources">REST API Reference for SearchResources Operation</seealso>
        SearchResourcesResponse EndSearchResources(IAsyncResult asyncResult);

        #endregion
        
        #region  Tag


        /// <summary>
        /// Adds specified tags to a resource with the specified ARN. Existing tags on a resource
        /// are not changed if they are not specified in the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Tag service method.</param>
        /// 
        /// <returns>The response from the Tag service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more resources specified in the request do not exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Tag">REST API Reference for Tag Operation</seealso>
        TagResponse Tag(TagRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Tag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Tag operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Tag">REST API Reference for Tag Operation</seealso>
        IAsyncResult BeginTag(TagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Tag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTag.</param>
        /// 
        /// <returns>Returns a  TagResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Tag">REST API Reference for Tag Operation</seealso>
        TagResponse EndTag(IAsyncResult asyncResult);

        #endregion
        
        #region  Untag


        /// <summary>
        /// Deletes specified tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Untag service method.</param>
        /// 
        /// <returns>The response from the Untag service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more resources specified in the request do not exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Untag">REST API Reference for Untag Operation</seealso>
        UntagResponse Untag(UntagRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Untag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Untag operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Untag">REST API Reference for Untag Operation</seealso>
        IAsyncResult BeginUntag(UntagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Untag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntag.</param>
        /// 
        /// <returns>Returns a  UntagResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Untag">REST API Reference for Untag Operation</seealso>
        UntagResponse EndUntag(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates an existing group with a new or changed description. You cannot update the
        /// name of a resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more resources specified in the request do not exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroupQuery


        /// <summary>
        /// Updates the resource query of a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupQuery service method.</param>
        /// 
        /// <returns>The response from the UpdateGroupQuery service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request does not comply with validation rules that are defined for the request
        /// parameters.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller is not authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method which is not allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more resources specified in the request do not exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// The caller has exceeded throttling limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroupQuery">REST API Reference for UpdateGroupQuery Operation</seealso>
        UpdateGroupQueryResponse UpdateGroupQuery(UpdateGroupQueryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroupQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupQuery operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroupQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroupQuery">REST API Reference for UpdateGroupQuery Operation</seealso>
        IAsyncResult BeginUpdateGroupQuery(UpdateGroupQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroupQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroupQuery.</param>
        /// 
        /// <returns>Returns a  UpdateGroupQueryResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroupQuery">REST API Reference for UpdateGroupQuery Operation</seealso>
        UpdateGroupQueryResponse EndUpdateGroupQuery(IAsyncResult asyncResult);

        #endregion
        
    }
}