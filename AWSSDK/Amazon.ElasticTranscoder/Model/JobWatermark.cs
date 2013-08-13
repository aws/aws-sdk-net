/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>Watermarks can be in .png or .jpg format. If you want to display a watermark that is not rectangular, use the .png format, which
    /// supports transparency.</para>
    /// </summary>
    public class JobWatermark
    {
        
        private string presetWatermarkId;
        private string inputKey;

        /// <summary>
        /// The ID of the watermark settings that Elastic Transcoder uses to add watermarks to the video during transcoding. The settings are in the
        /// preset specified by Preset for the current output. In that preset, the value of Watermarks Id tells Elastic Transcoder which settings to
        /// use.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 40</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PresetWatermarkId
        {
            get { return this.presetWatermarkId; }
            set { this.presetWatermarkId = value; }
        }

        /// <summary>
        /// Sets the PresetWatermarkId property
        /// </summary>
        /// <param name="presetWatermarkId">The value to set for the PresetWatermarkId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobWatermark WithPresetWatermarkId(string presetWatermarkId)
        {
            this.presetWatermarkId = presetWatermarkId;
            return this;
        }
            

        // Check to see if PresetWatermarkId property is set
        internal bool IsSetPresetWatermarkId()
        {
            return this.presetWatermarkId != null;
        }

        /// <summary>
        /// The name of the .png or .jpg file that you want to use for the watermark. To determine which Amazon S3 bucket contains the specified file,
        /// Elastic Transcoder checks the pipeline specified by <c>Pipeline</c>; the <c>Input Bucket</c> object in that pipeline identifies the bucket.
        /// If the file name includes a prefix, for example, <b>logos/128x64.png</b>, include the prefix in the key. If the file isn't in the specified
        /// bucket, Elastic Transcoder returns an error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^.{1,}.jpg$)|(^.{1,}.jpeg$)|(^.{1,}.png$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InputKey
        {
            get { return this.inputKey; }
            set { this.inputKey = value; }
        }

        /// <summary>
        /// Sets the InputKey property
        /// </summary>
        /// <param name="inputKey">The value to set for the InputKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobWatermark WithInputKey(string inputKey)
        {
            this.inputKey = inputKey;
            return this;
        }
            

        // Check to see if InputKey property is set
        internal bool IsSetInputKey()
        {
            return this.inputKey != null;
        }
    }
}
