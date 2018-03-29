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

using Amazon.AppSync.Model;
using Amazon.AppSync.Model.Internal.MarshallTransformations;
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
            var marshaller = CreateApiKeyRequestMarshaller.Instance;
            var unmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return Invoke<CreateApiKeyRequest,CreateApiKeyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateApiKeyRequestMarshaller.Instance;
            var unmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiKeyRequest,CreateApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDataSource

        internal virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var marshaller = CreateDataSourceRequestMarshaller.Instance;
            var unmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceRequest,CreateDataSourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateDataSourceRequestMarshaller.Instance;
            var unmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSourceRequest,CreateDataSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGraphqlApi

        internal virtual CreateGraphqlApiResponse CreateGraphqlApi(CreateGraphqlApiRequest request)
        {
            var marshaller = CreateGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = CreateGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<CreateGraphqlApiRequest,CreateGraphqlApiResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = CreateGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGraphqlApiRequest,CreateGraphqlApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateResolver

        internal virtual CreateResolverResponse CreateResolver(CreateResolverRequest request)
        {
            var marshaller = CreateResolverRequestMarshaller.Instance;
            var unmarshaller = CreateResolverResponseUnmarshaller.Instance;

            return Invoke<CreateResolverRequest,CreateResolverResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateResolverRequestMarshaller.Instance;
            var unmarshaller = CreateResolverResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResolverRequest,CreateResolverResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateType

        internal virtual CreateTypeResponse CreateType(CreateTypeRequest request)
        {
            var marshaller = CreateTypeRequestMarshaller.Instance;
            var unmarshaller = CreateTypeResponseUnmarshaller.Instance;

            return Invoke<CreateTypeRequest,CreateTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateTypeRequestMarshaller.Instance;
            var unmarshaller = CreateTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTypeRequest,CreateTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApiKey

        internal virtual DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
        {
            var marshaller = DeleteApiKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteApiKeyRequest,DeleteApiKeyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApiKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiKeyRequest,DeleteApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataSource

        internal virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var marshaller = DeleteDataSourceRequestMarshaller.Instance;
            var unmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceRequest,DeleteDataSourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteDataSourceRequestMarshaller.Instance;
            var unmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSourceRequest,DeleteDataSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGraphqlApi

        internal virtual DeleteGraphqlApiResponse DeleteGraphqlApi(DeleteGraphqlApiRequest request)
        {
            var marshaller = DeleteGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = DeleteGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<DeleteGraphqlApiRequest,DeleteGraphqlApiResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = DeleteGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGraphqlApiRequest,DeleteGraphqlApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteResolver

        internal virtual DeleteResolverResponse DeleteResolver(DeleteResolverRequest request)
        {
            var marshaller = DeleteResolverRequestMarshaller.Instance;
            var unmarshaller = DeleteResolverResponseUnmarshaller.Instance;

            return Invoke<DeleteResolverRequest,DeleteResolverResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteResolverRequestMarshaller.Instance;
            var unmarshaller = DeleteResolverResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResolverRequest,DeleteResolverResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteType

        internal virtual DeleteTypeResponse DeleteType(DeleteTypeRequest request)
        {
            var marshaller = DeleteTypeRequestMarshaller.Instance;
            var unmarshaller = DeleteTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteTypeRequest,DeleteTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteTypeRequestMarshaller.Instance;
            var unmarshaller = DeleteTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTypeRequest,DeleteTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDataSource

        internal virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var marshaller = GetDataSourceRequestMarshaller.Instance;
            var unmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceRequest,GetDataSourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetDataSourceRequestMarshaller.Instance;
            var unmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSourceRequest,GetDataSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGraphqlApi

        internal virtual GetGraphqlApiResponse GetGraphqlApi(GetGraphqlApiRequest request)
        {
            var marshaller = GetGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = GetGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<GetGraphqlApiRequest,GetGraphqlApiResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = GetGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<GetGraphqlApiRequest,GetGraphqlApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIntrospectionSchema

        internal virtual GetIntrospectionSchemaResponse GetIntrospectionSchema(GetIntrospectionSchemaRequest request)
        {
            var marshaller = GetIntrospectionSchemaRequestMarshaller.Instance;
            var unmarshaller = GetIntrospectionSchemaResponseUnmarshaller.Instance;

            return Invoke<GetIntrospectionSchemaRequest,GetIntrospectionSchemaResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetIntrospectionSchemaRequestMarshaller.Instance;
            var unmarshaller = GetIntrospectionSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntrospectionSchemaRequest,GetIntrospectionSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResolver

        internal virtual GetResolverResponse GetResolver(GetResolverRequest request)
        {
            var marshaller = GetResolverRequestMarshaller.Instance;
            var unmarshaller = GetResolverResponseUnmarshaller.Instance;

            return Invoke<GetResolverRequest,GetResolverResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetResolverRequestMarshaller.Instance;
            var unmarshaller = GetResolverResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverRequest,GetResolverResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSchemaCreationStatus

        internal virtual GetSchemaCreationStatusResponse GetSchemaCreationStatus(GetSchemaCreationStatusRequest request)
        {
            var marshaller = GetSchemaCreationStatusRequestMarshaller.Instance;
            var unmarshaller = GetSchemaCreationStatusResponseUnmarshaller.Instance;

            return Invoke<GetSchemaCreationStatusRequest,GetSchemaCreationStatusResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSchemaCreationStatusRequestMarshaller.Instance;
            var unmarshaller = GetSchemaCreationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaCreationStatusRequest,GetSchemaCreationStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetType

        internal virtual GetTypeResponse GetType(GetTypeRequest request)
        {
            var marshaller = GetTypeRequestMarshaller.Instance;
            var unmarshaller = GetTypeResponseUnmarshaller.Instance;

            return Invoke<GetTypeRequest,GetTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetTypeRequestMarshaller.Instance;
            var unmarshaller = GetTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetTypeRequest,GetTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListApiKeys

        internal virtual ListApiKeysResponse ListApiKeys(ListApiKeysRequest request)
        {
            var marshaller = ListApiKeysRequestMarshaller.Instance;
            var unmarshaller = ListApiKeysResponseUnmarshaller.Instance;

            return Invoke<ListApiKeysRequest,ListApiKeysResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListApiKeysRequestMarshaller.Instance;
            var unmarshaller = ListApiKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListApiKeysRequest,ListApiKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDataSources

        internal virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var marshaller = ListDataSourcesRequestMarshaller.Instance;
            var unmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesRequest,ListDataSourcesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListDataSourcesRequestMarshaller.Instance;
            var unmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourcesRequest,ListDataSourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGraphqlApis

        internal virtual ListGraphqlApisResponse ListGraphqlApis(ListGraphqlApisRequest request)
        {
            var marshaller = ListGraphqlApisRequestMarshaller.Instance;
            var unmarshaller = ListGraphqlApisResponseUnmarshaller.Instance;

            return Invoke<ListGraphqlApisRequest,ListGraphqlApisResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListGraphqlApisRequestMarshaller.Instance;
            var unmarshaller = ListGraphqlApisResponseUnmarshaller.Instance;

            return InvokeAsync<ListGraphqlApisRequest,ListGraphqlApisResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResolvers

        internal virtual ListResolversResponse ListResolvers(ListResolversRequest request)
        {
            var marshaller = ListResolversRequestMarshaller.Instance;
            var unmarshaller = ListResolversResponseUnmarshaller.Instance;

            return Invoke<ListResolversRequest,ListResolversResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListResolversRequestMarshaller.Instance;
            var unmarshaller = ListResolversResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolversRequest,ListResolversResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTypes

        internal virtual ListTypesResponse ListTypes(ListTypesRequest request)
        {
            var marshaller = ListTypesRequestMarshaller.Instance;
            var unmarshaller = ListTypesResponseUnmarshaller.Instance;

            return Invoke<ListTypesRequest,ListTypesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListTypesRequestMarshaller.Instance;
            var unmarshaller = ListTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypesRequest,ListTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartSchemaCreation

        internal virtual StartSchemaCreationResponse StartSchemaCreation(StartSchemaCreationRequest request)
        {
            var marshaller = StartSchemaCreationRequestMarshaller.Instance;
            var unmarshaller = StartSchemaCreationResponseUnmarshaller.Instance;

            return Invoke<StartSchemaCreationRequest,StartSchemaCreationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartSchemaCreationRequestMarshaller.Instance;
            var unmarshaller = StartSchemaCreationResponseUnmarshaller.Instance;

            return InvokeAsync<StartSchemaCreationRequest,StartSchemaCreationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApiKey

        internal virtual UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request)
        {
            var marshaller = UpdateApiKeyRequestMarshaller.Instance;
            var unmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateApiKeyRequest,UpdateApiKeyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateApiKeyRequestMarshaller.Instance;
            var unmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiKeyRequest,UpdateApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataSource

        internal virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var marshaller = UpdateDataSourceRequestMarshaller.Instance;
            var unmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceRequest,UpdateDataSourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateDataSourceRequestMarshaller.Instance;
            var unmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSourceRequest,UpdateDataSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGraphqlApi

        internal virtual UpdateGraphqlApiResponse UpdateGraphqlApi(UpdateGraphqlApiRequest request)
        {
            var marshaller = UpdateGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = UpdateGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<UpdateGraphqlApiRequest,UpdateGraphqlApiResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = UpdateGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGraphqlApiRequest,UpdateGraphqlApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateResolver

        internal virtual UpdateResolverResponse UpdateResolver(UpdateResolverRequest request)
        {
            var marshaller = UpdateResolverRequestMarshaller.Instance;
            var unmarshaller = UpdateResolverResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverRequest,UpdateResolverResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateResolverRequestMarshaller.Instance;
            var unmarshaller = UpdateResolverResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResolverRequest,UpdateResolverResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateType

        internal virtual UpdateTypeResponse UpdateType(UpdateTypeRequest request)
        {
            var marshaller = UpdateTypeRequestMarshaller.Instance;
            var unmarshaller = UpdateTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateTypeRequest,UpdateTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateTypeRequestMarshaller.Instance;
            var unmarshaller = UpdateTypeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTypeRequest,UpdateTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}