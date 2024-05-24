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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// If you work with a third party video watermarking partner, use the group of settings
    /// that correspond with your watermarking partner to include watermarks in your output.
    /// </summary>
    public partial class PartnerWatermarking
    {
        private NexGuardFileMarkerSettings _nexguardFileMarkerSettings;

        /// <summary>
        /// Gets and sets the property NexguardFileMarkerSettings. For forensic video watermarking,
        /// MediaConvert supports Nagra NexGuard File Marker watermarking. MediaConvert supports
        /// both PreRelease Content (NGPR/G2) and OTT Streaming workflows.
        /// </summary>
        public NexGuardFileMarkerSettings NexguardFileMarkerSettings
        {
            get { return this._nexguardFileMarkerSettings; }
            set { this._nexguardFileMarkerSettings = value; }
        }

        // Check to see if NexguardFileMarkerSettings property is set
        internal bool IsSetNexguardFileMarkerSettings()
        {
            return this._nexguardFileMarkerSettings != null;
        }

    }
}