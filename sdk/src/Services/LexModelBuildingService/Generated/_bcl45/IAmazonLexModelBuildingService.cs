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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LexModelBuildingService.Model;

namespace Amazon.LexModelBuildingService
{
    /// <summary>
    /// Interface for accessing LexModelBuildingService
    ///
    /// Amazon Lex Build-Time Actions 
    /// <para>
    ///  Amazon Lex is an AWS service for building conversational voice and text interfaces.
    /// Use these actions to create, update, and delete conversational bots for new and existing
    /// client applications. 
    /// </para>
    /// </summary>
    public partial interface IAmazonLexModelBuildingService : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILexModelBuildingServicePaginatorFactory Paginators { get; }

        
        #region  CreateBotVersion


        /// <summary>
        /// Creates a new version of the bot based on the <code>$LATEST</code> version. If the
        /// <code>$LATEST</code> version of this resource hasn't changed since you created the
        /// last version, Amazon Lex doesn't create a new version. It returns the last created
        /// version.
        /// 
        ///  <note> 
        /// <para>
        /// You can update only the <code>$LATEST</code> version of the bot. You can't update
        /// the numbered versions that you create with the <code>CreateBotVersion</code> operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  When you create the first version of a bot, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1. For more information, see <a>versioning-intro</a>. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permission for the <code>lex:CreateBotVersion</code> action.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBotVersion service method.</param>
        /// 
        /// <returns>The response from the CreateBotVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateBotVersion">REST API Reference for CreateBotVersion Operation</seealso>
        CreateBotVersionResponse CreateBotVersion(CreateBotVersionRequest request);



        /// <summary>
        /// Creates a new version of the bot based on the <code>$LATEST</code> version. If the
        /// <code>$LATEST</code> version of this resource hasn't changed since you created the
        /// last version, Amazon Lex doesn't create a new version. It returns the last created
        /// version.
        /// 
        ///  <note> 
        /// <para>
        /// You can update only the <code>$LATEST</code> version of the bot. You can't update
        /// the numbered versions that you create with the <code>CreateBotVersion</code> operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  When you create the first version of a bot, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1. For more information, see <a>versioning-intro</a>. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permission for the <code>lex:CreateBotVersion</code> action.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBotVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBotVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateBotVersion">REST API Reference for CreateBotVersion Operation</seealso>
        Task<CreateBotVersionResponse> CreateBotVersionAsync(CreateBotVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateIntentVersion


        /// <summary>
        /// Creates a new version of an intent based on the <code>$LATEST</code> version of the
        /// intent. If the <code>$LATEST</code> version of this intent hasn't changed since you
        /// last updated it, Amazon Lex doesn't create a new version. It returns the last version
        /// you created.
        /// 
        ///  <note> 
        /// <para>
        /// You can update only the <code>$LATEST</code> version of the intent. You can't update
        /// the numbered versions that you create with the <code>CreateIntentVersion</code> operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  When you create a version of an intent, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1. For more information, see <a>versioning-intro</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lex:CreateIntentVersion</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntentVersion service method.</param>
        /// 
        /// <returns>The response from the CreateIntentVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateIntentVersion">REST API Reference for CreateIntentVersion Operation</seealso>
        CreateIntentVersionResponse CreateIntentVersion(CreateIntentVersionRequest request);



        /// <summary>
        /// Creates a new version of an intent based on the <code>$LATEST</code> version of the
        /// intent. If the <code>$LATEST</code> version of this intent hasn't changed since you
        /// last updated it, Amazon Lex doesn't create a new version. It returns the last version
        /// you created.
        /// 
        ///  <note> 
        /// <para>
        /// You can update only the <code>$LATEST</code> version of the intent. You can't update
        /// the numbered versions that you create with the <code>CreateIntentVersion</code> operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  When you create a version of an intent, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1. For more information, see <a>versioning-intro</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lex:CreateIntentVersion</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntentVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateIntentVersion">REST API Reference for CreateIntentVersion Operation</seealso>
        Task<CreateIntentVersionResponse> CreateIntentVersionAsync(CreateIntentVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSlotTypeVersion


        /// <summary>
        /// Creates a new version of a slot type based on the <code>$LATEST</code> version of
        /// the specified slot type. If the <code>$LATEST</code> version of this resource has
        /// not changed since the last version that you created, Amazon Lex doesn't create a new
        /// version. It returns the last version that you created. 
        /// 
        ///  <note> 
        /// <para>
        /// You can update only the <code>$LATEST</code> version of a slot type. You can't update
        /// the numbered versions that you create with the <code>CreateSlotTypeVersion</code>
        /// operation.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you create a version of a slot type, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1. For more information, see <a>versioning-intro</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:CreateSlotTypeVersion</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlotTypeVersion service method.</param>
        /// 
        /// <returns>The response from the CreateSlotTypeVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateSlotTypeVersion">REST API Reference for CreateSlotTypeVersion Operation</seealso>
        CreateSlotTypeVersionResponse CreateSlotTypeVersion(CreateSlotTypeVersionRequest request);



        /// <summary>
        /// Creates a new version of a slot type based on the <code>$LATEST</code> version of
        /// the specified slot type. If the <code>$LATEST</code> version of this resource has
        /// not changed since the last version that you created, Amazon Lex doesn't create a new
        /// version. It returns the last version that you created. 
        /// 
        ///  <note> 
        /// <para>
        /// You can update only the <code>$LATEST</code> version of a slot type. You can't update
        /// the numbered versions that you create with the <code>CreateSlotTypeVersion</code>
        /// operation.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you create a version of a slot type, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1. For more information, see <a>versioning-intro</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:CreateSlotTypeVersion</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlotTypeVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSlotTypeVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateSlotTypeVersion">REST API Reference for CreateSlotTypeVersion Operation</seealso>
        Task<CreateSlotTypeVersionResponse> CreateSlotTypeVersionAsync(CreateSlotTypeVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBot


        /// <summary>
        /// Deletes all versions of the bot, including the <code>$LATEST</code> version. To delete
        /// a specific version of the bot, use the <a>DeleteBotVersion</a> operation. The <code>DeleteBot</code>
        /// operation doesn't immediately remove the bot schema. Instead, it is marked for deletion
        /// and removed later.
        /// 
        ///  
        /// <para>
        /// Amazon Lex stores utterances indefinitely for improving the ability of your bot to
        /// respond to user inputs. These utterances are not removed when the bot is deleted.
        /// To remove the utterances, use the <a>DeleteUtterances</a> operation.
        /// </para>
        ///  
        /// <para>
        /// If a bot has an alias, you can't delete it. Instead, the <code>DeleteBot</code> operation
        /// returns a <code>ResourceInUseException</code> exception that includes a reference
        /// to the alias that refers to the bot. To remove the reference to the bot, delete the
        /// alias. If you get the same exception again, delete the referring alias until the <code>DeleteBot</code>
        /// operation is successful.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:DeleteBot</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot service method.</param>
        /// 
        /// <returns>The response from the DeleteBot service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        DeleteBotResponse DeleteBot(DeleteBotRequest request);



        /// <summary>
        /// Deletes all versions of the bot, including the <code>$LATEST</code> version. To delete
        /// a specific version of the bot, use the <a>DeleteBotVersion</a> operation. The <code>DeleteBot</code>
        /// operation doesn't immediately remove the bot schema. Instead, it is marked for deletion
        /// and removed later.
        /// 
        ///  
        /// <para>
        /// Amazon Lex stores utterances indefinitely for improving the ability of your bot to
        /// respond to user inputs. These utterances are not removed when the bot is deleted.
        /// To remove the utterances, use the <a>DeleteUtterances</a> operation.
        /// </para>
        ///  
        /// <para>
        /// If a bot has an alias, you can't delete it. Instead, the <code>DeleteBot</code> operation
        /// returns a <code>ResourceInUseException</code> exception that includes a reference
        /// to the alias that refers to the bot. To remove the reference to the bot, delete the
        /// alias. If you get the same exception again, delete the referring alias until the <code>DeleteBot</code>
        /// operation is successful.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:DeleteBot</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBot service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        Task<DeleteBotResponse> DeleteBotAsync(DeleteBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBotAlias


        /// <summary>
        /// Deletes an alias for the specified bot. 
        /// 
        ///  
        /// <para>
        /// You can't delete an alias that is used in the association between a bot and a messaging
        /// channel. If an alias is used in a channel association, the <code>DeleteBot</code>
        /// operation returns a <code>ResourceInUseException</code> exception that includes a
        /// reference to the channel association that refers to the bot. You can remove the reference
        /// to the alias by deleting the channel association. If you get the same exception again,
        /// delete the referring association until the <code>DeleteBotAlias</code> operation is
        /// successful.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteBotAlias service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotAlias">REST API Reference for DeleteBotAlias Operation</seealso>
        DeleteBotAliasResponse DeleteBotAlias(DeleteBotAliasRequest request);



        /// <summary>
        /// Deletes an alias for the specified bot. 
        /// 
        ///  
        /// <para>
        /// You can't delete an alias that is used in the association between a bot and a messaging
        /// channel. If an alias is used in a channel association, the <code>DeleteBot</code>
        /// operation returns a <code>ResourceInUseException</code> exception that includes a
        /// reference to the channel association that refers to the bot. You can remove the reference
        /// to the alias by deleting the channel association. If you get the same exception again,
        /// delete the referring association until the <code>DeleteBotAlias</code> operation is
        /// successful.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBotAlias service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotAlias">REST API Reference for DeleteBotAlias Operation</seealso>
        Task<DeleteBotAliasResponse> DeleteBotAliasAsync(DeleteBotAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBotChannelAssociation


        /// <summary>
        /// Deletes the association between an Amazon Lex bot and a messaging platform.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lex:DeleteBotChannelAssociation</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotChannelAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteBotChannelAssociation service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotChannelAssociation">REST API Reference for DeleteBotChannelAssociation Operation</seealso>
        DeleteBotChannelAssociationResponse DeleteBotChannelAssociation(DeleteBotChannelAssociationRequest request);



        /// <summary>
        /// Deletes the association between an Amazon Lex bot and a messaging platform.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lex:DeleteBotChannelAssociation</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotChannelAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBotChannelAssociation service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotChannelAssociation">REST API Reference for DeleteBotChannelAssociation Operation</seealso>
        Task<DeleteBotChannelAssociationResponse> DeleteBotChannelAssociationAsync(DeleteBotChannelAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBotVersion


        /// <summary>
        /// Deletes a specific version of a bot. To delete all versions of a bot, use the <a>DeleteBot</a>
        /// operation. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:DeleteBotVersion</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteBotVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotVersion">REST API Reference for DeleteBotVersion Operation</seealso>
        DeleteBotVersionResponse DeleteBotVersion(DeleteBotVersionRequest request);



        /// <summary>
        /// Deletes a specific version of a bot. To delete all versions of a bot, use the <a>DeleteBot</a>
        /// operation. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:DeleteBotVersion</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBotVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotVersion">REST API Reference for DeleteBotVersion Operation</seealso>
        Task<DeleteBotVersionResponse> DeleteBotVersionAsync(DeleteBotVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIntent


        /// <summary>
        /// Deletes all versions of the intent, including the <code>$LATEST</code> version. To
        /// delete a specific version of the intent, use the <a>DeleteIntentVersion</a> operation.
        /// 
        ///  
        /// <para>
        ///  You can delete a version of an intent only if it is not referenced. To delete an
        /// intent that is referred to in one or more bots (see <a>how-it-works</a>), you must
        /// remove those references first. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you get the <code>ResourceInUseException</code> exception, it provides an example
        /// reference that shows where the intent is referenced. To remove the reference to the
        /// intent, either update the bot or delete it. If you get the same exception when you
        /// attempt to delete the intent again, repeat until the intent has no references and
        /// the call to <code>DeleteIntent</code> is successful. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  This operation requires permission for the <code>lex:DeleteIntent</code> action.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntent service method.</param>
        /// 
        /// <returns>The response from the DeleteIntent service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntent">REST API Reference for DeleteIntent Operation</seealso>
        DeleteIntentResponse DeleteIntent(DeleteIntentRequest request);



        /// <summary>
        /// Deletes all versions of the intent, including the <code>$LATEST</code> version. To
        /// delete a specific version of the intent, use the <a>DeleteIntentVersion</a> operation.
        /// 
        ///  
        /// <para>
        ///  You can delete a version of an intent only if it is not referenced. To delete an
        /// intent that is referred to in one or more bots (see <a>how-it-works</a>), you must
        /// remove those references first. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you get the <code>ResourceInUseException</code> exception, it provides an example
        /// reference that shows where the intent is referenced. To remove the reference to the
        /// intent, either update the bot or delete it. If you get the same exception when you
        /// attempt to delete the intent again, repeat until the intent has no references and
        /// the call to <code>DeleteIntent</code> is successful. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  This operation requires permission for the <code>lex:DeleteIntent</code> action.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntent service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntent">REST API Reference for DeleteIntent Operation</seealso>
        Task<DeleteIntentResponse> DeleteIntentAsync(DeleteIntentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIntentVersion


        /// <summary>
        /// Deletes a specific version of an intent. To delete all versions of a intent, use the
        /// <a>DeleteIntent</a> operation. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:DeleteIntentVersion</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntentVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteIntentVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntentVersion">REST API Reference for DeleteIntentVersion Operation</seealso>
        DeleteIntentVersionResponse DeleteIntentVersion(DeleteIntentVersionRequest request);



        /// <summary>
        /// Deletes a specific version of an intent. To delete all versions of a intent, use the
        /// <a>DeleteIntent</a> operation. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:DeleteIntentVersion</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntentVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntentVersion">REST API Reference for DeleteIntentVersion Operation</seealso>
        Task<DeleteIntentVersionResponse> DeleteIntentVersionAsync(DeleteIntentVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSlotType


        /// <summary>
        /// Deletes all versions of the slot type, including the <code>$LATEST</code> version.
        /// To delete a specific version of the slot type, use the <a>DeleteSlotTypeVersion</a>
        /// operation.
        /// 
        ///  
        /// <para>
        ///  You can delete a version of a slot type only if it is not referenced. To delete a
        /// slot type that is referred to in one or more intents, you must remove those references
        /// first. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you get the <code>ResourceInUseException</code> exception, the exception provides
        /// an example reference that shows the intent where the slot type is referenced. To remove
        /// the reference to the slot type, either update the intent or delete it. If you get
        /// the same exception when you attempt to delete the slot type again, repeat until the
        /// slot type has no references and the <code>DeleteSlotType</code> call is successful.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permission for the <code>lex:DeleteSlotType</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotType service method.</param>
        /// 
        /// <returns>The response from the DeleteSlotType service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotType">REST API Reference for DeleteSlotType Operation</seealso>
        DeleteSlotTypeResponse DeleteSlotType(DeleteSlotTypeRequest request);



        /// <summary>
        /// Deletes all versions of the slot type, including the <code>$LATEST</code> version.
        /// To delete a specific version of the slot type, use the <a>DeleteSlotTypeVersion</a>
        /// operation.
        /// 
        ///  
        /// <para>
        ///  You can delete a version of a slot type only if it is not referenced. To delete a
        /// slot type that is referred to in one or more intents, you must remove those references
        /// first. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you get the <code>ResourceInUseException</code> exception, the exception provides
        /// an example reference that shows the intent where the slot type is referenced. To remove
        /// the reference to the slot type, either update the intent or delete it. If you get
        /// the same exception when you attempt to delete the slot type again, repeat until the
        /// slot type has no references and the <code>DeleteSlotType</code> call is successful.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permission for the <code>lex:DeleteSlotType</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlotType service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotType">REST API Reference for DeleteSlotType Operation</seealso>
        Task<DeleteSlotTypeResponse> DeleteSlotTypeAsync(DeleteSlotTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSlotTypeVersion


        /// <summary>
        /// Deletes a specific version of a slot type. To delete all versions of a slot type,
        /// use the <a>DeleteSlotType</a> operation. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:DeleteSlotTypeVersion</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotTypeVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteSlotTypeVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotTypeVersion">REST API Reference for DeleteSlotTypeVersion Operation</seealso>
        DeleteSlotTypeVersionResponse DeleteSlotTypeVersion(DeleteSlotTypeVersionRequest request);



        /// <summary>
        /// Deletes a specific version of a slot type. To delete all versions of a slot type,
        /// use the <a>DeleteSlotType</a> operation. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:DeleteSlotTypeVersion</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotTypeVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlotTypeVersion service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ResourceInUseException">
        /// The resource that you are attempting to delete is referred to by another resource.
        /// Use this information to remove references to the resource that you are trying to delete.
        /// 
        ///  
        /// <para>
        /// The body of the exception contains a JSON object that describes the resource.
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"resourceReference": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"name": <i>string</i>, "version": <i>string</i> } }</code> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotTypeVersion">REST API Reference for DeleteSlotTypeVersion Operation</seealso>
        Task<DeleteSlotTypeVersionResponse> DeleteSlotTypeVersionAsync(DeleteSlotTypeVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUtterances


        /// <summary>
        /// Deletes stored utterances.
        /// 
        ///  
        /// <para>
        /// Amazon Lex stores the utterances that users send to your bot. Utterances are stored
        /// for 15 days for use with the <a>GetUtterancesView</a> operation, and then stored indefinitely
        /// for use in improving the ability of your bot to respond to user input.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>DeleteUtterances</code> operation to manually delete stored utterances
        /// for a specific user. When you use the <code>DeleteUtterances</code> operation, utterances
        /// stored for improving your bot's ability to respond to user input are deleted immediately.
        /// Utterances stored for use with the <code>GetUtterancesView</code> operation are deleted
        /// after 15 days.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:DeleteUtterances</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUtterances service method.</param>
        /// 
        /// <returns>The response from the DeleteUtterances service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteUtterances">REST API Reference for DeleteUtterances Operation</seealso>
        DeleteUtterancesResponse DeleteUtterances(DeleteUtterancesRequest request);



        /// <summary>
        /// Deletes stored utterances.
        /// 
        ///  
        /// <para>
        /// Amazon Lex stores the utterances that users send to your bot. Utterances are stored
        /// for 15 days for use with the <a>GetUtterancesView</a> operation, and then stored indefinitely
        /// for use in improving the ability of your bot to respond to user input.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>DeleteUtterances</code> operation to manually delete stored utterances
        /// for a specific user. When you use the <code>DeleteUtterances</code> operation, utterances
        /// stored for improving your bot's ability to respond to user input are deleted immediately.
        /// Utterances stored for use with the <code>GetUtterancesView</code> operation are deleted
        /// after 15 days.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:DeleteUtterances</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUtterances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUtterances service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteUtterances">REST API Reference for DeleteUtterances Operation</seealso>
        Task<DeleteUtterancesResponse> DeleteUtterancesAsync(DeleteUtterancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBot


        /// <summary>
        /// Returns metadata information for a specific bot. You must provide the bot name and
        /// the bot version or alias. 
        /// 
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>lex:GetBot</code> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBot service method.</param>
        /// 
        /// <returns>The response from the GetBot service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBot">REST API Reference for GetBot Operation</seealso>
        GetBotResponse GetBot(GetBotRequest request);



        /// <summary>
        /// Returns metadata information for a specific bot. You must provide the bot name and
        /// the bot version or alias. 
        /// 
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>lex:GetBot</code> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBot service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBot">REST API Reference for GetBot Operation</seealso>
        Task<GetBotResponse> GetBotAsync(GetBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBotAlias


        /// <summary>
        /// Returns information about an Amazon Lex bot alias. For more information about aliases,
        /// see <a>versioning-aliases</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetBotAlias</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotAlias service method.</param>
        /// 
        /// <returns>The response from the GetBotAlias service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotAlias">REST API Reference for GetBotAlias Operation</seealso>
        GetBotAliasResponse GetBotAlias(GetBotAliasRequest request);



        /// <summary>
        /// Returns information about an Amazon Lex bot alias. For more information about aliases,
        /// see <a>versioning-aliases</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetBotAlias</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBotAlias service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotAlias">REST API Reference for GetBotAlias Operation</seealso>
        Task<GetBotAliasResponse> GetBotAliasAsync(GetBotAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBotAliases


        /// <summary>
        /// Returns a list of aliases for a specified Amazon Lex bot.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetBotAliases</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotAliases service method.</param>
        /// 
        /// <returns>The response from the GetBotAliases service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotAliases">REST API Reference for GetBotAliases Operation</seealso>
        GetBotAliasesResponse GetBotAliases(GetBotAliasesRequest request);



        /// <summary>
        /// Returns a list of aliases for a specified Amazon Lex bot.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetBotAliases</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBotAliases service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotAliases">REST API Reference for GetBotAliases Operation</seealso>
        Task<GetBotAliasesResponse> GetBotAliasesAsync(GetBotAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBotChannelAssociation


        /// <summary>
        /// Returns information about the association between an Amazon Lex bot and a messaging
        /// platform.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetBotChannelAssociation</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotChannelAssociation service method.</param>
        /// 
        /// <returns>The response from the GetBotChannelAssociation service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotChannelAssociation">REST API Reference for GetBotChannelAssociation Operation</seealso>
        GetBotChannelAssociationResponse GetBotChannelAssociation(GetBotChannelAssociationRequest request);



        /// <summary>
        /// Returns information about the association between an Amazon Lex bot and a messaging
        /// platform.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetBotChannelAssociation</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotChannelAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBotChannelAssociation service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotChannelAssociation">REST API Reference for GetBotChannelAssociation Operation</seealso>
        Task<GetBotChannelAssociationResponse> GetBotChannelAssociationAsync(GetBotChannelAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBotChannelAssociations


        /// <summary>
        /// Returns a list of all of the channels associated with the specified bot. 
        /// 
        ///  
        /// <para>
        /// The <code>GetBotChannelAssociations</code> operation requires permissions for the
        /// <code>lex:GetBotChannelAssociations</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotChannelAssociations service method.</param>
        /// 
        /// <returns>The response from the GetBotChannelAssociations service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotChannelAssociations">REST API Reference for GetBotChannelAssociations Operation</seealso>
        GetBotChannelAssociationsResponse GetBotChannelAssociations(GetBotChannelAssociationsRequest request);



        /// <summary>
        /// Returns a list of all of the channels associated with the specified bot. 
        /// 
        ///  
        /// <para>
        /// The <code>GetBotChannelAssociations</code> operation requires permissions for the
        /// <code>lex:GetBotChannelAssociations</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotChannelAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBotChannelAssociations service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotChannelAssociations">REST API Reference for GetBotChannelAssociations Operation</seealso>
        Task<GetBotChannelAssociationsResponse> GetBotChannelAssociationsAsync(GetBotChannelAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBots


        /// <summary>
        /// Returns bot information as follows: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If you provide the <code>nameContains</code> field, the response includes information
        /// for the <code>$LATEST</code> version of all bots whose name contains the specified
        /// string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify the <code>nameContains</code> field, the operation returns information
        /// about the <code>$LATEST</code> version of all of your bots.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation requires permission for the <code>lex:GetBots</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBots service method.</param>
        /// 
        /// <returns>The response from the GetBots service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBots">REST API Reference for GetBots Operation</seealso>
        GetBotsResponse GetBots(GetBotsRequest request);



        /// <summary>
        /// Returns bot information as follows: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If you provide the <code>nameContains</code> field, the response includes information
        /// for the <code>$LATEST</code> version of all bots whose name contains the specified
        /// string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify the <code>nameContains</code> field, the operation returns information
        /// about the <code>$LATEST</code> version of all of your bots.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation requires permission for the <code>lex:GetBots</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBots service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBots">REST API Reference for GetBots Operation</seealso>
        Task<GetBotsResponse> GetBotsAsync(GetBotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBotVersions


        /// <summary>
        /// Gets information about all of the versions of a bot.
        /// 
        ///  
        /// <para>
        /// The <code>GetBotVersions</code> operation returns a <code>BotMetadata</code> object
        /// for each version of a bot. For example, if a bot has three numbered versions, the
        /// <code>GetBotVersions</code> operation returns four <code>BotMetadata</code> objects
        /// in the response, one for each numbered version and one for the <code>$LATEST</code>
        /// version. 
        /// </para>
        ///  
        /// <para>
        /// The <code>GetBotVersions</code> operation always returns at least one version, the
        /// <code>$LATEST</code> version.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetBotVersions</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotVersions service method.</param>
        /// 
        /// <returns>The response from the GetBotVersions service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotVersions">REST API Reference for GetBotVersions Operation</seealso>
        GetBotVersionsResponse GetBotVersions(GetBotVersionsRequest request);



        /// <summary>
        /// Gets information about all of the versions of a bot.
        /// 
        ///  
        /// <para>
        /// The <code>GetBotVersions</code> operation returns a <code>BotMetadata</code> object
        /// for each version of a bot. For example, if a bot has three numbered versions, the
        /// <code>GetBotVersions</code> operation returns four <code>BotMetadata</code> objects
        /// in the response, one for each numbered version and one for the <code>$LATEST</code>
        /// version. 
        /// </para>
        ///  
        /// <para>
        /// The <code>GetBotVersions</code> operation always returns at least one version, the
        /// <code>$LATEST</code> version.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetBotVersions</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBotVersions service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotVersions">REST API Reference for GetBotVersions Operation</seealso>
        Task<GetBotVersionsResponse> GetBotVersionsAsync(GetBotVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBuiltinIntent


        /// <summary>
        /// Returns information about a built-in intent.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lex:GetBuiltinIntent</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinIntent service method.</param>
        /// 
        /// <returns>The response from the GetBuiltinIntent service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinIntent">REST API Reference for GetBuiltinIntent Operation</seealso>
        GetBuiltinIntentResponse GetBuiltinIntent(GetBuiltinIntentRequest request);



        /// <summary>
        /// Returns information about a built-in intent.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lex:GetBuiltinIntent</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBuiltinIntent service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinIntent">REST API Reference for GetBuiltinIntent Operation</seealso>
        Task<GetBuiltinIntentResponse> GetBuiltinIntentAsync(GetBuiltinIntentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBuiltinIntents


        /// <summary>
        /// Gets a list of built-in intents that meet the specified criteria.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lex:GetBuiltinIntents</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinIntents service method.</param>
        /// 
        /// <returns>The response from the GetBuiltinIntents service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinIntents">REST API Reference for GetBuiltinIntents Operation</seealso>
        GetBuiltinIntentsResponse GetBuiltinIntents(GetBuiltinIntentsRequest request);



        /// <summary>
        /// Gets a list of built-in intents that meet the specified criteria.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lex:GetBuiltinIntents</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinIntents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBuiltinIntents service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinIntents">REST API Reference for GetBuiltinIntents Operation</seealso>
        Task<GetBuiltinIntentsResponse> GetBuiltinIntentsAsync(GetBuiltinIntentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBuiltinSlotTypes


        /// <summary>
        /// Gets a list of built-in slot types that meet the specified criteria.
        /// 
        ///  
        /// <para>
        /// For a list of built-in slot types, see <a href="https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/slot-type-reference">Slot
        /// Type Reference</a> in the <i>Alexa Skills Kit</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lex:GetBuiltInSlotTypes</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinSlotTypes service method.</param>
        /// 
        /// <returns>The response from the GetBuiltinSlotTypes service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinSlotTypes">REST API Reference for GetBuiltinSlotTypes Operation</seealso>
        GetBuiltinSlotTypesResponse GetBuiltinSlotTypes(GetBuiltinSlotTypesRequest request);



        /// <summary>
        /// Gets a list of built-in slot types that meet the specified criteria.
        /// 
        ///  
        /// <para>
        /// For a list of built-in slot types, see <a href="https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/slot-type-reference">Slot
        /// Type Reference</a> in the <i>Alexa Skills Kit</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lex:GetBuiltInSlotTypes</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinSlotTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBuiltinSlotTypes service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinSlotTypes">REST API Reference for GetBuiltinSlotTypes Operation</seealso>
        Task<GetBuiltinSlotTypesResponse> GetBuiltinSlotTypesAsync(GetBuiltinSlotTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetExport


        /// <summary>
        /// Exports the contents of a Amazon Lex resource in a specified format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExport service method.</param>
        /// 
        /// <returns>The response from the GetExport service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetExport">REST API Reference for GetExport Operation</seealso>
        GetExportResponse GetExport(GetExportRequest request);



        /// <summary>
        /// Exports the contents of a Amazon Lex resource in a specified format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExport service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetExport">REST API Reference for GetExport Operation</seealso>
        Task<GetExportResponse> GetExportAsync(GetExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetImport


        /// <summary>
        /// Gets information about an import job started with the <code>StartImport</code> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImport service method.</param>
        /// 
        /// <returns>The response from the GetImport service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetImport">REST API Reference for GetImport Operation</seealso>
        GetImportResponse GetImport(GetImportRequest request);



        /// <summary>
        /// Gets information about an import job started with the <code>StartImport</code> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImport service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetImport">REST API Reference for GetImport Operation</seealso>
        Task<GetImportResponse> GetImportAsync(GetImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIntent


        /// <summary>
        /// Returns information about an intent. In addition to the intent name, you must specify
        /// the intent version. 
        /// 
        ///  
        /// <para>
        ///  This operation requires permissions to perform the <code>lex:GetIntent</code> action.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntent service method.</param>
        /// 
        /// <returns>The response from the GetIntent service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntent">REST API Reference for GetIntent Operation</seealso>
        GetIntentResponse GetIntent(GetIntentRequest request);



        /// <summary>
        /// Returns information about an intent. In addition to the intent name, you must specify
        /// the intent version. 
        /// 
        ///  
        /// <para>
        ///  This operation requires permissions to perform the <code>lex:GetIntent</code> action.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntent service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntent">REST API Reference for GetIntent Operation</seealso>
        Task<GetIntentResponse> GetIntentAsync(GetIntentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIntents


        /// <summary>
        /// Returns intent information as follows: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If you specify the <code>nameContains</code> field, returns the <code>$LATEST</code>
        /// version of all intents that contain the specified string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you don't specify the <code>nameContains</code> field, returns information about
        /// the <code>$LATEST</code> version of all intents. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  The operation requires permission for the <code>lex:GetIntents</code> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntents service method.</param>
        /// 
        /// <returns>The response from the GetIntents service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntents">REST API Reference for GetIntents Operation</seealso>
        GetIntentsResponse GetIntents(GetIntentsRequest request);



        /// <summary>
        /// Returns intent information as follows: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If you specify the <code>nameContains</code> field, returns the <code>$LATEST</code>
        /// version of all intents that contain the specified string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you don't specify the <code>nameContains</code> field, returns information about
        /// the <code>$LATEST</code> version of all intents. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  The operation requires permission for the <code>lex:GetIntents</code> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntents service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntents">REST API Reference for GetIntents Operation</seealso>
        Task<GetIntentsResponse> GetIntentsAsync(GetIntentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIntentVersions


        /// <summary>
        /// Gets information about all of the versions of an intent.
        /// 
        ///  
        /// <para>
        /// The <code>GetIntentVersions</code> operation returns an <code>IntentMetadata</code>
        /// object for each version of an intent. For example, if an intent has three numbered
        /// versions, the <code>GetIntentVersions</code> operation returns four <code>IntentMetadata</code>
        /// objects in the response, one for each numbered version and one for the <code>$LATEST</code>
        /// version. 
        /// </para>
        ///  
        /// <para>
        /// The <code>GetIntentVersions</code> operation always returns at least one version,
        /// the <code>$LATEST</code> version.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetIntentVersions</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntentVersions service method.</param>
        /// 
        /// <returns>The response from the GetIntentVersions service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntentVersions">REST API Reference for GetIntentVersions Operation</seealso>
        GetIntentVersionsResponse GetIntentVersions(GetIntentVersionsRequest request);



        /// <summary>
        /// Gets information about all of the versions of an intent.
        /// 
        ///  
        /// <para>
        /// The <code>GetIntentVersions</code> operation returns an <code>IntentMetadata</code>
        /// object for each version of an intent. For example, if an intent has three numbered
        /// versions, the <code>GetIntentVersions</code> operation returns four <code>IntentMetadata</code>
        /// objects in the response, one for each numbered version and one for the <code>$LATEST</code>
        /// version. 
        /// </para>
        ///  
        /// <para>
        /// The <code>GetIntentVersions</code> operation always returns at least one version,
        /// the <code>$LATEST</code> version.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetIntentVersions</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntentVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntentVersions service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntentVersions">REST API Reference for GetIntentVersions Operation</seealso>
        Task<GetIntentVersionsResponse> GetIntentVersionsAsync(GetIntentVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSlotType


        /// <summary>
        /// Returns information about a specific version of a slot type. In addition to specifying
        /// the slot type name, you must specify the slot type version.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetSlotType</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSlotType service method.</param>
        /// 
        /// <returns>The response from the GetSlotType service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotType">REST API Reference for GetSlotType Operation</seealso>
        GetSlotTypeResponse GetSlotType(GetSlotTypeRequest request);



        /// <summary>
        /// Returns information about a specific version of a slot type. In addition to specifying
        /// the slot type name, you must specify the slot type version.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetSlotType</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSlotType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSlotType service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotType">REST API Reference for GetSlotType Operation</seealso>
        Task<GetSlotTypeResponse> GetSlotTypeAsync(GetSlotTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSlotTypes


        /// <summary>
        /// Returns slot type information as follows: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If you specify the <code>nameContains</code> field, returns the <code>$LATEST</code>
        /// version of all slot types that contain the specified string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you don't specify the <code>nameContains</code> field, returns information about
        /// the <code>$LATEST</code> version of all slot types. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  The operation requires permission for the <code>lex:GetSlotTypes</code> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSlotTypes service method.</param>
        /// 
        /// <returns>The response from the GetSlotTypes service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotTypes">REST API Reference for GetSlotTypes Operation</seealso>
        GetSlotTypesResponse GetSlotTypes(GetSlotTypesRequest request);



        /// <summary>
        /// Returns slot type information as follows: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If you specify the <code>nameContains</code> field, returns the <code>$LATEST</code>
        /// version of all slot types that contain the specified string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you don't specify the <code>nameContains</code> field, returns information about
        /// the <code>$LATEST</code> version of all slot types. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  The operation requires permission for the <code>lex:GetSlotTypes</code> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSlotTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSlotTypes service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotTypes">REST API Reference for GetSlotTypes Operation</seealso>
        Task<GetSlotTypesResponse> GetSlotTypesAsync(GetSlotTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSlotTypeVersions


        /// <summary>
        /// Gets information about all versions of a slot type.
        /// 
        ///  
        /// <para>
        /// The <code>GetSlotTypeVersions</code> operation returns a <code>SlotTypeMetadata</code>
        /// object for each version of a slot type. For example, if a slot type has three numbered
        /// versions, the <code>GetSlotTypeVersions</code> operation returns four <code>SlotTypeMetadata</code>
        /// objects in the response, one for each numbered version and one for the <code>$LATEST</code>
        /// version. 
        /// </para>
        ///  
        /// <para>
        /// The <code>GetSlotTypeVersions</code> operation always returns at least one version,
        /// the <code>$LATEST</code> version.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetSlotTypeVersions</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSlotTypeVersions service method.</param>
        /// 
        /// <returns>The response from the GetSlotTypeVersions service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotTypeVersions">REST API Reference for GetSlotTypeVersions Operation</seealso>
        GetSlotTypeVersionsResponse GetSlotTypeVersions(GetSlotTypeVersionsRequest request);



        /// <summary>
        /// Gets information about all versions of a slot type.
        /// 
        ///  
        /// <para>
        /// The <code>GetSlotTypeVersions</code> operation returns a <code>SlotTypeMetadata</code>
        /// object for each version of a slot type. For example, if a slot type has three numbered
        /// versions, the <code>GetSlotTypeVersions</code> operation returns four <code>SlotTypeMetadata</code>
        /// objects in the response, one for each numbered version and one for the <code>$LATEST</code>
        /// version. 
        /// </para>
        ///  
        /// <para>
        /// The <code>GetSlotTypeVersions</code> operation always returns at least one version,
        /// the <code>$LATEST</code> version.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetSlotTypeVersions</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSlotTypeVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSlotTypeVersions service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotTypeVersions">REST API Reference for GetSlotTypeVersions Operation</seealso>
        Task<GetSlotTypeVersionsResponse> GetSlotTypeVersionsAsync(GetSlotTypeVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUtterancesView


        /// <summary>
        /// Use the <code>GetUtterancesView</code> operation to get information about the utterances
        /// that your users have made to your bot. You can use this list to tune the utterances
        /// that your bot responds to.
        /// 
        ///  
        /// <para>
        /// For example, say that you have created a bot to order flowers. After your users have
        /// used your bot for a while, use the <code>GetUtterancesView</code> operation to see
        /// the requests that they have made and whether they have been successful. You might
        /// find that the utterance "I want flowers" is not being recognized. You could add this
        /// utterance to the <code>OrderFlowers</code> intent so that your bot recognizes that
        /// utterance.
        /// </para>
        ///  
        /// <para>
        /// After you publish a new version of a bot, you can get information about the old version
        /// and the new so that you can compare the performance across the two versions. 
        /// </para>
        ///  
        /// <para>
        /// Utterance statistics are generated once a day. Data is available for the last 15 days.
        /// You can request information for up to 5 versions of your bot in each request. Amazon
        /// Lex returns the most frequent utterances received by the bot in the last 15 days.
        /// The response contains information about a maximum of 100 utterances for each version.
        /// </para>
        ///  
        /// <para>
        /// If you set <code>childDirected</code> field to true when you created your bot, or
        /// if you opted out of participating in improving Amazon Lex, utterances are not available.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetUtterancesView</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUtterancesView service method.</param>
        /// 
        /// <returns>The response from the GetUtterancesView service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetUtterancesView">REST API Reference for GetUtterancesView Operation</seealso>
        GetUtterancesViewResponse GetUtterancesView(GetUtterancesViewRequest request);



        /// <summary>
        /// Use the <code>GetUtterancesView</code> operation to get information about the utterances
        /// that your users have made to your bot. You can use this list to tune the utterances
        /// that your bot responds to.
        /// 
        ///  
        /// <para>
        /// For example, say that you have created a bot to order flowers. After your users have
        /// used your bot for a while, use the <code>GetUtterancesView</code> operation to see
        /// the requests that they have made and whether they have been successful. You might
        /// find that the utterance "I want flowers" is not being recognized. You could add this
        /// utterance to the <code>OrderFlowers</code> intent so that your bot recognizes that
        /// utterance.
        /// </para>
        ///  
        /// <para>
        /// After you publish a new version of a bot, you can get information about the old version
        /// and the new so that you can compare the performance across the two versions. 
        /// </para>
        ///  
        /// <para>
        /// Utterance statistics are generated once a day. Data is available for the last 15 days.
        /// You can request information for up to 5 versions of your bot in each request. Amazon
        /// Lex returns the most frequent utterances received by the bot in the last 15 days.
        /// The response contains information about a maximum of 100 utterances for each version.
        /// </para>
        ///  
        /// <para>
        /// If you set <code>childDirected</code> field to true when you created your bot, or
        /// if you opted out of participating in improving Amazon Lex, utterances are not available.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:GetUtterancesView</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUtterancesView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUtterancesView service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetUtterancesView">REST API Reference for GetUtterancesView Operation</seealso>
        Task<GetUtterancesViewResponse> GetUtterancesViewAsync(GetUtterancesViewRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets a list of tags associated with the specified resource. Only bots, bot aliases,
        /// and bot channels can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Gets a list of tags associated with the specified resource. Only bots, bot aliases,
        /// and bot channels can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutBot


        /// <summary>
        /// Creates an Amazon Lex conversational bot or replaces an existing bot. When you create
        /// or update a bot you are only required to specify a name, a locale, and whether the
        /// bot is directed toward children under age 13. You can use this to add intents later,
        /// or to remove intents from an existing bot. When you create a bot with the minimum
        /// information, the bot is created or updated but Amazon Lex returns the <code/> response
        /// <code>FAILED</code>. You can build the bot after you add one or more intents. For
        /// more information about Amazon Lex bots, see <a>how-it-works</a>. 
        /// 
        ///  
        /// <para>
        /// If you specify the name of an existing bot, the fields in the request replace the
        /// existing values in the <code>$LATEST</code> version of the bot. Amazon Lex removes
        /// any fields that you don't provide values for in the request, except for the <code>idleTTLInSeconds</code>
        /// and <code>privacySettings</code> fields, which are set to their default values. If
        /// you don't specify values for required fields, Amazon Lex throws an exception.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:PutBot</code> action. For more
        /// information, see <a>security-iam</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBot service method.</param>
        /// 
        /// <returns>The response from the PutBot service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutBot">REST API Reference for PutBot Operation</seealso>
        PutBotResponse PutBot(PutBotRequest request);



        /// <summary>
        /// Creates an Amazon Lex conversational bot or replaces an existing bot. When you create
        /// or update a bot you are only required to specify a name, a locale, and whether the
        /// bot is directed toward children under age 13. You can use this to add intents later,
        /// or to remove intents from an existing bot. When you create a bot with the minimum
        /// information, the bot is created or updated but Amazon Lex returns the <code/> response
        /// <code>FAILED</code>. You can build the bot after you add one or more intents. For
        /// more information about Amazon Lex bots, see <a>how-it-works</a>. 
        /// 
        ///  
        /// <para>
        /// If you specify the name of an existing bot, the fields in the request replace the
        /// existing values in the <code>$LATEST</code> version of the bot. Amazon Lex removes
        /// any fields that you don't provide values for in the request, except for the <code>idleTTLInSeconds</code>
        /// and <code>privacySettings</code> fields, which are set to their default values. If
        /// you don't specify values for required fields, Amazon Lex throws an exception.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:PutBot</code> action. For more
        /// information, see <a>security-iam</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBot service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutBot">REST API Reference for PutBot Operation</seealso>
        Task<PutBotResponse> PutBotAsync(PutBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutBotAlias


        /// <summary>
        /// Creates an alias for the specified version of the bot or replaces an alias for the
        /// specified bot. To change the version of the bot that the alias points to, replace
        /// the alias. For more information about aliases, see <a>versioning-aliases</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:PutBotAlias</code> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBotAlias service method.</param>
        /// 
        /// <returns>The response from the PutBotAlias service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutBotAlias">REST API Reference for PutBotAlias Operation</seealso>
        PutBotAliasResponse PutBotAlias(PutBotAliasRequest request);



        /// <summary>
        /// Creates an alias for the specified version of the bot or replaces an alias for the
        /// specified bot. To change the version of the bot that the alias points to, replace
        /// the alias. For more information about aliases, see <a>versioning-aliases</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:PutBotAlias</code> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBotAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBotAlias service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutBotAlias">REST API Reference for PutBotAlias Operation</seealso>
        Task<PutBotAliasResponse> PutBotAliasAsync(PutBotAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutIntent


        /// <summary>
        /// Creates an intent or replaces an existing intent.
        /// 
        ///  
        /// <para>
        /// To define the interaction between the user and your bot, you use one or more intents.
        /// For a pizza ordering bot, for example, you would create an <code>OrderPizza</code>
        /// intent. 
        /// </para>
        ///  
        /// <para>
        /// To create an intent or replace an existing intent, you must provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Intent name. For example, <code>OrderPizza</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sample utterances. For example, "Can I order a pizza, please." and "I want to order
        /// a pizza."
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Information to be gathered. You specify slot types for the information that your bot
        /// will request from the user. You can specify standard slot types, such as a date or
        /// a time, or custom slot types such as the size and crust of a pizza.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// How the intent will be fulfilled. You can provide a Lambda function or configure the
        /// intent to return the intent information to the client application. If you use a Lambda
        /// function, when all of the intent information is available, Amazon Lex invokes your
        /// Lambda function. If you configure your intent to return the intent information to
        /// the client application. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify other optional information in the request, such as:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A confirmation prompt to ask the user to confirm an intent. For example, "Shall I
        /// order your pizza?"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A conclusion statement to send to the user after the intent has been fulfilled. For
        /// example, "I placed your pizza order."
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A follow-up prompt that asks the user for additional activity. For example, asking
        /// "Do you want to order a drink with your pizza?"
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify an existing intent name to update the intent, Amazon Lex replaces the
        /// values in the <code>$LATEST</code> version of the intent with the values in the request.
        /// Amazon Lex removes fields that you don't provide in the request. If you don't specify
        /// the required fields, Amazon Lex throws an exception. When you update the <code>$LATEST</code>
        /// version of an intent, the <code>status</code> field of any bot that uses the <code>$LATEST</code>
        /// version of the intent is set to <code>NOT_BUILT</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>how-it-works</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:PutIntent</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntent service method.</param>
        /// 
        /// <returns>The response from the PutIntent service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutIntent">REST API Reference for PutIntent Operation</seealso>
        PutIntentResponse PutIntent(PutIntentRequest request);



        /// <summary>
        /// Creates an intent or replaces an existing intent.
        /// 
        ///  
        /// <para>
        /// To define the interaction between the user and your bot, you use one or more intents.
        /// For a pizza ordering bot, for example, you would create an <code>OrderPizza</code>
        /// intent. 
        /// </para>
        ///  
        /// <para>
        /// To create an intent or replace an existing intent, you must provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Intent name. For example, <code>OrderPizza</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sample utterances. For example, "Can I order a pizza, please." and "I want to order
        /// a pizza."
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Information to be gathered. You specify slot types for the information that your bot
        /// will request from the user. You can specify standard slot types, such as a date or
        /// a time, or custom slot types such as the size and crust of a pizza.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// How the intent will be fulfilled. You can provide a Lambda function or configure the
        /// intent to return the intent information to the client application. If you use a Lambda
        /// function, when all of the intent information is available, Amazon Lex invokes your
        /// Lambda function. If you configure your intent to return the intent information to
        /// the client application. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify other optional information in the request, such as:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A confirmation prompt to ask the user to confirm an intent. For example, "Shall I
        /// order your pizza?"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A conclusion statement to send to the user after the intent has been fulfilled. For
        /// example, "I placed your pizza order."
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A follow-up prompt that asks the user for additional activity. For example, asking
        /// "Do you want to order a drink with your pizza?"
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify an existing intent name to update the intent, Amazon Lex replaces the
        /// values in the <code>$LATEST</code> version of the intent with the values in the request.
        /// Amazon Lex removes fields that you don't provide in the request. If you don't specify
        /// the required fields, Amazon Lex throws an exception. When you update the <code>$LATEST</code>
        /// version of an intent, the <code>status</code> field of any bot that uses the <code>$LATEST</code>
        /// version of the intent is set to <code>NOT_BUILT</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>how-it-works</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:PutIntent</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutIntent service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutIntent">REST API Reference for PutIntent Operation</seealso>
        Task<PutIntentResponse> PutIntentAsync(PutIntentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutSlotType


        /// <summary>
        /// Creates a custom slot type or replaces an existing custom slot type.
        /// 
        ///  
        /// <para>
        /// To create a custom slot type, specify a name for the slot type and a set of enumeration
        /// values, which are the values that a slot of this type can assume. For more information,
        /// see <a>how-it-works</a>.
        /// </para>
        ///  
        /// <para>
        /// If you specify the name of an existing slot type, the fields in the request replace
        /// the existing values in the <code>$LATEST</code> version of the slot type. Amazon Lex
        /// removes the fields that you don't provide in the request. If you don't specify required
        /// fields, Amazon Lex throws an exception. When you update the <code>$LATEST</code> version
        /// of a slot type, if a bot uses the <code>$LATEST</code> version of an intent that contains
        /// the slot type, the bot's <code>status</code> field is set to <code>NOT_BUILT</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:PutSlotType</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSlotType service method.</param>
        /// 
        /// <returns>The response from the PutSlotType service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutSlotType">REST API Reference for PutSlotType Operation</seealso>
        PutSlotTypeResponse PutSlotType(PutSlotTypeRequest request);



        /// <summary>
        /// Creates a custom slot type or replaces an existing custom slot type.
        /// 
        ///  
        /// <para>
        /// To create a custom slot type, specify a name for the slot type and a set of enumeration
        /// values, which are the values that a slot of this type can assume. For more information,
        /// see <a>how-it-works</a>.
        /// </para>
        ///  
        /// <para>
        /// If you specify the name of an existing slot type, the fields in the request replace
        /// the existing values in the <code>$LATEST</code> version of the slot type. Amazon Lex
        /// removes the fields that you don't provide in the request. If you don't specify required
        /// fields, Amazon Lex throws an exception. When you update the <code>$LATEST</code> version
        /// of a slot type, if a bot uses the <code>$LATEST</code> version of an intent that contains
        /// the slot type, the bot's <code>status</code> field is set to <code>NOT_BUILT</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:PutSlotType</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSlotType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSlotType service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.PreconditionFailedException">
        /// The checksum of the resource that you are trying to change does not match the checksum
        /// in the request. Check the resource's checksum and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutSlotType">REST API Reference for PutSlotType Operation</seealso>
        Task<PutSlotTypeResponse> PutSlotTypeAsync(PutSlotTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartImport


        /// <summary>
        /// Starts a job to import a resource to Amazon Lex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// 
        /// <returns>The response from the StartImport service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/StartImport">REST API Reference for StartImport Operation</seealso>
        StartImportResponse StartImport(StartImportRequest request);



        /// <summary>
        /// Starts a job to import a resource to Amazon Lex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImport service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/StartImport">REST API Reference for StartImport Operation</seealso>
        Task<StartImportResponse> StartImportAsync(StartImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource. If a tag key already exists, the
        /// existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>The response from the TagResource service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a bot, bot alias or bot channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a bot, bot alias or bot channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.InternalFailureException">
        /// An internal Amazon Lex error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LexModelBuildingService.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}