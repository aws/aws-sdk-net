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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTableStatistics operation.
    /// Returns table statistics on the database migration task, including table name, rows
    /// inserted, rows updated, and rows deleted.
    /// 
    ///  
    /// <para>
    /// Note that the "last updated" column the DMS console only indicates the time that AWS
    /// DMS last updated the table statistics record for a table. It does not indicate the
    /// time of the last update to the table.
    /// </para>
    /// </summary>
    public partial class DescribeTableStatisticsRequest : AmazonDatabaseMigrationServiceRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private string _marker;
        private int? _maxRecords;
        private string _replicationTaskArn;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters applied to the describe table statistics action.
        /// </para>
        ///  
        /// <para>
        /// Valid filter names: schema-name | table-name | table-state
        /// </para>
        ///  
        /// <para>
        /// A combination of filters creates an AND condition where each record matches all specified
        /// filters.
        /// </para>
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
        ///  An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <code>MaxRecords</code>. 
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
        ///  The maximum number of records to include in the response. If more records exist than
        /// the specified <code>MaxRecords</code> value, a pagination token called a marker is
        /// included in the response so that the remaining results can be retrieved. 
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 20, maximum 500.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task.
        /// </para>
        /// </summary>
        public string ReplicationTaskArn
        {
            get { return this._replicationTaskArn; }
            set { this._replicationTaskArn = value; }
        }

        // Check to see if ReplicationTaskArn property is set
        internal bool IsSetReplicationTaskArn()
        {
            return this._replicationTaskArn != null;
        }

    }
}