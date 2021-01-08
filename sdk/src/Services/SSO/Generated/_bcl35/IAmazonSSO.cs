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
 * Do not modify this file. This file is generated from the sso-2019-06-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSO.Model;

namespace Amazon.SSO
{
    /// <summary>
    /// Interface for accessing SSO
    ///
    /// AWS Single Sign-On Portal is a web service that makes it easy for you to assign user
    /// access to AWS SSO resources such as the user portal. Users can get AWS account applications
    /// and roles assigned to them and get federated into the application.
    /// 
    ///  
    /// <para>
    /// For general information about AWS SSO, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html">What
    /// is AWS Single Sign-On?</a> in the <i>AWS SSO User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This API reference guide describes the AWS SSO Portal operations that you can call
    /// programatically and includes detailed information on data types and errors.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms, such as Java, Ruby, .Net, iOS, or Android. The SDKs provide
    /// a convenient way to create programmatic access to AWS SSO and other AWS services.
    /// For more information about the AWS SDKs, including how to download and install them,
    /// see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial interface IAmazonSSO : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISSOPaginatorFactory Paginators { get; }
#endif


        
        #region  GetRoleCredentials


        /// <summary>
        /// Returns the STS short-term credentials for a given role name that is assigned to the
        /// user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoleCredentials service method.</param>
        /// 
        /// <returns>The response from the GetRoleCredentials service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/GetRoleCredentials">REST API Reference for GetRoleCredentials Operation</seealso>
        GetRoleCredentialsResponse GetRoleCredentials(GetRoleCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoleCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoleCredentials operation on AmazonSSOClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoleCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/GetRoleCredentials">REST API Reference for GetRoleCredentials Operation</seealso>
        IAsyncResult BeginGetRoleCredentials(GetRoleCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoleCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoleCredentials.</param>
        /// 
        /// <returns>Returns a  GetRoleCredentialsResult from SSO.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/GetRoleCredentials">REST API Reference for GetRoleCredentials Operation</seealso>
        GetRoleCredentialsResponse EndGetRoleCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccountRoles


        /// <summary>
        /// Lists all roles that are assigned to the user for a given AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountRoles service method.</param>
        /// 
        /// <returns>The response from the ListAccountRoles service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/ListAccountRoles">REST API Reference for ListAccountRoles Operation</seealso>
        ListAccountRolesResponse ListAccountRoles(ListAccountRolesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountRoles operation on AmazonSSOClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountRoles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/ListAccountRoles">REST API Reference for ListAccountRoles Operation</seealso>
        IAsyncResult BeginListAccountRoles(ListAccountRolesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountRoles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountRoles.</param>
        /// 
        /// <returns>Returns a  ListAccountRolesResult from SSO.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/ListAccountRoles">REST API Reference for ListAccountRoles Operation</seealso>
        ListAccountRolesResponse EndListAccountRoles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccounts


        /// <summary>
        /// Lists all AWS accounts assigned to the user. These AWS accounts are assigned by the
        /// administrator of the account. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/useraccess.html#assignusers">Assign
        /// User Access</a> in the <i>AWS SSO User Guide</i>. This operation returns a paginated
        /// response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// 
        /// <returns>The response from the ListAccounts service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        ListAccountsResponse ListAccounts(ListAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts operation on AmazonSSOClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        IAsyncResult BeginListAccounts(ListAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccounts.</param>
        /// 
        /// <returns>Returns a  ListAccountsResult from SSO.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        ListAccountsResponse EndListAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  Logout


        /// <summary>
        /// Removes the client- and server-side session that is associated with the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Logout service method.</param>
        /// 
        /// <returns>The response from the Logout service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/Logout">REST API Reference for Logout Operation</seealso>
        LogoutResponse Logout(LogoutRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Logout operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Logout operation on AmazonSSOClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLogout
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/Logout">REST API Reference for Logout Operation</seealso>
        IAsyncResult BeginLogout(LogoutRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Logout operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLogout.</param>
        /// 
        /// <returns>Returns a  LogoutResult from SSO.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/Logout">REST API Reference for Logout Operation</seealso>
        LogoutResponse EndLogout(IAsyncResult asyncResult);

        #endregion
        
    }
}