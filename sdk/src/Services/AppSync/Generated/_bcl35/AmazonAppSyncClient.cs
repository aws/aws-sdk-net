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
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        public virtual IAsyncResult BeginCreateApiKey(CreateApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateApiKeyRequestMarshaller.Instance;
            var unmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke<CreateApiKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiKey.</param>
        /// 
        /// <returns>Returns a  CreateApiKeyResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        public virtual CreateApiKeyResponse EndCreateApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApiKeyResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSource(CreateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDataSourceRequestMarshaller.Instance;
            var unmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDataSourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSource.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse EndCreateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSourceResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphqlApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGraphqlApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateGraphqlApi">REST API Reference for CreateGraphqlApi Operation</seealso>
        public virtual IAsyncResult BeginCreateGraphqlApi(CreateGraphqlApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = CreateGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke<CreateGraphqlApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGraphqlApi.</param>
        /// 
        /// <returns>Returns a  CreateGraphqlApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateGraphqlApi">REST API Reference for CreateGraphqlApi Operation</seealso>
        public virtual CreateGraphqlApiResponse EndCreateGraphqlApi(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGraphqlApiResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateResolver operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResolver
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateResolver">REST API Reference for CreateResolver Operation</seealso>
        public virtual IAsyncResult BeginCreateResolver(CreateResolverRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateResolverRequestMarshaller.Instance;
            var unmarshaller = CreateResolverResponseUnmarshaller.Instance;

            return BeginInvoke<CreateResolverRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResolver operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResolver.</param>
        /// 
        /// <returns>Returns a  CreateResolverResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateResolver">REST API Reference for CreateResolver Operation</seealso>
        public virtual CreateResolverResponse EndCreateResolver(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResolverResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateType operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateType">REST API Reference for CreateType Operation</seealso>
        public virtual IAsyncResult BeginCreateType(CreateTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateTypeRequestMarshaller.Instance;
            var unmarshaller = CreateTypeResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateType.</param>
        /// 
        /// <returns>Returns a  CreateTypeResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateType">REST API Reference for CreateType Operation</seealso>
        public virtual CreateTypeResponse EndCreateType(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTypeResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        public virtual IAsyncResult BeginDeleteApiKey(DeleteApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteApiKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApiKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiKey.</param>
        /// 
        /// <returns>Returns a  DeleteApiKeyResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        public virtual DeleteApiKeyResponse EndDeleteApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApiKeyResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDataSourceRequestMarshaller.Instance;
            var unmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDataSourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataSourceResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraphqlApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGraphqlApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteGraphqlApi">REST API Reference for DeleteGraphqlApi Operation</seealso>
        public virtual IAsyncResult BeginDeleteGraphqlApi(DeleteGraphqlApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = DeleteGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteGraphqlApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGraphqlApi.</param>
        /// 
        /// <returns>Returns a  DeleteGraphqlApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteGraphqlApi">REST API Reference for DeleteGraphqlApi Operation</seealso>
        public virtual DeleteGraphqlApiResponse EndDeleteGraphqlApi(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGraphqlApiResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolver operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResolver
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteResolver">REST API Reference for DeleteResolver Operation</seealso>
        public virtual IAsyncResult BeginDeleteResolver(DeleteResolverRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteResolverRequestMarshaller.Instance;
            var unmarshaller = DeleteResolverResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteResolverRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResolver operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResolver.</param>
        /// 
        /// <returns>Returns a  DeleteResolverResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteResolver">REST API Reference for DeleteResolver Operation</seealso>
        public virtual DeleteResolverResponse EndDeleteResolver(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResolverResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteType operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteType">REST API Reference for DeleteType Operation</seealso>
        public virtual IAsyncResult BeginDeleteType(DeleteTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteTypeRequestMarshaller.Instance;
            var unmarshaller = DeleteTypeResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteType.</param>
        /// 
        /// <returns>Returns a  DeleteTypeResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteType">REST API Reference for DeleteType Operation</seealso>
        public virtual DeleteTypeResponse EndDeleteType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTypeResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual IAsyncResult BeginGetDataSource(GetDataSourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDataSourceRequestMarshaller.Instance;
            var unmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke<GetDataSourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSource.</param>
        /// 
        /// <returns>Returns a  GetDataSourceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse EndGetDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataSourceResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetGraphqlApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGraphqlApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetGraphqlApi">REST API Reference for GetGraphqlApi Operation</seealso>
        public virtual IAsyncResult BeginGetGraphqlApi(GetGraphqlApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = GetGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke<GetGraphqlApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGraphqlApi.</param>
        /// 
        /// <returns>Returns a  GetGraphqlApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetGraphqlApi">REST API Reference for GetGraphqlApi Operation</seealso>
        public virtual GetGraphqlApiResponse EndGetGraphqlApi(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGraphqlApiResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetIntrospectionSchema operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntrospectionSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetIntrospectionSchema">REST API Reference for GetIntrospectionSchema Operation</seealso>
        public virtual IAsyncResult BeginGetIntrospectionSchema(GetIntrospectionSchemaRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIntrospectionSchemaRequestMarshaller.Instance;
            var unmarshaller = GetIntrospectionSchemaResponseUnmarshaller.Instance;

            return BeginInvoke<GetIntrospectionSchemaRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntrospectionSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntrospectionSchema.</param>
        /// 
        /// <returns>Returns a  GetIntrospectionSchemaResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetIntrospectionSchema">REST API Reference for GetIntrospectionSchema Operation</seealso>
        public virtual GetIntrospectionSchemaResponse EndGetIntrospectionSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntrospectionSchemaResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetResolver operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResolver
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetResolver">REST API Reference for GetResolver Operation</seealso>
        public virtual IAsyncResult BeginGetResolver(GetResolverRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetResolverRequestMarshaller.Instance;
            var unmarshaller = GetResolverResponseUnmarshaller.Instance;

            return BeginInvoke<GetResolverRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResolver operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResolver.</param>
        /// 
        /// <returns>Returns a  GetResolverResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetResolver">REST API Reference for GetResolver Operation</seealso>
        public virtual GetResolverResponse EndGetResolver(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResolverResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaCreationStatus operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaCreationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetSchemaCreationStatus">REST API Reference for GetSchemaCreationStatus Operation</seealso>
        public virtual IAsyncResult BeginGetSchemaCreationStatus(GetSchemaCreationStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSchemaCreationStatusRequestMarshaller.Instance;
            var unmarshaller = GetSchemaCreationStatusResponseUnmarshaller.Instance;

            return BeginInvoke<GetSchemaCreationStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaCreationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaCreationStatus.</param>
        /// 
        /// <returns>Returns a  GetSchemaCreationStatusResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetSchemaCreationStatus">REST API Reference for GetSchemaCreationStatus Operation</seealso>
        public virtual GetSchemaCreationStatusResponse EndGetSchemaCreationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaCreationStatusResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetType operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetType">REST API Reference for GetType Operation</seealso>
        public virtual IAsyncResult BeginGetType(GetTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTypeRequestMarshaller.Instance;
            var unmarshaller = GetTypeResponseUnmarshaller.Instance;

            return BeginInvoke<GetTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetType.</param>
        /// 
        /// <returns>Returns a  GetTypeResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetType">REST API Reference for GetType Operation</seealso>
        public virtual GetTypeResponse EndGetType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTypeResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListApiKeys operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApiKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListApiKeys">REST API Reference for ListApiKeys Operation</seealso>
        public virtual IAsyncResult BeginListApiKeys(ListApiKeysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListApiKeysRequestMarshaller.Instance;
            var unmarshaller = ListApiKeysResponseUnmarshaller.Instance;

            return BeginInvoke<ListApiKeysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApiKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApiKeys.</param>
        /// 
        /// <returns>Returns a  ListApiKeysResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListApiKeys">REST API Reference for ListApiKeys Operation</seealso>
        public virtual ListApiKeysResponse EndListApiKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApiKeysResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual IAsyncResult BeginListDataSources(ListDataSourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListDataSourcesRequestMarshaller.Instance;
            var unmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return BeginInvoke<ListDataSourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSources.</param>
        /// 
        /// <returns>Returns a  ListDataSourcesResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse EndListDataSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSourcesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListGraphqlApis operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGraphqlApis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListGraphqlApis">REST API Reference for ListGraphqlApis Operation</seealso>
        public virtual IAsyncResult BeginListGraphqlApis(ListGraphqlApisRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListGraphqlApisRequestMarshaller.Instance;
            var unmarshaller = ListGraphqlApisResponseUnmarshaller.Instance;

            return BeginInvoke<ListGraphqlApisRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGraphqlApis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGraphqlApis.</param>
        /// 
        /// <returns>Returns a  ListGraphqlApisResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListGraphqlApis">REST API Reference for ListGraphqlApis Operation</seealso>
        public virtual ListGraphqlApisResponse EndListGraphqlApis(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGraphqlApisResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListResolvers operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResolvers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolvers">REST API Reference for ListResolvers Operation</seealso>
        public virtual IAsyncResult BeginListResolvers(ListResolversRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListResolversRequestMarshaller.Instance;
            var unmarshaller = ListResolversResponseUnmarshaller.Instance;

            return BeginInvoke<ListResolversRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResolvers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResolvers.</param>
        /// 
        /// <returns>Returns a  ListResolversResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolvers">REST API Reference for ListResolvers Operation</seealso>
        public virtual ListResolversResponse EndListResolvers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResolversResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListTypes operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTypes">REST API Reference for ListTypes Operation</seealso>
        public virtual IAsyncResult BeginListTypes(ListTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTypesRequestMarshaller.Instance;
            var unmarshaller = ListTypesResponseUnmarshaller.Instance;

            return BeginInvoke<ListTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypes.</param>
        /// 
        /// <returns>Returns a  ListTypesResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTypes">REST API Reference for ListTypes Operation</seealso>
        public virtual ListTypesResponse EndListTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTypesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaCreation operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSchemaCreation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartSchemaCreation">REST API Reference for StartSchemaCreation Operation</seealso>
        public virtual IAsyncResult BeginStartSchemaCreation(StartSchemaCreationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartSchemaCreationRequestMarshaller.Instance;
            var unmarshaller = StartSchemaCreationResponseUnmarshaller.Instance;

            return BeginInvoke<StartSchemaCreationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSchemaCreation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSchemaCreation.</param>
        /// 
        /// <returns>Returns a  StartSchemaCreationResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartSchemaCreation">REST API Reference for StartSchemaCreation Operation</seealso>
        public virtual StartSchemaCreationResponse EndStartSchemaCreation(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSchemaCreationResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        public virtual IAsyncResult BeginUpdateApiKey(UpdateApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateApiKeyRequestMarshaller.Instance;
            var unmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApiKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiKey.</param>
        /// 
        /// <returns>Returns a  UpdateApiKeyResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        public virtual UpdateApiKeyResponse EndUpdateApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApiKeyResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDataSourceRequestMarshaller.Instance;
            var unmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDataSourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSourceResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateGraphqlApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGraphqlApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateGraphqlApi">REST API Reference for UpdateGraphqlApi Operation</seealso>
        public virtual IAsyncResult BeginUpdateGraphqlApi(UpdateGraphqlApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateGraphqlApiRequestMarshaller.Instance;
            var unmarshaller = UpdateGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateGraphqlApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGraphqlApi.</param>
        /// 
        /// <returns>Returns a  UpdateGraphqlApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateGraphqlApi">REST API Reference for UpdateGraphqlApi Operation</seealso>
        public virtual UpdateGraphqlApiResponse EndUpdateGraphqlApi(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGraphqlApiResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolver operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResolver
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateResolver">REST API Reference for UpdateResolver Operation</seealso>
        public virtual IAsyncResult BeginUpdateResolver(UpdateResolverRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateResolverRequestMarshaller.Instance;
            var unmarshaller = UpdateResolverResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateResolverRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResolver operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResolver.</param>
        /// 
        /// <returns>Returns a  UpdateResolverResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateResolver">REST API Reference for UpdateResolver Operation</seealso>
        public virtual UpdateResolverResponse EndUpdateResolver(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResolverResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateType operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateType">REST API Reference for UpdateType Operation</seealso>
        public virtual IAsyncResult BeginUpdateType(UpdateTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateTypeRequestMarshaller.Instance;
            var unmarshaller = UpdateTypeResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateType.</param>
        /// 
        /// <returns>Returns a  UpdateTypeResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateType">REST API Reference for UpdateType Operation</seealso>
        public virtual UpdateTypeResponse EndUpdateType(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTypeResponse>(asyncResult);
        }

        #endregion
        
    }
}