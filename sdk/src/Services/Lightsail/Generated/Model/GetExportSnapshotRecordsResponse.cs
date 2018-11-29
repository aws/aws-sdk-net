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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetExportSnapshotRecords operation.
    /// </summary>
    public partial class GetExportSnapshotRecordsResponse : AmazonWebServiceResponse
    {
        private List<ExportSnapshotRecord> _exportSnapshotRecords = new List<ExportSnapshotRecord>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property ExportSnapshotRecords. 
        /// <para>
        /// A list of objects describing the export snapshot records.
        /// </para>
        /// </summary>
        public List<ExportSnapshotRecord> ExportSnapshotRecords
        {
            get { return this._exportSnapshotRecords; }
            set { this._exportSnapshotRecords = value; }
        }

        // Check to see if ExportSnapshotRecords property is set
        internal bool IsSetExportSnapshotRecords()
        {
            return this._exportSnapshotRecords != null && this._exportSnapshotRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// A token used for advancing to the next page of results of your get relational database
        /// bundles request.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}