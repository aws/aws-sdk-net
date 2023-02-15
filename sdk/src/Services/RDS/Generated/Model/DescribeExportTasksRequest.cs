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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeExportTasks operation.
    /// Returns information about a snapshot or cluster export to Amazon S3. This API operation
    /// supports pagination.
    /// </summary>
    public partial class DescribeExportTasksRequest : AmazonRDSRequest
    {
        private string _exportTaskIdentifier;
        private List<Filter> _filters = new List<Filter>();
        private string _marker;
        private int? _maxRecords;
        private string _sourceArn;
        private ExportSourceType _sourceType;

        /// <summary>
        /// Gets and sets the property ExportTaskIdentifier. 
        /// <para>
        /// The identifier of the snapshot or cluster export task to be described.
        /// </para>
        /// </summary>
        public string ExportTaskIdentifier
        {
            get { return this._exportTaskIdentifier; }
            set { this._exportTaskIdentifier = value; }
        }

        // Check to see if ExportTaskIdentifier property is set
        internal bool IsSetExportTaskIdentifier()
        {
            return this._exportTaskIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters specify one or more snapshot or cluster exports to describe. The filters are
        /// specified as name-value pairs that define what to include in the output. Filter names
        /// and values are case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Supported filters include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>export-task-identifier</code> - An identifier for the snapshot or cluster export
        /// task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3-bucket</code> - The Amazon S3 bucket the data is exported to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>source-arn</code> - The Amazon Resource Name (ARN) of the snapshot or cluster
        /// exported to Amazon S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status</code> - The status of the export task. Must be lowercase. Valid statuses
        /// are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>canceled</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>canceling</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>complete</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>failed</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>in_progress</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>starting</code> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <code>DescribeExportTasks</code>
        /// request. If you specify this parameter, the response includes only records beyond
        /// the marker, up to the value specified by the <code>MaxRecords</code> parameter.
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

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified value, a pagination token called a marker is included in the response.
        /// You can use the marker in a later <code>DescribeExportTasks</code> request to retrieve
        /// the remaining results.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 20, maximum 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=100)]
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot or cluster exported to Amazon S3.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of source for the export.
        /// </para>
        /// </summary>
        public ExportSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}