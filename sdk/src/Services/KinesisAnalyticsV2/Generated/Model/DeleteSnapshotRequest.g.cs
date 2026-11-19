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
    /// Container for the parameters to the DeleteSnapshot operation. Deletes an enhanced
    /// snapshot. Snapshots are not scoped to an application, so you can delete a snapshot
    /// independently of the application that it was created from. <para> This operation is
    /// asynchronous. The response returns the snapshot ARN with the <c>DELETING</c> status.
    /// To track the progress of the operation, use <c>DescribeSnapshotOperation</c>. </para>
    /// <para> You can delete a snapshot in the <c>READY</c> or <c>FAILED</c> status. If a
    /// snapshot operation, such as an export, uses the snapshot, Managed Service for Apache
    /// Flink waits for that operation to finish before it deletes the snapshot. For a snapshot
    /// in any other status, <c>ResourceInUseException</c> is returned. </para>
    /// </summary>
    public partial class DeleteSnapshotRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property SnapshotCreationTimestamp. 
        /// <para>
        /// The creation timestamp of the enhanced snapshot to delete. Use the <c>DescribeSnapshot</c>
        /// operation to get this value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SnapshotCreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreationTimestamp property is set.
        /// </summary>
        internal bool IsSetSnapshotCreationTimestamp() => this.SnapshotCreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the enhanced snapshot to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;
    }
}
