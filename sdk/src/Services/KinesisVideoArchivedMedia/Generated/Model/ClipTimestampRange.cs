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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// The range of timestamps for which to return fragments.
    /// </summary>
    public partial class ClipTimestampRange
    {
        private DateTime? _endTimestamp;
        private DateTime? _startTimestamp;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The end of the timestamp range for the requested media.
        /// </para>
        ///  
        /// <para>
        /// This value must be within 24 hours of the specified <c>StartTimestamp</c>, and it
        /// must be later than the <c>StartTimestamp</c> value. If <c>FragmentSelectorType</c>
        /// for the request is <c>SERVER_TIMESTAMP</c>, this value must be in the past. 
        /// </para>
        ///  
        /// <para>
        /// This value is inclusive. The <c>EndTimestamp</c> is compared to the (starting) timestamp
        /// of the fragment. Fragments that start before the <c>EndTimestamp</c> value and continue
        /// past it are included in the session. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTimestamp
        {
            get { return this._endTimestamp; }
            set { this._endTimestamp = value; }
        }

        // Check to see if EndTimestamp property is set
        internal bool IsSetEndTimestamp()
        {
            return this._endTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The starting timestamp in the range of timestamps for which to return fragments. 
        /// </para>
        ///  
        /// <para>
        /// Only fragments that start exactly at or after <c>StartTimestamp</c> are included in
        /// the session. Fragments that start before <c>StartTimestamp</c> and continue past it
        /// aren't included in the session. If <c>FragmentSelectorType</c> is <c>SERVER_TIMESTAMP</c>,
        /// the <c>StartTimestamp</c> must be later than the stream head. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

    }
}