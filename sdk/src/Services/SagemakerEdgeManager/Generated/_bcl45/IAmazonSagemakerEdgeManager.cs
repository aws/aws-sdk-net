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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SagemakerEdgeManager.Model;

#pragma warning disable CS1570
namespace Amazon.SagemakerEdgeManager
{
    /// <summary>
    /// <para>Interface for accessing SagemakerEdgeManager</para>
    ///
    /// SageMaker Edge Manager dataplane service for communicating with active agents.
    /// </summary>
    public partial interface IAmazonSagemakerEdgeManager : IAmazonService, IDisposable
    {


        
        #region  GetDeployments


        /// <summary>
        /// Use to get the active deployments from a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// 
        /// <returns>The response from the GetDeployments service method, as returned by SagemakerEdgeManager.</returns>
        /// <exception cref="Amazon.SagemakerEdgeManager.Model.InternalServiceException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request);



        /// <summary>
        /// Use to get the active deployments from a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployments service method, as returned by SagemakerEdgeManager.</returns>
        /// <exception cref="Amazon.SagemakerEdgeManager.Model.InternalServiceException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        Task<GetDeploymentsResponse> GetDeploymentsAsync(GetDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeviceRegistration


        /// <summary>
        /// Use to check if a device is registered with SageMaker Edge Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceRegistration service method.</param>
        /// 
        /// <returns>The response from the GetDeviceRegistration service method, as returned by SagemakerEdgeManager.</returns>
        /// <exception cref="Amazon.SagemakerEdgeManager.Model.InternalServiceException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/GetDeviceRegistration">REST API Reference for GetDeviceRegistration Operation</seealso>
        GetDeviceRegistrationResponse GetDeviceRegistration(GetDeviceRegistrationRequest request);



        /// <summary>
        /// Use to check if a device is registered with SageMaker Edge Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeviceRegistration service method, as returned by SagemakerEdgeManager.</returns>
        /// <exception cref="Amazon.SagemakerEdgeManager.Model.InternalServiceException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/GetDeviceRegistration">REST API Reference for GetDeviceRegistration Operation</seealso>
        Task<GetDeviceRegistrationResponse> GetDeviceRegistrationAsync(GetDeviceRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Web Services customer support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/SendHeartbeat">REST API Reference for SendHeartbeat Operation</seealso>
        SendHeartbeatResponse SendHeartbeat(SendHeartbeatRequest request);



        /// <summary>
        /// Use to get the current status of devices registered on SageMaker Edge Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendHeartbeat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendHeartbeat service method, as returned by SagemakerEdgeManager.</returns>
        /// <exception cref="Amazon.SagemakerEdgeManager.Model.InternalServiceException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/SendHeartbeat">REST API Reference for SendHeartbeat Operation</seealso>
        Task<SendHeartbeatResponse> SendHeartbeatAsync(SendHeartbeatRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}