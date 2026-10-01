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
    /// Output Group settings, including type
    /// </summary>
    public partial class OutputGroupSettings
    {
        /// <summary>
        /// Gets and sets the property CmafGroupSettings. Settings related to your CMAF output
        /// package. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/outputs-file-ABR.html.
        /// </summary>
        public CmafGroupSettings CmafGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the CmafGroupSettings property is set.
        /// </summary>
        internal bool IsSetCmafGroupSettings() => this.CmafGroupSettings != null;

        /// <summary>
        /// Gets and sets the property DashIsoGroupSettings. Settings related to your DASH output
        /// package. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/outputs-file-ABR.html.
        /// </summary>
        public DashIsoGroupSettings DashIsoGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the DashIsoGroupSettings property is set.
        /// </summary>
        internal bool IsSetDashIsoGroupSettings() => this.DashIsoGroupSettings != null;

        /// <summary>
        /// Gets and sets the property FileGroupSettings. Settings related to your File output
        /// group. MediaConvert uses this group of settings to generate a single standalone file,
        /// rather than a streaming package.
        /// </summary>
        public FileGroupSettings FileGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the FileGroupSettings property is set.
        /// </summary>
        internal bool IsSetFileGroupSettings() => this.FileGroupSettings != null;

        /// <summary>
        /// Gets and sets the property HlsGroupSettings. Settings related to your HLS output package.
        /// For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/outputs-file-ABR.html.
        /// </summary>
        public HlsGroupSettings HlsGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsGroupSettings property is set.
        /// </summary>
        internal bool IsSetHlsGroupSettings() => this.HlsGroupSettings != null;

        /// <summary>
        /// Gets and sets the property MsSmoothGroupSettings. Settings related to your Microsoft
        /// Smooth Streaming output package. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/outputs-file-ABR.html.
        /// </summary>
        public MsSmoothGroupSettings MsSmoothGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the MsSmoothGroupSettings property is set.
        /// </summary>
        internal bool IsSetMsSmoothGroupSettings() => this.MsSmoothGroupSettings != null;

        /// <summary>
        /// Gets and sets the property PerFrameMetrics. Optionally choose one or more per frame
        /// metric reports to generate along with your output. You can use these metrics to analyze
        /// your video output according to one or more commonly used image quality metrics. You
        /// can specify per frame metrics for output groups or for individual outputs. When you
        /// do, MediaConvert writes a CSV (Comma-Separated Values) file to your S3 output destination,
        /// named after the output name and metric type. For example: videofile_PSNR.csv Jobs
        /// that generate per frame metrics will take longer to complete, depending on the resolution
        /// and complexity of your output. For example, some 4K jobs might take up to twice as
        /// long to complete. Note that when analyzing the video quality of your output, or when
        /// comparing the video quality of multiple different outputs, we generally also recommend
        /// a detailed visual review in a controlled environment. You can choose from the following
        /// per frame metrics: * PSNR: Peak Signal-to-Noise Ratio * SSIM: Structural Similarity
        /// Index Measure * MS_SSIM: Multi-Scale Similarity Index Measure * PSNR_HVS: Peak Signal-to-Noise
        /// Ratio, Human Visual System * VMAF: Video Multi-Method Assessment Fusion * QVBR: Quality-Defined
        /// Variable Bitrate. This option is only available when your output uses the QVBR rate
        /// control mode. * SHOT_CHANGE: Shot Changes
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PerFrameMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PerFrameMetrics property is set.
        /// </summary>
        internal bool IsSetPerFrameMetrics() => this.PerFrameMetrics != null && (this.PerFrameMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. Type of output group (File group, Apple HLS, DASH
        /// ISO, Microsoft Smooth Streaming, CMAF)
        /// </summary>
        public OutputGroupType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
