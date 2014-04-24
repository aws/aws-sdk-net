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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents the output of a <i>DescribeSnapshots</i> operation.</para>
    /// </summary>
    public partial class DescribeSnapshotsResult
    {
        
        private string marker;
        private List<Snapshot> snapshots = new List<Snapshot>();

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
        public DescribeSnapshotsResult WithMarker(string marker)
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
        /// A list of snapshots. Each item in the list contains detailed information about one snapshot.
        ///  
        /// </summary>
        public List<Snapshot> Snapshots
        {
            get { return this.snapshots; }
            set { this.snapshots = value; }
        }
        /// <summary>
        /// Adds elements to the Snapshots collection
        /// </summary>
        /// <param name="snapshots">The values to add to the Snapshots collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsResult WithSnapshots(params Snapshot[] snapshots)
        {
            foreach (Snapshot element in snapshots)
            {
                this.snapshots.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Snapshots collection
        /// </summary>
        /// <param name="snapshots">The values to add to the Snapshots collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotsResult WithSnapshots(IEnumerable<Snapshot> snapshots)
        {
            foreach (Snapshot element in snapshots)
            {
                this.snapshots.Add(element);
            }

            return this;
        }

        // Check to see if Snapshots property is set
        internal bool IsSetSnapshots()
        {
            return this.snapshots.Count > 0;
        }
    }
}
