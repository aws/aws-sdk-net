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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// A snapshot of a Source Server used during recovery.
    /// </summary>
    public partial class RecoverySnapshot
    {
        /// <summary>
        /// Gets and sets the property EbsSnapshots. 
        /// <para>
        /// A list of EBS snapshots.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EbsSnapshots { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EbsSnapshots property is set.
        /// </summary>
        internal bool IsSetEbsSnapshots() => this.EbsSnapshots != null && (this.EbsSnapshots.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExpectedTimestamp. 
        /// <para>
        /// The timestamp of when we expect the snapshot to be taken.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 32)]
        public string ExpectedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedTimestamp property is set.
        /// </summary>
        internal bool IsSetExpectedTimestamp() => this.ExpectedTimestamp != null;

        /// <summary>
        /// Gets and sets the property SnapshotID. 
        /// <para>
        /// The ID of the Recovery Snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 21, Max = 21)]
        public string SnapshotID { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotID property is set.
        /// </summary>
        internal bool IsSetSnapshotID() => this.SnapshotID != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The ID of the Source Server that the snapshot was taken for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The actual timestamp that the snapshot was taken.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp != null;
    }
}
