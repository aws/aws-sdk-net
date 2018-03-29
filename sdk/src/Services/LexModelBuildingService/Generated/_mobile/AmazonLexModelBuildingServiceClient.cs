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
            var marshaller = CreateBotVersionRequestMarshaller.Instance;
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
        public virtual Task<CreateBotVersionResponse> CreateBotVersionAsync(CreateBotVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateBotVersionRequestMarshaller.Instance;
            var unmarshaller = CreateBotVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBotVersionRequest,CreateBotVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateIntentVersion

        internal virtual CreateIntentVersionResponse CreateIntentVersion(CreateIntentVersionRequest request)
        {
            var marshaller = CreateIntentVersionRequestMarshaller.Instance;
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
        public virtual Task<CreateIntentVersionResponse> CreateIntentVersionAsync(CreateIntentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateIntentVersionRequestMarshaller.Instance;
            var unmarshaller = CreateIntentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntentVersionRequest,CreateIntentVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSlotTypeVersion

        internal virtual CreateSlotTypeVersionResponse CreateSlotTypeVersion(CreateSlotTypeVersionRequest request)
        {
            var marshaller = CreateSlotTypeVersionRequestMarshaller.Instance;
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
        public virtual Task<CreateSlotTypeVersionResponse> CreateSlotTypeVersionAsync(CreateSlotTypeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSlotTypeVersionRequestMarshaller.Instance;
            var unmarshaller = CreateSlotTypeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSlotTypeVersionRequest,CreateSlotTypeVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBot

        internal virtual DeleteBotResponse DeleteBot(DeleteBotRequest request)
        {
            var marshaller = DeleteBotRequestMarshaller.Instance;
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
        public virtual Task<DeleteBotResponse> DeleteBotAsync(DeleteBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteBotRequestMarshaller.Instance;
            var unmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotRequest,DeleteBotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBotAlias

        internal virtual DeleteBotAliasResponse DeleteBotAlias(DeleteBotAliasRequest request)
        {
            var marshaller = DeleteBotAliasRequestMarshaller.Instance;
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
        public virtual Task<DeleteBotAliasResponse> DeleteBotAliasAsync(DeleteBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteBotAliasRequestMarshaller.Instance;
            var unmarshaller = DeleteBotAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotAliasRequest,DeleteBotAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBotChannelAssociation

        internal virtual DeleteBotChannelAssociationResponse DeleteBotChannelAssociation(DeleteBotChannelAssociationRequest request)
        {
            var marshaller = DeleteBotChannelAssociationRequestMarshaller.Instance;
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
        public virtual Task<DeleteBotChannelAssociationResponse> DeleteBotChannelAssociationAsync(DeleteBotChannelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteBotChannelAssociationRequestMarshaller.Instance;
            var unmarshaller = DeleteBotChannelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotChannelAssociationRequest,DeleteBotChannelAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBotVersion

        internal virtual DeleteBotVersionResponse DeleteBotVersion(DeleteBotVersionRequest request)
        {
            var marshaller = DeleteBotVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteBotVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteBotVersionRequest,DeleteBotVersionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteBotVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteBotVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBotVersionRequest,DeleteBotVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntent

        internal virtual DeleteIntentResponse DeleteIntent(DeleteIntentRequest request)
        {
            var marshaller = DeleteIntentRequestMarshaller.Instance;
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
        public virtual Task<DeleteIntentResponse> DeleteIntentAsync(DeleteIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteIntentRequestMarshaller.Instance;
            var unmarshaller = DeleteIntentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntentRequest,DeleteIntentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntentVersion

        internal virtual DeleteIntentVersionResponse DeleteIntentVersion(DeleteIntentVersionRequest request)
        {
            var marshaller = DeleteIntentVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteIntentVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteIntentVersionRequest,DeleteIntentVersionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteIntentVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteIntentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntentVersionRequest,DeleteIntentVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSlotType

        internal virtual DeleteSlotTypeResponse DeleteSlotType(DeleteSlotTypeRequest request)
        {
            var marshaller = DeleteSlotTypeRequestMarshaller.Instance;
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
        public virtual Task<DeleteSlotTypeResponse> DeleteSlotTypeAsync(DeleteSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSlotTypeRequestMarshaller.Instance;
            var unmarshaller = DeleteSlotTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSlotTypeRequest,DeleteSlotTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSlotTypeVersion

        internal virtual DeleteSlotTypeVersionResponse DeleteSlotTypeVersion(DeleteSlotTypeVersionRequest request)
        {
            var marshaller = DeleteSlotTypeVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteSlotTypeVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteSlotTypeVersionRequest,DeleteSlotTypeVersionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteSlotTypeVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteSlotTypeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSlotTypeVersionRequest,DeleteSlotTypeVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUtterances

        internal virtual DeleteUtterancesResponse DeleteUtterances(DeleteUtterancesRequest request)
        {
            var marshaller = DeleteUtterancesRequestMarshaller.Instance;
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
        public virtual Task<DeleteUtterancesResponse> DeleteUtterancesAsync(DeleteUtterancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteUtterancesRequestMarshaller.Instance;
            var unmarshaller = DeleteUtterancesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUtterancesRequest,DeleteUtterancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBot

        internal virtual GetBotResponse GetBot(GetBotRequest request)
        {
            var marshaller = GetBotRequestMarshaller.Instance;
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
        public virtual Task<GetBotResponse> GetBotAsync(GetBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBotRequestMarshaller.Instance;
            var unmarshaller = GetBotResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotRequest,GetBotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBotAlias

        internal virtual GetBotAliasResponse GetBotAlias(GetBotAliasRequest request)
        {
            var marshaller = GetBotAliasRequestMarshaller.Instance;
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
        public virtual Task<GetBotAliasResponse> GetBotAliasAsync(GetBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBotAliasRequestMarshaller.Instance;
            var unmarshaller = GetBotAliasResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotAliasRequest,GetBotAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBotAliases

        internal virtual GetBotAliasesResponse GetBotAliases(GetBotAliasesRequest request)
        {
            var marshaller = GetBotAliasesRequestMarshaller.Instance;
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
        public virtual Task<GetBotAliasesResponse> GetBotAliasesAsync(GetBotAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBotAliasesRequestMarshaller.Instance;
            var unmarshaller = GetBotAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotAliasesRequest,GetBotAliasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBotChannelAssociation

        internal virtual GetBotChannelAssociationResponse GetBotChannelAssociation(GetBotChannelAssociationRequest request)
        {
            var marshaller = GetBotChannelAssociationRequestMarshaller.Instance;
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
        public virtual Task<GetBotChannelAssociationResponse> GetBotChannelAssociationAsync(GetBotChannelAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBotChannelAssociationRequestMarshaller.Instance;
            var unmarshaller = GetBotChannelAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotChannelAssociationRequest,GetBotChannelAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBotChannelAssociations

        internal virtual GetBotChannelAssociationsResponse GetBotChannelAssociations(GetBotChannelAssociationsRequest request)
        {
            var marshaller = GetBotChannelAssociationsRequestMarshaller.Instance;
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
        public virtual Task<GetBotChannelAssociationsResponse> GetBotChannelAssociationsAsync(GetBotChannelAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBotChannelAssociationsRequestMarshaller.Instance;
            var unmarshaller = GetBotChannelAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotChannelAssociationsRequest,GetBotChannelAssociationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBots

        internal virtual GetBotsResponse GetBots(GetBotsRequest request)
        {
            var marshaller = GetBotsRequestMarshaller.Instance;
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
        public virtual Task<GetBotsResponse> GetBotsAsync(GetBotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBotsRequestMarshaller.Instance;
            var unmarshaller = GetBotsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotsRequest,GetBotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBotVersions

        internal virtual GetBotVersionsResponse GetBotVersions(GetBotVersionsRequest request)
        {
            var marshaller = GetBotVersionsRequestMarshaller.Instance;
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
        public virtual Task<GetBotVersionsResponse> GetBotVersionsAsync(GetBotVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBotVersionsRequestMarshaller.Instance;
            var unmarshaller = GetBotVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBotVersionsRequest,GetBotVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBuiltinIntent

        internal virtual GetBuiltinIntentResponse GetBuiltinIntent(GetBuiltinIntentRequest request)
        {
            var marshaller = GetBuiltinIntentRequestMarshaller.Instance;
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
        public virtual Task<GetBuiltinIntentResponse> GetBuiltinIntentAsync(GetBuiltinIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBuiltinIntentRequestMarshaller.Instance;
            var unmarshaller = GetBuiltinIntentResponseUnmarshaller.Instance;

            return InvokeAsync<GetBuiltinIntentRequest,GetBuiltinIntentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBuiltinIntents

        internal virtual GetBuiltinIntentsResponse GetBuiltinIntents(GetBuiltinIntentsRequest request)
        {
            var marshaller = GetBuiltinIntentsRequestMarshaller.Instance;
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
        public virtual Task<GetBuiltinIntentsResponse> GetBuiltinIntentsAsync(GetBuiltinIntentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBuiltinIntentsRequestMarshaller.Instance;
            var unmarshaller = GetBuiltinIntentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBuiltinIntentsRequest,GetBuiltinIntentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBuiltinSlotTypes

        internal virtual GetBuiltinSlotTypesResponse GetBuiltinSlotTypes(GetBuiltinSlotTypesRequest request)
        {
            var marshaller = GetBuiltinSlotTypesRequestMarshaller.Instance;
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
        public virtual Task<GetBuiltinSlotTypesResponse> GetBuiltinSlotTypesAsync(GetBuiltinSlotTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBuiltinSlotTypesRequestMarshaller.Instance;
            var unmarshaller = GetBuiltinSlotTypesResponseUnmarshaller.Instance;

            return InvokeAsync<GetBuiltinSlotTypesRequest,GetBuiltinSlotTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetExport

        internal virtual GetExportResponse GetExport(GetExportRequest request)
        {
            var marshaller = GetExportRequestMarshaller.Instance;
            var unmarshaller = GetExportResponseUnmarshaller.Instance;

            return Invoke<GetExportRequest,GetExportResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetExportRequestMarshaller.Instance;
            var unmarshaller = GetExportResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportRequest,GetExportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetImport

        internal virtual GetImportResponse GetImport(GetImportRequest request)
        {
            var marshaller = GetImportRequestMarshaller.Instance;
            var unmarshaller = GetImportResponseUnmarshaller.Instance;

            return Invoke<GetImportRequest,GetImportResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetImportRequestMarshaller.Instance;
            var unmarshaller = GetImportResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportRequest,GetImportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIntent

        internal virtual GetIntentResponse GetIntent(GetIntentRequest request)
        {
            var marshaller = GetIntentRequestMarshaller.Instance;
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
        public virtual Task<GetIntentResponse> GetIntentAsync(GetIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIntentRequestMarshaller.Instance;
            var unmarshaller = GetIntentResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntentRequest,GetIntentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIntents

        internal virtual GetIntentsResponse GetIntents(GetIntentsRequest request)
        {
            var marshaller = GetIntentsRequestMarshaller.Instance;
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
        public virtual Task<GetIntentsResponse> GetIntentsAsync(GetIntentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIntentsRequestMarshaller.Instance;
            var unmarshaller = GetIntentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntentsRequest,GetIntentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIntentVersions

        internal virtual GetIntentVersionsResponse GetIntentVersions(GetIntentVersionsRequest request)
        {
            var marshaller = GetIntentVersionsRequestMarshaller.Instance;
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
        public virtual Task<GetIntentVersionsResponse> GetIntentVersionsAsync(GetIntentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIntentVersionsRequestMarshaller.Instance;
            var unmarshaller = GetIntentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntentVersionsRequest,GetIntentVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSlotType

        internal virtual GetSlotTypeResponse GetSlotType(GetSlotTypeRequest request)
        {
            var marshaller = GetSlotTypeRequestMarshaller.Instance;
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
        public virtual Task<GetSlotTypeResponse> GetSlotTypeAsync(GetSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSlotTypeRequestMarshaller.Instance;
            var unmarshaller = GetSlotTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetSlotTypeRequest,GetSlotTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSlotTypes

        internal virtual GetSlotTypesResponse GetSlotTypes(GetSlotTypesRequest request)
        {
            var marshaller = GetSlotTypesRequestMarshaller.Instance;
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
        public virtual Task<GetSlotTypesResponse> GetSlotTypesAsync(GetSlotTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSlotTypesRequestMarshaller.Instance;
            var unmarshaller = GetSlotTypesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSlotTypesRequest,GetSlotTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSlotTypeVersions

        internal virtual GetSlotTypeVersionsResponse GetSlotTypeVersions(GetSlotTypeVersionsRequest request)
        {
            var marshaller = GetSlotTypeVersionsRequestMarshaller.Instance;
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
        public virtual Task<GetSlotTypeVersionsResponse> GetSlotTypeVersionsAsync(GetSlotTypeVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSlotTypeVersionsRequestMarshaller.Instance;
            var unmarshaller = GetSlotTypeVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSlotTypeVersionsRequest,GetSlotTypeVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUtterancesView

        internal virtual GetUtterancesViewResponse GetUtterancesView(GetUtterancesViewRequest request)
        {
            var marshaller = GetUtterancesViewRequestMarshaller.Instance;
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
        public virtual Task<GetUtterancesViewResponse> GetUtterancesViewAsync(GetUtterancesViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetUtterancesViewRequestMarshaller.Instance;
            var unmarshaller = GetUtterancesViewResponseUnmarshaller.Instance;

            return InvokeAsync<GetUtterancesViewRequest,GetUtterancesViewResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBot

        internal virtual PutBotResponse PutBot(PutBotRequest request)
        {
            var marshaller = PutBotRequestMarshaller.Instance;
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
        public virtual Task<PutBotResponse> PutBotAsync(PutBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutBotRequestMarshaller.Instance;
            var unmarshaller = PutBotResponseUnmarshaller.Instance;

            return InvokeAsync<PutBotRequest,PutBotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBotAlias

        internal virtual PutBotAliasResponse PutBotAlias(PutBotAliasRequest request)
        {
            var marshaller = PutBotAliasRequestMarshaller.Instance;
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
        public virtual Task<PutBotAliasResponse> PutBotAliasAsync(PutBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutBotAliasRequestMarshaller.Instance;
            var unmarshaller = PutBotAliasResponseUnmarshaller.Instance;

            return InvokeAsync<PutBotAliasRequest,PutBotAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutIntent

        internal virtual PutIntentResponse PutIntent(PutIntentRequest request)
        {
            var marshaller = PutIntentRequestMarshaller.Instance;
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
        public virtual Task<PutIntentResponse> PutIntentAsync(PutIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutIntentRequestMarshaller.Instance;
            var unmarshaller = PutIntentResponseUnmarshaller.Instance;

            return InvokeAsync<PutIntentRequest,PutIntentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutSlotType

        internal virtual PutSlotTypeResponse PutSlotType(PutSlotTypeRequest request)
        {
            var marshaller = PutSlotTypeRequestMarshaller.Instance;
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
        public virtual Task<PutSlotTypeResponse> PutSlotTypeAsync(PutSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutSlotTypeRequestMarshaller.Instance;
            var unmarshaller = PutSlotTypeResponseUnmarshaller.Instance;

            return InvokeAsync<PutSlotTypeRequest,PutSlotTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartImport

        internal virtual StartImportResponse StartImport(StartImportRequest request)
        {
            var marshaller = StartImportRequestMarshaller.Instance;
            var unmarshaller = StartImportResponseUnmarshaller.Instance;

            return Invoke<StartImportRequest,StartImportResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartImportRequestMarshaller.Instance;
            var unmarshaller = StartImportResponseUnmarshaller.Instance;

            return InvokeAsync<StartImportRequest,StartImportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}