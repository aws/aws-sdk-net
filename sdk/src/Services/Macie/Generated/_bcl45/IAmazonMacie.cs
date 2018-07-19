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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Macie.Model;

namespace Amazon.Macie
{
    /// <summary>
    /// Interface for accessing Macie
    ///
    /// Amazon Macie 
    /// <para>
    /// Amazon Macie is a security service that uses machine learning to automatically discover,
    /// classify, and protect sensitive data in AWS. Macie recognizes sensitive data such
    /// as personally identifiable information (PII) or intellectual property, and provides
    /// you with dashboards and alerts that give visibility into how this data is being accessed
    /// or moved. For more information, see the <a href="https://docs.aws.amazon.com/macie/latest/userguide/what-is-macie.html">Macie
    /// User Guide</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonMacie : IAmazonService, IDisposable
    {

        
        #region  AssociateMemberAccount


        /// <summary>
        /// Associates a specified AWS account with Amazon Macie as a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberAccount service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateMemberAccount">REST API Reference for AssociateMemberAccount Operation</seealso>
        AssociateMemberAccountResponse AssociateMemberAccount(AssociateMemberAccountRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateMemberAccount">REST API Reference for AssociateMemberAccount Operation</seealso>
        Task<AssociateMemberAccountResponse> AssociateMemberAccountAsync(AssociateMemberAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateS3Resources


        /// <summary>
        /// Associates specified S3 resources with Amazon Macie for monitoring and data classification.
        /// If memberAccountId isn't specified, the action associates specified S3 resources with
        /// Macie for the current master account. If memberAccountId is specified, the action
        /// associates specified S3 resources with Macie for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateS3Resources service method.</param>
        /// 
        /// <returns>The response from the AssociateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateS3Resources">REST API Reference for AssociateS3Resources Operation</seealso>
        AssociateS3ResourcesResponse AssociateS3Resources(AssociateS3ResourcesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateS3Resources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateS3Resources">REST API Reference for AssociateS3Resources Operation</seealso>
        Task<AssociateS3ResourcesResponse> AssociateS3ResourcesAsync(AssociateS3ResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateMemberAccount


        /// <summary>
        /// Removes the specified member account from Amazon Macie.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberAccount service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateMemberAccount">REST API Reference for DisassociateMemberAccount Operation</seealso>
        DisassociateMemberAccountResponse DisassociateMemberAccount(DisassociateMemberAccountRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateMemberAccount">REST API Reference for DisassociateMemberAccount Operation</seealso>
        Task<DisassociateMemberAccountResponse> DisassociateMemberAccountAsync(DisassociateMemberAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateS3Resources


        /// <summary>
        /// Removes specified S3 resources from being monitored by Amazon Macie. If memberAccountId
        /// isn't specified, the action removes specified S3 resources from Macie for the current
        /// master account. If memberAccountId is specified, the action removes specified S3 resources
        /// from Macie for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateS3Resources service method.</param>
        /// 
        /// <returns>The response from the DisassociateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateS3Resources">REST API Reference for DisassociateS3Resources Operation</seealso>
        DisassociateS3ResourcesResponse DisassociateS3Resources(DisassociateS3ResourcesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateS3Resources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateS3Resources">REST API Reference for DisassociateS3Resources Operation</seealso>
        Task<DisassociateS3ResourcesResponse> DisassociateS3ResourcesAsync(DisassociateS3ResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMemberAccounts


        /// <summary>
        /// Lists all Amazon Macie member accounts for the current Amazon Macie master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
        /// 
        /// <returns>The response from the ListMemberAccounts service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        ListMemberAccountsResponse ListMemberAccounts(ListMemberAccountsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListMemberAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        Task<ListMemberAccountsResponse> ListMemberAccountsAsync(ListMemberAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListS3Resources


        /// <summary>
        /// Lists all the S3 resources associated with Amazon Macie. If memberAccountId isn't
        /// specified, the action lists the S3 resources associated with Amazon Macie for the
        /// current master account. If memberAccountId is specified, the action lists the S3 resources
        /// associated with Amazon Macie for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3Resources service method.</param>
        /// 
        /// <returns>The response from the ListS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListS3Resources">REST API Reference for ListS3Resources Operation</seealso>
        ListS3ResourcesResponse ListS3Resources(ListS3ResourcesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListS3Resources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListS3Resources">REST API Reference for ListS3Resources Operation</seealso>
        Task<ListS3ResourcesResponse> ListS3ResourcesAsync(ListS3ResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateS3Resources


        /// <summary>
        /// Updates the classification types for the specified S3 resources. If memberAccountId
        /// isn't specified, the action updates the classification types of the S3 resources associated
        /// with Amazon Macie for the current master account. If memberAccountId is specified,
        /// the action updates the classification types of the S3 resources associated with Amazon
        /// Macie for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateS3Resources service method.</param>
        /// 
        /// <returns>The response from the UpdateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/UpdateS3Resources">REST API Reference for UpdateS3Resources Operation</seealso>
        UpdateS3ResourcesResponse UpdateS3Resources(UpdateS3ResourcesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateS3Resources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/UpdateS3Resources">REST API Reference for UpdateS3Resources Operation</seealso>
        Task<UpdateS3ResourcesResponse> UpdateS3ResourcesAsync(UpdateS3ResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}