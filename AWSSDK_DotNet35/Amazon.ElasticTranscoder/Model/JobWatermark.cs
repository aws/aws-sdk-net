/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Watermarks can be in .png or .jpg format. If you want to display a watermark that
    /// is not rectangular, use the .png format, which supports transparency.
    /// </summary>
    public partial class JobWatermark
    {
        private string _inputKey;
        private string _presetWatermarkId;

        /// <summary>
        /// Gets and sets the property InputKey. 
        /// <para>
        ///  The name of the .png or .jpg file that you want to use for the watermark. To determine
        /// which Amazon S3 bucket contains the specified file, Elastic Transcoder checks the
        /// pipeline specified by <code>Pipeline</code>; the <code>Input Bucket</code> object
        /// in that pipeline identifies the bucket.
        /// </para>
        ///  
        /// <para>
        ///  If the file name includes a prefix, for example, <b>logos/128x64.png</b>, include
        /// the prefix in the key. If the file isn't in the specified bucket, Elastic Transcoder
        /// returns an error. 
        /// </para>
        /// </summary>
        public string InputKey
        {
            get { return this._inputKey; }
            set { this._inputKey = value; }
        }

        // Check to see if InputKey property is set
        internal bool IsSetInputKey()
        {
            return this._inputKey != null;
        }

        /// <summary>
        /// Gets and sets the property PresetWatermarkId. 
        /// <para>
        /// The ID of the watermark settings that Elastic Transcoder uses to add watermarks to
        /// the video during transcoding. The settings are in the preset specified by Preset for
        /// the current output. In that preset, the value of Watermarks Id tells Elastic Transcoder
        /// which settings to use.
        /// </para>
        /// </summary>
        public string PresetWatermarkId
        {
            get { return this._presetWatermarkId; }
            set { this._presetWatermarkId = value; }
        }

        // Check to see if PresetWatermarkId property is set
        internal bool IsSetPresetWatermarkId()
        {
            return this._presetWatermarkId != null;
        }

    }
}