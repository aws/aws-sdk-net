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
    /// Container for the parameters to the ListFragments operation.
    /// Returns a list of <a>Fragment</a> objects from the specified stream and timestamp
    /// range within the archived data.
    /// 
    ///  
    /// <para>
    /// Listing fragments is eventually consistent. This means that even if the producer receives
    /// an acknowledgment that a fragment is persisted, the result might not be returned immediately
    /// from a request to <c>ListFragments</c>. However, results are typically available in
    /// less than one second.
    /// </para>
    ///  <note> 
    /// <para>
    /// You must first call the <c>GetDataEndpoint</c> API to get an endpoint. Then send the
    /// <c>ListFragments</c> requests to this endpoint using the <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url
    /// parameter</a>. 
    /// </para>
    ///  </note> <important> 
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
    public partial class ListFragmentsRequest : AmazonKinesisVideoArchivedMediaRequest
    {
        private FragmentSelector _fragmentSelector;
        private long? _maxResults;
        private string _nextToken;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property FragmentSelector. 
        /// <para>
        /// Describes the timestamp range and timestamp origin for the range of fragments to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only required when the <c>NextToken</c> isn't passed in the API.
        /// </para>
        ///  </note>
        /// </summary>
        public FragmentSelector FragmentSelector
        {
            get { return this._fragmentSelector; }
            set { this._fragmentSelector = value; }
        }

        // Check to see if FragmentSelector property is set
        internal bool IsSetFragmentSelector()
        {
            return this._fragmentSelector != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The total number of fragments to return. If the total number of fragments available
        /// is more than the value specified in <c>max-results</c>, then a <a>ListFragmentsOutput$NextToken</a>
        /// is provided in the output that you can use to resume pagination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public long? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. This is the <a>ListFragmentsOutput$NextToken</a>
        /// from a previously truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream from which to retrieve a fragment list.
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
        /// The name of the stream from which to retrieve a fragment list. Specify either this
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