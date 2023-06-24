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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ConnectWisdomService.Model;

namespace Amazon.ConnectWisdomService
{
    /// <summary>
    /// Interface for accessing ConnectWisdomService
    ///
    /// Amazon Connect Wisdom delivers agents the information they need to solve customer
    /// issues as they're actively speaking with customers. Agents can search across connected
    /// repositories from within their agent desktop to find answers quickly. Use Amazon Connect
    /// Wisdom to create an assistant and a knowledge base, for example, or manage content
    /// by uploading custom files.
    /// </summary>
    public partial interface IAmazonConnectWisdomService : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectWisdomServicePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateAssistant


        /// <summary>
        /// Creates an Amazon Connect Wisdom assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistant service method.</param>
        /// 
        /// <returns>The response from the CreateAssistant service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <code>Create</code> API (such as <code>CreateAssistant</code>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateAssistant">REST API Reference for CreateAssistant Operation</seealso>
        CreateAssistantResponse CreateAssistant(CreateAssistantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistant operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateAssistant">REST API Reference for CreateAssistant Operation</seealso>
        IAsyncResult BeginCreateAssistant(CreateAssistantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssistant.</param>
        /// 
        /// <returns>Returns a  CreateAssistantResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateAssistant">REST API Reference for CreateAssistant Operation</seealso>
        CreateAssistantResponse EndCreateAssistant(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAssistantAssociation


        /// <summary>
        /// Creates an association between an Amazon Connect Wisdom assistant and another resource.
        /// Currently, the only supported association is with a knowledge base. An assistant can
        /// have only a single association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistantAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateAssistantAssociation service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <code>Create</code> API (such as <code>CreateAssistant</code>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateAssistantAssociation">REST API Reference for CreateAssistantAssociation Operation</seealso>
        CreateAssistantAssociationResponse CreateAssistantAssociation(CreateAssistantAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistantAssociation operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssistantAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateAssistantAssociation">REST API Reference for CreateAssistantAssociation Operation</seealso>
        IAsyncResult BeginCreateAssistantAssociation(CreateAssistantAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssistantAssociation.</param>
        /// 
        /// <returns>Returns a  CreateAssistantAssociationResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateAssistantAssociation">REST API Reference for CreateAssistantAssociation Operation</seealso>
        CreateAssistantAssociationResponse EndCreateAssistantAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContent


        /// <summary>
        /// Creates Wisdom content. Before to calling this API, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>
        /// to upload an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContent service method.</param>
        /// 
        /// <returns>The response from the CreateContent service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <code>Create</code> API (such as <code>CreateAssistant</code>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateContent">REST API Reference for CreateContent Operation</seealso>
        CreateContentResponse CreateContent(CreateContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContent operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateContent">REST API Reference for CreateContent Operation</seealso>
        IAsyncResult BeginCreateContent(CreateContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContent.</param>
        /// 
        /// <returns>Returns a  CreateContentResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateContent">REST API Reference for CreateContent Operation</seealso>
        CreateContentResponse EndCreateContent(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKnowledgeBase


        /// <summary>
        /// Creates a knowledge base.
        /// 
        ///  <note> 
        /// <para>
        /// When using this API, you cannot reuse <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/Welcome.html">Amazon
        /// AppIntegrations</a> DataIntegrations with external knowledge bases such as Salesforce
        /// and ServiceNow. If you do, you'll get an <code>InvalidRequestException</code> error.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, you're programmatically managing your external knowledge base, and you
        /// want to add or remove one of the fields that is being ingested from Salesforce. Do
        /// the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Call <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_DeleteKnowledgeBase.html">DeleteKnowledgeBase</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_DeleteDataIntegration.html">DeleteDataIntegration</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// to recreate the DataIntegration or a create different one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call CreateKnowledgeBase.
        /// </para>
        ///  </li> </ol> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the CreateKnowledgeBase service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <code>Create</code> API (such as <code>CreateAssistant</code>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        CreateKnowledgeBaseResponse CreateKnowledgeBase(CreateKnowledgeBaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        IAsyncResult BeginCreateKnowledgeBase(CreateKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  CreateKnowledgeBaseResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        CreateKnowledgeBaseResponse EndCreateKnowledgeBase(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSession


        /// <summary>
        /// Creates a session. A session is a contextual container used for generating recommendations.
        /// Amazon Connect creates a new Wisdom session for each contact on which Wisdom is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// 
        /// <returns>The response from the CreateSession service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <code>Create</code> API (such as <code>CreateAssistant</code>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateSession">REST API Reference for CreateSession Operation</seealso>
        CreateSessionResponse CreateSession(CreateSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSession operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateSession">REST API Reference for CreateSession Operation</seealso>
        IAsyncResult BeginCreateSession(CreateSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSession.</param>
        /// 
        /// <returns>Returns a  CreateSessionResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateSession">REST API Reference for CreateSession Operation</seealso>
        CreateSessionResponse EndCreateSession(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAssistant


        /// <summary>
        /// Deletes an assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistant service method.</param>
        /// 
        /// <returns>The response from the DeleteAssistant service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteAssistant">REST API Reference for DeleteAssistant Operation</seealso>
        DeleteAssistantResponse DeleteAssistant(DeleteAssistantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistant operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteAssistant">REST API Reference for DeleteAssistant Operation</seealso>
        IAsyncResult BeginDeleteAssistant(DeleteAssistantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssistant.</param>
        /// 
        /// <returns>Returns a  DeleteAssistantResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteAssistant">REST API Reference for DeleteAssistant Operation</seealso>
        DeleteAssistantResponse EndDeleteAssistant(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAssistantAssociation


        /// <summary>
        /// Deletes an assistant association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistantAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteAssistantAssociation service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteAssistantAssociation">REST API Reference for DeleteAssistantAssociation Operation</seealso>
        DeleteAssistantAssociationResponse DeleteAssistantAssociation(DeleteAssistantAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistantAssociation operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssistantAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteAssistantAssociation">REST API Reference for DeleteAssistantAssociation Operation</seealso>
        IAsyncResult BeginDeleteAssistantAssociation(DeleteAssistantAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssistantAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteAssistantAssociationResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteAssistantAssociation">REST API Reference for DeleteAssistantAssociation Operation</seealso>
        DeleteAssistantAssociationResponse EndDeleteAssistantAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteContent


        /// <summary>
        /// Deletes the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContent service method.</param>
        /// 
        /// <returns>The response from the DeleteContent service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteContent">REST API Reference for DeleteContent Operation</seealso>
        DeleteContentResponse DeleteContent(DeleteContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContent operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteContent">REST API Reference for DeleteContent Operation</seealso>
        IAsyncResult BeginDeleteContent(DeleteContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContent.</param>
        /// 
        /// <returns>Returns a  DeleteContentResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteContent">REST API Reference for DeleteContent Operation</seealso>
        DeleteContentResponse EndDeleteContent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKnowledgeBase


        /// <summary>
        /// Deletes the knowledge base.
        /// 
        ///  <note> 
        /// <para>
        /// When you use this API to delete an external knowledge base such as Salesforce or ServiceNow,
        /// you must also delete the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/Welcome.html">Amazon
        /// AppIntegrations</a> DataIntegration. This is because you can't reuse the DataIntegration
        /// after it's been associated with an external knowledge base. However, you can delete
        /// and recreate it. See <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_DeleteDataIntegration.html">DeleteDataIntegration</a>
        /// and <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// in the <i>Amazon AppIntegrations API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the DeleteKnowledgeBase service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <code>Create</code> API (such as <code>CreateAssistant</code>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        DeleteKnowledgeBaseResponse DeleteKnowledgeBase(DeleteKnowledgeBaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        IAsyncResult BeginDeleteKnowledgeBase(DeleteKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  DeleteKnowledgeBaseResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        DeleteKnowledgeBaseResponse EndDeleteKnowledgeBase(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssistant


        /// <summary>
        /// Retrieves information about an assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssistant service method.</param>
        /// 
        /// <returns>The response from the GetAssistant service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetAssistant">REST API Reference for GetAssistant Operation</seealso>
        GetAssistantResponse GetAssistant(GetAssistantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssistant operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetAssistant">REST API Reference for GetAssistant Operation</seealso>
        IAsyncResult BeginGetAssistant(GetAssistantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssistant.</param>
        /// 
        /// <returns>Returns a  GetAssistantResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetAssistant">REST API Reference for GetAssistant Operation</seealso>
        GetAssistantResponse EndGetAssistant(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssistantAssociation


        /// <summary>
        /// Retrieves information about an assistant association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssistantAssociation service method.</param>
        /// 
        /// <returns>The response from the GetAssistantAssociation service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetAssistantAssociation">REST API Reference for GetAssistantAssociation Operation</seealso>
        GetAssistantAssociationResponse GetAssistantAssociation(GetAssistantAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssistantAssociation operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssistantAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetAssistantAssociation">REST API Reference for GetAssistantAssociation Operation</seealso>
        IAsyncResult BeginGetAssistantAssociation(GetAssistantAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssistantAssociation.</param>
        /// 
        /// <returns>Returns a  GetAssistantAssociationResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetAssistantAssociation">REST API Reference for GetAssistantAssociation Operation</seealso>
        GetAssistantAssociationResponse EndGetAssistantAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContent


        /// <summary>
        /// Retrieves content, including a pre-signed URL to download the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContent service method.</param>
        /// 
        /// <returns>The response from the GetContent service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetContent">REST API Reference for GetContent Operation</seealso>
        GetContentResponse GetContent(GetContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContent operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetContent">REST API Reference for GetContent Operation</seealso>
        IAsyncResult BeginGetContent(GetContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContent.</param>
        /// 
        /// <returns>Returns a  GetContentResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetContent">REST API Reference for GetContent Operation</seealso>
        GetContentResponse EndGetContent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContentSummary


        /// <summary>
        /// Retrieves summary information about the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContentSummary service method.</param>
        /// 
        /// <returns>The response from the GetContentSummary service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetContentSummary">REST API Reference for GetContentSummary Operation</seealso>
        GetContentSummaryResponse GetContentSummary(GetContentSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContentSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContentSummary operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContentSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetContentSummary">REST API Reference for GetContentSummary Operation</seealso>
        IAsyncResult BeginGetContentSummary(GetContentSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContentSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContentSummary.</param>
        /// 
        /// <returns>Returns a  GetContentSummaryResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetContentSummary">REST API Reference for GetContentSummary Operation</seealso>
        GetContentSummaryResponse EndGetContentSummary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKnowledgeBase


        /// <summary>
        /// Retrieves information about the knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the GetKnowledgeBase service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        GetKnowledgeBaseResponse GetKnowledgeBase(GetKnowledgeBaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        IAsyncResult BeginGetKnowledgeBase(GetKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  GetKnowledgeBaseResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        GetKnowledgeBaseResponse EndGetKnowledgeBase(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecommendations


        /// <summary>
        /// Retrieves recommendations for the specified session. To avoid retrieving the same
        /// recommendations in subsequent calls, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_NotifyRecommendationsReceived.html">NotifyRecommendationsReceived</a>.
        /// This API supports long-polling behavior with the <code>waitTimeSeconds</code> parameter.
        /// Short poll is the default behavior and only returns recommendations already available.
        /// To perform a manual query against an assistant, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_QueryAssistant.html">QueryAssistant</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetRecommendations service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        GetRecommendationsResponse GetRecommendations(GetRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        IAsyncResult BeginGetRecommendations(GetRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendations.</param>
        /// 
        /// <returns>Returns a  GetRecommendationsResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        GetRecommendationsResponse EndGetRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSession


        /// <summary>
        /// Retrieves information for a specified session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse GetSession(GetSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetSession">REST API Reference for GetSession Operation</seealso>
        IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse EndGetSession(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssistantAssociations


        /// <summary>
        /// Lists information about assistant associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssistantAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssistantAssociations service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListAssistantAssociations">REST API Reference for ListAssistantAssociations Operation</seealso>
        ListAssistantAssociationsResponse ListAssistantAssociations(ListAssistantAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssistantAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssistantAssociations operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssistantAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListAssistantAssociations">REST API Reference for ListAssistantAssociations Operation</seealso>
        IAsyncResult BeginListAssistantAssociations(ListAssistantAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssistantAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssistantAssociations.</param>
        /// 
        /// <returns>Returns a  ListAssistantAssociationsResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListAssistantAssociations">REST API Reference for ListAssistantAssociations Operation</seealso>
        ListAssistantAssociationsResponse EndListAssistantAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssistants


        /// <summary>
        /// Lists information about assistants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssistants service method.</param>
        /// 
        /// <returns>The response from the ListAssistants service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        ListAssistantsResponse ListAssistants(ListAssistantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssistants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssistants operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssistants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        IAsyncResult BeginListAssistants(ListAssistantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssistants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssistants.</param>
        /// 
        /// <returns>Returns a  ListAssistantsResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        ListAssistantsResponse EndListAssistants(IAsyncResult asyncResult);

        #endregion
        
        #region  ListContents


        /// <summary>
        /// Lists the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContents service method.</param>
        /// 
        /// <returns>The response from the ListContents service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListContents">REST API Reference for ListContents Operation</seealso>
        ListContentsResponse ListContents(ListContentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListContents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContents operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListContents">REST API Reference for ListContents Operation</seealso>
        IAsyncResult BeginListContents(ListContentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContents.</param>
        /// 
        /// <returns>Returns a  ListContentsResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListContents">REST API Reference for ListContents Operation</seealso>
        ListContentsResponse EndListContents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKnowledgeBases


        /// <summary>
        /// Lists the knowledge bases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases service method.</param>
        /// 
        /// <returns>The response from the ListKnowledgeBases service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        ListKnowledgeBasesResponse ListKnowledgeBases(ListKnowledgeBasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKnowledgeBases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        IAsyncResult BeginListKnowledgeBases(ListKnowledgeBasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKnowledgeBases.</param>
        /// 
        /// <returns>Returns a  ListKnowledgeBasesResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        ListKnowledgeBasesResponse EndListKnowledgeBases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  NotifyRecommendationsReceived


        /// <summary>
        /// Removes the specified recommendations from the specified assistant's queue of newly
        /// available recommendations. You can use this API in conjunction with <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>
        /// and a <code>waitTimeSeconds</code> input for long-polling behavior and avoiding duplicate
        /// recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyRecommendationsReceived service method.</param>
        /// 
        /// <returns>The response from the NotifyRecommendationsReceived service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/NotifyRecommendationsReceived">REST API Reference for NotifyRecommendationsReceived Operation</seealso>
        NotifyRecommendationsReceivedResponse NotifyRecommendationsReceived(NotifyRecommendationsReceivedRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NotifyRecommendationsReceived operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyRecommendationsReceived operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNotifyRecommendationsReceived
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/NotifyRecommendationsReceived">REST API Reference for NotifyRecommendationsReceived Operation</seealso>
        IAsyncResult BeginNotifyRecommendationsReceived(NotifyRecommendationsReceivedRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NotifyRecommendationsReceived operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNotifyRecommendationsReceived.</param>
        /// 
        /// <returns>Returns a  NotifyRecommendationsReceivedResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/NotifyRecommendationsReceived">REST API Reference for NotifyRecommendationsReceived Operation</seealso>
        NotifyRecommendationsReceivedResponse EndNotifyRecommendationsReceived(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryAssistant


        /// <summary>
        /// Performs a manual search against the specified assistant. To retrieve recommendations
        /// for an assistant, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryAssistant service method.</param>
        /// 
        /// <returns>The response from the QueryAssistant service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/QueryAssistant">REST API Reference for QueryAssistant Operation</seealso>
        QueryAssistantResponse QueryAssistant(QueryAssistantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryAssistant operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/QueryAssistant">REST API Reference for QueryAssistant Operation</seealso>
        IAsyncResult BeginQueryAssistant(QueryAssistantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryAssistant.</param>
        /// 
        /// <returns>Returns a  QueryAssistantResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/QueryAssistant">REST API Reference for QueryAssistant Operation</seealso>
        QueryAssistantResponse EndQueryAssistant(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveKnowledgeBaseTemplateUri


        /// <summary>
        /// Removes a URI template from a knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveKnowledgeBaseTemplateUri service method.</param>
        /// 
        /// <returns>The response from the RemoveKnowledgeBaseTemplateUri service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/RemoveKnowledgeBaseTemplateUri">REST API Reference for RemoveKnowledgeBaseTemplateUri Operation</seealso>
        RemoveKnowledgeBaseTemplateUriResponse RemoveKnowledgeBaseTemplateUri(RemoveKnowledgeBaseTemplateUriRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveKnowledgeBaseTemplateUri operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveKnowledgeBaseTemplateUri
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/RemoveKnowledgeBaseTemplateUri">REST API Reference for RemoveKnowledgeBaseTemplateUri Operation</seealso>
        IAsyncResult BeginRemoveKnowledgeBaseTemplateUri(RemoveKnowledgeBaseTemplateUriRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveKnowledgeBaseTemplateUri.</param>
        /// 
        /// <returns>Returns a  RemoveKnowledgeBaseTemplateUriResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/RemoveKnowledgeBaseTemplateUri">REST API Reference for RemoveKnowledgeBaseTemplateUri Operation</seealso>
        RemoveKnowledgeBaseTemplateUriResponse EndRemoveKnowledgeBaseTemplateUri(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchContent


        /// <summary>
        /// Searches for content in a specified knowledge base. Can be used to get a specific
        /// content resource by its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchContent service method.</param>
        /// 
        /// <returns>The response from the SearchContent service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/SearchContent">REST API Reference for SearchContent Operation</seealso>
        SearchContentResponse SearchContent(SearchContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchContent operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/SearchContent">REST API Reference for SearchContent Operation</seealso>
        IAsyncResult BeginSearchContent(SearchContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchContent.</param>
        /// 
        /// <returns>Returns a  SearchContentResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/SearchContent">REST API Reference for SearchContent Operation</seealso>
        SearchContentResponse EndSearchContent(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchSessions


        /// <summary>
        /// Searches for sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSessions service method.</param>
        /// 
        /// <returns>The response from the SearchSessions service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/SearchSessions">REST API Reference for SearchSessions Operation</seealso>
        SearchSessionsResponse SearchSessions(SearchSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSessions operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/SearchSessions">REST API Reference for SearchSessions Operation</seealso>
        IAsyncResult BeginSearchSessions(SearchSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSessions.</param>
        /// 
        /// <returns>Returns a  SearchSessionsResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/SearchSessions">REST API Reference for SearchSessions Operation</seealso>
        SearchSessionsResponse EndSearchSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  StartContentUpload


        /// <summary>
        /// Get a URL to upload content to a knowledge base. To upload content, first make a PUT
        /// request to the returned URL with your file, making sure to include the required headers.
        /// Then use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_CreateContent.html">CreateContent</a>
        /// to finalize the content creation process or <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_UpdateContent.html">UpdateContent</a>
        /// to modify an existing resource. You can only upload content to a knowledge base of
        /// type CUSTOM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContentUpload service method.</param>
        /// 
        /// <returns>The response from the StartContentUpload service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/StartContentUpload">REST API Reference for StartContentUpload Operation</seealso>
        StartContentUploadResponse StartContentUpload(StartContentUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartContentUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartContentUpload operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartContentUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/StartContentUpload">REST API Reference for StartContentUpload Operation</seealso>
        IAsyncResult BeginStartContentUpload(StartContentUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartContentUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartContentUpload.</param>
        /// 
        /// <returns>Returns a  StartContentUploadResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/StartContentUpload">REST API Reference for StartContentUpload Operation</seealso>
        StartContentUploadResponse EndStartContentUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.TooManyTagsException">
        /// Amazon Connect Wisdom throws this exception if you have too many tags in your tag
        /// set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateContent


        /// <summary>
        /// Updates information about the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContent service method.</param>
        /// 
        /// <returns>The response from the UpdateContent service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.PreconditionFailedException">
        /// The provided <code>revisionId</code> does not match, indicating the content has been
        /// modified since it was last read.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        UpdateContentResponse UpdateContent(UpdateContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContent operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        IAsyncResult BeginUpdateContent(UpdateContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContent.</param>
        /// 
        /// <returns>Returns a  UpdateContentResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        UpdateContentResponse EndUpdateContent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKnowledgeBaseTemplateUri


        /// <summary>
        /// Updates the template URI of a knowledge base. This is only supported for knowledge
        /// bases of type EXTERNAL. Include a single variable in <code>${variable}</code> format;
        /// this interpolated by Wisdom using ingested content. For example, if you ingest a Salesforce
        /// article, it has an <code>Id</code> value, and you can set the template URI to <code>https://myInstanceName.lightning.force.com/lightning/r/Knowledge__kav/*${Id}*/view</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBaseTemplateUri service method.</param>
        /// 
        /// <returns>The response from the UpdateKnowledgeBaseTemplateUri service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UpdateKnowledgeBaseTemplateUri">REST API Reference for UpdateKnowledgeBaseTemplateUri Operation</seealso>
        UpdateKnowledgeBaseTemplateUriResponse UpdateKnowledgeBaseTemplateUri(UpdateKnowledgeBaseTemplateUriRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBaseTemplateUri operation on AmazonConnectWisdomServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKnowledgeBaseTemplateUri
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UpdateKnowledgeBaseTemplateUri">REST API Reference for UpdateKnowledgeBaseTemplateUri Operation</seealso>
        IAsyncResult BeginUpdateKnowledgeBaseTemplateUri(UpdateKnowledgeBaseTemplateUriRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKnowledgeBaseTemplateUri.</param>
        /// 
        /// <returns>Returns a  UpdateKnowledgeBaseTemplateUriResult from ConnectWisdomService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UpdateKnowledgeBaseTemplateUri">REST API Reference for UpdateKnowledgeBaseTemplateUri Operation</seealso>
        UpdateKnowledgeBaseTemplateUriResponse EndUpdateKnowledgeBaseTemplateUri(IAsyncResult asyncResult);

        #endregion
        
    }
}