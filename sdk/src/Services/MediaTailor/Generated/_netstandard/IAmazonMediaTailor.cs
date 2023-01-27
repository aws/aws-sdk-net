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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MediaTailor.Model;

namespace Amazon.MediaTailor
{
    /// <summary>
    /// Interface for accessing MediaTailor
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
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMediaTailorPaginatorFactory Paginators { get; }
#endif
                
        #region  ConfigureLogsForChannel



        /// <summary>
        /// Configures Amazon CloudWatch log settings for a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfigureLogsForChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForChannel">REST API Reference for ConfigureLogsForChannel Operation</seealso>
        Task<ConfigureLogsForChannelResponse> ConfigureLogsForChannelAsync(ConfigureLogsForChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ConfigureLogsForPlaybackConfiguration



        /// <summary>
        /// Amazon CloudWatch log settings for a playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfigureLogsForPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForPlaybackConfiguration">REST API Reference for ConfigureLogsForPlaybackConfiguration Operation</seealso>
        Task<ConfigureLogsForPlaybackConfigurationResponse> ConfigureLogsForPlaybackConfigurationAsync(ConfigureLogsForPlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateChannel



        /// <summary>
        /// Creates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLiveSource



        /// <summary>
        /// The live source configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateLiveSource">REST API Reference for CreateLiveSource Operation</seealso>
        Task<CreateLiveSourceResponse> CreateLiveSourceAsync(CreateLiveSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePrefetchSchedule



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
        /// 
        /// <returns>The response from the CreatePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreatePrefetchSchedule">REST API Reference for CreatePrefetchSchedule Operation</seealso>
        Task<CreatePrefetchScheduleResponse> CreatePrefetchScheduleAsync(CreatePrefetchScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProgram



        /// <summary>
        /// Creates a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateProgram">REST API Reference for CreateProgram Operation</seealso>
        Task<CreateProgramResponse> CreateProgramAsync(CreateProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSourceLocation



        /// <summary>
        /// Creates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateSourceLocation">REST API Reference for CreateSourceLocation Operation</seealso>
        Task<CreateSourceLocationResponse> CreateSourceLocationAsync(CreateSourceLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVodSource



        /// <summary>
        /// The VOD source configuration parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateVodSource">REST API Reference for CreateVodSource Operation</seealso>
        Task<CreateVodSourceResponse> CreateVodSourceAsync(CreateVodSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteChannel



        /// <summary>
        /// Deletes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteChannelPolicy



        /// <summary>
        /// The channel policy to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        Task<DeleteChannelPolicyResponse> DeleteChannelPolicyAsync(DeleteChannelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLiveSource



        /// <summary>
        /// The live source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteLiveSource">REST API Reference for DeleteLiveSource Operation</seealso>
        Task<DeleteLiveSourceResponse> DeleteLiveSourceAsync(DeleteLiveSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePlaybackConfiguration



        /// <summary>
        /// Deletes a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        Task<DeletePlaybackConfigurationResponse> DeletePlaybackConfigurationAsync(DeletePlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePrefetchSchedule



        /// <summary>
        /// Deletes a prefetch schedule for a specific playback configuration. If you call <code>DeletePrefetchSchedule</code>
        /// on an expired prefetch schedule, MediaTailor returns an HTTP 404 status code. For
        /// more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrefetchSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePrefetchSchedule">REST API Reference for DeletePrefetchSchedule Operation</seealso>
        Task<DeletePrefetchScheduleResponse> DeletePrefetchScheduleAsync(DeletePrefetchScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProgram



        /// <summary>
        /// Deletes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteProgram">REST API Reference for DeleteProgram Operation</seealso>
        Task<DeleteProgramResponse> DeleteProgramAsync(DeleteProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSourceLocation



        /// <summary>
        /// Deletes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteSourceLocation">REST API Reference for DeleteSourceLocation Operation</seealso>
        Task<DeleteSourceLocationResponse> DeleteSourceLocationAsync(DeleteSourceLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVodSource



        /// <summary>
        /// The video on demand (VOD) source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteVodSource">REST API Reference for DeleteVodSource Operation</seealso>
        Task<DeleteVodSourceResponse> DeleteVodSourceAsync(DeleteVodSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeChannel



        /// <summary>
        /// Describes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLiveSource



        /// <summary>
        /// The live source to describe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeLiveSource">REST API Reference for DescribeLiveSource Operation</seealso>
        Task<DescribeLiveSourceResponse> DescribeLiveSourceAsync(DescribeLiveSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProgram



        /// <summary>
        /// Describes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeProgram">REST API Reference for DescribeProgram Operation</seealso>
        Task<DescribeProgramResponse> DescribeProgramAsync(DescribeProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSourceLocation



        /// <summary>
        /// Describes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeSourceLocation">REST API Reference for DescribeSourceLocation Operation</seealso>
        Task<DescribeSourceLocationResponse> DescribeSourceLocationAsync(DescribeSourceLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVodSource



        /// <summary>
        /// Provides details about a specific video on demand (VOD) source in a specific source
        /// location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeVodSource">REST API Reference for DescribeVodSource Operation</seealso>
        Task<DescribeVodSourceResponse> DescribeVodSourceAsync(DescribeVodSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetChannelPolicy



        /// <summary>
        /// Returns the channel's IAM policy. IAM policies are used to control access to your
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        Task<GetChannelPolicyResponse> GetChannelPolicyAsync(GetChannelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetChannelSchedule



        /// <summary>
        /// Retrieves information about your channel's schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannelSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelSchedule">REST API Reference for GetChannelSchedule Operation</seealso>
        Task<GetChannelScheduleResponse> GetChannelScheduleAsync(GetChannelScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPlaybackConfiguration



        /// <summary>
        /// Retrieves a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        Task<GetPlaybackConfigurationResponse> GetPlaybackConfigurationAsync(GetPlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPrefetchSchedule



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
        /// 
        /// <returns>The response from the GetPrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPrefetchSchedule">REST API Reference for GetPrefetchSchedule Operation</seealso>
        Task<GetPrefetchScheduleResponse> GetPrefetchScheduleAsync(GetPrefetchScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAlerts



        /// <summary>
        /// Lists the alerts that are associated with a MediaTailor channel assembly resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlerts service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        Task<ListAlertsResponse> ListAlertsAsync(ListAlertsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChannels



        /// <summary>
        /// Retrieves information about the channels that are associated with the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListChannels">REST API Reference for ListChannels Operation</seealso>
        Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLiveSources



        /// <summary>
        /// Lists the live sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLiveSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLiveSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListLiveSources">REST API Reference for ListLiveSources Operation</seealso>
        Task<ListLiveSourcesResponse> ListLiveSourcesAsync(ListLiveSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPlaybackConfigurations



        /// <summary>
        /// Retrieves existing playback configurations. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with Configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlaybackConfigurations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        Task<ListPlaybackConfigurationsResponse> ListPlaybackConfigurationsAsync(ListPlaybackConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPrefetchSchedules



        /// <summary>
        /// Lists the prefetch schedules for a playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrefetchSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrefetchSchedules service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPrefetchSchedules">REST API Reference for ListPrefetchSchedules Operation</seealso>
        Task<ListPrefetchSchedulesResponse> ListPrefetchSchedulesAsync(ListPrefetchSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSourceLocations



        /// <summary>
        /// Lists the source locations for a channel. A source location defines the host server
        /// URL, and contains a list of sources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSourceLocations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListSourceLocations">REST API Reference for ListSourceLocations Operation</seealso>
        Task<ListSourceLocationsResponse> ListSourceLocationsAsync(ListSourceLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



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
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVodSources



        /// <summary>
        /// Lists the VOD sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVodSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVodSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListVodSources">REST API Reference for ListVodSources Operation</seealso>
        Task<ListVodSourcesResponse> ListVodSourcesAsync(ListVodSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutChannelPolicy



        /// <summary>
        /// Creates an IAM policy for the channel. IAM policies are used to control access to
        /// your channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        Task<PutChannelPolicyResponse> PutChannelPolicyAsync(PutChannelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutPlaybackConfiguration



        /// <summary>
        /// Creates a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        Task<PutPlaybackConfigurationResponse> PutPlaybackConfigurationAsync(PutPlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartChannel



        /// <summary>
        /// Starts a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StartChannel">REST API Reference for StartChannel Operation</seealso>
        Task<StartChannelResponse> StartChannelAsync(StartChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopChannel



        /// <summary>
        /// Stops a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StopChannel">REST API Reference for StopChannel Operation</seealso>
        Task<StopChannelResponse> StopChannelAsync(StopChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



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
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// The resource to untag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateChannel



        /// <summary>
        /// Updates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLiveSource



        /// <summary>
        /// Updates a live source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateLiveSource">REST API Reference for UpdateLiveSource Operation</seealso>
        Task<UpdateLiveSourceResponse> UpdateLiveSourceAsync(UpdateLiveSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSourceLocation



        /// <summary>
        /// Updates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateSourceLocation">REST API Reference for UpdateSourceLocation Operation</seealso>
        Task<UpdateSourceLocationResponse> UpdateSourceLocationAsync(UpdateSourceLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVodSource



        /// <summary>
        /// Updates a VOD source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateVodSource">REST API Reference for UpdateVodSource Operation</seealso>
        Task<UpdateVodSourceResponse> UpdateVodSourceAsync(UpdateVodSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}