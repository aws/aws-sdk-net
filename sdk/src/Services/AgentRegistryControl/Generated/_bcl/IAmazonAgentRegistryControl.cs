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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
    /// AWS Agent Registry is a managed catalog for publishing and discovering resources such
    /// as MCP servers, agents, and agent skills. Agent Registry Control is its control-plane
    /// API: use it to create and manage registries and the records they contain, configure
    /// discovery and authorization, govern record approval and curation workflows, and manage
    /// automatic detection of resources. Data-plane search and MCP invocation operations
    /// are provided by the companion Agent Registry API.
    /// </summary>
    public partial interface IAmazonAgentRegistryControl : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAgentRegistryControlPaginatorFactory Paginators { get; }

        
        #region  CreateRegistry


        /// <summary>
        /// Creates a new registry, a catalog that organizes registry records and defines their
        /// discovery authorization and record approval behavior. Creation is asynchronous: the
        /// registry begins in the CREATING status and becomes usable once it reaches READY.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// 
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



        /// <summary>
        /// Creates a new registry, a catalog that organizes registry records and defines their
        /// discovery authorization and record approval behavior. Creation is asynchronous: the
        /// registry begins in the CREATING status and becomes usable once it reaches READY.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  CreateRegistryRecord


        /// <summary>
        /// Creates a registry record within a registry. A registry record describes a discoverable
        /// resource, such as an MCP server, an agent, an agent skill, or a custom resource. Creation
        /// is asynchronous: the record is returned with the CREATING status while it is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistryRecord service method.</param>
        /// 
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



        /// <summary>
        /// Creates a registry record within a registry. A registry record describes a discoverable
        /// resource, such as an MCP server, an agent, an agent skill, or a custom resource. Creation
        /// is asynchronous: the record is returned with the CREATING status while it is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  DeleteRegistry


        /// <summary>
        /// Deletes a registry. Deletion is asynchronous: the registry transitions to the DELETING
        /// status and is removed along with its registry records.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// 
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



        /// <summary>
        /// Deletes a registry. Deletion is asynchronous: the registry transitions to the DELETING
        /// status and is removed along with its registry records.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  DeleteRegistryRecord


        /// <summary>
        /// Deletes a registry record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistryRecord service method.</param>
        /// 
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



        /// <summary>
        /// Deletes a registry record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  GetRegistry


        /// <summary>
        /// Gets a registry by identifier (ARN or ID)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistry service method.</param>
        /// 
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



        /// <summary>
        /// Gets a registry by identifier (ARN or ID)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  GetRegistryRecord


        /// <summary>
        /// Retrieves the details of a registry record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistryRecord service method.</param>
        /// 
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



        /// <summary>
        /// Retrieves the details of a registry record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  ListRegistries


        /// <summary>
        /// Lists the registries in the caller's account and Region, with optional filtering by
        /// status and discovery authorizer type
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// 
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



        /// <summary>
        /// Lists the registries in the caller's account and Region, with optional filtering by
        /// status and discovery authorizer type
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  ListRegistryRecords


        /// <summary>
        /// Lists the registry records within a registry, with optional filtering by name, status,
        /// and record type
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistryRecords service method.</param>
        /// 
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



        /// <summary>
        /// Lists the registry records within a registry, with optional filtering by name, status,
        /// and record type
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags on a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
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



        /// <summary>
        /// List the tags on a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  SubmitRegistryRecordForApproval


        /// <summary>
        /// Submits a DRAFT registry record for approval, moving it into the registry's approval
        /// workflow. Depending on the registry's approval configuration, the record is either
        /// auto-approved or set to PENDING_APPROVAL for a curator to approve or reject.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitRegistryRecordForApproval service method.</param>
        /// 
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



        /// <summary>
        /// Submits a DRAFT registry record for approval, moving it into the registry's approval
        /// workflow. Depending on the registry's approval configuration, the record is either
        /// auto-approved or set to PENDING_APPROVAL for a curator to approve or reject.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitRegistryRecordForApproval service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag a resource with key-value pairs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
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



        /// <summary>
        /// Tag a resource with key-value pairs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove tags from a resource by key
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
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



        /// <summary>
        /// Remove tags from a resource by key
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  UpdateRegistry


        /// <summary>
        /// Updates an existing registry. This operation uses PATCH semantics: specify only the
        /// fields you want to change, and omit the rest to leave them unchanged. Updates are
        /// applied asynchronously and the registry transitions to the UPDATING status while they
        /// are processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// 
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
        /// 
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

        #endregion
        
        #region  UpdateRegistryRecord


        /// <summary>
        /// Updates a registry record. The update is asynchronous: the record is returned with
        /// the UPDATING status while it is processed. Fields that use update wrappers follow
        /// PATCH semantics: omit the field to leave it unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistryRecord service method.</param>
        /// 
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



        /// <summary>
        /// Updates a registry record. The update is asynchronous: the record is returned with
        /// the UPDATING status while it is processed. Fields that use update wrappers follow
        /// PATCH semantics: omit the field to leave it unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
        
        #region  UpdateRegistryRecordStatus


        /// <summary>
        /// Updates the status of a registry record as part of the registry's curation workflow,
        /// for example to approve or reject a record that is pending approval, or to deprecate
        /// an approved record so that it is no longer discoverable
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistryRecordStatus service method.</param>
        /// 
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



        /// <summary>
        /// Updates the status of a registry record as part of the registry's curation workflow,
        /// for example to approve or reject a record that is pending approval, or to deprecate
        /// an approved record so that it is no longer discoverable
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistryRecordStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}