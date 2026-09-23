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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Macie2.Model;

#pragma warning disable CS1570

namespace Amazon.Macie2
{
    /// <summary>
    /// <para>Interface for accessing Macie2</para>
    ///
    /// Amazon Macie
    /// </summary>
    public partial interface IAmazonMacie2 : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMacie2PaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Accepts an Amazon Macie membership invitation that was received from a specific account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
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
        AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request);
#endif

        /// <summary>
        /// Accepts an Amazon Macie membership invitation that was received from a specific account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about one or more custom data identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCustomDataIdentifiers service method.</param>
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
        BatchGetCustomDataIdentifiersResponse BatchGetCustomDataIdentifiers(BatchGetCustomDataIdentifiersRequest request);
#endif

        /// <summary>
        /// Retrieves information about one or more custom data identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCustomDataIdentifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchGetCustomDataIdentifiersResponse> BatchGetCustomDataIdentifiersAsync(BatchGetCustomDataIdentifiersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Changes the status of automated sensitive data discovery for one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateAutomatedDiscoveryAccounts service method.</param>
        /// <returns>The response from the BatchUpdateAutomatedDiscoveryAccounts service method, as returned by Macie2.</returns>
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
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/BatchUpdateAutomatedDiscoveryAccounts">REST API Reference for BatchUpdateAutomatedDiscoveryAccounts Operation</seealso>
        BatchUpdateAutomatedDiscoveryAccountsResponse BatchUpdateAutomatedDiscoveryAccounts(BatchUpdateAutomatedDiscoveryAccountsRequest request);
#endif

        /// <summary>
        /// Changes the status of automated sensitive data discovery for one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateAutomatedDiscoveryAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the BatchUpdateAutomatedDiscoveryAccounts service method, as returned by Macie2.</returns>
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
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/BatchUpdateAutomatedDiscoveryAccounts">REST API Reference for BatchUpdateAutomatedDiscoveryAccounts Operation</seealso>
        Task<BatchUpdateAutomatedDiscoveryAccountsResponse> BatchUpdateAutomatedDiscoveryAccountsAsync(BatchUpdateAutomatedDiscoveryAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates and defines the settings for an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAllowList service method.</param>
        /// <returns>The response from the CreateAllowList service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateAllowList">REST API Reference for CreateAllowList Operation</seealso>
        CreateAllowListResponse CreateAllowList(CreateAllowListRequest request);
#endif

        /// <summary>
        /// Creates and defines the settings for an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAllowList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAllowList service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateAllowList">REST API Reference for CreateAllowList Operation</seealso>
        Task<CreateAllowListResponse> CreateAllowListAsync(CreateAllowListRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates and defines the settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClassificationJob service method.</param>
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
        CreateClassificationJobResponse CreateClassificationJob(CreateClassificationJobRequest request);
#endif

        /// <summary>
        /// Creates and defines the settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateClassificationJobResponse> CreateClassificationJobAsync(CreateClassificationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates and defines the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDataIdentifier service method.</param>
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
        CreateCustomDataIdentifierResponse CreateCustomDataIdentifier(CreateCustomDataIdentifierRequest request);
#endif

        /// <summary>
        /// Creates and defines the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateCustomDataIdentifierResponse> CreateCustomDataIdentifierAsync(CreateCustomDataIdentifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates and defines the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsFilter service method.</param>
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
        CreateFindingsFilterResponse CreateFindingsFilter(CreateFindingsFilterRequest request);
#endif

        /// <summary>
        /// Creates and defines the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateFindingsFilterResponse> CreateFindingsFilterAsync(CreateFindingsFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Sends an Amazon Macie membership invitation to one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvitations service method.</param>
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
        CreateInvitationsResponse CreateInvitations(CreateInvitationsRequest request);
#endif

        /// <summary>
        /// Sends an Amazon Macie membership invitation to one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateInvitationsResponse> CreateInvitationsAsync(CreateInvitationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Associates an account with an Amazon Macie administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMember service method.</param>
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
        CreateMemberResponse CreateMember(CreateMemberRequest request);
#endif

        /// <summary>
        /// Associates an account with an Amazon Macie administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateMemberResponse> CreateMemberAsync(CreateMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates sample findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
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
        CreateSampleFindingsResponse CreateSampleFindings(CreateSampleFindingsRequest request);
#endif

        /// <summary>
        /// Creates sample findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSampleFindingsResponse> CreateSampleFindingsAsync(CreateSampleFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Declines Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
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
        DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request);
#endif

        /// <summary>
        /// Declines Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeclineInvitationsResponse> DeclineInvitationsAsync(DeclineInvitationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAllowList service method.</param>
        /// <returns>The response from the DeleteAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteAllowList">REST API Reference for DeleteAllowList Operation</seealso>
        DeleteAllowListResponse DeleteAllowList(DeleteAllowListRequest request);
#endif

        /// <summary>
        /// Deletes an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAllowList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteAllowList">REST API Reference for DeleteAllowList Operation</seealso>
        Task<DeleteAllowListResponse> DeleteAllowListAsync(DeleteAllowListRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Soft deletes a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDataIdentifier service method.</param>
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
        DeleteCustomDataIdentifierResponse DeleteCustomDataIdentifier(DeleteCustomDataIdentifierRequest request);
#endif

        /// <summary>
        /// Soft deletes a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteCustomDataIdentifierResponse> DeleteCustomDataIdentifierAsync(DeleteCustomDataIdentifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFindingsFilter service method.</param>
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
        DeleteFindingsFilterResponse DeleteFindingsFilter(DeleteFindingsFilterRequest request);
#endif

        /// <summary>
        /// Deletes a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteFindingsFilterResponse> DeleteFindingsFilterAsync(DeleteFindingsFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
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
        DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request);
#endif

        /// <summary>
        /// Deletes Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteInvitationsResponse> DeleteInvitationsAsync(DeleteInvitationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the association between an Amazon Macie administrator account and an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
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
        DeleteMemberResponse DeleteMember(DeleteMemberRequest request);
#endif

        /// <summary>
        /// Deletes the association between an Amazon Macie administrator account and an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves (queries) statistical data and other information about one or more S3 buckets
        /// that Amazon Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuckets service method.</param>
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
        DescribeBucketsResponse DescribeBuckets(DescribeBucketsRequest request);
#endif

        /// <summary>
        /// Retrieves (queries) statistical data and other information about one or more S3 buckets
        /// that Amazon Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuckets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBucketsResponse> DescribeBucketsAsync(DescribeBucketsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the status and settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassificationJob service method.</param>
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
        DescribeClassificationJobResponse DescribeClassificationJob(DescribeClassificationJobRequest request);
#endif

        /// <summary>
        /// Retrieves the status and settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeClassificationJobResponse> DescribeClassificationJobAsync(DescribeClassificationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the Amazon Macie configuration settings for an organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
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
        DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request);
#endif

        /// <summary>
        /// Retrieves the Amazon Macie configuration settings for an organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeOrganizationConfigurationResponse> DescribeOrganizationConfigurationAsync(DescribeOrganizationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disables Amazon Macie and deletes all settings and resources for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMacie service method.</param>
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
        DisableMacieResponse DisableMacie(DisableMacieRequest request);
#endif

        /// <summary>
        /// Disables Amazon Macie and deletes all settings and resources for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMacie service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisableMacieResponse> DisableMacieAsync(DisableMacieRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disables an account as the delegated Amazon Macie administrator account for an organization
        /// in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
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
        DisableOrganizationAdminAccountResponse DisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request);
#endif

        /// <summary>
        /// Disables an account as the delegated Amazon Macie administrator account for an organization
        /// in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisableOrganizationAdminAccountResponse> DisableOrganizationAdminAccountAsync(DisableOrganizationAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disassociates a member account from its Amazon Macie administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount service method.</param>
        /// <returns>The response from the DisassociateFromAdministratorAccount service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        DisassociateFromAdministratorAccountResponse DisassociateFromAdministratorAccount(DisassociateFromAdministratorAccountRequest request);
#endif

        /// <summary>
        /// Disassociates a member account from its Amazon Macie administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateFromAdministratorAccount service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        Task<DisassociateFromAdministratorAccountResponse> DisassociateFromAdministratorAccountAsync(DisassociateFromAdministratorAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// (Deprecated) Disassociates a member account from its Amazon Macie administrator account.
        /// This operation has been replaced by the <link linkend="DisassociateFromAdministratorAccount">DisassociateFromAdministratorAccount</link>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
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
        DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request);
#endif

        /// <summary>
        /// (Deprecated) Disassociates a member account from its Amazon Macie administrator account.
        /// This operation has been replaced by the <link linkend="DisassociateFromAdministratorAccount">DisassociateFromAdministratorAccount</link>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateFromMasterAccountResponse> DisassociateFromMasterAccountAsync(DisassociateFromMasterAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disassociates an Amazon Macie administrator account from a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
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
        DisassociateMemberResponse DisassociateMember(DisassociateMemberRequest request);
#endif

        /// <summary>
        /// Disassociates an Amazon Macie administrator account from a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateMemberResponse> DisassociateMemberAsync(DisassociateMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Enables Amazon Macie and specifies the configuration settings for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMacie service method.</param>
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
        EnableMacieResponse EnableMacie(EnableMacieRequest request);
#endif

        /// <summary>
        /// Enables Amazon Macie and specifies the configuration settings for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMacie service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<EnableMacieResponse> EnableMacieAsync(EnableMacieRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Designates an account as the delegated Amazon Macie administrator account for an organization
        /// in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
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
        EnableOrganizationAdminAccountResponse EnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request);
#endif

        /// <summary>
        /// Designates an account as the delegated Amazon Macie administrator account for an organization
        /// in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<EnableOrganizationAdminAccountResponse> EnableOrganizationAdminAccountAsync(EnableOrganizationAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the Amazon Macie administrator account for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount service method.</param>
        /// <returns>The response from the GetAdministratorAccount service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        GetAdministratorAccountResponse GetAdministratorAccount(GetAdministratorAccountRequest request);
#endif

        /// <summary>
        /// Retrieves information about the Amazon Macie administrator account for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAdministratorAccount service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        Task<GetAdministratorAccountResponse> GetAdministratorAccountAsync(GetAdministratorAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the settings and status of an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAllowList service method.</param>
        /// <returns>The response from the GetAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAllowList">REST API Reference for GetAllowList Operation</seealso>
        GetAllowListResponse GetAllowList(GetAllowListRequest request);
#endif

        /// <summary>
        /// Retrieves the settings and status of an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAllowList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAllowList">REST API Reference for GetAllowList Operation</seealso>
        Task<GetAllowListResponse> GetAllowListAsync(GetAllowListRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the configuration settings and status of automated sensitive data discovery
        /// for an organization or standalone account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedDiscoveryConfiguration service method.</param>
        /// <returns>The response from the GetAutomatedDiscoveryConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAutomatedDiscoveryConfiguration">REST API Reference for GetAutomatedDiscoveryConfiguration Operation</seealso>
        GetAutomatedDiscoveryConfigurationResponse GetAutomatedDiscoveryConfiguration(GetAutomatedDiscoveryConfigurationRequest request);
#endif

        /// <summary>
        /// Retrieves the configuration settings and status of automated sensitive data discovery
        /// for an organization or standalone account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAutomatedDiscoveryConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAutomatedDiscoveryConfiguration">REST API Reference for GetAutomatedDiscoveryConfiguration Operation</seealso>
        Task<GetAutomatedDiscoveryConfigurationResponse> GetAutomatedDiscoveryConfigurationAsync(GetAutomatedDiscoveryConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves (queries) aggregated statistical data about all the S3 buckets that Amazon
        /// Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketStatistics service method.</param>
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
        GetBucketStatisticsResponse GetBucketStatistics(GetBucketStatisticsRequest request);
#endif

        /// <summary>
        /// Retrieves (queries) aggregated statistical data about all the S3 buckets that Amazon
        /// Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetBucketStatisticsResponse> GetBucketStatisticsAsync(GetBucketStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationExportConfiguration service method.</param>
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
        GetClassificationExportConfigurationResponse GetClassificationExportConfiguration(GetClassificationExportConfigurationRequest request);
#endif

        /// <summary>
        /// Retrieves the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationExportConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetClassificationExportConfigurationResponse> GetClassificationExportConfigurationAsync(GetClassificationExportConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the classification scope settings for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationScope service method.</param>
        /// <returns>The response from the GetClassificationScope service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationScope">REST API Reference for GetClassificationScope Operation</seealso>
        GetClassificationScopeResponse GetClassificationScope(GetClassificationScopeRequest request);
#endif

        /// <summary>
        /// Retrieves the classification scope settings for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetClassificationScope service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationScope">REST API Reference for GetClassificationScope Operation</seealso>
        Task<GetClassificationScopeResponse> GetClassificationScopeAsync(GetClassificationScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomDataIdentifier service method.</param>
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
        GetCustomDataIdentifierResponse GetCustomDataIdentifier(GetCustomDataIdentifierRequest request);
#endif

        /// <summary>
        /// Retrieves the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetCustomDataIdentifierResponse> GetCustomDataIdentifierAsync(GetCustomDataIdentifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves (queries) aggregated statistical data about findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingStatistics service method.</param>
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
        GetFindingStatisticsResponse GetFindingStatistics(GetFindingStatisticsRequest request);
#endif

        /// <summary>
        /// Retrieves (queries) aggregated statistical data about findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetFindingStatisticsResponse> GetFindingStatisticsAsync(GetFindingStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the details of one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
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
        GetFindingsResponse GetFindings(GetFindingsRequest request);
#endif

        /// <summary>
        /// Retrieves the details of one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetFindingsResponse> GetFindingsAsync(GetFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsFilter service method.</param>
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
        GetFindingsFilterResponse GetFindingsFilter(GetFindingsFilterRequest request);
#endif

        /// <summary>
        /// Retrieves the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetFindingsFilterResponse> GetFindingsFilterAsync(GetFindingsFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the configuration settings for publishing findings to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsPublicationConfiguration service method.</param>
        /// <returns>The response from the GetFindingsPublicationConfiguration service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsPublicationConfiguration">REST API Reference for GetFindingsPublicationConfiguration Operation</seealso>
        GetFindingsPublicationConfigurationResponse GetFindingsPublicationConfiguration(GetFindingsPublicationConfigurationRequest request);
#endif

        /// <summary>
        /// Retrieves the configuration settings for publishing findings to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsPublicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetFindingsPublicationConfiguration service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsPublicationConfiguration">REST API Reference for GetFindingsPublicationConfiguration Operation</seealso>
        Task<GetFindingsPublicationConfigurationResponse> GetFindingsPublicationConfigurationAsync(GetFindingsPublicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the count of Amazon Macie membership invitations that were received by an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
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
        GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request);
#endif

        /// <summary>
        /// Retrieves the count of Amazon Macie membership invitations that were received by an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetInvitationsCountResponse> GetInvitationsCountAsync(GetInvitationsCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the status and configuration settings for an Amazon Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMacieSession service method.</param>
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
        GetMacieSessionResponse GetMacieSession(GetMacieSessionRequest request);
#endif

        /// <summary>
        /// Retrieves the status and configuration settings for an Amazon Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMacieSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetMacieSessionResponse> GetMacieSessionAsync(GetMacieSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// (Deprecated) Retrieves information about the Amazon Macie administrator account for
        /// an account. This operation has been replaced by the <link linkend="GetAdministratorAccount">GetAdministratorAccount</link>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
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
        GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request);
#endif

        /// <summary>
        /// (Deprecated) Retrieves information about the Amazon Macie administrator account for
        /// an account. This operation has been replaced by the <link linkend="GetAdministratorAccount">GetAdministratorAccount</link>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetMasterAccountResponse> GetMasterAccountAsync(GetMasterAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about an account that's associated with an Amazon Macie administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
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
        GetMemberResponse GetMember(GetMemberRequest request);
#endif

        /// <summary>
        /// Retrieves information about an account that's associated with an Amazon Macie administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetMemberResponse> GetMemberAsync(GetMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves (queries) sensitive data discovery statistics and the sensitivity score
        /// for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceProfile service method.</param>
        /// <returns>The response from the GetResourceProfile service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetResourceProfile">REST API Reference for GetResourceProfile Operation</seealso>
        GetResourceProfileResponse GetResourceProfile(GetResourceProfileRequest request);
#endif

        /// <summary>
        /// Retrieves (queries) sensitive data discovery statistics and the sensitivity score
        /// for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetResourceProfile service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetResourceProfile">REST API Reference for GetResourceProfile Operation</seealso>
        Task<GetResourceProfileResponse> GetResourceProfileAsync(GetResourceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the status and configuration settings for retrieving occurrences of sensitive
        /// data reported by findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevealConfiguration service method.</param>
        /// <returns>The response from the GetRevealConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetRevealConfiguration">REST API Reference for GetRevealConfiguration Operation</seealso>
        GetRevealConfigurationResponse GetRevealConfiguration(GetRevealConfigurationRequest request);
#endif

        /// <summary>
        /// Retrieves the status and configuration settings for retrieving occurrences of sensitive
        /// data reported by findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevealConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRevealConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetRevealConfiguration">REST API Reference for GetRevealConfiguration Operation</seealso>
        Task<GetRevealConfigurationResponse> GetRevealConfigurationAsync(GetRevealConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves occurrences of sensitive data reported by a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrences service method.</param>
        /// <returns>The response from the GetSensitiveDataOccurrences service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
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
        /// <exception cref="Amazon.Macie2.Model.UnprocessableEntityException">
        /// Provides information about an error that occurred due to an unprocessable entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrences">REST API Reference for GetSensitiveDataOccurrences Operation</seealso>
        GetSensitiveDataOccurrencesResponse GetSensitiveDataOccurrences(GetSensitiveDataOccurrencesRequest request);
#endif

        /// <summary>
        /// Retrieves occurrences of sensitive data reported by a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetSensitiveDataOccurrences service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
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
        /// <exception cref="Amazon.Macie2.Model.UnprocessableEntityException">
        /// Provides information about an error that occurred due to an unprocessable entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrences">REST API Reference for GetSensitiveDataOccurrences Operation</seealso>
        Task<GetSensitiveDataOccurrencesResponse> GetSensitiveDataOccurrencesAsync(GetSensitiveDataOccurrencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Checks whether occurrences of sensitive data can be retrieved for a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrencesAvailability service method.</param>
        /// <returns>The response from the GetSensitiveDataOccurrencesAvailability service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrencesAvailability">REST API Reference for GetSensitiveDataOccurrencesAvailability Operation</seealso>
        GetSensitiveDataOccurrencesAvailabilityResponse GetSensitiveDataOccurrencesAvailability(GetSensitiveDataOccurrencesAvailabilityRequest request);
#endif

        /// <summary>
        /// Checks whether occurrences of sensitive data can be retrieved for a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrencesAvailability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetSensitiveDataOccurrencesAvailability service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrencesAvailability">REST API Reference for GetSensitiveDataOccurrencesAvailability Operation</seealso>
        Task<GetSensitiveDataOccurrencesAvailabilityResponse> GetSensitiveDataOccurrencesAvailabilityAsync(GetSensitiveDataOccurrencesAvailabilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the settings for the sensitivity inspection template for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitivityInspectionTemplate service method.</param>
        /// <returns>The response from the GetSensitivityInspectionTemplate service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitivityInspectionTemplate">REST API Reference for GetSensitivityInspectionTemplate Operation</seealso>
        GetSensitivityInspectionTemplateResponse GetSensitivityInspectionTemplate(GetSensitivityInspectionTemplateRequest request);
#endif

        /// <summary>
        /// Retrieves the settings for the sensitivity inspection template for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitivityInspectionTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetSensitivityInspectionTemplate service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitivityInspectionTemplate">REST API Reference for GetSensitivityInspectionTemplate Operation</seealso>
        Task<GetSensitivityInspectionTemplateResponse> GetSensitivityInspectionTemplateAsync(GetSensitivityInspectionTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves (queries) quotas and aggregated usage data for one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageStatistics service method.</param>
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
        GetUsageStatisticsResponse GetUsageStatistics(GetUsageStatisticsRequest request);
#endif

        /// <summary>
        /// Retrieves (queries) quotas and aggregated usage data for one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetUsageStatisticsResponse> GetUsageStatisticsAsync(GetUsageStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves (queries) aggregated usage data for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageTotals service method.</param>
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
        GetUsageTotalsResponse GetUsageTotals(GetUsageTotalsRequest request);
#endif

        /// <summary>
        /// Retrieves (queries) aggregated usage data for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageTotals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetUsageTotalsResponse> GetUsageTotalsAsync(GetUsageTotalsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a subset of information about all the allow lists for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowLists service method.</param>
        /// <returns>The response from the ListAllowLists service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListAllowLists">REST API Reference for ListAllowLists Operation</seealso>
        ListAllowListsResponse ListAllowLists(ListAllowListsRequest request);
#endif

        /// <summary>
        /// Retrieves a subset of information about all the allow lists for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAllowLists service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListAllowLists">REST API Reference for ListAllowLists Operation</seealso>
        Task<ListAllowListsResponse> ListAllowListsAsync(ListAllowListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the status of automated sensitive data discovery for one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedDiscoveryAccounts service method.</param>
        /// <returns>The response from the ListAutomatedDiscoveryAccounts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListAutomatedDiscoveryAccounts">REST API Reference for ListAutomatedDiscoveryAccounts Operation</seealso>
        ListAutomatedDiscoveryAccountsResponse ListAutomatedDiscoveryAccounts(ListAutomatedDiscoveryAccountsRequest request);
#endif

        /// <summary>
        /// Retrieves the status of automated sensitive data discovery for one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedDiscoveryAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAutomatedDiscoveryAccounts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListAutomatedDiscoveryAccounts">REST API Reference for ListAutomatedDiscoveryAccounts Operation</seealso>
        Task<ListAutomatedDiscoveryAccountsResponse> ListAutomatedDiscoveryAccountsAsync(ListAutomatedDiscoveryAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a subset of information about one or more classification jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationJobs service method.</param>
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
        ListClassificationJobsResponse ListClassificationJobs(ListClassificationJobsRequest request);
#endif

        /// <summary>
        /// Retrieves a subset of information about one or more classification jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListClassificationJobsResponse> ListClassificationJobsAsync(ListClassificationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a subset of information about the classification scope for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationScopes service method.</param>
        /// <returns>The response from the ListClassificationScopes service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationScopes">REST API Reference for ListClassificationScopes Operation</seealso>
        ListClassificationScopesResponse ListClassificationScopes(ListClassificationScopesRequest request);
#endif

        /// <summary>
        /// Retrieves a subset of information about the classification scope for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationScopes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListClassificationScopes service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationScopes">REST API Reference for ListClassificationScopes Operation</seealso>
        Task<ListClassificationScopesResponse> ListClassificationScopesAsync(ListClassificationScopesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a subset of information about the custom data identifiers for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomDataIdentifiers service method.</param>
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
        ListCustomDataIdentifiersResponse ListCustomDataIdentifiers(ListCustomDataIdentifiersRequest request);
#endif

        /// <summary>
        /// Retrieves a subset of information about the custom data identifiers for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomDataIdentifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListCustomDataIdentifiersResponse> ListCustomDataIdentifiersAsync(ListCustomDataIdentifiersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a subset of information about one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
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
        ListFindingsResponse ListFindings(ListFindingsRequest request);
#endif

        /// <summary>
        /// Retrieves a subset of information about one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a subset of information about all the findings filters for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsFilters service method.</param>
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
        ListFindingsFiltersResponse ListFindingsFilters(ListFindingsFiltersRequest request);
#endif

        /// <summary>
        /// Retrieves a subset of information about all the findings filters for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListFindingsFiltersResponse> ListFindingsFiltersAsync(ListFindingsFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about Amazon Macie membership invitations that were received
        /// by an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
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
        ListInvitationsResponse ListInvitations(ListInvitationsRequest request);
#endif

        /// <summary>
        /// Retrieves information about Amazon Macie membership invitations that were received
        /// by an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about all the managed data identifiers that Amazon Macie currently
        /// provides.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedDataIdentifiers service method.</param>
        /// <returns>The response from the ListManagedDataIdentifiers service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListManagedDataIdentifiers">REST API Reference for ListManagedDataIdentifiers Operation</seealso>
        ListManagedDataIdentifiersResponse ListManagedDataIdentifiers(ListManagedDataIdentifiersRequest request);
#endif

        /// <summary>
        /// Retrieves information about all the managed data identifiers that Amazon Macie currently
        /// provides.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedDataIdentifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListManagedDataIdentifiers service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListManagedDataIdentifiers">REST API Reference for ListManagedDataIdentifiers Operation</seealso>
        Task<ListManagedDataIdentifiersResponse> ListManagedDataIdentifiersAsync(ListManagedDataIdentifiersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the accounts that are associated with an Amazon Macie
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
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
        ListMembersResponse ListMembers(ListMembersRequest request);
#endif

        /// <summary>
        /// Retrieves information about the accounts that are associated with an Amazon Macie
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the delegated Amazon Macie administrator account for an
        /// organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
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
        ListOrganizationAdminAccountsResponse ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request);
#endif

        /// <summary>
        /// Retrieves information about the delegated Amazon Macie administrator account for an
        /// organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListOrganizationAdminAccountsResponse> ListOrganizationAdminAccountsAsync(ListOrganizationAdminAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about objects that Amazon Macie selected from an S3 bucket for
        /// automated sensitive data discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileArtifacts service method.</param>
        /// <returns>The response from the ListResourceProfileArtifacts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileArtifacts">REST API Reference for ListResourceProfileArtifacts Operation</seealso>
        ListResourceProfileArtifactsResponse ListResourceProfileArtifacts(ListResourceProfileArtifactsRequest request);
#endif

        /// <summary>
        /// Retrieves information about objects that Amazon Macie selected from an S3 bucket for
        /// automated sensitive data discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListResourceProfileArtifacts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileArtifacts">REST API Reference for ListResourceProfileArtifacts Operation</seealso>
        Task<ListResourceProfileArtifactsResponse> ListResourceProfileArtifactsAsync(ListResourceProfileArtifactsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the types and amount of sensitive data that Amazon Macie
        /// found in an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileDetections service method.</param>
        /// <returns>The response from the ListResourceProfileDetections service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileDetections">REST API Reference for ListResourceProfileDetections Operation</seealso>
        ListResourceProfileDetectionsResponse ListResourceProfileDetections(ListResourceProfileDetectionsRequest request);
#endif

        /// <summary>
        /// Retrieves information about the types and amount of sensitive data that Amazon Macie
        /// found in an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileDetections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListResourceProfileDetections service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileDetections">REST API Reference for ListResourceProfileDetections Operation</seealso>
        Task<ListResourceProfileDetectionsResponse> ListResourceProfileDetectionsAsync(ListResourceProfileDetectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a subset of information about the sensitivity inspection template for an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSensitivityInspectionTemplates service method.</param>
        /// <returns>The response from the ListSensitivityInspectionTemplates service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListSensitivityInspectionTemplates">REST API Reference for ListSensitivityInspectionTemplates Operation</seealso>
        ListSensitivityInspectionTemplatesResponse ListSensitivityInspectionTemplates(ListSensitivityInspectionTemplatesRequest request);
#endif

        /// <summary>
        /// Retrieves a subset of information about the sensitivity inspection template for an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSensitivityInspectionTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSensitivityInspectionTemplates service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListSensitivityInspectionTemplates">REST API Reference for ListSensitivityInspectionTemplates Operation</seealso>
        Task<ListSensitivityInspectionTemplatesResponse> ListSensitivityInspectionTemplatesAsync(ListSensitivityInspectionTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the tags (keys and values) that are associated with an Amazon Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Retrieves the tags (keys and values) that are associated with an Amazon Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds or updates the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClassificationExportConfiguration service method.</param>
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
        PutClassificationExportConfigurationResponse PutClassificationExportConfiguration(PutClassificationExportConfigurationRequest request);
#endif

        /// <summary>
        /// Adds or updates the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClassificationExportConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutClassificationExportConfigurationResponse> PutClassificationExportConfigurationAsync(PutClassificationExportConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the configuration settings for publishing findings to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFindingsPublicationConfiguration service method.</param>
        /// <returns>The response from the PutFindingsPublicationConfiguration service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutFindingsPublicationConfiguration">REST API Reference for PutFindingsPublicationConfiguration Operation</seealso>
        PutFindingsPublicationConfigurationResponse PutFindingsPublicationConfiguration(PutFindingsPublicationConfigurationRequest request);
#endif

        /// <summary>
        /// Updates the configuration settings for publishing findings to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFindingsPublicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutFindingsPublicationConfiguration service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutFindingsPublicationConfiguration">REST API Reference for PutFindingsPublicationConfiguration Operation</seealso>
        Task<PutFindingsPublicationConfigurationResponse> PutFindingsPublicationConfigurationAsync(PutFindingsPublicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves (queries) statistical data and other information about Amazon Web Services
        /// resources that Amazon Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResources service method.</param>
        /// <returns>The response from the SearchResources service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/SearchResources">REST API Reference for SearchResources Operation</seealso>
        SearchResourcesResponse SearchResources(SearchResourcesRequest request);
#endif

        /// <summary>
        /// Retrieves (queries) statistical data and other information about Amazon Web Services
        /// resources that Amazon Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SearchResources service method, as returned by Macie2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/SearchResources">REST API Reference for SearchResources Operation</seealso>
        Task<SearchResourcesResponse> SearchResourcesAsync(SearchResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds or updates one or more tags (keys and values) that are associated with an Amazon
        /// Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds or updates one or more tags (keys and values) that are associated with an Amazon
        /// Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Tests criteria for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestCustomDataIdentifier service method.</param>
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
        TestCustomDataIdentifierResponse TestCustomDataIdentifier(TestCustomDataIdentifierRequest request);
#endif

        /// <summary>
        /// Tests criteria for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TestCustomDataIdentifierResponse> TestCustomDataIdentifierAsync(TestCustomDataIdentifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes one or more tags (keys and values) from an Amazon Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes one or more tags (keys and values) from an Amazon Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the settings for an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAllowList service method.</param>
        /// <returns>The response from the UpdateAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAllowList">REST API Reference for UpdateAllowList Operation</seealso>
        UpdateAllowListResponse UpdateAllowList(UpdateAllowListRequest request);
#endif

        /// <summary>
        /// Updates the settings for an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAllowList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAllowList">REST API Reference for UpdateAllowList Operation</seealso>
        Task<UpdateAllowListResponse> UpdateAllowListAsync(UpdateAllowListRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Changes the configuration settings and status of automated sensitive data discovery
        /// for an organization or standalone account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedDiscoveryConfiguration service method.</param>
        /// <returns>The response from the UpdateAutomatedDiscoveryConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAutomatedDiscoveryConfiguration">REST API Reference for UpdateAutomatedDiscoveryConfiguration Operation</seealso>
        UpdateAutomatedDiscoveryConfigurationResponse UpdateAutomatedDiscoveryConfiguration(UpdateAutomatedDiscoveryConfigurationRequest request);
#endif

        /// <summary>
        /// Changes the configuration settings and status of automated sensitive data discovery
        /// for an organization or standalone account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAutomatedDiscoveryConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAutomatedDiscoveryConfiguration">REST API Reference for UpdateAutomatedDiscoveryConfiguration Operation</seealso>
        Task<UpdateAutomatedDiscoveryConfigurationResponse> UpdateAutomatedDiscoveryConfigurationAsync(UpdateAutomatedDiscoveryConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Changes the status of a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationJob service method.</param>
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
        UpdateClassificationJobResponse UpdateClassificationJob(UpdateClassificationJobRequest request);
#endif

        /// <summary>
        /// Changes the status of a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateClassificationJobResponse> UpdateClassificationJobAsync(UpdateClassificationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the classification scope settings for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationScope service method.</param>
        /// <returns>The response from the UpdateClassificationScope service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationScope">REST API Reference for UpdateClassificationScope Operation</seealso>
        UpdateClassificationScopeResponse UpdateClassificationScope(UpdateClassificationScopeRequest request);
#endif

        /// <summary>
        /// Updates the classification scope settings for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateClassificationScope service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationScope">REST API Reference for UpdateClassificationScope Operation</seealso>
        Task<UpdateClassificationScopeResponse> UpdateClassificationScopeAsync(UpdateClassificationScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFilter service method.</param>
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
        UpdateFindingsFilterResponse UpdateFindingsFilter(UpdateFindingsFilterRequest request);
#endif

        /// <summary>
        /// Updates the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateFindingsFilterResponse> UpdateFindingsFilterAsync(UpdateFindingsFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Suspends or re-enables Amazon Macie, or updates the configuration settings for a Macie
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMacieSession service method.</param>
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
        UpdateMacieSessionResponse UpdateMacieSession(UpdateMacieSessionRequest request);
#endif

        /// <summary>
        /// Suspends or re-enables Amazon Macie, or updates the configuration settings for a Macie
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMacieSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateMacieSessionResponse> UpdateMacieSessionAsync(UpdateMacieSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Enables an Amazon Macie administrator to suspend or re-enable Macie for a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemberSession service method.</param>
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
        UpdateMemberSessionResponse UpdateMemberSession(UpdateMemberSessionRequest request);
#endif

        /// <summary>
        /// Enables an Amazon Macie administrator to suspend or re-enable Macie for a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemberSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateMemberSessionResponse> UpdateMemberSessionAsync(UpdateMemberSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the Amazon Macie configuration settings for an organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
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
        UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request);
#endif

        /// <summary>
        /// Updates the Amazon Macie configuration settings for an organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateOrganizationConfigurationResponse> UpdateOrganizationConfigurationAsync(UpdateOrganizationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the sensitivity score for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfile service method.</param>
        /// <returns>The response from the UpdateResourceProfile service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfile">REST API Reference for UpdateResourceProfile Operation</seealso>
        UpdateResourceProfileResponse UpdateResourceProfile(UpdateResourceProfileRequest request);
#endif

        /// <summary>
        /// Updates the sensitivity score for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateResourceProfile service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfile">REST API Reference for UpdateResourceProfile Operation</seealso>
        Task<UpdateResourceProfileResponse> UpdateResourceProfileAsync(UpdateResourceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the sensitivity scoring settings for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfileDetections service method.</param>
        /// <returns>The response from the UpdateResourceProfileDetections service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfileDetections">REST API Reference for UpdateResourceProfileDetections Operation</seealso>
        UpdateResourceProfileDetectionsResponse UpdateResourceProfileDetections(UpdateResourceProfileDetectionsRequest request);
#endif

        /// <summary>
        /// Updates the sensitivity scoring settings for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfileDetections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateResourceProfileDetections service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfileDetections">REST API Reference for UpdateResourceProfileDetections Operation</seealso>
        Task<UpdateResourceProfileDetectionsResponse> UpdateResourceProfileDetectionsAsync(UpdateResourceProfileDetectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the status and configuration settings for retrieving occurrences of sensitive
        /// data reported by findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevealConfiguration service method.</param>
        /// <returns>The response from the UpdateRevealConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateRevealConfiguration">REST API Reference for UpdateRevealConfiguration Operation</seealso>
        UpdateRevealConfigurationResponse UpdateRevealConfiguration(UpdateRevealConfigurationRequest request);
#endif

        /// <summary>
        /// Updates the status and configuration settings for retrieving occurrences of sensitive
        /// data reported by findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevealConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRevealConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateRevealConfiguration">REST API Reference for UpdateRevealConfiguration Operation</seealso>
        Task<UpdateRevealConfigurationResponse> UpdateRevealConfigurationAsync(UpdateRevealConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the settings for the sensitivity inspection template for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSensitivityInspectionTemplate service method.</param>
        /// <returns>The response from the UpdateSensitivityInspectionTemplate service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateSensitivityInspectionTemplate">REST API Reference for UpdateSensitivityInspectionTemplate Operation</seealso>
        UpdateSensitivityInspectionTemplateResponse UpdateSensitivityInspectionTemplate(UpdateSensitivityInspectionTemplateRequest request);
#endif

        /// <summary>
        /// Updates the settings for the sensitivity inspection template for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSensitivityInspectionTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateSensitivityInspectionTemplate service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateSensitivityInspectionTemplate">REST API Reference for UpdateSensitivityInspectionTemplate Operation</seealso>
        Task<UpdateSensitivityInspectionTemplateResponse> UpdateSensitivityInspectionTemplateAsync(UpdateSensitivityInspectionTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonMacie2Config))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonMacie2Config();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonMacie2Config;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonMacie2Config to create AmazonMacie2Client");
            }

            return awsCredentials == null ?
                    new AmazonMacie2Client(serviceClientConfig) :
                    new AmazonMacie2Client(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
