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
    /// This is the response object from the ListFragments operation.
    /// </summary>
    public partial class ListFragmentsResponse : AmazonWebServiceResponse
    {
        private List<Fragment> _fragments = new List<Fragment>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Fragments. 
        /// <para>
        /// A list of archived <a>Fragment</a> objects from the stream that meet the selector
        /// criteria. Results are in no specific order, even across pages.
        /// </para>
        /// </summary>
        public List<Fragment> Fragments
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the returned list is truncated, the operation returns this token to use to retrieve
        /// the next page of results. This value is <code>null</code> when there are no more results
        /// to return.
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

    }
}