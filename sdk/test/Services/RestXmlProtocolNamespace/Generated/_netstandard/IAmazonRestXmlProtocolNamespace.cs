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
 * Do not modify this file. This file is generated from the rest-xml-protocol-namespace-2019-12-16.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RestXmlProtocolNamespace.Model;

#pragma warning disable CS1570
namespace Amazon.RestXmlProtocolNamespace
{
    /// <summary>
    /// <para>Interface for accessing RestXmlProtocolNamespace</para>
    ///
    /// A REST XML service that sends XML requests and responses.
    /// 
    ///  
    /// <para>
    /// This service and test case is complementary to the test cases in the <c>restXml</c>
    /// directory, but the service under test here has the <c>xmlNamespace</c> trait applied
    /// to it.
    /// </para>
    ///  
    /// <para>
    /// See https://github.com/smithy-lang/smithy/issues/616
    /// </para>
    /// </summary>
    public partial interface IAmazonRestXmlProtocolNamespace : IAmazonService, IDisposable
    {
                
        #region  SimpleScalarProperties



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestXmlProtocolNamespace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-namespace-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        Task<SimpleScalarPropertiesResponse> SimpleScalarPropertiesAsync(SimpleScalarPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRestXmlProtocolNamespaceConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRestXmlProtocolNamespaceConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRestXmlProtocolNamespaceConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRestXmlProtocolNamespaceConfig to create AmazonRestXmlProtocolNamespaceClient");
            }

            return awsCredentials == null ? 
                    new AmazonRestXmlProtocolNamespaceClient(serviceClientConfig) :
                    new AmazonRestXmlProtocolNamespaceClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}