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
    /// Container for the parameters to the DescribeDBClusterSnapshots operation.
    /// Returns information about DB cluster snapshots. This API action supports pagination.
    /// 
    ///  
    /// <para>
    /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
    /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeDBClusterSnapshotsRequest : AmazonRDSRequest
    {
        private string _dbClusterIdentifier;
        private string _dbClusterResourceId;
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
        /// The ID of the DB cluster to retrieve the list of DB cluster snapshots for. This parameter
        /// can't be used in conjunction with the <c>DBClusterSnapshotIdentifier</c> parameter.
        /// This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the identifier of an existing DBCluster.
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
        /// Gets and sets the property DbClusterResourceId. 
        /// <para>
        /// A specific DB cluster resource ID to describe.
        /// </para>
        /// </summary>
        public string DbClusterResourceId
        {
            get { return this._dbClusterResourceId; }
            set { this._dbClusterResourceId = value; }
        }

        // Check to see if DbClusterResourceId property is set
        internal bool IsSetDbClusterResourceId()
        {
            return this._dbClusterResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotIdentifier. 
        /// <para>
        /// A specific DB cluster snapshot identifier to describe. This parameter can't be used
        /// in conjunction with the <c>DBClusterIdentifier</c> parameter. This value is stored
        /// as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the identifier of an existing DBClusterSnapshot.
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
        /// A filter that specifies one or more DB cluster snapshots to describe.
        /// </para>
        ///  
        /// <para>
        /// Supported filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db-cluster-id</c> - Accepts DB cluster identifiers and DB cluster Amazon Resource
        /// Names (ARNs).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db-cluster-snapshot-id</c> - Accepts DB cluster snapshot identifiers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>snapshot-type</c> - Accepts types of DB cluster snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>engine</c> - Accepts names of database engines.
        /// </para>
        ///  </li> </ul>
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
        /// Specifies whether to include manual DB cluster snapshots that are public and can be
        /// copied or restored by any Amazon Web Services account. By default, the public snapshots
        /// are not included.
        /// </para>
        ///  
        /// <para>
        /// You can share a manual DB cluster snapshot as public by using the <a>ModifyDBClusterSnapshotAttribute</a>
        /// API action.
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
        /// Specifies whether to include shared manual DB cluster snapshots from other Amazon
        /// Web Services accounts that this Amazon Web Services account has been given permission
        /// to copy or restore. By default, these snapshots are not included.
        /// </para>
        ///  
        /// <para>
        /// You can give an Amazon Web Services account permission to restore a manual DB cluster
        /// snapshot from another Amazon Web Services account by the <c>ModifyDBClusterSnapshotAttribute</c>
        /// API action.
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
        /// An optional pagination token provided by a previous <c>DescribeDBClusterSnapshots</c>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by <c>MaxRecords</c>.
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
        /// the specified <c>MaxRecords</c> value, a pagination token called a marker is included
        /// in the response so you can retrieve the remaining results.
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
        /// The type of DB cluster snapshots to be returned. You can specify one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>automated</c> - Return all DB cluster snapshots that have been automatically taken
        /// by Amazon RDS for my Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>manual</c> - Return all DB cluster snapshots that have been taken by my Amazon
        /// Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>shared</c> - Return all manual DB cluster snapshots that have been shared to my
        /// Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public</c> - Return all DB cluster snapshots that have been marked as public.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a <c>SnapshotType</c> value, then both automated and manual DB
        /// cluster snapshots are returned. You can include shared DB cluster snapshots with these
        /// results by enabling the <c>IncludeShared</c> parameter. You can include public DB
        /// cluster snapshots with these results by enabling the <c>IncludePublic</c> parameter.
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