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
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CognitoSync.Model;

namespace Amazon.CognitoSync
{
    /// <summary>
    /// Interface for accessing CognitoSync
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
    /// </summary>
    public partial interface IAmazonCognitoSync : IDisposable
    {

        
        #region  DeleteDataset

        /// <summary>
        /// Deletes the specific dataset. The dataset will be deleted permanently, and the action
        /// can't be undone. Datasets that this dataset was merged with will no longer report
        /// the merge. Any consequent operation on this dataset will result in a ResourceNotFoundException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDataset

        /// <summary>
        /// Gets metadata about a dataset by identity and dataset name. The credentials used to
        /// make this API call need to have access to the identity data. With Amazon Cognito Sync,
        /// each identity has access only to its own data. You should use Amazon Cognito Identity
        /// service to retrieve the credentials necessary to make this API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeIdentityPoolUsage

        /// <summary>
        /// Gets usage details (for example, data storage) about a particular identity pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPoolUsage service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        DescribeIdentityPoolUsageResponse DescribeIdentityPoolUsage(DescribeIdentityPoolUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityPoolUsage operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPoolUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(DescribeIdentityPoolUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeIdentityUsage

        /// <summary>
        /// Gets usage information for an identity, including number of datasets and data usage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityUsage service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        DescribeIdentityUsageResponse DescribeIdentityUsage(DescribeIdentityUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityUsage operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeIdentityUsageResponse> DescribeIdentityUsageAsync(DescribeIdentityUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityPoolConfiguration

        /// <summary>
        /// Gets the configuration settings of an identity pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        GetIdentityPoolConfigurationResponse GetIdentityPoolConfiguration(GetIdentityPoolConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityPoolConfiguration operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(GetIdentityPoolConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDatasets

        /// <summary>
        /// Lists datasets for an identity. The credentials used to make this API call need to
        /// have access to the identity data. With Amazon Cognito Sync, each identity has access
        /// only to its own data. You should use Amazon Cognito Identity service to retrieve the
        /// credentials necessary to make this API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        ListDatasetsResponse ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIdentityPoolUsage

        /// <summary>
        /// Gets a list of identity pools registered with Cognito.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPoolUsage service method.</param>
        /// 
        /// <returns>The response from the ListIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        ListIdentityPoolUsageResponse ListIdentityPoolUsage(ListIdentityPoolUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPoolUsage operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPoolUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListIdentityPoolUsageResponse> ListIdentityPoolUsageAsync(ListIdentityPoolUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRecords

        /// <summary>
        /// Gets paginated records, optionally changed after a particular sync count for a dataset
        /// and identity. The credentials used to make this API call need to have access to the
        /// identity data. With Amazon Cognito Sync, each identity has access only to its own
        /// data. You should use Amazon Cognito Identity service to retrieve the credentials necessary
        /// to make this API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecords service method.</param>
        /// 
        /// <returns>The response from the ListRecords service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        ListRecordsResponse ListRecords(ListRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecords operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecords operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListRecordsResponse> ListRecordsAsync(ListRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterDevice

        /// <summary>
        /// Registers a device to receive push sync notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevice service method.</param>
        /// 
        /// <returns>The response from the RegisterDevice service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDevice operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetIdentityPoolConfiguration

        /// <summary>
        /// Sets the necessary configuration for push sync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolConfiguration service method.</param>
        /// 
        /// <returns>The response from the SetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        SetIdentityPoolConfigurationResponse SetIdentityPoolConfiguration(SetIdentityPoolConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityPoolConfiguration operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetIdentityPoolConfigurationResponse> SetIdentityPoolConfigurationAsync(SetIdentityPoolConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SubscribeToDataset

        /// <summary>
        /// Subscribes to receive notifications when a dataset is modified by another device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToDataset service method.</param>
        /// 
        /// <returns>The response from the SubscribeToDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        SubscribeToDatasetResponse SubscribeToDataset(SubscribeToDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SubscribeToDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToDataset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SubscribeToDatasetResponse> SubscribeToDatasetAsync(SubscribeToDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UnsubscribeFromDataset

        /// <summary>
        /// Unsubscribe from receiving notifications when a dataset is modified by another device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromDataset service method.</param>
        /// 
        /// <returns>The response from the UnsubscribeFromDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        UnsubscribeFromDatasetResponse UnsubscribeFromDataset(UnsubscribeFromDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnsubscribeFromDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromDataset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UnsubscribeFromDatasetResponse> UnsubscribeFromDatasetAsync(UnsubscribeFromDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRecords

        /// <summary>
        /// Posts updates to records and add and delete records for a dataset and user. The credentials
        /// used to make this API call need to have access to the identity data. With Amazon Cognito
        /// Sync, each identity has access only to its own data. You should use Amazon Cognito
        /// Identity service to retrieve the credentials necessary to make this API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecords service method.</param>
        /// 
        /// <returns>The response from the UpdateRecords service method, as returned by CognitoSync.</returns>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// Thrown when the limit on the number of objects or operations has been exceeded.
        /// </exception>
        /// <exception cref="NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="ResourceConflictException">
        /// Thrown if an update can't be applied because the resource was changed by another call
        /// and this would result in a conflict.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        UpdateRecordsResponse UpdateRecords(UpdateRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecords operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecords operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateRecordsResponse> UpdateRecordsAsync(UpdateRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}