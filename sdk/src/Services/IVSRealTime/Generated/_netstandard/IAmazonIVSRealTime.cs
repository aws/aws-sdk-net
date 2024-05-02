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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IVSRealTime.Model;

#pragma warning disable CS1570
namespace Amazon.IVSRealTime
{
    /// <summary>
    /// <para>Interface for accessing IVSRealTime</para>
    ///
    /// <b>Introduction</b> 
    /// 
    ///  
    /// <para>
    /// The Amazon Interactive Video Service (IVS) real-time API is REST compatible, using
    /// a standard HTTP API and an AWS EventBridge event stream for responses. JSON is used
    /// for both requests and responses, including errors. 
    /// </para>
    ///  
    /// <para>
    /// Terminology:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <i>stage</i> is a virtual space where participants can exchange video in real time.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <i>participant token</i> is a token that authenticates a participant when they join
    /// a stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <i>participant object</i> represents participants (people) in the stage and contains
    /// information about them. When a token is created, it includes a participant ID; when
    /// a participant uses that token to join a stage, the participant is associated with
    /// that participant ID. There is a 1:1 mapping between participant tokens and participants.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Server-side composition: The <i>composition</i> process composites participants of
    /// a stage into a single video and forwards it to a set of outputs (e.g., IVS channels).
    /// Composition endpoints support this process.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Server-side composition: A <i>composition</i> controls the look of the outputs, including
    /// how participants are positioned in the video.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// The following resources contain information about your IVS live stream (see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/getting-started.html">Getting
    /// Started with Amazon IVS Real-Time Streaming</a>):
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Stage</b> — A stage is a virtual space where participants can exchange video in
    /// real time.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>tag</i> is a metadata label that you assign to an AWS resource. A tag comprises
    /// a <i>key</i> and a <i>value</i>, both set by you. For example, you might set a tag
    /// as <c>topic:nature</c> to label a particular video category. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// AWS Resources</a> for more information, including restrictions that apply to tags
    /// and "Tag naming limits and requirements"; Amazon IVS stages has no service-specific
    /// constraints beyond what is documented there.
    /// </para>
    ///  
    /// <para>
    /// Tags can help you identify and organize your AWS resources. For example, you can use
    /// the same tag for different resources to indicate that they are related. You can also
    /// use tags to manage access (see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Access
    /// Tags</a>).
    /// </para>
    ///  
    /// <para>
    /// The Amazon IVS real-time API has these tag-related endpoints: <a>TagResource</a>,
    /// <a>UntagResource</a>, and <a>ListTagsForResource</a>. The following resource supports
    /// tagging: Stage.
    /// </para>
    ///  
    /// <para>
    /// At most 50 tags can be applied to a resource.
    /// </para>
    ///  
    /// <para>
    ///  <b>Stages Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateParticipantToken</a> — Creates an additional token for a specified stage.
    /// This can be done after stage creation or when tokens expire.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateStage</a> — Creates a new stage (and optionally participant tokens).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteStage</a> — Shuts down and deletes the specified stage (disconnecting all
    /// participants).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisconnectParticipant</a> — Disconnects a specified participant and revokes the
    /// participant permanently from a specified stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetParticipant</a> — Gets information about the specified participant token.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStage</a> — Gets information for the specified stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStageSession</a> — Gets information for the specified stage session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListParticipantEvents</a> — Lists events for a specified participant that occurred
    /// during a specified stage session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListParticipants</a> — Lists all participants in a specified stage session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStages</a> — Gets summary information about all stages in your account, in
    /// the AWS region where the API request is processed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStageSessions</a> — Gets all sessions for a specified stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateStage</a> — Updates a stage’s configuration.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Composition Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetComposition</a> — Gets information about the specified Composition resource.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListCompositions</a> — Gets summary information about all Compositions in your
    /// account, in the AWS region where the API request is processed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartComposition</a> — Starts a Composition from a stage based on the configuration
    /// provided in the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopComposition</a> — Stops and deletes a Composition resource. Any broadcast
    /// from the Composition resource is stopped.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>EncoderConfiguration Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateEncoderConfiguration</a> — Creates an EncoderConfiguration object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteEncoderConfiguration</a> — Deletes an EncoderConfiguration resource. Ensures
    /// that no Compositions are using this template; otherwise, returns an error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetEncoderConfiguration</a> — Gets information about the specified EncoderConfiguration
    /// resource.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListEncoderConfigurations</a> — Gets summary information about all EncoderConfigurations
    /// in your account, in the AWS region where the API request is processed.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>StorageConfiguration Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateStorageConfiguration</a> — Creates a new storage configuration, used to
    /// enable recording to Amazon S3.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteStorageConfiguration</a> — Deletes the storage configuration for the specified
    /// ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStorageConfiguration</a> — Gets the storage configuration for the specified
    /// ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStorageConfigurations</a> — Gets summary information about all storage configurations
    /// in your account, in the AWS region where the API request is processed.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tags Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a> — Gets information about AWS tags for the specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a> — Adds or updates tags for the AWS resource with the specified
    /// ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a> — Removes tags from the resource with the specified ARN.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonIVSRealTime : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIVSRealTimePaginatorFactory Paginators { get; }
#endif
                
        #region  CreateEncoderConfiguration



        /// <summary>
        /// Creates an EncoderConfiguration object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEncoderConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEncoderConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateEncoderConfiguration">REST API Reference for CreateEncoderConfiguration Operation</seealso>
        Task<CreateEncoderConfigurationResponse> CreateEncoderConfigurationAsync(CreateEncoderConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateParticipantToken



        /// <summary>
        /// Creates an additional token for a specified stage. This can be done after stage creation
        /// or when tokens expire. Tokens always are scoped to the stage for which they are created.
        /// 
        ///  
        /// <para>
        /// Encryption keys are owned by Amazon IVS and never used directly by your application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParticipantToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateParticipantToken service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateParticipantToken">REST API Reference for CreateParticipantToken Operation</seealso>
        Task<CreateParticipantTokenResponse> CreateParticipantTokenAsync(CreateParticipantTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStage



        /// <summary>
        /// Creates a new stage (and optionally participant tokens).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateStage">REST API Reference for CreateStage Operation</seealso>
        Task<CreateStageResponse> CreateStageAsync(CreateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStorageConfiguration



        /// <summary>
        /// Creates a new storage configuration, used to enable recording to Amazon S3. When a
        /// StorageConfiguration is created, IVS will modify the S3 bucketPolicy of the provided
        /// bucket. This will ensure that IVS has sufficient permissions to write content to the
        /// provided bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorageConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateStorageConfiguration">REST API Reference for CreateStorageConfiguration Operation</seealso>
        Task<CreateStorageConfigurationResponse> CreateStorageConfigurationAsync(CreateStorageConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEncoderConfiguration



        /// <summary>
        /// Deletes an EncoderConfiguration resource. Ensures that no Compositions are using this
        /// template; otherwise, returns an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEncoderConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEncoderConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteEncoderConfiguration">REST API Reference for DeleteEncoderConfiguration Operation</seealso>
        Task<DeleteEncoderConfigurationResponse> DeleteEncoderConfigurationAsync(DeleteEncoderConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStage



        /// <summary>
        /// Shuts down and deletes the specified stage (disconnecting all participants).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        Task<DeleteStageResponse> DeleteStageAsync(DeleteStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStorageConfiguration



        /// <summary>
        /// Deletes the storage configuration for the specified ARN.
        /// 
        ///  
        /// <para>
        /// If you try to delete a storage configuration that is used by a Composition, you will
        /// get an error (409 ConflictException). To avoid this, for all Compositions that reference
        /// the storage configuration, first use <a>StopComposition</a> and wait for it to complete,
        /// then use DeleteStorageConfiguration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStorageConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteStorageConfiguration">REST API Reference for DeleteStorageConfiguration Operation</seealso>
        Task<DeleteStorageConfigurationResponse> DeleteStorageConfigurationAsync(DeleteStorageConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisconnectParticipant



        /// <summary>
        /// Disconnects a specified participant and revokes the participant permanently from a
        /// specified stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectParticipant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectParticipant service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        Task<DisconnectParticipantResponse> DisconnectParticipantAsync(DisconnectParticipantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetComposition



        /// <summary>
        /// Get information about the specified Composition resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComposition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComposition service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetComposition">REST API Reference for GetComposition Operation</seealso>
        Task<GetCompositionResponse> GetCompositionAsync(GetCompositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEncoderConfiguration



        /// <summary>
        /// Gets information about the specified EncoderConfiguration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncoderConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEncoderConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetEncoderConfiguration">REST API Reference for GetEncoderConfiguration Operation</seealso>
        Task<GetEncoderConfigurationResponse> GetEncoderConfigurationAsync(GetEncoderConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetParticipant



        /// <summary>
        /// Gets information about the specified participant token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParticipant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParticipant service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetParticipant">REST API Reference for GetParticipant Operation</seealso>
        Task<GetParticipantResponse> GetParticipantAsync(GetParticipantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStage



        /// <summary>
        /// Gets information for the specified stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStage">REST API Reference for GetStage Operation</seealso>
        Task<GetStageResponse> GetStageAsync(GetStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStageSession



        /// <summary>
        /// Gets information for the specified stage session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStageSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStageSession service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStageSession">REST API Reference for GetStageSession Operation</seealso>
        Task<GetStageSessionResponse> GetStageSessionAsync(GetStageSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStorageConfiguration



        /// <summary>
        /// Gets the storage configuration for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStorageConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStorageConfiguration">REST API Reference for GetStorageConfiguration Operation</seealso>
        Task<GetStorageConfigurationResponse> GetStorageConfigurationAsync(GetStorageConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCompositions



        /// <summary>
        /// Gets summary information about all Compositions in your account, in the AWS region
        /// where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompositions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCompositions service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListCompositions">REST API Reference for ListCompositions Operation</seealso>
        Task<ListCompositionsResponse> ListCompositionsAsync(ListCompositionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEncoderConfigurations



        /// <summary>
        /// Gets summary information about all EncoderConfigurations in your account, in the AWS
        /// region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEncoderConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEncoderConfigurations service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListEncoderConfigurations">REST API Reference for ListEncoderConfigurations Operation</seealso>
        Task<ListEncoderConfigurationsResponse> ListEncoderConfigurationsAsync(ListEncoderConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListParticipantEvents



        /// <summary>
        /// Lists events for a specified participant that occurred during a specified stage session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParticipantEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParticipantEvents service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListParticipantEvents">REST API Reference for ListParticipantEvents Operation</seealso>
        Task<ListParticipantEventsResponse> ListParticipantEventsAsync(ListParticipantEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListParticipants



        /// <summary>
        /// Lists all participants in a specified stage session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParticipants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParticipants service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListParticipants">REST API Reference for ListParticipants Operation</seealso>
        Task<ListParticipantsResponse> ListParticipantsAsync(ListParticipantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStages



        /// <summary>
        /// Gets summary information about all stages in your account, in the AWS region where
        /// the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStages service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStages">REST API Reference for ListStages Operation</seealso>
        Task<ListStagesResponse> ListStagesAsync(ListStagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStageSessions



        /// <summary>
        /// Gets all sessions for a specified stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStageSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStageSessions service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStageSessions">REST API Reference for ListStageSessions Operation</seealso>
        Task<ListStageSessionsResponse> ListStageSessionsAsync(ListStageSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStorageConfigurations



        /// <summary>
        /// Gets summary information about all storage configurations in your account, in the
        /// AWS region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStorageConfigurations service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStorageConfigurations">REST API Reference for ListStorageConfigurations Operation</seealso>
        Task<ListStorageConfigurationsResponse> ListStorageConfigurationsAsync(ListStorageConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Gets information about AWS tags for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartComposition



        /// <summary>
        /// Starts a Composition from a stage based on the configuration provided in the request.
        /// 
        ///  
        /// <para>
        /// A Composition is an ephemeral resource that exists after this endpoint returns successfully.
        /// Composition stops and the resource is deleted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When <a>StopComposition</a> is called.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After a 1-minute timeout, when all participants are disconnected from the stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After a 1-minute timeout, if there are no participants in the stage when StartComposition
        /// is called.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When broadcasting to the IVS channel fails and all retries are exhausted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When broadcasting is disconnected and all attempts to reconnect are exhausted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartComposition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartComposition service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/StartComposition">REST API Reference for StartComposition Operation</seealso>
        Task<StartCompositionResponse> StartCompositionAsync(StartCompositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopComposition



        /// <summary>
        /// Stops and deletes a Composition resource. Any broadcast from the Composition resource
        /// is stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopComposition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopComposition service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/StopComposition">REST API Reference for StopComposition Operation</seealso>
        Task<StopCompositionResponse> StopCompositionAsync(StopCompositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or updates tags for the AWS resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from the resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateStage



        /// <summary>
        /// Updates a stage’s configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        Task<UpdateStageResponse> UpdateStageAsync(UpdateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}