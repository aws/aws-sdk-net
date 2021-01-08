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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Macie2.Model;

namespace Amazon.Macie2
{
    /// <summary>
    /// Interface for accessing Macie2
    ///
    /// Amazon Macie is a fully managed data security and data privacy service that uses machine
    /// learning and pattern matching to discover and protect your sensitive data in AWS.
    /// Macie automates the discovery of sensitive data, such as PII and intellectual property,
    /// to provide you with insight into the data that your organization stores in AWS. Macie
    /// also provides an inventory of your Amazon S3 buckets, which it continually monitors
    /// for you. If Macie detects sensitive data or potential data access issues, it generates
    /// detailed findings for you to review and act upon as necessary.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonMacie2 : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMacie2PaginatorFactory Paginators { get; }
#endif
                
        #region  AcceptInvitation



        /// <summary>
        /// Accepts an Amazon Macie membership invitation that was received from a specific account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        Task<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetCustomDataIdentifiers



        /// <summary>
        /// Retrieves information about one or more custom data identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCustomDataIdentifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCustomDataIdentifiers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/BatchGetCustomDataIdentifiers">REST API Reference for BatchGetCustomDataIdentifiers Operation</seealso>
        Task<BatchGetCustomDataIdentifiersResponse> BatchGetCustomDataIdentifiersAsync(BatchGetCustomDataIdentifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateClassificationJob



        /// <summary>
        /// Creates and defines the settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateClassificationJob">REST API Reference for CreateClassificationJob Operation</seealso>
        Task<CreateClassificationJobResponse> CreateClassificationJobAsync(CreateClassificationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomDataIdentifier



        /// <summary>
        /// Creates and defines the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateCustomDataIdentifier">REST API Reference for CreateCustomDataIdentifier Operation</seealso>
        Task<CreateCustomDataIdentifierResponse> CreateCustomDataIdentifierAsync(CreateCustomDataIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFindingsFilter



        /// <summary>
        /// Creates and defines the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateFindingsFilter">REST API Reference for CreateFindingsFilter Operation</seealso>
        Task<CreateFindingsFilterResponse> CreateFindingsFilterAsync(CreateFindingsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInvitations



        /// <summary>
        /// Sends an Amazon Macie membership invitation to one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateInvitations">REST API Reference for CreateInvitations Operation</seealso>
        Task<CreateInvitationsResponse> CreateInvitationsAsync(CreateInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMember



        /// <summary>
        /// Associates an account with an Amazon Macie master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateMember">REST API Reference for CreateMember Operation</seealso>
        Task<CreateMemberResponse> CreateMemberAsync(CreateMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSampleFindings



        /// <summary>
        /// Creates sample findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSampleFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        Task<CreateSampleFindingsResponse> CreateSampleFindingsAsync(CreateSampleFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeclineInvitations



        /// <summary>
        /// Declines Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        Task<DeclineInvitationsResponse> DeclineInvitationsAsync(DeclineInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomDataIdentifier



        /// <summary>
        /// Soft deletes a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteCustomDataIdentifier">REST API Reference for DeleteCustomDataIdentifier Operation</seealso>
        Task<DeleteCustomDataIdentifierResponse> DeleteCustomDataIdentifierAsync(DeleteCustomDataIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFindingsFilter



        /// <summary>
        /// Deletes a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteFindingsFilter">REST API Reference for DeleteFindingsFilter Operation</seealso>
        Task<DeleteFindingsFilterResponse> DeleteFindingsFilterAsync(DeleteFindingsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInvitations



        /// <summary>
        /// Deletes Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        Task<DeleteInvitationsResponse> DeleteInvitationsAsync(DeleteInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMember



        /// <summary>
        /// Deletes the association between an Amazon Macie master account and an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBuckets



        /// <summary>
        /// Retrieves (queries) statistical data and other information about one or more S3 buckets
        /// that Amazon Macie monitors and analyzes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuckets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBuckets service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeBuckets">REST API Reference for DescribeBuckets Operation</seealso>
        Task<DescribeBucketsResponse> DescribeBucketsAsync(DescribeBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClassificationJob



        /// <summary>
        /// Retrieves the status and settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeClassificationJob">REST API Reference for DescribeClassificationJob Operation</seealso>
        Task<DescribeClassificationJobResponse> DescribeClassificationJobAsync(DescribeClassificationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOrganizationConfiguration



        /// <summary>
        /// Retrieves the Amazon Macie configuration settings for an AWS organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        Task<DescribeOrganizationConfigurationResponse> DescribeOrganizationConfigurationAsync(DescribeOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableMacie



        /// <summary>
        /// Disables an Amazon Macie account and deletes Macie resources for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMacie service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableMacie service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableMacie">REST API Reference for DisableMacie Operation</seealso>
        Task<DisableMacieResponse> DisableMacieAsync(DisableMacieRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableOrganizationAdminAccount



        /// <summary>
        /// Disables an account as the delegated Amazon Macie administrator account for an AWS
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableOrganizationAdminAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        Task<DisableOrganizationAdminAccountResponse> DisableOrganizationAdminAccountAsync(DisableOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateFromMasterAccount



        /// <summary>
        /// Disassociates a member account from its Amazon Macie master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        Task<DisassociateFromMasterAccountResponse> DisassociateFromMasterAccountAsync(DisassociateFromMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateMember



        /// <summary>
        /// Disassociates an Amazon Macie master account from a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        Task<DisassociateMemberResponse> DisassociateMemberAsync(DisassociateMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableMacie



        /// <summary>
        /// Enables Amazon Macie and specifies the configuration settings for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMacie service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableMacie service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableMacie">REST API Reference for EnableMacie Operation</seealso>
        Task<EnableMacieResponse> EnableMacieAsync(EnableMacieRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableOrganizationAdminAccount



        /// <summary>
        /// Designates an account as the delegated Amazon Macie administrator account for an AWS
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableOrganizationAdminAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        Task<EnableOrganizationAdminAccountResponse> EnableOrganizationAdminAccountAsync(EnableOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBucketStatistics



        /// <summary>
        /// Retrieves (queries) aggregated statistical data for all the S3 buckets that Amazon
        /// Macie monitors and analyzes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetBucketStatistics">REST API Reference for GetBucketStatistics Operation</seealso>
        Task<GetBucketStatisticsResponse> GetBucketStatisticsAsync(GetBucketStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetClassificationExportConfiguration



        /// <summary>
        /// Retrieves the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationExportConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClassificationExportConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationExportConfiguration">REST API Reference for GetClassificationExportConfiguration Operation</seealso>
        Task<GetClassificationExportConfigurationResponse> GetClassificationExportConfigurationAsync(GetClassificationExportConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCustomDataIdentifier



        /// <summary>
        /// Retrieves the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetCustomDataIdentifier">REST API Reference for GetCustomDataIdentifier Operation</seealso>
        Task<GetCustomDataIdentifierResponse> GetCustomDataIdentifierAsync(GetCustomDataIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFindings



        /// <summary>
        /// Retrieves the details of one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindings">REST API Reference for GetFindings Operation</seealso>
        Task<GetFindingsResponse> GetFindingsAsync(GetFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFindingsFilter



        /// <summary>
        /// Retrieves the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsFilter">REST API Reference for GetFindingsFilter Operation</seealso>
        Task<GetFindingsFilterResponse> GetFindingsFilterAsync(GetFindingsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFindingStatistics



        /// <summary>
        /// Retrieves (queries) aggregated statistical data about findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingStatistics">REST API Reference for GetFindingStatistics Operation</seealso>
        Task<GetFindingStatisticsResponse> GetFindingStatisticsAsync(GetFindingStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInvitationsCount



        /// <summary>
        /// Retrieves the count of Amazon Macie membership invitations that were received by an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        Task<GetInvitationsCountResponse> GetInvitationsCountAsync(GetInvitationsCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMacieSession



        /// <summary>
        /// Retrieves the current status and configuration settings for an Amazon Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMacieSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMacieSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMacieSession">REST API Reference for GetMacieSession Operation</seealso>
        Task<GetMacieSessionResponse> GetMacieSessionAsync(GetMacieSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMasterAccount



        /// <summary>
        /// Retrieves information about the Amazon Macie master account for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        Task<GetMasterAccountResponse> GetMasterAccountAsync(GetMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMember



        /// <summary>
        /// Retrieves information about a member account that's associated with an Amazon Macie
        /// master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMember">REST API Reference for GetMember Operation</seealso>
        Task<GetMemberResponse> GetMemberAsync(GetMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUsageStatistics



        /// <summary>
        /// Retrieves (queries) quotas and aggregated usage data for one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsageStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageStatistics">REST API Reference for GetUsageStatistics Operation</seealso>
        Task<GetUsageStatisticsResponse> GetUsageStatisticsAsync(GetUsageStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUsageTotals



        /// <summary>
        /// Retrieves (queries) aggregated usage data for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageTotals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsageTotals service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageTotals">REST API Reference for GetUsageTotals Operation</seealso>
        Task<GetUsageTotalsResponse> GetUsageTotalsAsync(GetUsageTotalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListClassificationJobs



        /// <summary>
        /// Retrieves a subset of information about one or more classification jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClassificationJobs service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationJobs">REST API Reference for ListClassificationJobs Operation</seealso>
        Task<ListClassificationJobsResponse> ListClassificationJobsAsync(ListClassificationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCustomDataIdentifiers



        /// <summary>
        /// Retrieves a subset of information about all the custom data identifiers for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomDataIdentifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomDataIdentifiers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListCustomDataIdentifiers">REST API Reference for ListCustomDataIdentifiers Operation</seealso>
        Task<ListCustomDataIdentifiersResponse> ListCustomDataIdentifiersAsync(ListCustomDataIdentifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFindings



        /// <summary>
        /// Retrieves a subset of information about one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindings">REST API Reference for ListFindings Operation</seealso>
        Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFindingsFilters



        /// <summary>
        /// Retrieves a subset of information about all the findings filters for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindingsFilters service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindingsFilters">REST API Reference for ListFindingsFilters Operation</seealso>
        Task<ListFindingsFiltersResponse> ListFindingsFiltersAsync(ListFindingsFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInvitations



        /// <summary>
        /// Retrieves information about all the Amazon Macie membership invitations that were
        /// received by an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMembers



        /// <summary>
        /// Retrieves information about the accounts that are associated with an Amazon Macie
        /// master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListMembers">REST API Reference for ListMembers Operation</seealso>
        Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOrganizationAdminAccounts



        /// <summary>
        /// Retrieves information about the delegated Amazon Macie administrator account for an
        /// AWS organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationAdminAccounts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        Task<ListOrganizationAdminAccountsResponse> ListOrganizationAdminAccountsAsync(ListOrganizationAdminAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Retrieves the tags (keys and values) that are associated with a classification job,
        /// custom data identifier, findings filter, or member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutClassificationExportConfiguration



        /// <summary>
        /// Creates or updates the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClassificationExportConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutClassificationExportConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutClassificationExportConfiguration">REST API Reference for PutClassificationExportConfiguration Operation</seealso>
        Task<PutClassificationExportConfigurationResponse> PutClassificationExportConfigurationAsync(PutClassificationExportConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or updates one or more tags (keys and values) that are associated with a classification
        /// job, custom data identifier, findings filter, or member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestCustomDataIdentifier



        /// <summary>
        /// Tests a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TestCustomDataIdentifier">REST API Reference for TestCustomDataIdentifier Operation</seealso>
        Task<TestCustomDataIdentifierResponse> TestCustomDataIdentifierAsync(TestCustomDataIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags (keys and values) from a classification job, custom data
        /// identifier, findings filter, or member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateClassificationJob



        /// <summary>
        /// Changes the status of a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationJob">REST API Reference for UpdateClassificationJob Operation</seealso>
        Task<UpdateClassificationJobResponse> UpdateClassificationJobAsync(UpdateClassificationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFindingsFilter



        /// <summary>
        /// Updates the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateFindingsFilter">REST API Reference for UpdateFindingsFilter Operation</seealso>
        Task<UpdateFindingsFilterResponse> UpdateFindingsFilterAsync(UpdateFindingsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMacieSession



        /// <summary>
        /// Suspends or re-enables an Amazon Macie account, or updates the configuration settings
        /// for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMacieSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMacieSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMacieSession">REST API Reference for UpdateMacieSession Operation</seealso>
        Task<UpdateMacieSessionResponse> UpdateMacieSessionAsync(UpdateMacieSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMemberSession



        /// <summary>
        /// Enables an Amazon Macie master account to suspend or re-enable a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemberSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMemberSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMemberSession">REST API Reference for UpdateMemberSession Operation</seealso>
        Task<UpdateMemberSessionResponse> UpdateMemberSessionAsync(UpdateMemberSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateOrganizationConfiguration



        /// <summary>
        /// Updates the Amazon Macie configuration settings for an AWS organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        Task<UpdateOrganizationConfigurationResponse> UpdateOrganizationConfigurationAsync(UpdateOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}