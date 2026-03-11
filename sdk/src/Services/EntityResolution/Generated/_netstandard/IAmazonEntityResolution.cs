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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EntityResolution.Model;

#pragma warning disable CS1570
namespace Amazon.EntityResolution
{
    /// <summary>
    /// <para>Interface for accessing EntityResolution</para>
    ///
    /// Welcome to the <i>Entity Resolution API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Entity Resolution is an Amazon Web Services service that provides pre-configured entity
    /// resolution capabilities that enable developers and analysts at advertising and marketing
    /// companies to build an accurate and complete view of their consumers.
    /// </para>
    ///  
    /// <para>
    ///  With Entity Resolution, you can match source records containing consumer identifiers,
    /// such as name, email address, and phone number. This is true even when these records
    /// have incomplete or conflicting identifiers. For example, Entity Resolution can effectively
    /// match a source record from a customer relationship management (CRM) system with a
    /// source record from a marketing system containing campaign information.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Entity Resolution concepts, procedures, and best practices, see
    /// the <a href="https://docs.aws.amazon.com/entityresolution/latest/userguide/what-is-service.html">Entity
    /// Resolution User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonEntityResolution : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IEntityResolutionPaginatorFactory Paginators { get; }
#endif
                
        #region  AddPolicyStatement



        /// <summary>
        /// Adds a policy statement object. To retrieve a list of existing policy statements,
        /// use the <c>GetPolicy</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPolicyStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPolicyStatement service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/AddPolicyStatement">REST API Reference for AddPolicyStatement Operation</seealso>
        Task<AddPolicyStatementResponse> AddPolicyStatementAsync(AddPolicyStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteUniqueId



        /// <summary>
        /// Deletes multiple unique IDs in a matching workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUniqueId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteUniqueId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/BatchDeleteUniqueId">REST API Reference for BatchDeleteUniqueId Operation</seealso>
        Task<BatchDeleteUniqueIdResponse> BatchDeleteUniqueIdAsync(BatchDeleteUniqueIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIdMappingWorkflow



        /// <summary>
        /// Creates an <c>IdMappingWorkflow</c> object which stores the configuration of the data
        /// processing job to be run. Each <c>IdMappingWorkflow</c> must have a unique workflow
        /// name. To modify an existing workflow, use the UpdateIdMappingWorkflow API.
        /// 
        ///  <important> 
        /// <para>
        /// Incremental processing is not supported for ID mapping workflows. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdMappingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdMappingWorkflow">REST API Reference for CreateIdMappingWorkflow Operation</seealso>
        Task<CreateIdMappingWorkflowResponse> CreateIdMappingWorkflowAsync(CreateIdMappingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIdNamespace



        /// <summary>
        /// Creates an ID namespace object which will help customers provide metadata explaining
        /// their dataset and how to use it. Each ID namespace must have a unique name. To modify
        /// an existing ID namespace, use the UpdateIdNamespace API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdNamespace">REST API Reference for CreateIdNamespace Operation</seealso>
        Task<CreateIdNamespaceResponse> CreateIdNamespaceAsync(CreateIdNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMatchingWorkflow



        /// <summary>
        /// Creates a matching workflow that defines the configuration for a data processing job.
        /// The workflow name must be unique. To modify an existing workflow, use <c>UpdateMatchingWorkflow</c>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// For workflows where <c>resolutionType</c> is <c>ML_MATCHING</c> or <c>PROVIDER</c>,
        /// incremental processing is not supported. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateMatchingWorkflow">REST API Reference for CreateMatchingWorkflow Operation</seealso>
        Task<CreateMatchingWorkflowResponse> CreateMatchingWorkflowAsync(CreateMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSchemaMapping



        /// <summary>
        /// Creates a schema mapping, which defines the schema of the input customer records table.
        /// The <c>SchemaMapping</c> also provides Entity Resolution with some metadata about
        /// the table, such as the attribute types of the columns and which columns to match on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchemaMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateSchemaMapping">REST API Reference for CreateSchemaMapping Operation</seealso>
        Task<CreateSchemaMappingResponse> CreateSchemaMappingAsync(CreateSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIdMappingWorkflow



        /// <summary>
        /// Deletes the <c>IdMappingWorkflow</c> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdMappingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdMappingWorkflow">REST API Reference for DeleteIdMappingWorkflow Operation</seealso>
        Task<DeleteIdMappingWorkflowResponse> DeleteIdMappingWorkflowAsync(DeleteIdMappingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIdNamespace



        /// <summary>
        /// Deletes the <c>IdNamespace</c> with a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdNamespace">REST API Reference for DeleteIdNamespace Operation</seealso>
        Task<DeleteIdNamespaceResponse> DeleteIdNamespaceAsync(DeleteIdNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMatchingWorkflow



        /// <summary>
        /// Deletes the <c>MatchingWorkflow</c> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteMatchingWorkflow">REST API Reference for DeleteMatchingWorkflow Operation</seealso>
        Task<DeleteMatchingWorkflowResponse> DeleteMatchingWorkflowAsync(DeleteMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePolicyStatement



        /// <summary>
        /// Deletes the policy statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicyStatement service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeletePolicyStatement">REST API Reference for DeletePolicyStatement Operation</seealso>
        Task<DeletePolicyStatementResponse> DeletePolicyStatementAsync(DeletePolicyStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSchemaMapping



        /// <summary>
        /// Deletes the <c>SchemaMapping</c> with a given name. This operation will succeed even
        /// if a schema with the given name does not exist. This operation will fail if there
        /// is a <c>MatchingWorkflow</c> object that references the <c>SchemaMapping</c> in the
        /// workflow's <c>InputSourceConfig</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteSchemaMapping">REST API Reference for DeleteSchemaMapping Operation</seealso>
        Task<DeleteSchemaMappingResponse> DeleteSchemaMappingAsync(DeleteSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateMatchId



        /// <summary>
        /// Generates or retrieves Match IDs for records using a rule-based matching workflow.
        /// When you call this operation, it processes your records against the workflow's matching
        /// rules to identify potential matches. For existing records, it retrieves their Match
        /// IDs and associated rules. For records without matches, it generates new Match IDs.
        /// The operation saves results to Amazon S3. 
        /// 
        ///  
        /// <para>
        /// The processing type (<c>processingType</c>) you choose affects both the accuracy and
        /// response time of the operation. Additional charges apply for each API call, whether
        /// made through the Entity Resolution console or directly via the API. The rule-based
        /// matching workflow must exist and be active before calling this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMatchId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GenerateMatchId">REST API Reference for GenerateMatchId Operation</seealso>
        Task<GenerateMatchIdResponse> GenerateMatchIdAsync(GenerateMatchIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIdMappingJob



        /// <summary>
        /// Returns the status, metrics, and errors (if there are any) that are associated with
        /// a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdMappingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingJob">REST API Reference for GetIdMappingJob Operation</seealso>
        Task<GetIdMappingJobResponse> GetIdMappingJobAsync(GetIdMappingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIdMappingWorkflow



        /// <summary>
        /// Returns the <c>IdMappingWorkflow</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingWorkflow">REST API Reference for GetIdMappingWorkflow Operation</seealso>
        Task<GetIdMappingWorkflowResponse> GetIdMappingWorkflowAsync(GetIdMappingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIdNamespace



        /// <summary>
        /// Returns the <c>IdNamespace</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdNamespace">REST API Reference for GetIdNamespace Operation</seealso>
        Task<GetIdNamespaceResponse> GetIdNamespaceAsync(GetIdNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMatchId



        /// <summary>
        /// Returns the corresponding Match ID of a customer record if the record has been processed
        /// in a rule-based matching workflow.
        /// 
        ///  
        /// <para>
        /// You can call this API as a dry run of an incremental load on the rule-based matching
        /// workflow.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchId">REST API Reference for GetMatchId Operation</seealso>
        Task<GetMatchIdResponse> GetMatchIdAsync(GetMatchIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMatchingJob



        /// <summary>
        /// Returns the status, metrics, and errors (if there are any) that are associated with
        /// a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingJob">REST API Reference for GetMatchingJob Operation</seealso>
        Task<GetMatchingJobResponse> GetMatchingJobAsync(GetMatchingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMatchingWorkflow



        /// <summary>
        /// Returns the <c>MatchingWorkflow</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingWorkflow">REST API Reference for GetMatchingWorkflow Operation</seealso>
        Task<GetMatchingWorkflowResponse> GetMatchingWorkflowAsync(GetMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPolicy



        /// <summary>
        /// Returns the resource-based policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProviderService



        /// <summary>
        /// Returns the <c>ProviderService</c> of a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProviderService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProviderService service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetProviderService">REST API Reference for GetProviderService Operation</seealso>
        Task<GetProviderServiceResponse> GetProviderServiceAsync(GetProviderServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSchemaMapping



        /// <summary>
        /// Returns the SchemaMapping of a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetSchemaMapping">REST API Reference for GetSchemaMapping Operation</seealso>
        Task<GetSchemaMappingResponse> GetSchemaMappingAsync(GetSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIdMappingJobs



        /// <summary>
        /// Lists all ID mapping jobs for a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdMappingJobs service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingJobs">REST API Reference for ListIdMappingJobs Operation</seealso>
        Task<ListIdMappingJobsResponse> ListIdMappingJobsAsync(ListIdMappingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIdMappingWorkflows



        /// <summary>
        /// Returns a list of all the <c>IdMappingWorkflows</c> that have been created for an
        /// Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdMappingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingWorkflows">REST API Reference for ListIdMappingWorkflows Operation</seealso>
        Task<ListIdMappingWorkflowsResponse> ListIdMappingWorkflowsAsync(ListIdMappingWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIdNamespaces



        /// <summary>
        /// Returns a list of all ID namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdNamespaces service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdNamespaces">REST API Reference for ListIdNamespaces Operation</seealso>
        Task<ListIdNamespacesResponse> ListIdNamespacesAsync(ListIdNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMatchingJobs



        /// <summary>
        /// Lists all jobs for a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMatchingJobs service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingJobs">REST API Reference for ListMatchingJobs Operation</seealso>
        Task<ListMatchingJobsResponse> ListMatchingJobsAsync(ListMatchingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMatchingWorkflows



        /// <summary>
        /// Returns a list of all the <c>MatchingWorkflows</c> that have been created for an Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMatchingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingWorkflows">REST API Reference for ListMatchingWorkflows Operation</seealso>
        Task<ListMatchingWorkflowsResponse> ListMatchingWorkflowsAsync(ListMatchingWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProviderServices



        /// <summary>
        /// Returns a list of all the <c>ProviderServices</c> that are available in this Amazon
        /// Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProviderServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProviderServices service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListProviderServices">REST API Reference for ListProviderServices Operation</seealso>
        Task<ListProviderServicesResponse> ListProviderServicesAsync(ListProviderServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSchemaMappings



        /// <summary>
        /// Returns a list of all the <c>SchemaMappings</c> that have been created for an Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemaMappings service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListSchemaMappings">REST API Reference for ListSchemaMappings Operation</seealso>
        Task<ListSchemaMappingsResponse> ListSchemaMappingsAsync(ListSchemaMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Displays the tags associated with an Entity Resolution resource. In Entity Resolution,
        /// <c>SchemaMapping</c>, and <c>MatchingWorkflow</c> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutPolicy



        /// <summary>
        /// Updates the resource-based policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPolicy service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        Task<PutPolicyResponse> PutPolicyAsync(PutPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartIdMappingJob



        /// <summary>
        /// Starts the <c>IdMappingJob</c> of a workflow. The workflow must have previously been
        /// created using the <c>CreateIdMappingWorkflow</c> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIdMappingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartIdMappingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartIdMappingJob">REST API Reference for StartIdMappingJob Operation</seealso>
        Task<StartIdMappingJobResponse> StartIdMappingJobAsync(StartIdMappingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMatchingJob



        /// <summary>
        /// Starts the <c>MatchingJob</c> of a workflow. The workflow must have previously been
        /// created using the <c>CreateMatchingWorkflow</c> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartMatchingJob">REST API Reference for StartMatchingJob Operation</seealso>
        Task<StartMatchingJobResponse> StartMatchingJobAsync(StartMatchingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Entity Resolution resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In Entity Resolution, <c>SchemaMapping</c> and <c>MatchingWorkflow</c>
        /// can be tagged. Tags don't have any semantic meaning to Amazon Web Services and are
        /// interpreted strictly as strings of characters. You can use the <c>TagResource</c>
        /// action with a resource that already has tags. If you specify a new tag key, this tag
        /// is appended to the list of tags associated with the resource. If you specify a tag
        /// key that is already associated with the resource, the new tag value that you specify
        /// replaces the previous value for that tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from the specified Entity Resolution resource. In Entity
        /// Resolution, <c>SchemaMapping</c>, and <c>MatchingWorkflow</c> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIdMappingWorkflow



        /// <summary>
        /// Updates an existing <c>IdMappingWorkflow</c>. This method is identical to CreateIdMappingWorkflow,
        /// except it uses an HTTP <c>PUT</c> request instead of a <c>POST</c> request, and the
        /// <c>IdMappingWorkflow</c> must already exist for the method to succeed.
        /// 
        ///  <important> 
        /// <para>
        /// Incremental processing is not supported for ID mapping workflows. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdMappingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdMappingWorkflow">REST API Reference for UpdateIdMappingWorkflow Operation</seealso>
        Task<UpdateIdMappingWorkflowResponse> UpdateIdMappingWorkflowAsync(UpdateIdMappingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIdNamespace



        /// <summary>
        /// Updates an existing ID namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdNamespace">REST API Reference for UpdateIdNamespace Operation</seealso>
        Task<UpdateIdNamespaceResponse> UpdateIdNamespaceAsync(UpdateIdNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMatchingWorkflow



        /// <summary>
        /// Updates an existing matching workflow. The workflow must already exist for this operation
        /// to succeed.
        /// 
        ///  <important> 
        /// <para>
        /// For workflows where <c>resolutionType</c> is <c>ML_MATCHING</c> or <c>PROVIDER</c>,
        /// incremental processing is not supported. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchingWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateMatchingWorkflow">REST API Reference for UpdateMatchingWorkflow Operation</seealso>
        Task<UpdateMatchingWorkflowResponse> UpdateMatchingWorkflowAsync(UpdateMatchingWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSchemaMapping



        /// <summary>
        /// Updates a schema mapping.
        /// 
        ///  <note> 
        /// <para>
        /// A schema is immutable if it is being used by a workflow. Therefore, you can't update
        /// a schema mapping if it's associated with a workflow. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchemaMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateSchemaMapping">REST API Reference for UpdateSchemaMapping Operation</seealso>
        Task<UpdateSchemaMappingResponse> UpdateSchemaMappingAsync(UpdateSchemaMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonEntityResolutionConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonEntityResolutionConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonEntityResolutionConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonEntityResolutionConfig to create AmazonEntityResolutionClient");
            }

            return awsCredentials == null ? 
                    new AmazonEntityResolutionClient(serviceClientConfig) :
                    new AmazonEntityResolutionClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}