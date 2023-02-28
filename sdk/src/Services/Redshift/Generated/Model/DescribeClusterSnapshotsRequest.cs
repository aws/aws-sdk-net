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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusterSnapshots operation.
    /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
    /// By default, this operation returns information about all snapshots of all clusters
    /// that are owned by your Amazon Web Services account. No information is returned for
    /// snapshots owned by inactive Amazon Web Services accounts.
    /// 
    ///  
    /// <para>
    /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
    /// all snapshots that match any combination of the specified keys and values. For example,
    /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
    /// and <code>test</code> for tag values, all snapshots that have any combination of those
    /// values are returned. Only snapshots that you own are returned in the response; shared
    /// snapshots are not returned with the tag key and tag value request parameters.
    /// </para>
    ///  
    /// <para>
    /// If both tag keys and values are omitted from the request, snapshots are returned regardless
    /// of whether they have tag keys or values associated with them.
    /// </para>
    /// </summary>
    public partial class DescribeClusterSnapshotsRequest : AmazonRedshiftRequest
    {
        private bool? _clusterExists;
        private string _clusterIdentifier;
        private DateTime? _endTimeUtc;
        private string _marker;
        private int? _maxRecords;
        private string _ownerAccount;
        private string _snapshotArn;
        private string _snapshotIdentifier;
        private string _snapshotType;
        private List<SnapshotSortingEntity> _sortingEntities = new List<SnapshotSortingEntity>();
        private DateTime? _startTimeUtc;
        private List<string> _tagKeys = new List<string>();
        private List<string> _tagValues = new List<string>();

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
        /// If <code>ClusterExists</code> is set to <code>true</code>, <code>ClusterIdentifier</code>
        /// is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>ClusterExists</code> is set to <code>false</code> and <code>ClusterIdentifier</code>
        /// isn't specified, all snapshots associated with deleted clusters (orphaned snapshots)
        /// are returned. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>ClusterExists</code> is set to <code>false</code> and <code>ClusterIdentifier</code>
        /// is specified for a deleted cluster, snapshots associated with that cluster are returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>ClusterExists</code> is set to <code>false</code> and <code>ClusterIdentifier</code>
        /// is specified for an existing cluster, no snapshots are returned. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool ClusterExists
        {
            get { return this._clusterExists.GetValueOrDefault(); }
            set { this._clusterExists = value; }
        }

        // Check to see if ClusterExists property is set
        internal bool IsSetClusterExists()
        {
            return this._clusterExists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster which generated the requested snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// A time value that requests only snapshots created at or before the specified time.
        /// The time value is specified in ISO 8601 format. For more information about ISO 8601,
        /// go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601 Wikipedia page.</a>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>2012-07-16T18:00:00Z</code> 
        /// </para>
        /// </summary>
        public DateTime EndTimeUtc
        {
            get { return this._endTimeUtc.GetValueOrDefault(); }
            set { this._endTime = this._endTimeUtc = value; }
        }

        // Check to see if EndTimeUtc property is set
        internal bool IsSetEndTimeUtc()
        {
            return this._endTimeUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeClusterSnapshots</a> request exceed the
        /// value specified in <code>MaxRecords</code>, Amazon Web Services returns a value in
        /// the <code>Marker</code> field of the response. You can retrieve the next set of response
        /// records by providing the returned marker value in the <code>Marker</code> parameter
        /// and retrying the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified <code>MaxRecords</code> value, a value is returned
        /// in a <code>marker</code> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned marker value. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>100</code> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20, maximum 500.
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
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The Amazon Web Services account used to create or copy the snapshot. Use this field
        /// to filter the results to snapshots owned by a particular account. To describe snapshots
        /// you own, either specify your Amazon Web Services account, or do not specify the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot associated with the message to describe
        /// cluster snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotArn
        {
            get { return this._snapshotArn; }
            set { this._snapshotArn = value; }
        }

        // Check to see if SnapshotArn property is set
        internal bool IsSetSnapshotArn()
        {
            return this._snapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The snapshot identifier of the snapshot about which to return information.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of snapshots for which you are requesting information. By default, snapshots
        /// of all types are returned.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>automated</code> | <code>manual</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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

        /// <summary>
        /// Gets and sets the property SortingEntities.
        /// </summary>
        public List<SnapshotSortingEntity> SortingEntities
        {
            get { return this._sortingEntities; }
            set { this._sortingEntities = value; }
        }

        // Check to see if SortingEntities property is set
        internal bool IsSetSortingEntities()
        {
            return this._sortingEntities != null && this._sortingEntities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// A value that requests only snapshots created at or after the specified time. The time
        /// value is specified in ISO 8601 format. For more information about ISO 8601, go to
        /// the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601 Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>2012-07-16T18:00:00Z</code> 
        /// </para>
        /// </summary>
        public DateTime StartTimeUtc
        {
            get { return this._startTimeUtc.GetValueOrDefault(); }
            set { this._startTime = this._startTimeUtc = value; }
        }

        // Check to see if StartTimeUtc property is set
        internal bool IsSetStartTimeUtc()
        {
            return this._startTimeUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A tag key or keys for which you want to return all matching cluster snapshots that
        /// are associated with the specified key or keys. For example, suppose that you have
        /// snapshots that are tagged with keys called <code>owner</code> and <code>environment</code>.
        /// If you specify both of these tag keys in the request, Amazon Redshift returns a response
        /// with the snapshots that have either or both of these tag keys associated with them.
        /// </para>
        /// </summary>
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagValues. 
        /// <para>
        /// A tag value or values for which you want to return all matching cluster snapshots
        /// that are associated with the specified tag value or values. For example, suppose that
        /// you have snapshots that are tagged with values called <code>admin</code> and <code>test</code>.
        /// If you specify both of these tag values in the request, Amazon Redshift returns a
        /// response with the snapshots that have either or both of these tag values associated
        /// with them.
        /// </para>
        /// </summary>
        public List<string> TagValues
        {
            get { return this._tagValues; }
            set { this._tagValues = value; }
        }

        // Check to see if TagValues property is set
        internal bool IsSetTagValues()
        {
            return this._tagValues != null && this._tagValues.Count > 0; 
        }

#region Backwards compatible properties
        private DateTime? _endTime;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use EndTimeUtc instead. Setting either EndTime or EndTimeUtc
        /// results in both EndTime and EndTimeUtc being assigned, the latest assignment to either
        /// one of the two property is reflected in the value of both. EndTime is provided for
        /// backwards compatibility only and assigning a non-Utc DateTime to it results in the
        /// wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// A time value that requests only snapshots created at or before the specified time.
        /// The time value is specified in ISO 8601 format. For more information about ISO 8601,
        /// go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601 Wikipedia page.</a>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>2012-07-16T18:00:00Z</code> 
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use EndTimeUtc instead. Setting either EndTime or EndTimeUtc results in both EndTime and " +
            "EndTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. EndTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set
            {
                this._endTime = value;
                this._endTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use StartTimeUtc instead. Setting either StartTime or
        /// StartTimeUtc results in both StartTime and StartTimeUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. StartTime
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// A value that requests only snapshots created at or after the specified time. The time
        /// value is specified in ISO 8601 format. For more information about ISO 8601, go to
        /// the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601 Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>2012-07-16T18:00:00Z</code> 
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use StartTimeUtc instead. Setting either StartTime or StartTimeUtc results in both StartTime and " +
            "StartTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. StartTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set
            {
                this._startTime = value;
                this._startTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}