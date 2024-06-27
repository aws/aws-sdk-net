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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ConnectWisdomService.Model;

#pragma warning disable CS1570
namespace Amazon.ConnectWisdomService
{
    /// <summary>
    /// <para>Interface for accessing ConnectWisdomService</para>
    ///
    /// Amazon Connect Wisdom delivers agents the information they need to solve customer
    /// issues as they're actively speaking with customers. Agents can search across connected
    /// repositories from within their agent desktop to find answers quickly. Use Amazon Connect
    /// Wisdom to create an assistant and a knowledge base, for example, or manage content
    /// by uploading custom files.
    /// </summary>
    public partial interface IAmazonConnectWisdomService : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssistant service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
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
        Task<CreateAssistantResponse> CreateAssistantAsync(CreateAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAssistantAssociation



        /// <summary>
        /// Creates an association between an Amazon Connect Wisdom assistant and another resource.
        /// Currently, the only supported association is with a knowledge base. An assistant can
        /// have only a single association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistantAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssistantAssociation service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
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
        Task<CreateAssistantAssociationResponse> CreateAssistantAssociationAsync(CreateAssistantAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateContent



        /// <summary>
        /// Creates Wisdom content. Before to calling this API, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>
        /// to upload an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContent service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
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
        Task<CreateContentResponse> CreateContentAsync(CreateContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateKnowledgeBase



        /// <summary>
        /// Creates a knowledge base.
        /// 
        ///  <note> 
        /// <para>
        /// When using this API, you cannot reuse <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/Welcome.html">Amazon
        /// AppIntegrations</a> DataIntegrations with external knowledge bases such as Salesforce
        /// and ServiceNow. If you do, you'll get an <c>InvalidRequestException</c> error. 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKnowledgeBase service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
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
        Task<CreateKnowledgeBaseResponse> CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateQuickResponse



        /// <summary>
        /// Creates a Wisdom quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuickResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQuickResponse service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/CreateQuickResponse">REST API Reference for CreateQuickResponse Operation</seealso>
        Task<CreateQuickResponseResponse> CreateQuickResponseAsync(CreateQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSession



        /// <summary>
        /// Creates a session. A session is a contextual container used for generating recommendations.
        /// Amazon Connect creates a new Wisdom session for each contact on which Wisdom is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSession service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
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
        Task<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAssistant



        /// <summary>
        /// Deletes an assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAssistantResponse> DeleteAssistantAsync(DeleteAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAssistantAssociation



        /// <summary>
        /// Deletes an assistant association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistantAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAssistantAssociationResponse> DeleteAssistantAssociationAsync(DeleteAssistantAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteContent



        /// <summary>
        /// Deletes the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteContentResponse> DeleteContentAsync(DeleteContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteImportJob



        /// <summary>
        /// Deletes the quick response import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImportJob service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteImportJob">REST API Reference for DeleteImportJob Operation</seealso>
        Task<DeleteImportJobResponse> DeleteImportJobAsync(DeleteImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKnowledgeBase service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
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
        Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteQuickResponse



        /// <summary>
        /// Deletes a quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuickResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQuickResponse service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/DeleteQuickResponse">REST API Reference for DeleteQuickResponse Operation</seealso>
        Task<DeleteQuickResponseResponse> DeleteQuickResponseAsync(DeleteQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssistant



        /// <summary>
        /// Retrieves information about an assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssistant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAssistantResponse> GetAssistantAsync(GetAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssistantAssociation



        /// <summary>
        /// Retrieves information about an assistant association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssistantAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAssistantAssociationResponse> GetAssistantAssociationAsync(GetAssistantAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetContent



        /// <summary>
        /// Retrieves content, including a pre-signed URL to download the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetContentResponse> GetContentAsync(GetContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetContentSummary



        /// <summary>
        /// Retrieves summary information about the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContentSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetContentSummaryResponse> GetContentSummaryAsync(GetContentSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetImportJob



        /// <summary>
        /// Retrieves the started import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImportJob service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        Task<GetImportJobResponse> GetImportJobAsync(GetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetKnowledgeBase



        /// <summary>
        /// Retrieves information about the knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetKnowledgeBaseResponse> GetKnowledgeBaseAsync(GetKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQuickResponse



        /// <summary>
        /// Retrieves the quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuickResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQuickResponse service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/GetQuickResponse">REST API Reference for GetQuickResponse Operation</seealso>
        Task<GetQuickResponseResponse> GetQuickResponseAsync(GetQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRecommendations



        /// <summary>
        /// Retrieves recommendations for the specified session. To avoid retrieving the same
        /// recommendations in subsequent calls, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_NotifyRecommendationsReceived.html">NotifyRecommendationsReceived</a>.
        /// This API supports long-polling behavior with the <c>waitTimeSeconds</c> parameter.
        /// Short poll is the default behavior and only returns recommendations already available.
        /// To perform a manual query against an assistant, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_QueryAssistant.html">QueryAssistant</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        [Obsolete("GetRecommendations API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        Task<GetRecommendationsResponse> GetRecommendationsAsync(GetRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSession



        /// <summary>
        /// Retrieves information for a specified session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssistantAssociations



        /// <summary>
        /// Lists information about assistant associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssistantAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssistantAssociationsResponse> ListAssistantAssociationsAsync(ListAssistantAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssistants



        /// <summary>
        /// Lists information about assistants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssistants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssistants service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        Task<ListAssistantsResponse> ListAssistantsAsync(ListAssistantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContents



        /// <summary>
        /// Lists the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListContentsResponse> ListContentsAsync(ListContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImportJobs



        /// <summary>
        /// Lists information about import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportJobs service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        Task<ListImportJobsResponse> ListImportJobsAsync(ListImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListKnowledgeBases



        /// <summary>
        /// Lists the knowledge bases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKnowledgeBases service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        Task<ListKnowledgeBasesResponse> ListKnowledgeBasesAsync(ListKnowledgeBasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQuickResponses



        /// <summary>
        /// Lists information about quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickResponses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQuickResponses service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListQuickResponses">REST API Reference for ListQuickResponses Operation</seealso>
        Task<ListQuickResponsesResponse> ListQuickResponsesAsync(ListQuickResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  NotifyRecommendationsReceived



        /// <summary>
        /// Removes the specified recommendations from the specified assistant's queue of newly
        /// available recommendations. You can use this API in conjunction with <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>
        /// and a <c>waitTimeSeconds</c> input for long-polling behavior and avoiding duplicate
        /// recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyRecommendationsReceived service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<NotifyRecommendationsReceivedResponse> NotifyRecommendationsReceivedAsync(NotifyRecommendationsReceivedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  QueryAssistant



        /// <summary>
        /// Performs a manual search against the specified assistant. To retrieve recommendations
        /// for an assistant, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryAssistant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryAssistant service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.RequestTimeoutException">
        /// The request reached the service more than 15 minutes after the date stamp on the request
        /// or more than 15 minutes after the request expiration date (such as for pre-signed
        /// URLs), or the date stamp on the request is more than 15 minutes in the future.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/QueryAssistant">REST API Reference for QueryAssistant Operation</seealso>
        [Obsolete("QueryAssistant API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        Task<QueryAssistantResponse> QueryAssistantAsync(QueryAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveKnowledgeBaseTemplateUri



        /// <summary>
        /// Removes a URI template from a knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveKnowledgeBaseTemplateUri service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RemoveKnowledgeBaseTemplateUriResponse> RemoveKnowledgeBaseTemplateUriAsync(RemoveKnowledgeBaseTemplateUriRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchContent



        /// <summary>
        /// Searches for content in a specified knowledge base. Can be used to get a specific
        /// content resource by its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SearchContentResponse> SearchContentAsync(SearchContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchQuickResponses



        /// <summary>
        /// Searches existing Wisdom quick responses in a Wisdom knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchQuickResponses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchQuickResponses service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.RequestTimeoutException">
        /// The request reached the service more than 15 minutes after the date stamp on the request
        /// or more than 15 minutes after the request expiration date (such as for pre-signed
        /// URLs), or the date stamp on the request is more than 15 minutes in the future.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/SearchQuickResponses">REST API Reference for SearchQuickResponses Operation</seealso>
        Task<SearchQuickResponsesResponse> SearchQuickResponsesAsync(SearchQuickResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchSessions



        /// <summary>
        /// Searches for sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SearchSessionsResponse> SearchSessionsAsync(SearchSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartContentUploadResponse> StartContentUploadAsync(StartContentUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartImportJob



        /// <summary>
        /// Start an asynchronous job to import Wisdom resources from an uploaded source file.
        /// Before calling this API, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>
        /// to upload an asset that contains the resource data.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For importing Wisdom quick responses, you need to upload a csv file including the
        /// quick responses. For information about how to format the csv file for importing quick
        /// responses, see <a href="https://docs.aws.amazon.com/console/connect/quick-responses/add-data">Import
        /// quick responses</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImportJob service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/StartImportJob">REST API Reference for StartImportJob Operation</seealso>
        Task<StartImportJobResponse> StartImportJobAsync(StartImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContent



        /// <summary>
        /// Updates information about the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContent service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.PreconditionFailedException">
        /// The provided <c>revisionId</c> does not match, indicating the content has been modified
        /// since it was last read.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        Task<UpdateContentResponse> UpdateContentAsync(UpdateContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateKnowledgeBaseTemplateUri



        /// <summary>
        /// Updates the template URI of a knowledge base. This is only supported for knowledge
        /// bases of type EXTERNAL. Include a single variable in <c>${variable}</c> format; this
        /// interpolated by Wisdom using ingested content. For example, if you ingest a Salesforce
        /// article, it has an <c>Id</c> value, and you can set the template URI to <c>https://myInstanceName.lightning.force.com/lightning/r/Knowledge__kav/*${Id}*/view</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBaseTemplateUri service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateKnowledgeBaseTemplateUriResponse> UpdateKnowledgeBaseTemplateUriAsync(UpdateKnowledgeBaseTemplateUriRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQuickResponse



        /// <summary>
        /// Updates an existing Wisdom quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQuickResponse service method, as returned by ConnectWisdomService.</returns>
        /// <exception cref="Amazon.ConnectWisdomService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.PreconditionFailedException">
        /// The provided <c>revisionId</c> does not match, indicating the content has been modified
        /// since it was last read.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConnectWisdomService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wisdom-2020-10-19/UpdateQuickResponse">REST API Reference for UpdateQuickResponse Operation</seealso>
        Task<UpdateQuickResponseResponse> UpdateQuickResponseAsync(UpdateQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonConnectWisdomServiceConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonConnectWisdomServiceConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonConnectWisdomServiceConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonConnectWisdomServiceConfig to create AmazonConnectWisdomServiceClient");
            }

            return awsCredentials == null ? 
                    new AmazonConnectWisdomServiceClient(serviceClientConfig) :
                    new AmazonConnectWisdomServiceClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}