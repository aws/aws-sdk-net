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
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CognitoSync.Model;
using Amazon.CognitoSync.Model.Internal.MarshallTransformations;
using Amazon.CognitoSync.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CognitoSync
{
    /// <summary>
    /// <para>Implementation for accessing CognitoSync</para>
    ///
    /// Amazon Cognito Sync 
    /// <para>
    /// Amazon Cognito Sync provides an AWS service and client library that enable cross-device
    /// syncing of application-related user data. High-level client libraries are available
    /// for both iOS and Android. You can use these libraries to persist data locally so that
    /// it's available even if the device is offline. Developer credentials don't need to
    /// be stored on the mobile device to access the service. You can use Amazon Cognito to
    /// obtain a normalized user ID and credentials. User data is persisted in a dataset that
    /// can store up to 1 MB of key-value pairs, and you can have up to 20 datasets per user
    /// identity.
    /// </para>
    ///  
    /// <para>
    /// With Amazon Cognito Sync, the data stored for each identity is accessible only to
    /// credentials assigned to that identity. In order to use the Cognito Sync service, you
    /// need to make API calls using credentials retrieved with <a href="http://docs.aws.amazon.com/cognitoidentity/latest/APIReference/Welcome.html">Amazon
    /// Cognito Identity service</a>.
    /// </para>
    ///  
    /// <para>
    /// If you want to use Cognito Sync in an Android or iOS application, you will probably
    /// want to make API calls via the AWS Mobile SDK. To learn more, see the <a href="http://docs.aws.amazon.com/mobile/sdkforandroid/developerguide/cognito-sync.html">Developer
    /// Guide for Android</a> and the <a href="http://docs.aws.amazon.com/mobile/sdkforios/developerguide/cognito-sync.html">Developer
    /// Guide for iOS</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCognitoSyncClient : AmazonServiceClient, IAmazonCognitoSync
    {
        private static IServiceMetadata serviceMetadata = new AmazonCognitoSyncMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with the credentials loaded from the application's
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
        public AmazonCognitoSyncClient()
            : base(new AmazonCognitoSyncConfig()) { }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with the credentials loaded from the application's
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
        public AmazonCognitoSyncClient(RegionEndpoint region)
            : base(new AmazonCognitoSyncConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(AmazonCognitoSyncConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCognitoSyncClient(AWSCredentials credentials)
            : this(credentials, new AmazonCognitoSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoSyncClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCognitoSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Credentials and an
        /// AmazonCognitoSyncClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(AWSCredentials credentials, AmazonCognitoSyncConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoSyncConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.RetryHandler>(new Amazon.CognitoSync.Internal.CognitoCredentialsRetriever());
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCognitoSyncEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCognitoSyncAuthSchemeHandler());
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


        #region  BulkPublish


        /// <summary>
        /// Initiates a bulk publish of all existing datasets for an Identity Pool to the configured
        /// stream. Customers are limited to one successful bulk publish per 24 hours. Bulk publish
        /// is an asynchronous request, customers can see the status of the request via the GetBulkPublishDetails
        /// operation.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BulkPublish service method.</param>
        /// 
        /// <returns>The response from the BulkPublish service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.AlreadyStreamedException">
        /// An exception thrown when a bulk publish operation is requested less than 24 hours
        /// after a previous bulk publish operation completed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.DuplicateRequestException">
        /// An exception thrown when there is an IN_PROGRESS bulk publish operation for the given
        /// identity pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/BulkPublish">REST API Reference for BulkPublish Operation</seealso>
        public virtual BulkPublishResponse BulkPublish(BulkPublishRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BulkPublishRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BulkPublishResponseUnmarshaller.Instance;

            return Invoke<BulkPublishResponse>(request, options);
        }


        /// <summary>
        /// Initiates a bulk publish of all existing datasets for an Identity Pool to the configured
        /// stream. Customers are limited to one successful bulk publish per 24 hours. Bulk publish
        /// is an asynchronous request, customers can see the status of the request via the GetBulkPublishDetails
        /// operation.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BulkPublish service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BulkPublish service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.AlreadyStreamedException">
        /// An exception thrown when a bulk publish operation is requested less than 24 hours
        /// after a previous bulk publish operation completed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.DuplicateRequestException">
        /// An exception thrown when there is an IN_PROGRESS bulk publish operation for the given
        /// identity pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/BulkPublish">REST API Reference for BulkPublish Operation</seealso>
        public virtual Task<BulkPublishResponse> BulkPublishAsync(BulkPublishRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BulkPublishRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BulkPublishResponseUnmarshaller.Instance;
            
            return InvokeAsync<BulkPublishResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataset


        /// <summary>
        /// Deletes the specific dataset. The dataset will be deleted permanently, and the action
        /// can't be undone. Datasets that this dataset was merged with will no longer report
        /// the merge. Any subsequent operation on this dataset will result in a ResourceNotFoundException.
        /// 
        ///  
        /// <para>
        /// This API can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceConflictException">
        /// Thrown if an update can't be applied because the resource was changed by another call
        /// and this would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specific dataset. The dataset will be deleted permanently, and the action
        /// can't be undone. Datasets that this dataset was merged with will no longer report
        /// the merge. Any subsequent operation on this dataset will result in a ResourceNotFoundException.
        /// 
        ///  
        /// <para>
        /// This API can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceConflictException">
        /// Thrown if an update can't be applied because the resource was changed by another call
        /// and this would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Gets meta data about a dataset by identity and dataset name. With Amazon Cognito Sync,
        /// each identity has access only to its own data. Thus, the credentials used to make
        /// this API call need to have access to the identity data.
        /// 
        ///  
        /// <para>
        /// This API can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials. You should use Cognito Identity credentials to make
        /// this API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }


        /// <summary>
        /// Gets meta data about a dataset by identity and dataset name. With Amazon Cognito Sync,
        /// each identity has access only to its own data. Thus, the credentials used to make
        /// this API call need to have access to the identity data.
        /// 
        ///  
        /// <para>
        /// This API can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials. You should use Cognito Identity credentials to make
        /// this API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentityPoolUsage


        /// <summary>
        /// Gets usage details (for example, data storage) about a particular identity pool.
        /// 
        ///  
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE) created by Amazon Cognito. GUID generation is unique within a region.</param>
        /// 
        /// <returns>The response from the DescribeIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/DescribeIdentityPoolUsage">REST API Reference for DescribeIdentityPoolUsage Operation</seealso>
        public virtual DescribeIdentityPoolUsageResponse DescribeIdentityPoolUsage(string identityPoolId)
        {
            var request = new DescribeIdentityPoolUsageRequest();
            request.IdentityPoolId = identityPoolId;
            return DescribeIdentityPoolUsage(request);
        }


        /// <summary>
        /// Gets usage details (for example, data storage) about a particular identity pool.
        /// 
        ///  
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPoolUsage service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/DescribeIdentityPoolUsage">REST API Reference for DescribeIdentityPoolUsage Operation</seealso>
        public virtual DescribeIdentityPoolUsageResponse DescribeIdentityPoolUsage(DescribeIdentityPoolUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIdentityPoolUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityPoolUsageResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityPoolUsageResponse>(request, options);
        }


        /// <summary>
        /// Gets usage details (for example, data storage) about a particular identity pool.
        /// 
        ///  
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE) created by Amazon Cognito. GUID generation is unique within a region.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/DescribeIdentityPoolUsage">REST API Reference for DescribeIdentityPoolUsage Operation</seealso>
        public virtual Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeIdentityPoolUsageRequest();
            request.IdentityPoolId = identityPoolId;
            return DescribeIdentityPoolUsageAsync(request, cancellationToken);
        }


        /// <summary>
        /// Gets usage details (for example, data storage) about a particular identity pool.
        /// 
        ///  
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPoolUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/DescribeIdentityPoolUsage">REST API Reference for DescribeIdentityPoolUsage Operation</seealso>
        public virtual Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(DescribeIdentityPoolUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIdentityPoolUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityPoolUsageResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeIdentityPoolUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentityUsage


        /// <summary>
        /// Gets usage information for an identity, including number of datasets and data usage.
        /// 
        ///  
        /// <para>
        /// This API can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityUsage service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/DescribeIdentityUsage">REST API Reference for DescribeIdentityUsage Operation</seealso>
        public virtual DescribeIdentityUsageResponse DescribeIdentityUsage(DescribeIdentityUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIdentityUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityUsageResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityUsageResponse>(request, options);
        }


        /// <summary>
        /// Gets usage information for an identity, including number of datasets and data usage.
        /// 
        ///  
        /// <para>
        /// This API can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdentityUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/DescribeIdentityUsage">REST API Reference for DescribeIdentityUsage Operation</seealso>
        public virtual Task<DescribeIdentityUsageResponse> DescribeIdentityUsageAsync(DescribeIdentityUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIdentityUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityUsageResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeIdentityUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBulkPublishDetails


        /// <summary>
        /// Get the status of the last BulkPublish operation for an identity pool.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBulkPublishDetails service method.</param>
        /// 
        /// <returns>The response from the GetBulkPublishDetails service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/GetBulkPublishDetails">REST API Reference for GetBulkPublishDetails Operation</seealso>
        public virtual GetBulkPublishDetailsResponse GetBulkPublishDetails(GetBulkPublishDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBulkPublishDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBulkPublishDetailsResponseUnmarshaller.Instance;

            return Invoke<GetBulkPublishDetailsResponse>(request, options);
        }


        /// <summary>
        /// Get the status of the last BulkPublish operation for an identity pool.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBulkPublishDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBulkPublishDetails service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/GetBulkPublishDetails">REST API Reference for GetBulkPublishDetails Operation</seealso>
        public virtual Task<GetBulkPublishDetailsResponse> GetBulkPublishDetailsAsync(GetBulkPublishDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBulkPublishDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBulkPublishDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBulkPublishDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCognitoEvents


        /// <summary>
        /// Gets the events and the corresponding Lambda functions associated with an identity
        /// pool.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCognitoEvents service method.</param>
        /// 
        /// <returns>The response from the GetCognitoEvents service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/GetCognitoEvents">REST API Reference for GetCognitoEvents Operation</seealso>
        public virtual GetCognitoEventsResponse GetCognitoEvents(GetCognitoEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCognitoEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCognitoEventsResponseUnmarshaller.Instance;

            return Invoke<GetCognitoEventsResponse>(request, options);
        }


        /// <summary>
        /// Gets the events and the corresponding Lambda functions associated with an identity
        /// pool.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCognitoEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCognitoEvents service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/GetCognitoEvents">REST API Reference for GetCognitoEvents Operation</seealso>
        public virtual Task<GetCognitoEventsResponse> GetCognitoEventsAsync(GetCognitoEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCognitoEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCognitoEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCognitoEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityPoolConfiguration


        /// <summary>
        /// Gets the configuration settings of an identity pool.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE) created by Amazon Cognito. This is the ID of the pool for which to return a configuration.</param>
        /// 
        /// <returns>The response from the GetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/GetIdentityPoolConfiguration">REST API Reference for GetIdentityPoolConfiguration Operation</seealso>
        public virtual GetIdentityPoolConfigurationResponse GetIdentityPoolConfiguration(string identityPoolId)
        {
            var request = new GetIdentityPoolConfigurationRequest();
            request.IdentityPoolId = identityPoolId;
            return GetIdentityPoolConfiguration(request);
        }


        /// <summary>
        /// Gets the configuration settings of an identity pool.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/GetIdentityPoolConfiguration">REST API Reference for GetIdentityPoolConfiguration Operation</seealso>
        public virtual GetIdentityPoolConfigurationResponse GetIdentityPoolConfiguration(GetIdentityPoolConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdentityPoolConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityPoolConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetIdentityPoolConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Gets the configuration settings of an identity pool.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE) created by Amazon Cognito. This is the ID of the pool for which to return a configuration.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/GetIdentityPoolConfiguration">REST API Reference for GetIdentityPoolConfiguration Operation</seealso>
        public virtual Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetIdentityPoolConfigurationRequest();
            request.IdentityPoolId = identityPoolId;
            return GetIdentityPoolConfigurationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Gets the configuration settings of an identity pool.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/GetIdentityPoolConfiguration">REST API Reference for GetIdentityPoolConfiguration Operation</seealso>
        public virtual Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(GetIdentityPoolConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdentityPoolConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityPoolConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIdentityPoolConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// Lists datasets for an identity. With Amazon Cognito Sync, each identity has access
        /// only to its own data. Thus, the credentials used to make this API call need to have
        /// access to the identity data.
        /// 
        ///  
        /// <para>
        /// ListDatasets can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials. You should use the Cognito Identity credentials to
        /// make this API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }


        /// <summary>
        /// Lists datasets for an identity. With Amazon Cognito Sync, each identity has access
        /// only to its own data. Thus, the credentials used to make this API call need to have
        /// access to the identity data.
        /// 
        ///  
        /// <para>
        /// ListDatasets can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials. You should use the Cognito Identity credentials to
        /// make this API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDatasetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIdentityPoolUsage


        /// <summary>
        /// Gets a list of identity pools registered with Cognito.
        /// 
        ///  
        /// <para>
        /// ListIdentityPoolUsage can only be called with developer credentials. You cannot make
        /// this API call with the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPoolUsage service method.</param>
        /// 
        /// <returns>The response from the ListIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/ListIdentityPoolUsage">REST API Reference for ListIdentityPoolUsage Operation</seealso>
        public virtual ListIdentityPoolUsageResponse ListIdentityPoolUsage(ListIdentityPoolUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentityPoolUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityPoolUsageResponseUnmarshaller.Instance;

            return Invoke<ListIdentityPoolUsageResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of identity pools registered with Cognito.
        /// 
        ///  
        /// <para>
        /// ListIdentityPoolUsage can only be called with developer credentials. You cannot make
        /// this API call with the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPoolUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/ListIdentityPoolUsage">REST API Reference for ListIdentityPoolUsage Operation</seealso>
        public virtual Task<ListIdentityPoolUsageResponse> ListIdentityPoolUsageAsync(ListIdentityPoolUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentityPoolUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityPoolUsageResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListIdentityPoolUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecords


        /// <summary>
        /// Gets paginated records, optionally changed after a particular sync count for a dataset
        /// and identity. With Amazon Cognito Sync, each identity has access only to its own data.
        /// Thus, the credentials used to make this API call need to have access to the identity
        /// data.
        /// 
        ///  
        /// <para>
        /// ListRecords can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials. You should use Cognito Identity credentials to make
        /// this API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecords service method.</param>
        /// 
        /// <returns>The response from the ListRecords service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/ListRecords">REST API Reference for ListRecords Operation</seealso>
        public virtual ListRecordsResponse ListRecords(ListRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordsResponseUnmarshaller.Instance;

            return Invoke<ListRecordsResponse>(request, options);
        }


        /// <summary>
        /// Gets paginated records, optionally changed after a particular sync count for a dataset
        /// and identity. With Amazon Cognito Sync, each identity has access only to its own data.
        /// Thus, the credentials used to make this API call need to have access to the identity
        /// data.
        /// 
        ///  
        /// <para>
        /// ListRecords can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials. You should use Cognito Identity credentials to make
        /// this API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecords service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/ListRecords">REST API Reference for ListRecords Operation</seealso>
        public virtual Task<ListRecordsResponse> ListRecordsAsync(ListRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterDevice


        /// <summary>
        /// Registers a device to receive push sync notifications.
        /// 
        /// 
        /// <para>
        /// This API can only be called with temporary credentials provided by Cognito Identity.
        /// You cannot call this API with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevice service method.</param>
        /// 
        /// <returns>The response from the RegisterDevice service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/RegisterDevice">REST API Reference for RegisterDevice Operation</seealso>
        public virtual RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDeviceResponseUnmarshaller.Instance;

            return Invoke<RegisterDeviceResponse>(request, options);
        }


        /// <summary>
        /// Registers a device to receive push sync notifications.
        /// 
        /// 
        /// <para>
        /// This API can only be called with temporary credentials provided by Cognito Identity.
        /// You cannot call this API with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDevice service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/RegisterDevice">REST API Reference for RegisterDevice Operation</seealso>
        public virtual Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDeviceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetCognitoEvents


        /// <summary>
        /// Sets the AWS Lambda function for a given event type for an identity pool. This request
        /// only updates the key/value pair specified. Other key/values pairs are not updated.
        /// To remove a key value pair, pass a empty value for the particular key.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetCognitoEvents service method.</param>
        /// 
        /// <returns>The response from the SetCognitoEvents service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/SetCognitoEvents">REST API Reference for SetCognitoEvents Operation</seealso>
        public virtual SetCognitoEventsResponse SetCognitoEvents(SetCognitoEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetCognitoEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetCognitoEventsResponseUnmarshaller.Instance;

            return Invoke<SetCognitoEventsResponse>(request, options);
        }


        /// <summary>
        /// Sets the AWS Lambda function for a given event type for an identity pool. This request
        /// only updates the key/value pair specified. Other key/values pairs are not updated.
        /// To remove a key value pair, pass a empty value for the particular key.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetCognitoEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetCognitoEvents service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/SetCognitoEvents">REST API Reference for SetCognitoEvents Operation</seealso>
        public virtual Task<SetCognitoEventsResponse> SetCognitoEventsAsync(SetCognitoEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetCognitoEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetCognitoEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetCognitoEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityPoolConfiguration


        /// <summary>
        /// Sets the necessary configuration for push sync.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolConfiguration service method.</param>
        /// 
        /// <returns>The response from the SetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.ConcurrentModificationException">
        /// Thrown if there are parallel requests to modify a resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/SetIdentityPoolConfiguration">REST API Reference for SetIdentityPoolConfiguration Operation</seealso>
        public virtual SetIdentityPoolConfigurationResponse SetIdentityPoolConfiguration(SetIdentityPoolConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetIdentityPoolConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityPoolConfigurationResponseUnmarshaller.Instance;

            return Invoke<SetIdentityPoolConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Sets the necessary configuration for push sync.
        /// 
        /// 
        /// <para>
        /// This API can only be called with developer credentials. You cannot call this API with
        /// the temporary user credentials provided by Cognito Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.ConcurrentModificationException">
        /// Thrown if there are parallel requests to modify a resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/SetIdentityPoolConfiguration">REST API Reference for SetIdentityPoolConfiguration Operation</seealso>
        public virtual Task<SetIdentityPoolConfigurationResponse> SetIdentityPoolConfigurationAsync(SetIdentityPoolConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetIdentityPoolConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityPoolConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetIdentityPoolConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SubscribeToDataset


        /// <summary>
        /// Subscribes to receive notifications when a dataset is modified by another device.
        /// 
        /// 
        /// <para>
        /// This API can only be called with temporary credentials provided by Cognito Identity.
        /// You cannot call this API with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToDataset service method.</param>
        /// 
        /// <returns>The response from the SubscribeToDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/SubscribeToDataset">REST API Reference for SubscribeToDataset Operation</seealso>
        public virtual SubscribeToDatasetResponse SubscribeToDataset(SubscribeToDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubscribeToDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeToDatasetResponseUnmarshaller.Instance;

            return Invoke<SubscribeToDatasetResponse>(request, options);
        }


        /// <summary>
        /// Subscribes to receive notifications when a dataset is modified by another device.
        /// 
        /// 
        /// <para>
        /// This API can only be called with temporary credentials provided by Cognito Identity.
        /// You cannot call this API with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubscribeToDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/SubscribeToDataset">REST API Reference for SubscribeToDataset Operation</seealso>
        public virtual Task<SubscribeToDatasetResponse> SubscribeToDatasetAsync(SubscribeToDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubscribeToDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeToDatasetResponseUnmarshaller.Instance;
            
            return InvokeAsync<SubscribeToDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnsubscribeFromDataset


        /// <summary>
        /// Unsubscribes from receiving notifications when a dataset is modified by another device.
        /// 
        /// 
        /// <para>
        /// This API can only be called with temporary credentials provided by Cognito Identity.
        /// You cannot call this API with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromDataset service method.</param>
        /// 
        /// <returns>The response from the UnsubscribeFromDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/UnsubscribeFromDataset">REST API Reference for UnsubscribeFromDataset Operation</seealso>
        public virtual UnsubscribeFromDatasetResponse UnsubscribeFromDataset(UnsubscribeFromDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnsubscribeFromDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeFromDatasetResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeFromDatasetResponse>(request, options);
        }


        /// <summary>
        /// Unsubscribes from receiving notifications when a dataset is modified by another device.
        /// 
        /// 
        /// <para>
        /// This API can only be called with temporary credentials provided by Cognito Identity.
        /// You cannot call this API with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnsubscribeFromDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/UnsubscribeFromDataset">REST API Reference for UnsubscribeFromDataset Operation</seealso>
        public virtual Task<UnsubscribeFromDatasetResponse> UnsubscribeFromDatasetAsync(UnsubscribeFromDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnsubscribeFromDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeFromDatasetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UnsubscribeFromDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRecords


        /// <summary>
        /// Posts updates to records and adds and deletes records for a dataset and user.
        /// 
        ///  
        /// <para>
        /// The sync count in the record patch is your last known sync count for that record.
        /// The server will reject an UpdateRecords request with a ResourceConflictException if
        /// you try to patch a record with a new value but a stale sync count.
        /// </para>
        /// 
        /// <para>
        /// For example, if the sync count on the server is 5 for a key called highScore and you
        /// try and submit a new highScore with sync count of 4, the request will be rejected.
        /// To obtain the current sync count for a record, call ListRecords. On a successful update
        /// of the record, the response returns the new sync count for that record. You should
        /// present that sync count the next time you try to update that same record. When the
        /// record does not exist, specify the sync count as 0.
        /// </para>
        ///  
        /// <para>
        /// This API can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecords service method.</param>
        /// 
        /// <returns>The response from the UpdateRecords service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidLambdaFunctionOutputException">
        /// The AWS Lambda function returned invalid output or an exception.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.LambdaThrottledException">
        /// AWS Lambda throttled your account, please contact AWS Support
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.LimitExceededException">
        /// Thrown when the limit on the number of objects or operations has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceConflictException">
        /// Thrown if an update can't be applied because the resource was changed by another call
        /// and this would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/UpdateRecords">REST API Reference for UpdateRecords Operation</seealso>
        public virtual UpdateRecordsResponse UpdateRecords(UpdateRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecordsResponseUnmarshaller.Instance;

            return Invoke<UpdateRecordsResponse>(request, options);
        }


        /// <summary>
        /// Posts updates to records and adds and deletes records for a dataset and user.
        /// 
        ///  
        /// <para>
        /// The sync count in the record patch is your last known sync count for that record.
        /// The server will reject an UpdateRecords request with a ResourceConflictException if
        /// you try to patch a record with a new value but a stale sync count.
        /// </para>
        /// 
        /// <para>
        /// For example, if the sync count on the server is 5 for a key called highScore and you
        /// try and submit a new highScore with sync count of 4, the request will be rejected.
        /// To obtain the current sync count for a record, call ListRecords. On a successful update
        /// of the record, the response returns the new sync count for that record. You should
        /// present that sync count the next time you try to update that same record. When the
        /// record does not exist, specify the sync count as 0.
        /// </para>
        ///  
        /// <para>
        /// This API can be called with temporary user credentials provided by Cognito Identity
        /// or with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecords service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidLambdaFunctionOutputException">
        /// The AWS Lambda function returned invalid output or an exception.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.LambdaThrottledException">
        /// AWS Lambda throttled your account, please contact AWS Support
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.LimitExceededException">
        /// Thrown when the limit on the number of objects or operations has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceConflictException">
        /// Thrown if an update can't be applied because the resource was changed by another call
        /// and this would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-sync-2014-06-30/UpdateRecords">REST API Reference for UpdateRecords Operation</seealso>
        public virtual Task<UpdateRecordsResponse> UpdateRecordsAsync(UpdateRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecordsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRecordsResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}