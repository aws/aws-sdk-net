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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeDBSnapshotTenantDatabases operation. Describes
    /// the tenant databases that exist in a DB snapshot. This command only applies to RDS
    /// for Oracle DB instances in the multi-tenant configuration. <para> You can use this
    /// command to inspect the tenant databases within a snapshot before restoring it. You
    /// can't directly interact with the tenant databases in a DB snapshot. If you restore
    /// a snapshot that was taken from DB instance using the multi-tenant configuration, you
    /// restore all its tenant databases. </para>
    /// </summary>
    public partial class DescribeDBSnapshotTenantDatabasesRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The ID of the DB instance used to create the DB snapshots. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the identifier of an existing <c>DBInstance</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// The ID of a DB snapshot that contains the tenant databases to describe. This value
        /// is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify this parameter, the value must match the ID of an existing DB snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify an automatic snapshot, you must also specify <c>SnapshotType</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetDBSnapshotIdentifier() => this.DBSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// A specific DB resource identifier to describe.
        /// </para>
        /// </summary>
        public string DbiResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbiResourceId property is set.
        /// </summary>
        internal bool IsSetDbiResourceId() => this.DbiResourceId != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies one or more tenant databases to describe.
        /// </para>
        ///  
        /// <para>
        /// Supported filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tenant-db-name</c> - Tenant database names. The results list only includes information
        /// about the tenant databases that match these tenant DB names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tenant-database-resource-id</c> - Tenant database resource identifiers. The results
        /// list only includes information about the tenant databases contained within the DB
        /// snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dbi-resource-id</c> - DB instance resource identifiers. The results list only
        /// includes information about snapshots containing tenant databases contained within
        /// the DB instances identified by these resource identifiers.
        /// </para>
        ///  </li> <li> 
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
        ///  <c>snapshot-type</c> - Accepts types of DB snapshots.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <c>DescribeDBSnapshotTenantDatabases</c>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <c>MaxRecords</c> value, a pagination token called a marker is included
        /// in the response so that you can retrieve the remaining results.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of DB snapshots to be returned. You can specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>automated</c> – All DB snapshots that have been automatically taken by Amazon
        /// RDS for my Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>manual</c> – All DB snapshots that have been taken by my Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>shared</c> – All manual DB snapshots that have been shared to my Amazon Web Services
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public</c> – All DB snapshots that have been marked as public.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>awsbackup</c> – All DB snapshots managed by the Amazon Web Services Backup service.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;
    }
}
