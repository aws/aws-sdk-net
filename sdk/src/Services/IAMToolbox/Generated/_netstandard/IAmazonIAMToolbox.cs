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
 * Do not modify this file. This file is generated from the iam-toolbox-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IAMToolbox.Model;

#pragma warning disable CS1570
namespace Amazon.IAMToolbox
{
    /// <summary>
    /// <para>Interface for accessing IAMToolbox</para>
    ///
    /// Contains APIs to work with AWS Identity and Access Management (IAM).
    /// </summary>
    public partial interface IAmazonIAMToolbox : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIAMToolboxPaginatorFactory Paginators { get; }
#endif
                
        #region  GetRequestAuthorizationDetails



        /// <summary>
        /// Retrieves the authorization details for a specific access denied request. The details
        /// include the request context, the evaluations performed, and the policies that were
        /// evaluated.
        /// 
        ///  
        /// <para>
        /// Use this operation to understand why a request was denied. Supported services include
        /// an authorization ID in the access denied error message. Pass that ID to this operation
        /// to retrieve the details.
        /// </para>
        ///  
        /// <para>
        /// Authorization details are available for at least 24 hours after the denial.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have the <c>iam:GetRequestAuthorizationDetails</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestAuthorizationDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRequestAuthorizationDetails service method, as returned by IAMToolbox.</returns>
        /// <exception cref="Amazon.IAMToolbox.Model.AccessDeniedException">
        /// The caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMToolbox.Model.InternalServerException">
        /// An unexpected error occurred while processing the request. Try again.
        /// </exception>
        /// <exception cref="Amazon.IAMToolbox.Model.ResourceNotFoundException">
        /// The requested authorization details do not exist in this region or have expired. Verify
        /// that the authorization ID from the access denied error message is correct and the
        /// call is made in the region where the denial occurred. Ensure that the calling principal
        /// belongs to the same account or organization as the original denied request.
        /// </exception>
        /// <exception cref="Amazon.IAMToolbox.Model.ValidationException">
        /// The request is malformed or is missing one or more required parameters. Check the
        /// request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-toolbox-2018-05-10/GetRequestAuthorizationDetails">REST API Reference for GetRequestAuthorizationDetails Operation</seealso>
        Task<GetRequestAuthorizationDetailsResponse> GetRequestAuthorizationDetailsAsync(GetRequestAuthorizationDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonIAMToolboxConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonIAMToolboxConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonIAMToolboxConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonIAMToolboxConfig to create AmazonIAMToolboxClient");
            }

            return awsCredentials == null ? 
                    new AmazonIAMToolboxClient(serviceClientConfig) :
                    new AmazonIAMToolboxClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}