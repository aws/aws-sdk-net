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
 * Do not modify this file. This file is generated from the kinesis-video-media-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideoMedia.Model
{
    /// <summary>
    /// Identifies the chunk on the Kinesis video stream where you want the <c>GetMedia</c>
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
    /// fragment number or timestamp (server or producer). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each chunk's metadata includes a continuation token as a Matroska (MKV) tag (<c>AWS_KINESISVIDEO_CONTINUATION_TOKEN</c>).
    /// If your previous <c>GetMedia</c> request terminated, you can use this tag value in
    /// your next <c>GetMedia</c> request. The API then starts returning chunks starting where
    /// the last API ended.
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
        /// Specifies the fragment number from where you want the <c>GetMedia</c> API to start
        /// returning the fragments. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Continuation token that Kinesis Video Streams returned in the previous <c>GetMedia</c>
        /// response. The <c>GetMedia</c> API then starts with the chunk identified by the continuation
        /// token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// FRAGMENT_NUMBER - Start with the chunk after a specific fragment. You must also specify
        /// the <c>AfterFragmentNumber</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRODUCER_TIMESTAMP or SERVER_TIMESTAMP - Start with the chunk containing a fragment
        /// with the specified producer or server timestamp. You specify the timestamp by adding
        /// <c>StartTimestamp</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  CONTINUATION_TOKEN - Read using the specified continuation token. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you choose the NOW, EARLIEST, or CONTINUATION_TOKEN as the <c>startSelectorType</c>,
        /// you don't provide any additional information in the <c>startSelector</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A timestamp value. This value is required if you choose the PRODUCER_TIMESTAMP or
        /// the SERVER_TIMESTAMP as the <c>startSelectorType</c>. The <c>GetMedia</c> API then
        /// starts with the chunk containing the fragment that has the specified timestamp.
        /// </para>
        /// </summary>
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