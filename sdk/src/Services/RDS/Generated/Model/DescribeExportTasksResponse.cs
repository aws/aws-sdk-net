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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// This is the response object from the DescribeExportTasks operation.
    /// </summary>
    public partial class DescribeExportTasksResponse : AmazonWebServiceResponse
    {
        private List<ExportTask> _exportTasks = AWSConfigs.InitializeCollections ? new List<ExportTask>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property ExportTasks. 
        /// <para>
        /// Information about an export of a snapshot or cluster to Amazon S3.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExportTask> ExportTasks
        {
            get { return this._exportTasks; }
            set { this._exportTasks = value; }
        }

        // Check to see if ExportTasks property is set
        internal bool IsSetExportTasks()
        {
            return this._exportTasks != null && (this._exportTasks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token that can be used in a later <c>DescribeExportTasks</c> request.
        /// A marker is used for pagination to identify the location to begin output for the next
        /// response of <c>DescribeExportTasks</c>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}