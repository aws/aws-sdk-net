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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        /// 
        /// <returns>The response from the ConfigureLogsForChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForChannel">REST API Reference for ConfigureLogsForChannel Operation</seealso>
        ConfigureLogsForChannelResponse ConfigureLogsForChannel(ConfigureLogsForChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureLogsForChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfigureLogsForChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForChannel">REST API Reference for ConfigureLogsForChannel Operation</seealso>
        IAsyncResult BeginConfigureLogsForChannel(ConfigureLogsForChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfigureLogsForChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureLogsForChannel.</param>
        /// 
        /// <returns>Returns a  ConfigureLogsForChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForChannel">REST API Reference for ConfigureLogsForChannel Operation</seealso>
        ConfigureLogsForChannelResponse EndConfigureLogsForChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfigureLogsForPlaybackConfiguration


        /// <summary>
        /// Amazon CloudWatch log settings for a playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForPlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the ConfigureLogsForPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForPlaybackConfiguration">REST API Reference for ConfigureLogsForPlaybackConfiguration Operation</seealso>
        ConfigureLogsForPlaybackConfigurationResponse ConfigureLogsForPlaybackConfiguration(ConfigureLogsForPlaybackConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureLogsForPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForPlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfigureLogsForPlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForPlaybackConfiguration">REST API Reference for ConfigureLogsForPlaybackConfiguration Operation</seealso>
        IAsyncResult BeginConfigureLogsForPlaybackConfiguration(ConfigureLogsForPlaybackConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfigureLogsForPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureLogsForPlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  ConfigureLogsForPlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForPlaybackConfiguration">REST API Reference for ConfigureLogsForPlaybackConfiguration Operation</seealso>
        ConfigureLogsForPlaybackConfigurationResponse EndConfigureLogsForPlaybackConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChannel


        /// <summary>
        /// Creates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse CreateChannel(CreateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLiveSource


        /// <summary>
        /// The live source configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLiveSource service method.</param>
        /// 
        /// <returns>The response from the CreateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateLiveSource">REST API Reference for CreateLiveSource Operation</seealso>
        CreateLiveSourceResponse CreateLiveSource(CreateLiveSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLiveSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLiveSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLiveSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateLiveSource">REST API Reference for CreateLiveSource Operation</seealso>
        IAsyncResult BeginCreateLiveSource(CreateLiveSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLiveSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLiveSource.</param>
        /// 
        /// <returns>Returns a  CreateLiveSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateLiveSource">REST API Reference for CreateLiveSource Operation</seealso>
        CreateLiveSourceResponse EndCreateLiveSource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePrefetchSchedule


        /// <summary>
        /// Creates a prefetch schedule for a playback configuration. A prefetch schedule allows
        /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
        /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrefetchSchedule service method.</param>
        /// 
        /// <returns>The response from the CreatePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreatePrefetchSchedule">REST API Reference for CreatePrefetchSchedule Operation</seealso>
        CreatePrefetchScheduleResponse CreatePrefetchSchedule(CreatePrefetchScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrefetchSchedule operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePrefetchSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreatePrefetchSchedule">REST API Reference for CreatePrefetchSchedule Operation</seealso>
        IAsyncResult BeginCreatePrefetchSchedule(CreatePrefetchScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePrefetchSchedule.</param>
        /// 
        /// <returns>Returns a  CreatePrefetchScheduleResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreatePrefetchSchedule">REST API Reference for CreatePrefetchSchedule Operation</seealso>
        CreatePrefetchScheduleResponse EndCreatePrefetchSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProgram


        /// <summary>
        /// Creates a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgram service method.</param>
        /// 
        /// <returns>The response from the CreateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateProgram">REST API Reference for CreateProgram Operation</seealso>
        CreateProgramResponse CreateProgram(CreateProgramRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProgram operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateProgram">REST API Reference for CreateProgram Operation</seealso>
        IAsyncResult BeginCreateProgram(CreateProgramRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProgram.</param>
        /// 
        /// <returns>Returns a  CreateProgramResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateProgram">REST API Reference for CreateProgram Operation</seealso>
        CreateProgramResponse EndCreateProgram(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSourceLocation


        /// <summary>
        /// Creates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceLocation service method.</param>
        /// 
        /// <returns>The response from the CreateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateSourceLocation">REST API Reference for CreateSourceLocation Operation</seealso>
        CreateSourceLocationResponse CreateSourceLocation(CreateSourceLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceLocation operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSourceLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateSourceLocation">REST API Reference for CreateSourceLocation Operation</seealso>
        IAsyncResult BeginCreateSourceLocation(CreateSourceLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSourceLocation.</param>
        /// 
        /// <returns>Returns a  CreateSourceLocationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateSourceLocation">REST API Reference for CreateSourceLocation Operation</seealso>
        CreateSourceLocationResponse EndCreateSourceLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVodSource


        /// <summary>
        /// The VOD source configuration parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVodSource service method.</param>
        /// 
        /// <returns>The response from the CreateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateVodSource">REST API Reference for CreateVodSource Operation</seealso>
        CreateVodSourceResponse CreateVodSource(CreateVodSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVodSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVodSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVodSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateVodSource">REST API Reference for CreateVodSource Operation</seealso>
        IAsyncResult BeginCreateVodSource(CreateVodSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVodSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVodSource.</param>
        /// 
        /// <returns>Returns a  CreateVodSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateVodSource">REST API Reference for CreateVodSource Operation</seealso>
        CreateVodSourceResponse EndCreateVodSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Deletes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse DeleteChannel(DeleteChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChannelPolicy


        /// <summary>
        /// The channel policy to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        DeleteChannelPolicyResponse DeleteChannelPolicy(DeleteChannelPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        IAsyncResult BeginDeleteChannelPolicy(DeleteChannelPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteChannelPolicyResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        DeleteChannelPolicyResponse EndDeleteChannelPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLiveSource


        /// <summary>
        /// The live source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLiveSource service method.</param>
        /// 
        /// <returns>The response from the DeleteLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteLiveSource">REST API Reference for DeleteLiveSource Operation</seealso>
        DeleteLiveSourceResponse DeleteLiveSource(DeleteLiveSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLiveSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLiveSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLiveSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteLiveSource">REST API Reference for DeleteLiveSource Operation</seealso>
        IAsyncResult BeginDeleteLiveSource(DeleteLiveSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLiveSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLiveSource.</param>
        /// 
        /// <returns>Returns a  DeleteLiveSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteLiveSource">REST API Reference for DeleteLiveSource Operation</seealso>
        DeleteLiveSourceResponse EndDeleteLiveSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePlaybackConfiguration


        /// <summary>
        /// Deletes a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeletePlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        DeletePlaybackConfigurationResponse DeletePlaybackConfiguration(DeletePlaybackConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        IAsyncResult BeginDeletePlaybackConfiguration(DeletePlaybackConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  DeletePlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        DeletePlaybackConfigurationResponse EndDeletePlaybackConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePrefetchSchedule


        /// <summary>
        /// Deletes a prefetch schedule for a specific playback configuration. If you call <code>DeletePrefetchSchedule</code>
        /// on an expired prefetch schedule, MediaTailor returns an HTTP 404 status code. For
        /// more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrefetchSchedule service method.</param>
        /// 
        /// <returns>The response from the DeletePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePrefetchSchedule">REST API Reference for DeletePrefetchSchedule Operation</seealso>
        DeletePrefetchScheduleResponse DeletePrefetchSchedule(DeletePrefetchScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePrefetchSchedule operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePrefetchSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePrefetchSchedule">REST API Reference for DeletePrefetchSchedule Operation</seealso>
        IAsyncResult BeginDeletePrefetchSchedule(DeletePrefetchScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePrefetchSchedule.</param>
        /// 
        /// <returns>Returns a  DeletePrefetchScheduleResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePrefetchSchedule">REST API Reference for DeletePrefetchSchedule Operation</seealso>
        DeletePrefetchScheduleResponse EndDeletePrefetchSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProgram


        /// <summary>
        /// Deletes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgram service method.</param>
        /// 
        /// <returns>The response from the DeleteProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteProgram">REST API Reference for DeleteProgram Operation</seealso>
        DeleteProgramResponse DeleteProgram(DeleteProgramRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgram operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteProgram">REST API Reference for DeleteProgram Operation</seealso>
        IAsyncResult BeginDeleteProgram(DeleteProgramRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProgram.</param>
        /// 
        /// <returns>Returns a  DeleteProgramResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteProgram">REST API Reference for DeleteProgram Operation</seealso>
        DeleteProgramResponse EndDeleteProgram(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSourceLocation


        /// <summary>
        /// Deletes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceLocation service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteSourceLocation">REST API Reference for DeleteSourceLocation Operation</seealso>
        DeleteSourceLocationResponse DeleteSourceLocation(DeleteSourceLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceLocation operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSourceLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteSourceLocation">REST API Reference for DeleteSourceLocation Operation</seealso>
        IAsyncResult BeginDeleteSourceLocation(DeleteSourceLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSourceLocation.</param>
        /// 
        /// <returns>Returns a  DeleteSourceLocationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteSourceLocation">REST API Reference for DeleteSourceLocation Operation</seealso>
        DeleteSourceLocationResponse EndDeleteSourceLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVodSource


        /// <summary>
        /// The video on demand (VOD) source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVodSource service method.</param>
        /// 
        /// <returns>The response from the DeleteVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteVodSource">REST API Reference for DeleteVodSource Operation</seealso>
        DeleteVodSourceResponse DeleteVodSource(DeleteVodSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVodSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVodSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVodSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteVodSource">REST API Reference for DeleteVodSource Operation</seealso>
        IAsyncResult BeginDeleteVodSource(DeleteVodSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVodSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVodSource.</param>
        /// 
        /// <returns>Returns a  DeleteVodSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteVodSource">REST API Reference for DeleteVodSource Operation</seealso>
        DeleteVodSourceResponse EndDeleteVodSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeChannel


        /// <summary>
        /// Describes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        DescribeChannelResponse DescribeChannel(DescribeChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLiveSource


        /// <summary>
        /// The live source to describe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLiveSource service method.</param>
        /// 
        /// <returns>The response from the DescribeLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeLiveSource">REST API Reference for DescribeLiveSource Operation</seealso>
        DescribeLiveSourceResponse DescribeLiveSource(DescribeLiveSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLiveSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLiveSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLiveSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeLiveSource">REST API Reference for DescribeLiveSource Operation</seealso>
        IAsyncResult BeginDescribeLiveSource(DescribeLiveSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLiveSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLiveSource.</param>
        /// 
        /// <returns>Returns a  DescribeLiveSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeLiveSource">REST API Reference for DescribeLiveSource Operation</seealso>
        DescribeLiveSourceResponse EndDescribeLiveSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProgram


        /// <summary>
        /// Describes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProgram service method.</param>
        /// 
        /// <returns>The response from the DescribeProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeProgram">REST API Reference for DescribeProgram Operation</seealso>
        DescribeProgramResponse DescribeProgram(DescribeProgramRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProgram operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeProgram">REST API Reference for DescribeProgram Operation</seealso>
        IAsyncResult BeginDescribeProgram(DescribeProgramRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProgram.</param>
        /// 
        /// <returns>Returns a  DescribeProgramResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeProgram">REST API Reference for DescribeProgram Operation</seealso>
        DescribeProgramResponse EndDescribeProgram(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSourceLocation


        /// <summary>
        /// Describes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceLocation service method.</param>
        /// 
        /// <returns>The response from the DescribeSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeSourceLocation">REST API Reference for DescribeSourceLocation Operation</seealso>
        DescribeSourceLocationResponse DescribeSourceLocation(DescribeSourceLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceLocation operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSourceLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeSourceLocation">REST API Reference for DescribeSourceLocation Operation</seealso>
        IAsyncResult BeginDescribeSourceLocation(DescribeSourceLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSourceLocation.</param>
        /// 
        /// <returns>Returns a  DescribeSourceLocationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeSourceLocation">REST API Reference for DescribeSourceLocation Operation</seealso>
        DescribeSourceLocationResponse EndDescribeSourceLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVodSource


        /// <summary>
        /// Provides details about a specific video on demand (VOD) source in a specific source
        /// location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVodSource service method.</param>
        /// 
        /// <returns>The response from the DescribeVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeVodSource">REST API Reference for DescribeVodSource Operation</seealso>
        DescribeVodSourceResponse DescribeVodSource(DescribeVodSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVodSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVodSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVodSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeVodSource">REST API Reference for DescribeVodSource Operation</seealso>
        IAsyncResult BeginDescribeVodSource(DescribeVodSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVodSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVodSource.</param>
        /// 
        /// <returns>Returns a  DescribeVodSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeVodSource">REST API Reference for DescribeVodSource Operation</seealso>
        DescribeVodSourceResponse EndDescribeVodSource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChannelPolicy


        /// <summary>
        /// Returns the channel's IAM policy. IAM policies are used to control access to your
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the GetChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        GetChannelPolicyResponse GetChannelPolicy(GetChannelPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        IAsyncResult BeginGetChannelPolicy(GetChannelPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelPolicy.</param>
        /// 
        /// <returns>Returns a  GetChannelPolicyResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        GetChannelPolicyResponse EndGetChannelPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChannelSchedule


        /// <summary>
        /// Retrieves information about your channel's schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelSchedule service method.</param>
        /// 
        /// <returns>The response from the GetChannelSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelSchedule">REST API Reference for GetChannelSchedule Operation</seealso>
        GetChannelScheduleResponse GetChannelSchedule(GetChannelScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelSchedule operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelSchedule">REST API Reference for GetChannelSchedule Operation</seealso>
        IAsyncResult BeginGetChannelSchedule(GetChannelScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelSchedule.</param>
        /// 
        /// <returns>Returns a  GetChannelScheduleResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelSchedule">REST API Reference for GetChannelSchedule Operation</seealso>
        GetChannelScheduleResponse EndGetChannelSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPlaybackConfiguration


        /// <summary>
        /// Retrieves a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        GetPlaybackConfigurationResponse GetPlaybackConfiguration(GetPlaybackConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        IAsyncResult BeginGetPlaybackConfiguration(GetPlaybackConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  GetPlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        GetPlaybackConfigurationResponse EndGetPlaybackConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPrefetchSchedule


        /// <summary>
        /// Retrieves a prefetch schedule for a playback configuration. A prefetch schedule allows
        /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
        /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrefetchSchedule service method.</param>
        /// 
        /// <returns>The response from the GetPrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPrefetchSchedule">REST API Reference for GetPrefetchSchedule Operation</seealso>
        GetPrefetchScheduleResponse GetPrefetchSchedule(GetPrefetchScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPrefetchSchedule operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPrefetchSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPrefetchSchedule">REST API Reference for GetPrefetchSchedule Operation</seealso>
        IAsyncResult BeginGetPrefetchSchedule(GetPrefetchScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPrefetchSchedule.</param>
        /// 
        /// <returns>Returns a  GetPrefetchScheduleResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPrefetchSchedule">REST API Reference for GetPrefetchSchedule Operation</seealso>
        GetPrefetchScheduleResponse EndGetPrefetchSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAlerts


        /// <summary>
        /// Lists the alerts that are associated with a MediaTailor channel assembly resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// 
        /// <returns>The response from the ListAlerts service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        ListAlertsResponse ListAlerts(ListAlertsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlerts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlerts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        IAsyncResult BeginListAlerts(ListAlertsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlerts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlerts.</param>
        /// 
        /// <returns>Returns a  ListAlertsResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        ListAlertsResponse EndListAlerts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Retrieves information about the channels that are associated with the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListChannels">REST API Reference for ListChannels Operation</seealso>
        IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse EndListChannels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLiveSources


        /// <summary>
        /// Lists the live sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLiveSources service method.</param>
        /// 
        /// <returns>The response from the ListLiveSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListLiveSources">REST API Reference for ListLiveSources Operation</seealso>
        ListLiveSourcesResponse ListLiveSources(ListLiveSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLiveSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLiveSources operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLiveSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListLiveSources">REST API Reference for ListLiveSources Operation</seealso>
        IAsyncResult BeginListLiveSources(ListLiveSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLiveSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLiveSources.</param>
        /// 
        /// <returns>Returns a  ListLiveSourcesResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListLiveSources">REST API Reference for ListLiveSources Operation</seealso>
        ListLiveSourcesResponse EndListLiveSources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPlaybackConfigurations


        /// <summary>
        /// Retrieves existing playback configurations. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with Configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListPlaybackConfigurations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        ListPlaybackConfigurationsResponse ListPlaybackConfigurations(ListPlaybackConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlaybackConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlaybackConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        IAsyncResult BeginListPlaybackConfigurations(ListPlaybackConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlaybackConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlaybackConfigurations.</param>
        /// 
        /// <returns>Returns a  ListPlaybackConfigurationsResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        ListPlaybackConfigurationsResponse EndListPlaybackConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPrefetchSchedules


        /// <summary>
        /// Lists the prefetch schedules for a playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrefetchSchedules service method.</param>
        /// 
        /// <returns>The response from the ListPrefetchSchedules service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPrefetchSchedules">REST API Reference for ListPrefetchSchedules Operation</seealso>
        ListPrefetchSchedulesResponse ListPrefetchSchedules(ListPrefetchSchedulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrefetchSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrefetchSchedules operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrefetchSchedules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPrefetchSchedules">REST API Reference for ListPrefetchSchedules Operation</seealso>
        IAsyncResult BeginListPrefetchSchedules(ListPrefetchSchedulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrefetchSchedules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrefetchSchedules.</param>
        /// 
        /// <returns>Returns a  ListPrefetchSchedulesResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPrefetchSchedules">REST API Reference for ListPrefetchSchedules Operation</seealso>
        ListPrefetchSchedulesResponse EndListPrefetchSchedules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSourceLocations


        /// <summary>
        /// Lists the source locations for a channel. A source location defines the host server
        /// URL, and contains a list of sources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceLocations service method.</param>
        /// 
        /// <returns>The response from the ListSourceLocations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListSourceLocations">REST API Reference for ListSourceLocations Operation</seealso>
        ListSourceLocationsResponse ListSourceLocations(ListSourceLocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceLocations operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceLocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListSourceLocations">REST API Reference for ListSourceLocations Operation</seealso>
        IAsyncResult BeginListSourceLocations(ListSourceLocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceLocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceLocations.</param>
        /// 
        /// <returns>Returns a  ListSourceLocationsResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListSourceLocations">REST API Reference for ListSourceLocations Operation</seealso>
        ListSourceLocationsResponse EndListSourceLocations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// A list of tags that are associated with this resource. Tags are key-value pairs that
        /// you can associate with Amazon resources to help with organization, access control,
        /// and cost tracking. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVodSources


        /// <summary>
        /// Lists the VOD sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVodSources service method.</param>
        /// 
        /// <returns>The response from the ListVodSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListVodSources">REST API Reference for ListVodSources Operation</seealso>
        ListVodSourcesResponse ListVodSources(ListVodSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVodSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVodSources operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVodSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListVodSources">REST API Reference for ListVodSources Operation</seealso>
        IAsyncResult BeginListVodSources(ListVodSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVodSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVodSources.</param>
        /// 
        /// <returns>Returns a  ListVodSourcesResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListVodSources">REST API Reference for ListVodSources Operation</seealso>
        ListVodSourcesResponse EndListVodSources(IAsyncResult asyncResult);

        #endregion
        
        #region  PutChannelPolicy


        /// <summary>
        /// Creates an IAM policy for the channel. IAM policies are used to control access to
        /// your channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the PutChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        PutChannelPolicyResponse PutChannelPolicy(PutChannelPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutChannelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        IAsyncResult BeginPutChannelPolicy(PutChannelPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutChannelPolicy.</param>
        /// 
        /// <returns>Returns a  PutChannelPolicyResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        PutChannelPolicyResponse EndPutChannelPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPlaybackConfiguration


        /// <summary>
        /// Creates a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        PutPlaybackConfigurationResponse PutPlaybackConfiguration(PutPlaybackConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        IAsyncResult BeginPutPlaybackConfiguration(PutPlaybackConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  PutPlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        PutPlaybackConfigurationResponse EndPutPlaybackConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  StartChannel


        /// <summary>
        /// Starts a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// 
        /// <returns>The response from the StartChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StartChannel">REST API Reference for StartChannel Operation</seealso>
        StartChannelResponse StartChannel(StartChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StartChannel">REST API Reference for StartChannel Operation</seealso>
        IAsyncResult BeginStartChannel(StartChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartChannel.</param>
        /// 
        /// <returns>Returns a  StartChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StartChannel">REST API Reference for StartChannel Operation</seealso>
        StartChannelResponse EndStartChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  StopChannel


        /// <summary>
        /// Stops a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// 
        /// <returns>The response from the StopChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StopChannel">REST API Reference for StopChannel Operation</seealso>
        StopChannelResponse StopChannel(StopChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StopChannel">REST API Reference for StopChannel Operation</seealso>
        IAsyncResult BeginStopChannel(StopChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopChannel.</param>
        /// 
        /// <returns>Returns a  StopChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StopChannel">REST API Reference for StopChannel Operation</seealso>
        StopChannelResponse EndStopChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// The resource to tag. Tags are key-value pairs that you can associate with Amazon resources
        /// to help with organization, access control, and cost tracking. For more information,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// The resource to untag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Updates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse UpdateChannel(UpdateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLiveSource


        /// <summary>
        /// Updates a live source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLiveSource service method.</param>
        /// 
        /// <returns>The response from the UpdateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateLiveSource">REST API Reference for UpdateLiveSource Operation</seealso>
        UpdateLiveSourceResponse UpdateLiveSource(UpdateLiveSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLiveSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLiveSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLiveSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateLiveSource">REST API Reference for UpdateLiveSource Operation</seealso>
        IAsyncResult BeginUpdateLiveSource(UpdateLiveSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLiveSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLiveSource.</param>
        /// 
        /// <returns>Returns a  UpdateLiveSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateLiveSource">REST API Reference for UpdateLiveSource Operation</seealso>
        UpdateLiveSourceResponse EndUpdateLiveSource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProgram


        /// <summary>
        /// Updates a program within a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgram service method.</param>
        /// 
        /// <returns>The response from the UpdateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateProgram">REST API Reference for UpdateProgram Operation</seealso>
        UpdateProgramResponse UpdateProgram(UpdateProgramRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgram operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateProgram">REST API Reference for UpdateProgram Operation</seealso>
        IAsyncResult BeginUpdateProgram(UpdateProgramRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProgram.</param>
        /// 
        /// <returns>Returns a  UpdateProgramResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateProgram">REST API Reference for UpdateProgram Operation</seealso>
        UpdateProgramResponse EndUpdateProgram(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSourceLocation


        /// <summary>
        /// Updates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceLocation service method.</param>
        /// 
        /// <returns>The response from the UpdateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateSourceLocation">REST API Reference for UpdateSourceLocation Operation</seealso>
        UpdateSourceLocationResponse UpdateSourceLocation(UpdateSourceLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceLocation operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSourceLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateSourceLocation">REST API Reference for UpdateSourceLocation Operation</seealso>
        IAsyncResult BeginUpdateSourceLocation(UpdateSourceLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSourceLocation.</param>
        /// 
        /// <returns>Returns a  UpdateSourceLocationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateSourceLocation">REST API Reference for UpdateSourceLocation Operation</seealso>
        UpdateSourceLocationResponse EndUpdateSourceLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVodSource


        /// <summary>
        /// Updates a VOD source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVodSource service method.</param>
        /// 
        /// <returns>The response from the UpdateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateVodSource">REST API Reference for UpdateVodSource Operation</seealso>
        UpdateVodSourceResponse UpdateVodSource(UpdateVodSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVodSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVodSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVodSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateVodSource">REST API Reference for UpdateVodSource Operation</seealso>
        IAsyncResult BeginUpdateVodSource(UpdateVodSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVodSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVodSource.</param>
        /// 
        /// <returns>Returns a  UpdateVodSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateVodSource">REST API Reference for UpdateVodSource Operation</seealso>
        UpdateVodSourceResponse EndUpdateVodSource(IAsyncResult asyncResult);

        #endregion
        
    }
}