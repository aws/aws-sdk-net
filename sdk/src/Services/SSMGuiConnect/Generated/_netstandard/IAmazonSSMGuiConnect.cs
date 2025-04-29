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
 * Do not modify this file. This file is generated from the ssm-guiconnect-2021-05-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSMGuiConnect.Model;

#pragma warning disable CS1570
namespace Amazon.SSMGuiConnect
{
    /// <summary>
    /// <para>Interface for accessing SSMGuiConnect</para>
    ///
    /// AWS Systems Manager GUI Connect 
    /// <para>
    /// Systems Manager GUI Connect, a component of Fleet Manager, lets you connect to your
    /// Window Server-type Amazon Elastic Compute Cloud (Amazon EC2) instances using the Remote
    /// Desktop Protocol (RDP). GUI Connect, which is powered by <a href="https://docs.aws.amazon.com/dcv/latest/adminguide/what-is-dcv.html">Amazon
    /// DCV</a>, provides you with secure connectivity to your Windows Server instances directly
    /// from the Systems Manager console. You can have up to four simultaneous connections
    /// in a single browser window. In the console, GUI Connect is also referred to as Fleet
    /// Manager Remote Desktop.
    /// 
    ///  
    /// <para>
    /// This reference is intended to be used with the <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/">
    /// <i>Amazon Web Services Systems Manager User Guide</i> </a>. To get started, see the
    /// following user guide topics:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-setting-up.html">Setting
    /// up Amazon Web Services Systems Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/fleet-rdp.html">Connect
    /// to a Windows Server managed instance using Remote Desktop</a> 
    /// </para>
    ///  </li> </ul>
    /// </para>
    /// </summary>
    public partial interface IAmazonSSMGuiConnect : IAmazonService, IDisposable
    {
                
        #region  DeleteConnectionRecordingPreferences



        /// <summary>
        /// Deletes the preferences for recording RDP connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectionRecordingPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnectionRecordingPreferences service method, as returned by SSMGuiConnect.</returns>
        /// <exception cref="Amazon.SSMGuiConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-guiconnect-2021-05-01/DeleteConnectionRecordingPreferences">REST API Reference for DeleteConnectionRecordingPreferences Operation</seealso>
        Task<DeleteConnectionRecordingPreferencesResponse> DeleteConnectionRecordingPreferencesAsync(DeleteConnectionRecordingPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConnectionRecordingPreferences



        /// <summary>
        /// Returns the preferences specified for recording RDP connections in the requesting
        /// Amazon Web Services account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionRecordingPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectionRecordingPreferences service method, as returned by SSMGuiConnect.</returns>
        /// <exception cref="Amazon.SSMGuiConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-guiconnect-2021-05-01/GetConnectionRecordingPreferences">REST API Reference for GetConnectionRecordingPreferences Operation</seealso>
        Task<GetConnectionRecordingPreferencesResponse> GetConnectionRecordingPreferencesAsync(GetConnectionRecordingPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConnectionRecordingPreferences



        /// <summary>
        /// Updates the preferences for recording RDP connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionRecordingPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnectionRecordingPreferences service method, as returned by SSMGuiConnect.</returns>
        /// <exception cref="Amazon.SSMGuiConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-guiconnect-2021-05-01/UpdateConnectionRecordingPreferences">REST API Reference for UpdateConnectionRecordingPreferences Operation</seealso>
        Task<UpdateConnectionRecordingPreferencesResponse> UpdateConnectionRecordingPreferencesAsync(UpdateConnectionRecordingPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSSMGuiConnectConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSSMGuiConnectConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSSMGuiConnectConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSSMGuiConnectConfig to create AmazonSSMGuiConnectClient");
            }

            return awsCredentials == null ? 
                    new AmazonSSMGuiConnectClient(serviceClientConfig) :
                    new AmazonSSMGuiConnectClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}