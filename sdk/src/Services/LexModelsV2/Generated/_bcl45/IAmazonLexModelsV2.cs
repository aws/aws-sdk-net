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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILexModelsV2PaginatorFactory Paginators { get; }

        
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
        /// Create a batch of custom vocabulary items for a given bot locale's custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCustomVocabularyItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchCreateCustomVocabularyItemResponse> BatchCreateCustomVocabularyItemAsync(BatchCreateCustomVocabularyItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Delete a batch of custom vocabulary items for a given bot locale's custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCustomVocabularyItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDeleteCustomVocabularyItemResponse> BatchDeleteCustomVocabularyItemAsync(BatchDeleteCustomVocabularyItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Update a batch of custom vocabulary items for a given bot locale's custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCustomVocabularyItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchUpdateCustomVocabularyItemResponse> BatchUpdateCustomVocabularyItemAsync(BatchUpdateCustomVocabularyItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Builds a bot, its intents, and its slot types into a specific locale. A bot can be
        /// built into multiple locales. At runtime the locale is used to choose a specific build
        /// of the bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BuildBotLocale service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BuildBotLocaleResponse> BuildBotLocaleAsync(BuildBotLocaleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an Amazon Lex conversational bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateBotResponse> CreateBotAsync(CreateBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateBotAliasResponse> CreateBotAliasAsync(CreateBotAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a locale in the bot. The locale contains the intents and slot types that the
        /// bot uses in conversations with users in the specified language and locale. You must
        /// add a locale to a bot before you can add intents and slot types to the bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBotLocale service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateBotLocaleResponse> CreateBotLocaleAsync(CreateBotLocaleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateBotVersionResponse> CreateBotVersionAsync(CreateBotVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateExportResponse> CreateExportAsync(CreateExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateIntentResponse> CreateIntentAsync(CreateIntentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new resource policy with the specified policy statements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateResourcePolicyResponse> CreateResourcePolicyAsync(CreateResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateResourcePolicyStatementResponse> CreateResourcePolicyStatementAsync(CreateResourcePolicyStatementRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a slot in an intent. A slot is a variable needed to fulfill an intent. For
        /// example, an <code>OrderPizza</code> intent might need slots for size, crust, and number
        /// of pizzas. For each slot, you define one or more utterances that Amazon Lex uses to
        /// elicit a response from the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSlotResponse> CreateSlotAsync(CreateSlotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a custom slot type
        /// 
        ///  
        /// <para>
        ///  To create a custom slot type, specify a name for the slot type and a set of enumeration
        /// values, the values that a slot of this type can assume. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlotType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSlotTypeResponse> CreateSlotTypeAsync(CreateSlotTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a pre-signed S3 write URL that you use to upload the zip archive when importing
        /// a bot or a bot locale.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateUploadUrlResponse> CreateUploadUrlAsync(CreateUploadUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteBotResponse> DeleteBotAsync(DeleteBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteBotAliasResponse> DeleteBotAliasAsync(DeleteBotAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a locale from a bot.
        /// 
        ///  
        /// <para>
        /// When you delete a locale, all intents, slots, and slot types defined for the locale
        /// are also deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotLocale service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteBotLocaleResponse> DeleteBotLocaleAsync(DeleteBotLocaleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a specific version of a bot. To delete all versions of a bot, use the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DeleteBot.html">DeleteBot</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteBotVersionResponse> DeleteBotVersionAsync(DeleteBotVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a custom vocabulary from the specified locale in the specified bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteCustomVocabularyResponse> DeleteCustomVocabularyAsync(DeleteCustomVocabularyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a previous export and the associated files stored in an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteExportResponse> DeleteExportAsync(DeleteExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a previous import and the associated file stored in an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteImportResponse> DeleteImportAsync(DeleteImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes the specified intent.
        /// 
        ///  
        /// <para>
        /// Deleting an intent also deletes the slots associated with the intent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteIntentResponse> DeleteIntentAsync(DeleteIntentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes an existing policy from a bot or bot alias. If the resource doesn't have a
        /// policy attached, Amazon Lex returns an exception.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a policy statement from a resource policy. If you delete the last statement
        /// from a policy, the policy is deleted. If you specify a statement ID that doesn't exist
        /// in the policy, or if the bot or bot alias doesn't have a policy attached, Amazon Lex
        /// returns an exception.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicyStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteResourcePolicyStatementResponse> DeleteResourcePolicyStatementAsync(DeleteResourcePolicyStatementRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified slot from an intent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteSlotResponse> DeleteSlotAsync(DeleteSlotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteSlotTypeResponse> DeleteSlotTypeAsync(DeleteSlotTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteUtterancesResponse> DeleteUtterancesAsync(DeleteUtterancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides metadata information about a bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBotResponse> DescribeBotAsync(DescribeBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get information about a specific bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBotAliasResponse> DescribeBotAliasAsync(DescribeBotAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the settings that a bot has for a specific locale.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotLocale service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBotLocaleResponse> DescribeBotLocaleAsync(DescribeBotLocaleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides metadata information about a bot recommendation. This information will enable
        /// you to get a description on the request inputs, to download associated transcripts
        /// after processing is complete, and to download intents and slot-types generated by
        /// the bot recommendation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBotRecommendationResponse> DescribeBotRecommendationAsync(DescribeBotRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides metadata about a version of a bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBotVersionResponse> DescribeBotVersionAsync(DescribeBotVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides metadata information about a custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomVocabularyMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeCustomVocabularyMetadataResponse> DescribeCustomVocabularyMetadataAsync(DescribeCustomVocabularyMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a specific export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeExportResponse> DescribeExportAsync(DescribeExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a specific import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeImportResponse> DescribeImportAsync(DescribeImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns metadata about an intent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeIntentResponse> DescribeIntentAsync(DescribeIntentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets the resource policy and policy revision for a bot or bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeResourcePolicyResponse> DescribeResourcePolicyAsync(DescribeResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets metadata information about a slot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeSlotResponse> DescribeSlotAsync(DescribeSlotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets metadata information about a slot type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlotType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeSlotTypeResponse> DescribeSlotTypeAsync(DescribeSlotTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAggregatedUtterancesResponse> ListAggregatedUtterancesAsync(ListAggregatedUtterancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of aliases for the specified bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBotAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBotAliasesResponse> ListBotAliasesAsync(ListBotAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of locales for the specified bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBotLocales service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBotLocalesResponse> ListBotLocalesAsync(ListBotLocalesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get a list of bot recommendations that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBotRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBotRecommendationsResponse> ListBotRecommendationsAsync(ListBotRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of available bots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBotsResponse> ListBotsAsync(ListBotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBotVersionsResponse> ListBotVersionsAsync(ListBotVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBuiltInIntentsResponse> ListBuiltInIntentsAsync(ListBuiltInIntentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of built-in slot types that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuiltInSlotTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBuiltInSlotTypesResponse> ListBuiltInSlotTypesAsync(ListBuiltInSlotTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Paginated list of custom vocabulary items for a given bot locale's custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVocabularyItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListCustomVocabularyItemsResponse> ListCustomVocabularyItemsAsync(ListCustomVocabularyItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the exports for a bot, bot locale, or custom vocabulary. Exports are kept in
        /// the list for 7 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the imports for a bot, bot locale, or custom vocabulary. Imports are kept in
        /// the list for 7 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get a list of intents that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListIntentsResponse> ListIntentsAsync(ListIntentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of recommended intents provided by the bot recommendation that you can
        /// use in your bot. Intents in the response are ordered by relevance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedIntents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRecommendedIntentsResponse> ListRecommendedIntentsAsync(ListRecommendedIntentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of slots that match the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSlots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSlotsResponse> ListSlotsAsync(ListSlotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of slot types that match the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSlotTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSlotTypesResponse> ListSlotTypesAsync(ListSlotTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of tags associated with a resource. Only bots, bot aliases, and bot channels
        /// can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Search for associated transcripts that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAssociatedTranscripts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SearchAssociatedTranscriptsResponse> SearchAssociatedTranscriptsAsync(SearchAssociatedTranscriptsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Use this to provide your transcript data, and to start the bot recommendation process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBotRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartBotRecommendationResponse> StartBotRecommendationAsync(StartBotRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts importing a bot, bot locale, or custom vocabulary from a zip archive that you
        /// uploaded to an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartImportResponse> StartImportAsync(StartImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Stop an already running Bot Recommendation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBotRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopBotRecommendationResponse> StopBotRecommendationAsync(StopBotRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Adds the specified tags to the specified resource. If a tag key already exists, the
        /// existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes tags from a bot, bot alias, or bot channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the configuration of an existing bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateBotResponse> UpdateBotAsync(UpdateBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the configuration of an existing bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateBotAliasResponse> UpdateBotAliasAsync(UpdateBotAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the settings that a bot has for a specific locale.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotLocale service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateBotLocaleResponse> UpdateBotLocaleAsync(UpdateBotLocaleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an existing bot recommendation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateBotRecommendationResponse> UpdateBotRecommendationAsync(UpdateBotRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateExportResponse> UpdateExportAsync(UpdateExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the settings for an intent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateIntentResponse> UpdateIntentAsync(UpdateIntentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Replaces the existing resource policy for a bot or bot alias with a new one. If the
        /// policy doesn't exist, Amazon Lex returns an exception.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateResourcePolicyResponse> UpdateResourcePolicyAsync(UpdateResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the settings for a slot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateSlotResponse> UpdateSlotAsync(UpdateSlotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the configuration of an existing slot type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlotType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateSlotTypeResponse> UpdateSlotTypeAsync(UpdateSlotTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}