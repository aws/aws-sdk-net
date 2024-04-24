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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Watermarks can be in .png or .jpg format. If you want to display a watermark that
    /// is not rectangular, use the .png format, which supports transparency.
    /// </summary>
    public partial class JobWatermark
    {
        private Encryption _encryption;
        private string _inputKey;
        private string _presetWatermarkId;

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// The encryption settings, if any, that you want Elastic Transcoder to apply to your
        /// watermarks.
        /// </para>
        /// </summary>
        public Encryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property InputKey. 
        /// <para>
        ///  The name of the .png or .jpg file that you want to use for the watermark. To determine
        /// which Amazon S3 bucket contains the specified file, Elastic Transcoder checks the
        /// pipeline specified by <c>Pipeline</c>; the <c>Input Bucket</c> object in that pipeline
        /// identifies the bucket.
        /// </para>
        ///  
        /// <para>
        ///  If the file name includes a prefix, for example, <b>logos/128x64.png</b>, include
        /// the prefix in the key. If the file isn't in the specified bucket, Elastic Transcoder
        /// returns an error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        [AWSProperty(Min=1, Max=40)]
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