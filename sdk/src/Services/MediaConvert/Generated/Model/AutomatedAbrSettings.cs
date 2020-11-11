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
    /// Use automated ABR to have MediaConvert set up the renditions in your ABR package for
    /// you automatically, based on characteristics of your input video. This feature optimizes
    /// video quality while minimizing the overall size of your ABR package.
    /// </summary>
    public partial class AutomatedAbrSettings
    {
        private int? _maxAbrBitrate;
        private int? _maxRenditions;
        private int? _minAbrBitrate;

        /// <summary>
        /// Gets and sets the property MaxAbrBitrate. Optional. The maximum target bit rate used
        /// in your automated ABR stack. Use this value to set an upper limit on the bandwidth
        /// consumed by the highest-quality rendition. This is the rendition that is delivered
        /// to viewers with the fastest internet connections. If you don't specify a value, MediaConvert
        /// uses 8,000,000 (8 mb/s) by default.
        /// </summary>
        [AWSProperty(Min=100000, Max=100000000)]
        public int MaxAbrBitrate
        {
            get { return this._maxAbrBitrate.GetValueOrDefault(); }
            set { this._maxAbrBitrate = value; }
        }

        // Check to see if MaxAbrBitrate property is set
        internal bool IsSetMaxAbrBitrate()
        {
            return this._maxAbrBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRenditions. Optional. The maximum number of renditions
        /// that MediaConvert will create in your automated ABR stack. The number of renditions
        /// is determined automatically, based on analysis of each job, but will never exceed
        /// this limit. When you set this to Auto in the console, which is equivalent to excluding
        /// it from your JSON job specification, MediaConvert defaults to a limit of 15.
        /// </summary>
        [AWSProperty(Min=3, Max=15)]
        public int MaxRenditions
        {
            get { return this._maxRenditions.GetValueOrDefault(); }
            set { this._maxRenditions = value; }
        }

        // Check to see if MaxRenditions property is set
        internal bool IsSetMaxRenditions()
        {
            return this._maxRenditions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinAbrBitrate. Optional. The minimum target bitrate used
        /// in your automated ABR stack. Use this value to set a lower limit on the bitrate of
        /// video delivered to viewers with slow internet connections. If you don't specify a
        /// value, MediaConvert uses 600,000 (600 kb/s) by default.
        /// </summary>
        [AWSProperty(Min=100000, Max=100000000)]
        public int MinAbrBitrate
        {
            get { return this._minAbrBitrate.GetValueOrDefault(); }
            set { this._minAbrBitrate = value; }
        }

        // Check to see if MinAbrBitrate property is set
        internal bool IsSetMinAbrBitrate()
        {
            return this._minAbrBitrate.HasValue; 
        }

    }
}