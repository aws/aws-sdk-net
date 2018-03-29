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
        public virtual CreateBotVersionResponse CreateBotVersion(CreateBotVersionRequest request)
        {
            var marshaller = CreateBotVersionRequestMarshaller.Instance;
            var unmarshaller = CreateBotVersionResponseUnmarshaller.Instance;

            return Invoke<CreateBotVersionRequest,CreateBotVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBotVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBotVersion operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBotVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateBotVersion">REST API Reference for CreateBotVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateBotVersion(CreateBotVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateBotVersionRequestMarshaller.Instance;
            var unmarshaller = CreateBotVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateBotVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBotVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBotVersion.</param>
        /// 
        /// <returns>Returns a  CreateBotVersionResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateBotVersion">REST API Reference for CreateBotVersion Operation</seealso>
        public virtual CreateBotVersionResponse EndCreateBotVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBotVersionResponse>(asyncResult);
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
        public virtual CreateIntentVersionResponse CreateIntentVersion(CreateIntentVersionRequest request)
        {
            var marshaller = CreateIntentVersionRequestMarshaller.Instance;
            var unmarshaller = CreateIntentVersionResponseUnmarshaller.Instance;

            return Invoke<CreateIntentVersionRequest,CreateIntentVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntentVersion operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIntentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateIntentVersion">REST API Reference for CreateIntentVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateIntentVersion(CreateIntentVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateIntentVersionRequestMarshaller.Instance;
            var unmarshaller = CreateIntentVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateIntentVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIntentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIntentVersion.</param>
        /// 
        /// <returns>Returns a  CreateIntentVersionResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateIntentVersion">REST API Reference for CreateIntentVersion Operation</seealso>
        public virtual CreateIntentVersionResponse EndCreateIntentVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIntentVersionResponse>(asyncResult);
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
        public virtual CreateSlotTypeVersionResponse CreateSlotTypeVersion(CreateSlotTypeVersionRequest request)
        {
            var marshaller = CreateSlotTypeVersionRequestMarshaller.Instance;
            var unmarshaller = CreateSlotTypeVersionResponseUnmarshaller.Instance;

            return Invoke<CreateSlotTypeVersionRequest,CreateSlotTypeVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSlotTypeVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSlotTypeVersion operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSlotTypeVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateSlotTypeVersion">REST API Reference for CreateSlotTypeVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateSlotTypeVersion(CreateSlotTypeVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateSlotTypeVersionRequestMarshaller.Instance;
            var unmarshaller = CreateSlotTypeVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSlotTypeVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSlotTypeVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSlotTypeVersion.</param>
        /// 
        /// <returns>Returns a  CreateSlotTypeVersionResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/CreateSlotTypeVersion">REST API Reference for CreateSlotTypeVersion Operation</seealso>
        public virtual CreateSlotTypeVersionResponse EndCreateSlotTypeVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSlotTypeVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBot

        /// <summary>
        /// Deletes all versions of the bot, including the <code>$LATEST</code> version. To delete
        /// a specific version of the bot, use the <a>DeleteBotVersion</a> operation.
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
        public virtual DeleteBotResponse DeleteBot(DeleteBotRequest request)
        {
            var marshaller = DeleteBotRequestMarshaller.Instance;
            var unmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return Invoke<DeleteBotRequest,DeleteBotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        public virtual IAsyncResult BeginDeleteBot(DeleteBotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteBotRequestMarshaller.Instance;
            var unmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBot.</param>
        /// 
        /// <returns>Returns a  DeleteBotResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        public virtual DeleteBotResponse EndDeleteBot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBotResponse>(asyncResult);
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
        public virtual DeleteBotAliasResponse DeleteBotAlias(DeleteBotAliasRequest request)
        {
            var marshaller = DeleteBotAliasRequestMarshaller.Instance;
            var unmarshaller = DeleteBotAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteBotAliasRequest,DeleteBotAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBotAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotAlias operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBotAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotAlias">REST API Reference for DeleteBotAlias Operation</seealso>
        public virtual IAsyncResult BeginDeleteBotAlias(DeleteBotAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteBotAliasRequestMarshaller.Instance;
            var unmarshaller = DeleteBotAliasResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBotAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBotAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBotAlias.</param>
        /// 
        /// <returns>Returns a  DeleteBotAliasResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotAlias">REST API Reference for DeleteBotAlias Operation</seealso>
        public virtual DeleteBotAliasResponse EndDeleteBotAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBotAliasResponse>(asyncResult);
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
        public virtual DeleteBotChannelAssociationResponse DeleteBotChannelAssociation(DeleteBotChannelAssociationRequest request)
        {
            var marshaller = DeleteBotChannelAssociationRequestMarshaller.Instance;
            var unmarshaller = DeleteBotChannelAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteBotChannelAssociationRequest,DeleteBotChannelAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBotChannelAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotChannelAssociation operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBotChannelAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotChannelAssociation">REST API Reference for DeleteBotChannelAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteBotChannelAssociation(DeleteBotChannelAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteBotChannelAssociationRequestMarshaller.Instance;
            var unmarshaller = DeleteBotChannelAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBotChannelAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBotChannelAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBotChannelAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteBotChannelAssociationResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotChannelAssociation">REST API Reference for DeleteBotChannelAssociation Operation</seealso>
        public virtual DeleteBotChannelAssociationResponse EndDeleteBotChannelAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBotChannelAssociationResponse>(asyncResult);
        }

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
        public virtual DeleteBotVersionResponse DeleteBotVersion(DeleteBotVersionRequest request)
        {
            var marshaller = DeleteBotVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteBotVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteBotVersionRequest,DeleteBotVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBotVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotVersion operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBotVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotVersion">REST API Reference for DeleteBotVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteBotVersion(DeleteBotVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteBotVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteBotVersionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBotVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBotVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBotVersion.</param>
        /// 
        /// <returns>Returns a  DeleteBotVersionResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotVersion">REST API Reference for DeleteBotVersion Operation</seealso>
        public virtual DeleteBotVersionResponse EndDeleteBotVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBotVersionResponse>(asyncResult);
        }

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
        public virtual DeleteIntentResponse DeleteIntent(DeleteIntentRequest request)
        {
            var marshaller = DeleteIntentRequestMarshaller.Instance;
            var unmarshaller = DeleteIntentResponseUnmarshaller.Instance;

            return Invoke<DeleteIntentRequest,DeleteIntentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntent operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntent">REST API Reference for DeleteIntent Operation</seealso>
        public virtual IAsyncResult BeginDeleteIntent(DeleteIntentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIntentRequestMarshaller.Instance;
            var unmarshaller = DeleteIntentResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIntentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntent.</param>
        /// 
        /// <returns>Returns a  DeleteIntentResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntent">REST API Reference for DeleteIntent Operation</seealso>
        public virtual DeleteIntentResponse EndDeleteIntent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIntentResponse>(asyncResult);
        }

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
        public virtual DeleteIntentVersionResponse DeleteIntentVersion(DeleteIntentVersionRequest request)
        {
            var marshaller = DeleteIntentVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteIntentVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteIntentVersionRequest,DeleteIntentVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntentVersion operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntentVersion">REST API Reference for DeleteIntentVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteIntentVersion(DeleteIntentVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIntentVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteIntentVersionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIntentVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntentVersion.</param>
        /// 
        /// <returns>Returns a  DeleteIntentVersionResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntentVersion">REST API Reference for DeleteIntentVersion Operation</seealso>
        public virtual DeleteIntentVersionResponse EndDeleteIntentVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIntentVersionResponse>(asyncResult);
        }

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
        public virtual DeleteSlotTypeResponse DeleteSlotType(DeleteSlotTypeRequest request)
        {
            var marshaller = DeleteSlotTypeRequestMarshaller.Instance;
            var unmarshaller = DeleteSlotTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteSlotTypeRequest,DeleteSlotTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSlotType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotType operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSlotType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotType">REST API Reference for DeleteSlotType Operation</seealso>
        public virtual IAsyncResult BeginDeleteSlotType(DeleteSlotTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteSlotTypeRequestMarshaller.Instance;
            var unmarshaller = DeleteSlotTypeResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSlotTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSlotType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSlotType.</param>
        /// 
        /// <returns>Returns a  DeleteSlotTypeResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotType">REST API Reference for DeleteSlotType Operation</seealso>
        public virtual DeleteSlotTypeResponse EndDeleteSlotType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSlotTypeResponse>(asyncResult);
        }

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
        public virtual DeleteSlotTypeVersionResponse DeleteSlotTypeVersion(DeleteSlotTypeVersionRequest request)
        {
            var marshaller = DeleteSlotTypeVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteSlotTypeVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteSlotTypeVersionRequest,DeleteSlotTypeVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSlotTypeVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotTypeVersion operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSlotTypeVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotTypeVersion">REST API Reference for DeleteSlotTypeVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteSlotTypeVersion(DeleteSlotTypeVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteSlotTypeVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteSlotTypeVersionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSlotTypeVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSlotTypeVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSlotTypeVersion.</param>
        /// 
        /// <returns>Returns a  DeleteSlotTypeVersionResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotTypeVersion">REST API Reference for DeleteSlotTypeVersion Operation</seealso>
        public virtual DeleteSlotTypeVersionResponse EndDeleteSlotTypeVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSlotTypeVersionResponse>(asyncResult);
        }

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
        /// Use the <code>DeleteStoredUtterances</code> operation to manually delete stored utterances
        /// for a specific user.
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
        public virtual DeleteUtterancesResponse DeleteUtterances(DeleteUtterancesRequest request)
        {
            var marshaller = DeleteUtterancesRequestMarshaller.Instance;
            var unmarshaller = DeleteUtterancesResponseUnmarshaller.Instance;

            return Invoke<DeleteUtterancesRequest,DeleteUtterancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUtterances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUtterances operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUtterances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteUtterances">REST API Reference for DeleteUtterances Operation</seealso>
        public virtual IAsyncResult BeginDeleteUtterances(DeleteUtterancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteUtterancesRequestMarshaller.Instance;
            var unmarshaller = DeleteUtterancesResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUtterancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUtterances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUtterances.</param>
        /// 
        /// <returns>Returns a  DeleteUtterancesResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteUtterances">REST API Reference for DeleteUtterances Operation</seealso>
        public virtual DeleteUtterancesResponse EndDeleteUtterances(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUtterancesResponse>(asyncResult);
        }

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
        public virtual GetBotResponse GetBot(GetBotRequest request)
        {
            var marshaller = GetBotRequestMarshaller.Instance;
            var unmarshaller = GetBotResponseUnmarshaller.Instance;

            return Invoke<GetBotRequest,GetBotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBot operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBot">REST API Reference for GetBot Operation</seealso>
        public virtual IAsyncResult BeginGetBot(GetBotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBotRequestMarshaller.Instance;
            var unmarshaller = GetBotResponseUnmarshaller.Instance;

            return BeginInvoke<GetBotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBot.</param>
        /// 
        /// <returns>Returns a  GetBotResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBot">REST API Reference for GetBot Operation</seealso>
        public virtual GetBotResponse EndGetBot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBotResponse>(asyncResult);
        }

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
        public virtual GetBotAliasResponse GetBotAlias(GetBotAliasRequest request)
        {
            var marshaller = GetBotAliasRequestMarshaller.Instance;
            var unmarshaller = GetBotAliasResponseUnmarshaller.Instance;

            return Invoke<GetBotAliasRequest,GetBotAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotAlias operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBotAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotAlias">REST API Reference for GetBotAlias Operation</seealso>
        public virtual IAsyncResult BeginGetBotAlias(GetBotAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBotAliasRequestMarshaller.Instance;
            var unmarshaller = GetBotAliasResponseUnmarshaller.Instance;

            return BeginInvoke<GetBotAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBotAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBotAlias.</param>
        /// 
        /// <returns>Returns a  GetBotAliasResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotAlias">REST API Reference for GetBotAlias Operation</seealso>
        public virtual GetBotAliasResponse EndGetBotAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBotAliasResponse>(asyncResult);
        }

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
        public virtual GetBotAliasesResponse GetBotAliases(GetBotAliasesRequest request)
        {
            var marshaller = GetBotAliasesRequestMarshaller.Instance;
            var unmarshaller = GetBotAliasesResponseUnmarshaller.Instance;

            return Invoke<GetBotAliasesRequest,GetBotAliasesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotAliases operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBotAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotAliases">REST API Reference for GetBotAliases Operation</seealso>
        public virtual IAsyncResult BeginGetBotAliases(GetBotAliasesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBotAliasesRequestMarshaller.Instance;
            var unmarshaller = GetBotAliasesResponseUnmarshaller.Instance;

            return BeginInvoke<GetBotAliasesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBotAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBotAliases.</param>
        /// 
        /// <returns>Returns a  GetBotAliasesResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotAliases">REST API Reference for GetBotAliases Operation</seealso>
        public virtual GetBotAliasesResponse EndGetBotAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBotAliasesResponse>(asyncResult);
        }

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
        public virtual GetBotChannelAssociationResponse GetBotChannelAssociation(GetBotChannelAssociationRequest request)
        {
            var marshaller = GetBotChannelAssociationRequestMarshaller.Instance;
            var unmarshaller = GetBotChannelAssociationResponseUnmarshaller.Instance;

            return Invoke<GetBotChannelAssociationRequest,GetBotChannelAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotChannelAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotChannelAssociation operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBotChannelAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotChannelAssociation">REST API Reference for GetBotChannelAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetBotChannelAssociation(GetBotChannelAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBotChannelAssociationRequestMarshaller.Instance;
            var unmarshaller = GetBotChannelAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<GetBotChannelAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBotChannelAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBotChannelAssociation.</param>
        /// 
        /// <returns>Returns a  GetBotChannelAssociationResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotChannelAssociation">REST API Reference for GetBotChannelAssociation Operation</seealso>
        public virtual GetBotChannelAssociationResponse EndGetBotChannelAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBotChannelAssociationResponse>(asyncResult);
        }

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
        public virtual GetBotChannelAssociationsResponse GetBotChannelAssociations(GetBotChannelAssociationsRequest request)
        {
            var marshaller = GetBotChannelAssociationsRequestMarshaller.Instance;
            var unmarshaller = GetBotChannelAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetBotChannelAssociationsRequest,GetBotChannelAssociationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotChannelAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotChannelAssociations operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBotChannelAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotChannelAssociations">REST API Reference for GetBotChannelAssociations Operation</seealso>
        public virtual IAsyncResult BeginGetBotChannelAssociations(GetBotChannelAssociationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBotChannelAssociationsRequestMarshaller.Instance;
            var unmarshaller = GetBotChannelAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke<GetBotChannelAssociationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBotChannelAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBotChannelAssociations.</param>
        /// 
        /// <returns>Returns a  GetBotChannelAssociationsResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotChannelAssociations">REST API Reference for GetBotChannelAssociations Operation</seealso>
        public virtual GetBotChannelAssociationsResponse EndGetBotChannelAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBotChannelAssociationsResponse>(asyncResult);
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
        public virtual GetBotsResponse GetBots(GetBotsRequest request)
        {
            var marshaller = GetBotsRequestMarshaller.Instance;
            var unmarshaller = GetBotsResponseUnmarshaller.Instance;

            return Invoke<GetBotsRequest,GetBotsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBots operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBots">REST API Reference for GetBots Operation</seealso>
        public virtual IAsyncResult BeginGetBots(GetBotsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBotsRequestMarshaller.Instance;
            var unmarshaller = GetBotsResponseUnmarshaller.Instance;

            return BeginInvoke<GetBotsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBots.</param>
        /// 
        /// <returns>Returns a  GetBotsResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBots">REST API Reference for GetBots Operation</seealso>
        public virtual GetBotsResponse EndGetBots(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBotsResponse>(asyncResult);
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
        public virtual GetBotVersionsResponse GetBotVersions(GetBotVersionsRequest request)
        {
            var marshaller = GetBotVersionsRequestMarshaller.Instance;
            var unmarshaller = GetBotVersionsResponseUnmarshaller.Instance;

            return Invoke<GetBotVersionsRequest,GetBotVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotVersions operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBotVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotVersions">REST API Reference for GetBotVersions Operation</seealso>
        public virtual IAsyncResult BeginGetBotVersions(GetBotVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBotVersionsRequestMarshaller.Instance;
            var unmarshaller = GetBotVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetBotVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBotVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBotVersions.</param>
        /// 
        /// <returns>Returns a  GetBotVersionsResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBotVersions">REST API Reference for GetBotVersions Operation</seealso>
        public virtual GetBotVersionsResponse EndGetBotVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBotVersionsResponse>(asyncResult);
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
        public virtual GetBuiltinIntentResponse GetBuiltinIntent(GetBuiltinIntentRequest request)
        {
            var marshaller = GetBuiltinIntentRequestMarshaller.Instance;
            var unmarshaller = GetBuiltinIntentResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinIntentRequest,GetBuiltinIntentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBuiltinIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinIntent operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBuiltinIntent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinIntent">REST API Reference for GetBuiltinIntent Operation</seealso>
        public virtual IAsyncResult BeginGetBuiltinIntent(GetBuiltinIntentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBuiltinIntentRequestMarshaller.Instance;
            var unmarshaller = GetBuiltinIntentResponseUnmarshaller.Instance;

            return BeginInvoke<GetBuiltinIntentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBuiltinIntent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBuiltinIntent.</param>
        /// 
        /// <returns>Returns a  GetBuiltinIntentResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinIntent">REST API Reference for GetBuiltinIntent Operation</seealso>
        public virtual GetBuiltinIntentResponse EndGetBuiltinIntent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBuiltinIntentResponse>(asyncResult);
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
        public virtual GetBuiltinIntentsResponse GetBuiltinIntents(GetBuiltinIntentsRequest request)
        {
            var marshaller = GetBuiltinIntentsRequestMarshaller.Instance;
            var unmarshaller = GetBuiltinIntentsResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinIntentsRequest,GetBuiltinIntentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBuiltinIntents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinIntents operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBuiltinIntents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinIntents">REST API Reference for GetBuiltinIntents Operation</seealso>
        public virtual IAsyncResult BeginGetBuiltinIntents(GetBuiltinIntentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBuiltinIntentsRequestMarshaller.Instance;
            var unmarshaller = GetBuiltinIntentsResponseUnmarshaller.Instance;

            return BeginInvoke<GetBuiltinIntentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBuiltinIntents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBuiltinIntents.</param>
        /// 
        /// <returns>Returns a  GetBuiltinIntentsResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinIntents">REST API Reference for GetBuiltinIntents Operation</seealso>
        public virtual GetBuiltinIntentsResponse EndGetBuiltinIntents(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBuiltinIntentsResponse>(asyncResult);
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
        public virtual GetBuiltinSlotTypesResponse GetBuiltinSlotTypes(GetBuiltinSlotTypesRequest request)
        {
            var marshaller = GetBuiltinSlotTypesRequestMarshaller.Instance;
            var unmarshaller = GetBuiltinSlotTypesResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinSlotTypesRequest,GetBuiltinSlotTypesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBuiltinSlotTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBuiltinSlotTypes operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBuiltinSlotTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinSlotTypes">REST API Reference for GetBuiltinSlotTypes Operation</seealso>
        public virtual IAsyncResult BeginGetBuiltinSlotTypes(GetBuiltinSlotTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBuiltinSlotTypesRequestMarshaller.Instance;
            var unmarshaller = GetBuiltinSlotTypesResponseUnmarshaller.Instance;

            return BeginInvoke<GetBuiltinSlotTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBuiltinSlotTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBuiltinSlotTypes.</param>
        /// 
        /// <returns>Returns a  GetBuiltinSlotTypesResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetBuiltinSlotTypes">REST API Reference for GetBuiltinSlotTypes Operation</seealso>
        public virtual GetBuiltinSlotTypesResponse EndGetBuiltinSlotTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBuiltinSlotTypesResponse>(asyncResult);
        }

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
        public virtual GetExportResponse GetExport(GetExportRequest request)
        {
            var marshaller = GetExportRequestMarshaller.Instance;
            var unmarshaller = GetExportResponseUnmarshaller.Instance;

            return Invoke<GetExportRequest,GetExportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExport operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetExport">REST API Reference for GetExport Operation</seealso>
        public virtual IAsyncResult BeginGetExport(GetExportRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetExportRequestMarshaller.Instance;
            var unmarshaller = GetExportResponseUnmarshaller.Instance;

            return BeginInvoke<GetExportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExport.</param>
        /// 
        /// <returns>Returns a  GetExportResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetExport">REST API Reference for GetExport Operation</seealso>
        public virtual GetExportResponse EndGetExport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExportResponse>(asyncResult);
        }

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
        public virtual GetImportResponse GetImport(GetImportRequest request)
        {
            var marshaller = GetImportRequestMarshaller.Instance;
            var unmarshaller = GetImportResponseUnmarshaller.Instance;

            return Invoke<GetImportRequest,GetImportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImport operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetImport">REST API Reference for GetImport Operation</seealso>
        public virtual IAsyncResult BeginGetImport(GetImportRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetImportRequestMarshaller.Instance;
            var unmarshaller = GetImportResponseUnmarshaller.Instance;

            return BeginInvoke<GetImportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImport.</param>
        /// 
        /// <returns>Returns a  GetImportResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetImport">REST API Reference for GetImport Operation</seealso>
        public virtual GetImportResponse EndGetImport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImportResponse>(asyncResult);
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
        public virtual GetIntentResponse GetIntent(GetIntentRequest request)
        {
            var marshaller = GetIntentRequestMarshaller.Instance;
            var unmarshaller = GetIntentResponseUnmarshaller.Instance;

            return Invoke<GetIntentRequest,GetIntentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntent operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntent">REST API Reference for GetIntent Operation</seealso>
        public virtual IAsyncResult BeginGetIntent(GetIntentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIntentRequestMarshaller.Instance;
            var unmarshaller = GetIntentResponseUnmarshaller.Instance;

            return BeginInvoke<GetIntentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntent.</param>
        /// 
        /// <returns>Returns a  GetIntentResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntent">REST API Reference for GetIntent Operation</seealso>
        public virtual GetIntentResponse EndGetIntent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntentResponse>(asyncResult);
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
        public virtual GetIntentsResponse GetIntents(GetIntentsRequest request)
        {
            var marshaller = GetIntentsRequestMarshaller.Instance;
            var unmarshaller = GetIntentsResponseUnmarshaller.Instance;

            return Invoke<GetIntentsRequest,GetIntentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntents operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntents">REST API Reference for GetIntents Operation</seealso>
        public virtual IAsyncResult BeginGetIntents(GetIntentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIntentsRequestMarshaller.Instance;
            var unmarshaller = GetIntentsResponseUnmarshaller.Instance;

            return BeginInvoke<GetIntentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntents.</param>
        /// 
        /// <returns>Returns a  GetIntentsResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntents">REST API Reference for GetIntents Operation</seealso>
        public virtual GetIntentsResponse EndGetIntents(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntentsResponse>(asyncResult);
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
        public virtual GetIntentVersionsResponse GetIntentVersions(GetIntentVersionsRequest request)
        {
            var marshaller = GetIntentVersionsRequestMarshaller.Instance;
            var unmarshaller = GetIntentVersionsResponseUnmarshaller.Instance;

            return Invoke<GetIntentVersionsRequest,GetIntentVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntentVersions operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntentVersions">REST API Reference for GetIntentVersions Operation</seealso>
        public virtual IAsyncResult BeginGetIntentVersions(GetIntentVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIntentVersionsRequestMarshaller.Instance;
            var unmarshaller = GetIntentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetIntentVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntentVersions.</param>
        /// 
        /// <returns>Returns a  GetIntentVersionsResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetIntentVersions">REST API Reference for GetIntentVersions Operation</seealso>
        public virtual GetIntentVersionsResponse EndGetIntentVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntentVersionsResponse>(asyncResult);
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
        public virtual GetSlotTypeResponse GetSlotType(GetSlotTypeRequest request)
        {
            var marshaller = GetSlotTypeRequestMarshaller.Instance;
            var unmarshaller = GetSlotTypeResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypeRequest,GetSlotTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSlotType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSlotType operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSlotType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotType">REST API Reference for GetSlotType Operation</seealso>
        public virtual IAsyncResult BeginGetSlotType(GetSlotTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSlotTypeRequestMarshaller.Instance;
            var unmarshaller = GetSlotTypeResponseUnmarshaller.Instance;

            return BeginInvoke<GetSlotTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSlotType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSlotType.</param>
        /// 
        /// <returns>Returns a  GetSlotTypeResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotType">REST API Reference for GetSlotType Operation</seealso>
        public virtual GetSlotTypeResponse EndGetSlotType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSlotTypeResponse>(asyncResult);
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
        public virtual GetSlotTypesResponse GetSlotTypes(GetSlotTypesRequest request)
        {
            var marshaller = GetSlotTypesRequestMarshaller.Instance;
            var unmarshaller = GetSlotTypesResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypesRequest,GetSlotTypesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSlotTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSlotTypes operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSlotTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotTypes">REST API Reference for GetSlotTypes Operation</seealso>
        public virtual IAsyncResult BeginGetSlotTypes(GetSlotTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSlotTypesRequestMarshaller.Instance;
            var unmarshaller = GetSlotTypesResponseUnmarshaller.Instance;

            return BeginInvoke<GetSlotTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSlotTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSlotTypes.</param>
        /// 
        /// <returns>Returns a  GetSlotTypesResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotTypes">REST API Reference for GetSlotTypes Operation</seealso>
        public virtual GetSlotTypesResponse EndGetSlotTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSlotTypesResponse>(asyncResult);
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
        public virtual GetSlotTypeVersionsResponse GetSlotTypeVersions(GetSlotTypeVersionsRequest request)
        {
            var marshaller = GetSlotTypeVersionsRequestMarshaller.Instance;
            var unmarshaller = GetSlotTypeVersionsResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypeVersionsRequest,GetSlotTypeVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSlotTypeVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSlotTypeVersions operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSlotTypeVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotTypeVersions">REST API Reference for GetSlotTypeVersions Operation</seealso>
        public virtual IAsyncResult BeginGetSlotTypeVersions(GetSlotTypeVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSlotTypeVersionsRequestMarshaller.Instance;
            var unmarshaller = GetSlotTypeVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetSlotTypeVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSlotTypeVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSlotTypeVersions.</param>
        /// 
        /// <returns>Returns a  GetSlotTypeVersionsResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetSlotTypeVersions">REST API Reference for GetSlotTypeVersions Operation</seealso>
        public virtual GetSlotTypeVersionsResponse EndGetSlotTypeVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSlotTypeVersionsResponse>(asyncResult);
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
        ///  <note> 
        /// <para>
        /// Utterance statistics are generated once a day. Data is available for the last 15 days.
        /// You can request information for up to 5 versions in each request. The response contains
        /// information about a maximum of 100 utterances for each version.
        /// </para>
        ///  </note> 
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
        public virtual GetUtterancesViewResponse GetUtterancesView(GetUtterancesViewRequest request)
        {
            var marshaller = GetUtterancesViewRequestMarshaller.Instance;
            var unmarshaller = GetUtterancesViewResponseUnmarshaller.Instance;

            return Invoke<GetUtterancesViewRequest,GetUtterancesViewResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUtterancesView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUtterancesView operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUtterancesView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetUtterancesView">REST API Reference for GetUtterancesView Operation</seealso>
        public virtual IAsyncResult BeginGetUtterancesView(GetUtterancesViewRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetUtterancesViewRequestMarshaller.Instance;
            var unmarshaller = GetUtterancesViewResponseUnmarshaller.Instance;

            return BeginInvoke<GetUtterancesViewRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUtterancesView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUtterancesView.</param>
        /// 
        /// <returns>Returns a  GetUtterancesViewResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetUtterancesView">REST API Reference for GetUtterancesView Operation</seealso>
        public virtual GetUtterancesViewResponse EndGetUtterancesView(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUtterancesViewResponse>(asyncResult);
        }

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
        public virtual PutBotResponse PutBot(PutBotRequest request)
        {
            var marshaller = PutBotRequestMarshaller.Instance;
            var unmarshaller = PutBotResponseUnmarshaller.Instance;

            return Invoke<PutBotRequest,PutBotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBot operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutBot">REST API Reference for PutBot Operation</seealso>
        public virtual IAsyncResult BeginPutBot(PutBotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutBotRequestMarshaller.Instance;
            var unmarshaller = PutBotResponseUnmarshaller.Instance;

            return BeginInvoke<PutBotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBot.</param>
        /// 
        /// <returns>Returns a  PutBotResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutBot">REST API Reference for PutBot Operation</seealso>
        public virtual PutBotResponse EndPutBot(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBotResponse>(asyncResult);
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
        public virtual PutBotAliasResponse PutBotAlias(PutBotAliasRequest request)
        {
            var marshaller = PutBotAliasRequestMarshaller.Instance;
            var unmarshaller = PutBotAliasResponseUnmarshaller.Instance;

            return Invoke<PutBotAliasRequest,PutBotAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBotAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBotAlias operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBotAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutBotAlias">REST API Reference for PutBotAlias Operation</seealso>
        public virtual IAsyncResult BeginPutBotAlias(PutBotAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutBotAliasRequestMarshaller.Instance;
            var unmarshaller = PutBotAliasResponseUnmarshaller.Instance;

            return BeginInvoke<PutBotAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBotAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBotAlias.</param>
        /// 
        /// <returns>Returns a  PutBotAliasResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutBotAlias">REST API Reference for PutBotAlias Operation</seealso>
        public virtual PutBotAliasResponse EndPutBotAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBotAliasResponse>(asyncResult);
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
        public virtual PutIntentResponse PutIntent(PutIntentRequest request)
        {
            var marshaller = PutIntentRequestMarshaller.Instance;
            var unmarshaller = PutIntentResponseUnmarshaller.Instance;

            return Invoke<PutIntentRequest,PutIntentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutIntent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntent operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutIntent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutIntent">REST API Reference for PutIntent Operation</seealso>
        public virtual IAsyncResult BeginPutIntent(PutIntentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutIntentRequestMarshaller.Instance;
            var unmarshaller = PutIntentResponseUnmarshaller.Instance;

            return BeginInvoke<PutIntentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutIntent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIntent.</param>
        /// 
        /// <returns>Returns a  PutIntentResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutIntent">REST API Reference for PutIntent Operation</seealso>
        public virtual PutIntentResponse EndPutIntent(IAsyncResult asyncResult)
        {
            return EndInvoke<PutIntentResponse>(asyncResult);
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
        public virtual PutSlotTypeResponse PutSlotType(PutSlotTypeRequest request)
        {
            var marshaller = PutSlotTypeRequestMarshaller.Instance;
            var unmarshaller = PutSlotTypeResponseUnmarshaller.Instance;

            return Invoke<PutSlotTypeRequest,PutSlotTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSlotType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSlotType operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSlotType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutSlotType">REST API Reference for PutSlotType Operation</seealso>
        public virtual IAsyncResult BeginPutSlotType(PutSlotTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutSlotTypeRequestMarshaller.Instance;
            var unmarshaller = PutSlotTypeResponseUnmarshaller.Instance;

            return BeginInvoke<PutSlotTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSlotType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSlotType.</param>
        /// 
        /// <returns>Returns a  PutSlotTypeResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/PutSlotType">REST API Reference for PutSlotType Operation</seealso>
        public virtual PutSlotTypeResponse EndPutSlotType(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSlotTypeResponse>(asyncResult);
        }

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
        public virtual StartImportResponse StartImport(StartImportRequest request)
        {
            var marshaller = StartImportRequestMarshaller.Instance;
            var unmarshaller = StartImportResponseUnmarshaller.Instance;

            return Invoke<StartImportRequest,StartImportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImport operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/StartImport">REST API Reference for StartImport Operation</seealso>
        public virtual IAsyncResult BeginStartImport(StartImportRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartImportRequestMarshaller.Instance;
            var unmarshaller = StartImportResponseUnmarshaller.Instance;

            return BeginInvoke<StartImportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImport.</param>
        /// 
        /// <returns>Returns a  StartImportResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/StartImport">REST API Reference for StartImport Operation</seealso>
        public virtual StartImportResponse EndStartImport(IAsyncResult asyncResult)
        {
            return EndInvoke<StartImportResponse>(asyncResult);
        }

        #endregion
        
    }
}