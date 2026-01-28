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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The encoding configuration to apply to the NDI® source when transcoding it to a transport
    /// stream for downstream distribution. You can choose between several predefined encoding
    /// profiles based on common use cases.
    /// </summary>
    public partial class EncodingConfig
    {
        private EncodingProfile _encodingProfile;
        private int? _videoMaxBitrate;

        /// <summary>
        /// Gets and sets the property EncodingProfile. 
        /// <para>
        ///  The encoding profile to use when transcoding the NDI source content to a transport
        /// stream. You can change this value while the flow is running. 
        /// </para>
        /// </summary>
        public EncodingProfile EncodingProfile
        {
            get { return this._encodingProfile; }
            set { this._encodingProfile = value; }
        }

        // Check to see if EncodingProfile property is set
        internal bool IsSetEncodingProfile()
        {
            return this._encodingProfile != null;
        }

        /// <summary>
        /// Gets and sets the property VideoMaxBitrate. 
        /// <para>
        ///  The maximum video bitrate to use when transcoding the NDI source to a transport stream.
        /// This parameter enables you to override the default video bitrate within the encoding
        /// profile's supported range. 
        /// </para>
        ///  
        /// <para>
        ///  The supported range is 10,000,000 - 50,000,000 bits per second (bps). If you don't
        /// specify a value, MediaConnect uses the default value of 20,000,000 bps. 
        /// </para>
        /// </summary>
        public int VideoMaxBitrate
        {
            get { return this._videoMaxBitrate.GetValueOrDefault(); }
            set { this._videoMaxBitrate = value; }
        }

        // Check to see if VideoMaxBitrate property is set
        internal bool IsSetVideoMaxBitrate()
        {
            return this._videoMaxBitrate.HasValue; 
        }

    }
}