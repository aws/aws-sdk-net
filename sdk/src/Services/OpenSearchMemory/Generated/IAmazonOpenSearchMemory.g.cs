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
using Amazon.OpenSearchMemory.Model;

#pragma warning disable CS1570

namespace Amazon.OpenSearchMemory
{
    /// <summary>
    /// <para>Interface for accessing OpenSearchMemory</para>
    ///
    /// Amazon OpenSearch Memory lets your AI agents and applications recall facts and summaries
    /// across sessions. Your agents send events, such as conversation turns, and search the
    /// memories derived from them.
    /// 
    ///  
    /// <para>
    /// A space groups related events and memories, and holds the memory strategies that you
    /// configure for them. Use the space operations to create, get, list, update, and delete
    /// spaces. Use the event and memory operations to write, read, list, search, update,
    /// and delete a space's events and memories.
    /// </para>
    /// </summary>
    public partial interface IAmazonOpenSearchMemory : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOpenSearchMemoryPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Gets up to 10 events by ID, each as <c>GetEvent</c> returns it, including its payload.
        /// 
        ///  
        /// <para>
        /// If you supply <c>actorId</c> or <c>sessionId</c>, every requested event must match
        /// it. Each event has its own outcome. The operation reports an event that it can't return
        /// in <c>errors</c> instead of failing, with an error code named for the exception that
        /// <c>GetEvent</c> would return for it. The operation reports both an event that doesn't
        /// exist and an event outside the supplied scope as <c>RESOURCE_NOT_FOUND</c>.
        /// </para>
        ///  
        /// <para>
        /// The exception is the space's customer managed AWS KMS key: if it is disabled, pending
        /// deletion, can't be used for decryption, or was deleted, the whole call fails with
        /// <c>ValidationException</c>, as <c>GetEvent</c> does.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetEvent service method.</param>
        /// <returns>The response from the BatchGetEvent service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/BatchGetEvent">REST API Reference for BatchGetEvent Operation</seealso>
        BatchGetEventResponse BatchGetEvent(BatchGetEventRequest request);
#endif

        /// <summary>
        /// Gets up to 10 events by ID, each as <c>GetEvent</c> returns it, including its payload.
        /// 
        ///  
        /// <para>
        /// If you supply <c>actorId</c> or <c>sessionId</c>, every requested event must match
        /// it. Each event has its own outcome. The operation reports an event that it can't return
        /// in <c>errors</c> instead of failing, with an error code named for the exception that
        /// <c>GetEvent</c> would return for it. The operation reports both an event that doesn't
        /// exist and an event outside the supplied scope as <c>RESOURCE_NOT_FOUND</c>.
        /// </para>
        ///  
        /// <para>
        /// The exception is the space's customer managed AWS KMS key: if it is disabled, pending
        /// deletion, can't be used for decryption, or was deleted, the whole call fails with
        /// <c>ValidationException</c>, as <c>GetEvent</c> does.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the BatchGetEvent service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/BatchGetEvent">REST API Reference for BatchGetEvent Operation</seealso>
        Task<BatchGetEventResponse> BatchGetEventAsync(BatchGetEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Submits an event (conversation turns, structured data, or a PDF document stored in
        /// Amazon S3) to a session in a space.
        /// 
        ///  
        /// <para>
        /// The operation returns as soon as the event is saved. <c>GetEvent</c> and <c>ListEvents</c>
        /// return it immediately. <c>SearchEvents</c> returns it after it's indexed. <c>SearchMemories</c>
        /// returns memories extracted from it only after a strategy's extraction trigger fires
        /// and the memories are indexed.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvent service method.</param>
        /// <returns>The response from the CreateEvent service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/CreateEvent">REST API Reference for CreateEvent Operation</seealso>
        CreateEventResponse CreateEvent(CreateEventRequest request);
#endif

        /// <summary>
        /// Submits an event (conversation turns, structured data, or a PDF document stored in
        /// Amazon S3) to a session in a space.
        /// 
        ///  
        /// <para>
        /// The operation returns as soon as the event is saved. <c>GetEvent</c> and <c>ListEvents</c>
        /// return it immediately. <c>SearchEvents</c> returns it after it's indexed. <c>SearchMemories</c>
        /// returns memories extracted from it only after a strategy's extraction trigger fires
        /// and the memories are indexed.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateEvent service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/CreateEvent">REST API Reference for CreateEvent Operation</seealso>
        Task<CreateEventResponse> CreateEventAsync(CreateEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Writes a memory that you have already formed, without extracting it from events. The
        /// service embeds the text as given and stores it as a memory of the named strategy.
        /// To have the service extract memories from conversation turns, use <c>CreateEvent</c>
        /// instead.
        /// 
        ///  
        /// <para>
        /// The operation returns before the memory is searchable. The returned <c>memoryId</c>
        /// is final, but until the memory is indexed, <c>GetMemory</c>, <c>UpdateMemory</c>,
        /// and <c>DeleteMemory</c> return <c>ResourceNotFoundException</c> for it.
        /// </para>
        ///  
        /// <para>
        /// If the request would exceed the service's rate for embedding requests, it fails with
        /// <c>ThrottlingException</c>. Retry with exponential backoff.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMemory service method.</param>
        /// <returns>The response from the CreateMemory service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/CreateMemory">REST API Reference for CreateMemory Operation</seealso>
        CreateMemoryResponse CreateMemory(CreateMemoryRequest request);
#endif

        /// <summary>
        /// Writes a memory that you have already formed, without extracting it from events. The
        /// service embeds the text as given and stores it as a memory of the named strategy.
        /// To have the service extract memories from conversation turns, use <c>CreateEvent</c>
        /// instead.
        /// 
        ///  
        /// <para>
        /// The operation returns before the memory is searchable. The returned <c>memoryId</c>
        /// is final, but until the memory is indexed, <c>GetMemory</c>, <c>UpdateMemory</c>,
        /// and <c>DeleteMemory</c> return <c>ResourceNotFoundException</c> for it.
        /// </para>
        ///  
        /// <para>
        /// If the request would exceed the service's rate for embedding requests, it fails with
        /// <c>ThrottlingException</c>. Retry with exponential backoff.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMemory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateMemory service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/CreateMemory">REST API Reference for CreateMemory Operation</seealso>
        Task<CreateMemoryResponse> CreateMemoryAsync(CreateMemoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a space. A space is an AWS resource that stores the events you send and the
        /// memories extracted from them, and defines the memory strategies that extract those
        /// memories.
        /// 
        ///  
        /// <para>
        /// The operation returns before provisioning finishes, with <c>status</c> <c>CREATING</c>.
        /// Call <c>GetSpace</c> until the status is <c>ACTIVE</c>, and then use the space. If
        /// provisioning fails, the status becomes <c>FAILED</c> and <c>statusReason</c> says
        /// why.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace service method.</param>
        /// <returns>The response from the CreateSpace service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ServiceQuotaExceededException">
        /// The request would exceed a quota, such as the number of spaces in your account or
        /// the number of strategies in a space.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        CreateSpaceResponse CreateSpace(CreateSpaceRequest request);
#endif

        /// <summary>
        /// Creates a space. A space is an AWS resource that stores the events you send and the
        /// memories extracted from them, and defines the memory strategies that extract those
        /// memories.
        /// 
        ///  
        /// <para>
        /// The operation returns before provisioning finishes, with <c>status</c> <c>CREATING</c>.
        /// Call <c>GetSpace</c> until the status is <c>ACTIVE</c>, and then use the space. If
        /// provisioning fails, the status becomes <c>FAILED</c> and <c>statusReason</c> says
        /// why.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateSpace service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ServiceQuotaExceededException">
        /// The request would exceed a quota, such as the number of spaces in your account or
        /// the number of strategies in a space.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an event. Deletion can't be undone. The event stops appearing in <c>SearchEvents</c>
        /// results shortly after you delete it. Deleting an event that doesn't exist returns
        /// <c>ResourceNotFoundException</c>.
        /// 
        ///  
        /// <para>
        /// Deleting an event doesn't delete the memories derived from it, because a memory can
        /// combine content from several events. To remove them, use <c>DeleteMemory</c>.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// <returns>The response from the DeleteEvent service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        DeleteEventResponse DeleteEvent(DeleteEventRequest request);
#endif

        /// <summary>
        /// Deletes an event. Deletion can't be undone. The event stops appearing in <c>SearchEvents</c>
        /// results shortly after you delete it. Deleting an event that doesn't exist returns
        /// <c>ResourceNotFoundException</c>.
        /// 
        ///  
        /// <para>
        /// Deleting an event doesn't delete the memories derived from it, because a memory can
        /// combine content from several events. To remove them, use <c>DeleteMemory</c>.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteEvent service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        Task<DeleteEventResponse> DeleteEventAsync(DeleteEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a memory, including its content and embedding. Deletion can't be undone. Searches
        /// stop returning the memory shortly after you delete it.
        /// 
        ///  
        /// <para>
        /// Deleting a memory that no longer exists returns <c>ResourceNotFoundException</c>,
        /// so the operation is not idempotent. If you retry deletes, treat that error as success.
        /// </para>
        ///  
        /// <para>
        /// A memory past its expiry (set from the space's <c>memoryExpiryDays</c> when the memory
        /// is written) reads as not found: the operation returns <c>ResourceNotFoundException</c>,
        /// as for a memory that was already deleted.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemory service method.</param>
        /// <returns>The response from the DeleteMemory service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/DeleteMemory">REST API Reference for DeleteMemory Operation</seealso>
        DeleteMemoryResponse DeleteMemory(DeleteMemoryRequest request);
#endif

        /// <summary>
        /// Deletes a memory, including its content and embedding. Deletion can't be undone. Searches
        /// stop returning the memory shortly after you delete it.
        /// 
        ///  
        /// <para>
        /// Deleting a memory that no longer exists returns <c>ResourceNotFoundException</c>,
        /// so the operation is not idempotent. If you retry deletes, treat that error as success.
        /// </para>
        ///  
        /// <para>
        /// A memory past its expiry (set from the space's <c>memoryExpiryDays</c> when the memory
        /// is written) reads as not found: the operation returns <c>ResourceNotFoundException</c>,
        /// as for a memory that was already deleted.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteMemory service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/DeleteMemory">REST API Reference for DeleteMemory Operation</seealso>
        Task<DeleteMemoryResponse> DeleteMemoryAsync(DeleteMemoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a space and its memories. Deletion can't be undone. After you delete the space,
        /// you can't retrieve its events, and the service removes them when they reach their
        /// expiry.
        /// 
        ///  
        /// <para>
        /// The operation returns with <c>status</c> <c>DELETING</c>. When deletion finishes,
        /// <c>GetSpace</c> returns <c>ResourceNotFoundException</c>. If deletion fails, the status
        /// becomes <c>FAILED</c>. A space that is <c>CREATING</c> or <c>UPDATING</c> can't be
        /// deleted until that finishes: the request fails with <c>ConflictException</c>. Deleting
        /// a space that is already <c>DELETING</c> returns <c>DELETING</c> again.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// <returns>The response from the DeleteSpace service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request);
#endif

        /// <summary>
        /// Deletes a space and its memories. Deletion can't be undone. After you delete the space,
        /// you can't retrieve its events, and the service removes them when they reach their
        /// expiry.
        /// 
        ///  
        /// <para>
        /// The operation returns with <c>status</c> <c>DELETING</c>. When deletion finishes,
        /// <c>GetSpace</c> returns <c>ResourceNotFoundException</c>. If deletion fails, the status
        /// becomes <c>FAILED</c>. A space that is <c>CREATING</c> or <c>UPDATING</c> can't be
        /// deleted until that finishes: the request fails with <c>ConflictException</c>. Deleting
        /// a space that is already <c>DELETING</c> returns <c>DELETING</c> again.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteSpace service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets an event by ID, including its payload.
        /// 
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvent service method.</param>
        /// <returns>The response from the GetEvent service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/GetEvent">REST API Reference for GetEvent Operation</seealso>
        GetEventResponse GetEvent(GetEventRequest request);
#endif

        /// <summary>
        /// Gets an event by ID, including its payload.
        /// 
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetEvent service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/GetEvent">REST API Reference for GetEvent Operation</seealso>
        Task<GetEventResponse> GetEventAsync(GetEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets a memory by ID, as returned by <c>SearchMemories</c> or <c>ListMemories</c>.
        /// A memory that doesn't exist returns <c>ResourceNotFoundException</c>. Unlike <c>SearchMemories</c>,
        /// this operation also returns memories that consolidation has superseded.
        /// 
        ///  
        /// <para>
        /// A memory past its expiry (set from the space's <c>memoryExpiryDays</c> when the memory
        /// is written) reads as not found: <c>ResourceNotFoundException</c>, the same answer
        /// as for an ID that does not exist.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemory service method.</param>
        /// <returns>The response from the GetMemory service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/GetMemory">REST API Reference for GetMemory Operation</seealso>
        GetMemoryResponse GetMemory(GetMemoryRequest request);
#endif

        /// <summary>
        /// Gets a memory by ID, as returned by <c>SearchMemories</c> or <c>ListMemories</c>.
        /// A memory that doesn't exist returns <c>ResourceNotFoundException</c>. Unlike <c>SearchMemories</c>,
        /// this operation also returns memories that consolidation has superseded.
        /// 
        ///  
        /// <para>
        /// A memory past its expiry (set from the space's <c>memoryExpiryDays</c> when the memory
        /// is written) reads as not found: <c>ResourceNotFoundException</c>, the same answer
        /// as for an ID that does not exist.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetMemory service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/GetMemory">REST API Reference for GetMemory Operation</seealso>
        Task<GetMemoryResponse> GetMemoryAsync(GetMemoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a space's configuration and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// <returns>The response from the GetSpace service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/GetSpace">REST API Reference for GetSpace Operation</seealso>
        GetSpaceResponse GetSpace(GetSpaceRequest request);
#endif

        /// <summary>
        /// Returns a space's configuration and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetSpace service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/GetSpace">REST API Reference for GetSpace Operation</seealso>
        Task<GetSpaceResponse> GetSpaceAsync(GetSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the events in a session, sorted by time. Optionally limit the results to events
        /// whose <c>eventTimestamp</c> falls between <c>eventTimestampAfter</c> and <c>eventTimestampBefore</c>.
        /// Returns event metadata only. Call <c>GetEvent</c> for the payload. For full-text or
        /// relevance search, use <c>SearchEvents</c>.
        /// 
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvents service method.</param>
        /// <returns>The response from the ListEvents service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/ListEvents">REST API Reference for ListEvents Operation</seealso>
        ListEventsResponse ListEvents(ListEventsRequest request);
#endif

        /// <summary>
        /// Lists the events in a session, sorted by time. Optionally limit the results to events
        /// whose <c>eventTimestamp</c> falls between <c>eventTimestampAfter</c> and <c>eventTimestampBefore</c>.
        /// Returns event metadata only. Call <c>GetEvent</c> for the payload. For full-text or
        /// relevance search, use <c>SearchEvents</c>.
        /// 
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListEvents service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/ListEvents">REST API Reference for ListEvents Operation</seealso>
        Task<ListEventsResponse> ListEventsAsync(ListEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists a space's memories without a query, for example the most recent memories or
        /// the memories of one strategy. Filter by strategy and optionally by owning actor or
        /// session, sort by creation or update time, and page through the results. Results have
        /// no relevance score. To query or filter by metadata, use <c>SearchMemories</c>.
        /// 
        ///  
        /// <para>
        /// If memories are written or deleted while you page, the results can skip a memory or
        /// return it twice. You can page through only a limited number of results. A request
        /// past that limit fails with <c>ValidationException</c> (reason <c>invalidNextToken</c>),
        /// and the message gives the limit.
        /// </para>
        ///  
        /// <para>
        /// Memories past their expiry (set from the space's <c>memoryExpiryDays</c> when each
        /// memory is written) are left out. Unlike <c>SearchMemories</c>, this operation also
        /// returns memories that consolidation has superseded.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemories service method.</param>
        /// <returns>The response from the ListMemories service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/ListMemories">REST API Reference for ListMemories Operation</seealso>
        ListMemoriesResponse ListMemories(ListMemoriesRequest request);
#endif

        /// <summary>
        /// Lists a space's memories without a query, for example the most recent memories or
        /// the memories of one strategy. Filter by strategy and optionally by owning actor or
        /// session, sort by creation or update time, and page through the results. Results have
        /// no relevance score. To query or filter by metadata, use <c>SearchMemories</c>.
        /// 
        ///  
        /// <para>
        /// If memories are written or deleted while you page, the results can skip a memory or
        /// return it twice. You can page through only a limited number of results. A request
        /// past that limit fails with <c>ValidationException</c> (reason <c>invalidNextToken</c>),
        /// and the message gives the limit.
        /// </para>
        ///  
        /// <para>
        /// Memories past their expiry (set from the space's <c>memoryExpiryDays</c> when each
        /// memory is written) are left out. Unlike <c>SearchMemories</c>, this operation also
        /// returns memories that consolidation has superseded.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListMemories service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/ListMemories">REST API Reference for ListMemories Operation</seealso>
        Task<ListMemoriesResponse> ListMemoriesAsync(ListMemoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the spaces in your account in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// <returns>The response from the ListSpaces service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        ListSpacesResponse ListSpaces(ListSpacesRequest request);
#endif

        /// <summary>
        /// Lists the spaces in your account in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSpaces service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        Task<ListSpacesResponse> ListSpacesAsync(ListSpacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags for the specified space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Lists the tags for the specified space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Searches a space's events by relevance. It works like <c>SearchMemories</c> without
        /// the memory type and strategy selector. The query is a subset of the OpenSearch Query
        /// DSL. The service validates it, limits the search to the actor in <c>actorId</c> and
        /// the sessions in <c>sessionIds</c>, and returns ranked results. Each result is the
        /// matching chunk of an event, not the whole event. You can page through only a limited
        /// number of results. A request past that limit fails with <c>ValidationException</c>
        /// (reason <c>invalidNextToken</c>), and the message gives the limit.
        /// 
        ///  
        /// <para>
        /// If the results are larger than 5 MiB, the request fails with <c>ValidationException</c>
        /// (reason <c>queryBodyTooLarge</c>). Lower <c>maxResults</c>.
        /// </para>
        ///  
        /// <para>
        /// If the request would exceed the service's rate for embedding requests, it fails with
        /// <c>ThrottlingException</c>. Retry with exponential backoff.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchEvents service method.</param>
        /// <returns>The response from the SearchEvents service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/SearchEvents">REST API Reference for SearchEvents Operation</seealso>
        SearchEventsResponse SearchEvents(SearchEventsRequest request);
#endif

        /// <summary>
        /// Searches a space's events by relevance. It works like <c>SearchMemories</c> without
        /// the memory type and strategy selector. The query is a subset of the OpenSearch Query
        /// DSL. The service validates it, limits the search to the actor in <c>actorId</c> and
        /// the sessions in <c>sessionIds</c>, and returns ranked results. Each result is the
        /// matching chunk of an event, not the whole event. You can page through only a limited
        /// number of results. A request past that limit fails with <c>ValidationException</c>
        /// (reason <c>invalidNextToken</c>), and the message gives the limit.
        /// 
        ///  
        /// <para>
        /// If the results are larger than 5 MiB, the request fails with <c>ValidationException</c>
        /// (reason <c>queryBodyTooLarge</c>). Lower <c>maxResults</c>.
        /// </para>
        ///  
        /// <para>
        /// If the request would exceed the service's rate for embedding requests, it fails with
        /// <c>ThrottlingException</c>. Retry with exponential backoff.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SearchEvents service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/SearchEvents">REST API Reference for SearchEvents Operation</seealso>
        Task<SearchEventsResponse> SearchEventsAsync(SearchEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Searches a space's memories by relevance. The query is a subset of the OpenSearch
        /// Query DSL. The service validates it, limits the search to the requested strategies
        /// and to the actor in <c>actorId</c>, and returns one ranked list of memories. You can
        /// page through only a limited number of results. A request past that limit fails with
        /// <c>ValidationException</c> (reason <c>invalidNextToken</c>), and the message gives
        /// the limit.
        /// 
        ///  
        /// <para>
        /// Memories past their expiry (set from the space's <c>memoryExpiryDays</c> when each
        /// memory is written) are left out of the results. Only current memories are returned:
        /// a memory that consolidation has superseded (an older version of a fact that a newer
        /// memory replaced) is left out.
        /// </para>
        ///  
        /// <para>
        /// If the results are larger than 5 MiB, the request fails with <c>ValidationException</c>
        /// (reason <c>queryBodyTooLarge</c>). Lower <c>maxResults</c>.
        /// </para>
        ///  
        /// <para>
        /// If the request would exceed the service's rate for embedding requests, it fails with
        /// <c>ThrottlingException</c>. Retry with exponential backoff.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchMemories service method.</param>
        /// <returns>The response from the SearchMemories service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/SearchMemories">REST API Reference for SearchMemories Operation</seealso>
        SearchMemoriesResponse SearchMemories(SearchMemoriesRequest request);
#endif

        /// <summary>
        /// Searches a space's memories by relevance. The query is a subset of the OpenSearch
        /// Query DSL. The service validates it, limits the search to the requested strategies
        /// and to the actor in <c>actorId</c>, and returns one ranked list of memories. You can
        /// page through only a limited number of results. A request past that limit fails with
        /// <c>ValidationException</c> (reason <c>invalidNextToken</c>), and the message gives
        /// the limit.
        /// 
        ///  
        /// <para>
        /// Memories past their expiry (set from the space's <c>memoryExpiryDays</c> when each
        /// memory is written) are left out of the results. Only current memories are returned:
        /// a memory that consolidation has superseded (an older version of a fact that a newer
        /// memory replaced) is left out.
        /// </para>
        ///  
        /// <para>
        /// If the results are larger than 5 MiB, the request fails with <c>ValidationException</c>
        /// (reason <c>queryBodyTooLarge</c>). Lower <c>maxResults</c>.
        /// </para>
        ///  
        /// <para>
        /// If the request would exceed the service's rate for embedding requests, it fails with
        /// <c>ThrottlingException</c>. Retry with exponential backoff.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchMemories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SearchMemories service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/SearchMemories">REST API Reference for SearchMemories Operation</seealso>
        Task<SearchMemoriesResponse> SearchMemoriesAsync(SearchMemoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds the specified tags to the specified space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds the specified tags to the specified space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes the specified tags from the specified space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes the specified tags from the specified space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a memory in place. Supply only the fields to change. Omitted fields keep their
        /// stored values. A request must supply <c>content</c> or <c>metadata</c>, or it fails
        /// with <c>ValidationException</c>. Supplying <c>content</c> re-embeds the memory. A
        /// change to metadata alone doesn't.
        /// 
        ///  
        /// <para>
        /// The memory keeps its <c>memoryId</c> across updates. Shortly after an update, searches
        /// stop returning the previous content.
        /// </para>
        ///  
        /// <para>
        ///  <c>memoryType</c> can't be changed. To change it, delete the memory and create a
        /// new one.
        /// </para>
        ///  
        /// <para>
        /// A memory past its expiry (set from the space's <c>memoryExpiryDays</c> when the memory
        /// is written) reads as not found: the operation fails with <c>ResourceNotFoundException</c>
        /// and changes nothing. An update does not move the expiry.
        /// </para>
        ///  
        /// <para>
        /// Concurrent updates to one memory are last-writer-wins. There is no version check.
        /// To avoid lost updates, serialize your updates to a memory.
        /// </para>
        ///  
        /// <para>
        /// If you supply <c>content</c> and the request would exceed the service's rate for embedding
        /// requests, it fails with <c>ThrottlingException</c>. Retry with exponential backoff.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemory service method.</param>
        /// <returns>The response from the UpdateMemory service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/UpdateMemory">REST API Reference for UpdateMemory Operation</seealso>
        UpdateMemoryResponse UpdateMemory(UpdateMemoryRequest request);
#endif

        /// <summary>
        /// Updates a memory in place. Supply only the fields to change. Omitted fields keep their
        /// stored values. A request must supply <c>content</c> or <c>metadata</c>, or it fails
        /// with <c>ValidationException</c>. Supplying <c>content</c> re-embeds the memory. A
        /// change to metadata alone doesn't.
        /// 
        ///  
        /// <para>
        /// The memory keeps its <c>memoryId</c> across updates. Shortly after an update, searches
        /// stop returning the previous content.
        /// </para>
        ///  
        /// <para>
        ///  <c>memoryType</c> can't be changed. To change it, delete the memory and create a
        /// new one.
        /// </para>
        ///  
        /// <para>
        /// A memory past its expiry (set from the space's <c>memoryExpiryDays</c> when the memory
        /// is written) reads as not found: the operation fails with <c>ResourceNotFoundException</c>
        /// and changes nothing. An update does not move the expiry.
        /// </para>
        ///  
        /// <para>
        /// Concurrent updates to one memory are last-writer-wins. There is no version check.
        /// To avoid lost updates, serialize your updates to a memory.
        /// </para>
        ///  
        /// <para>
        /// If you supply <c>content</c> and the request would exceed the service's rate for embedding
        /// requests, it fails with <c>ThrottlingException</c>. Retry with exponential backoff.
        /// </para>
        ///  
        /// <para>
        /// If the space uses a customer managed AWS KMS key, the call can also fail because of
        /// the key. It fails with <c>AccessDeniedException</c> if you aren't allowed to use the
        /// key, and with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails
        /// with <c>ValidationException</c> if the key is disabled, pending deletion, or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateMemory service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/UpdateMemory">REST API Reference for UpdateMemory Operation</seealso>
        Task<UpdateMemoryResponse> UpdateMemoryAsync(UpdateMemoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a space's memory strategies, retention settings, or extraction model. Supply
        /// only the fields to change. Omitted fields keep their current values.
        /// 
        ///  
        /// <para>
        /// If the request changes the set of strategies, a strategy's configuration, a retention
        /// setting, or the extraction model, the space moves to <c>UPDATING</c>. When the change
        /// is complete, the space returns to <c>ACTIVE</c>, or moves to <c>FAILED</c> if the
        /// change can't be applied. While the space is <c>UPDATING</c>, <c>GetSpace</c> returns
        /// the previous configuration. A request that only changes strategy descriptions or repeats
        /// the values the space has stored is applied immediately and doesn't change the status.
        /// Sending a retention value that the space never set also moves the space to <c>UPDATING</c>,
        /// even one that matches the behavior without it, such as 90 for <c>eventExpiryDays</c>
        /// or 0 for <c>memoryExpiryDays</c>. A space that is <c>CREATING</c>, <c>UPDATING</c>,
        /// or <c>DELETING</c> can't be updated: the request fails with <c>ConflictException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// <returns>The response from the UpdateSpace service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ServiceQuotaExceededException">
        /// The request would exceed a quota, such as the number of spaces in your account or
        /// the number of strategies in a space.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request);
#endif

        /// <summary>
        /// Updates a space's memory strategies, retention settings, or extraction model. Supply
        /// only the fields to change. Omitted fields keep their current values.
        /// 
        ///  
        /// <para>
        /// If the request changes the set of strategies, a strategy's configuration, a retention
        /// setting, or the extraction model, the space moves to <c>UPDATING</c>. When the change
        /// is complete, the space returns to <c>ACTIVE</c>, or moves to <c>FAILED</c> if the
        /// change can't be applied. While the space is <c>UPDATING</c>, <c>GetSpace</c> returns
        /// the previous configuration. A request that only changes strategy descriptions or repeats
        /// the values the space has stored is applied immediately and doesn't change the status.
        /// Sending a retention value that the space never set also moves the space to <c>UPDATING</c>,
        /// even one that matches the behavior without it, such as 90 for <c>eventExpiryDays</c>
        /// or 0 for <c>memoryExpiryDays</c>. A space that is <c>CREATING</c>, <c>UPDATING</c>,
        /// or <c>DELETING</c> can't be updated: the request fails with <c>ConflictException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateSpace service method, as returned by OpenSearchMemory.</returns>
        /// <exception cref="Amazon.OpenSearchMemory.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. To use this operation,
        /// you must have AWS Identity and Access Management (IAM) permissions for the operation,
        /// and on the resource it acts on. If the space uses a customer managed AWS Key Management
        /// Service (AWS KMS) key, you must also have permission to use the key.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the space
        /// is being created, updated, or deleted, a space with the same name already exists,
        /// or you reused a client token with different parameters. Wait for the space to finish
        /// being created, updated, or deleted, or use a different name or client token, and then
        /// retry.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.InternalServerException">
        /// The service couldn't process the request because of an internal error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the IDs in the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ServiceQuotaExceededException">
        /// The request would exceed a quota, such as the number of spaces in your account or
        /// the number of strategies in a space.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ThrottlingException">
        /// The service throttled the request. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchMemory.Model.ValidationException">
        /// The request isn't valid. The <c>reason</c>, <c>message</c>, and <c>fieldList</c> members
        /// describe the problem. Fix the request, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchmemory-2026-08-24/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonOpenSearchMemoryConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonOpenSearchMemoryConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonOpenSearchMemoryConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonOpenSearchMemoryConfig to create AmazonOpenSearchMemoryClient");
            }

            return awsCredentials == null ?
                    new AmazonOpenSearchMemoryClient(serviceClientConfig) :
                    new AmazonOpenSearchMemoryClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
