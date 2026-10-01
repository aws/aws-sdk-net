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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Request data replication info.
    /// </summary>
    public partial class DataReplicationInfo
    {
        /// <summary>
        /// Gets and sets the property DataReplicationError. 
        /// <para>
        /// Error in obtaining data replication info.
        /// </para>
        /// </summary>
        public DataReplicationError DataReplicationError { get; set; }

        /// <summary>
        /// Checks to see if the DataReplicationError property is set.
        /// </summary>
        internal bool IsSetDataReplicationError() => this.DataReplicationError != null;

        /// <summary>
        /// Gets and sets the property DataReplicationInitiation. 
        /// <para>
        /// Request to query whether data replication has been initiated.
        /// </para>
        /// </summary>
        public DataReplicationInitiation DataReplicationInitiation { get; set; }

        /// <summary>
        /// Checks to see if the DataReplicationInitiation property is set.
        /// </summary>
        internal bool IsSetDataReplicationInitiation() => this.DataReplicationInitiation != null;

        /// <summary>
        /// Gets and sets the property DataReplicationState. 
        /// <para>
        /// Request to query the data replication state.
        /// </para>
        /// </summary>
        public DataReplicationState DataReplicationState { get; set; }

        /// <summary>
        /// Checks to see if the DataReplicationState property is set.
        /// </summary>
        internal bool IsSetDataReplicationState() => this.DataReplicationState != null;

        /// <summary>
        /// Gets and sets the property EtaDateTime. 
        /// <para>
        /// Request to query the time when data replication will be complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string EtaDateTime { get; set; }

        /// <summary>
        /// Checks to see if the EtaDateTime property is set.
        /// </summary>
        internal bool IsSetEtaDateTime() => this.EtaDateTime != null;

        /// <summary>
        /// Gets and sets the property LagDuration. 
        /// <para>
        /// Request to query data replication lag duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string LagDuration { get; set; }

        /// <summary>
        /// Checks to see if the LagDuration property is set.
        /// </summary>
        internal bool IsSetLagDuration() => this.LagDuration != null;

        /// <summary>
        /// Gets and sets the property LastSnapshotDateTime. 
        /// <para>
        /// Request to query data replication last snapshot time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string LastSnapshotDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSnapshotDateTime property is set.
        /// </summary>
        internal bool IsSetLastSnapshotDateTime() => this.LastSnapshotDateTime != null;

        /// <summary>
        /// Gets and sets the property ReplicatedDisks. 
        /// <para>
        /// Request to query disks replicated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public List<DataReplicationInfoReplicatedDisk> ReplicatedDisks { get; set; } = AWSConfigs.InitializeCollections ? new List<DataReplicationInfoReplicatedDisk>() : null;

        /// <summary>
        /// Checks to see if the ReplicatedDisks property is set.
        /// </summary>
        internal bool IsSetReplicatedDisks() => this.ReplicatedDisks != null && (this.ReplicatedDisks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicatorId. 
        /// <para>
        /// Replication server instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string ReplicatorId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicatorId property is set.
        /// </summary>
        internal bool IsSetReplicatorId() => this.ReplicatorId != null;
    }
}
