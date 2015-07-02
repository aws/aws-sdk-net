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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CloudHSM.Model;

namespace Amazon.CloudHSM
{
    /// <summary>
    /// Interface for accessing CloudHSM
    ///
    /// AWS CloudHSM Service
    /// </summary>
    public partial interface IAmazonCloudHSM : IDisposable
    {

        
        #region  CreateHapg


        /// <summary>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </summary>
        /// <param name="label">The label of the new high-availability partition group.</param>
        /// 
        /// <returns>The response from the CreateHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        CreateHapgResponse CreateHapg(string label);

        /// <summary>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHapg service method.</param>
        /// 
        /// <returns>The response from the CreateHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        CreateHapgResponse CreateHapg(CreateHapgRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHapg
        ///         operation.</returns>
        IAsyncResult BeginCreateHapg(CreateHapgRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHapg.</param>
        /// 
        /// <returns>Returns a  CreateHapgResult from CloudHSM.</returns>
        CreateHapgResponse EndCreateHapg(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHsm


        /// <summary>
        /// Creates an uninitialized HSM instance. Running this command provisions an HSM appliance
        /// and will result in charges to your AWS account for the HSM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm service method.</param>
        /// 
        /// <returns>The response from the CreateHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        CreateHsmResponse CreateHsm(CreateHsmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHsm
        ///         operation.</returns>
        IAsyncResult BeginCreateHsm(CreateHsmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsm.</param>
        /// 
        /// <returns>Returns a  CreateHsmResult from CloudHSM.</returns>
        CreateHsmResponse EndCreateHsm(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLunaClient


        /// <summary>
        /// Creates an HSM client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLunaClient service method.</param>
        /// 
        /// <returns>The response from the CreateLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        CreateLunaClientResponse CreateLunaClient(CreateLunaClientRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLunaClient
        ///         operation.</returns>
        IAsyncResult BeginCreateLunaClient(CreateLunaClientRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLunaClient.</param>
        /// 
        /// <returns>Returns a  CreateLunaClientResult from CloudHSM.</returns>
        CreateLunaClientResponse EndCreateLunaClient(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHapg


        /// <summary>
        /// Deletes a high-availability partition group.
        /// </summary>
        /// <param name="hapgArn">The ARN of the high-availability partition group to delete.</param>
        /// 
        /// <returns>The response from the DeleteHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DeleteHapgResponse DeleteHapg(string hapgArn);

        /// <summary>
        /// Deletes a high-availability partition group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHapg service method.</param>
        /// 
        /// <returns>The response from the DeleteHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DeleteHapgResponse DeleteHapg(DeleteHapgRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHapg
        ///         operation.</returns>
        IAsyncResult BeginDeleteHapg(DeleteHapgRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHapg.</param>
        /// 
        /// <returns>Returns a  DeleteHapgResult from CloudHSM.</returns>
        DeleteHapgResponse EndDeleteHapg(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHsm


        /// <summary>
        /// Deletes an HSM. Once complete, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM to delete.</param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DeleteHsmResponse DeleteHsm(string hsmArn);

        /// <summary>
        /// Deletes an HSM. Once complete, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm service method.</param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DeleteHsmResponse DeleteHsm(DeleteHsmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHsm
        ///         operation.</returns>
        IAsyncResult BeginDeleteHsm(DeleteHsmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsm.</param>
        /// 
        /// <returns>Returns a  DeleteHsmResult from CloudHSM.</returns>
        DeleteHsmResponse EndDeleteHsm(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLunaClient


        /// <summary>
        /// Deletes a client.
        /// </summary>
        /// <param name="clientArn">The ARN of the client to delete.</param>
        /// 
        /// <returns>The response from the DeleteLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DeleteLunaClientResponse DeleteLunaClient(string clientArn);

        /// <summary>
        /// Deletes a client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLunaClient service method.</param>
        /// 
        /// <returns>The response from the DeleteLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DeleteLunaClientResponse DeleteLunaClient(DeleteLunaClientRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLunaClient
        ///         operation.</returns>
        IAsyncResult BeginDeleteLunaClient(DeleteLunaClientRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLunaClient.</param>
        /// 
        /// <returns>Returns a  DeleteLunaClientResult from CloudHSM.</returns>
        DeleteLunaClientResponse EndDeleteLunaClient(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHapg


        /// <summary>
        /// Retrieves information about a high-availability partition group.
        /// </summary>
        /// <param name="hapgArn">The ARN of the high-availability partition group to describe.</param>
        /// 
        /// <returns>The response from the DescribeHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DescribeHapgResponse DescribeHapg(string hapgArn);

        /// <summary>
        /// Retrieves information about a high-availability partition group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHapg service method.</param>
        /// 
        /// <returns>The response from the DescribeHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DescribeHapgResponse DescribeHapg(DescribeHapgRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHapg
        ///         operation.</returns>
        IAsyncResult BeginDescribeHapg(DescribeHapgRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHapg.</param>
        /// 
        /// <returns>Returns a  DescribeHapgResult from CloudHSM.</returns>
        DescribeHapgResponse EndDescribeHapg(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHsm


        /// <summary>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM. Either the <i>HsmArn</i> or the <i>SerialNumber</i> parameter must be specified.</param>
        /// 
        /// <returns>The response from the DescribeHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DescribeHsmResponse DescribeHsm(string hsmArn);

        /// <summary>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsm service method.</param>
        /// 
        /// <returns>The response from the DescribeHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DescribeHsmResponse DescribeHsm(DescribeHsmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHsm
        ///         operation.</returns>
        IAsyncResult BeginDescribeHsm(DescribeHsmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsm.</param>
        /// 
        /// <returns>Returns a  DescribeHsmResult from CloudHSM.</returns>
        DescribeHsmResponse EndDescribeHsm(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLunaClient


        /// <summary>
        /// Retrieves information about an HSM client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLunaClient service method.</param>
        /// 
        /// <returns>The response from the DescribeLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        DescribeLunaClientResponse DescribeLunaClient(DescribeLunaClientRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLunaClient
        ///         operation.</returns>
        IAsyncResult BeginDescribeLunaClient(DescribeLunaClientRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLunaClient.</param>
        /// 
        /// <returns>Returns a  DescribeLunaClientResult from CloudHSM.</returns>
        DescribeLunaClientResponse EndDescribeLunaClient(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfig


        /// <summary>
        /// Gets the configuration files necessary to connect to all high availability partition
        /// groups the client is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfig service method.</param>
        /// 
        /// <returns>The response from the GetConfig service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        GetConfigResponse GetConfig(GetConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfig operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfig
        ///         operation.</returns>
        IAsyncResult BeginGetConfig(GetConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfig.</param>
        /// 
        /// <returns>Returns a  GetConfigResult from CloudHSM.</returns>
        GetConfigResponse EndGetConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAvailableZones


        /// <summary>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableZones service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        ListAvailableZonesResponse ListAvailableZones();

        /// <summary>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableZones service method.</param>
        /// 
        /// <returns>The response from the ListAvailableZones service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        ListAvailableZonesResponse ListAvailableZones(ListAvailableZonesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableZones operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableZones
        ///         operation.</returns>
        IAsyncResult BeginListAvailableZones(ListAvailableZonesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableZones.</param>
        /// 
        /// <returns>Returns a  ListAvailableZonesResult from CloudHSM.</returns>
        ListAvailableZonesResponse EndListAvailableZones(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHapgs


        /// <summary>
        /// Lists the high-availability partition groups for the account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListHapgs</a> to retrieve the next set
        /// of items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHapgs service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        ListHapgsResponse ListHapgs();

        /// <summary>
        /// Lists the high-availability partition groups for the account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListHapgs</a> to retrieve the next set
        /// of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHapgs service method.</param>
        /// 
        /// <returns>The response from the ListHapgs service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        ListHapgsResponse ListHapgs(ListHapgsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHapgs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHapgs operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHapgs
        ///         operation.</returns>
        IAsyncResult BeginListHapgs(ListHapgsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHapgs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHapgs.</param>
        /// 
        /// <returns>Returns a  ListHapgsResult from CloudHSM.</returns>
        ListHapgsResponse EndListHapgs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHsms


        /// <summary>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListHsms</a> to retrieve the next set of
        /// items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHsms service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        ListHsmsResponse ListHsms();

        /// <summary>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListHsms</a> to retrieve the next set of
        /// items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHsms service method.</param>
        /// 
        /// <returns>The response from the ListHsms service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        ListHsmsResponse ListHsms(ListHsmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHsms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHsms operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHsms
        ///         operation.</returns>
        IAsyncResult BeginListHsms(ListHsmsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHsms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHsms.</param>
        /// 
        /// <returns>Returns a  ListHsmsResult from CloudHSM.</returns>
        ListHsmsResponse EndListHsms(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLunaClients


        /// <summary>
        /// Lists all of the clients.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListLunaClients</a> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListLunaClients service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        ListLunaClientsResponse ListLunaClients();

        /// <summary>
        /// Lists all of the clients.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListLunaClients</a> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLunaClients service method.</param>
        /// 
        /// <returns>The response from the ListLunaClients service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        ListLunaClientsResponse ListLunaClients(ListLunaClientsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLunaClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLunaClients operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLunaClients
        ///         operation.</returns>
        IAsyncResult BeginListLunaClients(ListLunaClientsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLunaClients operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLunaClients.</param>
        /// 
        /// <returns>Returns a  ListLunaClientsResult from CloudHSM.</returns>
        ListLunaClientsResponse EndListLunaClients(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyHapg


        /// <summary>
        /// Modifies an existing high-availability partition group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHapg service method.</param>
        /// 
        /// <returns>The response from the ModifyHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        ModifyHapgResponse ModifyHapg(ModifyHapgRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyHapg
        ///         operation.</returns>
        IAsyncResult BeginModifyHapg(ModifyHapgRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyHapg.</param>
        /// 
        /// <returns>Returns a  ModifyHapgResult from CloudHSM.</returns>
        ModifyHapgResponse EndModifyHapg(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyHsm


        /// <summary>
        /// Modifies an HSM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHsm service method.</param>
        /// 
        /// <returns>The response from the ModifyHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        ModifyHsmResponse ModifyHsm(ModifyHsmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyHsm
        ///         operation.</returns>
        IAsyncResult BeginModifyHsm(ModifyHsmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyHsm.</param>
        /// 
        /// <returns>Returns a  ModifyHsmResult from CloudHSM.</returns>
        ModifyHsmResponse EndModifyHsm(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyLunaClient


        /// <summary>
        /// Modifies the certificate used by the client.
        /// 
        ///  
        /// <para>
        /// This action can potentially start a workflow to install the new certificate on the
        /// client's HSMs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLunaClient service method.</param>
        /// 
        /// <returns>The response from the ModifyLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        ModifyLunaClientResponse ModifyLunaClient(ModifyLunaClientRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyLunaClient
        ///         operation.</returns>
        IAsyncResult BeginModifyLunaClient(ModifyLunaClientRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyLunaClient.</param>
        /// 
        /// <returns>Returns a  ModifyLunaClientResult from CloudHSM.</returns>
        ModifyLunaClientResponse EndModifyLunaClient(IAsyncResult asyncResult);

        #endregion
        
    }
}