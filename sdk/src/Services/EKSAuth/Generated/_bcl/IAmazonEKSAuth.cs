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
 * Do not modify this file. This file is generated from the eks-auth-2023-11-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EKSAuth.Model;

#pragma warning disable CS1570
namespace Amazon.EKSAuth
{
    /// <summary>
    /// <para>Interface for accessing EKSAuth</para>
    ///
    /// The Amazon EKS Auth API and the <c>AssumeRoleForPodIdentity</c> action are only used
    /// by the EKS Pod Identity Agent.
    /// </summary>
    public partial interface IAmazonEKSAuth : IAmazonService, IDisposable
    {


        
        #region  AssumeRoleForPodIdentity


        /// <summary>
        /// The Amazon EKS Auth API and the <c>AssumeRoleForPodIdentity</c> action are only used
        /// by the EKS Pod Identity Agent.
        /// 
        ///  
        /// <para>
        /// We recommend that applications use the Amazon Web Services SDKs to connect to Amazon
        /// Web Services services; if credentials from an EKS Pod Identity association are available
        /// in the pod, the latest versions of the SDKs use them automatically.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleForPodIdentity service method.</param>
        /// 
        /// <returns>The response from the AssumeRoleForPodIdentity service method, as returned by EKSAuth.</returns>
        /// <exception cref="Amazon.EKSAuth.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The IAM principal making
        /// the request must have at least one IAM permissions policy attached that grants the
        /// required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ExpiredTokenException">
        /// The specified Kubernetes service account token is expired.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InternalServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InvalidRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// will depend on the API, and will be documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InvalidTokenException">
        /// The specified Kubernetes service account token is invalid.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ThrottlingException">
        /// The request was denied because your request rate is too high. Reduce the frequency
        /// of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-auth-2023-11-26/AssumeRoleForPodIdentity">REST API Reference for AssumeRoleForPodIdentity Operation</seealso>
        AssumeRoleForPodIdentityResponse AssumeRoleForPodIdentity(AssumeRoleForPodIdentityRequest request);



        /// <summary>
        /// The Amazon EKS Auth API and the <c>AssumeRoleForPodIdentity</c> action are only used
        /// by the EKS Pod Identity Agent.
        /// 
        ///  
        /// <para>
        /// We recommend that applications use the Amazon Web Services SDKs to connect to Amazon
        /// Web Services services; if credentials from an EKS Pod Identity association are available
        /// in the pod, the latest versions of the SDKs use them automatically.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleForPodIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeRoleForPodIdentity service method, as returned by EKSAuth.</returns>
        /// <exception cref="Amazon.EKSAuth.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The IAM principal making
        /// the request must have at least one IAM permissions policy attached that grants the
        /// required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ExpiredTokenException">
        /// The specified Kubernetes service account token is expired.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InternalServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InvalidRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// will depend on the API, and will be documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InvalidTokenException">
        /// The specified Kubernetes service account token is invalid.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ThrottlingException">
        /// The request was denied because your request rate is too high. Reduce the frequency
        /// of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-auth-2023-11-26/AssumeRoleForPodIdentity">REST API Reference for AssumeRoleForPodIdentity Operation</seealso>
        Task<AssumeRoleForPodIdentityResponse> AssumeRoleForPodIdentityAsync(AssumeRoleForPodIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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