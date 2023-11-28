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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockAgent.Model;

namespace Amazon.BedrockAgent
{
    /// <summary>
    /// Interface for accessing BedrockAgent
    ///
    /// An example service, deployed with the Octane Service creator, which will echo the
    /// string
    /// </summary>
    public partial interface IAmazonBedrockAgent : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockAgentPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the AssociateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAgentKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAgentKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/AssociateAgentKnowledgeBase">REST API Reference for AssociateAgentKnowledgeBase Operation</seealso>
        IAsyncResult BeginAssociateAgentKnowledgeBase(AssociateAgentKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAgentKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  AssociateAgentKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/AssociateAgentKnowledgeBase">REST API Reference for AssociateAgentKnowledgeBase Operation</seealso>
        AssociateAgentKnowledgeBaseResponse EndAssociateAgentKnowledgeBase(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        IAsyncResult BeginCreateAgent(CreateAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgent.</param>
        /// 
        /// <returns>Returns a  CreateAgentResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        CreateAgentResponse EndCreateAgent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentActionGroup operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgentActionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentActionGroup">REST API Reference for CreateAgentActionGroup Operation</seealso>
        IAsyncResult BeginCreateAgentActionGroup(CreateAgentActionGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgentActionGroup.</param>
        /// 
        /// <returns>Returns a  CreateAgentActionGroupResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentActionGroup">REST API Reference for CreateAgentActionGroup Operation</seealso>
        CreateAgentActionGroupResponse EndCreateAgentActionGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentAlias operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgentAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentAlias">REST API Reference for CreateAgentAlias Operation</seealso>
        IAsyncResult BeginCreateAgentAlias(CreateAgentAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgentAlias.</param>
        /// 
        /// <returns>Returns a  CreateAgentAliasResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentAlias">REST API Reference for CreateAgentAlias Operation</seealso>
        CreateAgentAliasResponse EndCreateAgentAlias(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        IAsyncResult BeginCreateDataSource(CreateDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSource.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        CreateDataSourceResponse EndCreateDataSource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        IAsyncResult BeginCreateKnowledgeBase(CreateKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  CreateKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        CreateKnowledgeBaseResponse EndCreateKnowledgeBase(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        IAsyncResult BeginDeleteAgent(DeleteAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgent.</param>
        /// 
        /// <returns>Returns a  DeleteAgentResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        DeleteAgentResponse EndDeleteAgent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentActionGroup operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentActionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentActionGroup">REST API Reference for DeleteAgentActionGroup Operation</seealso>
        IAsyncResult BeginDeleteAgentActionGroup(DeleteAgentActionGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentActionGroup.</param>
        /// 
        /// <returns>Returns a  DeleteAgentActionGroupResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentActionGroup">REST API Reference for DeleteAgentActionGroup Operation</seealso>
        DeleteAgentActionGroupResponse EndDeleteAgentActionGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentAlias operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentAlias">REST API Reference for DeleteAgentAlias Operation</seealso>
        IAsyncResult BeginDeleteAgentAlias(DeleteAgentAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAgentAliasResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentAlias">REST API Reference for DeleteAgentAlias Operation</seealso>
        DeleteAgentAliasResponse EndDeleteAgentAlias(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentVersion operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentVersion">REST API Reference for DeleteAgentVersion Operation</seealso>
        IAsyncResult BeginDeleteAgentVersion(DeleteAgentVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentVersion.</param>
        /// 
        /// <returns>Returns a  DeleteAgentVersionResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentVersion">REST API Reference for DeleteAgentVersion Operation</seealso>
        DeleteAgentVersionResponse EndDeleteAgentVersion(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        IAsyncResult BeginDeleteKnowledgeBase(DeleteKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  DeleteKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        DeleteKnowledgeBaseResponse EndDeleteKnowledgeBase(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DisassociateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAgentKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAgentKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DisassociateAgentKnowledgeBase">REST API Reference for DisassociateAgentKnowledgeBase Operation</seealso>
        IAsyncResult BeginDisassociateAgentKnowledgeBase(DisassociateAgentKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAgentKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  DisassociateAgentKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DisassociateAgentKnowledgeBase">REST API Reference for DisassociateAgentKnowledgeBase Operation</seealso>
        DisassociateAgentKnowledgeBaseResponse EndDisassociateAgentKnowledgeBase(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgent operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgent">REST API Reference for GetAgent Operation</seealso>
        IAsyncResult BeginGetAgent(GetAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgent.</param>
        /// 
        /// <returns>Returns a  GetAgentResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgent">REST API Reference for GetAgent Operation</seealso>
        GetAgentResponse EndGetAgent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentActionGroup operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentActionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentActionGroup">REST API Reference for GetAgentActionGroup Operation</seealso>
        IAsyncResult BeginGetAgentActionGroup(GetAgentActionGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentActionGroup.</param>
        /// 
        /// <returns>Returns a  GetAgentActionGroupResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentActionGroup">REST API Reference for GetAgentActionGroup Operation</seealso>
        GetAgentActionGroupResponse EndGetAgentActionGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentAlias operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentAlias">REST API Reference for GetAgentAlias Operation</seealso>
        IAsyncResult BeginGetAgentAlias(GetAgentAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentAlias.</param>
        /// 
        /// <returns>Returns a  GetAgentAliasResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentAlias">REST API Reference for GetAgentAlias Operation</seealso>
        GetAgentAliasResponse EndGetAgentAlias(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentKnowledgeBase">REST API Reference for GetAgentKnowledgeBase Operation</seealso>
        IAsyncResult BeginGetAgentKnowledgeBase(GetAgentKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  GetAgentKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentKnowledgeBase">REST API Reference for GetAgentKnowledgeBase Operation</seealso>
        GetAgentKnowledgeBaseResponse EndGetAgentKnowledgeBase(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentVersion operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentVersion">REST API Reference for GetAgentVersion Operation</seealso>
        IAsyncResult BeginGetAgentVersion(GetAgentVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentVersion.</param>
        /// 
        /// <returns>Returns a  GetAgentVersionResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentVersion">REST API Reference for GetAgentVersion Operation</seealso>
        GetAgentVersionResponse EndGetAgentVersion(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        IAsyncResult BeginGetDataSource(GetDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSource.</param>
        /// 
        /// <returns>Returns a  GetDataSourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        GetDataSourceResponse EndGetDataSource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIngestionJob operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIngestionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetIngestionJob">REST API Reference for GetIngestionJob Operation</seealso>
        IAsyncResult BeginGetIngestionJob(GetIngestionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIngestionJob.</param>
        /// 
        /// <returns>Returns a  GetIngestionJobResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetIngestionJob">REST API Reference for GetIngestionJob Operation</seealso>
        GetIngestionJobResponse EndGetIngestionJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        IAsyncResult BeginGetKnowledgeBase(GetKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  GetKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        GetKnowledgeBaseResponse EndGetKnowledgeBase(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListAgentActionGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentActionGroups operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentActionGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentActionGroups">REST API Reference for ListAgentActionGroups Operation</seealso>
        IAsyncResult BeginListAgentActionGroups(ListAgentActionGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentActionGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentActionGroups.</param>
        /// 
        /// <returns>Returns a  ListAgentActionGroupsResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentActionGroups">REST API Reference for ListAgentActionGroups Operation</seealso>
        ListAgentActionGroupsResponse EndListAgentActionGroups(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListAgentAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentAliases operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentAliases">REST API Reference for ListAgentAliases Operation</seealso>
        IAsyncResult BeginListAgentAliases(ListAgentAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentAliases.</param>
        /// 
        /// <returns>Returns a  ListAgentAliasesResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentAliases">REST API Reference for ListAgentAliases Operation</seealso>
        ListAgentAliasesResponse EndListAgentAliases(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListAgentKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentKnowledgeBases operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentKnowledgeBases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentKnowledgeBases">REST API Reference for ListAgentKnowledgeBases Operation</seealso>
        IAsyncResult BeginListAgentKnowledgeBases(ListAgentKnowledgeBasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentKnowledgeBases.</param>
        /// 
        /// <returns>Returns a  ListAgentKnowledgeBasesResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentKnowledgeBases">REST API Reference for ListAgentKnowledgeBases Operation</seealso>
        ListAgentKnowledgeBasesResponse EndListAgentKnowledgeBases(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgents operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgents">REST API Reference for ListAgents Operation</seealso>
        IAsyncResult BeginListAgents(ListAgentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgents.</param>
        /// 
        /// <returns>Returns a  ListAgentsResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgents">REST API Reference for ListAgents Operation</seealso>
        ListAgentsResponse EndListAgents(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentVersions operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentVersions">REST API Reference for ListAgentVersions Operation</seealso>
        IAsyncResult BeginListAgentVersions(ListAgentVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentVersions.</param>
        /// 
        /// <returns>Returns a  ListAgentVersionsResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentVersions">REST API Reference for ListAgentVersions Operation</seealso>
        ListAgentVersionsResponse EndListAgentVersions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        IAsyncResult BeginListDataSources(ListDataSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSources.</param>
        /// 
        /// <returns>Returns a  ListDataSourcesResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        ListDataSourcesResponse EndListDataSources(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListIngestionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIngestionJobs operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIngestionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListIngestionJobs">REST API Reference for ListIngestionJobs Operation</seealso>
        IAsyncResult BeginListIngestionJobs(ListIngestionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIngestionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIngestionJobs.</param>
        /// 
        /// <returns>Returns a  ListIngestionJobsResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListIngestionJobs">REST API Reference for ListIngestionJobs Operation</seealso>
        ListIngestionJobsResponse EndListIngestionJobs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKnowledgeBases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        IAsyncResult BeginListKnowledgeBases(ListKnowledgeBasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKnowledgeBases.</param>
        /// 
        /// <returns>Returns a  ListKnowledgeBasesResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        ListKnowledgeBasesResponse EndListKnowledgeBases(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the PrepareAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PrepareAgent operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPrepareAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/PrepareAgent">REST API Reference for PrepareAgent Operation</seealso>
        IAsyncResult BeginPrepareAgent(PrepareAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PrepareAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPrepareAgent.</param>
        /// 
        /// <returns>Returns a  PrepareAgentResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/PrepareAgent">REST API Reference for PrepareAgent Operation</seealso>
        PrepareAgentResponse EndPrepareAgent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartIngestionJob operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartIngestionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/StartIngestionJob">REST API Reference for StartIngestionJob Operation</seealso>
        IAsyncResult BeginStartIngestionJob(StartIngestionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartIngestionJob.</param>
        /// 
        /// <returns>Returns a  StartIngestionJobResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/StartIngestionJob">REST API Reference for StartIngestionJob Operation</seealso>
        StartIngestionJobResponse EndStartIngestionJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        IAsyncResult BeginUpdateAgent(UpdateAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgent.</param>
        /// 
        /// <returns>Returns a  UpdateAgentResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        UpdateAgentResponse EndUpdateAgent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentActionGroup operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentActionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentActionGroup">REST API Reference for UpdateAgentActionGroup Operation</seealso>
        IAsyncResult BeginUpdateAgentActionGroup(UpdateAgentActionGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentActionGroup.</param>
        /// 
        /// <returns>Returns a  UpdateAgentActionGroupResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentActionGroup">REST API Reference for UpdateAgentActionGroup Operation</seealso>
        UpdateAgentActionGroupResponse EndUpdateAgentActionGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentAlias operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentAlias">REST API Reference for UpdateAgentAlias Operation</seealso>
        IAsyncResult BeginUpdateAgentAlias(UpdateAgentAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentAlias.</param>
        /// 
        /// <returns>Returns a  UpdateAgentAliasResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentAlias">REST API Reference for UpdateAgentAlias Operation</seealso>
        UpdateAgentAliasResponse EndUpdateAgentAlias(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentKnowledgeBase">REST API Reference for UpdateAgentKnowledgeBase Operation</seealso>
        IAsyncResult BeginUpdateAgentKnowledgeBase(UpdateAgentKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  UpdateAgentKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentKnowledgeBase">REST API Reference for UpdateAgentKnowledgeBase Operation</seealso>
        UpdateAgentKnowledgeBaseResponse EndUpdateAgentKnowledgeBase(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateKnowledgeBase">REST API Reference for UpdateKnowledgeBase Operation</seealso>
        IAsyncResult BeginUpdateKnowledgeBase(UpdateKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  UpdateKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateKnowledgeBase">REST API Reference for UpdateKnowledgeBase Operation</seealso>
        UpdateKnowledgeBaseResponse EndUpdateKnowledgeBase(IAsyncResult asyncResult);

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