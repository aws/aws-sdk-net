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
using Amazon.Continuum.Model;

#pragma warning disable CS1570

namespace Amazon.Continuum
{
    /// <summary>
    /// <para>Interface for accessing Continuum</para>
    ///
    /// AWS Continuum finds, validates, prioritizes, and remediates code vulnerabilities across
    /// the source repositories and AWS resources in your environments.
    /// </summary>
    public partial interface IAmazonContinuum : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IContinuumPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Associates one Collector with this Environment and configures the customer role Continuum
        /// uses to authorize access to associated Collector data. The caller must have permission
        /// on the Environment and permission to pass the role. Continuum assumes the supplied
        /// role and calls GetCollectorDataAccessAuthorization on the requested Collector; only
        /// a successful authorization response permits the association. The caller does not need
        /// Collector data-access permission. The Environment retains its other Collector associations.
        /// Calling again with an existing association is safe and does not create a duplicate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCollector service method.</param>
        /// <returns>The response from the AssociateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/AssociateCollector">REST API Reference for AssociateCollector Operation</seealso>
        AssociateCollectorResponse AssociateCollector(AssociateCollectorRequest request);
#endif

        /// <summary>
        /// Associates one Collector with this Environment and configures the customer role Continuum
        /// uses to authorize access to associated Collector data. The caller must have permission
        /// on the Environment and permission to pass the role. Continuum assumes the supplied
        /// role and calls GetCollectorDataAccessAuthorization on the requested Collector; only
        /// a successful authorization response permits the association. The caller does not need
        /// Collector data-access permission. The Environment retains its other Collector associations.
        /// Calling again with an existing association is safe and does not create a duplicate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/AssociateCollector">REST API Reference for AssociateCollector Operation</seealso>
        Task<AssociateCollectorResponse> AssociateCollectorAsync(AssociateCollectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Ingests a customer-supplied security finding into an environment. Continuum validates
        /// the document synchronously against the required overlay fields for the declared format;
        /// invalid documents are rejected with a ValidationException. The maximum accepted document
        /// size is 256 KB. The environment must have a source configured, and the finding must
        /// identify a code location so Continuum can tie it to a repository in the environment's
        /// build. Continuum assigns a findingId and stores the verbatim document. When no successful
        /// build yet contains the finding's repository, the finding stays SUBMITTED until the
        /// next successful build; if that build does not contain it either, the finding is DISCARDED
        /// with discardReason SOURCE_REPO_NOT_FOUND.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeFinding service method.</param>
        /// <returns>The response from the CreateCodeFinding service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCodeFinding">REST API Reference for CreateCodeFinding Operation</seealso>
        CreateCodeFindingResponse CreateCodeFinding(CreateCodeFindingRequest request);
#endif

        /// <summary>
        /// Ingests a customer-supplied security finding into an environment. Continuum validates
        /// the document synchronously against the required overlay fields for the declared format;
        /// invalid documents are rejected with a ValidationException. The maximum accepted document
        /// size is 256 KB. The environment must have a source configured, and the finding must
        /// identify a code location so Continuum can tie it to a repository in the environment's
        /// build. Continuum assigns a findingId and stores the verbatim document. When no successful
        /// build yet contains the finding's repository, the finding stays SUBMITTED until the
        /// next successful build; if that build does not contain it either, the finding is DISCARDED
        /// with discardReason SOURCE_REPO_NOT_FOUND.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCodeFinding service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCodeFinding">REST API Reference for CreateCodeFinding Operation</seealso>
        Task<CreateCodeFindingResponse> CreateCodeFindingAsync(CreateCodeFindingRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates an explicit scan request for one environment. CP creates durable work before
        /// any queue delivery occurs. Retrying a request that succeeded, with the same clientToken
        /// on the same environment, returns the original scan instead of starting another one.
        /// Token handling is not yet atomic: requests with the same token that run at the same
        /// time, or a retry after a request that failed partway through, can leave an additional
        /// scan, which may end in the FAILED state with a message that it was superseded. Deleting
        /// the environment makes its tokens unusable; a later request with one of them returns
        /// ResourceNotFoundException. Each environment can have a limited number of scans in
        /// progress at the same time. Once that limit is enforced, a request that would exceed
        /// it returns ServiceQuotaExceededException; wait for a scan to finish (ListCodeScans
        /// shows each scan's status), then retry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeScan service method.</param>
        /// <returns>The response from the CreateCodeScan service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCodeScan">REST API Reference for CreateCodeScan Operation</seealso>
        CreateCodeScanResponse CreateCodeScan(CreateCodeScanRequest request);
#endif

        /// <summary>
        /// Creates an explicit scan request for one environment. CP creates durable work before
        /// any queue delivery occurs. Retrying a request that succeeded, with the same clientToken
        /// on the same environment, returns the original scan instead of starting another one.
        /// Token handling is not yet atomic: requests with the same token that run at the same
        /// time, or a retry after a request that failed partway through, can leave an additional
        /// scan, which may end in the FAILED state with a message that it was superseded. Deleting
        /// the environment makes its tokens unusable; a later request with one of them returns
        /// ResourceNotFoundException. Each environment can have a limited number of scans in
        /// progress at the same time. Once that limit is enforced, a request that would exceed
        /// it returns ServiceQuotaExceededException; wait for a scan to finish (ListCodeScans
        /// shows each scan's status), then retry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCodeScan service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCodeScan">REST API Reference for CreateCodeScan Operation</seealso>
        Task<CreateCodeScanResponse> CreateCodeScanAsync(CreateCodeScanRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates the Collector for the caller's account. Provisions an AWS Config service-linked
        /// recorder using the caller's federated access session and begins recording infrastructure
        /// changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollector service method.</param>
        /// <returns>The response from the CreateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCollector">REST API Reference for CreateCollector Operation</seealso>
        CreateCollectorResponse CreateCollector(CreateCollectorRequest request);
#endif

        /// <summary>
        /// Creates the Collector for the caller's account. Provisions an AWS Config service-linked
        /// recorder using the caller's federated access session and begins recording infrastructure
        /// changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCollector">REST API Reference for CreateCollector Operation</seealso>
        Task<CreateCollectorResponse> CreateCollectorAsync(CreateCollectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates an environment and starts its validation and any requested provisioning. Storage
        /// provisioning and dependency checks may continue after the initial 201 response; use
        /// GetEnvironment to observe completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <returns>The response from the CreateEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request);
#endif

        /// <summary>
        /// Creates an environment and starts its validation and any requested provisioning. Storage
        /// provisioning and dependency checks may continue after the initial 201 response; use
        /// GetEnvironment to observe completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new integration with an external source provider. Repeating an identical
        /// request with the same clientToken returns the original integrationId, integrationArn,
        /// and createdAt. Token records are retained for eight hours after success or terminal
        /// failure, including after the integration is deleted; replaying a deleted integration's
        /// token does not recreate it. An identical request with a retained terminal failure
        /// returns the recorded error. Reusing a token with different parameters returns ValidationException.
        /// A fresh token starts a new create attempt; if the name is already owned by another
        /// integration, ConflictException includes that integration's identifier. An attempt
        /// still in progress may return ThrottlingException with retryAfterSeconds set to 1;
        /// retry with the same token and identical parameters. GitHub authorization codes are
        /// single use. Retry an unresolved attempt with its original token and unchanged parameters
        /// first. If the service reports a terminal failure, an expired attempt, or a successful
        /// token exchange whose integration could not be saved, restart GitHub authorization
        /// with a fresh token and authorization code. The service does not checkpoint provider
        /// results for recovery by another request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <returns>The response from the CreateIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request);
#endif

        /// <summary>
        /// Creates a new integration with an external source provider. Repeating an identical
        /// request with the same clientToken returns the original integrationId, integrationArn,
        /// and createdAt. Token records are retained for eight hours after success or terminal
        /// failure, including after the integration is deleted; replaying a deleted integration's
        /// token does not recreate it. An identical request with a retained terminal failure
        /// returns the recorded error. Reusing a token with different parameters returns ValidationException.
        /// A fresh token starts a new create attempt; if the name is already owned by another
        /// integration, ConflictException includes that integration's identifier. An attempt
        /// still in progress may return ThrottlingException with retryAfterSeconds set to 1;
        /// retry with the same token and identical parameters. GitHub authorization codes are
        /// single use. Retry an unresolved attempt with its original token and unchanged parameters
        /// first. If the service reports a terminal failure, an expired attempt, or a successful
        /// token exchange whose integration could not be saved, restart GitHub authorization
        /// with a fresh token and authorization code. The service does not checkpoint provider
        /// results for recovery by another request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the Collector for the caller's account. The Collector first enters PENDING_DELETION,
        /// then the service removes its schedule, AWS Config service-linked recorder, versioned
        /// S3 bucket, KMS key, and persisted record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollector service method.</param>
        /// <returns>The response from the DeleteCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteCollector">REST API Reference for DeleteCollector Operation</seealso>
        DeleteCollectorResponse DeleteCollector(DeleteCollectorRequest request);
#endif

        /// <summary>
        /// Deletes the Collector for the caller's account. The Collector first enters PENDING_DELETION,
        /// then the service removes its schedule, AWS Config service-linked recorder, versioned
        /// S3 bucket, KMS key, and persisted record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteCollector">REST API Reference for DeleteCollector Operation</seealso>
        Task<DeleteCollectorResponse> DeleteCollectorAsync(DeleteCollectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an environment and its associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <returns>The response from the DeleteEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request);
#endif

        /// <summary>
        /// Deletes an environment and its associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an integration and releases its name and account quota. Its retained CreateIntegration
        /// token receipt can still replay the original result without recreating the integration.
        /// Shared provider registrations are retained: deleting one integration does not remove
        /// provider access used by another integration. A fresh GitHub CreateIntegration attempt
        /// requires a fresh OAuth authorization code and a new clientToken.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <returns>The response from the DeleteIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request);
#endif

        /// <summary>
        /// Deletes an integration and releases its name and account quota. Its retained CreateIntegration
        /// token receipt can still replay the original result without recreating the integration.
        /// Shared provider registrations are retained: deleting one integration does not remove
        /// provider access used by another integration. A fresh GitHub CreateIntegration attempt
        /// requires a fresh OAuth authorization code and a new clientToken.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes one Collector association from this Environment, preserving its other associations.
        /// The stored Collector data-access role is cleared when no Collector associations remain.
        /// The Environment owner must have permission to disassociate. A current Collector access
        /// grant is not required, and the Collector does not need to remain active or present,
        /// so stale or revoked associations can be cleaned up.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCollector service method.</param>
        /// <returns>The response from the DisassociateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DisassociateCollector">REST API Reference for DisassociateCollector Operation</seealso>
        DisassociateCollectorResponse DisassociateCollector(DisassociateCollectorRequest request);
#endif

        /// <summary>
        /// Removes one Collector association from this Environment, preserving its other associations.
        /// The stored Collector data-access role is cleared when no Collector associations remain.
        /// The Environment owner must have permission to disassociate. A current Collector access
        /// grant is not required, and the Collector does not need to remain active or present,
        /// so stale or revoked associations can be cleaned up.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DisassociateCollector">REST API Reference for DisassociateCollector Operation</seealso>
        Task<DisassociateCollectorResponse> DisassociateCollectorAsync(DisassociateCollectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current state and details of a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeFinding service method.</param>
        /// <returns>The response from the GetCodeFinding service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeFinding">REST API Reference for GetCodeFinding Operation</seealso>
        GetCodeFindingResponse GetCodeFinding(GetCodeFindingRequest request);
#endif

        /// <summary>
        /// Retrieves the current state and details of a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCodeFinding service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeFinding">REST API Reference for GetCodeFinding Operation</seealso>
        Task<GetCodeFindingResponse> GetCodeFindingAsync(GetCodeFindingRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current state and details of an issue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeIssue service method.</param>
        /// <returns>The response from the GetCodeIssue service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeIssue">REST API Reference for GetCodeIssue Operation</seealso>
        GetCodeIssueResponse GetCodeIssue(GetCodeIssueRequest request);
#endif

        /// <summary>
        /// Retrieves the current state and details of an issue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeIssue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCodeIssue service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeIssue">REST API Reference for GetCodeIssue Operation</seealso>
        Task<GetCodeIssueResponse> GetCodeIssueAsync(GetCodeIssueRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves one immutable artifact attached to an issue, including its content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeIssueArtifact service method.</param>
        /// <returns>The response from the GetCodeIssueArtifact service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeIssueArtifact">REST API Reference for GetCodeIssueArtifact Operation</seealso>
        GetCodeIssueArtifactResponse GetCodeIssueArtifact(GetCodeIssueArtifactRequest request);
#endif

        /// <summary>
        /// Retrieves one immutable artifact attached to an issue, including its content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeIssueArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCodeIssueArtifact service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeIssueArtifact">REST API Reference for GetCodeIssueArtifact Operation</seealso>
        Task<GetCodeIssueArtifactResponse> GetCodeIssueArtifactAsync(GetCodeIssueArtifactRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves one customer-visible environment scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeScan service method.</param>
        /// <returns>The response from the GetCodeScan service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeScan">REST API Reference for GetCodeScan Operation</seealso>
        GetCodeScanResponse GetCodeScan(GetCodeScanRequest request);
#endif

        /// <summary>
        /// Retrieves one customer-visible environment scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCodeScan service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeScan">REST API Reference for GetCodeScan Operation</seealso>
        Task<GetCodeScanResponse> GetCodeScanAsync(GetCodeScanRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current state of the Collector for the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollector service method.</param>
        /// <returns>The response from the GetCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCollector">REST API Reference for GetCollector Operation</seealso>
        GetCollectorResponse GetCollector(GetCollectorRequest request);
#endif

        /// <summary>
        /// Retrieves the current state of the Collector for the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCollector">REST API Reference for GetCollector Operation</seealso>
        Task<GetCollectorResponse> GetCollectorAsync(GetCollectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Authorizes an Environment's access to a Collector's data. Continuum calls this operation
        /// with the Environment's Collector data-access role before it reads the Collector's
        /// inventory, so grant continuum:GetCollectorDataAccessAuthorization to that role and,
        /// for a Collector in another account, in the Collector's resource policy. The operation
        /// evaluates the action against the exact Collector ARN and the Collector's current resource
        /// policy using IAM and the caller's authenticated request context, with environmentArn
        /// as the continuum:EnvironmentArn condition key. A successful request returns HTTP 200
        /// with no response members. If access is not granted, the operation returns AccessDeniedException
        /// without disclosing Collector existence, ownership, or the policy layer that denied
        /// access. The service does not reinterpret the policy using only an account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollectorDataAccessAuthorization service method.</param>
        /// <returns>The response from the GetCollectorDataAccessAuthorization service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCollectorDataAccessAuthorization">REST API Reference for GetCollectorDataAccessAuthorization Operation</seealso>
        GetCollectorDataAccessAuthorizationResponse GetCollectorDataAccessAuthorization(GetCollectorDataAccessAuthorizationRequest request);
#endif

        /// <summary>
        /// Authorizes an Environment's access to a Collector's data. Continuum calls this operation
        /// with the Environment's Collector data-access role before it reads the Collector's
        /// inventory, so grant continuum:GetCollectorDataAccessAuthorization to that role and,
        /// for a Collector in another account, in the Collector's resource policy. The operation
        /// evaluates the action against the exact Collector ARN and the Collector's current resource
        /// policy using IAM and the caller's authenticated request context, with environmentArn
        /// as the continuum:EnvironmentArn condition key. A successful request returns HTTP 200
        /// with no response members. If access is not granted, the operation returns AccessDeniedException
        /// without disclosing Collector existence, ownership, or the policy layer that denied
        /// access. The service does not reinterpret the policy using only an account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollectorDataAccessAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCollectorDataAccessAuthorization service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCollectorDataAccessAuthorization">REST API Reference for GetCollectorDataAccessAuthorization Operation</seealso>
        Task<GetCollectorDataAccessAuthorizationResponse> GetCollectorDataAccessAuthorizationAsync(GetCollectorDataAccessAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current state and configuration of an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <returns>The response from the GetEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request);
#endif

        /// <summary>
        /// Retrieves the current state and configuration of an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about an integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <returns>The response from the GetIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        GetIntegrationResponse GetIntegration(GetIntegrationRequest request);
#endif

        /// <summary>
        /// Retrieves information about an integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the resource policy attached to a Continuum resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <returns>The response from the GetResourcePolicy service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);
#endif

        /// <summary>
        /// Retrieves the resource policy attached to a Continuum resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetResourcePolicy service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the Collectors currently associated with one Environment in ascending collectorId
        /// order. Each entry carries the Collector ARN, so a listed association can be passed
        /// straight to DisassociateCollector, including when the Collector belongs to another
        /// account. An association recorded before Continuum persisted the ARN is omitted from
        /// the response, because without the ARN it cannot be acted on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedCollectors service method.</param>
        /// <returns>The response from the ListAssociatedCollectors service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListAssociatedCollectors">REST API Reference for ListAssociatedCollectors Operation</seealso>
        ListAssociatedCollectorsResponse ListAssociatedCollectors(ListAssociatedCollectorsRequest request);
#endif

        /// <summary>
        /// Lists the Collectors currently associated with one Environment in ascending collectorId
        /// order. Each entry carries the Collector ARN, so a listed association can be passed
        /// straight to DisassociateCollector, including when the Collector belongs to another
        /// account. An association recorded before Continuum persisted the ARN is omitted from
        /// the response, because without the ARN it cannot be acted on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedCollectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAssociatedCollectors service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListAssociatedCollectors">REST API Reference for ListAssociatedCollectors Operation</seealso>
        Task<ListAssociatedCollectorsResponse> ListAssociatedCollectorsAsync(ListAssociatedCollectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the Environments currently associated with one Collector in lexicographically
        /// ascending environmentArn order. The ARN identifies each Environment across accounts
        /// within the Collector's Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedEnvironments service method.</param>
        /// <returns>The response from the ListAssociatedEnvironments service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListAssociatedEnvironments">REST API Reference for ListAssociatedEnvironments Operation</seealso>
        ListAssociatedEnvironmentsResponse ListAssociatedEnvironments(ListAssociatedEnvironmentsRequest request);
#endif

        /// <summary>
        /// Lists the Environments currently associated with one Collector in lexicographically
        /// ascending environmentArn order. The ARN identifies each Environment across accounts
        /// within the Collector's Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAssociatedEnvironments service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListAssociatedEnvironments">REST API Reference for ListAssociatedEnvironments Operation</seealso>
        Task<ListAssociatedEnvironmentsResponse> ListAssociatedEnvironmentsAsync(ListAssociatedEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the findings in an environment in descending findingId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeFindings service method.</param>
        /// <returns>The response from the ListCodeFindings service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeFindings">REST API Reference for ListCodeFindings Operation</seealso>
        ListCodeFindingsResponse ListCodeFindings(ListCodeFindingsRequest request);
#endif

        /// <summary>
        /// Lists the findings in an environment in descending findingId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCodeFindings service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeFindings">REST API Reference for ListCodeFindings Operation</seealso>
        Task<ListCodeFindingsResponse> ListCodeFindingsAsync(ListCodeFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the artifacts attached to an issue in descending artifactId order. Content is
        /// returned by GetCodeIssueArtifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeIssueArtifacts service method.</param>
        /// <returns>The response from the ListCodeIssueArtifacts service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeIssueArtifacts">REST API Reference for ListCodeIssueArtifacts Operation</seealso>
        ListCodeIssueArtifactsResponse ListCodeIssueArtifacts(ListCodeIssueArtifactsRequest request);
#endif

        /// <summary>
        /// Lists the artifacts attached to an issue in descending artifactId order. Content is
        /// returned by GetCodeIssueArtifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeIssueArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCodeIssueArtifacts service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeIssueArtifacts">REST API Reference for ListCodeIssueArtifacts Operation</seealso>
        Task<ListCodeIssueArtifactsResponse> ListCodeIssueArtifactsAsync(ListCodeIssueArtifactsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the issues in an environment in descending issueId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeIssues service method.</param>
        /// <returns>The response from the ListCodeIssues service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeIssues">REST API Reference for ListCodeIssues Operation</seealso>
        ListCodeIssuesResponse ListCodeIssues(ListCodeIssuesRequest request);
#endif

        /// <summary>
        /// Lists the issues in an environment in descending issueId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeIssues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCodeIssues service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeIssues">REST API Reference for ListCodeIssues Operation</seealso>
        Task<ListCodeIssuesResponse> ListCodeIssuesAsync(ListCodeIssuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists customer-visible scans for one environment in descending scanRunId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeScans service method.</param>
        /// <returns>The response from the ListCodeScans service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeScans">REST API Reference for ListCodeScans Operation</seealso>
        ListCodeScansResponse ListCodeScans(ListCodeScansRequest request);
#endif

        /// <summary>
        /// Lists customer-visible scans for one environment in descending scanRunId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeScans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCodeScans service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeScans">REST API Reference for ListCodeScans Operation</seealso>
        Task<ListCodeScansResponse> ListCodeScansAsync(ListCodeScansRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the Collectors owned by the authenticated caller's account, including a Collector
        /// whose deletion is in progress. A Collector that is still being created is omitted.
        /// The account-scoped Collector quota currently permits at most one result, so no result
        /// ordering applies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollectors service method.</param>
        /// <returns>The response from the ListCollectors service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCollectors">REST API Reference for ListCollectors Operation</seealso>
        ListCollectorsResponse ListCollectors(ListCollectorsRequest request);
#endif

        /// <summary>
        /// Lists the Collectors owned by the authenticated caller's account, including a Collector
        /// whose deletion is in progress. A Collector that is still being created is omitted.
        /// The account-scoped Collector quota currently permits at most one result, so no result
        /// ordering applies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCollectors service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCollectors">REST API Reference for ListCollectors Operation</seealso>
        Task<ListCollectorsResponse> ListCollectorsAsync(ListCollectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all environments in your account in descending environmentId order. This complete-inventory
        /// operation intentionally has no response filters; see the input documentation for the
        /// API standards justification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <returns>The response from the ListEnvironments service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request);
#endif

        /// <summary>
        /// Lists all environments in your account in descending environmentId order. This complete-inventory
        /// operation intentionally has no response filters; see the input documentation for the
        /// API standards justification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListEnvironments service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the integrations in your account in descending integrationId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <returns>The response from the ListIntegrations service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        ListIntegrationsResponse ListIntegrations(ListIntegrationsRequest request);
#endif

        /// <summary>
        /// Lists the integrations in your account in descending integrationId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListIntegrations service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        Task<ListIntegrationsResponse> ListIntegrationsAsync(ListIntegrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates or replaces the resource policy attached to a Continuum resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <returns>The response from the PutResourcePolicy service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);
#endif

        /// <summary>
        /// Creates or replaces the resource policy attached to a Continuum resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutResourcePolicy service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts an OAuth authorization for a new integration and returns the values the caller
        /// sends to the provider's authorization endpoint. The authorization belongs to the calling
        /// AWS account, can be redeemed once by CreateIntegration from that same account, and
        /// expires after ten minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIntegrationAuthorization service method.</param>
        /// <returns>The response from the StartIntegrationAuthorization service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/StartIntegrationAuthorization">REST API Reference for StartIntegrationAuthorization Operation</seealso>
        StartIntegrationAuthorizationResponse StartIntegrationAuthorization(StartIntegrationAuthorizationRequest request);
#endif

        /// <summary>
        /// Starts an OAuth authorization for a new integration and returns the values the caller
        /// sends to the provider's authorization endpoint. The authorization belongs to the calling
        /// AWS account, can be redeemed once by CreateIntegration from that same account, and
        /// expires after ten minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIntegrationAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartIntegrationAuthorization service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/StartIntegrationAuthorization">REST API Reference for StartIntegrationAuthorization Operation</seealso>
        Task<StartIntegrationAuthorizationResponse> StartIntegrationAuthorizationAsync(StartIntegrationAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the customer-controlled mutable properties of a Collector. Only the name and
        /// Kubernetes cluster IAM role can be changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollector service method.</param>
        /// <returns>The response from the UpdateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateCollector">REST API Reference for UpdateCollector Operation</seealso>
        UpdateCollectorResponse UpdateCollector(UpdateCollectorRequest request);
#endif

        /// <summary>
        /// Updates the customer-controlled mutable properties of a Collector. Only the name and
        /// Kubernetes cluster IAM role can be changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateCollector">REST API Reference for UpdateCollector Operation</seealso>
        Task<UpdateCollectorResponse> UpdateCollectorAsync(UpdateCollectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the customer-controlled mutable properties of an environment. Only the name,
        /// the environment's S3 integration source and repository selections, its scan frequency,
        /// its network policy, and its patch creation policy can be changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <returns>The response from the UpdateEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request);
#endif

        /// <summary>
        /// Updates the customer-controlled mutable properties of an environment. Only the name,
        /// the environment's S3 integration source and repository selections, its scan frequency,
        /// its network policy, and its patch creation policy can be changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Rotates the credentials used by an Amazon S3 integration. Only S3 integrations can
        /// be updated; GitHub integrations cannot be modified. The integration's name, provider
        /// type, and bucket remain fixed. The caller must have iam:PassRole permission for the
        /// supplied role, including when only the external ID changes. Continuum verifies that
        /// the role can be assumed with the requested external ID and can access the existing
        /// bucket before saving both credentials atomically. Omitting externalId preserves its
        /// current value. Repeating both current credentials leaves updatedAt unchanged, but
        /// still requires authorization and access validation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <returns>The response from the UpdateIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request);
#endif

        /// <summary>
        /// Rotates the credentials used by an Amazon S3 integration. Only S3 integrations can
        /// be updated; GitHub integrations cannot be modified. The integration's name, provider
        /// type, and bucket remain fixed. The caller must have iam:PassRole permission for the
        /// supplied role, including when only the external ID changes. Continuum verifies that
        /// the role can be assumed with the requested external ID and can access the existing
        /// bucket before saving both credentials atomically. Omitting externalId preserves its
        /// current value. Repeating both current credentials leaves updatedAt unchanged, but
        /// still requires authorization and access validation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonContinuumConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonContinuumConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonContinuumConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonContinuumConfig to create AmazonContinuumClient");
            }

            return awsCredentials == null ?
                    new AmazonContinuumClient(serviceClientConfig) :
                    new AmazonContinuumClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
