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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetJobBookmarks operation.
    /// </summary>
    public partial class GetJobBookmarksResponse : AmazonWebServiceResponse
    {
        private List<JobBookmarkEntry> _jobBookmarkEntries = new List<JobBookmarkEntry>();
        private int? _nextToken;

        /// <summary>
        /// Gets and sets the property JobBookmarkEntries. 
        /// <para>
        /// A list of job bookmark entries that defines a point that a job can resume processing.
        /// </para>
        /// </summary>
        public List<JobBookmarkEntry> JobBookmarkEntries
        {
            get { return this._jobBookmarkEntries; }
            set { this._jobBookmarkEntries = value; }
        }

        // Check to see if JobBookmarkEntries property is set
        internal bool IsSetJobBookmarkEntries()
        {
            return this._jobBookmarkEntries != null && this._jobBookmarkEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, which has a value of 1 if all the entries are returned, or &gt;
        /// 1 if not all requested job runs have been returned.
        /// </para>
        /// </summary>
        public int NextToken
        {
            get { return this._nextToken.GetValueOrDefault(); }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken.HasValue; 
        }

    }
}