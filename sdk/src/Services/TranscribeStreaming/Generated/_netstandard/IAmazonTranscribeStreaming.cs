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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.TranscribeStreaming.Model;

#pragma warning disable CS1570
namespace Amazon.TranscribeStreaming
{
    /// <summary>
    /// <para>Interface for accessing TranscribeStreaming</para>
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
    public partial interface IAmazonTranscribeStreaming : IAmazonService, IDisposable
    {
                
        #region  GetMedicalScribeStream



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
        Task<GetMedicalScribeStreamResponse> GetMedicalScribeStreamAsync(GetMedicalScribeStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartCallAnalyticsStreamTranscription

#if NET8_0_OR_GREATER


        /// <summary>
        /// Starts a bidirectional HTTP/2 or WebSocket stream where audio is streamed to Amazon
        /// Transcribe and the transcription results are streamed to your application. Use this
        /// operation for <a href="https://docs.aws.amazon.com/transcribe/latest/dg/call-analytics.html">Call
        /// Analytics</a> transcriptions.
        /// 
        ///  
        /// <para>
        /// The following parameters are required:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>language-code</c> or <c>identify-language</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>media-encoding</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sample-rate</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on streaming with Amazon Transcribe, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html">Transcribing
        /// streaming audio</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCallAnalyticsStreamTranscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCallAnalyticsStreamTranscription service method, as returned by TranscribeStreaming.</returns>
        /// <exception cref="Amazon.TranscribeStreaming.Model.BadRequestException">
        /// One or more arguments to the <c>StartStreamTranscription</c>, <c>StartMedicalStreamTranscription</c>,
        /// or <c>StartCallAnalyticsStreamTranscription</c> operation was not valid. For example,
        /// <c>MediaEncoding</c> or <c>LanguageCode</c> used unsupported values. Check the specified
        /// parameters and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.ConflictException">
        /// A new stream started with the same session ID. The current stream has been terminated.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.InternalFailureException">
        /// A problem occurred while processing the audio. Amazon Transcribe terminated processing.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.LimitExceededException">
        /// Your client has exceeded one of the Amazon Transcribe limits. This is typically the
        /// audio length limit. Break your audio stream into smaller chunks and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.ServiceUnavailableException">
        /// The service is currently unavailable. Try your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-streaming-2017-10-26/StartCallAnalyticsStreamTranscription">REST API Reference for StartCallAnalyticsStreamTranscription Operation</seealso>
        Task<StartCallAnalyticsStreamTranscriptionResponse> StartCallAnalyticsStreamTranscriptionAsync(StartCallAnalyticsStreamTranscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

#endif
        #endregion
                
        #region  StartMedicalScribeStream

#if NET8_0_OR_GREATER


        /// <summary>
        /// Starts a bidirectional HTTP/2 stream, where audio is streamed to Amazon Web Services
        /// HealthScribe and the transcription results are streamed to your application.
        /// 
        ///  
        /// <para>
        /// When you start a stream, you first specify the stream configuration in a <c>MedicalScribeConfigurationEvent</c>.
        /// This event includes channel definitions, encryption settings, medical scribe context,
        /// and post-stream analytics settings, such as the output configuration for aggregated
        /// transcript and clinical note generation. These are additional streaming session configurations
        /// beyond those provided in your initial start request headers. Whether you are starting
        /// a new session or resuming an existing session, your first event must be a <c>MedicalScribeConfigurationEvent</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  After you send a <c>MedicalScribeConfigurationEvent</c>, you start <c>AudioEvents</c>
        /// and Amazon Web Services HealthScribe responds with real-time transcription results.
        /// When you are finished, to start processing the results with the post-stream analytics,
        /// send a <c>MedicalScribeSessionControlEvent</c> with a <c>Type</c> of <c>END_OF_SESSION</c>
        /// and Amazon Web Services HealthScribe starts the analytics. 
        /// </para>
        ///  
        /// <para>
        /// You can pause or resume streaming. To pause streaming, complete the input stream without
        /// sending the <c>MedicalScribeSessionControlEvent</c>. To resume streaming, call the
        /// <c>StartMedicalScribeStream</c> and specify the same SessionId you used to start the
        /// stream. 
        /// </para>
        ///  
        /// <para>
        /// The following parameters are required:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>language-code</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>media-encoding</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>media-sample-rate-hertz</c> 
        /// </para>
        ///  </li> </ul>  
        /// <para>
        /// For more information on streaming with Amazon Web Services HealthScribe, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/health-scribe-streaming.html">Amazon
        /// Web Services HealthScribe</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalScribeStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMedicalScribeStream service method, as returned by TranscribeStreaming.</returns>
        /// <exception cref="Amazon.TranscribeStreaming.Model.BadRequestException">
        /// One or more arguments to the <c>StartStreamTranscription</c>, <c>StartMedicalStreamTranscription</c>,
        /// or <c>StartCallAnalyticsStreamTranscription</c> operation was not valid. For example,
        /// <c>MediaEncoding</c> or <c>LanguageCode</c> used unsupported values. Check the specified
        /// parameters and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.ConflictException">
        /// A new stream started with the same session ID. The current stream has been terminated.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.InternalFailureException">
        /// A problem occurred while processing the audio. Amazon Transcribe terminated processing.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.LimitExceededException">
        /// Your client has exceeded one of the Amazon Transcribe limits. This is typically the
        /// audio length limit. Break your audio stream into smaller chunks and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.ServiceUnavailableException">
        /// The service is currently unavailable. Try your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-streaming-2017-10-26/StartMedicalScribeStream">REST API Reference for StartMedicalScribeStream Operation</seealso>
        Task<StartMedicalScribeStreamResponse> StartMedicalScribeStreamAsync(StartMedicalScribeStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

#endif
        #endregion
                
        #region  StartMedicalStreamTranscription

#if NET8_0_OR_GREATER


        /// <summary>
        /// Starts a bidirectional HTTP/2 or WebSocket stream where audio is streamed to Amazon
        /// Transcribe Medical and the transcription results are streamed to your application.
        /// 
        ///  
        /// <para>
        /// The following parameters are required:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>language-code</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>media-encoding</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sample-rate</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on streaming with Amazon Transcribe Medical, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html">Transcribing
        /// streaming audio</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalStreamTranscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMedicalStreamTranscription service method, as returned by TranscribeStreaming.</returns>
        /// <exception cref="Amazon.TranscribeStreaming.Model.BadRequestException">
        /// One or more arguments to the <c>StartStreamTranscription</c>, <c>StartMedicalStreamTranscription</c>,
        /// or <c>StartCallAnalyticsStreamTranscription</c> operation was not valid. For example,
        /// <c>MediaEncoding</c> or <c>LanguageCode</c> used unsupported values. Check the specified
        /// parameters and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.ConflictException">
        /// A new stream started with the same session ID. The current stream has been terminated.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.InternalFailureException">
        /// A problem occurred while processing the audio. Amazon Transcribe terminated processing.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.LimitExceededException">
        /// Your client has exceeded one of the Amazon Transcribe limits. This is typically the
        /// audio length limit. Break your audio stream into smaller chunks and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.ServiceUnavailableException">
        /// The service is currently unavailable. Try your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-streaming-2017-10-26/StartMedicalStreamTranscription">REST API Reference for StartMedicalStreamTranscription Operation</seealso>
        Task<StartMedicalStreamTranscriptionResponse> StartMedicalStreamTranscriptionAsync(StartMedicalStreamTranscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

#endif
        #endregion
                
        #region  StartStreamTranscription

#if NET8_0_OR_GREATER


        /// <summary>
        /// Starts a bidirectional HTTP/2 or WebSocket stream where audio is streamed to Amazon
        /// Transcribe and the transcription results are streamed to your application.
        /// 
        ///  
        /// <para>
        /// The following parameters are required:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>language-code</c> or <c>identify-language</c> or <c>identify-multiple-language</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>media-encoding</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sample-rate</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on streaming with Amazon Transcribe, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html">Transcribing
        /// streaming audio</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamTranscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartStreamTranscription service method, as returned by TranscribeStreaming.</returns>
        /// <exception cref="Amazon.TranscribeStreaming.Model.BadRequestException">
        /// One or more arguments to the <c>StartStreamTranscription</c>, <c>StartMedicalStreamTranscription</c>,
        /// or <c>StartCallAnalyticsStreamTranscription</c> operation was not valid. For example,
        /// <c>MediaEncoding</c> or <c>LanguageCode</c> used unsupported values. Check the specified
        /// parameters and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.ConflictException">
        /// A new stream started with the same session ID. The current stream has been terminated.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.InternalFailureException">
        /// A problem occurred while processing the audio. Amazon Transcribe terminated processing.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.LimitExceededException">
        /// Your client has exceeded one of the Amazon Transcribe limits. This is typically the
        /// audio length limit. Break your audio stream into smaller chunks and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeStreaming.Model.ServiceUnavailableException">
        /// The service is currently unavailable. Try your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-streaming-2017-10-26/StartStreamTranscription">REST API Reference for StartStreamTranscription Operation</seealso>
        Task<StartStreamTranscriptionResponse> StartStreamTranscriptionAsync(StartStreamTranscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

#endif
        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonTranscribeStreamingConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonTranscribeStreamingConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonTranscribeStreamingConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonTranscribeStreamingConfig to create AmazonTranscribeStreamingClient");
            }

            return awsCredentials == null ? 
                    new AmazonTranscribeStreamingClient(serviceClientConfig) :
                    new AmazonTranscribeStreamingClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}