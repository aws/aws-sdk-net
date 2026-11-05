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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusterSnapshots operation. Returns one
    /// or more snapshot objects, which contain metadata about your cluster snapshots. By
    /// default, this operation returns information about all snapshots of all clusters that
    /// are owned by your Amazon Web Services account. No information is returned for snapshots
    /// owned by inactive Amazon Web Services accounts. <para> If you specify both tag keys
    /// and tag values in the same request, Amazon Redshift returns all snapshots that match
    /// any combination of the specified keys and values. For example, if you have <c>owner</c>
    /// and <c>environment</c> for tag keys, and <c>admin</c> and <c>test</c> for tag values,
    /// all snapshots that have any combination of those values are returned. Only snapshots
    /// that you own are returned in the response; shared snapshots are not returned with
    /// the tag key and tag value request parameters. </para> <para> If both tag keys and
    /// values are omitted from the request, snapshots are returned regardless of whether
    /// they have tag keys or values associated with them. </para>
    /// </summary>
    public partial class DescribeClusterSnapshotsRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterExists. 
        /// <para>
        /// A value that indicates whether to return snapshots only for an existing cluster. You
        /// can perform table-level restore only by using a snapshot of an existing cluster, that
        /// is, a cluster that has not been deleted. Values for this parameter work as follows:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>ClusterExists</c> is set to <c>true</c>, <c>ClusterIdentifier</c> is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>ClusterExists</c> is set to <c>false</c> and <c>ClusterIdentifier</c> isn't
        /// specified, all snapshots associated with deleted clusters (orphaned snapshots) are
        /// returned. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>ClusterExists</c> is set to <c>false</c> and <c>ClusterIdentifier</c> is specified
        /// for a deleted cluster, snapshots associated with that cluster are returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>ClusterExists</c> is set to <c>false</c> and <c>ClusterIdentifier</c> is specified
        /// for an existing cluster, no snapshots are returned. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? ClusterExists { get; set; }

        /// <summary>
        /// Checks to see if the ClusterExists property is set.
        /// </summary>
        internal bool IsSetClusterExists() => this.ClusterExists.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster which generated the requested snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A time value that requests only snapshots created at or before the specified time.
        /// The time value is specified in ISO 8601 format. For more information about ISO 8601,
        /// go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601 Wikipedia page.</a>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>2012-07-16T18:00:00Z</c> 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeClusterSnapshots</a> request exceed the
        /// value specified in <c>MaxRecords</c>, Amazon Web Services returns a value in the <c>Marker</c>
        /// field of the response. You can retrieve the next set of response records by providing
        /// the returned marker value in the <c>Marker</c> parameter and retrying the request.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified <c>MaxRecords</c> value, a value is returned
        /// in a <c>marker</c> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned marker value. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>100</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The Amazon Web Services account used to create or copy the snapshot. Use this field
        /// to filter the results to snapshots owned by a particular account. To describe snapshots
        /// you own, either specify your Amazon Web Services account, or do not specify the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot associated with the message to describe
        /// cluster snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotArn { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotArn property is set.
        /// </summary>
        internal bool IsSetSnapshotArn() => this.SnapshotArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The snapshot identifier of the snapshot about which to return information.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetSnapshotIdentifier() => this.SnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of snapshots for which you are requesting information. By default, snapshots
        /// of all types are returned.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>automated</c> | <c>manual</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;

        /// <summary>
        /// Gets and sets the property SortingEntities. 
        /// <para>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SnapshotSortingEntity> SortingEntities { get; set; } = AWSConfigs.InitializeCollections ? new List<SnapshotSortingEntity>() : null;

        /// <summary>
        /// Checks to see if the SortingEntities property is set.
        /// </summary>
        internal bool IsSetSortingEntities() => this.SortingEntities != null && (this.SortingEntities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A value that requests only snapshots created at or after the specified time. The time
        /// value is specified in ISO 8601 format. For more information about ISO 8601, go to
        /// the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601 Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>2012-07-16T18:00:00Z</c> 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A tag key or keys for which you want to return all matching cluster snapshots that
        /// are associated with the specified key or keys. For example, suppose that you have
        /// snapshots that are tagged with keys called <c>owner</c> and <c>environment</c>. If
        /// you specify both of these tag keys in the request, Amazon Redshift returns a response
        /// with the snapshots that have either or both of these tag keys associated with them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagKeys property is set.
        /// </summary>
        internal bool IsSetTagKeys() => this.TagKeys != null && (this.TagKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagValues. 
        /// <para>
        /// A tag value or values for which you want to return all matching cluster snapshots
        /// that are associated with the specified tag value or values. For example, suppose that
        /// you have snapshots that are tagged with values called <c>admin</c> and <c>test</c>.
        /// If you specify both of these tag values in the request, Amazon Redshift returns a
        /// response with the snapshots that have either or both of these tag values associated
        /// with them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagValues property is set.
        /// </summary>
        internal bool IsSetTagValues() => this.TagValues != null && (this.TagValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
