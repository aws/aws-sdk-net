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
using System.Net;

using Amazon.LexModelBuildingService.Model;
using Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations;
using Amazon.LexModelBuildingService.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonLexModelBuildingServiceMetadata();
        
        #region Constructors

#if CORECLR
    
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

#endif

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

        internal virtual CreateBotVersionResponse CreateBotVersion(CreateBotVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBotVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBotVersionResponseUnmarshaller.Instance;

            return Invoke<CreateBotVersionResponse>(request, options);
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
        public virtual Task<CreateBotVersionResponse> CreateBotVersionAsync(CreateBotVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBotVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBotVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBotVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIntentVersion

        internal virtual CreateIntentVersionResponse CreateIntentVersion(CreateIntentVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntentVersionResponseUnmarshaller.Instance;

            return Invoke<CreateIntentVersionResponse>(request, options);
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
        public virtual Task<CreateIntentVersionResponse> CreateIntentVersionAsync(CreateIntentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntentVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSlotTypeVersion

        internal virtual CreateSlotTypeVersionResponse CreateSlotTypeVersion(CreateSlotTypeVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSlotTypeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSlotTypeVersionResponseUnmarshaller.Instance;

            return Invoke<CreateSlotTypeVersionResponse>(request, options);
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
        public virtual Task<CreateSlotTypeVersionResponse> CreateSlotTypeVersionAsync(CreateSlotTypeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSlotTypeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSlotTypeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSlotTypeVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBot

        internal virtual DeleteBotResponse DeleteBot(DeleteBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return Invoke<DeleteBotResponse>(request, options);
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
        public virtual Task<DeleteBotResponse> DeleteBotAsync(DeleteBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBotAlias

        internal virtual DeleteBotAliasResponse DeleteBotAlias(DeleteBotAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteBotAliasResponse>(request, options);
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
        public virtual Task<DeleteBotAliasResponse> DeleteBotAliasAsync(DeleteBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBotChannelAssociation

        internal virtual DeleteBotChannelAssociationResponse DeleteBotChannelAssociation(DeleteBotChannelAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBotChannelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotChannelAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteBotChannelAssociationResponse>(request, options);
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
        public virtual Task<DeleteBotChannelAssociationResponse> DeleteBotChannelAssociationAsync(DeleteBotChannelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBotChannelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotChannelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotChannelAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBotVersion

        internal virtual DeleteBotVersionResponse DeleteBotVersion(DeleteBotVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBotVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteBotVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBotVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteBotVersion">REST API Reference for DeleteBotVersion Operation</seealso>
        public virtual Task<DeleteBotVersionResponse> DeleteBotVersionAsync(DeleteBotVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBotVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntent

        internal virtual DeleteIntentResponse DeleteIntent(DeleteIntentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntentResponseUnmarshaller.Instance;

            return Invoke<DeleteIntentResponse>(request, options);
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
        public virtual Task<DeleteIntentResponse> DeleteIntentAsync(DeleteIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntentVersion

        internal virtual DeleteIntentVersionResponse DeleteIntentVersion(DeleteIntentVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntentVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteIntentVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntentVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteIntentVersion">REST API Reference for DeleteIntentVersion Operation</seealso>
        public virtual Task<DeleteIntentVersionResponse> DeleteIntentVersionAsync(DeleteIntentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntentVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSlotType

        internal virtual DeleteSlotTypeResponse DeleteSlotType(DeleteSlotTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlotTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteSlotTypeResponse>(request, options);
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
        public virtual Task<DeleteSlotTypeResponse> DeleteSlotTypeAsync(DeleteSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlotTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSlotTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSlotTypeVersion

        internal virtual DeleteSlotTypeVersionResponse DeleteSlotTypeVersion(DeleteSlotTypeVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSlotTypeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlotTypeVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteSlotTypeVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSlotTypeVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotTypeVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/DeleteSlotTypeVersion">REST API Reference for DeleteSlotTypeVersion Operation</seealso>
        public virtual Task<DeleteSlotTypeVersionResponse> DeleteSlotTypeVersionAsync(DeleteSlotTypeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSlotTypeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlotTypeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSlotTypeVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUtterances

        internal virtual DeleteUtterancesResponse DeleteUtterances(DeleteUtterancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUtterancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUtterancesResponseUnmarshaller.Instance;

            return Invoke<DeleteUtterancesResponse>(request, options);
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
        public virtual Task<DeleteUtterancesResponse> DeleteUtterancesAsync(DeleteUtterancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUtterancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUtterancesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUtterancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBot

        internal virtual GetBotResponse GetBot(GetBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotResponseUnmarshaller.Instance;

            return Invoke<GetBotResponse>(request, options);
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
        public virtual Task<GetBotResponse> GetBotAsync(GetBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBotAlias

        internal virtual GetBotAliasResponse GetBotAlias(GetBotAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotAliasResponseUnmarshaller.Instance;

            return Invoke<GetBotAliasResponse>(request, options);
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
        public virtual Task<GetBotAliasResponse> GetBotAliasAsync(GetBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotAliasResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBotAliases

        internal virtual GetBotAliasesResponse GetBotAliases(GetBotAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotAliasesResponseUnmarshaller.Instance;

            return Invoke<GetBotAliasesResponse>(request, options);
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
        public virtual Task<GetBotAliasesResponse> GetBotAliasesAsync(GetBotAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBotChannelAssociation

        internal virtual GetBotChannelAssociationResponse GetBotChannelAssociation(GetBotChannelAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotChannelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotChannelAssociationResponseUnmarshaller.Instance;

            return Invoke<GetBotChannelAssociationResponse>(request, options);
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
        public virtual Task<GetBotChannelAssociationResponse> GetBotChannelAssociationAsync(GetBotChannelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotChannelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotChannelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotChannelAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBotChannelAssociations

        internal virtual GetBotChannelAssociationsResponse GetBotChannelAssociations(GetBotChannelAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotChannelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotChannelAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetBotChannelAssociationsResponse>(request, options);
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
        public virtual Task<GetBotChannelAssociationsResponse> GetBotChannelAssociationsAsync(GetBotChannelAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotChannelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotChannelAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotChannelAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBots

        internal virtual GetBotsResponse GetBots(GetBotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotsResponseUnmarshaller.Instance;

            return Invoke<GetBotsResponse>(request, options);
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
        public virtual Task<GetBotsResponse> GetBotsAsync(GetBotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBotVersions

        internal virtual GetBotVersionsResponse GetBotVersions(GetBotVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotVersionsResponseUnmarshaller.Instance;

            return Invoke<GetBotVersionsResponse>(request, options);
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
        public virtual Task<GetBotVersionsResponse> GetBotVersionsAsync(GetBotVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBuiltinIntent

        internal virtual GetBuiltinIntentResponse GetBuiltinIntent(GetBuiltinIntentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBuiltinIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinIntentResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinIntentResponse>(request, options);
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
        public virtual Task<GetBuiltinIntentResponse> GetBuiltinIntentAsync(GetBuiltinIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBuiltinIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinIntentResponseUnmarshaller.Instance;

            return InvokeAsync<GetBuiltinIntentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBuiltinIntents

        internal virtual GetBuiltinIntentsResponse GetBuiltinIntents(GetBuiltinIntentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBuiltinIntentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinIntentsResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinIntentsResponse>(request, options);
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
        public virtual Task<GetBuiltinIntentsResponse> GetBuiltinIntentsAsync(GetBuiltinIntentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBuiltinIntentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinIntentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBuiltinIntentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBuiltinSlotTypes

        internal virtual GetBuiltinSlotTypesResponse GetBuiltinSlotTypes(GetBuiltinSlotTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBuiltinSlotTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinSlotTypesResponseUnmarshaller.Instance;

            return Invoke<GetBuiltinSlotTypesResponse>(request, options);
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
        public virtual Task<GetBuiltinSlotTypesResponse> GetBuiltinSlotTypesAsync(GetBuiltinSlotTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBuiltinSlotTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuiltinSlotTypesResponseUnmarshaller.Instance;

            return InvokeAsync<GetBuiltinSlotTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExport

        internal virtual GetExportResponse GetExport(GetExportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportResponseUnmarshaller.Instance;

            return Invoke<GetExportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetExport">REST API Reference for GetExport Operation</seealso>
        public virtual Task<GetExportResponse> GetExportAsync(GetExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetImport

        internal virtual GetImportResponse GetImport(GetImportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportResponseUnmarshaller.Instance;

            return Invoke<GetImportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/GetImport">REST API Reference for GetImport Operation</seealso>
        public virtual Task<GetImportResponse> GetImportAsync(GetImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntent

        internal virtual GetIntentResponse GetIntent(GetIntentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentResponseUnmarshaller.Instance;

            return Invoke<GetIntentResponse>(request, options);
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
        public virtual Task<GetIntentResponse> GetIntentAsync(GetIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntents

        internal virtual GetIntentsResponse GetIntents(GetIntentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentsResponseUnmarshaller.Instance;

            return Invoke<GetIntentsResponse>(request, options);
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
        public virtual Task<GetIntentsResponse> GetIntentsAsync(GetIntentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntentVersions

        internal virtual GetIntentVersionsResponse GetIntentVersions(GetIntentVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentVersionsResponseUnmarshaller.Instance;

            return Invoke<GetIntentVersionsResponse>(request, options);
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
        public virtual Task<GetIntentVersionsResponse> GetIntentVersionsAsync(GetIntentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntentVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSlotType

        internal virtual GetSlotTypeResponse GetSlotType(GetSlotTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypeResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypeResponse>(request, options);
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
        public virtual Task<GetSlotTypeResponse> GetSlotTypeAsync(GetSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetSlotTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSlotTypes

        internal virtual GetSlotTypesResponse GetSlotTypes(GetSlotTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSlotTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypesResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypesResponse>(request, options);
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
        public virtual Task<GetSlotTypesResponse> GetSlotTypesAsync(GetSlotTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSlotTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSlotTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSlotTypeVersions

        internal virtual GetSlotTypeVersionsResponse GetSlotTypeVersions(GetSlotTypeVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSlotTypeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypeVersionsResponseUnmarshaller.Instance;

            return Invoke<GetSlotTypeVersionsResponse>(request, options);
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
        public virtual Task<GetSlotTypeVersionsResponse> GetSlotTypeVersionsAsync(GetSlotTypeVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSlotTypeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSlotTypeVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSlotTypeVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUtterancesView

        internal virtual GetUtterancesViewResponse GetUtterancesView(GetUtterancesViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUtterancesViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUtterancesViewResponseUnmarshaller.Instance;

            return Invoke<GetUtterancesViewResponse>(request, options);
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
        public virtual Task<GetUtterancesViewResponse> GetUtterancesViewAsync(GetUtterancesViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUtterancesViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUtterancesViewResponseUnmarshaller.Instance;

            return InvokeAsync<GetUtterancesViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBot

        internal virtual PutBotResponse PutBot(PutBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBotResponseUnmarshaller.Instance;

            return Invoke<PutBotResponse>(request, options);
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
        public virtual Task<PutBotResponse> PutBotAsync(PutBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBotResponseUnmarshaller.Instance;

            return InvokeAsync<PutBotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBotAlias

        internal virtual PutBotAliasResponse PutBotAlias(PutBotAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBotAliasResponseUnmarshaller.Instance;

            return Invoke<PutBotAliasResponse>(request, options);
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
        public virtual Task<PutBotAliasResponse> PutBotAliasAsync(PutBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBotAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBotAliasResponseUnmarshaller.Instance;

            return InvokeAsync<PutBotAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutIntent

        internal virtual PutIntentResponse PutIntent(PutIntentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntentResponseUnmarshaller.Instance;

            return Invoke<PutIntentResponse>(request, options);
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
        public virtual Task<PutIntentResponse> PutIntentAsync(PutIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutIntentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntentResponseUnmarshaller.Instance;

            return InvokeAsync<PutIntentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSlotType

        internal virtual PutSlotTypeResponse PutSlotType(PutSlotTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSlotTypeResponseUnmarshaller.Instance;

            return Invoke<PutSlotTypeResponse>(request, options);
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
        public virtual Task<PutSlotTypeResponse> PutSlotTypeAsync(PutSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSlotTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSlotTypeResponseUnmarshaller.Instance;

            return InvokeAsync<PutSlotTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartImport

        internal virtual StartImportResponse StartImport(StartImportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportResponseUnmarshaller.Instance;

            return Invoke<StartImportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lex-models-2017-04-19/StartImport">REST API Reference for StartImport Operation</seealso>
        public virtual Task<StartImportResponse> StartImportAsync(StartImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportResponseUnmarshaller.Instance;

            return InvokeAsync<StartImportResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}