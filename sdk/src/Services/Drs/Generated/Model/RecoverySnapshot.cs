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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
        private List<string> _ebsSnapshots = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _expectedTimestamp;
        private string _snapshotid;
        private string _sourceServerID;
        private string _timestamp;

        /// <summary>
        /// Gets and sets the property EbsSnapshots. 
        /// <para>
        /// A list of EBS snapshots.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EbsSnapshots
        {
            get { return this._ebsSnapshots; }
            set { this._ebsSnapshots = value; }
        }

        // Check to see if EbsSnapshots property is set
        internal bool IsSetEbsSnapshots()
        {
            return this._ebsSnapshots != null && (this._ebsSnapshots.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpectedTimestamp. 
        /// <para>
        /// The timestamp of when we expect the snapshot to be taken.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=32)]
        public string ExpectedTimestamp
        {
            get { return this._expectedTimestamp; }
            set { this._expectedTimestamp = value; }
        }

        // Check to see if ExpectedTimestamp property is set
        internal bool IsSetExpectedTimestamp()
        {
            return this._expectedTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotID. 
        /// <para>
        /// The ID of the Recovery Snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string SnapshotID
        {
            get { return this._snapshotid; }
            set { this._snapshotid = value; }
        }

        // Check to see if SnapshotID property is set
        internal bool IsSetSnapshotID()
        {
            return this._snapshotid != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The ID of the Source Server that the snapshot was taken for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The actual timestamp that the snapshot was taken.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

    }
}