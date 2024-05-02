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
    /// Details regarding output
    /// </summary>
    public partial class OutputDetail
    {
        private int? _durationInMs;
        private VideoDetail _videoDetails;

        /// <summary>
        /// Gets and sets the property DurationInMs. Duration in milliseconds
        /// </summary>
        public int? DurationInMs
        {
            get { return this._durationInMs; }
            set { this._durationInMs = value; }
        }

        // Check to see if DurationInMs property is set
        internal bool IsSetDurationInMs()
        {
            return this._durationInMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VideoDetails. Contains details about the output's video
        /// stream
        /// </summary>
        public VideoDetail VideoDetails
        {
            get { return this._videoDetails; }
            set { this._videoDetails = value; }
        }

        // Check to see if VideoDetails property is set
        internal bool IsSetVideoDetails()
        {
            return this._videoDetails != null;
        }

    }
}