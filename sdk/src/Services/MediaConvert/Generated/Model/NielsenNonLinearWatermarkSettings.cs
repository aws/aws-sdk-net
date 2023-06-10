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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Ignore these settings unless you are using Nielsen non-linear watermarking. Specify
    /// the values that MediaConvert uses to generate and place Nielsen watermarks in your
    /// output audio. In addition to specifying these values, you also need to set up your
    /// cloud TIC server. These settings apply to every output in your job. The MediaConvert
    /// implementation is currently with the following Nielsen versions: Nielsen Watermark
    /// SDK Version 5.2.1 Nielsen NLM Watermark Engine Version 1.2.7 Nielsen Watermark Authenticator
    /// [SID_TIC] Version [5.0.0]
    /// </summary>
    public partial class NielsenNonLinearWatermarkSettings
    {
        private NielsenActiveWatermarkProcessType _activeWatermarkProcess;
        private string _adiFilename;
        private string _assetId;
        private string _assetName;
        private string _cbetSourceId;
        private string _episodeId;
        private string _metadataDestination;
        private int? _sourceId;
        private NielsenSourceWatermarkStatusType _sourceWatermarkStatus;
        private string _ticServerUrl;
        private NielsenUniqueTicPerAudioTrackType _uniqueTicPerAudioTrack;

        /// <summary>
        /// Gets and sets the property ActiveWatermarkProcess. Choose the type of Nielsen watermarks
        /// that you want in your outputs. When you choose NAES 2 and NW (NAES2_AND_NW), you must
        /// provide a value for the setting SID (sourceId). When you choose CBET (CBET), you must
        /// provide a value for the setting CSID (cbetSourceId). When you choose NAES 2, NW, and
        /// CBET (NAES2_AND_NW_AND_CBET), you must provide values for both of these settings.
        /// </summary>
        public NielsenActiveWatermarkProcessType ActiveWatermarkProcess
        {
            get { return this._activeWatermarkProcess; }
            set { this._activeWatermarkProcess = value; }
        }

        // Check to see if ActiveWatermarkProcess property is set
        internal bool IsSetActiveWatermarkProcess()
        {
            return this._activeWatermarkProcess != null;
        }

        /// <summary>
        /// Gets and sets the property AdiFilename. Optional. Use this setting when you want the
        /// service to include an ADI file in the Nielsen metadata .zip file. To provide an ADI
        /// file, store it in Amazon S3 and provide a URL to it here. The URL should be in the
        /// following format: S3://bucket/path/ADI-file. For more information about the metadata
        /// .zip file, see the setting Metadata destination (metadataDestination).
        /// </summary>
        public string AdiFilename
        {
            get { return this._adiFilename; }
            set { this._adiFilename = value; }
        }

        // Check to see if AdiFilename property is set
        internal bool IsSetAdiFilename()
        {
            return this._adiFilename != null;
        }

        /// <summary>
        /// Gets and sets the property AssetId. Use the asset ID that you provide to Nielsen to
        /// uniquely identify this asset. Required for all Nielsen non-linear watermarking.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetName. Use the asset name that you provide to Nielsen
        /// for this asset. Required for all Nielsen non-linear watermarking.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string AssetName
        {
            get { return this._assetName; }
            set { this._assetName = value; }
        }

        // Check to see if AssetName property is set
        internal bool IsSetAssetName()
        {
            return this._assetName != null;
        }

        /// <summary>
        /// Gets and sets the property CbetSourceId. Use the CSID that Nielsen provides to you.
        /// This CBET source ID should be unique to your Nielsen account but common to all of
        /// your output assets that have CBET watermarking. Required when you choose a value for
        /// the setting Watermark types (ActiveWatermarkProcess) that includes CBET.
        /// </summary>
        public string CbetSourceId
        {
            get { return this._cbetSourceId; }
            set { this._cbetSourceId = value; }
        }

        // Check to see if CbetSourceId property is set
        internal bool IsSetCbetSourceId()
        {
            return this._cbetSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property EpisodeId. Optional. If this asset uses an episode ID with
        /// Nielsen, provide it here.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string EpisodeId
        {
            get { return this._episodeId; }
            set { this._episodeId = value; }
        }

        // Check to see if EpisodeId property is set
        internal bool IsSetEpisodeId()
        {
            return this._episodeId != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataDestination. Specify the Amazon S3 location where
        /// you want MediaConvert to save your Nielsen non-linear metadata .zip file. This Amazon
        /// S3 bucket must be in the same Region as the one where you do your MediaConvert transcoding.
        /// If you want to include an ADI file in this .zip file, use the setting ADI file (adiFilename)
        /// to specify it. MediaConvert delivers the Nielsen metadata .zip files only to your
        /// metadata destination Amazon S3 bucket. It doesn't deliver the .zip files to Nielsen.
        /// You are responsible for delivering the metadata .zip files to Nielsen.
        /// </summary>
        public string MetadataDestination
        {
            get { return this._metadataDestination; }
            set { this._metadataDestination = value; }
        }

        // Check to see if MetadataDestination property is set
        internal bool IsSetMetadataDestination()
        {
            return this._metadataDestination != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. Use the SID that Nielsen provides to you. This
        /// source ID should be unique to your Nielsen account but common to all of your output
        /// assets. Required for all Nielsen non-linear watermarking. This ID should be unique
        /// to your Nielsen account but common to all of your output assets. Required for all
        /// Nielsen non-linear watermarking.
        /// </summary>
        [AWSProperty(Min=0, Max=65534)]
        public int SourceId
        {
            get { return this._sourceId.GetValueOrDefault(); }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceWatermarkStatus. Required. Specify whether your source
        /// content already contains Nielsen non-linear watermarks. When you set this value to
        /// Watermarked (WATERMARKED), the service fails the job. Nielsen requires that you add
        /// non-linear watermarking to only clean content that doesn't already have non-linear
        /// Nielsen watermarks.
        /// </summary>
        public NielsenSourceWatermarkStatusType SourceWatermarkStatus
        {
            get { return this._sourceWatermarkStatus; }
            set { this._sourceWatermarkStatus = value; }
        }

        // Check to see if SourceWatermarkStatus property is set
        internal bool IsSetSourceWatermarkStatus()
        {
            return this._sourceWatermarkStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TicServerUrl. Specify the endpoint for the TIC server that
        /// you have deployed and configured in the AWS Cloud. Required for all Nielsen non-linear
        /// watermarking. MediaConvert can't connect directly to a TIC server. Instead, you must
        /// use API Gateway to provide a RESTful interface between MediaConvert and a TIC server
        /// that you deploy in your AWS account. For more information on deploying a TIC server
        /// in your AWS account and the required API Gateway, contact Nielsen support.
        /// </summary>
        public string TicServerUrl
        {
            get { return this._ticServerUrl; }
            set { this._ticServerUrl = value; }
        }

        // Check to see if TicServerUrl property is set
        internal bool IsSetTicServerUrl()
        {
            return this._ticServerUrl != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueTicPerAudioTrack. To create assets that have the
        /// same TIC values in each audio track, keep the default value Share TICs (SAME_TICS_PER_TRACK).
        /// To create assets that have unique TIC values for each audio track, choose Use unique
        /// TICs (RESERVE_UNIQUE_TICS_PER_TRACK).
        /// </summary>
        public NielsenUniqueTicPerAudioTrackType UniqueTicPerAudioTrack
        {
            get { return this._uniqueTicPerAudioTrack; }
            set { this._uniqueTicPerAudioTrack = value; }
        }

        // Check to see if UniqueTicPerAudioTrack property is set
        internal bool IsSetUniqueTicPerAudioTrack()
        {
            return this._uniqueTicPerAudioTrack != null;
        }

    }
}