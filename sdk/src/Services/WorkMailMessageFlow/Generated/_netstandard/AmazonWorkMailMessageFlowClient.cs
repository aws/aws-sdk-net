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
 * Do not modify this file. This file is generated from the workmailmessageflow-2019-05-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkMailMessageFlow.Model;
using Amazon.WorkMailMessageFlow.Model.Internal.MarshallTransformations;
using Amazon.WorkMailMessageFlow.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.WorkMailMessageFlow
{
    /// <summary>
    /// <para>Implementation for accessing WorkMailMessageFlow</para>
    ///
    /// The WorkMail Message Flow API provides access to email messages as they are being
    /// sent and received by a WorkMail organization.
    /// </summary>
    public partial class AmazonWorkMailMessageFlowClient : AmazonServiceClient, IAmazonWorkMailMessageFlow
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkMailMessageFlowMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with the credentials loaded from the application's
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
        public AmazonWorkMailMessageFlowClient()
            : base(new AmazonWorkMailMessageFlowConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with the credentials loaded from the application's
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
        public AmazonWorkMailMessageFlowClient(RegionEndpoint region)
            : base(new AmazonWorkMailMessageFlowConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkMailMessageFlowClient Configuration Object</param>
        public AmazonWorkMailMessageFlowClient(AmazonWorkMailMessageFlowConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkMailMessageFlowClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkMailMessageFlowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailMessageFlowClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkMailMessageFlowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Credentials and an
        /// AmazonWorkMailMessageFlowClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkMailMessageFlowClient Configuration Object</param>
        public AmazonWorkMailMessageFlowClient(AWSCredentials credentials, AmazonWorkMailMessageFlowConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkMailMessageFlowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkMailMessageFlowConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkMailMessageFlowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkMailMessageFlowClient Configuration Object</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkMailMessageFlowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkMailMessageFlowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkMailMessageFlowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkMailMessageFlowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkMailMessageFlowClient Configuration Object</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkMailMessageFlowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWorkMailMessageFlowEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWorkMailMessageFlowAuthSchemeHandler());
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


        #region  GetRawMessageContent

        internal virtual GetRawMessageContentResponse GetRawMessageContent(GetRawMessageContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRawMessageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRawMessageContentResponseUnmarshaller.Instance;

            return Invoke<GetRawMessageContentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the raw content of an in-transit email message, in MIME format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRawMessageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRawMessageContent service method, as returned by WorkMailMessageFlow.</returns>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.ResourceNotFoundException">
        /// The requested email message is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/GetRawMessageContent">REST API Reference for GetRawMessageContent Operation</seealso>
        public virtual Task<GetRawMessageContentResponse> GetRawMessageContentAsync(GetRawMessageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRawMessageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRawMessageContentResponseUnmarshaller.Instance;

            return InvokeAsync<GetRawMessageContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutRawMessageContent

        internal virtual PutRawMessageContentResponse PutRawMessageContent(PutRawMessageContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRawMessageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRawMessageContentResponseUnmarshaller.Instance;

            return Invoke<PutRawMessageContentResponse>(request, options);
        }



        /// <summary>
        /// Updates the raw content of an in-transit email message, in MIME format.
        /// 
        ///  
        /// <para>
        /// This example describes how to update in-transit email message. For more information
        /// and examples for using this API, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/update-with-lambda.html">
        /// Updating message content with AWS Lambda</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Updates to an in-transit message only appear when you call <c>PutRawMessageContent</c>
        /// from an AWS Lambda function configured with a synchronous <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/lambda.html#synchronous-rules">
        /// Run Lambda</a> rule. If you call <c>PutRawMessageContent</c> on a delivered or sent
        /// message, the message remains unchanged, even though <a href="https://docs.aws.amazon.com/workmail/latest/APIReference/API_messageflow_GetRawMessageContent.html">GetRawMessageContent</a>
        /// returns an updated message. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRawMessageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRawMessageContent service method, as returned by WorkMailMessageFlow.</returns>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.InvalidContentLocationException">
        /// WorkMail could not access the updated email content. Possible reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You made the request in a region other than your S3 bucket region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-owner-condition.html">S3
        /// bucket owner</a> is not the same as the calling AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You have an incomplete or missing S3 bucket policy. For more information about policies,
        /// see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/update-with-lambda.html">
        /// Updating message content with AWS Lambda </a> in the <i>WorkMail Administrator Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.MessageFrozenException">
        /// The requested email is not eligible for update. This is usually the case for a redirected
        /// email.
        /// </exception>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.MessageRejectedException">
        /// The requested email could not be updated due to an error in the MIME content. Check
        /// the error message for more information about what caused the error.
        /// </exception>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.ResourceNotFoundException">
        /// The requested email message is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/PutRawMessageContent">REST API Reference for PutRawMessageContent Operation</seealso>
        public virtual Task<PutRawMessageContentResponse> PutRawMessageContentAsync(PutRawMessageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRawMessageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRawMessageContentResponseUnmarshaller.Instance;

            return InvokeAsync<PutRawMessageContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}