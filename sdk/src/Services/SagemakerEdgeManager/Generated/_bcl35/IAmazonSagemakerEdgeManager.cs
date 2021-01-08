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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SagemakerEdgeManager.Model;

namespace Amazon.SagemakerEdgeManager
{
    /// <summary>
    /// Interface for accessing SagemakerEdgeManager
    ///
    /// SageMaker Edge Manager dataplane service for communicating with active agents.
    /// </summary>
    public partial interface IAmazonSagemakerEdgeManager : IAmazonService, IDisposable
    {




        
        #region  GetDeviceRegistration


        /// <summary>
        /// Use to check if a device is registered with SageMaker Edge Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceRegistration service method.</param>
        /// 
        /// <returns>The response from the GetDeviceRegistration service method, as returned by SagemakerEdgeManager.</returns>
        /// <exception cref="Amazon.SagemakerEdgeManager.Model.InternalServiceException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// AWS customer support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/GetDeviceRegistration">REST API Reference for GetDeviceRegistration Operation</seealso>
        GetDeviceRegistrationResponse GetDeviceRegistration(GetDeviceRegistrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceRegistration operation on AmazonSagemakerEdgeManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/GetDeviceRegistration">REST API Reference for GetDeviceRegistration Operation</seealso>
        IAsyncResult BeginGetDeviceRegistration(GetDeviceRegistrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceRegistration.</param>
        /// 
        /// <returns>Returns a  GetDeviceRegistrationResult from SagemakerEdgeManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/GetDeviceRegistration">REST API Reference for GetDeviceRegistration Operation</seealso>
        GetDeviceRegistrationResponse EndGetDeviceRegistration(IAsyncResult asyncResult);

        #endregion
        
        #region  SendHeartbeat


        /// <summary>
        /// Use to get the current status of devices registered on SageMaker Edge Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendHeartbeat service method.</param>
        /// 
        /// <returns>The response from the SendHeartbeat service method, as returned by SagemakerEdgeManager.</returns>
        /// <exception cref="Amazon.SagemakerEdgeManager.Model.InternalServiceException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// AWS customer support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/SendHeartbeat">REST API Reference for SendHeartbeat Operation</seealso>
        SendHeartbeatResponse SendHeartbeat(SendHeartbeatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendHeartbeat operation on AmazonSagemakerEdgeManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendHeartbeat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/SendHeartbeat">REST API Reference for SendHeartbeat Operation</seealso>
        IAsyncResult BeginSendHeartbeat(SendHeartbeatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendHeartbeat.</param>
        /// 
        /// <returns>Returns a  SendHeartbeatResult from SagemakerEdgeManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/SendHeartbeat">REST API Reference for SendHeartbeat Operation</seealso>
        SendHeartbeatResponse EndSendHeartbeat(IAsyncResult asyncResult);

        #endregion
        
    }
}