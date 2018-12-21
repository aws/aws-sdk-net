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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AppSync.Model;
using Amazon.AppSync.Model.Internal.MarshallTransformations;
using Amazon.AppSync.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AppSync
{
    /// <summary>
    /// Implementation for accessing AppSync
    ///
    /// AWS AppSync provides API actions for creating and interacting with data sources using
    /// GraphQL from your application.
    /// </summary>
    public partial class AmazonAppSyncClient : AmazonServiceClient, IAmazonAppSync
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppSyncMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonAppSyncClient with the credentials loaded from the application's
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
        public AmazonAppSyncClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppSyncConfig()) { }

        /// <summary>
        /// Constructs AmazonAppSyncClient with the credentials loaded from the application's
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
        public AmazonAppSyncClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppSyncConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppSyncClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppSyncClient Configuration Object</param>
        public AmazonAppSyncClient(AmazonAppSyncConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppSyncClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppSyncClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Credentials and an
        /// AmazonAppSyncClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppSyncClient Configuration Object</param>
        public AmazonAppSyncClient(AWSCredentials credentials, AmazonAppSyncConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppSyncConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppSyncClient Configuration Object</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppSyncClient Configuration Object</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppSyncConfig clientConfig)
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


        #region  CreateApiKey

        internal virtual CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return Invoke<CreateApiKeyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        public virtual Task<CreateApiKeyResponse> CreateApiKeyAsync(CreateApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataSource

        internal virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFunction

        internal virtual CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGraphqlApi

        internal virtual CreateGraphqlApiResponse CreateGraphqlApi(CreateGraphqlApiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<CreateGraphqlApiResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphqlApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateGraphqlApi">REST API Reference for CreateGraphqlApi Operation</seealso>
        public virtual Task<CreateGraphqlApiResponse> CreateGraphqlApiAsync(CreateGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGraphqlApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResolver

        internal virtual CreateResolverResponse CreateResolver(CreateResolverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverResponseUnmarshaller.Instance;

            return Invoke<CreateResolverResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateResolver operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResolver operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateResolver">REST API Reference for CreateResolver Operation</seealso>
        public virtual Task<CreateResolverResponse> CreateResolverAsync(CreateResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResolverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateType

        internal virtual CreateTypeResponse CreateType(CreateTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypeResponseUnmarshaller.Instance;

            return Invoke<CreateTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateType">REST API Reference for CreateType Operation</seealso>
        public virtual Task<CreateTypeResponse> CreateTypeAsync(CreateTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApiKey

        internal virtual DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteApiKeyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        public virtual Task<DeleteApiKeyResponse> DeleteApiKeyAsync(DeleteApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataSource

        internal virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFunction

        internal virtual DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGraphqlApi

        internal virtual DeleteGraphqlApiResponse DeleteGraphqlApi(DeleteGraphqlApiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<DeleteGraphqlApiResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraphqlApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteGraphqlApi">REST API Reference for DeleteGraphqlApi Operation</seealso>
        public virtual Task<DeleteGraphqlApiResponse> DeleteGraphqlApiAsync(DeleteGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGraphqlApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResolver

        internal virtual DeleteResolverResponse DeleteResolver(DeleteResolverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverResponseUnmarshaller.Instance;

            return Invoke<DeleteResolverResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResolver operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolver operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteResolver">REST API Reference for DeleteResolver Operation</seealso>
        public virtual Task<DeleteResolverResponse> DeleteResolverAsync(DeleteResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResolverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteType

        internal virtual DeleteTypeResponse DeleteType(DeleteTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteType">REST API Reference for DeleteType Operation</seealso>
        public virtual Task<DeleteTypeResponse> DeleteTypeAsync(DeleteTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataSource

        internal virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFunction

        internal virtual GetFunctionResponse GetFunction(GetFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual Task<GetFunctionResponse> GetFunctionAsync(GetFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGraphqlApi

        internal virtual GetGraphqlApiResponse GetGraphqlApi(GetGraphqlApiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<GetGraphqlApiResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGraphqlApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetGraphqlApi">REST API Reference for GetGraphqlApi Operation</seealso>
        public virtual Task<GetGraphqlApiResponse> GetGraphqlApiAsync(GetGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<GetGraphqlApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntrospectionSchema

        internal virtual GetIntrospectionSchemaResponse GetIntrospectionSchema(GetIntrospectionSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntrospectionSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntrospectionSchemaResponseUnmarshaller.Instance;

            return Invoke<GetIntrospectionSchemaResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIntrospectionSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntrospectionSchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetIntrospectionSchema">REST API Reference for GetIntrospectionSchema Operation</seealso>
        public virtual Task<GetIntrospectionSchemaResponse> GetIntrospectionSchemaAsync(GetIntrospectionSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntrospectionSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntrospectionSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntrospectionSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolver

        internal virtual GetResolverResponse GetResolver(GetResolverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverResponseUnmarshaller.Instance;

            return Invoke<GetResolverResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetResolver operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolver operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetResolver">REST API Reference for GetResolver Operation</seealso>
        public virtual Task<GetResolverResponse> GetResolverAsync(GetResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSchemaCreationStatus

        internal virtual GetSchemaCreationStatusResponse GetSchemaCreationStatus(GetSchemaCreationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaCreationStatusResponseUnmarshaller.Instance;

            return Invoke<GetSchemaCreationStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaCreationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaCreationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetSchemaCreationStatus">REST API Reference for GetSchemaCreationStatus Operation</seealso>
        public virtual Task<GetSchemaCreationStatusResponse> GetSchemaCreationStatusAsync(GetSchemaCreationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaCreationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaCreationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetType

        internal virtual GetTypeResponse GetType(GetTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypeResponseUnmarshaller.Instance;

            return Invoke<GetTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetType">REST API Reference for GetType Operation</seealso>
        public virtual Task<GetTypeResponse> GetTypeAsync(GetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApiKeys

        internal virtual ListApiKeysResponse ListApiKeys(ListApiKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApiKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiKeysResponseUnmarshaller.Instance;

            return Invoke<ListApiKeysResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListApiKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApiKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListApiKeys">REST API Reference for ListApiKeys Operation</seealso>
        public virtual Task<ListApiKeysResponse> ListApiKeysAsync(ListApiKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApiKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListApiKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSources

        internal virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFunctions

        internal virtual ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGraphqlApis

        internal virtual ListGraphqlApisResponse ListGraphqlApis(ListGraphqlApisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGraphqlApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphqlApisResponseUnmarshaller.Instance;

            return Invoke<ListGraphqlApisResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGraphqlApis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGraphqlApis operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListGraphqlApis">REST API Reference for ListGraphqlApis Operation</seealso>
        public virtual Task<ListGraphqlApisResponse> ListGraphqlApisAsync(ListGraphqlApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGraphqlApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphqlApisResponseUnmarshaller.Instance;

            return InvokeAsync<ListGraphqlApisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolvers

        internal virtual ListResolversResponse ListResolvers(ListResolversRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversResponseUnmarshaller.Instance;

            return Invoke<ListResolversResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListResolvers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolvers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolvers">REST API Reference for ListResolvers Operation</seealso>
        public virtual Task<ListResolversResponse> ListResolversAsync(ListResolversRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolversResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolversByFunction

        internal virtual ListResolversByFunctionResponse ListResolversByFunction(ListResolversByFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolversByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversByFunctionResponseUnmarshaller.Instance;

            return Invoke<ListResolversByFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListResolversByFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolversByFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolversByFunction">REST API Reference for ListResolversByFunction Operation</seealso>
        public virtual Task<ListResolversByFunctionResponse> ListResolversByFunctionAsync(ListResolversByFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolversByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversByFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolversByFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTypes

        internal virtual ListTypesResponse ListTypes(ListTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;

            return Invoke<ListTypesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTypes">REST API Reference for ListTypes Operation</seealso>
        public virtual Task<ListTypesResponse> ListTypesAsync(ListTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSchemaCreation

        internal virtual StartSchemaCreationResponse StartSchemaCreation(StartSchemaCreationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSchemaCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaCreationResponseUnmarshaller.Instance;

            return Invoke<StartSchemaCreationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartSchemaCreation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaCreation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartSchemaCreation">REST API Reference for StartSchemaCreation Operation</seealso>
        public virtual Task<StartSchemaCreationResponse> StartSchemaCreationAsync(StartSchemaCreationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSchemaCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaCreationResponseUnmarshaller.Instance;

            return InvokeAsync<StartSchemaCreationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApiKey

        internal virtual UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateApiKeyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        public virtual Task<UpdateApiKeyResponse> UpdateApiKeyAsync(UpdateApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataSource

        internal virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFunction

        internal virtual UpdateFunctionResponse UpdateFunction(UpdateFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        public virtual Task<UpdateFunctionResponse> UpdateFunctionAsync(UpdateFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGraphqlApi

        internal virtual UpdateGraphqlApiResponse UpdateGraphqlApi(UpdateGraphqlApiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<UpdateGraphqlApiResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGraphqlApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateGraphqlApi">REST API Reference for UpdateGraphqlApi Operation</seealso>
        public virtual Task<UpdateGraphqlApiResponse> UpdateGraphqlApiAsync(UpdateGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGraphqlApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResolver

        internal virtual UpdateResolverResponse UpdateResolver(UpdateResolverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResolver operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolver operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateResolver">REST API Reference for UpdateResolver Operation</seealso>
        public virtual Task<UpdateResolverResponse> UpdateResolverAsync(UpdateResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResolverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateType

        internal virtual UpdateTypeResponse UpdateType(UpdateTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateType">REST API Reference for UpdateType Operation</seealso>
        public virtual Task<UpdateTypeResponse> UpdateTypeAsync(UpdateTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}