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
    /// Container for the parameters to the GetMediaForFragmentList operation.
    /// Gets media for a list of fragments (specified by fragment number) from the archived
    /// data in an Amazon Kinesis video stream.
    /// 
    ///  <note> 
    /// <para>
    /// You must first call the <c>GetDataEndpoint</c> API to get an endpoint. Then send the
    /// <c>GetMediaForFragmentList</c> requests to this endpoint using the <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url
    /// parameter</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// For limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
    /// Video Streams Limits</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// If an error is thrown after invoking a Kinesis Video Streams archived media API, in
    /// addition to the HTTP status code and the response body, it includes the following
    /// pieces of information: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>x-amz-ErrorType</c> HTTP header – contains a more specific error type in addition
    /// to what the HTTP status code provides. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>x-amz-RequestId</c> HTTP header – if you want to report an issue to Amazon Web
    /// Services, the support team can better diagnose the problem if given the Request Id.
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
    ///  </important>
    /// </summary>
    public partial class GetMediaForFragmentListRequest : AmazonKinesisVideoArchivedMediaRequest
    {
        private List<string> _fragments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property Fragments. 
        /// <para>
        /// A list of the numbers of fragments for which to retrieve media. You retrieve these
        /// values with <a>ListFragments</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public List<string> Fragments
        {
            get { return this._fragments; }
            set { this._fragments = value; }
        }

        // Check to see if Fragments property is set
        internal bool IsSetFragments()
        {
            return this._fragments != null && (this._fragments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream from which to retrieve fragment media.
        /// Specify either this parameter or the <c>StreamName</c> parameter.
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
        /// The name of the stream from which to retrieve fragment media. Specify either this
        /// parameter or the <c>StreamARN</c> parameter.
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