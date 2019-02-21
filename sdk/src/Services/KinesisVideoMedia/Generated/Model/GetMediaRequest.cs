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
    /// Container for the parameters to the GetMedia operation.
    /// Use this API to retrieve media content from a Kinesis video stream. In the request,
    /// you identify the stream name or stream Amazon Resource Name (ARN), and the starting
    /// chunk. Kinesis Video Streams then returns a stream of chunks in order by fragment
    /// number.
    /// 
    ///  <note> 
    /// <para>
    /// You must first call the <code>GetDataEndpoint</code> API to get an endpoint. Then
    /// send the <code>GetMedia</code> requests to this endpoint using the <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url
    /// parameter</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// When you put media data (fragments) on a stream, Kinesis Video Streams stores each
    /// incoming fragment and related metadata in what is called a "chunk." For more information,
    /// see . The <code>GetMedia</code> API returns a stream of these chunks starting from
    /// the chunk that you specify in the request. 
    /// </para>
    ///  
    /// <para>
    /// The following limits apply when using the <code>GetMedia</code> API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A client can call <code>GetMedia</code> up to five times per second per stream. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Kinesis Video Streams sends media data at a rate of up to 25 megabytes per second
    /// (or 200 megabits per second) during a <code>GetMedia</code> session. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetMediaRequest : AmazonKinesisVideoMediaRequest
    {
        private StartSelector _startSelector;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property StartSelector. 
        /// <para>
        /// Identifies the starting chunk to get from the specified stream. 
        /// </para>
        /// </summary>
        public StartSelector StartSelector
        {
            get { return this._startSelector; }
            set { this._startSelector = value; }
        }

        // Check to see if StartSelector property is set
        internal bool IsSetStartSelector()
        {
            return this._startSelector != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream from where you want to get the media content. If you don't specify
        /// the <code>streamARN</code>, you must specify the <code>streamName</code>.
        /// </para>
        /// </summary>
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The Kinesis video stream name from where you want to get the media content. If you
        /// don't specify the <code>streamName</code>, you must specify the <code>streamARN</code>.
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}