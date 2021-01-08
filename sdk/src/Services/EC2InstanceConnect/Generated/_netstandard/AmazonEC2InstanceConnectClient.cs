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
 * Do not modify this file. This file is generated from the ec2-instance-connect-2018-04-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EC2InstanceConnect.Model;
using Amazon.EC2InstanceConnect.Model.Internal.MarshallTransformations;
using Amazon.EC2InstanceConnect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2InstanceConnect
{
    /// <summary>
    /// Implementation for accessing EC2InstanceConnect
    ///
    /// AWS EC2 Connect Service is a service that enables system administrators to publish
    /// temporary SSH keys to their EC2 instances in order to establish connections to their
    /// instances without leaving a permanent authentication option.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonEC2InstanceConnectClient : AmazonServiceClient, IAmazonEC2InstanceConnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonEC2InstanceConnectMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with the credentials loaded from the application's
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
        public AmazonEC2InstanceConnectClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2InstanceConnectConfig()) { }

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with the credentials loaded from the application's
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
        public AmazonEC2InstanceConnectClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2InstanceConnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEC2InstanceConnectClient Configuration Object</param>
        public AmazonEC2InstanceConnectClient(AmazonEC2InstanceConnectConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEC2InstanceConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonEC2InstanceConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2InstanceConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEC2InstanceConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with AWS Credentials and an
        /// AmazonEC2InstanceConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEC2InstanceConnectClient Configuration Object</param>
        public AmazonEC2InstanceConnectClient(AWSCredentials credentials, AmazonEC2InstanceConnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEC2InstanceConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEC2InstanceConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2InstanceConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEC2InstanceConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2InstanceConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEC2InstanceConnectClient Configuration Object</param>
        public AmazonEC2InstanceConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEC2InstanceConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEC2InstanceConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEC2InstanceConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2InstanceConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEC2InstanceConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2InstanceConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2InstanceConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEC2InstanceConnectClient Configuration Object</param>
        public AmazonEC2InstanceConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEC2InstanceConnectConfig clientConfig)
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


        #region  SendSSHPublicKey

        internal virtual SendSSHPublicKeyResponse SendSSHPublicKey(SendSSHPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<SendSSHPublicKeyResponse>(request, options);
        }



        /// <summary>
        /// Pushes an SSH public key to a particular OS user on a given EC2 instance for 60 seconds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendSSHPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendSSHPublicKey service method, as returned by EC2InstanceConnect.</returns>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.AuthException">
        /// Indicates that either your AWS credentials are invalid or you do not have access to
        /// the EC2 instance.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.EC2InstanceNotFoundException">
        /// Indicates that the instance requested was not found in the given zone. Check that
        /// you have provided a valid instance ID and the correct zone.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.InvalidArgsException">
        /// Indicates that you provided bad input. Ensure you have a valid instance ID, the correct
        /// zone, and a valid SSH public key.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.ServiceException">
        /// Indicates that the service encountered an error. Follow the message's instructions
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.ThrottlingException">
        /// Indicates you have been making requests too frequently and have been throttled. Wait
        /// for a while and try again. If higher call volume is warranted contact AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-instance-connect-2018-04-02/SendSSHPublicKey">REST API Reference for SendSSHPublicKey Operation</seealso>
        public virtual Task<SendSSHPublicKeyResponse> SendSSHPublicKeyAsync(SendSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendSSHPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<SendSSHPublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}