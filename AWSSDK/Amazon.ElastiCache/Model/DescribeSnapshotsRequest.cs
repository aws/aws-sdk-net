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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSnapshots operation.
    /// <para>The <i>DescribeSnapshots</i> operation returns information about cache cluster snapshots. By default, <i>DescribeSnapshots</i> lists
    /// all of your snapshots; it can optionally describe a single snapshot, or just the snapshots associated with a particular cache
    /// cluster.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeSnapshots"/>
    public class DescribeSnapshotsRequest : AmazonWebServiceRequest
    {
        private string cacheClusterId;
        private string snapshotName;
        private string snapshotSource;
        private string marker;
        private int? maxRecords;

        /// <summary>
        /// A user-supplied cluster identifier. If this parameter is specified, only snapshots associated with that specific cache cluster will be
        /// described.
        ///  
        /// </summary>
        public string CacheClusterId
        {
            get { return this.cacheClusterId; }
            set { this.cacheClusterId = value; }
        }

        /// <summary>
        /// Sets the CacheClusterId property
        /// </summary>
        /// <param name="cacheClusterId">The value to set for the CacheClusterId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsRequest WithCacheClusterId(string cacheClusterId)
        {
            this.cacheClusterId = cacheClusterId;
            return this;
        }
            

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this.cacheClusterId != null;
        }

        /// <summary>
        /// A user-supplied name of the snapshot. If this parameter is specified, only this snapshot will be described.
        ///  
        /// </summary>
        public string SnapshotName
        {
            get { return this.snapshotName; }
            set { this.snapshotName = value; }
        }

        /// <summary>
        /// Sets the SnapshotName property
        /// </summary>
        /// <param name="snapshotName">The value to set for the SnapshotName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsRequest WithSnapshotName(string snapshotName)
        {
            this.snapshotName = snapshotName;
            return this;
        }
            

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this.snapshotName != null;
        }

        /// <summary>
        /// Indicates whether the snapshot is from an automatic backup (<c>automated</c>) or was created manually (<c>manual</c>).
        ///  
        /// </summary>
        public string SnapshotSource
        {
            get { return this.snapshotSource; }
            set { this.snapshotSource = value; }
        }

        /// <summary>
        /// Sets the SnapshotSource property
        /// </summary>
        /// <param name="snapshotSource">The value to set for the SnapshotSource property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsRequest WithSnapshotSource(string snapshotSource)
        {
            this.snapshotSource = snapshotSource;
            return this;
        }
            

        // Check to see if SnapshotSource property is set
        internal bool IsSetSnapshotSource()
        {
            return this.snapshotSource != null;
        }

        /// <summary>
        /// An optional marker returned from a prior request. Use this marker for pagination of results from this operation. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified by <i>MaxRecords</i>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more records exist than the specified <c>MaxRecords</c> value, a marker is
        /// included in the response so that the remaining results can be retrieved. Default: 50Constraints: minimum 20; maximum 50.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }
    }
}
    
