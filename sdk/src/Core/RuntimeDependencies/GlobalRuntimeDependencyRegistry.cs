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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using AWSSDK.Runtime.Internal.Util;

namespace Amazon.RuntimeDependencies
{
    /// <summary>
    /// The GlobalRuntimeDependencyRegistry registry is used to register runtime dependency for the entire process using
    /// the AWS SDK for .NET.
    /// 
    /// There are some features of the AWS .NET SDK that at runtime load dependencies from assemblies. The most common
    /// example is using credential profiles that require the service client from the AWSSDK.SecurityToken package.
    /// Normally these runtime dependencies are resolved by using reflection to load the assembly and the type,
    /// In Native AOT with trimming turned on that will not worked because the dependency would be trimmed out.
    /// 
    /// The RuntimeDependencyRegistry is used to work around this limitation by allowing users to explicitly register
    /// the runtime dependency instance into the SDK removing any use of reflection.
    /// </summary>
    public class GlobalRuntimeDependencyRegistry : BaseRuntimeDependencyRegistry
    {
        private static readonly GlobalRuntimeDependencyRegistry _instance = new GlobalRuntimeDependencyRegistry();
        public static GlobalRuntimeDependencyRegistry Instance { get { return _instance; } }

        internal GlobalRuntimeDependencyRegistry()
        {
        }

        /// <summary>
        /// Register the Checksum provider. This should be an instance of AWSSDK.Extensions.CrtIntegration.CrtChecksums from AWSSDK.Extensions.CrtIntegration package.
        /// 
        /// The Checksum provider is used for features like S3 object integrity check when choosing certain algorithms that .NET does not support natively. For example CRC32 and CRC32C. 
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterChecksumProvider(object instance)
        {
            RegisterInstance(ChecksumCRTWrapper.CRT_WRAPPER_ASSEMBLY_NAME, ChecksumCRTWrapper.CRT_WRAPPER_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the AWS SigV4a provider. This should be an instance of Amazon.Extensions.CrtIntegration.CrtAWS4aSigner from AWSSDK.Extensions.CrtIntegration package.
        /// 
        /// The SigV4a provider is used for features like S3's multi-region access point and EventBridge global endpoints.
        /// 
        /// The context parameter for the factory has a Payload property that must be used when constructing the instance of CrtAWS4aSigner.
        /// <code>
        /// GlobalRuntimeDependencyRegistry.Instance.RegisterSigV4aProvider((context) =>
        /// {
        ///     return new Amazon.Extensions.CrtIntegration.CrtAWS4aSigner(context.SigV4aCrtSignerContextData.Payload);
        /// }
        /// </code>
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterSigV4aProvider(RuntimeDependencyFactory factory)
        {
            RegisterInstance(AWS4aSignerCRTWrapper.CRT_WRAPPER_ASSEMBLY_NAME, AWS4aSignerCRTWrapper.CRT_WRAPPER_CLASS_NAME, factory);
        }

        /// <summary>
        /// Register the Amazon.SecurityToken.AmazonSecurityTokenServiceClient instance from the AWSSDK.SecurityToken package.
        /// 
        /// The Security Token service client is used for credential providers that assume a role.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterSecurityTokenServiceClient(object instance)
        {
            RegisterInstance(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the Amazon.SecurityToken.AmazonSecurityTokenServiceClient instance from the AWSSDK.SecurityToken package.
        /// 
        /// The Security Token service client is used for credential providers that assume a role.
        /// 
        /// The region for Security Token service client is going to be used for can be found in the factory method's context.
        /// <code>
        /// GlobalRuntimeDependencyRegistry.Instance.RegisterSecurityTokenServiceClient((context) =>
        /// {
        ///     return new Amazon.SecurityToken.AmazonSecurityTokenServiceClient(context.SecurityTokenServiceClientContextData.Region);
        /// }
        /// </code>
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterSecurityTokenServiceClient(RuntimeDependencyFactory factory)
        {
            RegisterInstance(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, factory);
        }

        /// <summary>
        /// Register the Amazon.SSO.AmazonSSOClient instance from the AWSSDK.SSO package.
        /// 
        /// The SSO service client is used for credentials providers configured for single sign on.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterSSOClient(object instance)
        {
            RegisterInstance(ServiceClientHelpers.SSO_ASSEMBLY_NAME, ServiceClientHelpers.SSO_SERVICE_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the Amazon.SecurityToken.AmazonSecurityTokenServiceClient instance from the AWSSDK.SecurityToken package.
        /// 
        /// The SSO service client is used for credentials providers configured for single sign on.
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterSSOClient(RuntimeDependencyFactory factory)
        {
            RegisterInstance(ServiceClientHelpers.SSO_ASSEMBLY_NAME, ServiceClientHelpers.SSO_SERVICE_CLASS_NAME, factory);
        }

        /// <summary>
        /// Register the Amazon.SSOOIDC.AmazonSSOOIDCClient instance from the AWSSDK.SSOOIDC package.
        /// 
        /// The SSO OIDC service client is used for credentials providers configured for single sign on.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterSSOOIDCClient(object instance)
        {
            RegisterInstance(ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME, ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the Amazon.SSOOIDC.AmazonSSOOIDCClient instance from the AWSSDK.SSOOIDC package.
        /// 
        /// The SSO OIDC service client is used for credentials providers configured for single sign on.
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterSSOOIDCClient(RuntimeDependencyFactory factory)
        {
            RegisterInstance(ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME, ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME, factory);
        }

        /// <summary>
        /// Register the Amazon.S3.AmazonS3Client instance from the AWSSDK.S3 package.
        /// 
        /// The S3 client is used by the DynamoDB high level feature called S3 link.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterS3Client(object instance)
        {
            RegisterInstance(ServiceClientHelpers.S3_ASSEMBLY_NAME, ServiceClientHelpers.S3_SERVICE_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the Amazon.S3.AmazonS3Client instance from the AWSSDK.S3 package.
        /// 
        /// The S3 client is used by the DynamoDB high level feature called S3 link.
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterS3Client(RuntimeDependencyFactory factory)
        {
            RegisterInstance(ServiceClientHelpers.S3_ASSEMBLY_NAME, ServiceClientHelpers.S3_SERVICE_CLASS_NAME, factory);
        }
    }
}
