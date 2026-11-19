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
    /// Provides summary information about an operation that was performed on an enhanced
    /// snapshot.
    /// </summary>
    public partial class SnapshotOperationInfo
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp that indicates when the operation finished. This field is present only
        /// after the operation completes.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotOperation. 
        /// <para>
        /// The type of operation that was performed on the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnapshotOperation SnapshotOperation { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotOperation property is set.
        /// </summary>
        internal bool IsSetSnapshotOperation() => this.SnapshotOperation != null;

        /// <summary>
        /// Gets and sets the property SnapshotOperationId. 
        /// <para>
        /// The ID of the snapshot operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SnapshotOperationId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotOperationId property is set.
        /// </summary>
        internal bool IsSetSnapshotOperationId() => this.SnapshotOperationId != null;

        /// <summary>
        /// Gets and sets the property SnapshotOperationStatus. 
        /// <para>
        /// The status of the snapshot operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnapshotOperationStatus SnapshotOperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotOperationStatus property is set.
        /// </summary>
        internal bool IsSetSnapshotOperationStatus() => this.SnapshotOperationStatus != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp that indicates when the operation was created.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
