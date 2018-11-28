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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// This is the response object from the ListApplicationSnapshots operation.
    /// </summary>
    public partial class ListApplicationSnapshotsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SnapshotDetails> _snapshotSummaries = new List<SnapshotDetails>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or <code>null</code> if there are no additional
        /// results.
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
        /// Gets and sets the property SnapshotSummaries. 
        /// <para>
        /// A collection of objects containing information about the application snapshots.
        /// </para>
        /// </summary>
        public List<SnapshotDetails> SnapshotSummaries
        {
            get { return this._snapshotSummaries; }
            set { this._snapshotSummaries = value; }
        }

        // Check to see if SnapshotSummaries property is set
        internal bool IsSetSnapshotSummaries()
        {
            return this._snapshotSummaries != null && this._snapshotSummaries.Count > 0; 
        }

    }
}