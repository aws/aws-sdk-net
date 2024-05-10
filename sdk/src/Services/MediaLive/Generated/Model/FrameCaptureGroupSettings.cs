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
    /// Frame Capture Group Settings
    /// </summary>
    public partial class FrameCaptureGroupSettings
    {
        private OutputLocationRef _destination;
        private FrameCaptureCdnSettings _frameCaptureCdnSettings;

        /// <summary>
        /// Gets and sets the property Destination. The destination for the frame capture files.
        /// Either the URI for an Amazon S3 bucket and object, plus a file name prefix (for example,
        /// s3ssl://sportsDelivery/highlights/20180820/curling-) or the URI for a MediaStore container,
        /// plus a file name prefix (for example, mediastoressl://sportsDelivery/20180820/curling-).
        /// The final file names consist of the prefix from the destination field (for example,
        /// "curling-") + name modifier + the counter (5 digits, starting from 00001) + extension
        /// (which is always .jpg).  For example, curling-low.00001.jpg
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputLocationRef Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property FrameCaptureCdnSettings. Parameters that control interactions
        /// with the CDN.
        /// </summary>
        public FrameCaptureCdnSettings FrameCaptureCdnSettings
        {
            get { return this._frameCaptureCdnSettings; }
            set { this._frameCaptureCdnSettings = value; }
        }

        // Check to see if FrameCaptureCdnSettings property is set
        internal bool IsSetFrameCaptureCdnSettings()
        {
            return this._frameCaptureCdnSettings != null;
        }

    }
}