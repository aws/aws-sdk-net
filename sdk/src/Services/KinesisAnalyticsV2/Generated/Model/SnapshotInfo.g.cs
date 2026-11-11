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
    /// Provides summary information about an enhanced snapshot.
    /// </summary>
    public partial class SnapshotInfo
    {
        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The ARN of the enhanced snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SnapshotArn { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotArn property is set.
        /// </summary>
        internal bool IsSetSnapshotArn() => this.SnapshotArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotCreationTimestamp. 
        /// <para>
        /// The timestamp that indicates when the snapshot was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SnapshotCreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreationTimestamp property is set.
        /// </summary>
        internal bool IsSetSnapshotCreationTimestamp() => this.SnapshotCreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotFormat. 
        /// <para>
        /// The format of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnapshotFormat SnapshotFormat { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotFormat property is set.
        /// </summary>
        internal bool IsSetSnapshotFormat() => this.SnapshotFormat != null;

        /// <summary>
        /// Gets and sets the property SnapshotInitiator. 
        /// <para>
        /// Indicates who initiated the snapshot. <c>USER</c> indicates a snapshot that you created
        /// or imported. <c>SYSTEM</c> indicates a snapshot that Managed Service for Apache Flink
        /// created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnapshotInitiator SnapshotInitiator { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotInitiator property is set.
        /// </summary>
        internal bool IsSetSnapshotInitiator() => this.SnapshotInitiator != null;

        /// <summary>
        /// Gets and sets the property SnapshotInitiatorOperation. 
        /// <para>
        /// The operation that created the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnapshotInitiatorOperation SnapshotInitiatorOperation { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotInitiatorOperation property is set.
        /// </summary>
        internal bool IsSetSnapshotInitiatorOperation() => this.SnapshotInitiatorOperation != null;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the enhanced snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property SnapshotStatus. 
        /// <para>
        /// The status of the enhanced snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
