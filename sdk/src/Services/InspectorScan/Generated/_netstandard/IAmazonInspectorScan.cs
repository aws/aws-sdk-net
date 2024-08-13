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
 * Do not modify this file. This file is generated from the inspector-scan-2023-08-08.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.InspectorScan.Model;

#pragma warning disable CS1570
namespace Amazon.InspectorScan
{
    /// <summary>
    /// <para>Interface for accessing InspectorScan</para>
    ///
    /// Amazon Inspector Scan is a vulnerability discovery service that scans a provided Software
    /// Bill of Materials (SBOM) for security vulnerabilities.
    /// </summary>
    public partial interface IAmazonInspectorScan : IAmazonService, IDisposable
    {
                
        #region  ScanSbom



        /// <summary>
        /// Scans a provided CycloneDX 1.5 SBOM and reports on any vulnerabilities discovered
        /// in that SBOM. You can generate compatible SBOMs for your resources using the <a href="">Amazon
        /// Inspector SBOM generator</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScanSbom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScanSbom service method, as returned by InspectorScan.</returns>
        /// <exception cref="Amazon.InspectorScan.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InspectorScan.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.InspectorScan.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InspectorScan.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-scan-2023-08-08/ScanSbom">REST API Reference for ScanSbom Operation</seealso>
        Task<ScanSbomResponse> ScanSbomAsync(ScanSbomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonInspectorScanConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonInspectorScanConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonInspectorScanConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonInspectorScanConfig to create AmazonInspectorScanClient");
            }

            return awsCredentials == null ? 
                    new AmazonInspectorScanClient(serviceClientConfig) :
                    new AmazonInspectorScanClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}