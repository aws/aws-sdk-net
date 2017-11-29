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
 * Do not modify this file. This file is generated from the kinesis-video-media-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideoMedia.Model
{
    /// <summary>
    /// Identifies the chunk on the Kinesis video stream where you want the <code>GetMedia</code>
    /// API to start returning media data. You have the following options to identify the
    /// starting chunk: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Choose the latest (or oldest) chunk.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Identify a specific chunk. You can identify a specific chunk either by providing a
    /// fragment number or time stamp (server or producer). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each chunk's metadata includes a continuation token as a Matroska (MKV) tag (<code>AWS_KINESISVIDEO_CONTINUATION_TOKEN</code>).
    /// If your previous <code>GetMedia</code> request terminated, you can use this tag value
    /// in your next <code>GetMedia</code> request. The API then starts returning chunks starting
    /// where the last API ended.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartSelector
    {
        private string _afterFragmentNumber;
        private string _continuationToken;
        private StartSelectorType _startSelectorType;
        private DateTime? _startTimestamp;

        /// <summary>
        /// Gets and sets the property AfterFragmentNumber. 
        /// <para>
        /// Specifies the fragment number from where you want the <code>GetMedia</code> API to
        /// start returning the fragments. 
        /// </para>
        /// </summary>
        public string AfterFragmentNumber
        {
            get { return this._afterFragmentNumber; }
            set { this._afterFragmentNumber = value; }
        }

        // Check to see if AfterFragmentNumber property is set
        internal bool IsSetAfterFragmentNumber()
        {
            return this._afterFragmentNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// Continuation token that Kinesis Video Streams returned in the previous <code>GetMedia</code>
        /// response. The <code>GetMedia</code> API then starts with the chunk identified by the
        /// continuation token.
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this._continuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property StartSelectorType. 
        /// <para>
        /// Identifies the fragment on the Kinesis video stream where you want to start getting
        /// the data from.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// NOW - Start with the latest chunk on the stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EARLIEST - Start with earliest available chunk on the stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FRAGMENT_NUMBER - Start with the chunk containing the specific fragment. You must
        /// also specify the <code>StartFragmentNumber</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRODUCER_TIMESTAMP or SERVER_TIMESTAMP - Start with the chunk containing a fragment
        /// with the specified producer or server time stamp. You specify the time stamp by adding
        /// <code>StartTimestamp</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  CONTINUATION_TOKEN - Read using the specified continuation token. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you choose the NOW, EARLIEST, or CONTINUATION_TOKEN as the <code>startSelectorType</code>,
        /// you don't provide any additional information in the <code>startSelector</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public StartSelectorType StartSelectorType
        {
            get { return this._startSelectorType; }
            set { this._startSelectorType = value; }
        }

        // Check to see if StartSelectorType property is set
        internal bool IsSetStartSelectorType()
        {
            return this._startSelectorType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// A time stamp value. This value is required if you choose the PRODUCER_TIMESTAMP or
        /// the SERVER_TIMESTAMP as the <code>startSelectorType</code>. The <code>GetMedia</code>
        /// API then starts with the chunk containing the fragment that has the specified time
        /// stamp.
        /// </para>
        /// </summary>
        public DateTime StartTimestamp
        {
            get { return this._startTimestamp.GetValueOrDefault(); }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

    }
}