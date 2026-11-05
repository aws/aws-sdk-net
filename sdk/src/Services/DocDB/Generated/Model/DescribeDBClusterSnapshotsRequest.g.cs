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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBClusterSnapshots operation. Returns
    /// information about cluster snapshots. This API operation supports pagination.
    /// </summary>
    public partial class DescribeDBClusterSnapshotsRequest : AmazonDocDBRequest
    {
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
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

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
        public string DBClusterSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterSnapshotIdentifier() => this.DBClusterSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This parameter is not currently supported.
        /// </para>
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
        /// Gets and sets the property IncludePublic. 
        /// <para>
        /// Set to <c>true</c> to include manual cluster snapshots that are public and can be
        /// copied or restored by any Amazon Web Services account, and otherwise <c>false</c>.
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludePublic { get; set; }

        /// <summary>
        /// Checks to see if the IncludePublic property is set.
        /// </summary>
        internal bool IsSetIncludePublic() => this.IncludePublic.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeShared. 
        /// <para>
        /// Set to <c>true</c> to include shared manual cluster snapshots from other Amazon Web
        /// Services accounts that this Amazon Web Services account has been given permission
        /// to copy or restore, and otherwise <c>false</c>. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeShared { get; set; }

        /// <summary>
        /// Checks to see if the IncludeShared property is set.
        /// </summary>
        internal bool IsSetIncludeShared() => this.IncludeShared.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <c>MaxRecords</c>.
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
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

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
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;
    }
}
