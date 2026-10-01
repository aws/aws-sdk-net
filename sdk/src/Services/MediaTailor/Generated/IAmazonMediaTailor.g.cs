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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.MediaTailor.Model;

#pragma warning disable CS1570

namespace Amazon.MediaTailor
{
    /// <summary>
    /// <para>Interface for accessing MediaTailor</para>
    ///
    /// Use the AWS Elemental MediaTailor SDKs and CLI to configure scalable ad insertion
    /// and linear channels. With MediaTailor, you can assemble existing content into a linear
    /// stream and serve targeted ads to viewers while maintaining broadcast quality in over-the-top
    /// (OTT) video applications. For information about using the service, including detailed
    /// information about the settings covered in this guide, see the <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/">AWS
    /// Elemental MediaTailor User Guide</a>.
    /// 
    ///  
    /// <para>
    /// Through the SDKs and the CLI you manage AWS Elemental MediaTailor configurations and
    /// channels the same as you do through the console. For example, you specify ad insertion
    /// behavior and mapping information for the origin server and the ad decision server
    /// (ADS).
    /// </para>
    /// </summary>
    public partial interface IAmazonMediaTailor : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMediaTailorPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Configures Amazon CloudWatch log settings for a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForChannel service method.</param>
        /// <returns>The response from the ConfigureLogsForChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForChannel">REST API Reference for ConfigureLogsForChannel Operation</seealso>
        ConfigureLogsForChannelResponse ConfigureLogsForChannel(ConfigureLogsForChannelRequest request);
#endif

        /// <summary>
        /// Configures Amazon CloudWatch log settings for a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ConfigureLogsForChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForChannel">REST API Reference for ConfigureLogsForChannel Operation</seealso>
        Task<ConfigureLogsForChannelResponse> ConfigureLogsForChannelAsync(ConfigureLogsForChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Defines where AWS Elemental MediaTailor sends logs for the playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForPlaybackConfiguration service method.</param>
        /// <returns>The response from the ConfigureLogsForPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForPlaybackConfiguration">REST API Reference for ConfigureLogsForPlaybackConfiguration Operation</seealso>
        ConfigureLogsForPlaybackConfigurationResponse ConfigureLogsForPlaybackConfiguration(ConfigureLogsForPlaybackConfigurationRequest request);
#endif

        /// <summary>
        /// Defines where AWS Elemental MediaTailor sends logs for the playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ConfigureLogsForPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForPlaybackConfiguration">REST API Reference for ConfigureLogsForPlaybackConfiguration Operation</seealso>
        Task<ConfigureLogsForPlaybackConfigurationResponse> ConfigureLogsForPlaybackConfigurationAsync(ConfigureLogsForPlaybackConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <returns>The response from the CreateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse CreateChannel(CreateChannelRequest request);
#endif

        /// <summary>
        /// Creates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The live source configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLiveSource service method.</param>
        /// <returns>The response from the CreateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateLiveSource">REST API Reference for CreateLiveSource Operation</seealso>
        CreateLiveSourceResponse CreateLiveSource(CreateLiveSourceRequest request);
#endif

        /// <summary>
        /// The live source configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateLiveSource">REST API Reference for CreateLiveSource Operation</seealso>
        Task<CreateLiveSourceResponse> CreateLiveSourceAsync(CreateLiveSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a prefetch schedule for a playback configuration. A prefetch schedule allows
        /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
        /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrefetchSchedule service method.</param>
        /// <returns>The response from the CreatePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreatePrefetchSchedule">REST API Reference for CreatePrefetchSchedule Operation</seealso>
        CreatePrefetchScheduleResponse CreatePrefetchSchedule(CreatePrefetchScheduleRequest request);
#endif

        /// <summary>
        /// Creates a prefetch schedule for a playback configuration. A prefetch schedule allows
        /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
        /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrefetchSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreatePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreatePrefetchSchedule">REST API Reference for CreatePrefetchSchedule Operation</seealso>
        Task<CreatePrefetchScheduleResponse> CreatePrefetchScheduleAsync(CreatePrefetchScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgram service method.</param>
        /// <returns>The response from the CreateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateProgram">REST API Reference for CreateProgram Operation</seealso>
        CreateProgramResponse CreateProgram(CreateProgramRequest request);
#endif

        /// <summary>
        /// Creates a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateProgram">REST API Reference for CreateProgram Operation</seealso>
        Task<CreateProgramResponse> CreateProgramAsync(CreateProgramRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceLocation service method.</param>
        /// <returns>The response from the CreateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateSourceLocation">REST API Reference for CreateSourceLocation Operation</seealso>
        CreateSourceLocationResponse CreateSourceLocation(CreateSourceLocationRequest request);
#endif

        /// <summary>
        /// Creates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateSourceLocation">REST API Reference for CreateSourceLocation Operation</seealso>
        Task<CreateSourceLocationResponse> CreateSourceLocationAsync(CreateSourceLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The VOD source configuration parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVodSource service method.</param>
        /// <returns>The response from the CreateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateVodSource">REST API Reference for CreateVodSource Operation</seealso>
        CreateVodSourceResponse CreateVodSource(CreateVodSourceRequest request);
#endif

        /// <summary>
        /// The VOD source configuration parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateVodSource">REST API Reference for CreateVodSource Operation</seealso>
        Task<CreateVodSourceResponse> CreateVodSourceAsync(CreateVodSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <returns>The response from the DeleteChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse DeleteChannel(DeleteChannelRequest request);
#endif

        /// <summary>
        /// Deletes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The channel policy to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy service method.</param>
        /// <returns>The response from the DeleteChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        DeleteChannelPolicyResponse DeleteChannelPolicy(DeleteChannelPolicyRequest request);
#endif

        /// <summary>
        /// The channel policy to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        Task<DeleteChannelPolicyResponse> DeleteChannelPolicyAsync(DeleteChannelPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a function. MediaTailor prevents deletion of a function that is still referenced
        /// by a playback configuration or by another function. Remove all references before deleting.
        /// For more information about functions, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
        /// with functions</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// <returns>The response from the DeleteFunction service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request);
#endif

        /// <summary>
        /// Deletes a function. MediaTailor prevents deletion of a function that is still referenced
        /// by a playback configuration or by another function. Remove all references before deleting.
        /// For more information about functions, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
        /// with functions</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteFunction service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The live source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLiveSource service method.</param>
        /// <returns>The response from the DeleteLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteLiveSource">REST API Reference for DeleteLiveSource Operation</seealso>
        DeleteLiveSourceResponse DeleteLiveSource(DeleteLiveSourceRequest request);
#endif

        /// <summary>
        /// The live source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteLiveSource">REST API Reference for DeleteLiveSource Operation</seealso>
        Task<DeleteLiveSourceResponse> DeleteLiveSourceAsync(DeleteLiveSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration service method.</param>
        /// <returns>The response from the DeletePlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        DeletePlaybackConfigurationResponse DeletePlaybackConfiguration(DeletePlaybackConfigurationRequest request);
#endif

        /// <summary>
        /// Deletes a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeletePlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        Task<DeletePlaybackConfigurationResponse> DeletePlaybackConfigurationAsync(DeletePlaybackConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a prefetch schedule for a specific playback configuration. If you call <c>DeletePrefetchSchedule</c>
        /// on an expired prefetch schedule, MediaTailor returns an HTTP 404 status code. For
        /// more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrefetchSchedule service method.</param>
        /// <returns>The response from the DeletePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePrefetchSchedule">REST API Reference for DeletePrefetchSchedule Operation</seealso>
        DeletePrefetchScheduleResponse DeletePrefetchSchedule(DeletePrefetchScheduleRequest request);
#endif

        /// <summary>
        /// Deletes a prefetch schedule for a specific playback configuration. If you call <c>DeletePrefetchSchedule</c>
        /// on an expired prefetch schedule, MediaTailor returns an HTTP 404 status code. For
        /// more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrefetchSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeletePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePrefetchSchedule">REST API Reference for DeletePrefetchSchedule Operation</seealso>
        Task<DeletePrefetchScheduleResponse> DeletePrefetchScheduleAsync(DeletePrefetchScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgram service method.</param>
        /// <returns>The response from the DeleteProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteProgram">REST API Reference for DeleteProgram Operation</seealso>
        DeleteProgramResponse DeleteProgram(DeleteProgramRequest request);
#endif

        /// <summary>
        /// Deletes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteProgram">REST API Reference for DeleteProgram Operation</seealso>
        Task<DeleteProgramResponse> DeleteProgramAsync(DeleteProgramRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceLocation service method.</param>
        /// <returns>The response from the DeleteSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteSourceLocation">REST API Reference for DeleteSourceLocation Operation</seealso>
        DeleteSourceLocationResponse DeleteSourceLocation(DeleteSourceLocationRequest request);
#endif

        /// <summary>
        /// Deletes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteSourceLocation">REST API Reference for DeleteSourceLocation Operation</seealso>
        Task<DeleteSourceLocationResponse> DeleteSourceLocationAsync(DeleteSourceLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The video on demand (VOD) source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVodSource service method.</param>
        /// <returns>The response from the DeleteVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteVodSource">REST API Reference for DeleteVodSource Operation</seealso>
        DeleteVodSourceResponse DeleteVodSource(DeleteVodSourceRequest request);
#endif

        /// <summary>
        /// The video on demand (VOD) source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteVodSource">REST API Reference for DeleteVodSource Operation</seealso>
        Task<DeleteVodSourceResponse> DeleteVodSourceAsync(DeleteVodSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Describes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// <returns>The response from the DescribeChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        DescribeChannelResponse DescribeChannel(DescribeChannelRequest request);
#endif

        /// <summary>
        /// Describes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The live source to describe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLiveSource service method.</param>
        /// <returns>The response from the DescribeLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeLiveSource">REST API Reference for DescribeLiveSource Operation</seealso>
        DescribeLiveSourceResponse DescribeLiveSource(DescribeLiveSourceRequest request);
#endif

        /// <summary>
        /// The live source to describe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeLiveSource">REST API Reference for DescribeLiveSource Operation</seealso>
        Task<DescribeLiveSourceResponse> DescribeLiveSourceAsync(DescribeLiveSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Describes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProgram service method.</param>
        /// <returns>The response from the DescribeProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeProgram">REST API Reference for DescribeProgram Operation</seealso>
        DescribeProgramResponse DescribeProgram(DescribeProgramRequest request);
#endif

        /// <summary>
        /// Describes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeProgram">REST API Reference for DescribeProgram Operation</seealso>
        Task<DescribeProgramResponse> DescribeProgramAsync(DescribeProgramRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Describes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceLocation service method.</param>
        /// <returns>The response from the DescribeSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeSourceLocation">REST API Reference for DescribeSourceLocation Operation</seealso>
        DescribeSourceLocationResponse DescribeSourceLocation(DescribeSourceLocationRequest request);
#endif

        /// <summary>
        /// Describes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeSourceLocation">REST API Reference for DescribeSourceLocation Operation</seealso>
        Task<DescribeSourceLocationResponse> DescribeSourceLocationAsync(DescribeSourceLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Provides details about a specific video on demand (VOD) source in a specific source
        /// location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVodSource service method.</param>
        /// <returns>The response from the DescribeVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeVodSource">REST API Reference for DescribeVodSource Operation</seealso>
        DescribeVodSourceResponse DescribeVodSource(DescribeVodSourceRequest request);
#endif

        /// <summary>
        /// Provides details about a specific video on demand (VOD) source in a specific source
        /// location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeVodSource">REST API Reference for DescribeVodSource Operation</seealso>
        Task<DescribeVodSourceResponse> DescribeVodSourceAsync(DescribeVodSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns the channel's IAM policy. IAM policies are used to control access to your
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy service method.</param>
        /// <returns>The response from the GetChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        GetChannelPolicyResponse GetChannelPolicy(GetChannelPolicyRequest request);
#endif

        /// <summary>
        /// Returns the channel's IAM policy. IAM policies are used to control access to your
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        Task<GetChannelPolicyResponse> GetChannelPolicyAsync(GetChannelPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about your channel's schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelSchedule service method.</param>
        /// <returns>The response from the GetChannelSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelSchedule">REST API Reference for GetChannelSchedule Operation</seealso>
        GetChannelScheduleResponse GetChannelSchedule(GetChannelScheduleRequest request);
#endif

        /// <summary>
        /// Retrieves information about your channel's schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetChannelSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelSchedule">REST API Reference for GetChannelSchedule Operation</seealso>
        Task<GetChannelScheduleResponse> GetChannelScheduleAsync(GetChannelScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the configuration and metadata for a function. For more information about
        /// functions, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
        /// with functions</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// <returns>The response from the GetFunction service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetFunction">REST API Reference for GetFunction Operation</seealso>
        GetFunctionResponse GetFunction(GetFunctionRequest request);
#endif

        /// <summary>
        /// Retrieves the configuration and metadata for a function. For more information about
        /// functions, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
        /// with functions</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetFunction service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetFunction">REST API Reference for GetFunction Operation</seealso>
        Task<GetFunctionResponse> GetFunctionAsync(GetFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration service method.</param>
        /// <returns>The response from the GetPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        GetPlaybackConfigurationResponse GetPlaybackConfiguration(GetPlaybackConfigurationRequest request);
#endif

        /// <summary>
        /// Retrieves a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        Task<GetPlaybackConfigurationResponse> GetPlaybackConfigurationAsync(GetPlaybackConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a prefetch schedule for a playback configuration. A prefetch schedule allows
        /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
        /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrefetchSchedule service method.</param>
        /// <returns>The response from the GetPrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPrefetchSchedule">REST API Reference for GetPrefetchSchedule Operation</seealso>
        GetPrefetchScheduleResponse GetPrefetchSchedule(GetPrefetchScheduleRequest request);
#endif

        /// <summary>
        /// Retrieves a prefetch schedule for a playback configuration. A prefetch schedule allows
        /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
        /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrefetchSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPrefetchSchedule">REST API Reference for GetPrefetchSchedule Operation</seealso>
        Task<GetPrefetchScheduleResponse> GetPrefetchScheduleAsync(GetPrefetchScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the alerts that are associated with a MediaTailor channel assembly resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// <returns>The response from the ListAlerts service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        ListAlertsResponse ListAlerts(ListAlertsRequest request);
#endif

        /// <summary>
        /// Lists the alerts that are associated with a MediaTailor channel assembly resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAlerts service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        Task<ListAlertsResponse> ListAlertsAsync(ListAlertsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the channels that are associated with the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <returns>The response from the ListChannels service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse ListChannels(ListChannelsRequest request);
#endif

        /// <summary>
        /// Retrieves information about the channels that are associated with the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListChannels service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListChannels">REST API Reference for ListChannels Operation</seealso>
        Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves all functions associated with your AWS account in the current Region. For
        /// more information about functions, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
        /// with functions</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// <returns>The response from the ListFunctions service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        ListFunctionsResponse ListFunctions(ListFunctionsRequest request);
#endif

        /// <summary>
        /// Retrieves all functions associated with your AWS account in the current Region. For
        /// more information about functions, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
        /// with functions</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListFunctions service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the live sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLiveSources service method.</param>
        /// <returns>The response from the ListLiveSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListLiveSources">REST API Reference for ListLiveSources Operation</seealso>
        ListLiveSourcesResponse ListLiveSources(ListLiveSourcesRequest request);
#endif

        /// <summary>
        /// Lists the live sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLiveSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListLiveSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListLiveSources">REST API Reference for ListLiveSources Operation</seealso>
        Task<ListLiveSourcesResponse> ListLiveSourcesAsync(ListLiveSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves existing playback configurations. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with Configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations service method.</param>
        /// <returns>The response from the ListPlaybackConfigurations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        ListPlaybackConfigurationsResponse ListPlaybackConfigurations(ListPlaybackConfigurationsRequest request);
#endif

        /// <summary>
        /// Retrieves existing playback configurations. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with Configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPlaybackConfigurations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        Task<ListPlaybackConfigurationsResponse> ListPlaybackConfigurationsAsync(ListPlaybackConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the prefetch schedules for a playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrefetchSchedules service method.</param>
        /// <returns>The response from the ListPrefetchSchedules service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPrefetchSchedules">REST API Reference for ListPrefetchSchedules Operation</seealso>
        ListPrefetchSchedulesResponse ListPrefetchSchedules(ListPrefetchSchedulesRequest request);
#endif

        /// <summary>
        /// Lists the prefetch schedules for a playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrefetchSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPrefetchSchedules service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPrefetchSchedules">REST API Reference for ListPrefetchSchedules Operation</seealso>
        Task<ListPrefetchSchedulesResponse> ListPrefetchSchedulesAsync(ListPrefetchSchedulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the source locations for a channel. A source location defines the host server
        /// URL, and contains a list of sources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceLocations service method.</param>
        /// <returns>The response from the ListSourceLocations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListSourceLocations">REST API Reference for ListSourceLocations Operation</seealso>
        ListSourceLocationsResponse ListSourceLocations(ListSourceLocationsRequest request);
#endif

        /// <summary>
        /// Lists the source locations for a channel. A source location defines the host server
        /// URL, and contains a list of sources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSourceLocations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListSourceLocations">REST API Reference for ListSourceLocations Operation</seealso>
        Task<ListSourceLocationsResponse> ListSourceLocationsAsync(ListSourceLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// A list of tags that are associated with this resource. Tags are key-value pairs that
        /// you can associate with Amazon resources to help with organization, access control,
        /// and cost tracking. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// A list of tags that are associated with this resource. Tags are key-value pairs that
        /// you can associate with Amazon resources to help with organization, access control,
        /// and cost tracking. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the VOD sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVodSources service method.</param>
        /// <returns>The response from the ListVodSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListVodSources">REST API Reference for ListVodSources Operation</seealso>
        ListVodSourcesResponse ListVodSources(ListVodSourcesRequest request);
#endif

        /// <summary>
        /// Lists the VOD sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVodSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListVodSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListVodSources">REST API Reference for ListVodSources Operation</seealso>
        Task<ListVodSourcesResponse> ListVodSourcesAsync(ListVodSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates an IAM policy for the channel. IAM policies are used to control access to
        /// your channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy service method.</param>
        /// <returns>The response from the PutChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        PutChannelPolicyResponse PutChannelPolicy(PutChannelPolicyRequest request);
#endif

        /// <summary>
        /// Creates an IAM policy for the channel. IAM policies are used to control access to
        /// your channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        Task<PutChannelPolicyResponse> PutChannelPolicyAsync(PutChannelPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates or updates a function. A function defines reusable logic that MediaTailor
        /// executes at lifecycle hooks during ad insertion. For more information about functions,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
        /// with functions</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunction service method.</param>
        /// <returns>The response from the PutFunction service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutFunction">REST API Reference for PutFunction Operation</seealso>
        PutFunctionResponse PutFunction(PutFunctionRequest request);
#endif

        /// <summary>
        /// Creates or updates a function. A function defines reusable logic that MediaTailor
        /// executes at lifecycle hooks during ad insertion. For more information about functions,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
        /// with functions</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutFunction service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutFunction">REST API Reference for PutFunction Operation</seealso>
        Task<PutFunctionResponse> PutFunctionAsync(PutFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration service method.</param>
        /// <returns>The response from the PutPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        PutPlaybackConfigurationResponse PutPlaybackConfiguration(PutPlaybackConfigurationRequest request);
#endif

        /// <summary>
        /// Creates a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        Task<PutPlaybackConfigurationResponse> PutPlaybackConfigurationAsync(PutPlaybackConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// <returns>The response from the StartChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StartChannel">REST API Reference for StartChannel Operation</seealso>
        StartChannelResponse StartChannel(StartChannelRequest request);
#endif

        /// <summary>
        /// Starts a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StartChannel">REST API Reference for StartChannel Operation</seealso>
        Task<StartChannelResponse> StartChannelAsync(StartChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Stops a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// <returns>The response from the StopChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StopChannel">REST API Reference for StopChannel Operation</seealso>
        StopChannelResponse StopChannel(StopChannelRequest request);
#endif

        /// <summary>
        /// Stops a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StopChannel">REST API Reference for StopChannel Operation</seealso>
        Task<StopChannelResponse> StopChannelAsync(StopChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The resource to tag. Tags are key-value pairs that you can associate with Amazon resources
        /// to help with organization, access control, and cost tracking. For more information,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// The resource to tag. Tags are key-value pairs that you can associate with Amazon resources
        /// to help with organization, access control, and cost tracking. For more information,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The resource to untag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// The resource to untag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <returns>The response from the UpdateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse UpdateChannel(UpdateChannelRequest request);
#endif

        /// <summary>
        /// Updates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a live source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLiveSource service method.</param>
        /// <returns>The response from the UpdateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateLiveSource">REST API Reference for UpdateLiveSource Operation</seealso>
        UpdateLiveSourceResponse UpdateLiveSource(UpdateLiveSourceRequest request);
#endif

        /// <summary>
        /// Updates a live source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateLiveSource">REST API Reference for UpdateLiveSource Operation</seealso>
        Task<UpdateLiveSourceResponse> UpdateLiveSourceAsync(UpdateLiveSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a program within a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgram service method.</param>
        /// <returns>The response from the UpdateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateProgram">REST API Reference for UpdateProgram Operation</seealso>
        UpdateProgramResponse UpdateProgram(UpdateProgramRequest request);
#endif

        /// <summary>
        /// Updates a program within a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateProgram">REST API Reference for UpdateProgram Operation</seealso>
        Task<UpdateProgramResponse> UpdateProgramAsync(UpdateProgramRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceLocation service method.</param>
        /// <returns>The response from the UpdateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateSourceLocation">REST API Reference for UpdateSourceLocation Operation</seealso>
        UpdateSourceLocationResponse UpdateSourceLocation(UpdateSourceLocationRequest request);
#endif

        /// <summary>
        /// Updates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateSourceLocation">REST API Reference for UpdateSourceLocation Operation</seealso>
        Task<UpdateSourceLocationResponse> UpdateSourceLocationAsync(UpdateSourceLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a VOD source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVodSource service method.</param>
        /// <returns>The response from the UpdateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateVodSource">REST API Reference for UpdateVodSource Operation</seealso>
        UpdateVodSourceResponse UpdateVodSource(UpdateVodSourceRequest request);
#endif

        /// <summary>
        /// Updates a VOD source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateVodSource">REST API Reference for UpdateVodSource Operation</seealso>
        Task<UpdateVodSourceResponse> UpdateVodSourceAsync(UpdateVodSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonMediaTailorConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonMediaTailorConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonMediaTailorConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonMediaTailorConfig to create AmazonMediaTailorClient");
            }

            return awsCredentials == null ?
                    new AmazonMediaTailorClient(serviceClientConfig) :
                    new AmazonMediaTailorClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
