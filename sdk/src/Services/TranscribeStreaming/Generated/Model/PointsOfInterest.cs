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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Contains the timestamps of matched categories.
    /// </summary>
    public partial class PointsOfInterest
    {
        private List<TimestampRange> _timestampRanges = AWSConfigs.InitializeCollections ? new List<TimestampRange>() : null;

        /// <summary>
        /// Gets and sets the property TimestampRanges. 
        /// <para>
        /// Contains the timestamp ranges (start time through end time) of matched categories
        /// and rules.
        /// </para>
        /// </summary>
        public List<TimestampRange> TimestampRanges
        {
            get { return this._timestampRanges; }
            set { this._timestampRanges = value; }
        }

        // Check to see if TimestampRanges property is set
        internal bool IsSetTimestampRanges()
        {
            return this._timestampRanges != null && (this._timestampRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}