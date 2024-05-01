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
    /// Container for the parameters to the GetMedia operation.
    /// Use this API to retrieve media content from a Kinesis video stream. In the request,
    /// you identify the stream name or stream Amazon Resource Name (ARN), and the starting
    /// chunk. Kinesis Video Streams then returns a stream of chunks in order by fragment
    /// number.
    /// 
    ///  <note> 
    /// <para>
    /// You must first call the <c>GetDataEndpoint</c> API to get an endpoint. Then send the
    /// <c>GetMedia</c> requests to this endpoint using the <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url
    /// parameter</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// When you put media data (fragments) on a stream, Kinesis Video Streams stores each
    /// incoming fragment and related metadata in what is called a "chunk." For more information,
    /// see <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_dataplane_PutMedia.html">PutMedia</a>.
    /// The <c>GetMedia</c> API returns a stream of these chunks starting from the chunk that
    /// you specify in the request. 
    /// </para>
    ///  
    /// <para>
    /// The following limits apply when using the <c>GetMedia</c> API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A client can call <c>GetMedia</c> up to five times per second per stream. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Kinesis Video Streams sends media data at a rate of up to 25 megabytes per second
    /// (or 200 megabits per second) during a <c>GetMedia</c> session. 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// If an error is thrown after invoking a Kinesis Video Streams media API, in addition
    /// to the HTTP status code and the response body, it includes the following pieces of
    /// information: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>x-amz-ErrorType</c> HTTP header – contains a more specific error type in addition
    /// to what the HTTP status code provides. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>x-amz-RequestId</c> HTTP header – if you want to report an issue to AWS, the support
    /// team can better diagnose the problem if given the Request Id.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Both the HTTP status code and the ErrorType header can be utilized to make programmatic
    /// decisions about whether errors are retry-able and under what conditions, as well as
    /// provide information on what actions the client programmer might need to take in order
    /// to successfully try again.
    /// </para>
    ///  
    /// <para>
    /// For more information, see the <b>Errors</b> section at the bottom of this topic, as
    /// well as <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/CommonErrors.html">Common
    /// Errors</a>. 
    /// </para>
    ///  </note>
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
        [AWSProperty(Required=true)]
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
        /// the <c>streamARN</c>, you must specify the <c>streamName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// don't specify the <c>streamName</c>, you must specify the <c>streamARN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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