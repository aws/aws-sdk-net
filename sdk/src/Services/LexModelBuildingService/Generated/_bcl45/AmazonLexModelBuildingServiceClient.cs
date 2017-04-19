/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.LexModelBuildingService.Model;
using Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.LexModelBuildingService
{
    /// <summary>
    /// Implementation for accessing LexModelBuildingService
    ///
    /// Amazon Lex Build-Time Actions 
    /// <para>
    ///  Amazon Lex is an AWS service for building conversational voice and text interfaces.
    /// Use these actions to create, update, and delete conversational bots for new and existing
    /// client applications. 
    /// </para>
    /// </summary>
    public partial class AmazonLexModelBuildingServiceClient : AmazonServiceClient, IAmazonLexModelBuildingService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonLexModelBuildingServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLexModelBuildingServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonLexModelBuildingServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLexModelBuildingServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonLexModelBuildingServiceClient Configuration Object</param>
        public AmazonLexModelBuildingServiceClient(AmazonLexModelBuildingServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLexModelBuildingServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonLexModelBuildingServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexModelBuildingServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLexModelBuildingServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with AWS Credentials and an
        /// AmazonLexModelBuildingServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLexModelBuildingServiceClient Configuration Object</param>
        public AmazonLexModelBuildingServiceClient(AWSCredentials credentials, AmazonLexModelBuildingServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLexModelBuildingServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLexModelBuildingServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexModelBuildingServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLexModelBuildingServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLexModelBuildingServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLexModelBuildingServiceClient Configuration Object</param>
        public AmazonLexModelBuildingServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLexModelBuildingServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLexModelBuildingServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLexModelBuildingServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexModelBuildingServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLexModelBuildingServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexModelBuildingServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLexModelBuildingServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLexModelBuildingServiceClient Configuration Object</param>
        public AmazonLexModelBuildingServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLexModelBuildingServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
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
        public CreateBotVersionResponse CreateBotVersion(CreateBotVersionRequest request)
        {
            var marshaller = new CreateBotVersionRequestMarshaller();
            var unmarshaller = CreateBotVersionResponseUnmarshaller.Instance;

            return Invoke<CreateBotVersionRequest,CreateBotVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBotVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBotVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateBotVersion">REST API Reference for CreateBotVersion Operation</seealso>
        public Task<CreateBotVersionResponse> CreateBotVersionAsync(CreateBotVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateBotVersionRequestMarshaller();
            var unmarshaller = CreateBotVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBotVersionRequest,CreateBotVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateIntentVersionResponse CreateIntentVersion(CreateIntentVersionRequest request)
        {
            var marshaller = new CreateIntentVersionRequestMarshaller();
            var unmarshaller = CreateIntentVersionResponseUnmarshaller.Instance;

            return Invoke<CreateIntentVersionRequest,CreateIntentVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntentVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateIntentVersion">REST API Reference for CreateIntentVersion Operation</seealso>
        public Task<CreateIntentVersionResponse> CreateIntentVersionAsync(CreateIntentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateIntentVersionRequestMarshaller();
            var unmarshaller = CreateIntentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntentVersionRequest,CreateIntentVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateSlotTypeVersionResponse CreateSlotTypeVersion(CreateSlotTypeVersionRequest request)
        {
            var marshaller = new CreateSlotTypeVersionRequestMarshaller();
            var unmarshaller = CreateSlotTypeVersionResponseUnmarshaller.Instance;

            return Invoke<CreateSlotTypeVersionRequest,CreateSlotTypeVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSlotTypeVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSlotTypeVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateSlotTypeVersion">REST API Reference for CreateSlotTypeVersion Operation</seealso>
        public Task<CreateSlotTypeVersionResponse> CreateSlotTypeVersionAsync(CreateSlotTypeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSlotTypeVersionRequestMarshaller();
            var unmarshaller = CreateSlotTypeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSlotTypeVersionRequest,CreateSlotTypeVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBot


        /// <summary>
        /// Deletes a bot. If you specify a bot version in the request, the API deletes only the
        /// specified bot version. If you don't specify a version, the API deletes all versions
        /// of the bot, including the <code>$LATEST</code> version. 
        /// 
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
        public DeleteBotResponse DeleteBot(DeleteBotRequest request)
        {
            var marshaller = new DeleteBotRequestMarshaller();
            var unmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return Invoke<DeleteBotRequest,DeleteBotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        public Task<DeleteBotResponse> DeleteBotAsync(DeleteBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBotRequestMarshaller();
            var unmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotRequest,DeleteBotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteBotAliasResponse DeleteBotAlias(DeleteBotAliasRequest request)
        {
            var marshaller = new DeleteBotAliasRequestMarshaller();
            var unmarshaller = DeleteBotAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteBotAliasRequest,DeleteBotAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBotAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotAlias">REST API Reference for DeleteBotAlias Operation</seealso>
        public Task<DeleteBotAliasResponse> DeleteBotAliasAsync(DeleteBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBotAliasRequestMarshaller();
            var unmarshaller = DeleteBotAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotAliasRequest,DeleteBotAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteBotChannelAssociationResponse DeleteBotChannelAssociation(DeleteBotChannelAssociationRequest request)
        {
            var marshaller = new DeleteBotChannelAssociationRequestMarshaller();
            var unmarshaller = DeleteBotChannelAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteBotChannelAssociationRequest,DeleteBotChannelAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBotChannelAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotChannelAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotChannelAssociation">REST API Reference for DeleteBotChannelAssociation Operation</seealso>
        public Task<DeleteBotChannelAssociationResponse> DeleteBotChannelAssociationAsync(DeleteBotChannelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBotChannelAssociationRequestMarshaller();
            var unmarshaller = DeleteBotChannelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotChannelAssociationRequest,DeleteBotChannelAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntent


        /// <summary>
        /// Deletes an intent. If you specify a version in the request, the API deletes only the
        /// specified version of the intent. If you don't specify a version in the request, the
        /// API deletes all of the versions of the intent, including the <code>$LATEST</code>
        /// version. 
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
        public DeleteIntentResponse DeleteIntent(DeleteIntentRequest request)
        {
            var marshaller = new DeleteIntentRequestMarshaller();
            var unmarshaller = DeleteIntentResponseUnmarshaller.Instance;

            return Invoke<DeleteIntentRequest,DeleteIntentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntent">REST API Reference for DeleteIntent Operation</seealso>
        public Task<DeleteIntentResponse> DeleteIntentAsync(DeleteIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteIntentRequestMarshaller();
            var unmarshaller = DeleteIntentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntentRequest,DeleteIntentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSlotType


        /// <summary>
        /// Deletes a slot type. If you specify a version in the request, the API deletes the
        /// specific version. If you don't specify a version in the request, the API deletes all
        /// versions of the slot type, including the <code>$LATEST</code> version. 
        /// 
        ///  
        /// <para>
        ///  You can delete a version of a slot type only if it is not referenced. To delete a
        /// slot type that is referred to in one or more intents, you must remove those references
        /// first. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you get the <code>SlotTypeInUse</code> exception, the exception provides an example
        /// reference that shows the intent where the slot type is referenced. To remove the reference
        /// to the slot type, either update the intent or delete it. If you get the same exception
        /// when you attempt to delete the intent again, repeat until the intent has no references
        /// and the <code>DeleteSlotType</code> call is successful. 
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
        public DeleteSlotTypeResponse DeleteSlotType(DeleteSlotTypeRequest request)
        {
            var marshaller = new DeleteSlotTypeRequestMarshaller();
            var unmarshaller = DeleteSlotTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteSlotTypeRequest,DeleteSlotTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSlotType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotType">REST API Reference for DeleteSlotType Operation</seealso>
        public Task<DeleteSlotTypeResponse> DeleteSlotTypeAsync(DeleteSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSlotTypeRequestMarshaller();
            var unmarshaller = DeleteSlotTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSlotTypeRequest,DeleteSlotTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUtterances


        /// <summary>
        /// Deletes stored utterances.
        /// 
        ///  
        /// <para>
        /// When you create or update a bot using the operation, configure your bot to store user
        /// utterances by setting <code>privacySetting</code> to <code>STORE_UTTERANCES</code>.
        /// Use <code>DeleteUtterances</code> to remove the stored utterances for a specific user
        /// .
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
        public DeleteUtterancesResponse DeleteUtterances(DeleteUtterancesRequest request)
        {
            var marshaller = new DeleteUtterancesRequestMarshaller();
            var unmarshaller = DeleteUtterancesResponseUnmarshaller.Instance;

            return Invoke<DeleteUtterancesRequest,DeleteUtterancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUtterances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUtterances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteUtterances">REST API Reference for DeleteUtterances Operation</seealso>
        public Task<DeleteUtterancesResponse> DeleteUtterancesAsync(DeleteUtterancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteUtterancesRequestMarshaller();
            var unmarshaller = DeleteUtterancesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUtterancesRequest,DeleteUtterancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBot


        /// <summary>
        /// Returns metadata information for a specific bot. You must provide the bot name and
        /// the bot version or alias. 
        /// 
        ///  
        /// <para>
        ///  The GetBot operation requires permissions for the <code>lex:GetBot</code> action.
        /// 
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
        public GetBotResponse GetBot(GetBotRequest request)
        {
            var marshaller = new GetBotRequestMarshaller();
            var unmarshaller = GetBotResponseUnmarshaller.Instance;

            return Invoke<GetBotRequest,GetBotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBot">REST API Reference for GetBot Operation</seealso>
        public Task<GetBotResponse> GetBotAsync(GetBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBotRequestMarshaller();
            var unmarshaller = GetBotResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotRequest,GetBotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBotAlias


        /// <summary>
        /// Returns information about an Amazon Lex bot alias. For more information about aliases,
        /// see <a>versioning-aliases</a>.
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
        public GetBotAliasResponse GetBotAlias(GetBotAliasRequest request)
        {
            var marshaller = new GetBotAliasRequestMarshaller();
            var unmarshaller = GetBotAliasResponseUnmarshaller.Instance;

            return Invoke<GetBotAliasRequest,GetBotAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotAlias">REST API Reference for GetBotAlias Operation</seealso>
        public Task<GetBotAliasResponse> GetBotAliasAsync(GetBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBotAliasRequestMarshaller();
            var unmarshaller = GetBotAliasResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotAliasRequest,GetBotAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBotAliases


        /// <summary>
        /// Returns a list of aliases for a specified Amazon Lex bot.
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
        public GetBotAliasesResponse GetBotAliases(GetBotAliasesRequest request)
        {
            var marshaller = new GetBotAliasesRequestMarshaller();
            var unmarshaller = GetBotAliasesResponseUnmarshaller.Instance;

            return Invoke<GetBotAliasesRequest,GetBotAliasesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotAliases">REST API Reference for GetBotAliases Operation</seealso>
        public Task<GetBotAliasesResponse> GetBotAliasesAsync(GetBotAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBotAliasesRequestMarshaller();
            var unmarshaller = GetBotAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotAliasesRequest,GetBotAliasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBotChannelAssociation


        /// <summary>
        /// Returns information about the association between an Amazon Lex bot and a messaging
        /// platform.
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
        public GetBotChannelAssociationResponse GetBotChannelAssociation(GetBotChannelAssociationRequest request)
        {
            var marshaller = new GetBotChannelAssociationRequestMarshaller();
            var unmarshaller = GetBotChannelAssociationResponseUnmarshaller.Instance;

            return Invoke<GetBotChannelAssociationRequest,GetBotChannelAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotChannelAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotChannelAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotChannelAssociation">REST API Reference for GetBotChannelAssociation Operation</seealso>
        public Task<GetBotChannelAssociationResponse> GetBotChannelAssociationAsync(GetBotChannelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBotChannelAssociationRequestMarshaller();
            var unmarshaller = GetBotChannelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotChannelAssociationRequest,GetBotChannelAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBotChannelAssociations


        /// <summary>
        /// Returns a list of all of the channels associated with the specified bot.
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
        public GetBotChannelAssociationsResponse GetBotChannelAssociations(GetBotChannelAssociationsRequest request)
        {
            var marshaller = new GetBotChannelAssociationsRequestMarshaller();
            var unmarshaller = GetBotChannelAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetBotChannelAssociationsRequest,GetBotChannelAssociationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotChannelAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotChannelAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotChannelAssociations">REST API Reference for GetBotChannelAssociations Operation</seealso>
        public Task<GetBotChannelAssociationsResponse> GetBotChannelAssociationsAsync(GetBotChannelAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBotChannelAssociationsRequestMarshaller();
            var unmarshaller = GetBotChannelAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotChannelAssociationsRequest,GetBotChannelAssociationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetBotsResponse GetBots(GetBotsRequest request)
        {
            var marshaller = new GetBotsRequestMarshaller();
            var unmarshaller = GetBotsResponseUnmarshaller.Instance;

            return Invoke<GetBotsRequest,GetBotsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBots">REST API Reference for GetBots Operation</seealso>
        public Task<GetBotsResponse> GetBotsAsync(GetBotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBotsRequestMarshaller();
            var unmarshaller = GetBotsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotsRequest,GetBotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetBotVersionsResponse GetBotVersions(GetBotVersionsRequest request)
        {
            var marshaller = new GetBotVersionsRequestMarshaller();
            var unmarshaller = GetBotVersionsResponseUnmarshaller.Instance;

            return Invoke<GetBotVersionsRequest,GetBotVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotVersions">REST API Reference for GetBotVersions Operation</seealso>
        public Task<GetBotVersionsResponse> GetBotVersionsAsync(GetBotVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBotVersionsRequestMarshaller();
            var unmarshaller = GetBotVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotVersionsRequest,GetBotVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetBuiltinIntentResponse GetBuiltinIntent(GetBuiltinIntentRequest request)
        {
            var marshaller = new GetBuiltinIntentRequestMarshaller();
            var unmarshaller = GetBuiltinIntentResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinIntentRequest,GetBuiltinIntentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBuiltinIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinIntent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinIntent">REST API Reference for GetBuiltinIntent Operation</seealso>
        public Task<GetBuiltinIntentResponse> GetBuiltinIntentAsync(GetBuiltinIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBuiltinIntentRequestMarshaller();
            var unmarshaller = GetBuiltinIntentResponseUnmarshaller.Instance;

            return InvokeAsync<GetBuiltinIntentRequest,GetBuiltinIntentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetBuiltinIntentsResponse GetBuiltinIntents(GetBuiltinIntentsRequest request)
        {
            var marshaller = new GetBuiltinIntentsRequestMarshaller();
            var unmarshaller = GetBuiltinIntentsResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinIntentsRequest,GetBuiltinIntentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBuiltinIntents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinIntents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinIntents">REST API Reference for GetBuiltinIntents Operation</seealso>
        public Task<GetBuiltinIntentsResponse> GetBuiltinIntentsAsync(GetBuiltinIntentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBuiltinIntentsRequestMarshaller();
            var unmarshaller = GetBuiltinIntentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBuiltinIntentsRequest,GetBuiltinIntentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetBuiltinSlotTypesResponse GetBuiltinSlotTypes(GetBuiltinSlotTypesRequest request)
        {
            var marshaller = new GetBuiltinSlotTypesRequestMarshaller();
            var unmarshaller = GetBuiltinSlotTypesResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinSlotTypesRequest,GetBuiltinSlotTypesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBuiltinSlotTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinSlotTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinSlotTypes">REST API Reference for GetBuiltinSlotTypes Operation</seealso>
        public Task<GetBuiltinSlotTypesResponse> GetBuiltinSlotTypesAsync(GetBuiltinSlotTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBuiltinSlotTypesRequestMarshaller();
            var unmarshaller = GetBuiltinSlotTypesResponseUnmarshaller.Instance;

            return InvokeAsync<GetBuiltinSlotTypesRequest,GetBuiltinSlotTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetIntentResponse GetIntent(GetIntentRequest request)
        {
            var marshaller = new GetIntentRequestMarshaller();
            var unmarshaller = GetIntentResponseUnmarshaller.Instance;

            return Invoke<GetIntentRequest,GetIntentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntent">REST API Reference for GetIntent Operation</seealso>
        public Task<GetIntentResponse> GetIntentAsync(GetIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIntentRequestMarshaller();
            var unmarshaller = GetIntentResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntentRequest,GetIntentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetIntentsResponse GetIntents(GetIntentsRequest request)
        {
            var marshaller = new GetIntentsRequestMarshaller();
            var unmarshaller = GetIntentsResponseUnmarshaller.Instance;

            return Invoke<GetIntentsRequest,GetIntentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntents">REST API Reference for GetIntents Operation</seealso>
        public Task<GetIntentsResponse> GetIntentsAsync(GetIntentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIntentsRequestMarshaller();
            var unmarshaller = GetIntentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntentsRequest,GetIntentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetIntentVersionsResponse GetIntentVersions(GetIntentVersionsRequest request)
        {
            var marshaller = new GetIntentVersionsRequestMarshaller();
            var unmarshaller = GetIntentVersionsResponseUnmarshaller.Instance;

            return Invoke<GetIntentVersionsRequest,GetIntentVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntentVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntentVersions">REST API Reference for GetIntentVersions Operation</seealso>
        public Task<GetIntentVersionsResponse> GetIntentVersionsAsync(GetIntentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIntentVersionsRequestMarshaller();
            var unmarshaller = GetIntentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntentVersionsRequest,GetIntentVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetSlotTypeResponse GetSlotType(GetSlotTypeRequest request)
        {
            var marshaller = new GetSlotTypeRequestMarshaller();
            var unmarshaller = GetSlotTypeResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypeRequest,GetSlotTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSlotType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSlotType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotType">REST API Reference for GetSlotType Operation</seealso>
        public Task<GetSlotTypeResponse> GetSlotTypeAsync(GetSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSlotTypeRequestMarshaller();
            var unmarshaller = GetSlotTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetSlotTypeRequest,GetSlotTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetSlotTypesResponse GetSlotTypes(GetSlotTypesRequest request)
        {
            var marshaller = new GetSlotTypesRequestMarshaller();
            var unmarshaller = GetSlotTypesResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypesRequest,GetSlotTypesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSlotTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSlotTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotTypes">REST API Reference for GetSlotTypes Operation</seealso>
        public Task<GetSlotTypesResponse> GetSlotTypesAsync(GetSlotTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSlotTypesRequestMarshaller();
            var unmarshaller = GetSlotTypesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSlotTypesRequest,GetSlotTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetSlotTypeVersionsResponse GetSlotTypeVersions(GetSlotTypeVersionsRequest request)
        {
            var marshaller = new GetSlotTypeVersionsRequestMarshaller();
            var unmarshaller = GetSlotTypeVersionsResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypeVersionsRequest,GetSlotTypeVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSlotTypeVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSlotTypeVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotTypeVersions">REST API Reference for GetSlotTypeVersions Operation</seealso>
        public Task<GetSlotTypeVersionsResponse> GetSlotTypeVersionsAsync(GetSlotTypeVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSlotTypeVersionsRequestMarshaller();
            var unmarshaller = GetSlotTypeVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSlotTypeVersionsRequest,GetSlotTypeVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// You can request information for up to 5 versions in each request. The response contains
        /// information about a maximum of 100 utterances for each version.
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
        public GetUtterancesViewResponse GetUtterancesView(GetUtterancesViewRequest request)
        {
            var marshaller = new GetUtterancesViewRequestMarshaller();
            var unmarshaller = GetUtterancesViewResponseUnmarshaller.Instance;

            return Invoke<GetUtterancesViewRequest,GetUtterancesViewResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUtterancesView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUtterancesView operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetUtterancesView">REST API Reference for GetUtterancesView Operation</seealso>
        public Task<GetUtterancesViewResponse> GetUtterancesViewAsync(GetUtterancesViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetUtterancesViewRequestMarshaller();
            var unmarshaller = GetUtterancesViewResponseUnmarshaller.Instance;

            return InvokeAsync<GetUtterancesViewRequest,GetUtterancesViewResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBot


        /// <summary>
        /// Creates an Amazon Lex conversational bot or replaces an existing bot. When you create
        /// or update an intent you only required to specify a name. You can use this to add intents
        /// later, or to remove intents from an existing bot. When you create a bot with a name
        /// only, the bot is created or updated but Amazon Lex returns the <code/> response <code>FAILED</code>.
        /// You can build the bot after you add one or more intents. For more information about
        /// Amazon Lex bots, see <a>how-it-works</a>. 
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
        /// information, see <a>auth-and-access-control</a>.
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
        public PutBotResponse PutBot(PutBotRequest request)
        {
            var marshaller = new PutBotRequestMarshaller();
            var unmarshaller = PutBotResponseUnmarshaller.Instance;

            return Invoke<PutBotRequest,PutBotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutBot">REST API Reference for PutBot Operation</seealso>
        public Task<PutBotResponse> PutBotAsync(PutBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBotRequestMarshaller();
            var unmarshaller = PutBotResponseUnmarshaller.Instance;

            return InvokeAsync<PutBotRequest,PutBotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public PutBotAliasResponse PutBotAlias(PutBotAliasRequest request)
        {
            var marshaller = new PutBotAliasRequestMarshaller();
            var unmarshaller = PutBotAliasResponseUnmarshaller.Instance;

            return Invoke<PutBotAliasRequest,PutBotAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBotAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBotAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutBotAlias">REST API Reference for PutBotAlias Operation</seealso>
        public Task<PutBotAliasResponse> PutBotAliasAsync(PutBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBotAliasRequestMarshaller();
            var unmarshaller = PutBotAliasResponseUnmarshaller.Instance;

            return InvokeAsync<PutBotAliasRequest,PutBotAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// values in the <code>$LATEST</code> version of the slot type with the values in the
        /// request. Amazon Lex removes fields that you don't provide in the request. If you don't
        /// specify the required fields, Amazon Lex throws an exception.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>how-it-works</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>lex:PutIntent</code> action. For
        /// more information, see <a>auth-and-access-control</a>.
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
        public PutIntentResponse PutIntent(PutIntentRequest request)
        {
            var marshaller = new PutIntentRequestMarshaller();
            var unmarshaller = PutIntentResponseUnmarshaller.Instance;

            return Invoke<PutIntentRequest,PutIntentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutIntent">REST API Reference for PutIntent Operation</seealso>
        public Task<PutIntentResponse> PutIntentAsync(PutIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutIntentRequestMarshaller();
            var unmarshaller = PutIntentResponseUnmarshaller.Instance;

            return InvokeAsync<PutIntentRequest,PutIntentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// fields, Amazon Lex throws an exception.
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
        public PutSlotTypeResponse PutSlotType(PutSlotTypeRequest request)
        {
            var marshaller = new PutSlotTypeRequestMarshaller();
            var unmarshaller = PutSlotTypeResponseUnmarshaller.Instance;

            return Invoke<PutSlotTypeRequest,PutSlotTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSlotType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSlotType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutSlotType">REST API Reference for PutSlotType Operation</seealso>
        public Task<PutSlotTypeResponse> PutSlotTypeAsync(PutSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutSlotTypeRequestMarshaller();
            var unmarshaller = PutSlotTypeResponseUnmarshaller.Instance;

            return InvokeAsync<PutSlotTypeRequest,PutSlotTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}