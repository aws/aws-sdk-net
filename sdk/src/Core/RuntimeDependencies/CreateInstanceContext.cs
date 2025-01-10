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
using Amazon.Runtime;
using System.Net;

namespace Amazon.RuntimeDependencies
{
    /// <summary>
    /// Context object passed into the RuntimeDependencyFactory delegate used by the runtime dependency registry to give the SDK user
    /// context for constructed the runtime dependency.
    /// </summary>
    public class CreateInstanceContext
    {
        /// <summary>
        /// The type of context.
        /// </summary>
        public enum ContextType
        {
            /// <summary>
            /// Context for creating AmazonSecurityTokenServiceClient
            /// </summary>
            SecurityTokenServiceClient,

            /// <summary>
            /// Context for creating AmazonSecurityTokenServiceClient
            /// </summary>
            KeyManagementServiceClient,

            /// <summary>
            /// Context for creating the SigV4aCrtSigner used by the SDK for signing AWS requests with SigV4a
            /// </summary>
            SigV4aCrtSigner,

            /// <summary>
            /// Context for creating the CheckSumProvider used for computing checksums with algorithms .NET SDK does not natively support. 
            /// </summary>
            CheckSumProvider,

            /// <summary>
            /// Context for creating AmazonSSOClient
            /// </summary>
            SSOClient,

            /// <summary>
            /// Context for creating AmazonSSOOIDCClient
            /// </summary>
            SSOOIDCClient,

            /// <summary>
            /// Context for creating AmazonS3Client
            /// </summary>
            S3ClientContext
        }

        /// <summary>
        /// Create an instance of CreateInstanceContext with the SecurityTokenServiceClientContext context
        /// </summary>
        /// <param name="context"></param>
        public CreateInstanceContext(SecurityTokenServiceClientContext context)
        {
            SecurityTokenServiceClientContextData = context;
            Type = ContextType.SecurityTokenServiceClient;
        }

        /// <summary>
        /// Create an instance of CreateInstanceContext with the KeyManagementServiceClientContext context
        /// </summary>
        /// <param name="context"></param>
        public CreateInstanceContext(KeyManagementServiceClientContext context)
        {
            KeyManagementServiceClientContextData = context;
            Type = ContextType.KeyManagementServiceClient;
        }

        /// <summary>
        /// Create an instance of CreateInstanceContext with the SigV4aCrtSignerContext context
        /// </summary>
        /// <param name="context"></param>
        public CreateInstanceContext(SigV4aCrtSignerContext context)
        {
            SigV4aCrtSignerContextData = context;
            Type = ContextType.SigV4aCrtSigner;
        }

        /// <summary>
        /// Create an instance of CreateInstanceContext with the CheckSumProviderContext context
        /// </summary>
        /// <param name="context"></param>
        public CreateInstanceContext(CheckSumProviderContext context)
        {
            CheckSumProviderContextData = context;
            Type = ContextType.CheckSumProvider;
        }

        /// <summary>
        /// Create an instance of CreateInstanceContext with the SSOClientContext context
        /// </summary>
        /// <param name="context"></param>
        public CreateInstanceContext(SSOClientContext context)
        {
            SSOClientContextData = context;
            Type = ContextType.SSOClient;
        }

        /// <summary>
        /// Create an instance of CreateInstanceContext with the SSOOIDCClientContext context
        /// </summary>
        /// <param name="context"></param>
        public CreateInstanceContext(SSOOIDCClientContext context)
        {
            SSOOIDCClientContextData = context;
            Type = ContextType.SSOOIDCClient;
        }

        /// <summary>
        /// Create an instance of CreateInstanceContext with the SSOOIDCClientContext context
        /// </summary>
        /// <param name="context"></param>
        public CreateInstanceContext(S3ClientContext context)
        {
            S3ClientContextData = context;
            Type = ContextType.S3ClientContext;
        }

        /// <summary>
        /// The type of context being sent into the factory method. For each type there is a corresponding Data property set containing any relevant information that can be
        /// used for creating the dependency instance.
        /// </summary>
        public ContextType Type { get; }

        /// <summary>
        /// Data for the SecurityTokenServiceClient context
        /// </summary>
        public SecurityTokenServiceClientContext SecurityTokenServiceClientContextData { get; }

        /// <summary>
        /// Data for the KeyManagementServiceClient context
        /// </summary>
        public KeyManagementServiceClientContext KeyManagementServiceClientContextData { get; }

        /// <summary>
        /// Data for the SigV4aCrtSigner context
        /// </summary>
        public SigV4aCrtSignerContext SigV4aCrtSignerContextData { get; }

        /// <summary>
        /// Data for the CheckSumProvider context
        /// </summary>
        public CheckSumProviderContext CheckSumProviderContextData { get; }

        /// <summary>
        /// Data for the SSOClient context
        /// </summary>
        public SSOClientContext SSOClientContextData { get; }

        /// <summary>
        /// Data for the SOOIDCClient context
        /// </summary>
        public SSOOIDCClientContext SSOOIDCClientContextData { get; }

        /// <summary>
        /// Data for the AmazonS3Client context
        /// </summary>
        public S3ClientContext S3ClientContextData {get;}
    }


    /// <summary>
    /// Context for the factory method to create the SecurityTokenServiceClient runtime dependency.
    /// </summary>
    public class SecurityTokenServiceClientContext
    {
        /// <summary>
        /// The possibly actions the SecurityTokenServiceClient will be created for.
        /// 
        /// For FederatedAWSCredentials the Amazon.Runtime.AnonymousAWSCredentials can be used as credentials for the STS client
        /// because the authentication will come from the SAML endpoint.
        /// </summary>
        public enum ActionContext { AssumeRoleAWSCredentials, AssumeRoleWithWebIdentityCredentials, FederatedAWSCredentials };


        /// <summary>
        /// The action the SecurityTokenServiceClient is being created for. For example AssumeRoleAWSCredentials.
        /// </summary>
        public ActionContext Action { get; set; }

        /// <summary>
        /// The region the SDK expects the SecurityTokenServiceClient to be configured for.
        /// </summary>
        public RegionEndpoint Region { get; set; }

        /// <summary>
        /// Proxy settings that can be applied to the service client config object.
        /// </summary>
        public IWebProxy ProxySettings { get; set; }
    }

    /// <summary>
    /// Context for the factory method to create the KeyManagementServiceClient runtime dependency.
    /// </summary>
    public class KeyManagementServiceClientContext
    {

        /// <summary>
        /// The service client that is creating the KeyManagementServiceClient. The factory method should use the 
        /// configuration like AWS region when constructing the KeyManagementServiceClient.
        /// </summary>
        public AmazonServiceClient ParentServiceClient { get; set; }
    }

    /// <summary>
    /// Context for the factory method to create the SigV4aCrtSigner runtime dependency.
    /// </summary>
    public class SigV4aCrtSignerContext
    {
        /// <summary>
        /// Create an instance of the context
        /// </summary>
        /// <param name="signPayload"></param>
        public SigV4aCrtSignerContext(bool signPayload)
        {
            SignPayload = signPayload;
        }

        /// <summary>
        /// A boolean to pass into the constructor for the Amazon.Extensions.CrtIntegration.CrtAWS4aSigner to control whether the request payload should be signed.
        /// </summary>
        public bool SignPayload { get; set; }
    }

    /// <summary>
    /// Context for the factory method to create the CheckSumProvider runtime dependency.
    /// </summary>
    public class CheckSumProviderContext
    {

    }

    /// <summary>
    /// Context for the factory method to create the SSOClient runtime dependency.
    /// </summary>
    public class SSOClientContext
    {

        /// <summary>
        /// The region the SDK expects the SSOClient to be configured for.
        /// </summary>
        public RegionEndpoint Region { get; set; }

        /// <summary>
        /// Proxy settings that can be applied to the service client config object.
        /// </summary>
        public IWebProxy ProxySettings { get; set; }
    }

    /// <summary>
    /// Context for the factory method to create the SSOOIDCClient runtime dependency.
    /// </summary>
    public class SSOOIDCClientContext
    {

        /// <summary>
        /// The region the SDK expects the SSOOIDCClient to be configured for.
        /// </summary>
        public RegionEndpoint Region { get; set; }

        /// <summary>
        /// Proxy settings that can be applied to the service client config object.
        /// </summary>
        public IWebProxy ProxySettings { get; set; }
    }

    /// <summary>
    /// Context for the factory method to create the AmazonS3Client runtime dependency.
    /// </summary>
    public class S3ClientContext
    {
        /// <summary>
        /// The possibly actions the AmazonS3Client will be created for.
        /// </summary>
        public enum ActionContext { DynamoBDS3Link };


        /// <summary>
        /// The action the AmazonS3Client is being created for. For example creating an S3 client for the DynamoDB S3 Link feature.
        /// </summary>
        public ActionContext Action { get; set; }

        /// <summary>
        /// The region the SDK expects the S3 client to be configured for.
        /// </summary>
        public RegionEndpoint Region { get; set; }
    }
}
