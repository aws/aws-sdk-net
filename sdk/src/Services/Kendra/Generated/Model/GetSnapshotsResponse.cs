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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the GetSnapshots operation.
    /// </summary>
    public partial class GetSnapshotsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<List<string>> _snapshotsData = new List<List<string>>();
        private List<string> _snapshotsDataHeader = new List<string>();
        private TimeRange _snapShotTimeFilter;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Kendra returns this token, which you can use
        /// in a later request to retrieve the next set of search metrics data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
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
        /// Gets and sets the property SnapshotsData. 
        /// <para>
        /// The search metrics data. The data returned depends on the metric type you requested.
        /// </para>
        /// </summary>
        public List<List<string>> SnapshotsData
        {
            get { return this._snapshotsData; }
            set { this._snapshotsData = value; }
        }

        // Check to see if SnapshotsData property is set
        internal bool IsSetSnapshotsData()
        {
            return this._snapshotsData != null && this._snapshotsData.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotsDataHeader. 
        /// <para>
        /// The column headers for the search metrics data.
        /// </para>
        /// </summary>
        public List<string> SnapshotsDataHeader
        {
            get { return this._snapshotsDataHeader; }
            set { this._snapshotsDataHeader = value; }
        }

        // Check to see if SnapshotsDataHeader property is set
        internal bool IsSetSnapshotsDataHeader()
        {
            return this._snapshotsDataHeader != null && this._snapshotsDataHeader.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnapShotTimeFilter. 
        /// <para>
        /// The Unix timestamp for the beginning and end of the time window for the search metrics
        /// data.
        /// </para>
        /// </summary>
        public TimeRange SnapShotTimeFilter
        {
            get { return this._snapShotTimeFilter; }
            set { this._snapShotTimeFilter = value; }
        }

        // Check to see if SnapShotTimeFilter property is set
        internal bool IsSetSnapShotTimeFilter()
        {
            return this._snapShotTimeFilter != null;
        }

    }
}