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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.TranscribeStreaming.Model;
using Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations;
using Amazon.TranscribeStreaming.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.TranscribeStreaming
{
    /// <summary>
    /// <para>Implementation for accessing TranscribeStreaming</para>
    ///
    /// Amazon Transcribe streaming offers four main types of real-time transcription: <b>Standard</b>,
    /// <b>Medical</b>, <b>Call Analytics</b>, and <b>Health Scribe</b>.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>Standard transcriptions</b> are the most common option. Refer to for details.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Medical transcriptions</b> are tailored to medical professionals and incorporate
    /// medical terms. A common use case for this service is transcribing doctor-patient dialogue
    /// in real time, so doctors can focus on their patient instead of taking notes. Refer
    /// to for details.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Call Analytics transcriptions</b> are designed for use with call center audio
    /// on two different channels; if you're looking for insight into customer service calls,
    /// use this option. Refer to for details.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>HealthScribe transcriptions</b> are designed to automatically create clinical
    /// notes from patient-clinician conversations using generative AI. Refer to [here] for
    /// details.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonTranscribeStreamingClient : AmazonServiceClient, IAmazonTranscribeStreaming
    {
        private static IServiceMetadata serviceMetadata = new AmazonTranscribeStreamingMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with the credentials loaded from the application's
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
        public AmazonTranscribeStreamingClient()
            : base(new AmazonTranscribeStreamingConfig()) { }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with the credentials loaded from the application's
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
        public AmazonTranscribeStreamingClient(RegionEndpoint region)
            : base(new AmazonTranscribeStreamingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTranscribeStreamingClient Configuration Object</param>
        public AmazonTranscribeStreamingClient(AmazonTranscribeStreamingConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTranscribeStreamingClient(AWSCredentials credentials)
            : this(credentials, new AmazonTranscribeStreamingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeStreamingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTranscribeStreamingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with AWS Credentials and an
        /// AmazonTranscribeStreamingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTranscribeStreamingClient Configuration Object</param>
        public AmazonTranscribeStreamingClient(AWSCredentials credentials, AmazonTranscribeStreamingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTranscribeStreamingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranscribeStreamingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeStreamingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranscribeStreamingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranscribeStreamingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTranscribeStreamingClient Configuration Object</param>
        public AmazonTranscribeStreamingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTranscribeStreamingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTranscribeStreamingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranscribeStreamingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeStreamingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranscribeStreamingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeStreamingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranscribeStreamingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTranscribeStreamingClient Configuration Object</param>
        public AmazonTranscribeStreamingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTranscribeStreamingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTranscribeStreamingEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTranscribeStreamingAuthSchemeHandler());
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


        #region  GetMedicalScribeStream


        /// <summary>
        /// Provides details about the specified Amazon Web Services HealthScribe streaming session.
        /// To view the status of the streaming session, check the <c>StreamStatus</c> field in
        /// the response. To get the details of post-stream analytics, including its status, check
        /// the <c>PostStreamAnalyticsResult</c> field in the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalScribeStream service method.</param>
        /// 
        /// <returns>The response from the GetMedicalScribeStream service method, as returned by TranscribeStreaming.</returns>
        /// <exception cref="Amazon.TranscribeStreaming.Model.BadRequestException">
        /// One or more arguments to the <c>StartStreamTranscription</c>, <c>StartMedicalStreamTranscription</c>,
        /// or <c>StartCallAnalyticsStreamTranscription</c> operation was not valid. For example,
        /// <c>MediaEncoding</c> or <c>LanguageCode</c> used unsupported values. Check the specified
        /// parameters and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.InternalFailureException">
        /// A problem occurred while processing the audio. Amazon Transcribe terminated processing.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.LimitExceededException">
        /// Your client has exceeded one of the Amazon Transcribe limits. This is typically the
        /// audio length limit. Break your audio stream into smaller chunks and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.ResourceNotFoundException">
        /// The request references a resource which doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-streaming-2017-10-26/GetMedicalScribeStream">REST API Reference for GetMedicalScribeStream Operation</seealso>
        public virtual GetMedicalScribeStreamResponse GetMedicalScribeStream(GetMedicalScribeStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMedicalScribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalScribeStreamResponseUnmarshaller.Instance;

            return Invoke<GetMedicalScribeStreamResponse>(request, options);
        }


        /// <summary>
        /// Provides details about the specified Amazon Web Services HealthScribe streaming session.
        /// To view the status of the streaming session, check the <c>StreamStatus</c> field in
        /// the response. To get the details of post-stream analytics, including its status, check
        /// the <c>PostStreamAnalyticsResult</c> field in the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalScribeStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMedicalScribeStream service method, as returned by TranscribeStreaming.</returns>
        /// <exception cref="Amazon.TranscribeStreaming.Model.BadRequestException">
        /// One or more arguments to the <c>StartStreamTranscription</c>, <c>StartMedicalStreamTranscription</c>,
        /// or <c>StartCallAnalyticsStreamTranscription</c> operation was not valid. For example,
        /// <c>MediaEncoding</c> or <c>LanguageCode</c> used unsupported values. Check the specified
        /// parameters and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.InternalFailureException">
        /// A problem occurred while processing the audio. Amazon Transcribe terminated processing.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.LimitExceededException">
        /// Your client has exceeded one of the Amazon Transcribe limits. This is typically the
        /// audio length limit. Break your audio stream into smaller chunks and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.ResourceNotFoundException">
        /// The request references a resource which doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-streaming-2017-10-26/GetMedicalScribeStream">REST API Reference for GetMedicalScribeStream Operation</seealso>
        public virtual Task<GetMedicalScribeStreamResponse> GetMedicalScribeStreamAsync(GetMedicalScribeStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMedicalScribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalScribeStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMedicalScribeStreamResponse>(request, options, cancellationToken);
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