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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QLDBSession.Model;
using Amazon.QLDBSession.Model.Internal.MarshallTransformations;
using Amazon.QLDBSession.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.QLDBSession
{
    /// <summary>
    /// Implementation for accessing QLDBSession
    ///
    /// The transactional data APIs for Amazon QLDB
    /// 
    ///  <note> 
    /// <para>
    /// Instead of interacting directly with this API, we recommend using the QLDB driver
    /// or the QLDB shell to execute data transactions on a ledger.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you are working with an AWS SDK, use the QLDB driver. The driver provides a high-level
    /// abstraction layer above this <i>QLDB Session</i> data plane and manages <code>SendCommand</code>
    /// API calls for you. For information and a list of supported programming languages,
    /// see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/getting-started-driver.html">Getting
    /// started with the driver</a> in the <i>Amazon QLDB Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are working with the AWS Command Line Interface (AWS CLI), use the QLDB shell.
    /// The shell is a command line interface that uses the QLDB driver to interact with a
    /// ledger. For information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/data-shell.html">Accessing
    /// Amazon QLDB using the QLDB shell</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AmazonQLDBSessionClient : AmazonServiceClient, IAmazonQLDBSession
    {
        private static IServiceMetadata serviceMetadata = new AmazonQLDBSessionMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with the credentials loaded from the application's
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
        public AmazonQLDBSessionClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQLDBSessionConfig()) { }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with the credentials loaded from the application's
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
        public AmazonQLDBSessionClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQLDBSessionConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQLDBSessionClient Configuration Object</param>
        public AmazonQLDBSessionClient(AmazonQLDBSessionConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQLDBSessionClient(AWSCredentials credentials)
            : this(credentials, new AmazonQLDBSessionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQLDBSessionClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQLDBSessionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Credentials and an
        /// AmazonQLDBSessionClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQLDBSessionClient Configuration Object</param>
        public AmazonQLDBSessionClient(AWSCredentials credentials, AmazonQLDBSessionConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQLDBSessionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQLDBSessionConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQLDBSessionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQLDBSessionClient Configuration Object</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQLDBSessionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQLDBSessionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQLDBSessionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQLDBSessionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQLDBSessionClient Configuration Object</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQLDBSessionConfig clientConfig)
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


        #region  SendCommand


        /// <summary>
        /// Sends a command to an Amazon QLDB ledger.
        /// 
        ///  <note> 
        /// <para>
        /// Instead of interacting directly with this API, we recommend using the QLDB driver
        /// or the QLDB shell to execute data transactions on a ledger.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are working with an AWS SDK, use the QLDB driver. The driver provides a high-level
        /// abstraction layer above this <i>QLDB Session</i> data plane and manages <code>SendCommand</code>
        /// API calls for you. For information and a list of supported programming languages,
        /// see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/getting-started-driver.html">Getting
        /// started with the driver</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are working with the AWS Command Line Interface (AWS CLI), use the QLDB shell.
        /// The shell is a command line interface that uses the QLDB driver to interact with a
        /// ledger. For information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/data-shell.html">Accessing
        /// Amazon QLDB using the QLDB shell</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by QLDBSession.</returns>
        /// <exception cref="Amazon.QLDBSession.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.InvalidSessionException">
        /// Returned if the session doesn't exist anymore because it timed out or expired.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.LimitExceededException">
        /// Returned if a resource limit such as number of active sessions is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.OccConflictException">
        /// Returned when a transaction cannot be written to the journal due to a failure in the
        /// verification phase of <i>optimistic concurrency control</i> (OCC).
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.RateExceededException">
        /// Returned when the rate of requests exceeds the allowed throughput.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-session-2019-07-11/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual SendCommandResponse SendCommand(SendCommandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCommandResponseUnmarshaller.Instance;

            return Invoke<SendCommandResponse>(request, options);
        }


        /// <summary>
        /// Sends a command to an Amazon QLDB ledger.
        /// 
        ///  <note> 
        /// <para>
        /// Instead of interacting directly with this API, we recommend using the QLDB driver
        /// or the QLDB shell to execute data transactions on a ledger.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are working with an AWS SDK, use the QLDB driver. The driver provides a high-level
        /// abstraction layer above this <i>QLDB Session</i> data plane and manages <code>SendCommand</code>
        /// API calls for you. For information and a list of supported programming languages,
        /// see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/getting-started-driver.html">Getting
        /// started with the driver</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are working with the AWS Command Line Interface (AWS CLI), use the QLDB shell.
        /// The shell is a command line interface that uses the QLDB driver to interact with a
        /// ledger. For information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/data-shell.html">Accessing
        /// Amazon QLDB using the QLDB shell</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by QLDBSession.</returns>
        /// <exception cref="Amazon.QLDBSession.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.InvalidSessionException">
        /// Returned if the session doesn't exist anymore because it timed out or expired.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.LimitExceededException">
        /// Returned if a resource limit such as number of active sessions is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.OccConflictException">
        /// Returned when a transaction cannot be written to the journal due to a failure in the
        /// verification phase of <i>optimistic concurrency control</i> (OCC).
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.RateExceededException">
        /// Returned when the rate of requests exceeds the allowed throughput.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-session-2019-07-11/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual Task<SendCommandResponse> SendCommandAsync(SendCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCommandResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendCommandResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}