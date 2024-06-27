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

using System.Diagnostics.CodeAnalysis;

namespace Amazon.Runtime
{
    /// <summary>
    /// All Amazon service interfaces like IAmazonS3 extend from this interface. This allows all the 
    /// Amazon service interfaces be identified by this base interface and helps with generic constraints.
    /// </summary>
    public interface IAmazonService
    {
        /// <summary>
        /// A readonly view of the configuration for the service client.
        /// </summary>
        IClientConfig Config
        {
            get;
        }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Factory method for creating the service client config object used by the service client.
        /// This method is intended to be used by AWSSDK.Extensions.NETCore.Setup for creating
        /// AWS service clients registered in the dependency injection container.
        /// </summary>
        /// <returns></returns>
        static abstract ClientConfig CreateDefaultClientConfig();

        /// <summary>
        /// Factory method for creating the default implementation of the AWS service interface.
        /// This method is intended to be used by AWSSDK.Extensions.NETCore.Setup for creating
        /// AWS service clients registered in the dependency injection container.
        /// </summary>
        /// <param name="awsCredentials">The AWS credentials used for the service client.</param>
        /// <param name="clientConfig">
        /// The service client config for the service client. The base class ClientConfig  
        /// will be cast to the sub type expected by the service client.
        /// </param>
        /// <returns></returns>
        [UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. All other service clients have been confirmed to be trim safe. " +
            "If service clients become unsafe for trimming other compiler warnings will occur forcing the behavor to be addressed. " +
            "AppSync has been the the service users should be using for syncronization instead of CognitoSync for many years so unlikely " +
            "users will attempt to use CognitoSync with Native AOT.")]
        static abstract IAmazonService CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig);
#endif
    }
}