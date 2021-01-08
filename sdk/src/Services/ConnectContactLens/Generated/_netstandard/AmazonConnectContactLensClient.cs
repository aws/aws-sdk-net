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
 * Do not modify this file. This file is generated from the connect-contact-lens-2020-08-21.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ConnectContactLens.Model;
using Amazon.ConnectContactLens.Model.Internal.MarshallTransformations;
using Amazon.ConnectContactLens.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ConnectContactLens
{
    /// <summary>
    /// Implementation for accessing ConnectContactLens
    ///
    /// Contact Lens for Amazon Connect enables you to analyze conversations between customer
    /// and agents, by using speech transcription, natural language processing, and intelligent
    /// search capabilities. It performs sentiment analysis, detects issues, and enables you
    /// to automatically categorize contacts.
    /// 
    ///  
    /// <para>
    /// Contact Lens for Amazon Connect provides both real-time and post-call analytics of
    /// customer-agent conversations. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/analyze-conversations.html">Analyze
    /// conversations using Contact Lens</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// 
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonConnectContactLensClient : AmazonServiceClient, IAmazonConnectContactLens
    {
        private static IServiceMetadata serviceMetadata = new AmazonConnectContactLensMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with the credentials loaded from the application's
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
        public AmazonConnectContactLensClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectContactLensConfig()) { }

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with the credentials loaded from the application's
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
        public AmazonConnectContactLensClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectContactLensConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConnectContactLensClient Configuration Object</param>
        public AmazonConnectContactLensClient(AmazonConnectContactLensConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonConnectContactLensClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConnectContactLensClient(AWSCredentials credentials)
            : this(credentials, new AmazonConnectContactLensConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectContactLensClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConnectContactLensConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with AWS Credentials and an
        /// AmazonConnectContactLensClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConnectContactLensClient Configuration Object</param>
        public AmazonConnectContactLensClient(AWSCredentials credentials, AmazonConnectContactLensConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConnectContactLensClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectContactLensConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectContactLensClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectContactLensConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectContactLensClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConnectContactLensClient Configuration Object</param>
        public AmazonConnectContactLensClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConnectContactLensConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConnectContactLensClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectContactLensConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectContactLensClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectContactLensConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectContactLensClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectContactLensClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConnectContactLensClient Configuration Object</param>
        public AmazonConnectContactLensClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConnectContactLensConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IConnectContactLensPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IConnectContactLensPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ConnectContactLensPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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


        #region  ListRealtimeContactAnalysisSegments

        internal virtual ListRealtimeContactAnalysisSegmentsResponse ListRealtimeContactAnalysisSegments(ListRealtimeContactAnalysisSegmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRealtimeContactAnalysisSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRealtimeContactAnalysisSegmentsResponseUnmarshaller.Instance;

            return Invoke<ListRealtimeContactAnalysisSegmentsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of analysis segments for a real-time analysis session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRealtimeContactAnalysisSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRealtimeContactAnalysisSegments service method, as returned by ConnectContactLens.</returns>
        /// <exception cref="Amazon.ConnectContactLens.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectContactLens.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectContactLens.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConnectContactLens.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectContactLens.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-contact-lens-2020-08-21/ListRealtimeContactAnalysisSegments">REST API Reference for ListRealtimeContactAnalysisSegments Operation</seealso>
        public virtual Task<ListRealtimeContactAnalysisSegmentsResponse> ListRealtimeContactAnalysisSegmentsAsync(ListRealtimeContactAnalysisSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRealtimeContactAnalysisSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRealtimeContactAnalysisSegmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRealtimeContactAnalysisSegmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}