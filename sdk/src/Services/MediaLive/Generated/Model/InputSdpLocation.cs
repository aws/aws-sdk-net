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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// The location of the SDP file for one of the SMPTE 2110 streams in a receiver group.
    /// </summary>
    public partial class InputSdpLocation
    {
        private int? _mediaIndex;
        private string _sdpUrl;

        /// <summary>
        /// Gets and sets the property MediaIndex. The index of the media stream in the SDP file
        /// for one SMPTE 2110 stream.
        /// </summary>
        public int? MediaIndex
        {
            get { return this._mediaIndex; }
            set { this._mediaIndex = value; }
        }

        // Check to see if MediaIndex property is set
        internal bool IsSetMediaIndex()
        {
            return this._mediaIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SdpUrl. The URL of the SDP file for one SMPTE 2110 stream.
        /// </summary>
        public string SdpUrl
        {
            get { return this._sdpUrl; }
            set { this._sdpUrl = value; }
        }

        // Check to see if SdpUrl property is set
        internal bool IsSetSdpUrl()
        {
            return this._sdpUrl != null;
        }

    }
}