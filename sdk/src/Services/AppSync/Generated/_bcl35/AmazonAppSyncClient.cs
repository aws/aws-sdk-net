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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.AppSync.Model;
using Amazon.AppSync.Model.Internal.MarshallTransformations;
using Amazon.AppSync.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.AppSync
{
    /// <summary>
    /// <para>Implementation for accessing AppSync</para>
    ///
    /// AppSync provides API actions for creating and interacting with data sources using
    /// GraphQL from your application.
    /// </summary>
    public partial class AmazonAppSyncClient : AmazonServiceClient, IAmazonAppSync
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppSyncMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IAppSyncPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAppSyncPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AppSyncPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppSyncEndpointResolver());
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


        #region  AssociateApi

        /// <summary>
        /// Maps an endpoint to your custom domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApi service method.</param>
        /// 
        /// <returns>The response from the AssociateApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateApi">REST API Reference for AssociateApi Operation</seealso>
        public virtual AssociateApiResponse AssociateApi(AssociateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApiResponseUnmarshaller.Instance;

            return Invoke<AssociateApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateApi">REST API Reference for AssociateApi Operation</seealso>
        public virtual IAsyncResult BeginAssociateApi(AssociateApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateApi.</param>
        /// 
        /// <returns>Returns a  AssociateApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateApi">REST API Reference for AssociateApi Operation</seealso>
        public virtual AssociateApiResponse EndAssociateApi(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateApiResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateMergedGraphqlApi

        /// <summary>
        /// Creates an association between a Merged API and source API using the source API's
        /// identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMergedGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the AssociateMergedGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateMergedGraphqlApi">REST API Reference for AssociateMergedGraphqlApi Operation</seealso>
        public virtual AssociateMergedGraphqlApiResponse AssociateMergedGraphqlApi(AssociateMergedGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMergedGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMergedGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<AssociateMergedGraphqlApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMergedGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMergedGraphqlApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMergedGraphqlApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateMergedGraphqlApi">REST API Reference for AssociateMergedGraphqlApi Operation</seealso>
        public virtual IAsyncResult BeginAssociateMergedGraphqlApi(AssociateMergedGraphqlApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMergedGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMergedGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMergedGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMergedGraphqlApi.</param>
        /// 
        /// <returns>Returns a  AssociateMergedGraphqlApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateMergedGraphqlApi">REST API Reference for AssociateMergedGraphqlApi Operation</seealso>
        public virtual AssociateMergedGraphqlApiResponse EndAssociateMergedGraphqlApi(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateMergedGraphqlApiResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateSourceGraphqlApi

        /// <summary>
        /// Creates an association between a Merged API and source API using the Merged API's
        /// identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the AssociateSourceGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateSourceGraphqlApi">REST API Reference for AssociateSourceGraphqlApi Operation</seealso>
        public virtual AssociateSourceGraphqlApiResponse AssociateSourceGraphqlApi(AssociateSourceGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSourceGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSourceGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<AssociateSourceGraphqlApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSourceGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceGraphqlApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSourceGraphqlApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateSourceGraphqlApi">REST API Reference for AssociateSourceGraphqlApi Operation</seealso>
        public virtual IAsyncResult BeginAssociateSourceGraphqlApi(AssociateSourceGraphqlApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSourceGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSourceGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSourceGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSourceGraphqlApi.</param>
        /// 
        /// <returns>Returns a  AssociateSourceGraphqlApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateSourceGraphqlApi">REST API Reference for AssociateSourceGraphqlApi Operation</seealso>
        public virtual AssociateSourceGraphqlApiResponse EndAssociateSourceGraphqlApi(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateSourceGraphqlApiResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApi

        /// <summary>
        /// Creates an <c>Api</c> object. Use this operation to create an AppSync API with your
        /// preferred configuration, such as an Event API that provides real-time message publishing
        /// and message subscriptions over WebSockets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApi service method.</param>
        /// 
        /// <returns>The response from the CreateApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApi">REST API Reference for CreateApi Operation</seealso>
        public virtual CreateApiResponse CreateApi(CreateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return Invoke<CreateApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApi">REST API Reference for CreateApi Operation</seealso>
        public virtual IAsyncResult BeginCreateApi(CreateApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApi.</param>
        /// 
        /// <returns>Returns a  CreateApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApi">REST API Reference for CreateApi Operation</seealso>
        public virtual CreateApiResponse EndCreateApi(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApiResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApiCache

        /// <summary>
        /// Creates a cache for the GraphQL API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiCache service method.</param>
        /// 
        /// <returns>The response from the CreateApiCache service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApiCache">REST API Reference for CreateApiCache Operation</seealso>
        public virtual CreateApiCacheResponse CreateApiCache(CreateApiCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiCacheResponseUnmarshaller.Instance;

            return Invoke<CreateApiCacheResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiCache operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApiCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApiCache">REST API Reference for CreateApiCache Operation</seealso>
        public virtual IAsyncResult BeginCreateApiCache(CreateApiCacheRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiCacheResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiCache.</param>
        /// 
        /// <returns>Returns a  CreateApiCacheResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApiCache">REST API Reference for CreateApiCache Operation</seealso>
        public virtual CreateApiCacheResponse EndCreateApiCache(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApiCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApiKey

        /// <summary>
        /// Creates a unique key that you can distribute to clients who invoke your API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey service method.</param>
        /// 
        /// <returns>The response from the CreateApiKey service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ApiKeyLimitExceededException">
        /// The API key exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ApiKeyValidityOutOfBoundsException">
        /// The API key expiration must be set to a value between 1 and 365 days from creation
        /// (for <c>CreateApiKey</c>) or from update (for <c>UpdateApiKey</c>).
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        public virtual CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return Invoke<CreateApiKeyResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  CreateChannelNamespace

        /// <summary>
        /// Creates a <c>ChannelNamespace</c> for an <c>Api</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateChannelNamespace service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConflictException">
        /// A conflict with a previous successful update is detected. This typically occurs when
        /// the previous update did not have time to propagate before the next update was made.
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateChannelNamespace">REST API Reference for CreateChannelNamespace Operation</seealso>
        public virtual CreateChannelNamespaceResponse CreateChannelNamespace(CreateChannelNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateChannelNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelNamespace operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateChannelNamespace">REST API Reference for CreateChannelNamespace Operation</seealso>
        public virtual IAsyncResult BeginCreateChannelNamespace(CreateChannelNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelNamespace.</param>
        /// 
        /// <returns>Returns a  CreateChannelNamespaceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateChannelNamespace">REST API Reference for CreateChannelNamespace Operation</seealso>
        public virtual CreateChannelNamespaceResponse EndCreateChannelNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSource

        /// <summary>
        /// Creates a <c>DataSource</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  CreateDomainName

        /// <summary>
        /// Creates a custom <c>DomainName</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual IAsyncResult BeginCreateDomainName(CreateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainName.</param>
        /// 
        /// <returns>Returns a  CreateDomainNameResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual CreateDomainNameResponse EndCreateDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFunction

        /// <summary>
        /// Creates a <c>Function</c> object.
        /// 
        ///  
        /// <para>
        /// A function is a reusable entity. You can use multiple functions to compose the resolver
        /// logic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction service method.</param>
        /// 
        /// <returns>The response from the CreateFunction service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual IAsyncResult BeginCreateFunction(CreateFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFunction.</param>
        /// 
        /// <returns>Returns a  CreateFunctionResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual CreateFunctionResponse EndCreateFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGraphqlApi

        /// <summary>
        /// Creates a <c>GraphqlApi</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the CreateGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ApiLimitExceededException">
        /// The GraphQL API exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateGraphqlApi">REST API Reference for CreateGraphqlApi Operation</seealso>
        public virtual CreateGraphqlApiResponse CreateGraphqlApi(CreateGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<CreateGraphqlApiResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Creates a <c>Resolver</c> object.
        /// 
        ///  
        /// <para>
        /// A resolver converts incoming requests into a format that a data source can understand,
        /// and converts the data source's responses into GraphQL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResolver service method.</param>
        /// 
        /// <returns>The response from the CreateResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateResolver">REST API Reference for CreateResolver Operation</seealso>
        public virtual CreateResolverResponse CreateResolver(CreateResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverResponseUnmarshaller.Instance;

            return Invoke<CreateResolverResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Creates a <c>Type</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateType service method.</param>
        /// 
        /// <returns>The response from the CreateType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateType">REST API Reference for CreateType Operation</seealso>
        public virtual CreateTypeResponse CreateType(CreateTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypeResponseUnmarshaller.Instance;

            return Invoke<CreateTypeResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  DeleteApi

        /// <summary>
        /// Deletes an <c>Api</c> object
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi service method.</param>
        /// 
        /// <returns>The response from the DeleteApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        public virtual DeleteApiResponse DeleteApi(DeleteApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return Invoke<DeleteApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        public virtual IAsyncResult BeginDeleteApi(DeleteApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApi.</param>
        /// 
        /// <returns>Returns a  DeleteApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        public virtual DeleteApiResponse EndDeleteApi(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApiResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApiCache

        /// <summary>
        /// Deletes an <c>ApiCache</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiCache service method.</param>
        /// 
        /// <returns>The response from the DeleteApiCache service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApiCache">REST API Reference for DeleteApiCache Operation</seealso>
        public virtual DeleteApiCacheResponse DeleteApiCache(DeleteApiCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiCacheResponseUnmarshaller.Instance;

            return Invoke<DeleteApiCacheResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiCache operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApiCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApiCache">REST API Reference for DeleteApiCache Operation</seealso>
        public virtual IAsyncResult BeginDeleteApiCache(DeleteApiCacheRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiCacheResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiCache.</param>
        /// 
        /// <returns>Returns a  DeleteApiCacheResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApiCache">REST API Reference for DeleteApiCache Operation</seealso>
        public virtual DeleteApiCacheResponse EndDeleteApiCache(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApiCacheResponse>(asyncResult);
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
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        public virtual DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteApiKeyResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  DeleteChannelNamespace

        /// <summary>
        /// Deletes a <c>ChannelNamespace</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelNamespace service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteChannelNamespace">REST API Reference for DeleteChannelNamespace Operation</seealso>
        public virtual DeleteChannelNamespaceResponse DeleteChannelNamespace(DeleteChannelNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelNamespace operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteChannelNamespace">REST API Reference for DeleteChannelNamespace Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelNamespace(DeleteChannelNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteChannelNamespaceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteChannelNamespace">REST API Reference for DeleteChannelNamespace Operation</seealso>
        public virtual DeleteChannelNamespaceResponse EndDeleteChannelNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataSource

        /// <summary>
        /// Deletes a <c>DataSource</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  DeleteDomainName

        /// <summary>
        /// Deletes a custom <c>DomainName</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainName service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomainName(DeleteDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainName.</param>
        /// 
        /// <returns>Returns a  DeleteDomainNameResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual DeleteDomainNameResponse EndDeleteDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFunction

        /// <summary>
        /// Deletes a <c>Function</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual IAsyncResult BeginDeleteFunction(DeleteFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunction.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual DeleteFunctionResponse EndDeleteFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGraphqlApi

        /// <summary>
        /// Deletes a <c>GraphqlApi</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the DeleteGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteGraphqlApi">REST API Reference for DeleteGraphqlApi Operation</seealso>
        public virtual DeleteGraphqlApiResponse DeleteGraphqlApi(DeleteGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<DeleteGraphqlApiResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Deletes a <c>Resolver</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolver service method.</param>
        /// 
        /// <returns>The response from the DeleteResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteResolver">REST API Reference for DeleteResolver Operation</seealso>
        public virtual DeleteResolverResponse DeleteResolver(DeleteResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverResponseUnmarshaller.Instance;

            return Invoke<DeleteResolverResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Deletes a <c>Type</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteType service method.</param>
        /// 
        /// <returns>The response from the DeleteType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteType">REST API Reference for DeleteType Operation</seealso>
        public virtual DeleteTypeResponse DeleteType(DeleteTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteTypeResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  DisassociateApi

        /// <summary>
        /// Removes an <c>ApiAssociation</c> object from a custom domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApi service method.</param>
        /// 
        /// <returns>The response from the DisassociateApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateApi">REST API Reference for DisassociateApi Operation</seealso>
        public virtual DisassociateApiResponse DisassociateApi(DisassociateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApiResponseUnmarshaller.Instance;

            return Invoke<DisassociateApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateApi">REST API Reference for DisassociateApi Operation</seealso>
        public virtual IAsyncResult BeginDisassociateApi(DisassociateApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateApi.</param>
        /// 
        /// <returns>Returns a  DisassociateApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateApi">REST API Reference for DisassociateApi Operation</seealso>
        public virtual DisassociateApiResponse EndDisassociateApi(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateApiResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateMergedGraphqlApi

        /// <summary>
        /// Deletes an association between a Merged API and source API using the source API's
        /// identifier and the association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMergedGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the DisassociateMergedGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateMergedGraphqlApi">REST API Reference for DisassociateMergedGraphqlApi Operation</seealso>
        public virtual DisassociateMergedGraphqlApiResponse DisassociateMergedGraphqlApi(DisassociateMergedGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMergedGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMergedGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<DisassociateMergedGraphqlApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMergedGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMergedGraphqlApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMergedGraphqlApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateMergedGraphqlApi">REST API Reference for DisassociateMergedGraphqlApi Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMergedGraphqlApi(DisassociateMergedGraphqlApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMergedGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMergedGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMergedGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMergedGraphqlApi.</param>
        /// 
        /// <returns>Returns a  DisassociateMergedGraphqlApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateMergedGraphqlApi">REST API Reference for DisassociateMergedGraphqlApi Operation</seealso>
        public virtual DisassociateMergedGraphqlApiResponse EndDisassociateMergedGraphqlApi(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMergedGraphqlApiResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateSourceGraphqlApi

        /// <summary>
        /// Deletes an association between a Merged API and source API using the Merged API's
        /// identifier and the association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the DisassociateSourceGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateSourceGraphqlApi">REST API Reference for DisassociateSourceGraphqlApi Operation</seealso>
        public virtual DisassociateSourceGraphqlApiResponse DisassociateSourceGraphqlApi(DisassociateSourceGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSourceGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSourceGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<DisassociateSourceGraphqlApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSourceGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceGraphqlApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSourceGraphqlApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateSourceGraphqlApi">REST API Reference for DisassociateSourceGraphqlApi Operation</seealso>
        public virtual IAsyncResult BeginDisassociateSourceGraphqlApi(DisassociateSourceGraphqlApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSourceGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSourceGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSourceGraphqlApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSourceGraphqlApi.</param>
        /// 
        /// <returns>Returns a  DisassociateSourceGraphqlApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateSourceGraphqlApi">REST API Reference for DisassociateSourceGraphqlApi Operation</seealso>
        public virtual DisassociateSourceGraphqlApiResponse EndDisassociateSourceGraphqlApi(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateSourceGraphqlApiResponse>(asyncResult);
        }

        #endregion
        
        #region  EvaluateCode

        /// <summary>
        /// Evaluates the given code and returns the response. The code definition requirements
        /// depend on the specified runtime. For <c>APPSYNC_JS</c> runtimes, the code defines
        /// the request and response functions. The request function takes the incoming request
        /// after a GraphQL operation is parsed and converts it into a request configuration for
        /// the selected data source operation. The response function interprets responses from
        /// the data source and maps it to the shape of the GraphQL field output type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateCode service method.</param>
        /// 
        /// <returns>The response from the EvaluateCode service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/EvaluateCode">REST API Reference for EvaluateCode Operation</seealso>
        public virtual EvaluateCodeResponse EvaluateCode(EvaluateCodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluateCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateCodeResponseUnmarshaller.Instance;

            return Invoke<EvaluateCodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EvaluateCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluateCode operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEvaluateCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/EvaluateCode">REST API Reference for EvaluateCode Operation</seealso>
        public virtual IAsyncResult BeginEvaluateCode(EvaluateCodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluateCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateCodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EvaluateCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEvaluateCode.</param>
        /// 
        /// <returns>Returns a  EvaluateCodeResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/EvaluateCode">REST API Reference for EvaluateCode Operation</seealso>
        public virtual EvaluateCodeResponse EndEvaluateCode(IAsyncResult asyncResult)
        {
            return EndInvoke<EvaluateCodeResponse>(asyncResult);
        }

        #endregion
        
        #region  EvaluateMappingTemplate

        /// <summary>
        /// Evaluates a given template and returns the response. The mapping template can be a
        /// request or response template.
        /// 
        ///  
        /// <para>
        /// Request templates take the incoming request after a GraphQL operation is parsed and
        /// convert it into a request configuration for the selected data source operation. Response
        /// templates interpret responses from the data source and map it to the shape of the
        /// GraphQL field output type.
        /// </para>
        ///  
        /// <para>
        /// Mapping templates are written in the Apache Velocity Template Language (VTL).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateMappingTemplate service method.</param>
        /// 
        /// <returns>The response from the EvaluateMappingTemplate service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/EvaluateMappingTemplate">REST API Reference for EvaluateMappingTemplate Operation</seealso>
        public virtual EvaluateMappingTemplateResponse EvaluateMappingTemplate(EvaluateMappingTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluateMappingTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateMappingTemplateResponseUnmarshaller.Instance;

            return Invoke<EvaluateMappingTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EvaluateMappingTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluateMappingTemplate operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEvaluateMappingTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/EvaluateMappingTemplate">REST API Reference for EvaluateMappingTemplate Operation</seealso>
        public virtual IAsyncResult BeginEvaluateMappingTemplate(EvaluateMappingTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluateMappingTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateMappingTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EvaluateMappingTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEvaluateMappingTemplate.</param>
        /// 
        /// <returns>Returns a  EvaluateMappingTemplateResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/EvaluateMappingTemplate">REST API Reference for EvaluateMappingTemplate Operation</seealso>
        public virtual EvaluateMappingTemplateResponse EndEvaluateMappingTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<EvaluateMappingTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  FlushApiCache

        /// <summary>
        /// Flushes an <c>ApiCache</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushApiCache service method.</param>
        /// 
        /// <returns>The response from the FlushApiCache service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/FlushApiCache">REST API Reference for FlushApiCache Operation</seealso>
        public virtual FlushApiCacheResponse FlushApiCache(FlushApiCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlushApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlushApiCacheResponseUnmarshaller.Instance;

            return Invoke<FlushApiCacheResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FlushApiCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlushApiCache operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlushApiCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/FlushApiCache">REST API Reference for FlushApiCache Operation</seealso>
        public virtual IAsyncResult BeginFlushApiCache(FlushApiCacheRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlushApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlushApiCacheResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlushApiCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlushApiCache.</param>
        /// 
        /// <returns>Returns a  FlushApiCacheResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/FlushApiCache">REST API Reference for FlushApiCache Operation</seealso>
        public virtual FlushApiCacheResponse EndFlushApiCache(IAsyncResult asyncResult)
        {
            return EndInvoke<FlushApiCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApi

        /// <summary>
        /// Retrieves an <c>Api</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApi service method.</param>
        /// 
        /// <returns>The response from the GetApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApi">REST API Reference for GetApi Operation</seealso>
        public virtual GetApiResponse GetApi(GetApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return Invoke<GetApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApi">REST API Reference for GetApi Operation</seealso>
        public virtual IAsyncResult BeginGetApi(GetApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApi.</param>
        /// 
        /// <returns>Returns a  GetApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApi">REST API Reference for GetApi Operation</seealso>
        public virtual GetApiResponse EndGetApi(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiAssociation

        /// <summary>
        /// Retrieves an <c>ApiAssociation</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiAssociation service method.</param>
        /// 
        /// <returns>The response from the GetApiAssociation service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApiAssociation">REST API Reference for GetApiAssociation Operation</seealso>
        public virtual GetApiAssociationResponse GetApiAssociation(GetApiAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiAssociationResponseUnmarshaller.Instance;

            return Invoke<GetApiAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiAssociation operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApiAssociation">REST API Reference for GetApiAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetApiAssociation(GetApiAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiAssociation.</param>
        /// 
        /// <returns>Returns a  GetApiAssociationResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApiAssociation">REST API Reference for GetApiAssociation Operation</seealso>
        public virtual GetApiAssociationResponse EndGetApiAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiCache

        /// <summary>
        /// Retrieves an <c>ApiCache</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiCache service method.</param>
        /// 
        /// <returns>The response from the GetApiCache service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApiCache">REST API Reference for GetApiCache Operation</seealso>
        public virtual GetApiCacheResponse GetApiCache(GetApiCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiCacheResponseUnmarshaller.Instance;

            return Invoke<GetApiCacheResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiCache operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApiCache">REST API Reference for GetApiCache Operation</seealso>
        public virtual IAsyncResult BeginGetApiCache(GetApiCacheRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiCacheResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiCache.</param>
        /// 
        /// <returns>Returns a  GetApiCacheResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApiCache">REST API Reference for GetApiCache Operation</seealso>
        public virtual GetApiCacheResponse EndGetApiCache(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannelNamespace

        /// <summary>
        /// Retrieves the channel namespace for a specified <c>Api</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelNamespace service method.</param>
        /// 
        /// <returns>The response from the GetChannelNamespace service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetChannelNamespace">REST API Reference for GetChannelNamespace Operation</seealso>
        public virtual GetChannelNamespaceResponse GetChannelNamespace(GetChannelNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetChannelNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelNamespace operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetChannelNamespace">REST API Reference for GetChannelNamespace Operation</seealso>
        public virtual IAsyncResult BeginGetChannelNamespace(GetChannelNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelNamespace.</param>
        /// 
        /// <returns>Returns a  GetChannelNamespaceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetChannelNamespace">REST API Reference for GetChannelNamespace Operation</seealso>
        public virtual GetChannelNamespaceResponse EndGetChannelNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataSource

        /// <summary>
        /// Retrieves a <c>DataSource</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  GetDataSourceIntrospection

        /// <summary>
        /// Retrieves the record of an existing introspection. If the retrieval is successful,
        /// the result of the instrospection will also be returned. If the retrieval fails the
        /// operation, an error message will be returned instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSourceIntrospection service method.</param>
        /// 
        /// <returns>The response from the GetDataSourceIntrospection service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDataSourceIntrospection">REST API Reference for GetDataSourceIntrospection Operation</seealso>
        public virtual GetDataSourceIntrospectionResponse GetDataSourceIntrospection(GetDataSourceIntrospectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceIntrospectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceIntrospectionResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceIntrospectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSourceIntrospection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSourceIntrospection operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSourceIntrospection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDataSourceIntrospection">REST API Reference for GetDataSourceIntrospection Operation</seealso>
        public virtual IAsyncResult BeginGetDataSourceIntrospection(GetDataSourceIntrospectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceIntrospectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceIntrospectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSourceIntrospection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSourceIntrospection.</param>
        /// 
        /// <returns>Returns a  GetDataSourceIntrospectionResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDataSourceIntrospection">REST API Reference for GetDataSourceIntrospection Operation</seealso>
        public virtual GetDataSourceIntrospectionResponse EndGetDataSourceIntrospection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataSourceIntrospectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomainName

        /// <summary>
        /// Retrieves a custom <c>DomainName</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// 
        /// <returns>The response from the GetDomainName service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual IAsyncResult BeginGetDomainName(GetDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainName.</param>
        /// 
        /// <returns>Returns a  GetDomainNameResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual GetDomainNameResponse EndGetDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFunction

        /// <summary>
        /// Get a <c>Function</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual GetFunctionResponse GetFunction(GetFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunction operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual IAsyncResult BeginGetFunction(GetFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunction.</param>
        /// 
        /// <returns>Returns a  GetFunctionResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual GetFunctionResponse EndGetFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGraphqlApi

        /// <summary>
        /// Retrieves a <c>GraphqlApi</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the GetGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetGraphqlApi">REST API Reference for GetGraphqlApi Operation</seealso>
        public virtual GetGraphqlApiResponse GetGraphqlApi(GetGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<GetGraphqlApiResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  GetGraphqlApiEnvironmentVariables

        /// <summary>
        /// Retrieves the list of environmental variable key-value pairs associated with an API
        /// by its ID value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphqlApiEnvironmentVariables service method.</param>
        /// 
        /// <returns>The response from the GetGraphqlApiEnvironmentVariables service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetGraphqlApiEnvironmentVariables">REST API Reference for GetGraphqlApiEnvironmentVariables Operation</seealso>
        public virtual GetGraphqlApiEnvironmentVariablesResponse GetGraphqlApiEnvironmentVariables(GetGraphqlApiEnvironmentVariablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphqlApiEnvironmentVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphqlApiEnvironmentVariablesResponseUnmarshaller.Instance;

            return Invoke<GetGraphqlApiEnvironmentVariablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGraphqlApiEnvironmentVariables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGraphqlApiEnvironmentVariables operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGraphqlApiEnvironmentVariables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetGraphqlApiEnvironmentVariables">REST API Reference for GetGraphqlApiEnvironmentVariables Operation</seealso>
        public virtual IAsyncResult BeginGetGraphqlApiEnvironmentVariables(GetGraphqlApiEnvironmentVariablesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphqlApiEnvironmentVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphqlApiEnvironmentVariablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGraphqlApiEnvironmentVariables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGraphqlApiEnvironmentVariables.</param>
        /// 
        /// <returns>Returns a  GetGraphqlApiEnvironmentVariablesResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetGraphqlApiEnvironmentVariables">REST API Reference for GetGraphqlApiEnvironmentVariables Operation</seealso>
        public virtual GetGraphqlApiEnvironmentVariablesResponse EndGetGraphqlApiEnvironmentVariables(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGraphqlApiEnvironmentVariablesResponse>(asyncResult);
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
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetIntrospectionSchema">REST API Reference for GetIntrospectionSchema Operation</seealso>
        public virtual GetIntrospectionSchemaResponse GetIntrospectionSchema(GetIntrospectionSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntrospectionSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntrospectionSchemaResponseUnmarshaller.Instance;

            return Invoke<GetIntrospectionSchemaResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntrospectionSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntrospectionSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Retrieves a <c>Resolver</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolver service method.</param>
        /// 
        /// <returns>The response from the GetResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetResolver">REST API Reference for GetResolver Operation</seealso>
        public virtual GetResolverResponse GetResolver(GetResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverResponseUnmarshaller.Instance;

            return Invoke<GetResolverResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetSchemaCreationStatus">REST API Reference for GetSchemaCreationStatus Operation</seealso>
        public virtual GetSchemaCreationStatusResponse GetSchemaCreationStatus(GetSchemaCreationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaCreationStatusResponseUnmarshaller.Instance;

            return Invoke<GetSchemaCreationStatusResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaCreationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  GetSourceApiAssociation

        /// <summary>
        /// Retrieves a <c>SourceApiAssociation</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSourceApiAssociation service method.</param>
        /// 
        /// <returns>The response from the GetSourceApiAssociation service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetSourceApiAssociation">REST API Reference for GetSourceApiAssociation Operation</seealso>
        public virtual GetSourceApiAssociationResponse GetSourceApiAssociation(GetSourceApiAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSourceApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSourceApiAssociationResponseUnmarshaller.Instance;

            return Invoke<GetSourceApiAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSourceApiAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSourceApiAssociation operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSourceApiAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetSourceApiAssociation">REST API Reference for GetSourceApiAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetSourceApiAssociation(GetSourceApiAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSourceApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSourceApiAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSourceApiAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSourceApiAssociation.</param>
        /// 
        /// <returns>Returns a  GetSourceApiAssociationResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetSourceApiAssociation">REST API Reference for GetSourceApiAssociation Operation</seealso>
        public virtual GetSourceApiAssociationResponse EndGetSourceApiAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSourceApiAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetType

        /// <summary>
        /// Retrieves a <c>Type</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetType service method.</param>
        /// 
        /// <returns>The response from the GetType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetType">REST API Reference for GetType Operation</seealso>
        public virtual GetTypeResponse GetType(GetTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypeResponseUnmarshaller.Instance;

            return Invoke<GetTypeResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// API keys are deleted automatically 60 days after they expire. However, they may still
        /// be included in the response until they have actually been deleted. You can safely
        /// call <c>DeleteApiKey</c> to manually delete a key before it's automatically deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiKeys service method.</param>
        /// 
        /// <returns>The response from the ListApiKeys service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListApiKeys">REST API Reference for ListApiKeys Operation</seealso>
        public virtual ListApiKeysResponse ListApiKeys(ListApiKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApiKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiKeysResponseUnmarshaller.Instance;

            return Invoke<ListApiKeysResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApiKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  ListApis

        /// <summary>
        /// Lists the APIs in your AppSync account.
        /// 
        ///  
        /// <para>
        ///  <c>ListApis</c> returns only the high level API details. For more detailed information
        /// about an API, use <c>GetApi</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApis service method.</param>
        /// 
        /// <returns>The response from the ListApis service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListApis">REST API Reference for ListApis Operation</seealso>
        public virtual ListApisResponse ListApis(ListApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApisResponseUnmarshaller.Instance;

            return Invoke<ListApisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApis operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListApis">REST API Reference for ListApis Operation</seealso>
        public virtual IAsyncResult BeginListApis(ListApisRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApis.</param>
        /// 
        /// <returns>Returns a  ListApisResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListApis">REST API Reference for ListApis Operation</seealso>
        public virtual ListApisResponse EndListApis(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApisResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelNamespaces

        /// <summary>
        /// Lists the channel namespaces for a specified <c>Api</c>.
        /// 
        ///  
        /// <para>
        ///  <c>ListChannelNamespaces</c> returns only high level details for the channel namespace.
        /// To retrieve code handlers, use <c>GetChannelNamespace</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListChannelNamespaces service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListChannelNamespaces">REST API Reference for ListChannelNamespaces Operation</seealso>
        public virtual ListChannelNamespacesResponse ListChannelNamespaces(ListChannelNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListChannelNamespacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelNamespaces operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListChannelNamespaces">REST API Reference for ListChannelNamespaces Operation</seealso>
        public virtual IAsyncResult BeginListChannelNamespaces(ListChannelNamespacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelNamespacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelNamespaces.</param>
        /// 
        /// <returns>Returns a  ListChannelNamespacesResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListChannelNamespaces">REST API Reference for ListChannelNamespaces Operation</seealso>
        public virtual ListChannelNamespacesResponse EndListChannelNamespaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelNamespacesResponse>(asyncResult);
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
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  ListDomainNames

        /// <summary>
        /// Lists multiple custom domain names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        public virtual ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        public virtual IAsyncResult BeginListDomainNames(ListDomainNamesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainNames.</param>
        /// 
        /// <returns>Returns a  ListDomainNamesResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        public virtual ListDomainNamesResponse EndListDomainNames(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFunctions

        /// <summary>
        /// List multiple functions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual IAsyncResult BeginListFunctions(ListFunctionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctions.</param>
        /// 
        /// <returns>Returns a  ListFunctionsResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual ListFunctionsResponse EndListFunctions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFunctionsResponse>(asyncResult);
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
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListGraphqlApis">REST API Reference for ListGraphqlApis Operation</seealso>
        public virtual ListGraphqlApisResponse ListGraphqlApis(ListGraphqlApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphqlApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphqlApisResponseUnmarshaller.Instance;

            return Invoke<ListGraphqlApisResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphqlApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphqlApisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolvers">REST API Reference for ListResolvers Operation</seealso>
        public virtual ListResolversResponse ListResolvers(ListResolversRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResolversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversResponseUnmarshaller.Instance;

            return Invoke<ListResolversResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResolversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  ListResolversByFunction

        /// <summary>
        /// List the resolvers that are associated with a specific function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolversByFunction service method.</param>
        /// 
        /// <returns>The response from the ListResolversByFunction service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolversByFunction">REST API Reference for ListResolversByFunction Operation</seealso>
        public virtual ListResolversByFunctionResponse ListResolversByFunction(ListResolversByFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResolversByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversByFunctionResponseUnmarshaller.Instance;

            return Invoke<ListResolversByFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResolversByFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolversByFunction operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResolversByFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolversByFunction">REST API Reference for ListResolversByFunction Operation</seealso>
        public virtual IAsyncResult BeginListResolversByFunction(ListResolversByFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResolversByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversByFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResolversByFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResolversByFunction.</param>
        /// 
        /// <returns>Returns a  ListResolversByFunctionResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolversByFunction">REST API Reference for ListResolversByFunction Operation</seealso>
        public virtual ListResolversByFunctionResponse EndListResolversByFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResolversByFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSourceApiAssociations

        /// <summary>
        /// Lists the <c>SourceApiAssociationSummary</c> data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceApiAssociations service method.</param>
        /// 
        /// <returns>The response from the ListSourceApiAssociations service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListSourceApiAssociations">REST API Reference for ListSourceApiAssociations Operation</seealso>
        public virtual ListSourceApiAssociationsResponse ListSourceApiAssociations(ListSourceApiAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSourceApiAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceApiAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListSourceApiAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceApiAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceApiAssociations operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceApiAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListSourceApiAssociations">REST API Reference for ListSourceApiAssociations Operation</seealso>
        public virtual IAsyncResult BeginListSourceApiAssociations(ListSourceApiAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSourceApiAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceApiAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceApiAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceApiAssociations.</param>
        /// 
        /// <returns>Returns a  ListSourceApiAssociationsResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListSourceApiAssociations">REST API Reference for ListSourceApiAssociations Operation</seealso>
        public virtual ListSourceApiAssociationsResponse EndListSourceApiAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSourceApiAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTypes">REST API Reference for ListTypes Operation</seealso>
        public virtual ListTypesResponse ListTypes(ListTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;

            return Invoke<ListTypesResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  ListTypesByAssociation

        /// <summary>
        /// Lists <c>Type</c> objects by the source API association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypesByAssociation service method.</param>
        /// 
        /// <returns>The response from the ListTypesByAssociation service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTypesByAssociation">REST API Reference for ListTypesByAssociation Operation</seealso>
        public virtual ListTypesByAssociationResponse ListTypesByAssociation(ListTypesByAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesByAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesByAssociationResponseUnmarshaller.Instance;

            return Invoke<ListTypesByAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTypesByAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypesByAssociation operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTypesByAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTypesByAssociation">REST API Reference for ListTypesByAssociation Operation</seealso>
        public virtual IAsyncResult BeginListTypesByAssociation(ListTypesByAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesByAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesByAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypesByAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypesByAssociation.</param>
        /// 
        /// <returns>Returns a  ListTypesByAssociationResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTypesByAssociation">REST API Reference for ListTypesByAssociation Operation</seealso>
        public virtual ListTypesByAssociationResponse EndListTypesByAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTypesByAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutGraphqlApiEnvironmentVariables

        /// <summary>
        /// Creates a list of environmental variables in an API by its ID value. 
        /// 
        ///  
        /// <para>
        /// When creating an environmental variable, it must follow the constraints below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Both JavaScript and VTL templates support environmental variables.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Environmental variables are not evaluated before function invocation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Environmental variables only support string values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any defined value in an environmental variable is considered a string literal and
        /// not expanded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Variable evaluations should ideally be performed in the function code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When creating an environmental variable key-value pair, it must follow the additional
        /// constraints below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Keys must begin with a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys must be at least two characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys can only contain letters, numbers, and the underscore character (_).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Values can be up to 512 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can configure up to 50 key-value pairs in a GraphQL API.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a list of environmental variables by adding it to the <c>environmentVariables</c>
        /// payload as a list in the format <c>{"key1":"value1","key2":"value2", …}</c>. Note
        /// that each call of the <c>PutGraphqlApiEnvironmentVariables</c> action will result
        /// in the overwriting of the existing environmental variable list of that API. This means
        /// the existing environmental variables will be lost. To avoid this, you must include
        /// all existing and new environmental variables in the list each time you call this action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGraphqlApiEnvironmentVariables service method.</param>
        /// 
        /// <returns>The response from the PutGraphqlApiEnvironmentVariables service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/PutGraphqlApiEnvironmentVariables">REST API Reference for PutGraphqlApiEnvironmentVariables Operation</seealso>
        public virtual PutGraphqlApiEnvironmentVariablesResponse PutGraphqlApiEnvironmentVariables(PutGraphqlApiEnvironmentVariablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutGraphqlApiEnvironmentVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGraphqlApiEnvironmentVariablesResponseUnmarshaller.Instance;

            return Invoke<PutGraphqlApiEnvironmentVariablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutGraphqlApiEnvironmentVariables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGraphqlApiEnvironmentVariables operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGraphqlApiEnvironmentVariables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/PutGraphqlApiEnvironmentVariables">REST API Reference for PutGraphqlApiEnvironmentVariables Operation</seealso>
        public virtual IAsyncResult BeginPutGraphqlApiEnvironmentVariables(PutGraphqlApiEnvironmentVariablesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutGraphqlApiEnvironmentVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGraphqlApiEnvironmentVariablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutGraphqlApiEnvironmentVariables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGraphqlApiEnvironmentVariables.</param>
        /// 
        /// <returns>Returns a  PutGraphqlApiEnvironmentVariablesResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/PutGraphqlApiEnvironmentVariables">REST API Reference for PutGraphqlApiEnvironmentVariables Operation</seealso>
        public virtual PutGraphqlApiEnvironmentVariablesResponse EndPutGraphqlApiEnvironmentVariables(IAsyncResult asyncResult)
        {
            return EndInvoke<PutGraphqlApiEnvironmentVariablesResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDataSourceIntrospection

        /// <summary>
        /// Creates a new introspection. Returns the <c>introspectionId</c> of the new introspection
        /// after its creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceIntrospection service method.</param>
        /// 
        /// <returns>The response from the StartDataSourceIntrospection service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartDataSourceIntrospection">REST API Reference for StartDataSourceIntrospection Operation</seealso>
        public virtual StartDataSourceIntrospectionResponse StartDataSourceIntrospection(StartDataSourceIntrospectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataSourceIntrospectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceIntrospectionResponseUnmarshaller.Instance;

            return Invoke<StartDataSourceIntrospectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataSourceIntrospection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceIntrospection operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataSourceIntrospection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartDataSourceIntrospection">REST API Reference for StartDataSourceIntrospection Operation</seealso>
        public virtual IAsyncResult BeginStartDataSourceIntrospection(StartDataSourceIntrospectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataSourceIntrospectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceIntrospectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataSourceIntrospection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataSourceIntrospection.</param>
        /// 
        /// <returns>Returns a  StartDataSourceIntrospectionResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartDataSourceIntrospection">REST API Reference for StartDataSourceIntrospection Operation</seealso>
        public virtual StartDataSourceIntrospectionResponse EndStartDataSourceIntrospection(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDataSourceIntrospectionResponse>(asyncResult);
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
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartSchemaCreation">REST API Reference for StartSchemaCreation Operation</seealso>
        public virtual StartSchemaCreationResponse StartSchemaCreation(StartSchemaCreationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSchemaCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaCreationResponseUnmarshaller.Instance;

            return Invoke<StartSchemaCreationResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSchemaCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaCreationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  StartSchemaMerge

        /// <summary>
        /// Initiates a merge operation. Returns a status that shows the result of the merge operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaMerge service method.</param>
        /// 
        /// <returns>The response from the StartSchemaMerge service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartSchemaMerge">REST API Reference for StartSchemaMerge Operation</seealso>
        public virtual StartSchemaMergeResponse StartSchemaMerge(StartSchemaMergeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSchemaMergeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaMergeResponseUnmarshaller.Instance;

            return Invoke<StartSchemaMergeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSchemaMerge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaMerge operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSchemaMerge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartSchemaMerge">REST API Reference for StartSchemaMerge Operation</seealso>
        public virtual IAsyncResult BeginStartSchemaMerge(StartSchemaMergeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSchemaMergeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaMergeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSchemaMerge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSchemaMerge.</param>
        /// 
        /// <returns>Returns a  StartSchemaMergeResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartSchemaMerge">REST API Reference for StartSchemaMerge Operation</seealso>
        public virtual StartSchemaMergeResponse EndStartSchemaMerge(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSchemaMergeResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags a resource with user-supplied tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Untags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApi

        /// <summary>
        /// Updates an <c>Api</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi service method.</param>
        /// 
        /// <returns>The response from the UpdateApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        public virtual UpdateApiResponse UpdateApi(UpdateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return Invoke<UpdateApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        public virtual IAsyncResult BeginUpdateApi(UpdateApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApi.</param>
        /// 
        /// <returns>Returns a  UpdateApiResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        public virtual UpdateApiResponse EndUpdateApi(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApiResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApiCache

        /// <summary>
        /// Updates the cache for the GraphQL API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiCache service method.</param>
        /// 
        /// <returns>The response from the UpdateApiCache service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApiCache">REST API Reference for UpdateApiCache Operation</seealso>
        public virtual UpdateApiCacheResponse UpdateApiCache(UpdateApiCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiCacheResponseUnmarshaller.Instance;

            return Invoke<UpdateApiCacheResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiCache operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApiCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApiCache">REST API Reference for UpdateApiCache Operation</seealso>
        public virtual IAsyncResult BeginUpdateApiCache(UpdateApiCacheRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiCacheResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiCache.</param>
        /// 
        /// <returns>Returns a  UpdateApiCacheResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApiCache">REST API Reference for UpdateApiCache Operation</seealso>
        public virtual UpdateApiCacheResponse EndUpdateApiCache(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApiCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApiKey

        /// <summary>
        /// Updates an API key. You can update the key as long as it's not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey service method.</param>
        /// 
        /// <returns>The response from the UpdateApiKey service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ApiKeyValidityOutOfBoundsException">
        /// The API key expiration must be set to a value between 1 and 365 days from creation
        /// (for <c>CreateApiKey</c>) or from update (for <c>UpdateApiKey</c>).
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        public virtual UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateApiKeyResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  UpdateChannelNamespace

        /// <summary>
        /// Updates a <c>ChannelNamespace</c> associated with an <c>Api</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelNamespace service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateChannelNamespace">REST API Reference for UpdateChannelNamespace Operation</seealso>
        public virtual UpdateChannelNamespaceResponse UpdateChannelNamespace(UpdateChannelNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelNamespace operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateChannelNamespace">REST API Reference for UpdateChannelNamespace Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannelNamespace(UpdateChannelNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelNamespace.</param>
        /// 
        /// <returns>Returns a  UpdateChannelNamespaceResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateChannelNamespace">REST API Reference for UpdateChannelNamespace Operation</seealso>
        public virtual UpdateChannelNamespaceResponse EndUpdateChannelNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSource

        /// <summary>
        /// Updates a <c>DataSource</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  UpdateDomainName

        /// <summary>
        /// Updates a custom <c>DomainName</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainName service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual IAsyncResult BeginUpdateDomainName(UpdateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainName.</param>
        /// 
        /// <returns>Returns a  UpdateDomainNameResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual UpdateDomainNameResponse EndUpdateDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFunction

        /// <summary>
        /// Updates a <c>Function</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunction service method.</param>
        /// 
        /// <returns>The response from the UpdateFunction service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        public virtual UpdateFunctionResponse UpdateFunction(UpdateFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunction operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        public virtual IAsyncResult BeginUpdateFunction(UpdateFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunction.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        public virtual UpdateFunctionResponse EndUpdateFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGraphqlApi

        /// <summary>
        /// Updates a <c>GraphqlApi</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGraphqlApi service method.</param>
        /// 
        /// <returns>The response from the UpdateGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateGraphqlApi">REST API Reference for UpdateGraphqlApi Operation</seealso>
        public virtual UpdateGraphqlApiResponse UpdateGraphqlApi(UpdateGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<UpdateGraphqlApiResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGraphqlApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Updates a <c>Resolver</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolver service method.</param>
        /// 
        /// <returns>The response from the UpdateResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateResolver">REST API Reference for UpdateResolver Operation</seealso>
        public virtual UpdateResolverResponse UpdateResolver(UpdateResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  UpdateSourceApiAssociation

        /// <summary>
        /// Updates some of the configuration choices of a particular source API association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceApiAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateSourceApiAssociation service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateSourceApiAssociation">REST API Reference for UpdateSourceApiAssociation Operation</seealso>
        public virtual UpdateSourceApiAssociationResponse UpdateSourceApiAssociation(UpdateSourceApiAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSourceApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceApiAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateSourceApiAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSourceApiAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceApiAssociation operation on AmazonAppSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSourceApiAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateSourceApiAssociation">REST API Reference for UpdateSourceApiAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateSourceApiAssociation(UpdateSourceApiAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSourceApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceApiAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSourceApiAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSourceApiAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateSourceApiAssociationResult from AppSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateSourceApiAssociation">REST API Reference for UpdateSourceApiAssociation Operation</seealso>
        public virtual UpdateSourceApiAssociationResponse EndUpdateSourceApiAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSourceApiAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateType

        /// <summary>
        /// Updates a <c>Type</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateType service method.</param>
        /// 
        /// <returns>The response from the UpdateType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateType">REST API Reference for UpdateType Operation</seealso>
        public virtual UpdateTypeResponse UpdateType(UpdateTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateTypeResponse>(request, options);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
            var resolver = new AmazonAppSyncEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}