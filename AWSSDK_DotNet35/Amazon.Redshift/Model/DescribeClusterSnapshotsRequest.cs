/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusterSnapshots operation.
    /// <para> Returns one or more snapshot objects, which contain metadata about your cluster snapshots. By default, this operation returns
    /// information about all snapshots of all clusters that are owned by you AWS customer account. No information is returned for snapshots owned
    /// by inactive AWS customer accounts. </para>
    /// </summary>
    public partial class DescribeClusterSnapshotsRequest : AmazonRedshiftRequest
    {
        private string clusterIdentifier;
        private string snapshotIdentifier;
        private string snapshotType;
        private DateTime? startTime;
        private DateTime? endTime;
        private int? maxRecords;
        private string marker;
        private string ownerAccount;


        /// <summary>
        /// The identifier of the cluster for which information about snapshots is requested.
        ///  
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this.clusterIdentifier; }
            set { this.clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this.clusterIdentifier != null;
        }

        /// <summary>
        /// The snapshot identifier of the snapshot about which to return information.
        ///  
        /// </summary>
        public string SnapshotIdentifier
        {
            get { return this.snapshotIdentifier; }
            set { this.snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this.snapshotIdentifier != null;
        }

        /// <summary>
        /// The type of snapshots for which you are requesting information. By default, snapshots of all types are returned. Valid Values:
        /// <c>automated</c> | <c>manual</c>
        ///  
        /// </summary>
        public string SnapshotType
        {
            get { return this.snapshotType; }
            set { this.snapshotType = value; }
        }

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this.snapshotType != null;
        }

        /// <summary>
        /// A value that requests only snapshots created at or after the specified time. The time value is specified in ISO 8601 format. For more
        /// information about ISO 8601, go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601 Wikipedia page.</a> Example:
        /// <c>2012-07-16T18:00:00Z</c>
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;
        }

        /// <summary>
        /// A time value that requests only snapshots created at or before the specified time. The time value is specified in ISO 8601 format. For more
        /// information about ISO 8601, go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601 Wikipedia page.</a> Example:
        /// <c>2012-07-16T18:00:00Z</c>
        ///  
        /// </summary>
        public DateTime EndTime
        {
            get { return this.endTime ?? default(DateTime); }
            set { this.endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this.endTime.HasValue;
        }

        /// <summary>
        /// The maximum number of snapshot records to include in the response. If more records exist than the specified <c>MaxRecords</c> value, the
        /// response returns a marker that you can use in a subsequent <a>DescribeClusterSnapshots</a> request in order to retrieve the next set of
        /// snapshot records. Default: <c>100</c> Constraints: Must be at least 20 and no more than 100.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// An optional marker returned by a previous <a>DescribeClusterSnapshots</a> request to indicate the first snapshot that the request will
        /// return.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// The AWS customer account used to create or copy the snapshot. Use this field to filter the results to snapshots owned by a particular
        /// account. To describe snapshots you own, either specify your AWS customer account, or do not specify the parameter.
        ///  
        /// </summary>
        public string OwnerAccount
        {
            get { return this.ownerAccount; }
            set { this.ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this.ownerAccount != null;
        }

    }
}
    
