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
    /// Container for the parameters to the ListFragments operation.
    /// Returns a list of <a>Fragment</a> objects from the specified stream and start location
    /// within the archived data.
    /// </summary>
    public partial class ListFragmentsRequest : AmazonKinesisVideoArchivedMediaRequest
    {
        private FragmentSelector _fragmentSelector;
        private long? _maxResults;
        private string _nextToken;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property FragmentSelector. 
        /// <para>
        /// Describes the time stamp range and time stamp origin for the range of fragments to
        /// return.
        /// </para>
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
        /// is more than the value specified in <code>max-results</code>, then a <a>ListFragmentsOutput$NextToken</a>
        /// is provided in the output that you can use to resume pagination.
        /// </para>
        /// </summary>
        public long MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream from which to retrieve a fragment list.
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