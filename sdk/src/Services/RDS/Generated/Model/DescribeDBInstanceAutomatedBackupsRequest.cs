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
    /// Container for the parameters to the DescribeDBInstanceAutomatedBackups operation.
    /// Displays backups for both current and deleted instances. For example, use this operation
    /// to find details about automated backups for previously deleted instances. Current
    /// instances with retention periods greater than zero (0) are returned for both the <code>DescribeDBInstanceAutomatedBackups</code>
    /// and <code>DescribeDBInstances</code> operations.
    /// 
    ///  
    /// <para>
    /// All parameters are optional.
    /// </para>
    /// </summary>
    public partial class DescribeDBInstanceAutomatedBackupsRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private string _dbiResourceId;
        private List<Filter> _filters = new List<Filter>();
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// (Optional) The user-supplied instance identifier. If this parameter is specified,
        /// it must match the identifier of an existing DB instance. It returns information from
        /// the specific DB instance' automated backup. This parameter isn't case-sensitive. 
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The resource ID of the DB instance that is the source of the automated backup. This
        /// parameter isn't case-sensitive. 
        /// </para>
        /// </summary>
        public string DbiResourceId
        {
            get { return this._dbiResourceId; }
            set { this._dbiResourceId = value; }
        }

        // Check to see if DbiResourceId property is set
        internal bool IsSetDbiResourceId()
        {
            return this._dbiResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies which resources to return based on status.
        /// </para>
        ///  
        /// <para>
        /// Supported filters are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>status</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>active</code> - automated backups for current instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>retained</code> - automated backups for deleted instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>creating</code> - automated backups that are waiting for the first automated
        /// snapshot to be available
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>db-instance-id</code> - Accepts DB instance identifiers and Amazon Resource
        /// Names (ARNs) for DB instances. The results list includes only information about the
        /// DB instance automated backupss identified by these ARNs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dbi-resource-id</code> - Accepts DB instance resource identifiers and DB Amazon
        /// Resource Names (ARNs) for DB instances. The results list includes only information
        /// about the DB instance resources identified by these ARNs.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Returns all resources by default. The status for each resource is specified in the
        /// response.
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
        /// The pagination token provided in the previous request. If this parameter is specified
        /// the response includes only records beyond the marker, up to <code>MaxRecords</code>.
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