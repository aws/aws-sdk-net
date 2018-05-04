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


        /// <summary>
        /// Creates a unique key that you can distribute to clients who are executing your API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey service method.</param>
        /// 
        /// <returns>The response from the CreateApiKey service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ApiKeyLimitExceededException">
        /// The API key exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ApiKeyValidityOutOfBoundsException">
        /// The API key expiration must be set to a value between 1 and 365 days from creation
        /// (for <code>CreateApiKey</code>) or from update (for <code>UpdateApiKey</code>).
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        public virtual CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
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


        /// <summary>
        /// Creates a <code>DataSource</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
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


        /// <summary>
        /// Creates a <code>GraphqlApi</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the CreateGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ApiLimitExceededException">
        /// The GraphQL API exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateGraphqlApi">REST API Reference for CreateGraphqlApi Operation</seealso>
        public virtual CreateGraphqlApiResponse CreateGraphqlApi(CreateGraphqlApiRequest request)
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


        /// <summary>
        /// Creates a <code>Resolver</code> object.
        /// 
        ///  
        /// <para>
        /// A resolver converts incoming requests into a format that a data source can understand
        /// and converts the data source's responses into GraphQL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResolver service method.</param>
        /// 
        /// <returns>The response from the CreateResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateResolver">REST API Reference for CreateResolver Operation</seealso>
        public virtual CreateResolverResponse CreateResolver(CreateResolverRequest request)
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


        /// <summary>
        /// Creates a <code>Type</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateType service method.</param>
        /// 
        /// <returns>The response from the CreateType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateType">REST API Reference for CreateType Operation</seealso>
        public virtual CreateTypeResponse CreateType(CreateTypeRequest request)
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


        /// <summary>
        /// Deletes an API key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey service method.</param>
        /// 
        /// <returns>The response from the DeleteApiKey service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        public virtual DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
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


        /// <summary>
        /// Deletes a <code>DataSource</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
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


        /// <summary>
        /// Deletes a <code>GraphqlApi</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the DeleteGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteGraphqlApi">REST API Reference for DeleteGraphqlApi Operation</seealso>
        public virtual DeleteGraphqlApiResponse DeleteGraphqlApi(DeleteGraphqlApiRequest request)
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


        /// <summary>
        /// Deletes a <code>Resolver</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolver service method.</param>
        /// 
        /// <returns>The response from the DeleteResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteResolver">REST API Reference for DeleteResolver Operation</seealso>
        public virtual DeleteResolverResponse DeleteResolver(DeleteResolverRequest request)
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


        /// <summary>
        /// Deletes a <code>Type</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteType service method.</param>
        /// 
        /// <returns>The response from the DeleteType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteType">REST API Reference for DeleteType Operation</seealso>
        public virtual DeleteTypeResponse DeleteType(DeleteTypeRequest request)
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


        /// <summary>
        /// Retrieves a <code>DataSource</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
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


        /// <summary>
        /// Retrieves a <code>GraphqlApi</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the GetGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetGraphqlApi">REST API Reference for GetGraphqlApi Operation</seealso>
        public virtual GetGraphqlApiResponse GetGraphqlApi(GetGraphqlApiRequest request)
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


        /// <summary>
        /// Retrieves the introspection schema for a GraphQL API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntrospectionSchema service method.</param>
        /// 
        /// <returns>The response from the GetIntrospectionSchema service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.GraphQLSchemaException">
        /// The GraphQL schema is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetIntrospectionSchema">REST API Reference for GetIntrospectionSchema Operation</seealso>
        public virtual GetIntrospectionSchemaResponse GetIntrospectionSchema(GetIntrospectionSchemaRequest request)
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


        /// <summary>
        /// Retrieves a <code>Resolver</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolver service method.</param>
        /// 
        /// <returns>The response from the GetResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetResolver">REST API Reference for GetResolver Operation</seealso>
        public virtual GetResolverResponse GetResolver(GetResolverRequest request)
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


        /// <summary>
        /// Retrieves the current status of a schema creation operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaCreationStatus service method.</param>
        /// 
        /// <returns>The response from the GetSchemaCreationStatus service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetSchemaCreationStatus">REST API Reference for GetSchemaCreationStatus Operation</seealso>
        public virtual GetSchemaCreationStatusResponse GetSchemaCreationStatus(GetSchemaCreationStatusRequest request)
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


        /// <summary>
        /// Retrieves a <code>Type</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetType service method.</param>
        /// 
        /// <returns>The response from the GetType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetType">REST API Reference for GetType Operation</seealso>
        public virtual GetTypeResponse GetType(GetTypeRequest request)
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


        /// <summary>
        /// Lists the API keys for a given API.
        /// 
        ///  <note> 
        /// <para>
        /// API keys are deleted automatically sometime after they expire. However, they may still
        /// be included in the response until they have actually been deleted. You can safely
        /// call <code>DeleteApiKey</code> to manually delete a key before it's automatically
        /// deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiKeys service method.</param>
        /// 
        /// <returns>The response from the ListApiKeys service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListApiKeys">REST API Reference for ListApiKeys Operation</seealso>
        public virtual ListApiKeysResponse ListApiKeys(ListApiKeysRequest request)
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


        /// <summary>
        /// Lists the data sources for a given API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
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


        /// <summary>
        /// Lists your GraphQL APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphqlApis service method.</param>
        /// 
        /// <returns>The response from the ListGraphqlApis service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListGraphqlApis">REST API Reference for ListGraphqlApis Operation</seealso>
        public virtual ListGraphqlApisResponse ListGraphqlApis(ListGraphqlApisRequest request)
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


        /// <summary>
        /// Lists the resolvers for a given API and type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolvers service method.</param>
        /// 
        /// <returns>The response from the ListResolvers service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolvers">REST API Reference for ListResolvers Operation</seealso>
        public virtual ListResolversResponse ListResolvers(ListResolversRequest request)
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


        /// <summary>
        /// Lists the types for a given API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypes service method.</param>
        /// 
        /// <returns>The response from the ListTypes service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTypes">REST API Reference for ListTypes Operation</seealso>
        public virtual ListTypesResponse ListTypes(ListTypesRequest request)
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


        /// <summary>
        /// Adds a new schema to your GraphQL API.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous. Use to determine when it has completed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaCreation service method.</param>
        /// 
        /// <returns>The response from the StartSchemaCreation service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartSchemaCreation">REST API Reference for StartSchemaCreation Operation</seealso>
        public virtual StartSchemaCreationResponse StartSchemaCreation(StartSchemaCreationRequest request)
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


        /// <summary>
        /// Updates an API key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey service method.</param>
        /// 
        /// <returns>The response from the UpdateApiKey service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ApiKeyValidityOutOfBoundsException">
        /// The API key expiration must be set to a value between 1 and 365 days from creation
        /// (for <code>CreateApiKey</code>) or from update (for <code>UpdateApiKey</code>).
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        public virtual UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request)
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


        /// <summary>
        /// Updates a <code>DataSource</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
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


        /// <summary>
        /// Updates a <code>GraphqlApi</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the UpdateGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateGraphqlApi">REST API Reference for UpdateGraphqlApi Operation</seealso>
        public virtual UpdateGraphqlApiResponse UpdateGraphqlApi(UpdateGraphqlApiRequest request)
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


        /// <summary>
        /// Updates a <code>Resolver</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolver service method.</param>
        /// 
        /// <returns>The response from the UpdateResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateResolver">REST API Reference for UpdateResolver Operation</seealso>
        public virtual UpdateResolverResponse UpdateResolver(UpdateResolverRequest request)
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


        /// <summary>
        /// Updates a <code>Type</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateType service method.</param>
        /// 
        /// <returns>The response from the UpdateType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AWS AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateType">REST API Reference for UpdateType Operation</seealso>
        public virtual UpdateTypeResponse UpdateType(UpdateTypeRequest request)
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