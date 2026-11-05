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
    /// Information about Data Replication
    /// </summary>
    public partial class DataReplicationInfo
    {
        /// <summary>
        /// Gets and sets the property DataReplicationError. 
        /// <para>
        /// Error in data replication.
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
        /// Information about whether the data replication has been initiated.
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
        /// The state of the data replication.
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
        /// An estimate of when the data replication will be completed.
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
        /// Data replication lag duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string LagDuration { get; set; }

        /// <summary>
        /// Checks to see if the LagDuration property is set.
        /// </summary>
        internal bool IsSetLagDuration() => this.LagDuration != null;

        /// <summary>
        /// Gets and sets the property ReplicatedDisks. 
        /// <para>
        /// The disks that should be replicated.
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
        /// Gets and sets the property StagingAvailabilityZone. 
        /// <para>
        /// AWS Availability zone into which data is being replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string StagingAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the StagingAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetStagingAvailabilityZone() => this.StagingAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property StagingOutpostArn. 
        /// <para>
        /// The ARN of the staging Outpost
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 255)]
        public string StagingOutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the StagingOutpostArn property is set.
        /// </summary>
        internal bool IsSetStagingOutpostArn() => this.StagingOutpostArn != null;
    }
}
