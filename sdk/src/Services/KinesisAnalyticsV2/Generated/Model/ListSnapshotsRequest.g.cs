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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListSnapshots operation. Lists the enhanced snapshots
    /// in your account. Snapshots are not scoped to an application. To list the snapshots
    /// that were created from a specific application, use the <c>SourceApplicationName</c>
    /// parameter. <para> You can specify only one of the following filters in a request:
    /// <c>SourceApplicationName</c>, <c>SnapshotInitiator</c>, <c>SnapshotInitiatorOperation</c>,
    /// or <c>SnapshotStatus</c>. If you specify more than one filter, <c>InvalidArgumentException</c>
    /// is returned. </para> <para> The results are sorted in descending order of snapshot
    /// creation timestamp. To get detailed information about a specific snapshot, use <c>DescribeSnapshot</c>.
    /// </para>
    /// </summary>
    public partial class ListSnapshotsRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of snapshots to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SnapshotInitiator. 
        /// <para>
        /// Use this parameter to list only the snapshots with the specified initiator.
        /// </para>
        /// </summary>
        public SnapshotInitiator SnapshotInitiator { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotInitiator property is set.
        /// </summary>
        internal bool IsSetSnapshotInitiator() => this.SnapshotInitiator != null;

        /// <summary>
        /// Gets and sets the property SnapshotInitiatorOperation. 
        /// <para>
        /// Use this parameter to list only the snapshots that were created by the specified operation.
        /// </para>
        /// </summary>
        public SnapshotInitiatorOperation SnapshotInitiatorOperation { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotInitiatorOperation property is set.
        /// </summary>
        internal bool IsSetSnapshotInitiatorOperation() => this.SnapshotInitiatorOperation != null;

        /// <summary>
        /// Gets and sets the property SnapshotStatus. 
        /// <para>
        /// Use this parameter to list only the snapshots with the specified status.
        /// </para>
        /// </summary>
        public SnapshotStatus SnapshotStatus { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotStatus property is set.
        /// </summary>
        internal bool IsSetSnapshotStatus() => this.SnapshotStatus != null;

        /// <summary>
        /// Gets and sets the property SourceApplicationName.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SourceApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceApplicationName property is set.
        /// </summary>
        internal bool IsSetSourceApplicationName() => this.SourceApplicationName != null;
    }
}
