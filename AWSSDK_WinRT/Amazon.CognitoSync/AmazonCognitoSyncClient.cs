/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.CognitoSync.Model;
using Amazon.CognitoSync.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoSync
{
    /// <summary>
    /// Implementation for accessing CognitoSync
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
    /// </summary>
	public partial class AmazonCognitoSyncClient : AmazonWebServiceClient, Amazon.CognitoSync.IAmazonCognitoSync
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

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
            : this(credentials, new AmazonCognitoSyncConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Credentials and an
        /// AmazonCognitoSyncClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(AWSCredentials credentials, AmazonCognitoSyncConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoSyncConfig(){RegionEndpoint = region})
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var task = DeleteDatasetAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Deletes the specific dataset. The dataset will be deleted permanently, and the action
        /// can't be undone. Datasets that this dataset was merged with will no longer report
        /// the merge. Any consequent operation on this dataset will result in a ResourceNotFoundException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="T:Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest deleteDatasetRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDatasetRequestMarshaller();
            var unmarshaller = DeleteDatasetResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteDatasetRequest, DeleteDatasetResponse>(deleteDatasetRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var task = DescribeDatasetAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Gets metadata about a dataset by identity and dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="T:Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest describeDatasetRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDatasetRequestMarshaller();
            var unmarshaller = DescribeDatasetResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDatasetRequest, DescribeDatasetResponse>(describeDatasetRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeIdentityPoolUsageResponse DescribeIdentityPoolUsage(DescribeIdentityPoolUsageRequest request)
        {
            var task = DescribeIdentityPoolUsageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Gets usage details (for example, data storage) about a particular identity pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPoolUsage service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="T:Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(DescribeIdentityPoolUsageRequest describeIdentityPoolUsageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeIdentityPoolUsageRequestMarshaller();
            var unmarshaller = DescribeIdentityPoolUsageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeIdentityPoolUsageRequest, DescribeIdentityPoolUsageResponse>(describeIdentityPoolUsageRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeIdentityUsageResponse DescribeIdentityUsage(DescribeIdentityUsageRequest request)
        {
            var task = DescribeIdentityUsageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Gets usage information for an identity, including number of datasets and data usage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityUsage service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="T:Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeIdentityUsageResponse> DescribeIdentityUsageAsync(DescribeIdentityUsageRequest describeIdentityUsageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeIdentityUsageRequestMarshaller();
            var unmarshaller = DescribeIdentityUsageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeIdentityUsageRequest, DescribeIdentityUsageResponse>(describeIdentityUsageRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var task = ListDatasetsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Lists datasets for an identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by CognitoSync.</returns>
        /// <exception cref="T:Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest listDatasetsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDatasetsRequestMarshaller();
            var unmarshaller = ListDatasetsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListDatasetsRequest, ListDatasetsResponse>(listDatasetsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListIdentityPoolUsageResponse ListIdentityPoolUsage(ListIdentityPoolUsageRequest request)
        {
            var task = ListIdentityPoolUsageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Gets a list of identity pools registered with Cognito.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPoolUsage service method.</param>
        /// 
        /// <returns>The response from the ListIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="T:Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListIdentityPoolUsageResponse> ListIdentityPoolUsageAsync(ListIdentityPoolUsageRequest listIdentityPoolUsageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListIdentityPoolUsageRequestMarshaller();
            var unmarshaller = ListIdentityPoolUsageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListIdentityPoolUsageRequest, ListIdentityPoolUsageResponse>(listIdentityPoolUsageRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListRecordsResponse ListRecords(ListRecordsRequest request)
        {
            var task = ListRecordsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Gets paginated records, optionally changed after a particular sync count for a dataset
        /// and identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecords service method.</param>
        /// 
        /// <returns>The response from the ListRecords service method, as returned by CognitoSync.</returns>
        /// <exception cref="T:Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListRecordsResponse> ListRecordsAsync(ListRecordsRequest listRecordsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRecordsRequestMarshaller();
            var unmarshaller = ListRecordsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListRecordsRequest, ListRecordsResponse>(listRecordsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateRecordsResponse UpdateRecords(UpdateRecordsRequest request)
        {
            var task = UpdateRecordsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Posts updates to records and add and delete records for a dataset and user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecords service method.</param>
        /// 
        /// <returns>The response from the UpdateRecords service method, as returned by CognitoSync.</returns>
        /// <exception cref="T:Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.LimitExceededException">
        /// Thrown when the limit on the number of objects or operations has been exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.ResourceConflictException">
        /// Thrown if an update can't be applied because the resource was changed by another call
        /// and this would result in a conflict.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateRecordsResponse> UpdateRecordsAsync(UpdateRecordsRequest updateRecordsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateRecordsRequestMarshaller();
            var unmarshaller = UpdateRecordsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateRecordsRequest, UpdateRecordsResponse>(updateRecordsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
