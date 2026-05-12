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
 * Do not modify this file. This file is generated from the restxmldataplane-1999-12-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RestXmlDataPlane.Model;

#pragma warning disable CS1570
namespace Amazon.RestXmlDataPlane
{
    /// <summary>
    /// <para>Interface for accessing RestXmlDataPlane</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRestXmlDataPlane : IAmazonService, IDisposable
    {
                
        #region  CopyObject



        /// <summary>
        /// <pre><c>From Amazon S3. CopyObject serializes a large set of headers. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/CopyObject">REST API Reference for CopyObject Operation</seealso>
        Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMetricData



        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        Task<GetMetricDataResponse> GetMetricDataAsync(GetMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetObject



        /// <summary>
        /// As seen in Amazon S3. Object I/O is HTTP payload I/O, and is more of a function of
        /// network and checksum performance than serde. It is here because it's an important
        /// operation, for completeness.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/GetObject">REST API Reference for GetObject Operation</seealso>
        Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Healthcheck



        /// <summary>
        /// <pre><c>A response that only says &quot;OK&quot;, if it can. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Healthcheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Healthcheck service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/Healthcheck">REST API Reference for Healthcheck Operation</seealso>
        Task<HealthcheckResponse> HealthcheckAsync(HealthcheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutMetricData



        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutObject



        /// <summary>
        /// As seen in Amazon S3. Object I/O is HTTP payload I/O, and is more of a function of
        /// network and checksum performance than serde. It is here because it's an important
        /// operation, for completeness.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/PutObject">REST API Reference for PutObject Operation</seealso>
        Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRestXmlDataPlaneConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRestXmlDataPlaneConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRestXmlDataPlaneConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRestXmlDataPlaneConfig to create AmazonRestXmlDataPlaneClient");
            }

            return awsCredentials == null ? 
                    new AmazonRestXmlDataPlaneClient(serviceClientConfig) :
                    new AmazonRestXmlDataPlaneClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}