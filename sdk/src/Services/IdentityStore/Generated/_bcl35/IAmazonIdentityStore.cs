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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IdentityStore.Model;

namespace Amazon.IdentityStore
{
    /// <summary>
    /// Interface for accessing IdentityStore
    ///
    /// The Identity Store service used by AWS IAM Identity Center (successor to AWS Single
    /// Sign-On) provides a single place to retrieve all of your identities (users and groups).
    /// For more information, see the <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html">IAM
    /// Identity Center User Guide</a>.
    /// 
    ///  <pre><code> &lt;note&gt; &lt;p&gt;Although AWS Single Sign-On was renamed, the &lt;code&gt;sso&lt;/code&gt;
    /// and &lt;code&gt;identitystore&lt;/code&gt; API namespaces will continue to retain
    /// their original name for backward compatibility purposes. For more information, see
    /// &lt;a href=&quot;https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html#renamed&quot;&gt;IAM
    /// Identity Center rename&lt;/a&gt;.&lt;/p&gt; &lt;/note&gt; &lt;p&gt;This reference
    /// guide describes the identity store operations that you can call programatically and
    /// includes detailed information about data types and errors.&lt;/p&gt; </code></pre>
    /// </summary>
    public partial interface IAmazonIdentityStore : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIdentityStorePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateGroup


        /// <summary>
        /// Creates a group within the specified identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ServiceQuotaExceededException">
        /// The request would cause the number of users or groups in the identity store to exceed
        /// the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroupMembership


        /// <summary>
        /// Creates a relationship between a member and a group. The following identifiers must
        /// be specified: <code>GroupId</code>, <code>IdentityStoreId</code>, and <code>MemberId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
        /// 
        /// <returns>The response from the CreateGroupMembership service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ServiceQuotaExceededException">
        /// The request would cause the number of users or groups in the identity store to exceed
        /// the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        CreateGroupMembershipResponse CreateGroupMembership(CreateGroupMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        IAsyncResult BeginCreateGroupMembership(CreateGroupMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupMembership.</param>
        /// 
        /// <returns>Returns a  CreateGroupMembershipResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        CreateGroupMembershipResponse EndCreateGroupMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a user within the specified identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ServiceQuotaExceededException">
        /// The request would cause the number of users or groups in the identity store to exceed
        /// the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateUser">REST API Reference for CreateUser Operation</seealso>
        IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Delete a group within an identity store given <code>GroupId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroupMembership


        /// <summary>
        /// Delete a membership within a group given <code>MembershipId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupMembership service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        DeleteGroupMembershipResponse DeleteGroupMembership(DeleteGroupMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        IAsyncResult BeginDeleteGroupMembership(DeleteGroupMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupMembership.</param>
        /// 
        /// <returns>Returns a  DeleteGroupMembershipResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        DeleteGroupMembershipResponse EndDeleteGroupMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a user within an identity store given <code>UserId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGroup


        /// <summary>
        /// Retrieves the group metadata and attributes from <code>GroupId</code> in an identity
        /// store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        DescribeGroupResponse DescribeGroup(DescribeGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        IAsyncResult BeginDescribeGroup(DescribeGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroup.</param>
        /// 
        /// <returns>Returns a  DescribeGroupResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        DescribeGroupResponse EndDescribeGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGroupMembership


        /// <summary>
        /// Retrieves membership metadata and attributes from <code>MembershipId</code> in an
        /// identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroupMembership service method.</param>
        /// 
        /// <returns>The response from the DescribeGroupMembership service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        DescribeGroupMembershipResponse DescribeGroupMembership(DescribeGroupMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroupMembership operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        IAsyncResult BeginDescribeGroupMembership(DescribeGroupMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroupMembership.</param>
        /// 
        /// <returns>Returns a  DescribeGroupMembershipResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        DescribeGroupMembershipResponse EndDescribeGroupMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Retrieves the user metadata and attributes from the <code>UserId</code> in an identity
        /// store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse DescribeUser(DescribeUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        IAsyncResult BeginDescribeUser(DescribeUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUser.</param>
        /// 
        /// <returns>Returns a  DescribeUserResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroupId


        /// <summary>
        /// Retrieves <code>GroupId</code> in an identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupId service method.</param>
        /// 
        /// <returns>The response from the GetGroupId service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupId">REST API Reference for GetGroupId Operation</seealso>
        GetGroupIdResponse GetGroupId(GetGroupIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupId operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupId">REST API Reference for GetGroupId Operation</seealso>
        IAsyncResult BeginGetGroupId(GetGroupIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupId.</param>
        /// 
        /// <returns>Returns a  GetGroupIdResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupId">REST API Reference for GetGroupId Operation</seealso>
        GetGroupIdResponse EndGetGroupId(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroupMembershipId


        /// <summary>
        /// Retrieves the <code>MembershipId</code> in an identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupMembershipId service method.</param>
        /// 
        /// <returns>The response from the GetGroupMembershipId service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupMembershipId">REST API Reference for GetGroupMembershipId Operation</seealso>
        GetGroupMembershipIdResponse GetGroupMembershipId(GetGroupMembershipIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupMembershipId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupMembershipId operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupMembershipId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupMembershipId">REST API Reference for GetGroupMembershipId Operation</seealso>
        IAsyncResult BeginGetGroupMembershipId(GetGroupMembershipIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupMembershipId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupMembershipId.</param>
        /// 
        /// <returns>Returns a  GetGroupMembershipIdResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupMembershipId">REST API Reference for GetGroupMembershipId Operation</seealso>
        GetGroupMembershipIdResponse EndGetGroupMembershipId(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUserId


        /// <summary>
        /// Retrieves the <code>UserId</code> in an identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserId service method.</param>
        /// 
        /// <returns>The response from the GetUserId service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetUserId">REST API Reference for GetUserId Operation</seealso>
        GetUserIdResponse GetUserId(GetUserIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserId operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetUserId">REST API Reference for GetUserId Operation</seealso>
        IAsyncResult BeginGetUserId(GetUserIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserId.</param>
        /// 
        /// <returns>Returns a  GetUserIdResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetUserId">REST API Reference for GetUserId Operation</seealso>
        GetUserIdResponse EndGetUserId(IAsyncResult asyncResult);

        #endregion
        
        #region  IsMemberInGroups


        /// <summary>
        /// Checks the user's membership in all requested groups and returns if the member exists
        /// in all queried groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsMemberInGroups service method.</param>
        /// 
        /// <returns>The response from the IsMemberInGroups service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/IsMemberInGroups">REST API Reference for IsMemberInGroups Operation</seealso>
        IsMemberInGroupsResponse IsMemberInGroups(IsMemberInGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the IsMemberInGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IsMemberInGroups operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIsMemberInGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/IsMemberInGroups">REST API Reference for IsMemberInGroups Operation</seealso>
        IAsyncResult BeginIsMemberInGroups(IsMemberInGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  IsMemberInGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIsMemberInGroups.</param>
        /// 
        /// <returns>Returns a  IsMemberInGroupsResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/IsMemberInGroups">REST API Reference for IsMemberInGroups Operation</seealso>
        IsMemberInGroupsResponse EndIsMemberInGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupMemberships


        /// <summary>
        /// For the specified group in the specified identity store, returns the list of all <code>GroupMembership</code>
        /// objects and returns results in paginated form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
        /// 
        /// <returns>The response from the ListGroupMemberships service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        ListGroupMembershipsResponse ListGroupMemberships(ListGroupMembershipsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        IAsyncResult BeginListGroupMemberships(ListGroupMembershipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMemberships.</param>
        /// 
        /// <returns>Returns a  ListGroupMembershipsResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        ListGroupMembershipsResponse EndListGroupMemberships(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupMembershipsForMember


        /// <summary>
        /// For the specified member in the specified identity store, returns the list of all
        /// <code>GroupMembership</code> objects and returns results in paginated form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembershipsForMember service method.</param>
        /// 
        /// <returns>The response from the ListGroupMembershipsForMember service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMembershipsForMember">REST API Reference for ListGroupMembershipsForMember Operation</seealso>
        ListGroupMembershipsForMemberResponse ListGroupMembershipsForMember(ListGroupMembershipsForMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMembershipsForMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembershipsForMember operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMembershipsForMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMembershipsForMember">REST API Reference for ListGroupMembershipsForMember Operation</seealso>
        IAsyncResult BeginListGroupMembershipsForMember(ListGroupMembershipsForMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMembershipsForMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMembershipsForMember.</param>
        /// 
        /// <returns>Returns a  ListGroupMembershipsForMemberResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMembershipsForMember">REST API Reference for ListGroupMembershipsForMember Operation</seealso>
        ListGroupMembershipsForMemberResponse EndListGroupMembershipsForMember(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Lists all groups in the identity store. Returns a paginated list of complete <code>Group</code>
        /// objects. Filtering for a <code>Group</code> by the <code>DisplayName</code> attribute
        /// is deprecated. Instead, use the <code>GetGroupId</code> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroups">REST API Reference for ListGroups Operation</seealso>
        IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Lists all users in the identity store. Returns a paginated list of complete <code>User</code>
        /// objects. Filtering for a <code>User</code> by the <code>UserName</code> attribute
        /// is deprecated. Instead, use the <code>GetUserId</code> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListUsers">REST API Reference for ListUsers Operation</seealso>
        IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse EndListUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// For the specified group in the specified identity store, updates the group metadata
        /// and attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ServiceQuotaExceededException">
        /// The request would cause the number of users or groups in the identity store to exceed
        /// the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// For the specified user in the specified identity store, updates the user metadata
        /// and attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ServiceQuotaExceededException">
        /// The request would cause the number of users or groups in the identity store to exceed
        /// the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

        #endregion
        
    }
}