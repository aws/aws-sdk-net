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
 * Do not modify this file. This file is generated from the cloudtrail-data-2021-08-11.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudTrailData.Model;
using Amazon.CloudTrailData.Model.Internal.MarshallTransformations;
using Amazon.CloudTrailData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudTrailData
{
    /// <summary>
    /// Implementation for accessing CloudTrailData
    ///
    /// The CloudTrail Data Service lets you ingest events into CloudTrail from any source
    /// in your hybrid environments, such as in-house or SaaS applications hosted on-premises
    /// or in the cloud, virtual machines, or containers. You can store, access, analyze,
    /// troubleshoot and take action on this data without maintaining multiple log aggregators
    /// and reporting tools. After you run <code>PutAuditEvents</code> to ingest your application
    /// activity into CloudTrail, you can use CloudTrail Lake to search, query, and analyze
    /// the data that is logged from your applications.
    /// </summary>
    public partial class AmazonCloudTrailDataClient : AmazonServiceClient, IAmazonCloudTrailData
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudTrailDataMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with the credentials loaded from the application's
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
        public AmazonCloudTrailDataClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudTrailDataConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with the credentials loaded from the application's
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
        public AmazonCloudTrailDataClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudTrailDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudTrailDataClient Configuration Object</param>
        public AmazonCloudTrailDataClient(AmazonCloudTrailDataConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudTrailDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudTrailDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudTrailDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with AWS Credentials and an
        /// AmazonCloudTrailDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudTrailDataClient Configuration Object</param>
        public AmazonCloudTrailDataClient(AWSCredentials credentials, AmazonCloudTrailDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudTrailDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudTrailDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudTrailDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudTrailDataClient Configuration Object</param>
        public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudTrailDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudTrailDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudTrailDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudTrailDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudTrailDataClient Configuration Object</param>
        public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudTrailDataConfig clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudTrailDataEndpointResolver());
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


        #region  PutAuditEvents

        internal virtual PutAuditEventsResponse PutAuditEvents(PutAuditEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAuditEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAuditEventsResponseUnmarshaller.Instance;

            return Invoke<PutAuditEventsResponse>(request, options);
        }



        /// <summary>
        /// Ingests your application events into CloudTrail Lake. A required parameter, <code>auditEvents</code>,
        /// accepts the JSON records (also called <i>payload</i>) of events that you want CloudTrail
        /// to ingest. You can add up to 100 of these events (or up to 1 MB) per <code>PutAuditEvents</code>
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAuditEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAuditEvents service method, as returned by CloudTrailData.</returns>
        /// <exception cref="Amazon.CloudTrailData.Model.ChannelInsufficientPermissionException">
        /// The caller's account ID must be the same as the channel owner's account ID.
        /// </exception>
        /// <exception cref="Amazon.CloudTrailData.Model.ChannelNotFoundException">
        /// The channel could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrailData.Model.ChannelUnsupportedSchemaException">
        /// The schema type of the event is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudTrailData.Model.DuplicatedAuditEventIdException">
        /// Two or more entries in the request have the same event ID.
        /// </exception>
        /// <exception cref="Amazon.CloudTrailData.Model.InvalidChannelARNException">
        /// The specified channel ARN is not a valid channel ARN.
        /// </exception>
        /// <exception cref="Amazon.CloudTrailData.Model.UnsupportedOperationException">
        /// The operation requested is not supported in this region or account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-data-2021-08-11/PutAuditEvents">REST API Reference for PutAuditEvents Operation</seealso>
        public virtual Task<PutAuditEventsResponse> PutAuditEventsAsync(PutAuditEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAuditEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAuditEventsResponseUnmarshaller.Instance;

            return InvokeAsync<PutAuditEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}