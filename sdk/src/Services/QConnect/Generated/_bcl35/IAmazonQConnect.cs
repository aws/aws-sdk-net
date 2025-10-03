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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QConnect.Model;

#pragma warning disable CS1570
namespace Amazon.QConnect
{
    /// <summary>
    /// <para>Interface for accessing QConnect</para>
    ///
    /// <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Operations_Amazon_Q_Connect.html">Amazon
    /// Q actions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Types_Amazon_Q_Connect.html">Amazon
    /// Q data types</a> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    ///  <b>Powered by Amazon Bedrock</b>: Amazon Web Services implements <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/abuse-detection.html">automated
    /// abuse detection</a>. Because Amazon Q in Connect is built on Amazon Bedrock, users
    /// can take full advantage of the controls implemented in Amazon Bedrock to enforce safety,
    /// security, and the responsible use of artificial intelligence (AI).
    /// </para>
    ///  </note> 
    /// <para>
    /// Amazon Q in Connect is a generative AI customer service assistant. It is an LLM-enhanced
    /// evolution of Amazon Connect Wisdom that delivers real-time recommendations to help
    /// contact center agents resolve customer issues quickly and accurately.
    /// </para>
    ///  
    /// <para>
    /// Amazon Q in Connect automatically detects customer intent during calls and chats using
    /// conversational analytics and natural language understanding (NLU). It then provides
    /// agents with immediate, real-time generative responses and suggested actions, and links
    /// to relevant documents and articles. Agents can also query Amazon Q in Connect directly
    /// using natural language or keywords to answer customer requests.
    /// </para>
    ///  
    /// <para>
    /// Use the Amazon Q in Connect APIs to create an assistant and a knowledge base, for
    /// example, or manage content by uploading custom files.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-q-connect.html">Use
    /// Amazon Q in Connect for generative AI powered agent assistance in real-time</a> in
    /// the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonQConnect : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IQConnectPaginatorFactory Paginators { get; }
#endif


        
        #region  ActivateMessageTemplate


        /// <summary>
        /// Activates a specific version of the Amazon Q in Connect message template. After the
        /// version is activated, the previous active version will be deactivated automatically.
        /// You can use the <c>$ACTIVE_VERSION</c> qualifier later to reference the version that
        /// is in active status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateMessageTemplate service method.</param>
        /// 
        /// <returns>The response from the ActivateMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ActivateMessageTemplate">REST API Reference for ActivateMessageTemplate Operation</seealso>
        ActivateMessageTemplateResponse ActivateMessageTemplate(ActivateMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ActivateMessageTemplate">REST API Reference for ActivateMessageTemplate Operation</seealso>
        IAsyncResult BeginActivateMessageTemplate(ActivateMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateMessageTemplate.</param>
        /// 
        /// <returns>Returns a  ActivateMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ActivateMessageTemplate">REST API Reference for ActivateMessageTemplate Operation</seealso>
        ActivateMessageTemplateResponse EndActivateMessageTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAIAgent


        /// <summary>
        /// Creates an Amazon Q in Connect AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIAgent service method.</param>
        /// 
        /// <returns>The response from the CreateAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgent">REST API Reference for CreateAIAgent Operation</seealso>
        CreateAIAgentResponse CreateAIAgent(CreateAIAgentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgent">REST API Reference for CreateAIAgent Operation</seealso>
        IAsyncResult BeginCreateAIAgent(CreateAIAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIAgent.</param>
        /// 
        /// <returns>Returns a  CreateAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgent">REST API Reference for CreateAIAgent Operation</seealso>
        CreateAIAgentResponse EndCreateAIAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAIAgentVersion


        /// <summary>
        /// Creates and Amazon Q in Connect AI Agent version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIAgentVersion service method.</param>
        /// 
        /// <returns>The response from the CreateAIAgentVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgentVersion">REST API Reference for CreateAIAgentVersion Operation</seealso>
        CreateAIAgentVersionResponse CreateAIAgentVersion(CreateAIAgentVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIAgentVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIAgentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgentVersion">REST API Reference for CreateAIAgentVersion Operation</seealso>
        IAsyncResult BeginCreateAIAgentVersion(CreateAIAgentVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIAgentVersion.</param>
        /// 
        /// <returns>Returns a  CreateAIAgentVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgentVersion">REST API Reference for CreateAIAgentVersion Operation</seealso>
        CreateAIAgentVersionResponse EndCreateAIAgentVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAIGuardrail


        /// <summary>
        /// Creates an Amazon Q in Connect AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIGuardrail service method.</param>
        /// 
        /// <returns>The response from the CreateAIGuardrail service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrail">REST API Reference for CreateAIGuardrail Operation</seealso>
        CreateAIGuardrailResponse CreateAIGuardrail(CreateAIGuardrailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIGuardrail operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrail">REST API Reference for CreateAIGuardrail Operation</seealso>
        IAsyncResult BeginCreateAIGuardrail(CreateAIGuardrailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIGuardrail.</param>
        /// 
        /// <returns>Returns a  CreateAIGuardrailResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrail">REST API Reference for CreateAIGuardrail Operation</seealso>
        CreateAIGuardrailResponse EndCreateAIGuardrail(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAIGuardrailVersion


        /// <summary>
        /// Creates an Amazon Q in Connect AI Guardrail version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIGuardrailVersion service method.</param>
        /// 
        /// <returns>The response from the CreateAIGuardrailVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrailVersion">REST API Reference for CreateAIGuardrailVersion Operation</seealso>
        CreateAIGuardrailVersionResponse CreateAIGuardrailVersion(CreateAIGuardrailVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIGuardrailVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIGuardrailVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIGuardrailVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrailVersion">REST API Reference for CreateAIGuardrailVersion Operation</seealso>
        IAsyncResult BeginCreateAIGuardrailVersion(CreateAIGuardrailVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIGuardrailVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIGuardrailVersion.</param>
        /// 
        /// <returns>Returns a  CreateAIGuardrailVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrailVersion">REST API Reference for CreateAIGuardrailVersion Operation</seealso>
        CreateAIGuardrailVersionResponse EndCreateAIGuardrailVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAIPrompt


        /// <summary>
        /// Creates an Amazon Q in Connect AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIPrompt service method.</param>
        /// 
        /// <returns>The response from the CreateAIPrompt service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPrompt">REST API Reference for CreateAIPrompt Operation</seealso>
        CreateAIPromptResponse CreateAIPrompt(CreateAIPromptRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIPrompt operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIPrompt
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPrompt">REST API Reference for CreateAIPrompt Operation</seealso>
        IAsyncResult BeginCreateAIPrompt(CreateAIPromptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIPrompt.</param>
        /// 
        /// <returns>Returns a  CreateAIPromptResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPrompt">REST API Reference for CreateAIPrompt Operation</seealso>
        CreateAIPromptResponse EndCreateAIPrompt(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAIPromptVersion


        /// <summary>
        /// Creates an Amazon Q in Connect AI Prompt version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIPromptVersion service method.</param>
        /// 
        /// <returns>The response from the CreateAIPromptVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPromptVersion">REST API Reference for CreateAIPromptVersion Operation</seealso>
        CreateAIPromptVersionResponse CreateAIPromptVersion(CreateAIPromptVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIPromptVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIPromptVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIPromptVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPromptVersion">REST API Reference for CreateAIPromptVersion Operation</seealso>
        IAsyncResult BeginCreateAIPromptVersion(CreateAIPromptVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIPromptVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIPromptVersion.</param>
        /// 
        /// <returns>Returns a  CreateAIPromptVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPromptVersion">REST API Reference for CreateAIPromptVersion Operation</seealso>
        CreateAIPromptVersionResponse EndCreateAIPromptVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAssistant


        /// <summary>
        /// Creates an Amazon Q in Connect assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistant service method.</param>
        /// 
        /// <returns>The response from the CreateAssistant service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistant">REST API Reference for CreateAssistant Operation</seealso>
        CreateAssistantResponse CreateAssistant(CreateAssistantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistant operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistant">REST API Reference for CreateAssistant Operation</seealso>
        IAsyncResult BeginCreateAssistant(CreateAssistantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssistant.</param>
        /// 
        /// <returns>Returns a  CreateAssistantResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistant">REST API Reference for CreateAssistant Operation</seealso>
        CreateAssistantResponse EndCreateAssistant(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAssistantAssociation


        /// <summary>
        /// Creates an association between an Amazon Q in Connect assistant and another resource.
        /// Currently, the only supported association is with a knowledge base. An assistant can
        /// have only a single association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistantAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateAssistantAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistantAssociation">REST API Reference for CreateAssistantAssociation Operation</seealso>
        CreateAssistantAssociationResponse CreateAssistantAssociation(CreateAssistantAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistantAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssistantAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistantAssociation">REST API Reference for CreateAssistantAssociation Operation</seealso>
        IAsyncResult BeginCreateAssistantAssociation(CreateAssistantAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssistantAssociation.</param>
        /// 
        /// <returns>Returns a  CreateAssistantAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistantAssociation">REST API Reference for CreateAssistantAssociation Operation</seealso>
        CreateAssistantAssociationResponse EndCreateAssistantAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContent


        /// <summary>
        /// Creates Amazon Q in Connect content. Before to calling this API, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>
        /// to upload an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContent service method.</param>
        /// 
        /// <returns>The response from the CreateContent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContent">REST API Reference for CreateContent Operation</seealso>
        CreateContentResponse CreateContent(CreateContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContent">REST API Reference for CreateContent Operation</seealso>
        IAsyncResult BeginCreateContent(CreateContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContent.</param>
        /// 
        /// <returns>Returns a  CreateContentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContent">REST API Reference for CreateContent Operation</seealso>
        CreateContentResponse EndCreateContent(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContentAssociation


        /// <summary>
        /// Creates an association between a content resource in a knowledge base and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/step-by-step-guided-experiences.html">step-by-step
        /// guides</a>. Step-by-step guides offer instructions to agents for resolving common
        /// customer issues. You create a content association to integrate Amazon Q in Connect
        /// and step-by-step guides. 
        /// 
        ///  
        /// <para>
        /// After you integrate Amazon Q and step-by-step guides, when Amazon Q provides a recommendation
        /// to an agent based on the intent that it's detected, it also provides them with the
        /// option to start the step-by-step guide that you have associated with the content.
        /// </para>
        ///  
        /// <para>
        /// Note the following limitations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can create only one content association for each content resource in a knowledge
        /// base.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can associate a step-by-step guide with multiple content resources.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/integrate-q-with-guides.html">Integrate
        /// Amazon Q in Connect with step-by-step guides</a> in the <i>Amazon Connect Administrator
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContentAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateContentAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContentAssociation">REST API Reference for CreateContentAssociation Operation</seealso>
        CreateContentAssociationResponse CreateContentAssociation(CreateContentAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContentAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContentAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContentAssociation">REST API Reference for CreateContentAssociation Operation</seealso>
        IAsyncResult BeginCreateContentAssociation(CreateContentAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContentAssociation.</param>
        /// 
        /// <returns>Returns a  CreateContentAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContentAssociation">REST API Reference for CreateContentAssociation Operation</seealso>
        CreateContentAssociationResponse EndCreateContentAssociation(IAsyncResult asyncResult);

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
        /// Call <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_DeleteKnowledgeBase.html">DeleteKnowledgeBase</a>.
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
        /// <returns>The response from the CreateKnowledgeBase service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        CreateKnowledgeBaseResponse CreateKnowledgeBase(CreateKnowledgeBaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        IAsyncResult BeginCreateKnowledgeBase(CreateKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  CreateKnowledgeBaseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        CreateKnowledgeBaseResponse EndCreateKnowledgeBase(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMessageTemplate


        /// <summary>
        /// Creates an Amazon Q in Connect message template. The name of the message template
        /// has to be unique for each knowledge base. The channel subtype of the message template
        /// is immutable and cannot be modified after creation. After the message template is
        /// created, you can use the <c>$LATEST</c> qualifier to reference the created message
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplate">REST API Reference for CreateMessageTemplate Operation</seealso>
        CreateMessageTemplateResponse CreateMessageTemplate(CreateMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplate">REST API Reference for CreateMessageTemplate Operation</seealso>
        IAsyncResult BeginCreateMessageTemplate(CreateMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMessageTemplate.</param>
        /// 
        /// <returns>Returns a  CreateMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplate">REST API Reference for CreateMessageTemplate Operation</seealso>
        CreateMessageTemplateResponse EndCreateMessageTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMessageTemplateAttachment


        /// <summary>
        /// Uploads an attachment file to the specified Amazon Q in Connect message template.
        /// The name of the message template attachment has to be unique for each message template
        /// referenced by the <c>$LATEST</c> qualifier. The body of the attachment file should
        /// be encoded using base64 encoding. After the file is uploaded, you can use the pre-signed
        /// Amazon S3 URL returned in response to download the uploaded file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplateAttachment service method.</param>
        /// 
        /// <returns>The response from the CreateMessageTemplateAttachment service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateAttachment">REST API Reference for CreateMessageTemplateAttachment Operation</seealso>
        CreateMessageTemplateAttachmentResponse CreateMessageTemplateAttachment(CreateMessageTemplateAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMessageTemplateAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplateAttachment operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMessageTemplateAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateAttachment">REST API Reference for CreateMessageTemplateAttachment Operation</seealso>
        IAsyncResult BeginCreateMessageTemplateAttachment(CreateMessageTemplateAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMessageTemplateAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMessageTemplateAttachment.</param>
        /// 
        /// <returns>Returns a  CreateMessageTemplateAttachmentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateAttachment">REST API Reference for CreateMessageTemplateAttachment Operation</seealso>
        CreateMessageTemplateAttachmentResponse EndCreateMessageTemplateAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMessageTemplateVersion


        /// <summary>
        /// Creates a new Amazon Q in Connect message template version from the current content
        /// and configuration of a message template. Versions are immutable and monotonically
        /// increasing. Once a version is created, you can reference a specific version of the
        /// message template by passing in <c>&lt;message-template-id&gt;:&lt;versionNumber&gt;</c>
        /// as the message template identifier. An error is displayed if the supplied <c>messageTemplateContentSha256</c>
        /// is different from the <c>messageTemplateContentSha256</c> of the message template
        /// with <c>$LATEST</c> qualifier. If multiple <c>CreateMessageTemplateVersion</c> requests
        /// are made while the message template remains the same, only the first invocation creates
        /// a new version and the succeeding requests will return the same response as the first
        /// invocation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the CreateMessageTemplateVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateVersion">REST API Reference for CreateMessageTemplateVersion Operation</seealso>
        CreateMessageTemplateVersionResponse CreateMessageTemplateVersion(CreateMessageTemplateVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMessageTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplateVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMessageTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateVersion">REST API Reference for CreateMessageTemplateVersion Operation</seealso>
        IAsyncResult BeginCreateMessageTemplateVersion(CreateMessageTemplateVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMessageTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMessageTemplateVersion.</param>
        /// 
        /// <returns>Returns a  CreateMessageTemplateVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateVersion">REST API Reference for CreateMessageTemplateVersion Operation</seealso>
        CreateMessageTemplateVersionResponse EndCreateMessageTemplateVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateQuickResponse


        /// <summary>
        /// Creates an Amazon Q in Connect quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuickResponse service method.</param>
        /// 
        /// <returns>The response from the CreateQuickResponse service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateQuickResponse">REST API Reference for CreateQuickResponse Operation</seealso>
        CreateQuickResponseResponse CreateQuickResponse(CreateQuickResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQuickResponse operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQuickResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateQuickResponse">REST API Reference for CreateQuickResponse Operation</seealso>
        IAsyncResult BeginCreateQuickResponse(CreateQuickResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQuickResponse.</param>
        /// 
        /// <returns>Returns a  CreateQuickResponseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateQuickResponse">REST API Reference for CreateQuickResponse Operation</seealso>
        CreateQuickResponseResponse EndCreateQuickResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSession


        /// <summary>
        /// Creates a session. A session is a contextual container used for generating recommendations.
        /// Amazon Connect creates a new Amazon Q in Connect session for each contact on which
        /// Amazon Q in Connect is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// 
        /// <returns>The response from the CreateSession service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.DependencyFailedException">
        /// An error occurred while calling a dependency. For example, calling <c>connect:DecribeContact</c>
        /// as part of <c>CreateSession</c> with a contactArn.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateSession">REST API Reference for CreateSession Operation</seealso>
        CreateSessionResponse CreateSession(CreateSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSession operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateSession">REST API Reference for CreateSession Operation</seealso>
        IAsyncResult BeginCreateSession(CreateSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSession.</param>
        /// 
        /// <returns>Returns a  CreateSessionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateSession">REST API Reference for CreateSession Operation</seealso>
        CreateSessionResponse EndCreateSession(IAsyncResult asyncResult);

        #endregion
        
        #region  DeactivateMessageTemplate


        /// <summary>
        /// Deactivates a specific version of the Amazon Q in Connect message template . After
        /// the version is deactivated, you can no longer use the <c>$ACTIVE_VERSION</c> qualifier
        /// to reference the version in active status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMessageTemplate service method.</param>
        /// 
        /// <returns>The response from the DeactivateMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeactivateMessageTemplate">REST API Reference for DeactivateMessageTemplate Operation</seealso>
        DeactivateMessageTemplateResponse DeactivateMessageTemplate(DeactivateMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeactivateMessageTemplate">REST API Reference for DeactivateMessageTemplate Operation</seealso>
        IAsyncResult BeginDeactivateMessageTemplate(DeactivateMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateMessageTemplate.</param>
        /// 
        /// <returns>Returns a  DeactivateMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeactivateMessageTemplate">REST API Reference for DeactivateMessageTemplate Operation</seealso>
        DeactivateMessageTemplateResponse EndDeactivateMessageTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAIAgent


        /// <summary>
        /// Deletes an Amazon Q in Connect AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIAgent service method.</param>
        /// 
        /// <returns>The response from the DeleteAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgent">REST API Reference for DeleteAIAgent Operation</seealso>
        DeleteAIAgentResponse DeleteAIAgent(DeleteAIAgentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgent">REST API Reference for DeleteAIAgent Operation</seealso>
        IAsyncResult BeginDeleteAIAgent(DeleteAIAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIAgent.</param>
        /// 
        /// <returns>Returns a  DeleteAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgent">REST API Reference for DeleteAIAgent Operation</seealso>
        DeleteAIAgentResponse EndDeleteAIAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAIAgentVersion


        /// <summary>
        /// Deletes an Amazon Q in Connect AI Agent Version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIAgentVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteAIAgentVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgentVersion">REST API Reference for DeleteAIAgentVersion Operation</seealso>
        DeleteAIAgentVersionResponse DeleteAIAgentVersion(DeleteAIAgentVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIAgentVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIAgentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgentVersion">REST API Reference for DeleteAIAgentVersion Operation</seealso>
        IAsyncResult BeginDeleteAIAgentVersion(DeleteAIAgentVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIAgentVersion.</param>
        /// 
        /// <returns>Returns a  DeleteAIAgentVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgentVersion">REST API Reference for DeleteAIAgentVersion Operation</seealso>
        DeleteAIAgentVersionResponse EndDeleteAIAgentVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAIGuardrail


        /// <summary>
        /// Deletes an Amazon Q in Connect AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIGuardrail service method.</param>
        /// 
        /// <returns>The response from the DeleteAIGuardrail service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrail">REST API Reference for DeleteAIGuardrail Operation</seealso>
        DeleteAIGuardrailResponse DeleteAIGuardrail(DeleteAIGuardrailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIGuardrail operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrail">REST API Reference for DeleteAIGuardrail Operation</seealso>
        IAsyncResult BeginDeleteAIGuardrail(DeleteAIGuardrailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIGuardrail.</param>
        /// 
        /// <returns>Returns a  DeleteAIGuardrailResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrail">REST API Reference for DeleteAIGuardrail Operation</seealso>
        DeleteAIGuardrailResponse EndDeleteAIGuardrail(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAIGuardrailVersion


        /// <summary>
        /// Delete and Amazon Q in Connect AI Guardrail version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIGuardrailVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteAIGuardrailVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrailVersion">REST API Reference for DeleteAIGuardrailVersion Operation</seealso>
        DeleteAIGuardrailVersionResponse DeleteAIGuardrailVersion(DeleteAIGuardrailVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIGuardrailVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIGuardrailVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIGuardrailVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrailVersion">REST API Reference for DeleteAIGuardrailVersion Operation</seealso>
        IAsyncResult BeginDeleteAIGuardrailVersion(DeleteAIGuardrailVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIGuardrailVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIGuardrailVersion.</param>
        /// 
        /// <returns>Returns a  DeleteAIGuardrailVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrailVersion">REST API Reference for DeleteAIGuardrailVersion Operation</seealso>
        DeleteAIGuardrailVersionResponse EndDeleteAIGuardrailVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAIPrompt


        /// <summary>
        /// Deletes an Amazon Q in Connect AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIPrompt service method.</param>
        /// 
        /// <returns>The response from the DeleteAIPrompt service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPrompt">REST API Reference for DeleteAIPrompt Operation</seealso>
        DeleteAIPromptResponse DeleteAIPrompt(DeleteAIPromptRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIPrompt operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIPrompt
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPrompt">REST API Reference for DeleteAIPrompt Operation</seealso>
        IAsyncResult BeginDeleteAIPrompt(DeleteAIPromptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIPrompt.</param>
        /// 
        /// <returns>Returns a  DeleteAIPromptResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPrompt">REST API Reference for DeleteAIPrompt Operation</seealso>
        DeleteAIPromptResponse EndDeleteAIPrompt(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAIPromptVersion


        /// <summary>
        /// Delete and Amazon Q in Connect AI Prompt version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIPromptVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteAIPromptVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPromptVersion">REST API Reference for DeleteAIPromptVersion Operation</seealso>
        DeleteAIPromptVersionResponse DeleteAIPromptVersion(DeleteAIPromptVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIPromptVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIPromptVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIPromptVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPromptVersion">REST API Reference for DeleteAIPromptVersion Operation</seealso>
        IAsyncResult BeginDeleteAIPromptVersion(DeleteAIPromptVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIPromptVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIPromptVersion.</param>
        /// 
        /// <returns>Returns a  DeleteAIPromptVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPromptVersion">REST API Reference for DeleteAIPromptVersion Operation</seealso>
        DeleteAIPromptVersionResponse EndDeleteAIPromptVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAssistant


        /// <summary>
        /// Deletes an assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistant service method.</param>
        /// 
        /// <returns>The response from the DeleteAssistant service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistant">REST API Reference for DeleteAssistant Operation</seealso>
        DeleteAssistantResponse DeleteAssistant(DeleteAssistantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistant operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistant">REST API Reference for DeleteAssistant Operation</seealso>
        IAsyncResult BeginDeleteAssistant(DeleteAssistantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssistant.</param>
        /// 
        /// <returns>Returns a  DeleteAssistantResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistant">REST API Reference for DeleteAssistant Operation</seealso>
        DeleteAssistantResponse EndDeleteAssistant(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAssistantAssociation


        /// <summary>
        /// Deletes an assistant association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistantAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteAssistantAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistantAssociation">REST API Reference for DeleteAssistantAssociation Operation</seealso>
        DeleteAssistantAssociationResponse DeleteAssistantAssociation(DeleteAssistantAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistantAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssistantAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistantAssociation">REST API Reference for DeleteAssistantAssociation Operation</seealso>
        IAsyncResult BeginDeleteAssistantAssociation(DeleteAssistantAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssistantAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteAssistantAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistantAssociation">REST API Reference for DeleteAssistantAssociation Operation</seealso>
        DeleteAssistantAssociationResponse EndDeleteAssistantAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteContent


        /// <summary>
        /// Deletes the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContent service method.</param>
        /// 
        /// <returns>The response from the DeleteContent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContent">REST API Reference for DeleteContent Operation</seealso>
        DeleteContentResponse DeleteContent(DeleteContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContent">REST API Reference for DeleteContent Operation</seealso>
        IAsyncResult BeginDeleteContent(DeleteContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContent.</param>
        /// 
        /// <returns>Returns a  DeleteContentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContent">REST API Reference for DeleteContent Operation</seealso>
        DeleteContentResponse EndDeleteContent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteContentAssociation


        /// <summary>
        /// Deletes the content association. 
        /// 
        ///  
        /// <para>
        /// For more information about content associations--what they are and when they are used--see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/integrate-q-with-guides.html">Integrate
        /// Amazon Q in Connect with step-by-step guides</a> in the <i>Amazon Connect Administrator
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContentAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteContentAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContentAssociation">REST API Reference for DeleteContentAssociation Operation</seealso>
        DeleteContentAssociationResponse DeleteContentAssociation(DeleteContentAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContentAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContentAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContentAssociation">REST API Reference for DeleteContentAssociation Operation</seealso>
        IAsyncResult BeginDeleteContentAssociation(DeleteContentAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContentAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteContentAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContentAssociation">REST API Reference for DeleteContentAssociation Operation</seealso>
        DeleteContentAssociationResponse EndDeleteContentAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteImportJob


        /// <summary>
        /// Deletes the quick response import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportJob service method.</param>
        /// 
        /// <returns>The response from the DeleteImportJob service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteImportJob">REST API Reference for DeleteImportJob Operation</seealso>
        DeleteImportJobResponse DeleteImportJob(DeleteImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportJob operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteImportJob">REST API Reference for DeleteImportJob Operation</seealso>
        IAsyncResult BeginDeleteImportJob(DeleteImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImportJob.</param>
        /// 
        /// <returns>Returns a  DeleteImportJobResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteImportJob">REST API Reference for DeleteImportJob Operation</seealso>
        DeleteImportJobResponse EndDeleteImportJob(IAsyncResult asyncResult);

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
        /// <returns>The response from the DeleteKnowledgeBase service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        DeleteKnowledgeBaseResponse DeleteKnowledgeBase(DeleteKnowledgeBaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        IAsyncResult BeginDeleteKnowledgeBase(DeleteKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  DeleteKnowledgeBaseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        DeleteKnowledgeBaseResponse EndDeleteKnowledgeBase(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMessageTemplate


        /// <summary>
        /// Deletes an Amazon Q in Connect message template entirely or a specific version of
        /// the message template if version is supplied in the request. You can provide the message
        /// template identifier as <c>&lt;message-template-id&gt;:&lt;versionNumber&gt;</c> to
        /// delete a specific version of the message template. If it is not supplied, the message
        /// template and all available versions will be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplate">REST API Reference for DeleteMessageTemplate Operation</seealso>
        DeleteMessageTemplateResponse DeleteMessageTemplate(DeleteMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplate">REST API Reference for DeleteMessageTemplate Operation</seealso>
        IAsyncResult BeginDeleteMessageTemplate(DeleteMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMessageTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplate">REST API Reference for DeleteMessageTemplate Operation</seealso>
        DeleteMessageTemplateResponse EndDeleteMessageTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMessageTemplateAttachment


        /// <summary>
        /// Deletes the attachment file from the Amazon Q in Connect message template that is
        /// referenced by <c>$LATEST</c> qualifier. Attachments on available message template
        /// versions will remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageTemplateAttachment service method.</param>
        /// 
        /// <returns>The response from the DeleteMessageTemplateAttachment service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplateAttachment">REST API Reference for DeleteMessageTemplateAttachment Operation</seealso>
        DeleteMessageTemplateAttachmentResponse DeleteMessageTemplateAttachment(DeleteMessageTemplateAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessageTemplateAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageTemplateAttachment operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMessageTemplateAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplateAttachment">REST API Reference for DeleteMessageTemplateAttachment Operation</seealso>
        IAsyncResult BeginDeleteMessageTemplateAttachment(DeleteMessageTemplateAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMessageTemplateAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMessageTemplateAttachment.</param>
        /// 
        /// <returns>Returns a  DeleteMessageTemplateAttachmentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplateAttachment">REST API Reference for DeleteMessageTemplateAttachment Operation</seealso>
        DeleteMessageTemplateAttachmentResponse EndDeleteMessageTemplateAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteQuickResponse


        /// <summary>
        /// Deletes a quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuickResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteQuickResponse service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteQuickResponse">REST API Reference for DeleteQuickResponse Operation</seealso>
        DeleteQuickResponseResponse DeleteQuickResponse(DeleteQuickResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuickResponse operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQuickResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteQuickResponse">REST API Reference for DeleteQuickResponse Operation</seealso>
        IAsyncResult BeginDeleteQuickResponse(DeleteQuickResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQuickResponse.</param>
        /// 
        /// <returns>Returns a  DeleteQuickResponseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteQuickResponse">REST API Reference for DeleteQuickResponse Operation</seealso>
        DeleteQuickResponseResponse EndDeleteQuickResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAIAgent


        /// <summary>
        /// Gets an Amazon Q in Connect AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAIAgent service method.</param>
        /// 
        /// <returns>The response from the GetAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIAgent">REST API Reference for GetAIAgent Operation</seealso>
        GetAIAgentResponse GetAIAgent(GetAIAgentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIAgent">REST API Reference for GetAIAgent Operation</seealso>
        IAsyncResult BeginGetAIAgent(GetAIAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAIAgent.</param>
        /// 
        /// <returns>Returns a  GetAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIAgent">REST API Reference for GetAIAgent Operation</seealso>
        GetAIAgentResponse EndGetAIAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAIGuardrail


        /// <summary>
        /// Gets the Amazon Q in Connect AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAIGuardrail service method.</param>
        /// 
        /// <returns>The response from the GetAIGuardrail service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIGuardrail">REST API Reference for GetAIGuardrail Operation</seealso>
        GetAIGuardrailResponse GetAIGuardrail(GetAIGuardrailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAIGuardrail operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAIGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIGuardrail">REST API Reference for GetAIGuardrail Operation</seealso>
        IAsyncResult BeginGetAIGuardrail(GetAIGuardrailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAIGuardrail.</param>
        /// 
        /// <returns>Returns a  GetAIGuardrailResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIGuardrail">REST API Reference for GetAIGuardrail Operation</seealso>
        GetAIGuardrailResponse EndGetAIGuardrail(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAIPrompt


        /// <summary>
        /// Gets and Amazon Q in Connect AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAIPrompt service method.</param>
        /// 
        /// <returns>The response from the GetAIPrompt service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIPrompt">REST API Reference for GetAIPrompt Operation</seealso>
        GetAIPromptResponse GetAIPrompt(GetAIPromptRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAIPrompt operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAIPrompt
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIPrompt">REST API Reference for GetAIPrompt Operation</seealso>
        IAsyncResult BeginGetAIPrompt(GetAIPromptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAIPrompt.</param>
        /// 
        /// <returns>Returns a  GetAIPromptResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIPrompt">REST API Reference for GetAIPrompt Operation</seealso>
        GetAIPromptResponse EndGetAIPrompt(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssistant


        /// <summary>
        /// Retrieves information about an assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssistant service method.</param>
        /// 
        /// <returns>The response from the GetAssistant service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistant">REST API Reference for GetAssistant Operation</seealso>
        GetAssistantResponse GetAssistant(GetAssistantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssistant operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistant">REST API Reference for GetAssistant Operation</seealso>
        IAsyncResult BeginGetAssistant(GetAssistantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssistant.</param>
        /// 
        /// <returns>Returns a  GetAssistantResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistant">REST API Reference for GetAssistant Operation</seealso>
        GetAssistantResponse EndGetAssistant(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssistantAssociation


        /// <summary>
        /// Retrieves information about an assistant association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssistantAssociation service method.</param>
        /// 
        /// <returns>The response from the GetAssistantAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistantAssociation">REST API Reference for GetAssistantAssociation Operation</seealso>
        GetAssistantAssociationResponse GetAssistantAssociation(GetAssistantAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssistantAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssistantAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistantAssociation">REST API Reference for GetAssistantAssociation Operation</seealso>
        IAsyncResult BeginGetAssistantAssociation(GetAssistantAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssistantAssociation.</param>
        /// 
        /// <returns>Returns a  GetAssistantAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistantAssociation">REST API Reference for GetAssistantAssociation Operation</seealso>
        GetAssistantAssociationResponse EndGetAssistantAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContent


        /// <summary>
        /// Retrieves content, including a pre-signed URL to download the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContent service method.</param>
        /// 
        /// <returns>The response from the GetContent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContent">REST API Reference for GetContent Operation</seealso>
        GetContentResponse GetContent(GetContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContent">REST API Reference for GetContent Operation</seealso>
        IAsyncResult BeginGetContent(GetContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContent.</param>
        /// 
        /// <returns>Returns a  GetContentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContent">REST API Reference for GetContent Operation</seealso>
        GetContentResponse EndGetContent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContentAssociation


        /// <summary>
        /// Returns the content association.
        /// 
        ///  
        /// <para>
        /// For more information about content associations--what they are and when they are used--see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/integrate-q-with-guides.html">Integrate
        /// Amazon Q in Connect with step-by-step guides</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContentAssociation service method.</param>
        /// 
        /// <returns>The response from the GetContentAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentAssociation">REST API Reference for GetContentAssociation Operation</seealso>
        GetContentAssociationResponse GetContentAssociation(GetContentAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContentAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContentAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentAssociation">REST API Reference for GetContentAssociation Operation</seealso>
        IAsyncResult BeginGetContentAssociation(GetContentAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContentAssociation.</param>
        /// 
        /// <returns>Returns a  GetContentAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentAssociation">REST API Reference for GetContentAssociation Operation</seealso>
        GetContentAssociationResponse EndGetContentAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContentSummary


        /// <summary>
        /// Retrieves summary information about the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContentSummary service method.</param>
        /// 
        /// <returns>The response from the GetContentSummary service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentSummary">REST API Reference for GetContentSummary Operation</seealso>
        GetContentSummaryResponse GetContentSummary(GetContentSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContentSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContentSummary operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContentSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentSummary">REST API Reference for GetContentSummary Operation</seealso>
        IAsyncResult BeginGetContentSummary(GetContentSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContentSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContentSummary.</param>
        /// 
        /// <returns>Returns a  GetContentSummaryResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentSummary">REST API Reference for GetContentSummary Operation</seealso>
        GetContentSummaryResponse EndGetContentSummary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetImportJob


        /// <summary>
        /// Retrieves the started import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// 
        /// <returns>The response from the GetImportJob service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        GetImportJobResponse GetImportJob(GetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        IAsyncResult BeginGetImportJob(GetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJob.</param>
        /// 
        /// <returns>Returns a  GetImportJobResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        GetImportJobResponse EndGetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKnowledgeBase


        /// <summary>
        /// Retrieves information about the knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the GetKnowledgeBase service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        GetKnowledgeBaseResponse GetKnowledgeBase(GetKnowledgeBaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        IAsyncResult BeginGetKnowledgeBase(GetKnowledgeBaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  GetKnowledgeBaseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        GetKnowledgeBaseResponse EndGetKnowledgeBase(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMessageTemplate


        /// <summary>
        /// Retrieves the Amazon Q in Connect message template. The message template identifier
        /// can contain an optional qualifier, for example, <c>&lt;message-template-id&gt;:&lt;qualifier&gt;</c>,
        /// which is either an actual version number or an Amazon Q Connect managed qualifier
        /// <c>$ACTIVE_VERSION</c> | <c>$LATEST</c>. If it is not supplied, then <c>$LATEST</c>
        /// is assumed implicitly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMessageTemplate service method.</param>
        /// 
        /// <returns>The response from the GetMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetMessageTemplate">REST API Reference for GetMessageTemplate Operation</seealso>
        GetMessageTemplateResponse GetMessageTemplate(GetMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetMessageTemplate">REST API Reference for GetMessageTemplate Operation</seealso>
        IAsyncResult BeginGetMessageTemplate(GetMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMessageTemplate.</param>
        /// 
        /// <returns>Returns a  GetMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetMessageTemplate">REST API Reference for GetMessageTemplate Operation</seealso>
        GetMessageTemplateResponse EndGetMessageTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNextMessage


        /// <summary>
        /// Retrieves next message on an Amazon Q in Connect session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNextMessage service method.</param>
        /// 
        /// <returns>The response from the GetNextMessage service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetNextMessage">REST API Reference for GetNextMessage Operation</seealso>
        GetNextMessageResponse GetNextMessage(GetNextMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNextMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNextMessage operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNextMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetNextMessage">REST API Reference for GetNextMessage Operation</seealso>
        IAsyncResult BeginGetNextMessage(GetNextMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNextMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNextMessage.</param>
        /// 
        /// <returns>Returns a  GetNextMessageResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetNextMessage">REST API Reference for GetNextMessage Operation</seealso>
        GetNextMessageResponse EndGetNextMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQuickResponse


        /// <summary>
        /// Retrieves the quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuickResponse service method.</param>
        /// 
        /// <returns>The response from the GetQuickResponse service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetQuickResponse">REST API Reference for GetQuickResponse Operation</seealso>
        GetQuickResponseResponse GetQuickResponse(GetQuickResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQuickResponse operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQuickResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetQuickResponse">REST API Reference for GetQuickResponse Operation</seealso>
        IAsyncResult BeginGetQuickResponse(GetQuickResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQuickResponse.</param>
        /// 
        /// <returns>Returns a  GetQuickResponseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetQuickResponse">REST API Reference for GetQuickResponse Operation</seealso>
        GetQuickResponseResponse EndGetQuickResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecommendations


        /// <summary>
        /// <important> 
        /// <para>
        /// This API will be discontinued starting June 1, 2024. To receive generative responses
        /// after March 1, 2024, you will need to create a new Assistant in the Amazon Connect
        /// console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs)
        /// into your applications.
        /// 
        ///  </important> 
        /// <para>
        /// Retrieves recommendations for the specified session. To avoid retrieving the same
        /// recommendations in subsequent calls, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_NotifyRecommendationsReceived.html">NotifyRecommendationsReceived</a>.
        /// This API supports long-polling behavior with the <c>waitTimeSeconds</c> parameter.
        /// Short poll is the default behavior and only returns recommendations already available.
        /// To perform a manual query against an assistant, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_QueryAssistant.html">QueryAssistant</a>.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetRecommendations service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        [Obsolete("GetRecommendations API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        GetRecommendationsResponse GetRecommendations(GetRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        [Obsolete("GetRecommendations API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        IAsyncResult BeginGetRecommendations(GetRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendations.</param>
        /// 
        /// <returns>Returns a  GetRecommendationsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        [Obsolete("GetRecommendations API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        GetRecommendationsResponse EndGetRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSession


        /// <summary>
        /// Retrieves information for a specified session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse GetSession(GetSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetSession">REST API Reference for GetSession Operation</seealso>
        IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse EndGetSession(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAIAgents


        /// <summary>
        /// Lists AI Agents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIAgents service method.</param>
        /// 
        /// <returns>The response from the ListAIAgents service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgents">REST API Reference for ListAIAgents Operation</seealso>
        ListAIAgentsResponse ListAIAgents(ListAIAgentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIAgents operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIAgents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgents">REST API Reference for ListAIAgents Operation</seealso>
        IAsyncResult BeginListAIAgents(ListAIAgentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIAgents.</param>
        /// 
        /// <returns>Returns a  ListAIAgentsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgents">REST API Reference for ListAIAgents Operation</seealso>
        ListAIAgentsResponse EndListAIAgents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAIAgentVersions


        /// <summary>
        /// List AI Agent versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIAgentVersions service method.</param>
        /// 
        /// <returns>The response from the ListAIAgentVersions service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgentVersions">REST API Reference for ListAIAgentVersions Operation</seealso>
        ListAIAgentVersionsResponse ListAIAgentVersions(ListAIAgentVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIAgentVersions operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIAgentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgentVersions">REST API Reference for ListAIAgentVersions Operation</seealso>
        IAsyncResult BeginListAIAgentVersions(ListAIAgentVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIAgentVersions.</param>
        /// 
        /// <returns>Returns a  ListAIAgentVersionsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgentVersions">REST API Reference for ListAIAgentVersions Operation</seealso>
        ListAIAgentVersionsResponse EndListAIAgentVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAIGuardrails


        /// <summary>
        /// Lists the AI Guardrails available on the Amazon Q in Connect assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIGuardrails service method.</param>
        /// 
        /// <returns>The response from the ListAIGuardrails service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrails">REST API Reference for ListAIGuardrails Operation</seealso>
        ListAIGuardrailsResponse ListAIGuardrails(ListAIGuardrailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIGuardrails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIGuardrails operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIGuardrails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrails">REST API Reference for ListAIGuardrails Operation</seealso>
        IAsyncResult BeginListAIGuardrails(ListAIGuardrailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIGuardrails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIGuardrails.</param>
        /// 
        /// <returns>Returns a  ListAIGuardrailsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrails">REST API Reference for ListAIGuardrails Operation</seealso>
        ListAIGuardrailsResponse EndListAIGuardrails(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAIGuardrailVersions


        /// <summary>
        /// Lists AI Guardrail versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIGuardrailVersions service method.</param>
        /// 
        /// <returns>The response from the ListAIGuardrailVersions service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrailVersions">REST API Reference for ListAIGuardrailVersions Operation</seealso>
        ListAIGuardrailVersionsResponse ListAIGuardrailVersions(ListAIGuardrailVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIGuardrailVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIGuardrailVersions operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIGuardrailVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrailVersions">REST API Reference for ListAIGuardrailVersions Operation</seealso>
        IAsyncResult BeginListAIGuardrailVersions(ListAIGuardrailVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIGuardrailVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIGuardrailVersions.</param>
        /// 
        /// <returns>Returns a  ListAIGuardrailVersionsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrailVersions">REST API Reference for ListAIGuardrailVersions Operation</seealso>
        ListAIGuardrailVersionsResponse EndListAIGuardrailVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAIPrompts


        /// <summary>
        /// Lists the AI Prompts available on the Amazon Q in Connect assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIPrompts service method.</param>
        /// 
        /// <returns>The response from the ListAIPrompts service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPrompts">REST API Reference for ListAIPrompts Operation</seealso>
        ListAIPromptsResponse ListAIPrompts(ListAIPromptsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIPrompts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIPrompts operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIPrompts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPrompts">REST API Reference for ListAIPrompts Operation</seealso>
        IAsyncResult BeginListAIPrompts(ListAIPromptsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIPrompts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIPrompts.</param>
        /// 
        /// <returns>Returns a  ListAIPromptsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPrompts">REST API Reference for ListAIPrompts Operation</seealso>
        ListAIPromptsResponse EndListAIPrompts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAIPromptVersions


        /// <summary>
        /// Lists AI Prompt versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIPromptVersions service method.</param>
        /// 
        /// <returns>The response from the ListAIPromptVersions service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPromptVersions">REST API Reference for ListAIPromptVersions Operation</seealso>
        ListAIPromptVersionsResponse ListAIPromptVersions(ListAIPromptVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIPromptVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIPromptVersions operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIPromptVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPromptVersions">REST API Reference for ListAIPromptVersions Operation</seealso>
        IAsyncResult BeginListAIPromptVersions(ListAIPromptVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIPromptVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIPromptVersions.</param>
        /// 
        /// <returns>Returns a  ListAIPromptVersionsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPromptVersions">REST API Reference for ListAIPromptVersions Operation</seealso>
        ListAIPromptVersionsResponse EndListAIPromptVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssistantAssociations


        /// <summary>
        /// Lists information about assistant associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssistantAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssistantAssociations service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistantAssociations">REST API Reference for ListAssistantAssociations Operation</seealso>
        ListAssistantAssociationsResponse ListAssistantAssociations(ListAssistantAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssistantAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssistantAssociations operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssistantAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistantAssociations">REST API Reference for ListAssistantAssociations Operation</seealso>
        IAsyncResult BeginListAssistantAssociations(ListAssistantAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssistantAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssistantAssociations.</param>
        /// 
        /// <returns>Returns a  ListAssistantAssociationsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistantAssociations">REST API Reference for ListAssistantAssociations Operation</seealso>
        ListAssistantAssociationsResponse EndListAssistantAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssistants


        /// <summary>
        /// Lists information about assistants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssistants service method.</param>
        /// 
        /// <returns>The response from the ListAssistants service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        ListAssistantsResponse ListAssistants(ListAssistantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssistants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssistants operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssistants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        IAsyncResult BeginListAssistants(ListAssistantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssistants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssistants.</param>
        /// 
        /// <returns>Returns a  ListAssistantsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        ListAssistantsResponse EndListAssistants(IAsyncResult asyncResult);

        #endregion
        
        #region  ListContentAssociations


        /// <summary>
        /// Lists the content associations.
        /// 
        ///  
        /// <para>
        /// For more information about content associations--what they are and when they are used--see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/integrate-q-with-guides.html">Integrate
        /// Amazon Q in Connect with step-by-step guides</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContentAssociations service method.</param>
        /// 
        /// <returns>The response from the ListContentAssociations service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContentAssociations">REST API Reference for ListContentAssociations Operation</seealso>
        ListContentAssociationsResponse ListContentAssociations(ListContentAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListContentAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContentAssociations operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContentAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContentAssociations">REST API Reference for ListContentAssociations Operation</seealso>
        IAsyncResult BeginListContentAssociations(ListContentAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContentAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContentAssociations.</param>
        /// 
        /// <returns>Returns a  ListContentAssociationsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContentAssociations">REST API Reference for ListContentAssociations Operation</seealso>
        ListContentAssociationsResponse EndListContentAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListContents


        /// <summary>
        /// Lists the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContents service method.</param>
        /// 
        /// <returns>The response from the ListContents service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContents">REST API Reference for ListContents Operation</seealso>
        ListContentsResponse ListContents(ListContentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListContents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContents operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContents">REST API Reference for ListContents Operation</seealso>
        IAsyncResult BeginListContents(ListContentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContents.</param>
        /// 
        /// <returns>Returns a  ListContentsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContents">REST API Reference for ListContents Operation</seealso>
        ListContentsResponse EndListContents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImportJobs


        /// <summary>
        /// Lists information about import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListImportJobs service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        ListImportJobsResponse ListImportJobs(ListImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImportJobs operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        IAsyncResult BeginListImportJobs(ListImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImportJobs.</param>
        /// 
        /// <returns>Returns a  ListImportJobsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        ListImportJobsResponse EndListImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKnowledgeBases


        /// <summary>
        /// Lists the knowledge bases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases service method.</param>
        /// 
        /// <returns>The response from the ListKnowledgeBases service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        ListKnowledgeBasesResponse ListKnowledgeBases(ListKnowledgeBasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKnowledgeBases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        IAsyncResult BeginListKnowledgeBases(ListKnowledgeBasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKnowledgeBases.</param>
        /// 
        /// <returns>Returns a  ListKnowledgeBasesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        ListKnowledgeBasesResponse EndListKnowledgeBases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMessages


        /// <summary>
        /// Lists messages on an Amazon Q in Connect session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessages service method.</param>
        /// 
        /// <returns>The response from the ListMessages service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessages">REST API Reference for ListMessages Operation</seealso>
        ListMessagesResponse ListMessages(ListMessagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMessages operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessages">REST API Reference for ListMessages Operation</seealso>
        IAsyncResult BeginListMessages(ListMessagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMessages.</param>
        /// 
        /// <returns>Returns a  ListMessagesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessages">REST API Reference for ListMessages Operation</seealso>
        ListMessagesResponse EndListMessages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMessageTemplates


        /// <summary>
        /// Lists all the available Amazon Q in Connect message templates for the specified knowledge
        /// base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessageTemplates service method.</param>
        /// 
        /// <returns>The response from the ListMessageTemplates service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplates">REST API Reference for ListMessageTemplates Operation</seealso>
        ListMessageTemplatesResponse ListMessageTemplates(ListMessageTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMessageTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMessageTemplates operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMessageTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplates">REST API Reference for ListMessageTemplates Operation</seealso>
        IAsyncResult BeginListMessageTemplates(ListMessageTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMessageTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMessageTemplates.</param>
        /// 
        /// <returns>Returns a  ListMessageTemplatesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplates">REST API Reference for ListMessageTemplates Operation</seealso>
        ListMessageTemplatesResponse EndListMessageTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMessageTemplateVersions


        /// <summary>
        /// Lists all the available versions for the specified Amazon Q in Connect message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessageTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the ListMessageTemplateVersions service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplateVersions">REST API Reference for ListMessageTemplateVersions Operation</seealso>
        ListMessageTemplateVersionsResponse ListMessageTemplateVersions(ListMessageTemplateVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMessageTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMessageTemplateVersions operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMessageTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplateVersions">REST API Reference for ListMessageTemplateVersions Operation</seealso>
        IAsyncResult BeginListMessageTemplateVersions(ListMessageTemplateVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMessageTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMessageTemplateVersions.</param>
        /// 
        /// <returns>Returns a  ListMessageTemplateVersionsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplateVersions">REST API Reference for ListMessageTemplateVersions Operation</seealso>
        ListMessageTemplateVersionsResponse EndListMessageTemplateVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQuickResponses


        /// <summary>
        /// Lists information about quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickResponses service method.</param>
        /// 
        /// <returns>The response from the ListQuickResponses service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListQuickResponses">REST API Reference for ListQuickResponses Operation</seealso>
        ListQuickResponsesResponse ListQuickResponses(ListQuickResponsesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQuickResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQuickResponses operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQuickResponses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListQuickResponses">REST API Reference for ListQuickResponses Operation</seealso>
        IAsyncResult BeginListQuickResponses(ListQuickResponsesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQuickResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQuickResponses.</param>
        /// 
        /// <returns>Returns a  ListQuickResponsesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListQuickResponses">REST API Reference for ListQuickResponses Operation</seealso>
        ListQuickResponsesResponse EndListQuickResponses(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  NotifyRecommendationsReceived


        /// <summary>
        /// Removes the specified recommendations from the specified assistant's queue of newly
        /// available recommendations. You can use this API in conjunction with <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>
        /// and a <c>waitTimeSeconds</c> input for long-polling behavior and avoiding duplicate
        /// recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyRecommendationsReceived service method.</param>
        /// 
        /// <returns>The response from the NotifyRecommendationsReceived service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/NotifyRecommendationsReceived">REST API Reference for NotifyRecommendationsReceived Operation</seealso>
        NotifyRecommendationsReceivedResponse NotifyRecommendationsReceived(NotifyRecommendationsReceivedRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NotifyRecommendationsReceived operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyRecommendationsReceived operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNotifyRecommendationsReceived
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/NotifyRecommendationsReceived">REST API Reference for NotifyRecommendationsReceived Operation</seealso>
        IAsyncResult BeginNotifyRecommendationsReceived(NotifyRecommendationsReceivedRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NotifyRecommendationsReceived operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNotifyRecommendationsReceived.</param>
        /// 
        /// <returns>Returns a  NotifyRecommendationsReceivedResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/NotifyRecommendationsReceived">REST API Reference for NotifyRecommendationsReceived Operation</seealso>
        NotifyRecommendationsReceivedResponse EndNotifyRecommendationsReceived(IAsyncResult asyncResult);

        #endregion
        
        #region  PutFeedback


        /// <summary>
        /// Provides feedback against the specified assistant for the specified target. This API
        /// only supports generative targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
        /// 
        /// <returns>The response from the PutFeedback service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        PutFeedbackResponse PutFeedback(PutFeedbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        IAsyncResult BeginPutFeedback(PutFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFeedback.</param>
        /// 
        /// <returns>Returns a  PutFeedbackResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        PutFeedbackResponse EndPutFeedback(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryAssistant


        /// <summary>
        /// <important> 
        /// <para>
        /// This API will be discontinued starting June 1, 2024. To receive generative responses
        /// after March 1, 2024, you will need to create a new Assistant in the Amazon Connect
        /// console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs)
        /// into your applications.
        /// 
        ///  </important> 
        /// <para>
        /// Performs a manual search against the specified assistant. To retrieve recommendations
        /// for an assistant, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>.
        /// 
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryAssistant service method.</param>
        /// 
        /// <returns>The response from the QueryAssistant service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.RequestTimeoutException">
        /// The request reached the service more than 15 minutes after the date stamp on the request
        /// or more than 15 minutes after the request expiration date (such as for pre-signed
        /// URLs), or the date stamp on the request is more than 15 minutes in the future.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/QueryAssistant">REST API Reference for QueryAssistant Operation</seealso>
        [Obsolete("QueryAssistant API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        QueryAssistantResponse QueryAssistant(QueryAssistantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryAssistant operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/QueryAssistant">REST API Reference for QueryAssistant Operation</seealso>
        [Obsolete("QueryAssistant API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        IAsyncResult BeginQueryAssistant(QueryAssistantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryAssistant.</param>
        /// 
        /// <returns>Returns a  QueryAssistantResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/QueryAssistant">REST API Reference for QueryAssistant Operation</seealso>
        [Obsolete("QueryAssistant API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        QueryAssistantResponse EndQueryAssistant(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveAssistantAIAgent


        /// <summary>
        /// Removes the AI Agent that is set for use by default on an Amazon Q in Connect Assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAssistantAIAgent service method.</param>
        /// 
        /// <returns>The response from the RemoveAssistantAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveAssistantAIAgent">REST API Reference for RemoveAssistantAIAgent Operation</seealso>
        RemoveAssistantAIAgentResponse RemoveAssistantAIAgent(RemoveAssistantAIAgentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAssistantAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAssistantAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAssistantAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveAssistantAIAgent">REST API Reference for RemoveAssistantAIAgent Operation</seealso>
        IAsyncResult BeginRemoveAssistantAIAgent(RemoveAssistantAIAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAssistantAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAssistantAIAgent.</param>
        /// 
        /// <returns>Returns a  RemoveAssistantAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveAssistantAIAgent">REST API Reference for RemoveAssistantAIAgent Operation</seealso>
        RemoveAssistantAIAgentResponse EndRemoveAssistantAIAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveKnowledgeBaseTemplateUri


        /// <summary>
        /// Removes a URI template from a knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveKnowledgeBaseTemplateUri service method.</param>
        /// 
        /// <returns>The response from the RemoveKnowledgeBaseTemplateUri service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveKnowledgeBaseTemplateUri">REST API Reference for RemoveKnowledgeBaseTemplateUri Operation</seealso>
        RemoveKnowledgeBaseTemplateUriResponse RemoveKnowledgeBaseTemplateUri(RemoveKnowledgeBaseTemplateUriRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveKnowledgeBaseTemplateUri operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveKnowledgeBaseTemplateUri
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveKnowledgeBaseTemplateUri">REST API Reference for RemoveKnowledgeBaseTemplateUri Operation</seealso>
        IAsyncResult BeginRemoveKnowledgeBaseTemplateUri(RemoveKnowledgeBaseTemplateUriRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveKnowledgeBaseTemplateUri.</param>
        /// 
        /// <returns>Returns a  RemoveKnowledgeBaseTemplateUriResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveKnowledgeBaseTemplateUri">REST API Reference for RemoveKnowledgeBaseTemplateUri Operation</seealso>
        RemoveKnowledgeBaseTemplateUriResponse EndRemoveKnowledgeBaseTemplateUri(IAsyncResult asyncResult);

        #endregion
        
        #region  RenderMessageTemplate


        /// <summary>
        /// Renders the Amazon Q in Connect message template based on the attribute values provided
        /// and generates the message content. For any variable present in the message template,
        /// if the attribute value is neither provided in the attribute request parameter nor
        /// the default attribute of the message template, the rendered message content will keep
        /// the variable placeholder as it is and return the attribute keys that are missing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenderMessageTemplate service method.</param>
        /// 
        /// <returns>The response from the RenderMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RenderMessageTemplate">REST API Reference for RenderMessageTemplate Operation</seealso>
        RenderMessageTemplateResponse RenderMessageTemplate(RenderMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RenderMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenderMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenderMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RenderMessageTemplate">REST API Reference for RenderMessageTemplate Operation</seealso>
        IAsyncResult BeginRenderMessageTemplate(RenderMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RenderMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenderMessageTemplate.</param>
        /// 
        /// <returns>Returns a  RenderMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RenderMessageTemplate">REST API Reference for RenderMessageTemplate Operation</seealso>
        RenderMessageTemplateResponse EndRenderMessageTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchContent


        /// <summary>
        /// Searches for content in a specified knowledge base. Can be used to get a specific
        /// content resource by its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchContent service method.</param>
        /// 
        /// <returns>The response from the SearchContent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchContent">REST API Reference for SearchContent Operation</seealso>
        SearchContentResponse SearchContent(SearchContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchContent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchContent">REST API Reference for SearchContent Operation</seealso>
        IAsyncResult BeginSearchContent(SearchContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchContent.</param>
        /// 
        /// <returns>Returns a  SearchContentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchContent">REST API Reference for SearchContent Operation</seealso>
        SearchContentResponse EndSearchContent(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchMessageTemplates


        /// <summary>
        /// Searches for Amazon Q in Connect message templates in the specified knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchMessageTemplates service method.</param>
        /// 
        /// <returns>The response from the SearchMessageTemplates service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchMessageTemplates">REST API Reference for SearchMessageTemplates Operation</seealso>
        SearchMessageTemplatesResponse SearchMessageTemplates(SearchMessageTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchMessageTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchMessageTemplates operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchMessageTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchMessageTemplates">REST API Reference for SearchMessageTemplates Operation</seealso>
        IAsyncResult BeginSearchMessageTemplates(SearchMessageTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchMessageTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchMessageTemplates.</param>
        /// 
        /// <returns>Returns a  SearchMessageTemplatesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchMessageTemplates">REST API Reference for SearchMessageTemplates Operation</seealso>
        SearchMessageTemplatesResponse EndSearchMessageTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchQuickResponses


        /// <summary>
        /// Searches existing Amazon Q in Connect quick responses in an Amazon Q in Connect knowledge
        /// base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchQuickResponses service method.</param>
        /// 
        /// <returns>The response from the SearchQuickResponses service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.RequestTimeoutException">
        /// The request reached the service more than 15 minutes after the date stamp on the request
        /// or more than 15 minutes after the request expiration date (such as for pre-signed
        /// URLs), or the date stamp on the request is more than 15 minutes in the future.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchQuickResponses">REST API Reference for SearchQuickResponses Operation</seealso>
        SearchQuickResponsesResponse SearchQuickResponses(SearchQuickResponsesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchQuickResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchQuickResponses operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchQuickResponses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchQuickResponses">REST API Reference for SearchQuickResponses Operation</seealso>
        IAsyncResult BeginSearchQuickResponses(SearchQuickResponsesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchQuickResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchQuickResponses.</param>
        /// 
        /// <returns>Returns a  SearchQuickResponsesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchQuickResponses">REST API Reference for SearchQuickResponses Operation</seealso>
        SearchQuickResponsesResponse EndSearchQuickResponses(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchSessions


        /// <summary>
        /// Searches for sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSessions service method.</param>
        /// 
        /// <returns>The response from the SearchSessions service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchSessions">REST API Reference for SearchSessions Operation</seealso>
        SearchSessionsResponse SearchSessions(SearchSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSessions operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchSessions">REST API Reference for SearchSessions Operation</seealso>
        IAsyncResult BeginSearchSessions(SearchSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSessions.</param>
        /// 
        /// <returns>Returns a  SearchSessionsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchSessions">REST API Reference for SearchSessions Operation</seealso>
        SearchSessionsResponse EndSearchSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  SendMessage


        /// <summary>
        /// Submits a message to the Amazon Q in Connect session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.RequestTimeoutException">
        /// The request reached the service more than 15 minutes after the date stamp on the request
        /// or more than 15 minutes after the request expiration date (such as for pre-signed
        /// URLs), or the date stamp on the request is more than 15 minutes in the future.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SendMessage">REST API Reference for SendMessage Operation</seealso>
        SendMessageResponse SendMessage(SendMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessage operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SendMessage">REST API Reference for SendMessage Operation</seealso>
        IAsyncResult BeginSendMessage(SendMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessage.</param>
        /// 
        /// <returns>Returns a  SendMessageResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SendMessage">REST API Reference for SendMessage Operation</seealso>
        SendMessageResponse EndSendMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  StartContentUpload


        /// <summary>
        /// Get a URL to upload content to a knowledge base. To upload content, first make a PUT
        /// request to the returned URL with your file, making sure to include the required headers.
        /// Then use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_CreateContent.html">CreateContent</a>
        /// to finalize the content creation process or <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_UpdateContent.html">UpdateContent</a>
        /// to modify an existing resource. You can only upload content to a knowledge base of
        /// type CUSTOM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContentUpload service method.</param>
        /// 
        /// <returns>The response from the StartContentUpload service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartContentUpload">REST API Reference for StartContentUpload Operation</seealso>
        StartContentUploadResponse StartContentUpload(StartContentUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartContentUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartContentUpload operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartContentUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartContentUpload">REST API Reference for StartContentUpload Operation</seealso>
        IAsyncResult BeginStartContentUpload(StartContentUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartContentUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartContentUpload.</param>
        /// 
        /// <returns>Returns a  StartContentUploadResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartContentUpload">REST API Reference for StartContentUpload Operation</seealso>
        StartContentUploadResponse EndStartContentUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  StartImportJob


        /// <summary>
        /// Start an asynchronous job to import Amazon Q in Connect resources from an uploaded
        /// source file. Before calling this API, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>
        /// to upload an asset that contains the resource data.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For importing Amazon Q in Connect quick responses, you need to upload a csv file including
        /// the quick responses. For information about how to format the csv file for importing
        /// quick responses, see <a href="https://docs.aws.amazon.com/console/connect/quick-responses/add-data">Import
        /// quick responses</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportJob service method.</param>
        /// 
        /// <returns>The response from the StartImportJob service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartImportJob">REST API Reference for StartImportJob Operation</seealso>
        StartImportJobResponse StartImportJob(StartImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImportJob operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartImportJob">REST API Reference for StartImportJob Operation</seealso>
        IAsyncResult BeginStartImportJob(StartImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImportJob.</param>
        /// 
        /// <returns>Returns a  StartImportJobResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartImportJob">REST API Reference for StartImportJob Operation</seealso>
        StartImportJobResponse EndStartImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.TooManyTagsException">
        /// Amazon Q in Connect throws this exception if you have too many tags in your tag set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAIAgent


        /// <summary>
        /// Updates an AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIAgent service method.</param>
        /// 
        /// <returns>The response from the UpdateAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIAgent">REST API Reference for UpdateAIAgent Operation</seealso>
        UpdateAIAgentResponse UpdateAIAgent(UpdateAIAgentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIAgent">REST API Reference for UpdateAIAgent Operation</seealso>
        IAsyncResult BeginUpdateAIAgent(UpdateAIAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAIAgent.</param>
        /// 
        /// <returns>Returns a  UpdateAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIAgent">REST API Reference for UpdateAIAgent Operation</seealso>
        UpdateAIAgentResponse EndUpdateAIAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAIGuardrail


        /// <summary>
        /// Updates an AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIGuardrail service method.</param>
        /// 
        /// <returns>The response from the UpdateAIGuardrail service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIGuardrail">REST API Reference for UpdateAIGuardrail Operation</seealso>
        UpdateAIGuardrailResponse UpdateAIGuardrail(UpdateAIGuardrailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIGuardrail operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAIGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIGuardrail">REST API Reference for UpdateAIGuardrail Operation</seealso>
        IAsyncResult BeginUpdateAIGuardrail(UpdateAIGuardrailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAIGuardrail.</param>
        /// 
        /// <returns>Returns a  UpdateAIGuardrailResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIGuardrail">REST API Reference for UpdateAIGuardrail Operation</seealso>
        UpdateAIGuardrailResponse EndUpdateAIGuardrail(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAIPrompt


        /// <summary>
        /// Updates an AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIPrompt service method.</param>
        /// 
        /// <returns>The response from the UpdateAIPrompt service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIPrompt">REST API Reference for UpdateAIPrompt Operation</seealso>
        UpdateAIPromptResponse UpdateAIPrompt(UpdateAIPromptRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIPrompt operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAIPrompt
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIPrompt">REST API Reference for UpdateAIPrompt Operation</seealso>
        IAsyncResult BeginUpdateAIPrompt(UpdateAIPromptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAIPrompt.</param>
        /// 
        /// <returns>Returns a  UpdateAIPromptResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIPrompt">REST API Reference for UpdateAIPrompt Operation</seealso>
        UpdateAIPromptResponse EndUpdateAIPrompt(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAssistantAIAgent


        /// <summary>
        /// Updates the AI Agent that is set for use by default on an Amazon Q in Connect Assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssistantAIAgent service method.</param>
        /// 
        /// <returns>The response from the UpdateAssistantAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAssistantAIAgent">REST API Reference for UpdateAssistantAIAgent Operation</seealso>
        UpdateAssistantAIAgentResponse UpdateAssistantAIAgent(UpdateAssistantAIAgentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssistantAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssistantAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssistantAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAssistantAIAgent">REST API Reference for UpdateAssistantAIAgent Operation</seealso>
        IAsyncResult BeginUpdateAssistantAIAgent(UpdateAssistantAIAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssistantAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssistantAIAgent.</param>
        /// 
        /// <returns>Returns a  UpdateAssistantAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAssistantAIAgent">REST API Reference for UpdateAssistantAIAgent Operation</seealso>
        UpdateAssistantAIAgentResponse EndUpdateAssistantAIAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateContent


        /// <summary>
        /// Updates information about the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContent service method.</param>
        /// 
        /// <returns>The response from the UpdateContent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.PreconditionFailedException">
        /// The provided <c>revisionId</c> does not match, indicating the content has been modified
        /// since it was last read.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        UpdateContentResponse UpdateContent(UpdateContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        IAsyncResult BeginUpdateContent(UpdateContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContent.</param>
        /// 
        /// <returns>Returns a  UpdateContentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        UpdateContentResponse EndUpdateContent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKnowledgeBaseTemplateUri


        /// <summary>
        /// Updates the template URI of a knowledge base. This is only supported for knowledge
        /// bases of type EXTERNAL. Include a single variable in <c>${variable}</c> format; this
        /// interpolated by Amazon Q in Connect using ingested content. For example, if you ingest
        /// a Salesforce article, it has an <c>Id</c> value, and you can set the template URI
        /// to <c>https://myInstanceName.lightning.force.com/lightning/r/Knowledge__kav/*${Id}*/view</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBaseTemplateUri service method.</param>
        /// 
        /// <returns>The response from the UpdateKnowledgeBaseTemplateUri service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateKnowledgeBaseTemplateUri">REST API Reference for UpdateKnowledgeBaseTemplateUri Operation</seealso>
        UpdateKnowledgeBaseTemplateUriResponse UpdateKnowledgeBaseTemplateUri(UpdateKnowledgeBaseTemplateUriRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBaseTemplateUri operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKnowledgeBaseTemplateUri
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateKnowledgeBaseTemplateUri">REST API Reference for UpdateKnowledgeBaseTemplateUri Operation</seealso>
        IAsyncResult BeginUpdateKnowledgeBaseTemplateUri(UpdateKnowledgeBaseTemplateUriRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKnowledgeBaseTemplateUri.</param>
        /// 
        /// <returns>Returns a  UpdateKnowledgeBaseTemplateUriResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateKnowledgeBaseTemplateUri">REST API Reference for UpdateKnowledgeBaseTemplateUri Operation</seealso>
        UpdateKnowledgeBaseTemplateUriResponse EndUpdateKnowledgeBaseTemplateUri(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMessageTemplate


        /// <summary>
        /// Updates the Amazon Q in Connect message template. Partial update is supported. If
        /// any field is not supplied, it will remain unchanged for the message template that
        /// is referenced by the <c>$LATEST</c> qualifier. Any modification will only apply to
        /// the message template that is referenced by the <c>$LATEST</c> qualifier. The fields
        /// for all available versions will remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMessageTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplate">REST API Reference for UpdateMessageTemplate Operation</seealso>
        UpdateMessageTemplateResponse UpdateMessageTemplate(UpdateMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplate">REST API Reference for UpdateMessageTemplate Operation</seealso>
        IAsyncResult BeginUpdateMessageTemplate(UpdateMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMessageTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplate">REST API Reference for UpdateMessageTemplate Operation</seealso>
        UpdateMessageTemplateResponse EndUpdateMessageTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMessageTemplateMetadata


        /// <summary>
        /// Updates the Amazon Q in Connect message template metadata. Note that any modification
        /// to the message template’s name, description and grouping configuration will applied
        /// to the message template pointed by the <c>$LATEST</c> qualifier and all available
        /// versions. Partial update is supported. If any field is not supplied, it will remain
        /// unchanged for the message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMessageTemplateMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateMessageTemplateMetadata service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplateMetadata">REST API Reference for UpdateMessageTemplateMetadata Operation</seealso>
        UpdateMessageTemplateMetadataResponse UpdateMessageTemplateMetadata(UpdateMessageTemplateMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMessageTemplateMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMessageTemplateMetadata operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMessageTemplateMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplateMetadata">REST API Reference for UpdateMessageTemplateMetadata Operation</seealso>
        IAsyncResult BeginUpdateMessageTemplateMetadata(UpdateMessageTemplateMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMessageTemplateMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMessageTemplateMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateMessageTemplateMetadataResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplateMetadata">REST API Reference for UpdateMessageTemplateMetadata Operation</seealso>
        UpdateMessageTemplateMetadataResponse EndUpdateMessageTemplateMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQuickResponse


        /// <summary>
        /// Updates an existing Amazon Q in Connect quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateQuickResponse service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.PreconditionFailedException">
        /// The provided <c>revisionId</c> does not match, indicating the content has been modified
        /// since it was last read.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateQuickResponse">REST API Reference for UpdateQuickResponse Operation</seealso>
        UpdateQuickResponseResponse UpdateQuickResponse(UpdateQuickResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickResponse operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQuickResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateQuickResponse">REST API Reference for UpdateQuickResponse Operation</seealso>
        IAsyncResult BeginUpdateQuickResponse(UpdateQuickResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQuickResponse.</param>
        /// 
        /// <returns>Returns a  UpdateQuickResponseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateQuickResponse">REST API Reference for UpdateQuickResponse Operation</seealso>
        UpdateQuickResponseResponse EndUpdateQuickResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSession


        /// <summary>
        /// Updates a session. A session is a contextual container used for generating recommendations.
        /// Amazon Connect updates the existing Amazon Q in Connect session for each contact on
        /// which Amazon Q in Connect is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession service method.</param>
        /// 
        /// <returns>The response from the UpdateSession service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        UpdateSessionResponse UpdateSession(UpdateSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        IAsyncResult BeginUpdateSession(UpdateSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSession.</param>
        /// 
        /// <returns>Returns a  UpdateSessionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        UpdateSessionResponse EndUpdateSession(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSessionData


        /// <summary>
        /// Updates the data stored on an Amazon Q in Connect Session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSessionData service method.</param>
        /// 
        /// <returns>The response from the UpdateSessionData service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSessionData">REST API Reference for UpdateSessionData Operation</seealso>
        UpdateSessionDataResponse UpdateSessionData(UpdateSessionDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSessionData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSessionData operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSessionData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSessionData">REST API Reference for UpdateSessionData Operation</seealso>
        IAsyncResult BeginUpdateSessionData(UpdateSessionDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSessionData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSessionData.</param>
        /// 
        /// <returns>Returns a  UpdateSessionDataResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSessionData">REST API Reference for UpdateSessionData Operation</seealso>
        UpdateSessionDataResponse EndUpdateSessionData(IAsyncResult asyncResult);

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