/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigatewaymanagementapi-2018-11-29.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ApiGatewayManagementApi.Model;
using Amazon.ApiGatewayManagementApi.Model.Internal.MarshallTransformations;
using Amazon.ApiGatewayManagementApi.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ApiGatewayManagementApi
{
    /// <summary>
    /// Implementation for accessing ApiGatewayManagementApi
    ///
    /// The Amazon API Gateway Management API allows you to directly manage runtime aspects
    /// of your deployed APIs. To use it, you must explicitly set the SDK's endpoint to point
    /// to the endpoint of your deployed API. The endpoint will be of the form https://{api-id}.execute-api.{region}.amazonaws.com/{stage},
    /// or will be the endpoint corresponding to your API's custom domain and base path, if
    /// applicable.
    /// </summary>
    public partial class AmazonApiGatewayManagementApiClient : AmazonServiceClient, IAmazonApiGatewayManagementApi
    {
        private static IServiceMetadata serviceMetadata = new AmazonApiGatewayManagementApiMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonApiGatewayManagementApiClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApiGatewayManagementApiConfig()) { }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayManagementApiClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApiGatewayManagementApiConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonApiGatewayManagementApiClient Configuration Object</param>
        public AmazonApiGatewayManagementApiClient(AmazonApiGatewayManagementApiConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApiGatewayManagementApiClient(AWSCredentials credentials)
            : this(credentials, new AmazonApiGatewayManagementApiConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayManagementApiClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApiGatewayManagementApiConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Credentials and an
        /// AmazonApiGatewayManagementApiClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApiGatewayManagementApiClient Configuration Object</param>
        public AmazonApiGatewayManagementApiClient(AWSCredentials credentials, AmazonApiGatewayManagementApiConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApiGatewayManagementApiConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApiGatewayManagementApiConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApiGatewayManagementApiClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApiGatewayManagementApiClient Configuration Object</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApiGatewayManagementApiConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApiGatewayManagementApiConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApiGatewayManagementApiConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApiGatewayManagementApiClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApiGatewayManagementApiClient Configuration Object</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApiGatewayManagementApiConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  PostToConnection

        internal virtual PostToConnectionResponse PostToConnection(PostToConnectionRequest request)
        {
            var marshaller = PostToConnectionRequestMarshaller.Instance;
            var unmarshaller = PostToConnectionResponseUnmarshaller.Instance;

            return Invoke<PostToConnectionRequest,PostToConnectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PostToConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostToConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PostToConnectionResponse> PostToConnectionAsync(PostToConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PostToConnectionRequestMarshaller.Instance;
            var unmarshaller = PostToConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<PostToConnectionRequest,PostToConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}