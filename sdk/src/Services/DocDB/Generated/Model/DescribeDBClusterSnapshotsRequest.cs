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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBClusterSnapshots operation.
    /// Returns information about cluster snapshots. This API operation supports pagination.
    /// </summary>
    public partial class DescribeDBClusterSnapshotsRequest : AmazonDocDBRequest
    {
        private string _dbClusterIdentifier;
        private string _dbClusterSnapshotIdentifier;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private bool? _includePublic;
        private bool? _includeShared;
        private string _marker;
        private int? _maxRecords;
        private string _snapshotType;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The ID of the cluster to retrieve the list of cluster snapshots for. This parameter
        /// can't be used with the <c>DBClusterSnapshotIdentifier</c> parameter. This parameter
        /// is not case sensitive. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If provided, must match the identifier of an existing <c>DBCluster</c>.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property DBClusterSnapshotIdentifier. 
        /// <para>
        /// A specific cluster snapshot identifier to describe. This parameter can't be used with
        /// the <c>DBClusterIdentifier</c> parameter. This value is stored as a lowercase string.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If provided, must match the identifier of an existing <c>DBClusterSnapshot</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If this identifier is for an automated snapshot, the <c>SnapshotType</c> parameter
        /// must also be specified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBClusterSnapshotIdentifier
        {
            get { return this._dbClusterSnapshotIdentifier; }
            set { this._dbClusterSnapshotIdentifier = value; }
        }

        // Check to see if DBClusterSnapshotIdentifier property is set
        internal bool IsSetDBClusterSnapshotIdentifier()
        {
            return this._dbClusterSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This parameter is not currently supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludePublic. 
        /// <para>
        /// Set to <c>true</c> to include manual cluster snapshots that are public and can be
        /// copied or restored by any Amazon Web Services account, and otherwise <c>false</c>.
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludePublic
        {
            get { return this._includePublic; }
            set { this._includePublic = value; }
        }

        // Check to see if IncludePublic property is set
        internal bool IsSetIncludePublic()
        {
            return this._includePublic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeShared. 
        /// <para>
        /// Set to <c>true</c> to include shared manual cluster snapshots from other Amazon Web
        /// Services accounts that this Amazon Web Services account has been given permission
        /// to copy or restore, and otherwise <c>false</c>. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeShared
        {
            get { return this._includeShared; }
            set { this._includeShared = value; }
        }

        // Check to see if IncludeShared property is set
        internal bool IsSetIncludeShared()
        {
            return this._includeShared.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <c>MaxRecords</c>.
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
        /// the specified <c>MaxRecords</c> value, a pagination token (marker) is included in
        /// the response so that the remaining results can be retrieved.
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
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of cluster snapshots to be returned. You can specify one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>automated</c> - Return all cluster snapshots that Amazon DocumentDB has automatically
        /// created for your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>manual</c> - Return all cluster snapshots that you have manually created for your
        /// Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>shared</c> - Return all manual cluster snapshots that have been shared to your
        /// Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public</c> - Return all cluster snapshots that have been marked as public.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a <c>SnapshotType</c> value, then both automated and manual cluster
        /// snapshots are returned. You can include shared cluster snapshots with these results
        /// by setting the <c>IncludeShared</c> parameter to <c>true</c>. You can include public
        /// cluster snapshots with these results by setting the<c>IncludePublic</c> parameter
        /// to <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>IncludeShared</c> and <c>IncludePublic</c> parameters don't apply for <c>SnapshotType</c>
        /// values of <c>manual</c> or <c>automated</c>. The <c>IncludePublic</c> parameter doesn't
        /// apply when <c>SnapshotType</c> is set to <c>shared</c>. The <c>IncludeShared</c> parameter
        /// doesn't apply when <c>SnapshotType</c> is set to <c>public</c>.
        /// </para>
        /// </summary>
        public string SnapshotType
        {
            get { return this._snapshotType; }
            set { this._snapshotType = value; }
        }

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this._snapshotType != null;
        }

    }
}