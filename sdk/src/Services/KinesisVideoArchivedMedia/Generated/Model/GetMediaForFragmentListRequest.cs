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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// Container for the parameters to the GetMediaForFragmentList operation.
    /// Gets media for a list of fragments (specified by fragment number) from the archived
    /// data in a Kinesis video stream.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is only available for the AWS SDK for Java. It is not supported in
    /// AWS SDKs for other languages.
    /// </para>
    ///  </note> 
    /// <para>
    /// The following limits apply when using the <code>GetMediaForFragmentList</code> API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A client can call <code>GetMediaForFragmentList</code> up to five times per second
    /// per stream. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Kinesis Video Streams sends media data at a rate of up to 25 megabytes per second
    /// (or 200 megabits per second) during a <code>GetMediaForFragmentList</code> session.
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetMediaForFragmentListRequest : AmazonKinesisVideoArchivedMediaRequest
    {
        private List<string> _fragments = new List<string>();
        private string _streamName;

        /// <summary>
        /// Gets and sets the property Fragments. 
        /// <para>
        /// A list of the numbers of fragments for which to retrieve media. You retrieve these
        /// values with <a>ListFragments</a>.
        /// </para>
        /// </summary>
        public List<string> Fragments
        {
            get { return this._fragments; }
            set { this._fragments = value; }
        }

        // Check to see if Fragments property is set
        internal bool IsSetFragments()
        {
            return this._fragments != null && this._fragments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream from which to retrieve fragment media.
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