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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Chime.Model;

namespace Amazon.Chime
{
    /// <summary>
    /// Interface for accessing Chime
    ///
    /// Amazon Chime is a communications service that transforms online meetings with a secure,
    /// easy-to-use application that you can trust. Amazon Chime works seamlessly across your
    /// devices so that you can stay connected. You can use Amazon Chime for online meetings,
    /// video conferencing, calls, and chat. You can also share content, both inside and outside
    /// your organization. Amazon Chime frees you to work productively from anywhere. 
    /// 
    ///  
    /// <para>
    /// The Amazon Chime API is designed for administrators to use to perform key tasks, such
    /// as creating and managing Amazon Chime accounts and users. This guide provides detailed
    /// information about the Amazon Chime API.
    /// </para>
    ///  
    /// <para>
    /// Use host name <code>service.chime.aws.amazon.com</code> when working with the Amazon
    /// Chime API.
    /// </para>
    /// </summary>
    public partial interface IAmazonChime : IAmazonService, IDisposable
    {
                
        #region  BatchSuspendUser


        /// <summary>
        /// Initiates the asynchronous execution of the BatchSuspendUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchSuspendUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchSuspendUser">REST API Reference for BatchSuspendUser Operation</seealso>
        Task<BatchSuspendUserResponse> BatchSuspendUserAsync(BatchSuspendUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUnsuspendUser


        /// <summary>
        /// Initiates the asynchronous execution of the BatchUnsuspendUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUnsuspendUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUnsuspendUser">REST API Reference for BatchUnsuspendUser Operation</seealso>
        Task<BatchUnsuspendUserResponse> BatchUnsuspendUserAsync(BatchUnsuspendUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUpdateUser


        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdateUser">REST API Reference for BatchUpdateUser Operation</seealso>
        Task<BatchUpdateUserResponse> BatchUpdateUserAsync(BatchUpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccount


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccount


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAccount">REST API Reference for DeleteAccount Operation</seealso>
        Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccount


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccount">REST API Reference for GetAccount Operation</seealso>
        Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountSettings


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUser


        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUser">REST API Reference for GetUser Operation</seealso>
        Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InviteUsers


        /// <summary>
        /// Initiates the asynchronous execution of the InviteUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/InviteUsers">REST API Reference for InviteUsers Operation</seealso>
        Task<InviteUsersResponse> InviteUsersAsync(InviteUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccounts


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUsers


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  LogoutUser


        /// <summary>
        /// Initiates the asynchronous execution of the LogoutUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LogoutUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/LogoutUser">REST API Reference for LogoutUser Operation</seealso>
        Task<LogoutUserResponse> LogoutUserAsync(LogoutUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetPersonalPIN


        /// <summary>
        /// Initiates the asynchronous execution of the ResetPersonalPIN operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetPersonalPIN operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ResetPersonalPIN">REST API Reference for ResetPersonalPIN Operation</seealso>
        Task<ResetPersonalPINResponse> ResetPersonalPINAsync(ResetPersonalPINRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccount


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccountSettings


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUser


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}