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
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from CognitoSync.</returns>
        DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from CognitoSync.</returns>
        DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPoolUsage operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityPoolUsage
        ///         operation.</returns>
        IAsyncResult BeginDescribeIdentityPoolUsage(DescribeIdentityPoolUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityPoolUsage operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityPoolUsage.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityPoolUsageResult from CognitoSync.</returns>
        DescribeIdentityPoolUsageResponse EndDescribeIdentityPoolUsage(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityUsage operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityUsage
        ///         operation.</returns>
        IAsyncResult BeginDescribeIdentityUsage(DescribeIdentityUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityUsage operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityUsage.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityUsageResult from CognitoSync.</returns>
        DescribeIdentityUsageResponse EndDescribeIdentityUsage(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolConfiguration operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityPoolConfiguration
        ///         operation.</returns>
        IAsyncResult BeginGetIdentityPoolConfiguration(GetIdentityPoolConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityPoolConfiguration operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityPoolConfiguration.</param>
        /// 
        /// <returns>Returns a  GetIdentityPoolConfigurationResult from CognitoSync.</returns>
        GetIdentityPoolConfigurationResponse EndGetIdentityPoolConfiguration(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from CognitoSync.</returns>
        ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPoolUsage operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityPoolUsage
        ///         operation.</returns>
        IAsyncResult BeginListIdentityPoolUsage(ListIdentityPoolUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityPoolUsage operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityPoolUsage.</param>
        /// 
        /// <returns>Returns a  ListIdentityPoolUsageResult from CognitoSync.</returns>
        ListIdentityPoolUsageResponse EndListIdentityPoolUsage(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListRecords operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecords
        ///         operation.</returns>
        IAsyncResult BeginListRecords(ListRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecords operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecords.</param>
        /// 
        /// <returns>Returns a  ListRecordsResult from CognitoSync.</returns>
        ListRecordsResponse EndListRecords(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevice operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDevice
        ///         operation.</returns>
        IAsyncResult BeginRegisterDevice(RegisterDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDevice operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDevice.</param>
        /// 
        /// <returns>Returns a  RegisterDeviceResult from CognitoSync.</returns>
        RegisterDeviceResponse EndRegisterDevice(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolConfiguration operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityPoolConfiguration
        ///         operation.</returns>
        IAsyncResult BeginSetIdentityPoolConfiguration(SetIdentityPoolConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityPoolConfiguration operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityPoolConfiguration.</param>
        /// 
        /// <returns>Returns a  SetIdentityPoolConfigurationResult from CognitoSync.</returns>
        SetIdentityPoolConfigurationResponse EndSetIdentityPoolConfiguration(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToDataset operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubscribeToDataset
        ///         operation.</returns>
        IAsyncResult BeginSubscribeToDataset(SubscribeToDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SubscribeToDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubscribeToDataset.</param>
        /// 
        /// <returns>Returns a  SubscribeToDatasetResult from CognitoSync.</returns>
        SubscribeToDatasetResponse EndSubscribeToDataset(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromDataset operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnsubscribeFromDataset
        ///         operation.</returns>
        IAsyncResult BeginUnsubscribeFromDataset(UnsubscribeFromDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnsubscribeFromDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnsubscribeFromDataset.</param>
        /// 
        /// <returns>Returns a  UnsubscribeFromDatasetResult from CognitoSync.</returns>
        UnsubscribeFromDatasetResponse EndUnsubscribeFromDataset(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecords operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecords
        ///         operation.</returns>
        IAsyncResult BeginUpdateRecords(UpdateRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecords operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecords.</param>
        /// 
        /// <returns>Returns a  UpdateRecordsResult from CognitoSync.</returns>
        UpdateRecordsResponse EndUpdateRecords(IAsyncResult asyncResult);

        #endregion
        
    }
}