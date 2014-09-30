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
    /// </summary>
    public partial interface IAmazonCognitoSync : IDisposable
    {
                
        #region  DeleteDataset

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
                
        #region  ListDatasets

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
                
        #region  UpdateRecords

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