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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBClusterBacktracks operation.
    /// Returns information about backtracks for a DB cluster.
    /// 
    ///  
    /// <para>
    /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
    /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class DescribeDBClusterBacktracksRequest : AmazonRDSRequest
    {
        private string _backtrackIdentifier;
        private string _dbClusterIdentifier;
        private List<Filter> _filters = new List<Filter>();
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property BacktrackIdentifier. 
        /// <para>
        /// If specified, this value is the backtrack identifier of the backtrack to be described.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain a valid universally unique identifier (UUID). For more information about
        /// UUIDs, see <a href="http://www.ietf.org/rfc/rfc4122.txt">A Universally Unique Identifier
        /// (UUID) URN Namespace</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>123e4567-e89b-12d3-a456-426655440000</code> 
        /// </para>
        /// </summary>
        public string BacktrackIdentifier
        {
            get { return this._backtrackIdentifier; }
            set { this._backtrackIdentifier = value; }
        }

        // Check to see if BacktrackIdentifier property is set
        internal bool IsSetBacktrackIdentifier()
        {
            return this._backtrackIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier of the DB cluster to be described. This parameter is stored
        /// as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>my-cluster1</code> 
        /// </para>
        /// </summary>
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies one or more DB clusters to describe. Supported filters include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>db-cluster-backtrack-id</code> - Accepts backtrack identifiers. The results
        /// list includes information about only the backtracks identified by these identifiers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db-cluster-backtrack-status</code> - Accepts any of the following backtrack
        /// status values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>applying</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>completed</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>failed</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The results list includes information about only the backtracks identified by these
        /// values. For more information about backtrack status values, see <a>DBClusterBacktrack</a>.
        /// </para>
        ///  </li> </ul>
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
        ///  An optional pagination token provided by a previous <a>DescribeDBClusterBacktracks</a>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by <code>MaxRecords</code>. 
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
        /// the specified <code>MaxRecords</code> value, a pagination token called a marker is
        /// included in the response so that the remaining results can be retrieved. 
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

    }
}