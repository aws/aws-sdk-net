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
    /// Container for the parameters to the DescribeDBSnapshots operation.
    /// Returns information about DB snapshots. This API action supports pagination.
    /// </summary>
    public partial class DescribeDBSnapshotsRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private string _dbiResourceId;
        private string _dbSnapshotIdentifier;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private bool? _includePublic;
        private bool? _includeShared;
        private string _marker;
        private int? _maxRecords;
        private string _snapshotType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeDBSnapshotsRequest() { }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The ID of the DB instance to retrieve the list of DB snapshots for. This parameter
        /// isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the identifier of an existing DBInstance.
        /// </para>
        ///  </li> </ul>
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
        /// A specific DB resource ID to describe.
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
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// A specific DB snapshot identifier to describe. This value is stored as a lowercase
        /// string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the identifier of an existing DBSnapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If this identifier is for an automated snapshot, the <c>SnapshotType</c> parameter
        /// must also be specified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this._dbSnapshotIdentifier; }
            set { this._dbSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this._dbSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies one or more DB snapshots to describe.
        /// </para>
        ///  
        /// <para>
        /// Supported filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db-instance-id</c> - Accepts DB instance identifiers and DB instance Amazon Resource
        /// Names (ARNs).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db-snapshot-id</c> - Accepts DB snapshot identifiers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dbi-resource-id</c> - Accepts identifiers of source DB instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>snapshot-type</c> - Accepts types of DB snapshots.
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
        /// You can share a manual DB snapshot as public by using the <a>ModifyDBSnapshotAttribute</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
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
        /// You can give an Amazon Web Services account permission to restore a manual DB snapshot
        /// from another Amazon Web Services account by using the <c>ModifyDBSnapshotAttribute</c>
        /// API action.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
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
        /// An optional pagination token provided by a previous <c>DescribeDBSnapshots</c> request.
        /// If this parameter is specified, the response includes only records beyond the marker,
        /// up to the value specified by <c>MaxRecords</c>.
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
        /// in the response so that you can retrieve the remaining results.
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
        /// The type of snapshots to be returned. You can specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>automated</c> - Return all DB snapshots that have been automatically taken by
        /// Amazon RDS for my Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>manual</c> - Return all DB snapshots that have been taken by my Amazon Web Services
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>shared</c> - Return all manual DB snapshots that have been shared to my Amazon
        /// Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public</c> - Return all DB snapshots that have been marked as public.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>awsbackup</c> - Return the DB snapshots managed by the Amazon Web Services Backup
        /// service.
        /// </para>
        ///  
        /// <para>
        /// For information about Amazon Web Services Backup, see the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/whatisbackup.html">
        /// <i>Amazon Web Services Backup Developer Guide.</i> </a> 
        /// </para>
        ///  
        /// <para>
        /// The <c>awsbackup</c> type does not apply to Aurora.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a <c>SnapshotType</c> value, then both automated and manual snapshots
        /// are returned. Shared and public DB snapshots are not included in the returned results
        /// by default. You can include shared snapshots with these results by enabling the <c>IncludeShared</c>
        /// parameter. You can include public snapshots with these results by enabling the <c>IncludePublic</c>
        /// parameter.
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