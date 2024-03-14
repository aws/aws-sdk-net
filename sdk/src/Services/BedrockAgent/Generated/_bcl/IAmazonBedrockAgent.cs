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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockAgent.Model;

namespace Amazon.BedrockAgent
{
    /// <summary>
    /// <para>Interface for accessing BedrockAgent</para>
    ///
    /// An example service, deployed with the Octane Service creator, which will echo the
    /// string
    /// </summary>
    public partial interface IAmazonBedrockAgent : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockAgentPaginatorFactory Paginators { get; }

        
        #region  AssociateAgentKnowledgeBase


        /// <summary>
        /// Associate a Knowledge Base to an existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAgentKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the AssociateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/AssociateAgentKnowledgeBase">REST API Reference for AssociateAgentKnowledgeBase Operation</seealso>
        AssociateAgentKnowledgeBaseResponse AssociateAgentKnowledgeBase(AssociateAgentKnowledgeBaseRequest request);



        /// <summary>
        /// Associate a Knowledge Base to an existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAgentKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/AssociateAgentKnowledgeBase">REST API Reference for AssociateAgentKnowledgeBase Operation</seealso>
        Task<AssociateAgentKnowledgeBaseResponse> AssociateAgentKnowledgeBaseAsync(AssociateAgentKnowledgeBaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAgent


        /// <summary>
        /// Creates an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent service method.</param>
        /// 
        /// <returns>The response from the CreateAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        CreateAgentResponse CreateAgent(CreateAgentRequest request);



        /// <summary>
        /// Creates an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAgentActionGroup


        /// <summary>
        /// Creates an Action Group for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentActionGroup service method.</param>
        /// 
        /// <returns>The response from the CreateAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentActionGroup">REST API Reference for CreateAgentActionGroup Operation</seealso>
        CreateAgentActionGroupResponse CreateAgentActionGroup(CreateAgentActionGroupRequest request);



        /// <summary>
        /// Creates an Action Group for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentActionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentActionGroup">REST API Reference for CreateAgentActionGroup Operation</seealso>
        Task<CreateAgentActionGroupResponse> CreateAgentActionGroupAsync(CreateAgentActionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAgentAlias


        /// <summary>
        /// Creates an Alias for an existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentAlias">REST API Reference for CreateAgentAlias Operation</seealso>
        CreateAgentAliasResponse CreateAgentAlias(CreateAgentAliasRequest request);



        /// <summary>
        /// Creates an Alias for an existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentAlias">REST API Reference for CreateAgentAlias Operation</seealso>
        Task<CreateAgentAliasResponse> CreateAgentAliasAsync(CreateAgentAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataSource


        /// <summary>
        /// Create a new data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request);



        /// <summary>
        /// Create a new data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateKnowledgeBase


        /// <summary>
        /// Create a new knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the CreateKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        CreateKnowledgeBaseResponse CreateKnowledgeBase(CreateKnowledgeBaseRequest request);



        /// <summary>
        /// Create a new knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        Task<CreateKnowledgeBaseResponse> CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgent


        /// <summary>
        /// Deletes an Agent for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent service method.</param>
        /// 
        /// <returns>The response from the DeleteAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        DeleteAgentResponse DeleteAgent(DeleteAgentRequest request);



        /// <summary>
        /// Deletes an Agent for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgentActionGroup


        /// <summary>
        /// Deletes an Action Group for existing Amazon Bedrock Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentActionGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentActionGroup">REST API Reference for DeleteAgentActionGroup Operation</seealso>
        DeleteAgentActionGroupResponse DeleteAgentActionGroup(DeleteAgentActionGroupRequest request);



        /// <summary>
        /// Deletes an Action Group for existing Amazon Bedrock Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentActionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentActionGroup">REST API Reference for DeleteAgentActionGroup Operation</seealso>
        Task<DeleteAgentActionGroupResponse> DeleteAgentActionGroupAsync(DeleteAgentActionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgentAlias


        /// <summary>
        /// Deletes an Alias for a Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentAlias">REST API Reference for DeleteAgentAlias Operation</seealso>
        DeleteAgentAliasResponse DeleteAgentAlias(DeleteAgentAliasRequest request);



        /// <summary>
        /// Deletes an Alias for a Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentAlias">REST API Reference for DeleteAgentAlias Operation</seealso>
        Task<DeleteAgentAliasResponse> DeleteAgentAliasAsync(DeleteAgentAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgentVersion


        /// <summary>
        /// Deletes an Agent version for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentVersion">REST API Reference for DeleteAgentVersion Operation</seealso>
        DeleteAgentVersionResponse DeleteAgentVersion(DeleteAgentVersionRequest request);



        /// <summary>
        /// Deletes an Agent version for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentVersion">REST API Reference for DeleteAgentVersion Operation</seealso>
        Task<DeleteAgentVersionResponse> DeleteAgentVersionAsync(DeleteAgentVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDataSource


        /// <summary>
        /// Delete an existing data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request);



        /// <summary>
        /// Delete an existing data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteKnowledgeBase


        /// <summary>
        /// Delete an existing knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the DeleteKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        DeleteKnowledgeBaseResponse DeleteKnowledgeBase(DeleteKnowledgeBaseRequest request);



        /// <summary>
        /// Delete an existing knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateAgentKnowledgeBase


        /// <summary>
        /// Disassociate an existing Knowledge Base from an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAgentKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the DisassociateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DisassociateAgentKnowledgeBase">REST API Reference for DisassociateAgentKnowledgeBase Operation</seealso>
        DisassociateAgentKnowledgeBaseResponse DisassociateAgentKnowledgeBase(DisassociateAgentKnowledgeBaseRequest request);



        /// <summary>
        /// Disassociate an existing Knowledge Base from an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAgentKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DisassociateAgentKnowledgeBase">REST API Reference for DisassociateAgentKnowledgeBase Operation</seealso>
        Task<DisassociateAgentKnowledgeBaseResponse> DisassociateAgentKnowledgeBaseAsync(DisassociateAgentKnowledgeBaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAgent


        /// <summary>
        /// Gets an Agent for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgent service method.</param>
        /// 
        /// <returns>The response from the GetAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgent">REST API Reference for GetAgent Operation</seealso>
        GetAgentResponse GetAgent(GetAgentRequest request);



        /// <summary>
        /// Gets an Agent for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgent">REST API Reference for GetAgent Operation</seealso>
        Task<GetAgentResponse> GetAgentAsync(GetAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAgentActionGroup


        /// <summary>
        /// Gets an Action Group for existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentActionGroup service method.</param>
        /// 
        /// <returns>The response from the GetAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentActionGroup">REST API Reference for GetAgentActionGroup Operation</seealso>
        GetAgentActionGroupResponse GetAgentActionGroup(GetAgentActionGroupRequest request);



        /// <summary>
        /// Gets an Action Group for existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentActionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentActionGroup">REST API Reference for GetAgentActionGroup Operation</seealso>
        Task<GetAgentActionGroupResponse> GetAgentActionGroupAsync(GetAgentActionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAgentAlias


        /// <summary>
        /// Describes an Alias for a Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentAlias service method.</param>
        /// 
        /// <returns>The response from the GetAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentAlias">REST API Reference for GetAgentAlias Operation</seealso>
        GetAgentAliasResponse GetAgentAlias(GetAgentAliasRequest request);



        /// <summary>
        /// Describes an Alias for a Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentAlias">REST API Reference for GetAgentAlias Operation</seealso>
        Task<GetAgentAliasResponse> GetAgentAliasAsync(GetAgentAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAgentKnowledgeBase


        /// <summary>
        /// Gets a knowledge base associated to an existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the GetAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentKnowledgeBase">REST API Reference for GetAgentKnowledgeBase Operation</seealso>
        GetAgentKnowledgeBaseResponse GetAgentKnowledgeBase(GetAgentKnowledgeBaseRequest request);



        /// <summary>
        /// Gets a knowledge base associated to an existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentKnowledgeBase">REST API Reference for GetAgentKnowledgeBase Operation</seealso>
        Task<GetAgentKnowledgeBaseResponse> GetAgentKnowledgeBaseAsync(GetAgentKnowledgeBaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAgentVersion


        /// <summary>
        /// Gets an Agent version for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentVersion service method.</param>
        /// 
        /// <returns>The response from the GetAgentVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentVersion">REST API Reference for GetAgentVersion Operation</seealso>
        GetAgentVersionResponse GetAgentVersion(GetAgentVersionRequest request);



        /// <summary>
        /// Gets an Agent version for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentVersion">REST API Reference for GetAgentVersion Operation</seealso>
        Task<GetAgentVersionResponse> GetAgentVersionAsync(GetAgentVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataSource


        /// <summary>
        /// Get an existing data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        GetDataSourceResponse GetDataSource(GetDataSourceRequest request);



        /// <summary>
        /// Get an existing data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIngestionJob


        /// <summary>
        /// Get an ingestion job
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestionJob service method.</param>
        /// 
        /// <returns>The response from the GetIngestionJob service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetIngestionJob">REST API Reference for GetIngestionJob Operation</seealso>
        GetIngestionJobResponse GetIngestionJob(GetIngestionJobRequest request);



        /// <summary>
        /// Get an ingestion job
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIngestionJob service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetIngestionJob">REST API Reference for GetIngestionJob Operation</seealso>
        Task<GetIngestionJobResponse> GetIngestionJobAsync(GetIngestionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetKnowledgeBase


        /// <summary>
        /// Get an existing knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the GetKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        GetKnowledgeBaseResponse GetKnowledgeBase(GetKnowledgeBaseRequest request);



        /// <summary>
        /// Get an existing knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        Task<GetKnowledgeBaseResponse> GetKnowledgeBaseAsync(GetKnowledgeBaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgentActionGroups


        /// <summary>
        /// Lists an Action Group for existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentActionGroups service method.</param>
        /// 
        /// <returns>The response from the ListAgentActionGroups service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentActionGroups">REST API Reference for ListAgentActionGroups Operation</seealso>
        ListAgentActionGroupsResponse ListAgentActionGroups(ListAgentActionGroupsRequest request);



        /// <summary>
        /// Lists an Action Group for existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentActionGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentActionGroups service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentActionGroups">REST API Reference for ListAgentActionGroups Operation</seealso>
        Task<ListAgentActionGroupsResponse> ListAgentActionGroupsAsync(ListAgentActionGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgentAliases


        /// <summary>
        /// Lists all the Aliases for an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentAliases service method.</param>
        /// 
        /// <returns>The response from the ListAgentAliases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentAliases">REST API Reference for ListAgentAliases Operation</seealso>
        ListAgentAliasesResponse ListAgentAliases(ListAgentAliasesRequest request);



        /// <summary>
        /// Lists all the Aliases for an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentAliases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentAliases">REST API Reference for ListAgentAliases Operation</seealso>
        Task<ListAgentAliasesResponse> ListAgentAliasesAsync(ListAgentAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgentKnowledgeBases


        /// <summary>
        /// List of Knowledge Bases associated to an existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentKnowledgeBases service method.</param>
        /// 
        /// <returns>The response from the ListAgentKnowledgeBases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentKnowledgeBases">REST API Reference for ListAgentKnowledgeBases Operation</seealso>
        ListAgentKnowledgeBasesResponse ListAgentKnowledgeBases(ListAgentKnowledgeBasesRequest request);



        /// <summary>
        /// List of Knowledge Bases associated to an existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentKnowledgeBases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentKnowledgeBases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentKnowledgeBases">REST API Reference for ListAgentKnowledgeBases Operation</seealso>
        Task<ListAgentKnowledgeBasesResponse> ListAgentKnowledgeBasesAsync(ListAgentKnowledgeBasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgents


        /// <summary>
        /// Lists Agents
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgents service method.</param>
        /// 
        /// <returns>The response from the ListAgents service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgents">REST API Reference for ListAgents Operation</seealso>
        ListAgentsResponse ListAgents(ListAgentsRequest request);



        /// <summary>
        /// Lists Agents
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgents service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgents">REST API Reference for ListAgents Operation</seealso>
        Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgentVersions


        /// <summary>
        /// Lists Agent Versions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentVersions service method.</param>
        /// 
        /// <returns>The response from the ListAgentVersions service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentVersions">REST API Reference for ListAgentVersions Operation</seealso>
        ListAgentVersionsResponse ListAgentVersions(ListAgentVersionsRequest request);



        /// <summary>
        /// Lists Agent Versions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentVersions service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentVersions">REST API Reference for ListAgentVersions Operation</seealso>
        Task<ListAgentVersionsResponse> ListAgentVersionsAsync(ListAgentVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDataSources


        /// <summary>
        /// List data sources
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request);



        /// <summary>
        /// List data sources
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIngestionJobs


        /// <summary>
        /// List ingestion jobs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestionJobs service method.</param>
        /// 
        /// <returns>The response from the ListIngestionJobs service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListIngestionJobs">REST API Reference for ListIngestionJobs Operation</seealso>
        ListIngestionJobsResponse ListIngestionJobs(ListIngestionJobsRequest request);



        /// <summary>
        /// List ingestion jobs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIngestionJobs service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListIngestionJobs">REST API Reference for ListIngestionJobs Operation</seealso>
        Task<ListIngestionJobsResponse> ListIngestionJobsAsync(ListIngestionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListKnowledgeBases


        /// <summary>
        /// List Knowledge Bases
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases service method.</param>
        /// 
        /// <returns>The response from the ListKnowledgeBases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        ListKnowledgeBasesResponse ListKnowledgeBases(ListKnowledgeBasesRequest request);



        /// <summary>
        /// List Knowledge Bases
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKnowledgeBases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        Task<ListKnowledgeBasesResponse> ListKnowledgeBasesAsync(ListKnowledgeBasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PrepareAgent


        /// <summary>
        /// Prepares an existing Amazon Bedrock Agent to receive runtime requests
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PrepareAgent service method.</param>
        /// 
        /// <returns>The response from the PrepareAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/PrepareAgent">REST API Reference for PrepareAgent Operation</seealso>
        PrepareAgentResponse PrepareAgent(PrepareAgentRequest request);



        /// <summary>
        /// Prepares an existing Amazon Bedrock Agent to receive runtime requests
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PrepareAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PrepareAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/PrepareAgent">REST API Reference for PrepareAgent Operation</seealso>
        Task<PrepareAgentResponse> PrepareAgentAsync(PrepareAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartIngestionJob


        /// <summary>
        /// Start a new ingestion job
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIngestionJob service method.</param>
        /// 
        /// <returns>The response from the StartIngestionJob service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/StartIngestionJob">REST API Reference for StartIngestionJob Operation</seealso>
        StartIngestionJobResponse StartIngestionJob(StartIngestionJobRequest request);



        /// <summary>
        /// Start a new ingestion job
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIngestionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartIngestionJob service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/StartIngestionJob">REST API Reference for StartIngestionJob Operation</seealso>
        Task<StartIngestionJobResponse> StartIngestionJobAsync(StartIngestionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Tag a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untag a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Untag a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgent


        /// <summary>
        /// Updates an existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent service method.</param>
        /// 
        /// <returns>The response from the UpdateAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        UpdateAgentResponse UpdateAgent(UpdateAgentRequest request);



        /// <summary>
        /// Updates an existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgentActionGroup


        /// <summary>
        /// Updates an existing Action Group for Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentActionGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentActionGroup">REST API Reference for UpdateAgentActionGroup Operation</seealso>
        UpdateAgentActionGroupResponse UpdateAgentActionGroup(UpdateAgentActionGroupRequest request);



        /// <summary>
        /// Updates an existing Action Group for Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentActionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentActionGroup">REST API Reference for UpdateAgentActionGroup Operation</seealso>
        Task<UpdateAgentActionGroupResponse> UpdateAgentActionGroupAsync(UpdateAgentActionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgentAlias


        /// <summary>
        /// Updates an existing Alias for an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentAlias">REST API Reference for UpdateAgentAlias Operation</seealso>
        UpdateAgentAliasResponse UpdateAgentAlias(UpdateAgentAliasRequest request);



        /// <summary>
        /// Updates an existing Alias for an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentAlias">REST API Reference for UpdateAgentAlias Operation</seealso>
        Task<UpdateAgentAliasResponse> UpdateAgentAliasAsync(UpdateAgentAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgentKnowledgeBase


        /// <summary>
        /// Updates an existing Knowledge Base associated to an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentKnowledgeBase">REST API Reference for UpdateAgentKnowledgeBase Operation</seealso>
        UpdateAgentKnowledgeBaseResponse UpdateAgentKnowledgeBase(UpdateAgentKnowledgeBaseRequest request);



        /// <summary>
        /// Updates an existing Knowledge Base associated to an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentKnowledgeBase">REST API Reference for UpdateAgentKnowledgeBase Operation</seealso>
        Task<UpdateAgentKnowledgeBaseResponse> UpdateAgentKnowledgeBaseAsync(UpdateAgentKnowledgeBaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDataSource


        /// <summary>
        /// Update an existing data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request);



        /// <summary>
        /// Update an existing data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateKnowledgeBase


        /// <summary>
        /// Update an existing knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the UpdateKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateKnowledgeBase">REST API Reference for UpdateKnowledgeBase Operation</seealso>
        UpdateKnowledgeBaseResponse UpdateKnowledgeBase(UpdateKnowledgeBaseRequest request);



        /// <summary>
        /// Update an existing knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateKnowledgeBase">REST API Reference for UpdateKnowledgeBase Operation</seealso>
        Task<UpdateKnowledgeBaseResponse> UpdateKnowledgeBaseAsync(UpdateKnowledgeBaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

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