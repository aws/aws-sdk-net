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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Ignore these settings unless you are using Nielsen non-linear watermarking. Specify
    /// the values that MediaConvert uses to generate and place Nielsen watermarks in your
    /// output audio. In addition to specifying these values, you also need to set up your
    /// cloud TIC server. These settings apply to every output in your job. The MediaConvert
    /// implementation is currently with the following Nielsen versions: Nielsen Watermark
    /// SDK Version 6.0.13 Nielsen NLM Watermark Engine Version 1.3.3 Nielsen Watermark Authenticator
    /// [SID_TIC] Version [7.0.0]
    /// </summary>
    public partial class NielsenNonLinearWatermarkSettings
    {
        /// <summary>
        /// Gets and sets the property ActiveWatermarkProcess. Choose the type of Nielsen watermarks
        /// that you want in your outputs. When you choose NAES 2 and NW, you must provide a value
        /// for the setting SID. When you choose CBET, you must provide a value for the setting
        /// CSID. When you choose NAES 2, NW, and CBET, you must provide values for both of these
        /// settings.
        /// </summary>
        public NielsenActiveWatermarkProcessType ActiveWatermarkProcess { get; set; }

        /// <summary>
        /// Checks to see if the ActiveWatermarkProcess property is set.
        /// </summary>
        internal bool IsSetActiveWatermarkProcess() => this.ActiveWatermarkProcess != null;

        /// <summary>
        /// Gets and sets the property AdiFilename. Optional. Use this setting when you want the
        /// service to include an ADI file in the Nielsen metadata .zip file. To provide an ADI
        /// file, store it in Amazon S3 and provide a URL to it here. The URL should be in the
        /// following format: S3://bucket/path/ADI-file. For more information about the metadata
        /// .zip file, see the setting Metadata destination.
        /// </summary>
        public string AdiFilename { get; set; }

        /// <summary>
        /// Checks to see if the AdiFilename property is set.
        /// </summary>
        internal bool IsSetAdiFilename() => this.AdiFilename != null;

        /// <summary>
        /// Gets and sets the property AssetId. Use the asset ID that you provide to Nielsen to
        /// uniquely identify this asset. Required for all Nielsen non-linear watermarking.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property AssetName. Use the asset name that you provide to Nielsen
        /// for this asset. Required for all Nielsen non-linear watermarking.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string AssetName { get; set; }

        /// <summary>
        /// Checks to see if the AssetName property is set.
        /// </summary>
        internal bool IsSetAssetName() => this.AssetName != null;

        /// <summary>
        /// Gets and sets the property CbetSourceId. Use the CSID that Nielsen provides to you.
        /// This CBET source ID should be unique to your Nielsen account but common to all of
        /// your output assets that have CBET watermarking. Required when you choose a value for
        /// the setting Watermark types that includes CBET.
        /// </summary>
        public string CbetSourceId { get; set; }

        /// <summary>
        /// Checks to see if the CbetSourceId property is set.
        /// </summary>
        internal bool IsSetCbetSourceId() => this.CbetSourceId != null;

        /// <summary>
        /// Gets and sets the property EpisodeId. Optional. If this asset uses an episode ID with
        /// Nielsen, provide it here.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string EpisodeId { get; set; }

        /// <summary>
        /// Checks to see if the EpisodeId property is set.
        /// </summary>
        internal bool IsSetEpisodeId() => this.EpisodeId != null;

        /// <summary>
        /// Gets and sets the property MetadataDestination. Specify the Amazon S3 location where
        /// you want MediaConvert to save your Nielsen non-linear metadata .zip file. This Amazon
        /// S3 bucket must be in the same Region as the one where you do your MediaConvert transcoding.
        /// If you want to include an ADI file in this .zip file, use the setting ADI file to
        /// specify it. MediaConvert delivers the Nielsen metadata .zip files only to your metadata
        /// destination Amazon S3 bucket. It doesn't deliver the .zip files to Nielsen. You are
        /// responsible for delivering the metadata .zip files to Nielsen.
        /// </summary>
        public string MetadataDestination { get; set; }

        /// <summary>
        /// Checks to see if the MetadataDestination property is set.
        /// </summary>
        internal bool IsSetMetadataDestination() => this.MetadataDestination != null;

        /// <summary>
        /// Gets and sets the property SourceId. Use the SID that Nielsen provides to you. This
        /// source ID should be unique to your Nielsen account but common to all of your output
        /// assets. Required for all Nielsen non-linear watermarking. This ID should be unique
        /// to your Nielsen account but common to all of your output assets. Required for all
        /// Nielsen non-linear watermarking.
        /// </summary>
        [AWSProperty(Min = 0, Max = 65534)]
        public int? SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId.HasValue;

        /// <summary>
        /// Gets and sets the property SourceWatermarkStatus. Required. Specify whether your source
        /// content already contains Nielsen non-linear watermarks. When you set this value to
        /// Watermarked, the service fails the job. Nielsen requires that you add non-linear watermarking
        /// to only clean content that doesn't already have non-linear Nielsen watermarks.
        /// </summary>
        public NielsenSourceWatermarkStatusType SourceWatermarkStatus { get; set; }

        /// <summary>
        /// Checks to see if the SourceWatermarkStatus property is set.
        /// </summary>
        internal bool IsSetSourceWatermarkStatus() => this.SourceWatermarkStatus != null;

        /// <summary>
        /// Gets and sets the property TicServerUrl. Specify the endpoint for the TIC server that
        /// you have deployed and configured in the AWS Cloud. Required for all Nielsen non-linear
        /// watermarking. MediaConvert can't connect directly to a TIC server. Instead, you must
        /// use API Gateway to provide a RESTful interface between MediaConvert and a TIC server
        /// that you deploy in your AWS account. For more information on deploying a TIC server
        /// in your AWS account and the required API Gateway, contact Nielsen support.
        /// </summary>
        public string TicServerUrl { get; set; }

        /// <summary>
        /// Checks to see if the TicServerUrl property is set.
        /// </summary>
        internal bool IsSetTicServerUrl() => this.TicServerUrl != null;

        /// <summary>
        /// Gets and sets the property UniqueTicPerAudioTrack. To create assets that have the
        /// same TIC values in each audio track, keep the default value Share TICs. To create
        /// assets that have unique TIC values for each audio track, choose Use unique TICs.
        /// </summary>
        public NielsenUniqueTicPerAudioTrackType UniqueTicPerAudioTrack { get; set; }

        /// <summary>
        /// Checks to see if the UniqueTicPerAudioTrack property is set.
        /// </summary>
        internal bool IsSetUniqueTicPerAudioTrack() => this.UniqueTicPerAudioTrack != null;
    }
}
