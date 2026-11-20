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
using Amazon.AgentRegistryControl.Model;

#pragma warning disable CS1570

namespace Amazon.AgentRegistryControl
{
    /// <summary>
    /// <para>Interface for accessing AgentRegistryControl</para>
    ///
    /// Amazon Web Services Agent Registry is a managed catalog for publishing and discovering
    /// resources such as MCP servers, agents, and agent skills. Agent Registry Control is
    /// its control-plane API: use it to create and manage registries and the records they
    /// contain, configure discovery and authorization, govern record approval and curation
    /// workflows, and manage automatic detection of resources. Data-plane search and MCP
    /// invocation operations are provided by the companion Agent Registry API.
    /// </summary>
    public partial interface IAmazonAgentRegistryControl : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAgentRegistryControlPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Associate a registry record with a publisher and assign the record a public identifier
        /// under the publisher's domain. The registry record must be APPROVED and the publisher
        /// must be ACTIVE. A registry record can have only one publisher association. The new
        /// association starts in PENDING_APPROVAL until a curator approves or rejects it. A ConflictException
        /// (HTTP 409) means the publisher is not ACTIVE yet, the registry record already has
        /// an association, or another registry record already holds the public identifier. To
        /// retry safely, repeat the request with the same clientToken; a retry returns the original
        /// association. If the publisher has reached its association quota, the request fails
        /// with ServiceQuotaExceededException (HTTP 402). Remove an unused association or request
        /// a quota increase.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePublisher service method.</param>
        /// <returns>The response from the AssociatePublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.DependencyException">
        /// This exception is thrown on a database (or other dependency) error. Modeled as a server
        /// error so SDKs retry it (5xx) and it feeds server-error alarming. Marked @retryable
        /// because it represents a transient downstream failure that is safe to retry (matches
        /// the forwarder's own retry-on-DependencyException behavior).
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/AssociatePublisher">REST API Reference for AssociatePublisher Operation</seealso>
        AssociatePublisherResponse AssociatePublisher(AssociatePublisherRequest request);
#endif

        /// <summary>
        /// Associate a registry record with a publisher and assign the record a public identifier
        /// under the publisher's domain. The registry record must be APPROVED and the publisher
        /// must be ACTIVE. A registry record can have only one publisher association. The new
        /// association starts in PENDING_APPROVAL until a curator approves or rejects it. A ConflictException
        /// (HTTP 409) means the publisher is not ACTIVE yet, the registry record already has
        /// an association, or another registry record already holds the public identifier. To
        /// retry safely, repeat the request with the same clientToken; a retry returns the original
        /// association. If the publisher has reached its association quota, the request fails
        /// with ServiceQuotaExceededException (HTTP 402). Remove an unused association or request
        /// a quota increase.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePublisher service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociatePublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.DependencyException">
        /// This exception is thrown on a database (or other dependency) error. Modeled as a server
        /// error so SDKs retry it (5xx) and it feeds server-error alarming. Marked @retryable
        /// because it represents a transient downstream failure that is safe to retry (matches
        /// the forwarder's own retry-on-DependencyException behavior).
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/AssociatePublisher">REST API Reference for AssociatePublisher Operation</seealso>
        Task<AssociatePublisherResponse> AssociatePublisherAsync(AssociatePublisherRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a publisher for a domain you control. The publisher starts in ACTION_REQUIRED,
        /// and the response includes a domainChallenge. To verify the domain, create a DNS TXT
        /// record with the challenge's recordName and recordValue. When the registry finds the
        /// record, the publisher becomes ACTIVE and you can associate registry records with it.
        /// Your account can have one publisher per domain. Creating a second publisher for the
        /// same domain fails with ConflictException unless the request repeats the original clientToken,
        /// which returns the existing publisher. The request also fails with ConflictException
        /// when another account has already verified the domain. If your account has reached
        /// its Publisher quota, the request fails with ServiceQuotaExceededException (HTTP 402).
        /// Delete an unused Publisher or request a quota increase.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublisher service method.</param>
        /// <returns>The response from the CreatePublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/CreatePublisher">REST API Reference for CreatePublisher Operation</seealso>
        CreatePublisherResponse CreatePublisher(CreatePublisherRequest request);
#endif

        /// <summary>
        /// Create a publisher for a domain you control. The publisher starts in ACTION_REQUIRED,
        /// and the response includes a domainChallenge. To verify the domain, create a DNS TXT
        /// record with the challenge's recordName and recordValue. When the registry finds the
        /// record, the publisher becomes ACTIVE and you can associate registry records with it.
        /// Your account can have one publisher per domain. Creating a second publisher for the
        /// same domain fails with ConflictException unless the request repeats the original clientToken,
        /// which returns the existing publisher. The request also fails with ConflictException
        /// when another account has already verified the domain. If your account has reached
        /// its Publisher quota, the request fails with ServiceQuotaExceededException (HTTP 402).
        /// Delete an unused Publisher or request a quota increase.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublisher service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreatePublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/CreatePublisher">REST API Reference for CreatePublisher Operation</seealso>
        Task<CreatePublisherResponse> CreatePublisherAsync(CreatePublisherRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new registry, a catalog that organizes registry records and defines their
        /// discovery authorization and record approval behavior. Creation is asynchronous: the
        /// registry begins in the CREATING status and becomes usable once it reaches READY.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// <returns>The response from the CreateRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        CreateRegistryResponse CreateRegistry(CreateRegistryRequest request);
#endif

        /// <summary>
        /// Creates a new registry, a catalog that organizes registry records and defines their
        /// discovery authorization and record approval behavior. Creation is asynchronous: the
        /// registry begins in the CREATING status and becomes usable once it reaches READY.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        Task<CreateRegistryResponse> CreateRegistryAsync(CreateRegistryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a registry record within a registry. A registry record describes a discoverable
        /// resource, such as an MCP server, an agent, an agent skill, or a custom resource. For
        /// an agent skill, you can upload a skill package in <c>artifact</c>, or synchronize
        /// the skill from an Amazon S3 or GitHub source. Creation is asynchronous: the operation
        /// returns the record with the <c>CREATING</c> status while the registry processes it.
        /// If a GitHub user must first authorize access to the source, the operation returns
        /// the record with the <c>CREATE_PENDING_AUTH</c> status instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistryRecord service method.</param>
        /// <returns>The response from the CreateRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/CreateRegistryRecord">REST API Reference for CreateRegistryRecord Operation</seealso>
        CreateRegistryRecordResponse CreateRegistryRecord(CreateRegistryRecordRequest request);
#endif

        /// <summary>
        /// Creates a registry record within a registry. A registry record describes a discoverable
        /// resource, such as an MCP server, an agent, an agent skill, or a custom resource. For
        /// an agent skill, you can upload a skill package in <c>artifact</c>, or synchronize
        /// the skill from an Amazon S3 or GitHub source. Creation is asynchronous: the operation
        /// returns the record with the <c>CREATING</c> status while the registry processes it.
        /// If a GitHub user must first authorize access to the source, the operation returns
        /// the record with the <c>CREATE_PENDING_AUTH</c> status instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/CreateRegistryRecord">REST API Reference for CreateRegistryRecord Operation</seealso>
        Task<CreateRegistryRecordResponse> CreateRegistryRecordAsync(CreateRegistryRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete a publisher. A successful call returns an empty response. You can't delete
        /// a publisher that has registry record associations; disassociate every registry record
        /// from it first. The request fails with ConflictException while the publisher has associations
        /// or another delete is in progress. Association removals can take a few seconds to be
        /// reflected, so a delete that follows a disassociation can briefly fail with ConflictException;
        /// retry after a short wait. If the publisher ARN names your account and the publisher
        /// doesn't exist, the request fails with ResourceNotFoundException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublisher service method.</param>
        /// <returns>The response from the DeletePublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/DeletePublisher">REST API Reference for DeletePublisher Operation</seealso>
        DeletePublisherResponse DeletePublisher(DeletePublisherRequest request);
#endif

        /// <summary>
        /// Delete a publisher. A successful call returns an empty response. You can't delete
        /// a publisher that has registry record associations; disassociate every registry record
        /// from it first. The request fails with ConflictException while the publisher has associations
        /// or another delete is in progress. Association removals can take a few seconds to be
        /// reflected, so a delete that follows a disassociation can briefly fail with ConflictException;
        /// retry after a short wait. If the publisher ARN names your account and the publisher
        /// doesn't exist, the request fails with ResourceNotFoundException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublisher service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeletePublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/DeletePublisher">REST API Reference for DeletePublisher Operation</seealso>
        Task<DeletePublisherResponse> DeletePublisherAsync(DeletePublisherRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a registry. Deletion is asynchronous: the registry transitions to the DELETING
        /// status and is removed along with its registry records.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// <returns>The response from the DeleteRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        DeleteRegistryResponse DeleteRegistry(DeleteRegistryRequest request);
#endif

        /// <summary>
        /// Deletes a registry. Deletion is asynchronous: the registry transitions to the DELETING
        /// status and is removed along with its registry records.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        Task<DeleteRegistryResponse> DeleteRegistryAsync(DeleteRegistryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a registry record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistryRecord service method.</param>
        /// <returns>The response from the DeleteRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/DeleteRegistryRecord">REST API Reference for DeleteRegistryRecord Operation</seealso>
        DeleteRegistryRecordResponse DeleteRegistryRecord(DeleteRegistryRecordRequest request);
#endif

        /// <summary>
        /// Deletes a registry record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/DeleteRegistryRecord">REST API Reference for DeleteRegistryRecord Operation</seealso>
        Task<DeleteRegistryRecordResponse> DeleteRegistryRecordAsync(DeleteRegistryRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Remove a registry record's publisher association and release its public identifier.
        /// A successful call returns an empty response. Disassociating a registry record that
        /// has no association succeeds. If another account created the association, the request
        /// fails with AccessDeniedException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePublisher service method.</param>
        /// <returns>The response from the DisassociatePublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/DisassociatePublisher">REST API Reference for DisassociatePublisher Operation</seealso>
        DisassociatePublisherResponse DisassociatePublisher(DisassociatePublisherRequest request);
#endif

        /// <summary>
        /// Remove a registry record's publisher association and release its public identifier.
        /// A successful call returns an empty response. Disassociating a registry record that
        /// has no association succeeds. If another account created the association, the request
        /// fails with AccessDeniedException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePublisher service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociatePublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/DisassociatePublisher">REST API Reference for DisassociatePublisher Operation</seealso>
        Task<DisassociatePublisherResponse> DisassociatePublisherAsync(DisassociatePublisherRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get a publisher, including its verification status and the DNS challenge for its domain.
        /// If the publisher ARN names your account and the publisher doesn't exist, the request
        /// fails with ResourceNotFoundException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublisher service method.</param>
        /// <returns>The response from the GetPublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/GetPublisher">REST API Reference for GetPublisher Operation</seealso>
        GetPublisherResponse GetPublisher(GetPublisherRequest request);
#endif

        /// <summary>
        /// Get a publisher, including its verification status and the DNS challenge for its domain.
        /// If the publisher ARN names your account and the publisher doesn't exist, the request
        /// fails with ResourceNotFoundException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublisher service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/GetPublisher">REST API Reference for GetPublisher Operation</seealso>
        Task<GetPublisherResponse> GetPublisherAsync(GetPublisherRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets a registry by identifier (ARN or ID)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistry service method.</param>
        /// <returns>The response from the GetRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/GetRegistry">REST API Reference for GetRegistry Operation</seealso>
        GetRegistryResponse GetRegistry(GetRegistryRequest request);
#endif

        /// <summary>
        /// Gets a registry by identifier (ARN or ID)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/GetRegistry">REST API Reference for GetRegistry Operation</seealso>
        Task<GetRegistryResponse> GetRegistryAsync(GetRegistryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the details of a registry record. The response describes the record's latest
        /// revision, including a revision that isn't approved yet. For a skill record, the operation
        /// also returns the skill package in <c>artifact</c> and the source that the registry
        /// last synchronized the skill from in <c>synchronizedSource</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistryRecord service method.</param>
        /// <returns>The response from the GetRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/GetRegistryRecord">REST API Reference for GetRegistryRecord Operation</seealso>
        GetRegistryRecordResponse GetRegistryRecord(GetRegistryRecordRequest request);
#endif

        /// <summary>
        /// Retrieves the details of a registry record. The response describes the record's latest
        /// revision, including a revision that isn't approved yet. For a skill record, the operation
        /// also returns the skill package in <c>artifact</c> and the source that the registry
        /// last synchronized the skill from in <c>synchronizedSource</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/GetRegistryRecord">REST API Reference for GetRegistryRecord Operation</seealso>
        Task<GetRegistryRecordResponse> GetRegistryRecordAsync(GetRegistryRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List the registry record associations your account created. Pass publisherArn to list
        /// only the associations for that publisher; omit it to list associations across all
        /// publishers. Results are eventually consistent, so an association you just created
        /// or removed can take a few seconds to appear in or disappear from the list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublisherAssociations service method.</param>
        /// <returns>The response from the ListPublisherAssociations service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListPublisherAssociations">REST API Reference for ListPublisherAssociations Operation</seealso>
        ListPublisherAssociationsResponse ListPublisherAssociations(ListPublisherAssociationsRequest request);
#endif

        /// <summary>
        /// List the registry record associations your account created. Pass publisherArn to list
        /// only the associations for that publisher; omit it to list associations across all
        /// publishers. Results are eventually consistent, so an association you just created
        /// or removed can take a few seconds to appear in or disappear from the list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublisherAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPublisherAssociations service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListPublisherAssociations">REST API Reference for ListPublisherAssociations Operation</seealso>
        Task<ListPublisherAssociationsResponse> ListPublisherAssociationsAsync(ListPublisherAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List the publishers your account owns, followed by the ACTIVE publishers shared with
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublishers service method.</param>
        /// <returns>The response from the ListPublishers service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListPublishers">REST API Reference for ListPublishers Operation</seealso>
        ListPublishersResponse ListPublishers(ListPublishersRequest request);
#endif

        /// <summary>
        /// List the publishers your account owns, followed by the ACTIVE publishers shared with
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublishers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPublishers service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListPublishers">REST API Reference for ListPublishers Operation</seealso>
        Task<ListPublishersResponse> ListPublishersAsync(ListPublishersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the registries in the caller's account and Region, with optional filtering by
        /// status and discovery authorizer type
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// <returns>The response from the ListRegistries service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        ListRegistriesResponse ListRegistries(ListRegistriesRequest request);
#endif

        /// <summary>
        /// Lists the registries in the caller's account and Region, with optional filtering by
        /// status and discovery authorizer type
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRegistries service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        Task<ListRegistriesResponse> ListRegistriesAsync(ListRegistriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the registry records within a registry, with optional filtering by name, status,
        /// and record type
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistryRecords service method.</param>
        /// <returns>The response from the ListRegistryRecords service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListRegistryRecords">REST API Reference for ListRegistryRecords Operation</seealso>
        ListRegistryRecordsResponse ListRegistryRecords(ListRegistryRecordsRequest request);
#endif

        /// <summary>
        /// Lists the registry records within a registry, with optional filtering by name, status,
        /// and record type
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRegistryRecords service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListRegistryRecords">REST API Reference for ListRegistryRecords Operation</seealso>
        Task<ListRegistryRecordsResponse> ListRegistryRecordsAsync(ListRegistryRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags associated with the specified Amazon Web Services Agent Registry resource.
        /// Returns the current tag key-value pairs on the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Lists the tags associated with the specified Amazon Web Services Agent Registry resource.
        /// Returns the current tag key-value pairs on the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Submits a DRAFT registry record for approval, moving it into the registry's approval
        /// workflow. Depending on the registry's approval configuration, the record is either
        /// auto-approved or set to PENDING_APPROVAL for a curator to approve or reject.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitRegistryRecordForApproval service method.</param>
        /// <returns>The response from the SubmitRegistryRecordForApproval service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/SubmitRegistryRecordForApproval">REST API Reference for SubmitRegistryRecordForApproval Operation</seealso>
        SubmitRegistryRecordForApprovalResponse SubmitRegistryRecordForApproval(SubmitRegistryRecordForApprovalRequest request);
#endif

        /// <summary>
        /// Submits a DRAFT registry record for approval, moving it into the registry's approval
        /// workflow. Depending on the registry's approval configuration, the record is either
        /// auto-approved or set to PENDING_APPROVAL for a curator to approve or reject.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitRegistryRecordForApproval service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SubmitRegistryRecordForApproval service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/SubmitRegistryRecordForApproval">REST API Reference for SubmitRegistryRecordForApproval Operation</seealso>
        Task<SubmitRegistryRecordForApprovalResponse> SubmitRegistryRecordForApprovalAsync(SubmitRegistryRecordForApprovalRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds or overwrites one or more tags for the specified Amazon Web Services Agent Registry
        /// resource. Tags are key-value pairs that you can use to categorize and manage Amazon
        /// Web Services resources. If a tag with the same key already exists on the resource,
        /// the service replaces its value with the value you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds or overwrites one or more tags for the specified Amazon Web Services Agent Registry
        /// resource. Tags are key-value pairs that you can use to categorize and manage Amazon
        /// Web Services resources. If a tag with the same key already exists on the resource,
        /// the service replaces its value with the value you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes one or more tags from the specified Amazon Web Services Agent Registry resource.
        /// The operation removes only the tags whose keys you supply; other tags on the resource
        /// remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes one or more tags from the specified Amazon Web Services Agent Registry resource.
        /// The operation removes only the tags whose keys you supply; other tags on the resource
        /// remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Record the curator's decision (APPROVED or REJECTED) on a registry record's publisher
        /// association. A successful call returns an empty response. Repeating the decision the
        /// association already holds changes nothing; the same approvalStatus with a different
        /// approvalStatusReason updates the reason. If the caller has no publisher association
        /// for the registry record, the request fails with AccessDeniedException. A ConflictException
        /// (HTTP 409) means the association is not in a state that accepts the decision (e.g.
        /// not PENDING_APPROVAL/APPROVED/REJECTED) or it changed while the request was being
        /// applied; read it again before deciding whether to resubmit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublisherAssociationApprovalStatus service method.</param>
        /// <returns>The response from the UpdatePublisherAssociationApprovalStatus service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdatePublisherAssociationApprovalStatus">REST API Reference for UpdatePublisherAssociationApprovalStatus Operation</seealso>
        UpdatePublisherAssociationApprovalStatusResponse UpdatePublisherAssociationApprovalStatus(UpdatePublisherAssociationApprovalStatusRequest request);
#endif

        /// <summary>
        /// Record the curator's decision (APPROVED or REJECTED) on a registry record's publisher
        /// association. A successful call returns an empty response. Repeating the decision the
        /// association already holds changes nothing; the same approvalStatus with a different
        /// approvalStatusReason updates the reason. If the caller has no publisher association
        /// for the registry record, the request fails with AccessDeniedException. A ConflictException
        /// (HTTP 409) means the association is not in a state that accepts the decision (e.g.
        /// not PENDING_APPROVAL/APPROVED/REJECTED) or it changed while the request was being
        /// applied; read it again before deciding whether to resubmit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublisherAssociationApprovalStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdatePublisherAssociationApprovalStatus service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdatePublisherAssociationApprovalStatus">REST API Reference for UpdatePublisherAssociationApprovalStatus Operation</seealso>
        Task<UpdatePublisherAssociationApprovalStatusResponse> UpdatePublisherAssociationApprovalStatusAsync(UpdatePublisherAssociationApprovalStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing registry. This operation uses PATCH semantics: specify only the
        /// fields you want to change, and omit the rest to leave them unchanged. Updates are
        /// applied asynchronously and the registry transitions to the UPDATING status while they
        /// are processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// <returns>The response from the UpdateRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        UpdateRegistryResponse UpdateRegistry(UpdateRegistryRequest request);
#endif

        /// <summary>
        /// Updates an existing registry. This operation uses PATCH semantics: specify only the
        /// fields you want to change, and omit the rest to leave them unchanged. Updates are
        /// applied asynchronously and the registry transitions to the UPDATING status while they
        /// are processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRegistry service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        Task<UpdateRegistryResponse> UpdateRegistryAsync(UpdateRegistryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a registry record. The update is asynchronous: the operation returns the record
        /// with the <c>UPDATING</c> status while the registry processes it. If a GitHub user
        /// must first authorize access to the record's skill source, the operation returns the
        /// record with the <c>UPDATE_PENDING_AUTH</c> status instead. Fields that use update
        /// wrappers follow PATCH semantics: omit the field to leave it unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistryRecord service method.</param>
        /// <returns>The response from the UpdateRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdateRegistryRecord">REST API Reference for UpdateRegistryRecord Operation</seealso>
        UpdateRegistryRecordResponse UpdateRegistryRecord(UpdateRegistryRecordRequest request);
#endif

        /// <summary>
        /// Updates a registry record. The update is asynchronous: the operation returns the record
        /// with the <c>UPDATING</c> status while the registry processes it. If a GitHub user
        /// must first authorize access to the record's skill source, the operation returns the
        /// record with the <c>UPDATE_PENDING_AUTH</c> status instead. Fields that use update
        /// wrappers follow PATCH semantics: omit the field to leave it unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRegistryRecord service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdateRegistryRecord">REST API Reference for UpdateRegistryRecord Operation</seealso>
        Task<UpdateRegistryRecordResponse> UpdateRegistryRecordAsync(UpdateRegistryRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the status of a registry record as part of the registry's curation workflow,
        /// for example to approve or reject a record that is pending approval, or to deprecate
        /// an approved record so that it is no longer discoverable
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistryRecordStatus service method.</param>
        /// <returns>The response from the UpdateRegistryRecordStatus service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdateRegistryRecordStatus">REST API Reference for UpdateRegistryRecordStatus Operation</seealso>
        UpdateRegistryRecordStatusResponse UpdateRegistryRecordStatus(UpdateRegistryRecordStatusRequest request);
#endif

        /// <summary>
        /// Updates the status of a registry record as part of the registry's curation workflow,
        /// for example to approve or reject a record that is pending approval, or to deprecate
        /// an approved record so that it is no longer discoverable
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistryRecordStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRegistryRecordStatus service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/UpdateRegistryRecordStatus">REST API Reference for UpdateRegistryRecordStatus Operation</seealso>
        Task<UpdateRegistryRecordStatusResponse> UpdateRegistryRecordStatusAsync(UpdateRegistryRecordStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Restart domain verification for a publisher in FAILED or SUSPENDED. The publisher
        /// returns to ACTION_REQUIRED with a new domainChallenge, which the response includes.
        /// Update the DNS TXT record with the new recordValue; the previous value no longer verifies
        /// the domain. The request fails with ConflictException when the publisher is ACTIVE,
        /// verification is already in progress (ACTION_REQUIRED), or the publisher is being deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidatePublisher service method.</param>
        /// <returns>The response from the ValidatePublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ValidatePublisher">REST API Reference for ValidatePublisher Operation</seealso>
        ValidatePublisherResponse ValidatePublisher(ValidatePublisherRequest request);
#endif

        /// <summary>
        /// Restart domain verification for a publisher in FAILED or SUSPENDED. The publisher
        /// returns to ACTION_REQUIRED with a new domainChallenge, which the response includes.
        /// Update the DNS TXT record with the new recordValue; the previous value no longer verifies
        /// the domain. The request fails with ConflictException when the publisher is ACTIVE,
        /// verification is already in progress (ACTION_REQUIRED), or the publisher is being deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidatePublisher service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ValidatePublisher service method, as returned by AgentRegistryControl.</returns>
        /// <exception cref="Amazon.AgentRegistryControl.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistryControl.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-control-2025-12-01/ValidatePublisher">REST API Reference for ValidatePublisher Operation</seealso>
        Task<ValidatePublisherResponse> ValidatePublisherAsync(ValidatePublisherRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAgentRegistryControlConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAgentRegistryControlConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAgentRegistryControlConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAgentRegistryControlConfig to create AmazonAgentRegistryControlClient");
            }

            return awsCredentials == null ?
                    new AmazonAgentRegistryControlClient(serviceClientConfig) :
                    new AmazonAgentRegistryControlClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
