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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// A list of Elastic DocumentDB snapshots.
    /// </summary>
    public partial class ClusterSnapshotInList
    {
        private string _clusterArn;
        private string _snapshotArn;
        private string _snapshotCreationTime;
        private string _snapshotName;
        private Status _status;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The arn of the Elastic DocumentDB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The arn of the Elastic DocumentDB snapshot
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SnapshotCreationTime. 
        /// <para>
        /// The time when the Elastic DocumentDB snapshot was created in Universal Coordinated
        /// Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotCreationTime
        {
            get { return this._snapshotCreationTime; }
            set { this._snapshotCreationTime = value; }
        }

        // Check to see if SnapshotCreationTime property is set
        internal bool IsSetSnapshotCreationTime()
        {
            return this._snapshotCreationTime != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the Elastic DocumentDB snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Elastic DocumentDB snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}