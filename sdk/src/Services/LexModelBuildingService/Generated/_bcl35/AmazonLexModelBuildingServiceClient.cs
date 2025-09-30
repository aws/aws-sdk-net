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
using System.Collections.Generic;
using System.Net;

using Amazon.LexModelBuildingService.Model;
using Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations;
using Amazon.LexModelBuildingService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.LexModelBuildingService
{
    /// <summary>
    /// <para>Implementation for accessing LexModelBuildingService</para>
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
        private static IServiceMetadata serviceMetadata = new AmazonLexModelBuildingServiceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ILexModelBuildingServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILexModelBuildingServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LexModelBuildingServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLexModelBuildingServiceEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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
        /// Creates a new version of the bot based on the <c>$LATEST</c> version. If the <c>$LATEST</c>
        /// version of this resource hasn't changed since you created the last version, Amazon
        /// Lex doesn't create a new version. It returns the last created version.
        /// 
        ///  <note> 
        /// <para>
        /// You can update only the <c>$LATEST</c> version of the bot. You can't update the numbered
        /// versions that you create with the <c>CreateBotVersion</c> operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  When you create the first version of a bot, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1. For more information, see <a>versioning-intro</a>. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permission for the <c>lex:CreateBotVersion</c> action. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBotVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBotVersionResponseUnmarshaller.Instance;

            return Invoke<CreateBotVersionResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBotVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBotVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Creates a new version of an intent based on the <c>$LATEST</c> version of the intent.
        /// If the <c>$LATEST</c> version of this intent hasn't changed since you last updated
        /// it, Amazon Lex doesn't create a new version. It returns the last version you created.
        /// 
        ///  <note> 
        /// <para>
        /// You can update only the <c>$LATEST</c> version of the intent. You can't update the
        /// numbered versions that you create with the <c>CreateIntentVersion</c> operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  When you create a version of an intent, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1. For more information, see <a>versioning-intro</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>lex:CreateIntentVersion</c>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntentVersionResponseUnmarshaller.Instance;

            return Invoke<CreateIntentVersionResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntentVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Creates a new version of a slot type based on the <c>$LATEST</c> version of the specified
        /// slot type. If the <c>$LATEST</c> version of this resource has not changed since the
        /// last version that you created, Amazon Lex doesn't create a new version. It returns
        /// the last version that you created. 
        /// 
        ///  <note> 
        /// <para>
        /// You can update only the <c>$LATEST</c> version of a slot type. You can't update the
        /// numbered versions that you create with the <c>CreateSlotTypeVersion</c> operation.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you create a version of a slot type, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1. For more information, see <a>versioning-intro</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:CreateSlotTypeVersion</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSlotTypeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSlotTypeVersionResponseUnmarshaller.Instance;

            return Invoke<CreateSlotTypeVersionResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSlotTypeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSlotTypeVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Deletes all versions of the bot, including the <c>$LATEST</c> version. To delete a
        /// specific version of the bot, use the <a>DeleteBotVersion</a> operation. The <c>DeleteBot</c>
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
        /// If a bot has an alias, you can't delete it. Instead, the <c>DeleteBot</c> operation
        /// returns a <c>ResourceInUseException</c> exception that includes a reference to the
        /// alias that refers to the bot. To remove the reference to the bot, delete the alias.
        /// If you get the same exception again, delete the referring alias until the <c>DeleteBot</c>
        /// operation is successful.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:DeleteBot</c> action.
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
        ///  <c>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"resourceReference": {</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"name": <i>string</i>, "version": <i>string</i> } }</c> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        public virtual DeleteBotResponse DeleteBot(DeleteBotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return Invoke<DeleteBotResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// channel. If an alias is used in a channel association, the <c>DeleteBot</c> operation
        /// returns a <c>ResourceInUseException</c> exception that includes a reference to the
        /// channel association that refers to the bot. You can remove the reference to the alias
        /// by deleting the channel association. If you get the same exception again, delete the
        /// referring association until the <c>DeleteBotAlias</c> operation is successful.
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
        ///  <c>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"resourceReference": {</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"name": <i>string</i>, "version": <i>string</i> } }</c> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotAlias">REST API Reference for DeleteBotAlias Operation</seealso>
        public virtual DeleteBotAliasResponse DeleteBotAlias(DeleteBotAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteBotAliasResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permission for the <c>lex:DeleteBotChannelAssociation</c>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotChannelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotChannelAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteBotChannelAssociationResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotChannelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotChannelAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permissions for the <c>lex:DeleteBotVersion</c> action.
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
        ///  <c>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"resourceReference": {</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"name": <i>string</i>, "version": <i>string</i> } }</c> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotVersion">REST API Reference for DeleteBotVersion Operation</seealso>
        public virtual DeleteBotVersionResponse DeleteBotVersion(DeleteBotVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteBotVersionResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Deletes all versions of the intent, including the <c>$LATEST</c> version. To delete
        /// a specific version of the intent, use the <a>DeleteIntentVersion</a> operation.
        /// 
        ///  
        /// <para>
        ///  You can delete a version of an intent only if it is not referenced. To delete an
        /// intent that is referred to in one or more bots (see <a>how-it-works</a>), you must
        /// remove those references first. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you get the <c>ResourceInUseException</c> exception, it provides an example reference
        /// that shows where the intent is referenced. To remove the reference to the intent,
        /// either update the bot or delete it. If you get the same exception when you attempt
        /// to delete the intent again, repeat until the intent has no references and the call
        /// to <c>DeleteIntent</c> is successful. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  This operation requires permission for the <c>lex:DeleteIntent</c> action. 
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
        ///  <c>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"resourceReference": {</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"name": <i>string</i>, "version": <i>string</i> } }</c> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntent">REST API Reference for DeleteIntent Operation</seealso>
        public virtual DeleteIntentResponse DeleteIntent(DeleteIntentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntentResponseUnmarshaller.Instance;

            return Invoke<DeleteIntentResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permissions for the <c>lex:DeleteIntentVersion</c> action.
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
        ///  <c>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"resourceReference": {</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"name": <i>string</i>, "version": <i>string</i> } }</c> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntentVersion">REST API Reference for DeleteIntentVersion Operation</seealso>
        public virtual DeleteIntentVersionResponse DeleteIntentVersion(DeleteIntentVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntentVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteIntentVersionResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntentVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Deletes all versions of the slot type, including the <c>$LATEST</c> version. To delete
        /// a specific version of the slot type, use the <a>DeleteSlotTypeVersion</a> operation.
        /// 
        ///  
        /// <para>
        ///  You can delete a version of a slot type only if it is not referenced. To delete a
        /// slot type that is referred to in one or more intents, you must remove those references
        /// first. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you get the <c>ResourceInUseException</c> exception, the exception provides an
        /// example reference that shows the intent where the slot type is referenced. To remove
        /// the reference to the slot type, either update the intent or delete it. If you get
        /// the same exception when you attempt to delete the slot type again, repeat until the
        /// slot type has no references and the <c>DeleteSlotType</c> call is successful. 
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permission for the <c>lex:DeleteSlotType</c> action.
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
        ///  <c>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"resourceReference": {</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"name": <i>string</i>, "version": <i>string</i> } }</c> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotType">REST API Reference for DeleteSlotType Operation</seealso>
        public virtual DeleteSlotTypeResponse DeleteSlotType(DeleteSlotTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlotTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteSlotTypeResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlotTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permissions for the <c>lex:DeleteSlotTypeVersion</c> action.
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
        ///  <c>{ "resourceType": BOT | BOTALIAS | BOTCHANNEL | INTENT,</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"resourceReference": {</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"name": <i>string</i>, "version": <i>string</i> } }</c> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotTypeVersion">REST API Reference for DeleteSlotTypeVersion Operation</seealso>
        public virtual DeleteSlotTypeVersionResponse DeleteSlotTypeVersion(DeleteSlotTypeVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlotTypeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlotTypeVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteSlotTypeVersionResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlotTypeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlotTypeVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Use the <c>DeleteUtterances</c> operation to manually delete stored utterances for
        /// a specific user. When you use the <c>DeleteUtterances</c> operation, utterances stored
        /// for improving your bot's ability to respond to user input are deleted immediately.
        /// Utterances stored for use with the <c>GetUtterancesView</c> operation are deleted
        /// after 15 days.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:DeleteUtterances</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUtterancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUtterancesResponseUnmarshaller.Instance;

            return Invoke<DeleteUtterancesResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUtterancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUtterancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        ///  This operation requires permissions for the <c>lex:GetBot</c> action. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotResponseUnmarshaller.Instance;

            return Invoke<GetBotResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permissions for the <c>lex:GetBotAlias</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotAliasResponseUnmarshaller.Instance;

            return Invoke<GetBotAliasResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permissions for the <c>lex:GetBotAliases</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotAliasesResponseUnmarshaller.Instance;

            return Invoke<GetBotAliasesResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotAliasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permissions for the <c>lex:GetBotChannelAssociation</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotChannelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotChannelAssociationResponseUnmarshaller.Instance;

            return Invoke<GetBotChannelAssociationResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotChannelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotChannelAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// The <c>GetBotChannelAssociations</c> operation requires permissions for the <c>lex:GetBotChannelAssociations</c>
        /// action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotChannelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotChannelAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetBotChannelAssociationsResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotChannelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotChannelAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// If you provide the <c>nameContains</c> field, the response includes information for
        /// the <c>$LATEST</c> version of all bots whose name contains the specified string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify the <c>nameContains</c> field, the operation returns information
        /// about the <c>$LATEST</c> version of all of your bots.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation requires permission for the <c>lex:GetBots</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotsResponseUnmarshaller.Instance;

            return Invoke<GetBotsResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// The <c>GetBotVersions</c> operation returns a <c>BotMetadata</c> object for each version
        /// of a bot. For example, if a bot has three numbered versions, the <c>GetBotVersions</c>
        /// operation returns four <c>BotMetadata</c> objects in the response, one for each numbered
        /// version and one for the <c>$LATEST</c> version. 
        /// </para>
        ///  
        /// <para>
        /// The <c>GetBotVersions</c> operation always returns at least one version, the <c>$LATEST</c>
        /// version.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:GetBotVersions</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotVersionsResponseUnmarshaller.Instance;

            return Invoke<GetBotVersionsResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permission for the <c>lex:GetBuiltinIntent</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBuiltinIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinIntentResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinIntentResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBuiltinIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinIntentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permission for the <c>lex:GetBuiltinIntents</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBuiltinIntentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinIntentsResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinIntentsResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBuiltinIntentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinIntentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permission for the <c>lex:GetBuiltInSlotTypes</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBuiltinSlotTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinSlotTypesResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinSlotTypesResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBuiltinSlotTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinSlotTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportResponseUnmarshaller.Instance;

            return Invoke<GetExportResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Gets information about an import job started with the <c>StartImport</c> operation.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportResponseUnmarshaller.Instance;

            return Invoke<GetImportResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        ///  This operation requires permissions to perform the <c>lex:GetIntent</c> action. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentResponseUnmarshaller.Instance;

            return Invoke<GetIntentResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// If you specify the <c>nameContains</c> field, returns the <c>$LATEST</c> version of
        /// all intents that contain the specified string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you don't specify the <c>nameContains</c> field, returns information about the
        /// <c>$LATEST</c> version of all intents. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  The operation requires permission for the <c>lex:GetIntents</c> action. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentsResponseUnmarshaller.Instance;

            return Invoke<GetIntentsResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// The <c>GetIntentVersions</c> operation returns an <c>IntentMetadata</c> object for
        /// each version of an intent. For example, if an intent has three numbered versions,
        /// the <c>GetIntentVersions</c> operation returns four <c>IntentMetadata</c> objects
        /// in the response, one for each numbered version and one for the <c>$LATEST</c> version.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The <c>GetIntentVersions</c> operation always returns at least one version, the <c>$LATEST</c>
        /// version.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:GetIntentVersions</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentVersionsResponseUnmarshaller.Instance;

            return Invoke<GetIntentVersionsResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  GetMigration

        /// <summary>
        /// Provides details about an ongoing or complete migration from an Amazon Lex V1 bot
        /// to an Amazon Lex V2 bot. Use this operation to view the migration alerts and warnings
        /// related to the migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMigration service method.</param>
        /// 
        /// <returns>The response from the GetMigration service method, as returned by LexModelBuildingService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetMigration">REST API Reference for GetMigration Operation</seealso>
        public virtual GetMigrationResponse GetMigration(GetMigrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMigrationResponseUnmarshaller.Instance;

            return Invoke<GetMigrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMigration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMigration operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMigration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetMigration">REST API Reference for GetMigration Operation</seealso>
        public virtual IAsyncResult BeginGetMigration(GetMigrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMigrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMigration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMigration.</param>
        /// 
        /// <returns>Returns a  GetMigrationResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetMigration">REST API Reference for GetMigration Operation</seealso>
        public virtual GetMigrationResponse EndGetMigration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMigrationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMigrations

        /// <summary>
        /// Gets a list of migrations between Amazon Lex V1 and Amazon Lex V2.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMigrations service method.</param>
        /// 
        /// <returns>The response from the GetMigrations service method, as returned by LexModelBuildingService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetMigrations">REST API Reference for GetMigrations Operation</seealso>
        public virtual GetMigrationsResponse GetMigrations(GetMigrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMigrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMigrationsResponseUnmarshaller.Instance;

            return Invoke<GetMigrationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMigrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMigrations operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMigrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetMigrations">REST API Reference for GetMigrations Operation</seealso>
        public virtual IAsyncResult BeginGetMigrations(GetMigrationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMigrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMigrationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMigrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMigrations.</param>
        /// 
        /// <returns>Returns a  GetMigrationsResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetMigrations">REST API Reference for GetMigrations Operation</seealso>
        public virtual GetMigrationsResponse EndGetMigrations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMigrationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSlotType

        /// <summary>
        /// Returns information about a specific version of a slot type. In addition to specifying
        /// the slot type name, you must specify the slot type version.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:GetSlotType</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypeResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypeResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// If you specify the <c>nameContains</c> field, returns the <c>$LATEST</c> version of
        /// all slot types that contain the specified string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you don't specify the <c>nameContains</c> field, returns information about the
        /// <c>$LATEST</c> version of all slot types. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  The operation requires permission for the <c>lex:GetSlotTypes</c> action. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSlotTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypesResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypesResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSlotTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// The <c>GetSlotTypeVersions</c> operation returns a <c>SlotTypeMetadata</c> object
        /// for each version of a slot type. For example, if a slot type has three numbered versions,
        /// the <c>GetSlotTypeVersions</c> operation returns four <c>SlotTypeMetadata</c> objects
        /// in the response, one for each numbered version and one for the <c>$LATEST</c> version.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The <c>GetSlotTypeVersions</c> operation always returns at least one version, the
        /// <c>$LATEST</c> version.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:GetSlotTypeVersions</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSlotTypeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypeVersionsResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypeVersionsResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSlotTypeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypeVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Use the <c>GetUtterancesView</c> operation to get information about the utterances
        /// that your users have made to your bot. You can use this list to tune the utterances
        /// that your bot responds to.
        /// 
        ///  
        /// <para>
        /// For example, say that you have created a bot to order flowers. After your users have
        /// used your bot for a while, use the <c>GetUtterancesView</c> operation to see the requests
        /// that they have made and whether they have been successful. You might find that the
        /// utterance "I want flowers" is not being recognized. You could add this utterance to
        /// the <c>OrderFlowers</c> intent so that your bot recognizes that utterance.
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
        /// If you set <c>childDirected</c> field to true when you created your bot, if you are
        /// using slot obfuscation with one or more slots, or if you opted out of participating
        /// in improving Amazon Lex, utterances are not available.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:GetUtterancesView</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUtterancesViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUtterancesViewResponseUnmarshaller.Instance;

            return Invoke<GetUtterancesViewResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUtterancesViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUtterancesViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBot

        /// <summary>
        /// Creates an Amazon Lex conversational bot or replaces an existing bot. When you create
        /// or update a bot you are only required to specify a name, a locale, and whether the
        /// bot is directed toward children under age 13. You can use this to add intents later,
        /// or to remove intents from an existing bot. When you create a bot with the minimum
        /// information, the bot is created or updated but Amazon Lex returns the <code/> response
        /// <c>FAILED</c>. You can build the bot after you add one or more intents. For more information
        /// about Amazon Lex bots, see <a>how-it-works</a>. 
        /// 
        ///  
        /// <para>
        /// If you specify the name of an existing bot, the fields in the request replace the
        /// existing values in the <c>$LATEST</c> version of the bot. Amazon Lex removes any fields
        /// that you don't provide values for in the request, except for the <c>idleTTLInSeconds</c>
        /// and <c>privacySettings</c> fields, which are set to their default values. If you don't
        /// specify values for required fields, Amazon Lex throws an exception.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:PutBot</c> action. For more information,
        /// see <a>security-iam</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBotResponseUnmarshaller.Instance;

            return Invoke<PutBotResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// This operation requires permissions for the <c>lex:PutBotAlias</c> action. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBotAliasResponseUnmarshaller.Instance;

            return Invoke<PutBotAliasResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBotAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// For a pizza ordering bot, for example, you would create an <c>OrderPizza</c> intent.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To create an intent or replace an existing intent, you must provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Intent name. For example, <c>OrderPizza</c>.
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
        /// values in the <c>$LATEST</c> version of the intent with the values in the request.
        /// Amazon Lex removes fields that you don't provide in the request. If you don't specify
        /// the required fields, Amazon Lex throws an exception. When you update the <c>$LATEST</c>
        /// version of an intent, the <c>status</c> field of any bot that uses the <c>$LATEST</c>
        /// version of the intent is set to <c>NOT_BUILT</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>how-it-works</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:PutIntent</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntentResponseUnmarshaller.Instance;

            return Invoke<PutIntentResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// the existing values in the <c>$LATEST</c> version of the slot type. Amazon Lex removes
        /// the fields that you don't provide in the request. If you don't specify required fields,
        /// Amazon Lex throws an exception. When you update the <c>$LATEST</c> version of a slot
        /// type, if a bot uses the <c>$LATEST</c> version of an intent that contains the slot
        /// type, the bot's <c>status</c> field is set to <c>NOT_BUILT</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <c>lex:PutSlotType</c> action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSlotTypeResponseUnmarshaller.Instance;

            return Invoke<PutSlotTypeResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSlotTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportResponseUnmarshaller.Instance;

            return Invoke<StartImportResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  StartMigration

        /// <summary>
        /// Starts migrating a bot from Amazon Lex V1 to Amazon Lex V2. Migrate your bot when
        /// you want to take advantage of the new features of Amazon Lex V2.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/migrate.html">Migrating
        /// a bot</a> in the <i>Amazon Lex developer guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMigration service method.</param>
        /// 
        /// <returns>The response from the StartMigration service method, as returned by LexModelBuildingService.</returns>
        /// <exception cref="Amazon.LexModelBuildingService.Model.AccessDeniedException">
        /// Your IAM user or role does not have permission to call the Amazon Lex V2 APIs required
        /// to migrate your bot.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/StartMigration">REST API Reference for StartMigration Operation</seealso>
        public virtual StartMigrationResponse StartMigration(StartMigrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMigrationResponseUnmarshaller.Instance;

            return Invoke<StartMigrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMigration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMigration operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMigration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/StartMigration">REST API Reference for StartMigration Operation</seealso>
        public virtual IAsyncResult BeginStartMigration(StartMigrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMigrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMigration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMigration.</param>
        /// 
        /// <returns>Returns a  StartMigrationResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/StartMigration">REST API Reference for StartMigration Operation</seealso>
        public virtual StartMigrationResponse EndStartMigration(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMigrationResponse>(asyncResult);
        }

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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLexModelBuildingServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from LexModelBuildingService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonLexModelBuildingServiceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}