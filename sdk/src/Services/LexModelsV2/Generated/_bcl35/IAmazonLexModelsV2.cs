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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LexModelsV2.Model;

namespace Amazon.LexModelsV2
{
    /// <summary>
    /// Interface for accessing LexModelsV2
    ///
    /// 
    /// </summary>
    public partial interface IAmazonLexModelsV2 : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILexModelsV2PaginatorFactory Paginators { get; }
#endif


        
        #region  BatchCreateCustomVocabularyItem


        /// <summary>
        /// Create a batch of custom vocabulary items for a given bot locale's custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCustomVocabularyItem service method.</param>
        /// 
        /// <returns>The response from the BatchCreateCustomVocabularyItem service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BatchCreateCustomVocabularyItem">REST API Reference for BatchCreateCustomVocabularyItem Operation</seealso>
        BatchCreateCustomVocabularyItemResponse BatchCreateCustomVocabularyItem(BatchCreateCustomVocabularyItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateCustomVocabularyItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCustomVocabularyItem operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateCustomVocabularyItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BatchCreateCustomVocabularyItem">REST API Reference for BatchCreateCustomVocabularyItem Operation</seealso>
        IAsyncResult BeginBatchCreateCustomVocabularyItem(BatchCreateCustomVocabularyItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateCustomVocabularyItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateCustomVocabularyItem.</param>
        /// 
        /// <returns>Returns a  BatchCreateCustomVocabularyItemResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BatchCreateCustomVocabularyItem">REST API Reference for BatchCreateCustomVocabularyItem Operation</seealso>
        BatchCreateCustomVocabularyItemResponse EndBatchCreateCustomVocabularyItem(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteCustomVocabularyItem


        /// <summary>
        /// Delete a batch of custom vocabulary items for a given bot locale's custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCustomVocabularyItem service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteCustomVocabularyItem service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BatchDeleteCustomVocabularyItem">REST API Reference for BatchDeleteCustomVocabularyItem Operation</seealso>
        BatchDeleteCustomVocabularyItemResponse BatchDeleteCustomVocabularyItem(BatchDeleteCustomVocabularyItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteCustomVocabularyItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCustomVocabularyItem operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteCustomVocabularyItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BatchDeleteCustomVocabularyItem">REST API Reference for BatchDeleteCustomVocabularyItem Operation</seealso>
        IAsyncResult BeginBatchDeleteCustomVocabularyItem(BatchDeleteCustomVocabularyItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteCustomVocabularyItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteCustomVocabularyItem.</param>
        /// 
        /// <returns>Returns a  BatchDeleteCustomVocabularyItemResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BatchDeleteCustomVocabularyItem">REST API Reference for BatchDeleteCustomVocabularyItem Operation</seealso>
        BatchDeleteCustomVocabularyItemResponse EndBatchDeleteCustomVocabularyItem(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateCustomVocabularyItem


        /// <summary>
        /// Update a batch of custom vocabulary items for a given bot locale's custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCustomVocabularyItem service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateCustomVocabularyItem service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BatchUpdateCustomVocabularyItem">REST API Reference for BatchUpdateCustomVocabularyItem Operation</seealso>
        BatchUpdateCustomVocabularyItemResponse BatchUpdateCustomVocabularyItem(BatchUpdateCustomVocabularyItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateCustomVocabularyItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCustomVocabularyItem operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateCustomVocabularyItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BatchUpdateCustomVocabularyItem">REST API Reference for BatchUpdateCustomVocabularyItem Operation</seealso>
        IAsyncResult BeginBatchUpdateCustomVocabularyItem(BatchUpdateCustomVocabularyItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateCustomVocabularyItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateCustomVocabularyItem.</param>
        /// 
        /// <returns>Returns a  BatchUpdateCustomVocabularyItemResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BatchUpdateCustomVocabularyItem">REST API Reference for BatchUpdateCustomVocabularyItem Operation</seealso>
        BatchUpdateCustomVocabularyItemResponse EndBatchUpdateCustomVocabularyItem(IAsyncResult asyncResult);

        #endregion
        
        #region  BuildBotLocale


        /// <summary>
        /// Builds a bot, its intents, and its slot types into a specific locale. A bot can be
        /// built into multiple locales. At runtime the locale is used to choose a specific build
        /// of the bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BuildBotLocale service method.</param>
        /// 
        /// <returns>The response from the BuildBotLocale service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BuildBotLocale">REST API Reference for BuildBotLocale Operation</seealso>
        BuildBotLocaleResponse BuildBotLocale(BuildBotLocaleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BuildBotLocale operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BuildBotLocale operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBuildBotLocale
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BuildBotLocale">REST API Reference for BuildBotLocale Operation</seealso>
        IAsyncResult BeginBuildBotLocale(BuildBotLocaleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BuildBotLocale operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBuildBotLocale.</param>
        /// 
        /// <returns>Returns a  BuildBotLocaleResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BuildBotLocale">REST API Reference for BuildBotLocale Operation</seealso>
        BuildBotLocaleResponse EndBuildBotLocale(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBot


        /// <summary>
        /// Creates an Amazon Lex conversational bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBot service method.</param>
        /// 
        /// <returns>The response from the CreateBot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBot">REST API Reference for CreateBot Operation</seealso>
        CreateBotResponse CreateBot(CreateBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBot operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBot">REST API Reference for CreateBot Operation</seealso>
        IAsyncResult BeginCreateBot(CreateBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBot.</param>
        /// 
        /// <returns>Returns a  CreateBotResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBot">REST API Reference for CreateBot Operation</seealso>
        CreateBotResponse EndCreateBot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBotAlias


        /// <summary>
        /// Creates an alias for the specified version of a bot. Use an alias to enable you to
        /// change the version of a bot without updating applications that use the bot.
        /// 
        ///  
        /// <para>
        /// For example, you can create an alias called "PROD" that your applications use to call
        /// the Amazon Lex bot. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBotAlias service method.</param>
        /// 
        /// <returns>The response from the CreateBotAlias service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotAlias">REST API Reference for CreateBotAlias Operation</seealso>
        CreateBotAliasResponse CreateBotAlias(CreateBotAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBotAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBotAlias operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBotAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotAlias">REST API Reference for CreateBotAlias Operation</seealso>
        IAsyncResult BeginCreateBotAlias(CreateBotAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBotAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBotAlias.</param>
        /// 
        /// <returns>Returns a  CreateBotAliasResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotAlias">REST API Reference for CreateBotAlias Operation</seealso>
        CreateBotAliasResponse EndCreateBotAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBotLocale


        /// <summary>
        /// Creates a locale in the bot. The locale contains the intents and slot types that the
        /// bot uses in conversations with users in the specified language and locale. You must
        /// add a locale to a bot before you can add intents and slot types to the bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBotLocale service method.</param>
        /// 
        /// <returns>The response from the CreateBotLocale service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotLocale">REST API Reference for CreateBotLocale Operation</seealso>
        CreateBotLocaleResponse CreateBotLocale(CreateBotLocaleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBotLocale operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBotLocale operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBotLocale
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotLocale">REST API Reference for CreateBotLocale Operation</seealso>
        IAsyncResult BeginCreateBotLocale(CreateBotLocaleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBotLocale operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBotLocale.</param>
        /// 
        /// <returns>Returns a  CreateBotLocaleResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotLocale">REST API Reference for CreateBotLocale Operation</seealso>
        CreateBotLocaleResponse EndCreateBotLocale(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBotVersion


        /// <summary>
        /// Creates a new version of the bot based on the <code>DRAFT</code> version. If the <code>DRAFT</code>
        /// version of this resource hasn't changed since you created the last version, Amazon
        /// Lex doesn't create a new version, it returns the last created version.
        /// 
        ///  
        /// <para>
        /// When you create the first version of a bot, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBotVersion service method.</param>
        /// 
        /// <returns>The response from the CreateBotVersion service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotVersion">REST API Reference for CreateBotVersion Operation</seealso>
        CreateBotVersionResponse CreateBotVersion(CreateBotVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBotVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBotVersion operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBotVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotVersion">REST API Reference for CreateBotVersion Operation</seealso>
        IAsyncResult BeginCreateBotVersion(CreateBotVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBotVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBotVersion.</param>
        /// 
        /// <returns>Returns a  CreateBotVersionResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotVersion">REST API Reference for CreateBotVersion Operation</seealso>
        CreateBotVersionResponse EndCreateBotVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateExport


        /// <summary>
        /// Creates a zip archive containing the contents of a bot or a bot locale. The archive
        /// contains a directory structure that contains JSON files that define the bot.
        /// 
        ///  
        /// <para>
        /// You can create an archive that contains the complete definition of a bot, or you can
        /// specify that the archive contain only the definition of a single bot locale.
        /// </para>
        ///  
        /// <para>
        /// For more information about exporting bots, and about the structure of the export archive,
        /// see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/importing-exporting.html">
        /// Importing and exporting bots </a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExport service method.</param>
        /// 
        /// <returns>The response from the CreateExport service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateExport">REST API Reference for CreateExport Operation</seealso>
        CreateExportResponse CreateExport(CreateExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExport operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateExport">REST API Reference for CreateExport Operation</seealso>
        IAsyncResult BeginCreateExport(CreateExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExport.</param>
        /// 
        /// <returns>Returns a  CreateExportResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateExport">REST API Reference for CreateExport Operation</seealso>
        CreateExportResponse EndCreateExport(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIntent


        /// <summary>
        /// Creates an intent.
        /// 
        ///  
        /// <para>
        /// To define the interaction between the user and your bot, you define one or more intents.
        /// For example, for a pizza ordering bot you would create an <code>OrderPizza</code>
        /// intent.
        /// </para>
        ///  
        /// <para>
        /// When you create an intent, you must provide a name. You can optionally provide the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sample utterances. For example, "I want to order a pizza" and "Can I order a pizza."
        /// You can't provide utterances for built-in intents.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Information to be gathered. You specify slots for the information that you bot requests
        /// from the user. You can specify standard slot types, such as date and time, or custom
        /// slot types for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// How the intent is fulfilled. You can provide a Lambda function or configure the intent
        /// to return the intent information to your client application. If you use a Lambda function,
        /// Amazon Lex invokes the function when all of the intent information is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A confirmation prompt to send to the user to confirm an intent. For example, "Shall
        /// I order your pizza?"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A conclusion statement to send to the user after the intent is fulfilled. For example,
        /// "I ordered your pizza."
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A follow-up prompt that asks the user for additional activity. For example, "Do you
        /// want a drink with your pizza?"
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntent service method.</param>
        /// 
        /// <returns>The response from the CreateIntent service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateIntent">REST API Reference for CreateIntent Operation</seealso>
        CreateIntentResponse CreateIntent(CreateIntentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntent operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIntent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateIntent">REST API Reference for CreateIntent Operation</seealso>
        IAsyncResult BeginCreateIntent(CreateIntentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIntent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIntent.</param>
        /// 
        /// <returns>Returns a  CreateIntentResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateIntent">REST API Reference for CreateIntent Operation</seealso>
        CreateIntentResponse EndCreateIntent(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResourcePolicy


        /// <summary>
        /// Creates a new resource policy with the specified policy statements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the CreateResourcePolicy service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateResourcePolicy">REST API Reference for CreateResourcePolicy Operation</seealso>
        CreateResourcePolicyResponse CreateResourcePolicy(CreateResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourcePolicy operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateResourcePolicy">REST API Reference for CreateResourcePolicy Operation</seealso>
        IAsyncResult BeginCreateResourcePolicy(CreateResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourcePolicy.</param>
        /// 
        /// <returns>Returns a  CreateResourcePolicyResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateResourcePolicy">REST API Reference for CreateResourcePolicy Operation</seealso>
        CreateResourcePolicyResponse EndCreateResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResourcePolicyStatement


        /// <summary>
        /// Adds a new resource policy statement to a bot or bot alias. If a resource policy exists,
        /// the statement is added to the current resource policy. If a policy doesn't exist,
        /// a new policy is created.
        /// 
        ///  
        /// <para>
        /// You can't create a resource policy statement that allows cross-account access.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourcePolicyStatement service method.</param>
        /// 
        /// <returns>The response from the CreateResourcePolicyStatement service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateResourcePolicyStatement">REST API Reference for CreateResourcePolicyStatement Operation</seealso>
        CreateResourcePolicyStatementResponse CreateResourcePolicyStatement(CreateResourcePolicyStatementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourcePolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourcePolicyStatement operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourcePolicyStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateResourcePolicyStatement">REST API Reference for CreateResourcePolicyStatement Operation</seealso>
        IAsyncResult BeginCreateResourcePolicyStatement(CreateResourcePolicyStatementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourcePolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourcePolicyStatement.</param>
        /// 
        /// <returns>Returns a  CreateResourcePolicyStatementResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateResourcePolicyStatement">REST API Reference for CreateResourcePolicyStatement Operation</seealso>
        CreateResourcePolicyStatementResponse EndCreateResourcePolicyStatement(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSlot


        /// <summary>
        /// Creates a slot in an intent. A slot is a variable needed to fulfill an intent. For
        /// example, an <code>OrderPizza</code> intent might need slots for size, crust, and number
        /// of pizzas. For each slot, you define one or more utterances that Amazon Lex uses to
        /// elicit a response from the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlot service method.</param>
        /// 
        /// <returns>The response from the CreateSlot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateSlot">REST API Reference for CreateSlot Operation</seealso>
        CreateSlotResponse CreateSlot(CreateSlotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSlot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSlot operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSlot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateSlot">REST API Reference for CreateSlot Operation</seealso>
        IAsyncResult BeginCreateSlot(CreateSlotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSlot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSlot.</param>
        /// 
        /// <returns>Returns a  CreateSlotResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateSlot">REST API Reference for CreateSlot Operation</seealso>
        CreateSlotResponse EndCreateSlot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSlotType


        /// <summary>
        /// Creates a custom slot type
        /// 
        ///  
        /// <para>
        ///  To create a custom slot type, specify a name for the slot type and a set of enumeration
        /// values, the values that a slot of this type can assume. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlotType service method.</param>
        /// 
        /// <returns>The response from the CreateSlotType service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateSlotType">REST API Reference for CreateSlotType Operation</seealso>
        CreateSlotTypeResponse CreateSlotType(CreateSlotTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSlotType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSlotType operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSlotType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateSlotType">REST API Reference for CreateSlotType Operation</seealso>
        IAsyncResult BeginCreateSlotType(CreateSlotTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSlotType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSlotType.</param>
        /// 
        /// <returns>Returns a  CreateSlotTypeResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateSlotType">REST API Reference for CreateSlotType Operation</seealso>
        CreateSlotTypeResponse EndCreateSlotType(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUploadUrl


        /// <summary>
        /// Gets a pre-signed S3 write URL that you use to upload the zip archive when importing
        /// a bot or a bot locale.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadUrl service method.</param>
        /// 
        /// <returns>The response from the CreateUploadUrl service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateUploadUrl">REST API Reference for CreateUploadUrl Operation</seealso>
        CreateUploadUrlResponse CreateUploadUrl(CreateUploadUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUploadUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadUrl operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUploadUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateUploadUrl">REST API Reference for CreateUploadUrl Operation</seealso>
        IAsyncResult BeginCreateUploadUrl(CreateUploadUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUploadUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUploadUrl.</param>
        /// 
        /// <returns>Returns a  CreateUploadUrlResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateUploadUrl">REST API Reference for CreateUploadUrl Operation</seealso>
        CreateUploadUrlResponse EndCreateUploadUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBot


        /// <summary>
        /// Deletes all versions of a bot, including the <code>Draft</code> version. To delete
        /// a specific version, use the <code>DeleteBotVersion</code> operation.
        /// 
        ///  
        /// <para>
        /// When you delete a bot, all of the resources contained in the bot are also deleted.
        /// Deleting a bot removes all locales, intents, slot, and slot types defined for the
        /// bot.
        /// </para>
        ///  
        /// <para>
        /// If a bot has an alias, the <code>DeleteBot</code> operation returns a <code>ResourceInUseException</code>
        /// exception. If you want to delete the bot and the alias, set the <code>skipResourceInUseCheck</code>
        /// parameter to <code>true</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot service method.</param>
        /// 
        /// <returns>The response from the DeleteBot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        DeleteBotResponse DeleteBot(DeleteBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        IAsyncResult BeginDeleteBot(DeleteBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBot.</param>
        /// 
        /// <returns>Returns a  DeleteBotResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        DeleteBotResponse EndDeleteBot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBotAlias


        /// <summary>
        /// Deletes the specified bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteBotAlias service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotAlias">REST API Reference for DeleteBotAlias Operation</seealso>
        DeleteBotAliasResponse DeleteBotAlias(DeleteBotAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBotAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotAlias operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBotAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotAlias">REST API Reference for DeleteBotAlias Operation</seealso>
        IAsyncResult BeginDeleteBotAlias(DeleteBotAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBotAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBotAlias.</param>
        /// 
        /// <returns>Returns a  DeleteBotAliasResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotAlias">REST API Reference for DeleteBotAlias Operation</seealso>
        DeleteBotAliasResponse EndDeleteBotAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBotLocale


        /// <summary>
        /// Removes a locale from a bot.
        /// 
        ///  
        /// <para>
        /// When you delete a locale, all intents, slots, and slot types defined for the locale
        /// are also deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotLocale service method.</param>
        /// 
        /// <returns>The response from the DeleteBotLocale service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotLocale">REST API Reference for DeleteBotLocale Operation</seealso>
        DeleteBotLocaleResponse DeleteBotLocale(DeleteBotLocaleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBotLocale operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotLocale operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBotLocale
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotLocale">REST API Reference for DeleteBotLocale Operation</seealso>
        IAsyncResult BeginDeleteBotLocale(DeleteBotLocaleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBotLocale operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBotLocale.</param>
        /// 
        /// <returns>Returns a  DeleteBotLocaleResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotLocale">REST API Reference for DeleteBotLocale Operation</seealso>
        DeleteBotLocaleResponse EndDeleteBotLocale(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBotVersion


        /// <summary>
        /// Deletes a specific version of a bot. To delete all versions of a bot, use the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DeleteBot.html">DeleteBot</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteBotVersion service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotVersion">REST API Reference for DeleteBotVersion Operation</seealso>
        DeleteBotVersionResponse DeleteBotVersion(DeleteBotVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBotVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotVersion operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBotVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotVersion">REST API Reference for DeleteBotVersion Operation</seealso>
        IAsyncResult BeginDeleteBotVersion(DeleteBotVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBotVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBotVersion.</param>
        /// 
        /// <returns>Returns a  DeleteBotVersionResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotVersion">REST API Reference for DeleteBotVersion Operation</seealso>
        DeleteBotVersionResponse EndDeleteBotVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCustomVocabulary


        /// <summary>
        /// Removes a custom vocabulary from the specified locale in the specified bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomVocabulary service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteCustomVocabulary">REST API Reference for DeleteCustomVocabulary Operation</seealso>
        DeleteCustomVocabularyResponse DeleteCustomVocabulary(DeleteCustomVocabularyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVocabulary operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteCustomVocabulary">REST API Reference for DeleteCustomVocabulary Operation</seealso>
        IAsyncResult BeginDeleteCustomVocabulary(DeleteCustomVocabularyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomVocabulary.</param>
        /// 
        /// <returns>Returns a  DeleteCustomVocabularyResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteCustomVocabulary">REST API Reference for DeleteCustomVocabulary Operation</seealso>
        DeleteCustomVocabularyResponse EndDeleteCustomVocabulary(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteExport


        /// <summary>
        /// Removes a previous export and the associated files stored in an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExport service method.</param>
        /// 
        /// <returns>The response from the DeleteExport service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteExport">REST API Reference for DeleteExport Operation</seealso>
        DeleteExportResponse DeleteExport(DeleteExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExport operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteExport">REST API Reference for DeleteExport Operation</seealso>
        IAsyncResult BeginDeleteExport(DeleteExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExport.</param>
        /// 
        /// <returns>Returns a  DeleteExportResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteExport">REST API Reference for DeleteExport Operation</seealso>
        DeleteExportResponse EndDeleteExport(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteImport


        /// <summary>
        /// Removes a previous import and the associated file stored in an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImport service method.</param>
        /// 
        /// <returns>The response from the DeleteImport service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteImport">REST API Reference for DeleteImport Operation</seealso>
        DeleteImportResponse DeleteImport(DeleteImportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImport operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteImport">REST API Reference for DeleteImport Operation</seealso>
        IAsyncResult BeginDeleteImport(DeleteImportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImport.</param>
        /// 
        /// <returns>Returns a  DeleteImportResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteImport">REST API Reference for DeleteImport Operation</seealso>
        DeleteImportResponse EndDeleteImport(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIntent


        /// <summary>
        /// Removes the specified intent.
        /// 
        ///  
        /// <para>
        /// Deleting an intent also deletes the slots associated with the intent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntent service method.</param>
        /// 
        /// <returns>The response from the DeleteIntent service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteIntent">REST API Reference for DeleteIntent Operation</seealso>
        DeleteIntentResponse DeleteIntent(DeleteIntentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntent operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteIntent">REST API Reference for DeleteIntent Operation</seealso>
        IAsyncResult BeginDeleteIntent(DeleteIntentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntent.</param>
        /// 
        /// <returns>Returns a  DeleteIntentResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteIntent">REST API Reference for DeleteIntent Operation</seealso>
        DeleteIntentResponse EndDeleteIntent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Removes an existing policy from a bot or bot alias. If the resource doesn't have a
        /// policy attached, Amazon Lex returns an exception.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicyStatement


        /// <summary>
        /// Deletes a policy statement from a resource policy. If you delete the last statement
        /// from a policy, the policy is deleted. If you specify a statement ID that doesn't exist
        /// in the policy, or if the bot or bot alias doesn't have a policy attached, Amazon Lex
        /// returns an exception.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicyStatement service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicyStatement service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteResourcePolicyStatement">REST API Reference for DeleteResourcePolicyStatement Operation</seealso>
        DeleteResourcePolicyStatementResponse DeleteResourcePolicyStatement(DeleteResourcePolicyStatementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicyStatement operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicyStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteResourcePolicyStatement">REST API Reference for DeleteResourcePolicyStatement Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicyStatement(DeleteResourcePolicyStatementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicyStatement.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyStatementResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteResourcePolicyStatement">REST API Reference for DeleteResourcePolicyStatement Operation</seealso>
        DeleteResourcePolicyStatementResponse EndDeleteResourcePolicyStatement(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSlot


        /// <summary>
        /// Deletes the specified slot from an intent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlot service method.</param>
        /// 
        /// <returns>The response from the DeleteSlot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteSlot">REST API Reference for DeleteSlot Operation</seealso>
        DeleteSlotResponse DeleteSlot(DeleteSlotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSlot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlot operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSlot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteSlot">REST API Reference for DeleteSlot Operation</seealso>
        IAsyncResult BeginDeleteSlot(DeleteSlotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSlot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSlot.</param>
        /// 
        /// <returns>Returns a  DeleteSlotResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteSlot">REST API Reference for DeleteSlot Operation</seealso>
        DeleteSlotResponse EndDeleteSlot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSlotType


        /// <summary>
        /// Deletes a slot type from a bot locale.
        /// 
        ///  
        /// <para>
        /// If a slot is using the slot type, Amazon Lex throws a <code>ResourceInUseException</code>
        /// exception. To avoid the exception, set the <code>skipResourceInUseCheck</code> parameter
        /// to <code>true</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotType service method.</param>
        /// 
        /// <returns>The response from the DeleteSlotType service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteSlotType">REST API Reference for DeleteSlotType Operation</seealso>
        DeleteSlotTypeResponse DeleteSlotType(DeleteSlotTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSlotType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotType operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSlotType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteSlotType">REST API Reference for DeleteSlotType Operation</seealso>
        IAsyncResult BeginDeleteSlotType(DeleteSlotTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSlotType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSlotType.</param>
        /// 
        /// <returns>Returns a  DeleteSlotTypeResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteSlotType">REST API Reference for DeleteSlotType Operation</seealso>
        DeleteSlotTypeResponse EndDeleteSlotType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUtterances


        /// <summary>
        /// Deletes stored utterances.
        /// 
        ///  
        /// <para>
        /// Amazon Lex stores the utterances that users send to your bot. Utterances are stored
        /// for 15 days for use with the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListAggregatedUtterances.html">ListAggregatedUtterances</a>
        /// operation, and then stored indefinitely for use in improving the ability of your bot
        /// to respond to user input..
        /// </para>
        ///  
        /// <para>
        /// Use the <code>DeleteUtterances</code> operation to manually delete utterances for
        /// a specific session. When you use the <code>DeleteUtterances</code> operation, utterances
        /// stored for improving your bot's ability to respond to user input are deleted immediately.
        /// Utterances stored for use with the <code>ListAggregatedUtterances</code> operation
        /// are deleted after 15 days.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUtterances service method.</param>
        /// 
        /// <returns>The response from the DeleteUtterances service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteUtterances">REST API Reference for DeleteUtterances Operation</seealso>
        DeleteUtterancesResponse DeleteUtterances(DeleteUtterancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUtterances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUtterances operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUtterances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteUtterances">REST API Reference for DeleteUtterances Operation</seealso>
        IAsyncResult BeginDeleteUtterances(DeleteUtterancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUtterances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUtterances.</param>
        /// 
        /// <returns>Returns a  DeleteUtterancesResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteUtterances">REST API Reference for DeleteUtterances Operation</seealso>
        DeleteUtterancesResponse EndDeleteUtterances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBot


        /// <summary>
        /// Provides metadata information about a bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBot service method.</param>
        /// 
        /// <returns>The response from the DescribeBot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBot">REST API Reference for DescribeBot Operation</seealso>
        DescribeBotResponse DescribeBot(DescribeBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBot operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBot">REST API Reference for DescribeBot Operation</seealso>
        IAsyncResult BeginDescribeBot(DescribeBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBot.</param>
        /// 
        /// <returns>Returns a  DescribeBotResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBot">REST API Reference for DescribeBot Operation</seealso>
        DescribeBotResponse EndDescribeBot(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBotAlias


        /// <summary>
        /// Get information about a specific bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeBotAlias service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotAlias">REST API Reference for DescribeBotAlias Operation</seealso>
        DescribeBotAliasResponse DescribeBotAlias(DescribeBotAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBotAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotAlias operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBotAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotAlias">REST API Reference for DescribeBotAlias Operation</seealso>
        IAsyncResult BeginDescribeBotAlias(DescribeBotAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBotAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBotAlias.</param>
        /// 
        /// <returns>Returns a  DescribeBotAliasResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotAlias">REST API Reference for DescribeBotAlias Operation</seealso>
        DescribeBotAliasResponse EndDescribeBotAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBotLocale


        /// <summary>
        /// Describes the settings that a bot has for a specific locale.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotLocale service method.</param>
        /// 
        /// <returns>The response from the DescribeBotLocale service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotLocale">REST API Reference for DescribeBotLocale Operation</seealso>
        DescribeBotLocaleResponse DescribeBotLocale(DescribeBotLocaleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBotLocale operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotLocale operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBotLocale
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotLocale">REST API Reference for DescribeBotLocale Operation</seealso>
        IAsyncResult BeginDescribeBotLocale(DescribeBotLocaleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBotLocale operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBotLocale.</param>
        /// 
        /// <returns>Returns a  DescribeBotLocaleResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotLocale">REST API Reference for DescribeBotLocale Operation</seealso>
        DescribeBotLocaleResponse EndDescribeBotLocale(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBotRecommendation


        /// <summary>
        /// Provides metadata information about a bot recommendation. This information will enable
        /// you to get a description on the request inputs, to download associated transcripts
        /// after processing is complete, and to download intents and slot-types generated by
        /// the bot recommendation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotRecommendation service method.</param>
        /// 
        /// <returns>The response from the DescribeBotRecommendation service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotRecommendation">REST API Reference for DescribeBotRecommendation Operation</seealso>
        DescribeBotRecommendationResponse DescribeBotRecommendation(DescribeBotRecommendationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBotRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotRecommendation operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBotRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotRecommendation">REST API Reference for DescribeBotRecommendation Operation</seealso>
        IAsyncResult BeginDescribeBotRecommendation(DescribeBotRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBotRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBotRecommendation.</param>
        /// 
        /// <returns>Returns a  DescribeBotRecommendationResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotRecommendation">REST API Reference for DescribeBotRecommendation Operation</seealso>
        DescribeBotRecommendationResponse EndDescribeBotRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBotVersion


        /// <summary>
        /// Provides metadata about a version of a bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotVersion service method.</param>
        /// 
        /// <returns>The response from the DescribeBotVersion service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotVersion">REST API Reference for DescribeBotVersion Operation</seealso>
        DescribeBotVersionResponse DescribeBotVersion(DescribeBotVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBotVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotVersion operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBotVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotVersion">REST API Reference for DescribeBotVersion Operation</seealso>
        IAsyncResult BeginDescribeBotVersion(DescribeBotVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBotVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBotVersion.</param>
        /// 
        /// <returns>Returns a  DescribeBotVersionResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotVersion">REST API Reference for DescribeBotVersion Operation</seealso>
        DescribeBotVersionResponse EndDescribeBotVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCustomVocabularyMetadata


        /// <summary>
        /// Provides metadata information about a custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomVocabularyMetadata service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomVocabularyMetadata service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeCustomVocabularyMetadata">REST API Reference for DescribeCustomVocabularyMetadata Operation</seealso>
        DescribeCustomVocabularyMetadataResponse DescribeCustomVocabularyMetadata(DescribeCustomVocabularyMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomVocabularyMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomVocabularyMetadata operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomVocabularyMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeCustomVocabularyMetadata">REST API Reference for DescribeCustomVocabularyMetadata Operation</seealso>
        IAsyncResult BeginDescribeCustomVocabularyMetadata(DescribeCustomVocabularyMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomVocabularyMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomVocabularyMetadata.</param>
        /// 
        /// <returns>Returns a  DescribeCustomVocabularyMetadataResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeCustomVocabularyMetadata">REST API Reference for DescribeCustomVocabularyMetadata Operation</seealso>
        DescribeCustomVocabularyMetadataResponse EndDescribeCustomVocabularyMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExport


        /// <summary>
        /// Gets information about a specific export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExport service method.</param>
        /// 
        /// <returns>The response from the DescribeExport service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeExport">REST API Reference for DescribeExport Operation</seealso>
        DescribeExportResponse DescribeExport(DescribeExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExport operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeExport">REST API Reference for DescribeExport Operation</seealso>
        IAsyncResult BeginDescribeExport(DescribeExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExport.</param>
        /// 
        /// <returns>Returns a  DescribeExportResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeExport">REST API Reference for DescribeExport Operation</seealso>
        DescribeExportResponse EndDescribeExport(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImport


        /// <summary>
        /// Gets information about a specific import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImport service method.</param>
        /// 
        /// <returns>The response from the DescribeImport service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeImport">REST API Reference for DescribeImport Operation</seealso>
        DescribeImportResponse DescribeImport(DescribeImportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImport operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeImport">REST API Reference for DescribeImport Operation</seealso>
        IAsyncResult BeginDescribeImport(DescribeImportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImport.</param>
        /// 
        /// <returns>Returns a  DescribeImportResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeImport">REST API Reference for DescribeImport Operation</seealso>
        DescribeImportResponse EndDescribeImport(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIntent


        /// <summary>
        /// Returns metadata about an intent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIntent service method.</param>
        /// 
        /// <returns>The response from the DescribeIntent service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeIntent">REST API Reference for DescribeIntent Operation</seealso>
        DescribeIntentResponse DescribeIntent(DescribeIntentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIntent operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIntent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeIntent">REST API Reference for DescribeIntent Operation</seealso>
        IAsyncResult BeginDescribeIntent(DescribeIntentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIntent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIntent.</param>
        /// 
        /// <returns>Returns a  DescribeIntentResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeIntent">REST API Reference for DescribeIntent Operation</seealso>
        DescribeIntentResponse EndDescribeIntent(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeResourcePolicy


        /// <summary>
        /// Gets the resource policy and policy revision for a bot or bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeResourcePolicy service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        IAsyncResult BeginDescribeResourcePolicy(DescribeResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DescribeResourcePolicyResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        DescribeResourcePolicyResponse EndDescribeResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSlot


        /// <summary>
        /// Gets metadata information about a slot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlot service method.</param>
        /// 
        /// <returns>The response from the DescribeSlot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeSlot">REST API Reference for DescribeSlot Operation</seealso>
        DescribeSlotResponse DescribeSlot(DescribeSlotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSlot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlot operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSlot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeSlot">REST API Reference for DescribeSlot Operation</seealso>
        IAsyncResult BeginDescribeSlot(DescribeSlotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSlot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSlot.</param>
        /// 
        /// <returns>Returns a  DescribeSlotResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeSlot">REST API Reference for DescribeSlot Operation</seealso>
        DescribeSlotResponse EndDescribeSlot(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSlotType


        /// <summary>
        /// Gets metadata information about a slot type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlotType service method.</param>
        /// 
        /// <returns>The response from the DescribeSlotType service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeSlotType">REST API Reference for DescribeSlotType Operation</seealso>
        DescribeSlotTypeResponse DescribeSlotType(DescribeSlotTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSlotType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlotType operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSlotType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeSlotType">REST API Reference for DescribeSlotType Operation</seealso>
        IAsyncResult BeginDescribeSlotType(DescribeSlotTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSlotType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSlotType.</param>
        /// 
        /// <returns>Returns a  DescribeSlotTypeResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeSlotType">REST API Reference for DescribeSlotType Operation</seealso>
        DescribeSlotTypeResponse EndDescribeSlotType(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAggregatedUtterances


        /// <summary>
        /// Provides a list of utterances that users have sent to the bot.
        /// 
        ///  
        /// <para>
        /// Utterances are aggregated by the text of the utterance. For example, all instances
        /// where customers used the phrase "I want to order pizza" are aggregated into the same
        /// line in the response.
        /// </para>
        ///  
        /// <para>
        /// You can see both detected utterances and missed utterances. A detected utterance is
        /// where the bot properly recognized the utterance and activated the associated intent.
        /// A missed utterance was not recognized by the bot and didn't activate an intent.
        /// </para>
        ///  
        /// <para>
        /// Utterances can be aggregated for a bot alias or for a bot version, but not both at
        /// the same time.
        /// </para>
        ///  
        /// <para>
        /// Utterances statistics are not generated under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>childDirected</code> field was set to true when the bot was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are using slot obfuscation with one or more slots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You opted out of participating in improving Amazon Lex.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAggregatedUtterances service method.</param>
        /// 
        /// <returns>The response from the ListAggregatedUtterances service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListAggregatedUtterances">REST API Reference for ListAggregatedUtterances Operation</seealso>
        ListAggregatedUtterancesResponse ListAggregatedUtterances(ListAggregatedUtterancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAggregatedUtterances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAggregatedUtterances operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAggregatedUtterances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListAggregatedUtterances">REST API Reference for ListAggregatedUtterances Operation</seealso>
        IAsyncResult BeginListAggregatedUtterances(ListAggregatedUtterancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAggregatedUtterances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAggregatedUtterances.</param>
        /// 
        /// <returns>Returns a  ListAggregatedUtterancesResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListAggregatedUtterances">REST API Reference for ListAggregatedUtterances Operation</seealso>
        ListAggregatedUtterancesResponse EndListAggregatedUtterances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBotAliases


        /// <summary>
        /// Gets a list of aliases for the specified bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBotAliases service method.</param>
        /// 
        /// <returns>The response from the ListBotAliases service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotAliases">REST API Reference for ListBotAliases Operation</seealso>
        ListBotAliasesResponse ListBotAliases(ListBotAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBotAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBotAliases operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBotAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotAliases">REST API Reference for ListBotAliases Operation</seealso>
        IAsyncResult BeginListBotAliases(ListBotAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBotAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBotAliases.</param>
        /// 
        /// <returns>Returns a  ListBotAliasesResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotAliases">REST API Reference for ListBotAliases Operation</seealso>
        ListBotAliasesResponse EndListBotAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBotLocales


        /// <summary>
        /// Gets a list of locales for the specified bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBotLocales service method.</param>
        /// 
        /// <returns>The response from the ListBotLocales service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotLocales">REST API Reference for ListBotLocales Operation</seealso>
        ListBotLocalesResponse ListBotLocales(ListBotLocalesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBotLocales operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBotLocales operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBotLocales
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotLocales">REST API Reference for ListBotLocales Operation</seealso>
        IAsyncResult BeginListBotLocales(ListBotLocalesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBotLocales operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBotLocales.</param>
        /// 
        /// <returns>Returns a  ListBotLocalesResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotLocales">REST API Reference for ListBotLocales Operation</seealso>
        ListBotLocalesResponse EndListBotLocales(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBotRecommendations


        /// <summary>
        /// Get a list of bot recommendations that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBotRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListBotRecommendations service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotRecommendations">REST API Reference for ListBotRecommendations Operation</seealso>
        ListBotRecommendationsResponse ListBotRecommendations(ListBotRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBotRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBotRecommendations operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBotRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotRecommendations">REST API Reference for ListBotRecommendations Operation</seealso>
        IAsyncResult BeginListBotRecommendations(ListBotRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBotRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBotRecommendations.</param>
        /// 
        /// <returns>Returns a  ListBotRecommendationsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotRecommendations">REST API Reference for ListBotRecommendations Operation</seealso>
        ListBotRecommendationsResponse EndListBotRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBots


        /// <summary>
        /// Gets a list of available bots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// 
        /// <returns>The response from the ListBots service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBots">REST API Reference for ListBots Operation</seealso>
        ListBotsResponse ListBots(ListBotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBots operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBots">REST API Reference for ListBots Operation</seealso>
        IAsyncResult BeginListBots(ListBotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBots.</param>
        /// 
        /// <returns>Returns a  ListBotsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBots">REST API Reference for ListBots Operation</seealso>
        ListBotsResponse EndListBots(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBotVersions


        /// <summary>
        /// Gets information about all of the versions of a bot.
        /// 
        ///  
        /// <para>
        /// The <code>ListBotVersions</code> operation returns a summary of each version of a
        /// bot. For example, if a bot has three numbered versions, the <code>ListBotVersions</code>
        /// operation returns for summaries, one for each numbered version and one for the <code>DRAFT</code>
        /// version.
        /// </para>
        ///  
        /// <para>
        /// The <code>ListBotVersions</code> operation always returns at least one version, the
        /// <code>DRAFT</code> version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBotVersions service method.</param>
        /// 
        /// <returns>The response from the ListBotVersions service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotVersions">REST API Reference for ListBotVersions Operation</seealso>
        ListBotVersionsResponse ListBotVersions(ListBotVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBotVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBotVersions operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBotVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotVersions">REST API Reference for ListBotVersions Operation</seealso>
        IAsyncResult BeginListBotVersions(ListBotVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBotVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBotVersions.</param>
        /// 
        /// <returns>Returns a  ListBotVersionsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotVersions">REST API Reference for ListBotVersions Operation</seealso>
        ListBotVersionsResponse EndListBotVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBuiltInIntents


        /// <summary>
        /// Gets a list of built-in intents provided by Amazon Lex that you can use in your bot.
        /// 
        /// 
        ///  
        /// <para>
        /// To use a built-in intent as a the base for your own intent, include the built-in intent
        /// signature in the <code>parentIntentSignature</code> parameter when you call the <code>CreateIntent</code>
        /// operation. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_CreateIntent.html">CreateIntent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuiltInIntents service method.</param>
        /// 
        /// <returns>The response from the ListBuiltInIntents service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBuiltInIntents">REST API Reference for ListBuiltInIntents Operation</seealso>
        ListBuiltInIntentsResponse ListBuiltInIntents(ListBuiltInIntentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuiltInIntents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuiltInIntents operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuiltInIntents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBuiltInIntents">REST API Reference for ListBuiltInIntents Operation</seealso>
        IAsyncResult BeginListBuiltInIntents(ListBuiltInIntentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuiltInIntents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuiltInIntents.</param>
        /// 
        /// <returns>Returns a  ListBuiltInIntentsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBuiltInIntents">REST API Reference for ListBuiltInIntents Operation</seealso>
        ListBuiltInIntentsResponse EndListBuiltInIntents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBuiltInSlotTypes


        /// <summary>
        /// Gets a list of built-in slot types that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuiltInSlotTypes service method.</param>
        /// 
        /// <returns>The response from the ListBuiltInSlotTypes service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBuiltInSlotTypes">REST API Reference for ListBuiltInSlotTypes Operation</seealso>
        ListBuiltInSlotTypesResponse ListBuiltInSlotTypes(ListBuiltInSlotTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuiltInSlotTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuiltInSlotTypes operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuiltInSlotTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBuiltInSlotTypes">REST API Reference for ListBuiltInSlotTypes Operation</seealso>
        IAsyncResult BeginListBuiltInSlotTypes(ListBuiltInSlotTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuiltInSlotTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuiltInSlotTypes.</param>
        /// 
        /// <returns>Returns a  ListBuiltInSlotTypesResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBuiltInSlotTypes">REST API Reference for ListBuiltInSlotTypes Operation</seealso>
        ListBuiltInSlotTypesResponse EndListBuiltInSlotTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCustomVocabularyItems


        /// <summary>
        /// Paginated list of custom vocabulary items for a given bot locale's custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVocabularyItems service method.</param>
        /// 
        /// <returns>The response from the ListCustomVocabularyItems service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListCustomVocabularyItems">REST API Reference for ListCustomVocabularyItems Operation</seealso>
        ListCustomVocabularyItemsResponse ListCustomVocabularyItems(ListCustomVocabularyItemsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomVocabularyItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVocabularyItems operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomVocabularyItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListCustomVocabularyItems">REST API Reference for ListCustomVocabularyItems Operation</seealso>
        IAsyncResult BeginListCustomVocabularyItems(ListCustomVocabularyItemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomVocabularyItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomVocabularyItems.</param>
        /// 
        /// <returns>Returns a  ListCustomVocabularyItemsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListCustomVocabularyItems">REST API Reference for ListCustomVocabularyItems Operation</seealso>
        ListCustomVocabularyItemsResponse EndListCustomVocabularyItems(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExports


        /// <summary>
        /// Lists the exports for a bot, bot locale, or custom vocabulary. Exports are kept in
        /// the list for 7 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse ListExports(ListExportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExports operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListExports">REST API Reference for ListExports Operation</seealso>
        IAsyncResult BeginListExports(ListExportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExports.</param>
        /// 
        /// <returns>Returns a  ListExportsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse EndListExports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImports


        /// <summary>
        /// Lists the imports for a bot, bot locale, or custom vocabulary. Imports are kept in
        /// the list for 7 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListImports">REST API Reference for ListImports Operation</seealso>
        ListImportsResponse ListImports(ListImportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImports operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListImports">REST API Reference for ListImports Operation</seealso>
        IAsyncResult BeginListImports(ListImportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImports.</param>
        /// 
        /// <returns>Returns a  ListImportsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListImports">REST API Reference for ListImports Operation</seealso>
        ListImportsResponse EndListImports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIntents


        /// <summary>
        /// Get a list of intents that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntents service method.</param>
        /// 
        /// <returns>The response from the ListIntents service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListIntents">REST API Reference for ListIntents Operation</seealso>
        ListIntentsResponse ListIntents(ListIntentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIntents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIntents operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIntents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListIntents">REST API Reference for ListIntents Operation</seealso>
        IAsyncResult BeginListIntents(ListIntentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIntents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIntents.</param>
        /// 
        /// <returns>Returns a  ListIntentsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListIntents">REST API Reference for ListIntents Operation</seealso>
        ListIntentsResponse EndListIntents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecommendedIntents


        /// <summary>
        /// Gets a list of recommended intents provided by the bot recommendation that you can
        /// use in your bot. Intents in the response are ordered by relevance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedIntents service method.</param>
        /// 
        /// <returns>The response from the ListRecommendedIntents service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListRecommendedIntents">REST API Reference for ListRecommendedIntents Operation</seealso>
        ListRecommendedIntentsResponse ListRecommendedIntents(ListRecommendedIntentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendedIntents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedIntents operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendedIntents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListRecommendedIntents">REST API Reference for ListRecommendedIntents Operation</seealso>
        IAsyncResult BeginListRecommendedIntents(ListRecommendedIntentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendedIntents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendedIntents.</param>
        /// 
        /// <returns>Returns a  ListRecommendedIntentsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListRecommendedIntents">REST API Reference for ListRecommendedIntents Operation</seealso>
        ListRecommendedIntentsResponse EndListRecommendedIntents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSlots


        /// <summary>
        /// Gets a list of slots that match the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSlots service method.</param>
        /// 
        /// <returns>The response from the ListSlots service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListSlots">REST API Reference for ListSlots Operation</seealso>
        ListSlotsResponse ListSlots(ListSlotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSlots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSlots operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSlots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListSlots">REST API Reference for ListSlots Operation</seealso>
        IAsyncResult BeginListSlots(ListSlotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSlots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSlots.</param>
        /// 
        /// <returns>Returns a  ListSlotsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListSlots">REST API Reference for ListSlots Operation</seealso>
        ListSlotsResponse EndListSlots(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSlotTypes


        /// <summary>
        /// Gets a list of slot types that match the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSlotTypes service method.</param>
        /// 
        /// <returns>The response from the ListSlotTypes service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListSlotTypes">REST API Reference for ListSlotTypes Operation</seealso>
        ListSlotTypesResponse ListSlotTypes(ListSlotTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSlotTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSlotTypes operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSlotTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListSlotTypes">REST API Reference for ListSlotTypes Operation</seealso>
        IAsyncResult BeginListSlotTypes(ListSlotTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSlotTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSlotTypes.</param>
        /// 
        /// <returns>Returns a  ListSlotTypesResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListSlotTypes">REST API Reference for ListSlotTypes Operation</seealso>
        ListSlotTypesResponse EndListSlotTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets a list of tags associated with a resource. Only bots, bot aliases, and bot channels
        /// can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchAssociatedTranscripts


        /// <summary>
        /// Search for associated transcripts that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAssociatedTranscripts service method.</param>
        /// 
        /// <returns>The response from the SearchAssociatedTranscripts service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/SearchAssociatedTranscripts">REST API Reference for SearchAssociatedTranscripts Operation</seealso>
        SearchAssociatedTranscriptsResponse SearchAssociatedTranscripts(SearchAssociatedTranscriptsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchAssociatedTranscripts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchAssociatedTranscripts operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchAssociatedTranscripts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/SearchAssociatedTranscripts">REST API Reference for SearchAssociatedTranscripts Operation</seealso>
        IAsyncResult BeginSearchAssociatedTranscripts(SearchAssociatedTranscriptsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchAssociatedTranscripts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchAssociatedTranscripts.</param>
        /// 
        /// <returns>Returns a  SearchAssociatedTranscriptsResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/SearchAssociatedTranscripts">REST API Reference for SearchAssociatedTranscripts Operation</seealso>
        SearchAssociatedTranscriptsResponse EndSearchAssociatedTranscripts(IAsyncResult asyncResult);

        #endregion
        
        #region  StartBotRecommendation


        /// <summary>
        /// Use this to provide your transcript data, and to start the bot recommendation process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBotRecommendation service method.</param>
        /// 
        /// <returns>The response from the StartBotRecommendation service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/StartBotRecommendation">REST API Reference for StartBotRecommendation Operation</seealso>
        StartBotRecommendationResponse StartBotRecommendation(StartBotRecommendationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartBotRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBotRecommendation operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBotRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/StartBotRecommendation">REST API Reference for StartBotRecommendation Operation</seealso>
        IAsyncResult BeginStartBotRecommendation(StartBotRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartBotRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBotRecommendation.</param>
        /// 
        /// <returns>Returns a  StartBotRecommendationResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/StartBotRecommendation">REST API Reference for StartBotRecommendation Operation</seealso>
        StartBotRecommendationResponse EndStartBotRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  StartImport


        /// <summary>
        /// Starts importing a bot, bot locale, or custom vocabulary from a zip archive that you
        /// uploaded to an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// 
        /// <returns>The response from the StartImport service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/StartImport">REST API Reference for StartImport Operation</seealso>
        StartImportResponse StartImport(StartImportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImport operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/StartImport">REST API Reference for StartImport Operation</seealso>
        IAsyncResult BeginStartImport(StartImportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImport.</param>
        /// 
        /// <returns>Returns a  StartImportResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/StartImport">REST API Reference for StartImport Operation</seealso>
        StartImportResponse EndStartImport(IAsyncResult asyncResult);

        #endregion
        
        #region  StopBotRecommendation


        /// <summary>
        /// Stop an already running Bot Recommendation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBotRecommendation service method.</param>
        /// 
        /// <returns>The response from the StopBotRecommendation service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/StopBotRecommendation">REST API Reference for StopBotRecommendation Operation</seealso>
        StopBotRecommendationResponse StopBotRecommendation(StopBotRecommendationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopBotRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBotRecommendation operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopBotRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/StopBotRecommendation">REST API Reference for StopBotRecommendation Operation</seealso>
        IAsyncResult BeginStopBotRecommendation(StopBotRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopBotRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopBotRecommendation.</param>
        /// 
        /// <returns>Returns a  StopBotRecommendationResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/StopBotRecommendation">REST API Reference for StopBotRecommendation Operation</seealso>
        StopBotRecommendationResponse EndStopBotRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource. If a tag key already exists, the
        /// existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a bot, bot alias, or bot channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBot


        /// <summary>
        /// Updates the configuration of an existing bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot service method.</param>
        /// 
        /// <returns>The response from the UpdateBot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        UpdateBotResponse UpdateBot(UpdateBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        IAsyncResult BeginUpdateBot(UpdateBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBot.</param>
        /// 
        /// <returns>Returns a  UpdateBotResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        UpdateBotResponse EndUpdateBot(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBotAlias


        /// <summary>
        /// Updates the configuration of an existing bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateBotAlias service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotAlias">REST API Reference for UpdateBotAlias Operation</seealso>
        UpdateBotAliasResponse UpdateBotAlias(UpdateBotAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBotAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotAlias operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBotAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotAlias">REST API Reference for UpdateBotAlias Operation</seealso>
        IAsyncResult BeginUpdateBotAlias(UpdateBotAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBotAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBotAlias.</param>
        /// 
        /// <returns>Returns a  UpdateBotAliasResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotAlias">REST API Reference for UpdateBotAlias Operation</seealso>
        UpdateBotAliasResponse EndUpdateBotAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBotLocale


        /// <summary>
        /// Updates the settings that a bot has for a specific locale.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotLocale service method.</param>
        /// 
        /// <returns>The response from the UpdateBotLocale service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotLocale">REST API Reference for UpdateBotLocale Operation</seealso>
        UpdateBotLocaleResponse UpdateBotLocale(UpdateBotLocaleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBotLocale operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotLocale operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBotLocale
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotLocale">REST API Reference for UpdateBotLocale Operation</seealso>
        IAsyncResult BeginUpdateBotLocale(UpdateBotLocaleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBotLocale operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBotLocale.</param>
        /// 
        /// <returns>Returns a  UpdateBotLocaleResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotLocale">REST API Reference for UpdateBotLocale Operation</seealso>
        UpdateBotLocaleResponse EndUpdateBotLocale(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBotRecommendation


        /// <summary>
        /// Updates an existing bot recommendation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotRecommendation service method.</param>
        /// 
        /// <returns>The response from the UpdateBotRecommendation service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotRecommendation">REST API Reference for UpdateBotRecommendation Operation</seealso>
        UpdateBotRecommendationResponse UpdateBotRecommendation(UpdateBotRecommendationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBotRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotRecommendation operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBotRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotRecommendation">REST API Reference for UpdateBotRecommendation Operation</seealso>
        IAsyncResult BeginUpdateBotRecommendation(UpdateBotRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBotRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBotRecommendation.</param>
        /// 
        /// <returns>Returns a  UpdateBotRecommendationResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotRecommendation">REST API Reference for UpdateBotRecommendation Operation</seealso>
        UpdateBotRecommendationResponse EndUpdateBotRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateExport


        /// <summary>
        /// Updates the password used to protect an export zip archive.
        /// 
        ///  
        /// <para>
        /// The password is not required. If you don't supply a password, Amazon Lex generates
        /// a zip file that is not protected by a password. This is the archive that is available
        /// at the pre-signed S3 URL provided by the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DescribeExport.html">DescribeExport</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExport service method.</param>
        /// 
        /// <returns>The response from the UpdateExport service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateExport">REST API Reference for UpdateExport Operation</seealso>
        UpdateExportResponse UpdateExport(UpdateExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExport operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateExport">REST API Reference for UpdateExport Operation</seealso>
        IAsyncResult BeginUpdateExport(UpdateExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateExport.</param>
        /// 
        /// <returns>Returns a  UpdateExportResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateExport">REST API Reference for UpdateExport Operation</seealso>
        UpdateExportResponse EndUpdateExport(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIntent


        /// <summary>
        /// Updates the settings for an intent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntent service method.</param>
        /// 
        /// <returns>The response from the UpdateIntent service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateIntent">REST API Reference for UpdateIntent Operation</seealso>
        UpdateIntentResponse UpdateIntent(UpdateIntentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntent operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIntent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateIntent">REST API Reference for UpdateIntent Operation</seealso>
        IAsyncResult BeginUpdateIntent(UpdateIntentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntent.</param>
        /// 
        /// <returns>Returns a  UpdateIntentResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateIntent">REST API Reference for UpdateIntent Operation</seealso>
        UpdateIntentResponse EndUpdateIntent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResourcePolicy


        /// <summary>
        /// Replaces the existing resource policy for a bot or bot alias with a new one. If the
        /// policy doesn't exist, Amazon Lex returns an exception.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateResourcePolicy service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// You asked to describe a resource that doesn't exist. Check the resource that you are
        /// requesting and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateResourcePolicy">REST API Reference for UpdateResourcePolicy Operation</seealso>
        UpdateResourcePolicyResponse UpdateResourcePolicy(UpdateResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourcePolicy operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateResourcePolicy">REST API Reference for UpdateResourcePolicy Operation</seealso>
        IAsyncResult BeginUpdateResourcePolicy(UpdateResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourcePolicy.</param>
        /// 
        /// <returns>Returns a  UpdateResourcePolicyResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateResourcePolicy">REST API Reference for UpdateResourcePolicy Operation</seealso>
        UpdateResourcePolicyResponse EndUpdateResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSlot


        /// <summary>
        /// Updates the settings for a slot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlot service method.</param>
        /// 
        /// <returns>The response from the UpdateSlot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateSlot">REST API Reference for UpdateSlot Operation</seealso>
        UpdateSlotResponse UpdateSlot(UpdateSlotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSlot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlot operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSlot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateSlot">REST API Reference for UpdateSlot Operation</seealso>
        IAsyncResult BeginUpdateSlot(UpdateSlotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSlot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSlot.</param>
        /// 
        /// <returns>Returns a  UpdateSlotResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateSlot">REST API Reference for UpdateSlot Operation</seealso>
        UpdateSlotResponse EndUpdateSlot(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSlotType


        /// <summary>
        /// Updates the configuration of an existing slot type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlotType service method.</param>
        /// 
        /// <returns>The response from the UpdateSlotType service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// The action that you tried to perform couldn't be completed because the resource is
        /// in a conflicting state. For example, deleting a bot that is in the CREATING state.
        /// Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// The service encountered an unexpected condition. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// Your request couldn't be completed because one or more request fields aren't valid.
        /// Check the fields in your request and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// You have reached a quota for your bot.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// Your request rate is too high. Reduce the frequency of requests.
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// One of the input parameters in your request isn't valid. Check the parameters and
        /// try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateSlotType">REST API Reference for UpdateSlotType Operation</seealso>
        UpdateSlotTypeResponse UpdateSlotType(UpdateSlotTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSlotType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlotType operation on AmazonLexModelsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSlotType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateSlotType">REST API Reference for UpdateSlotType Operation</seealso>
        IAsyncResult BeginUpdateSlotType(UpdateSlotTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSlotType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSlotType.</param>
        /// 
        /// <returns>Returns a  UpdateSlotTypeResult from LexModelsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateSlotType">REST API Reference for UpdateSlotType Operation</seealso>
        UpdateSlotTypeResponse EndUpdateSlotType(IAsyncResult asyncResult);

        #endregion
        
    }
}