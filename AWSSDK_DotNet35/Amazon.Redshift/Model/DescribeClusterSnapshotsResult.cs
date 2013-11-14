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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Contains the output from the DescribeClusterSnapshots action. </para>
    /// </summary>
    public partial class DescribeClusterSnapshotsResult : AmazonWebServiceResponse
    {
        
        private string marker;
        private List<Snapshot> snapshots = new List<Snapshot>();


        /// <summary>
        /// A marker that indicates the first snapshot that a subsequent <a>DescribeClusterSnapshots</a> request will return. The response returns a
        /// marker only if there are more snapshots to list than the current response can return.
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
        /// A list of <a>Snapshot</a> instances.
        ///  
        /// </summary>
        public List<Snapshot> Snapshots
        {
            get { return this.snapshots; }
            set { this.snapshots = value; }
        }

        // Check to see if Snapshots property is set
        internal bool IsSetSnapshots()
        {
            return this.snapshots.Count > 0;
        }
    }
}
