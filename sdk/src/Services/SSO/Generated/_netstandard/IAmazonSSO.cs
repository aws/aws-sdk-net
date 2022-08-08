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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSO.Model;

namespace Amazon.SSO
{
    /// <summary>
    /// Interface for accessing SSO
    ///
    /// Amazon Web Services Single Sign On Portal is a web service that makes it easy for
    /// you to assign user access to Amazon Web Services SSO resources such as the AWS access
    /// portal. Users can get Amazon Web Services account applications and roles assigned
    /// to them and get federated into the application.
    /// 
    ///  <note> 
    /// <para>
    /// Although Amazon Web Services Single Sign-On was renamed, the <code>sso</code> and
    /// <code>identitystore</code> API namespaces will continue to retain their original name
    /// for backward compatibility purposes. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html#renamed">Amazon
    /// Web Services SSO rename</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This API reference guide describes the Amazon Web Services SSO Portal operations that
    /// you can call programatically and includes detailed information on data types and errors.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Web Services provides SDKs that consist of libraries and sample code for various
    /// programming languages and platforms, such as Java, Ruby, .Net, iOS, or Android. The
    /// SDKs provide a convenient way to create programmatic access to Amazon Web Services
    /// SSO and other Amazon Web Services services. For more information about the Amazon
    /// Web Services SDKs, including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial interface IAmazonSSO : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRoleCredentialsResponse> GetRoleCredentialsAsync(GetRoleCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccountRoles



        /// <summary>
        /// Lists all roles that are assigned to the user for a given Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountRoles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccountRolesResponse> ListAccountRolesAsync(ListAccountRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccounts



        /// <summary>
        /// Lists all Amazon Web Services accounts assigned to the user. These Amazon Web Services
        /// accounts are assigned by the administrator of the account. For more information, see
        /// <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/useraccess.html#assignusers">Assign
        /// User Access</a> in the <i>Amazon Web Services SSO User Guide</i>. This operation returns
        /// a paginated response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Logout



        /// <summary>
        /// Removes the locally stored SSO tokens from the client-side cache and sends an API
        /// call to the Amazon Web Services SSO service to invalidate the corresponding server-side
        /// Amazon Web Services SSO sign in session.
        /// 
        ///  <note> 
        /// <para>
        /// If a user uses Amazon Web Services SSO to access the AWS CLI, the user’s Amazon Web
        /// Services SSO sign in session is used to obtain an IAM session, as specified in the
        /// corresponding Amazon Web Services SSO permission set. More specifically, Amazon Web
        /// Services SSO assumes an IAM role in the target account on behalf of the user, and
        /// the corresponding temporary Amazon Web Services credentials are returned to the client.
        /// </para>
        ///  
        /// <para>
        /// After user logout, any existing IAM role sessions that were created by using Amazon
        /// Web Services SSO permission sets continue based on the duration configured in the
        /// permission set. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/authconcept.html">User
        /// authentications</a> in the <i>Amazon Web Services SSO User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Logout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<LogoutResponse> LogoutAsync(LogoutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}