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

namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// A list of elastic cluster snapshots.
    /// </summary>
    public partial class ClusterSnapshotInList
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The ARN identifier of the elastic cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The ARN identifier of the elastic cluster snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SnapshotArn { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotArn property is set.
        /// </summary>
        internal bool IsSetSnapshotArn() => this.SnapshotArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotCreationTime. 
        /// <para>
        /// The time when the elastic cluster snapshot was created in Universal Coordinated Time
        /// (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SnapshotCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreationTime property is set.
        /// </summary>
        internal bool IsSetSnapshotCreationTime() => this.SnapshotCreationTime != null;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the elastic cluster snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the elastic cluster snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
