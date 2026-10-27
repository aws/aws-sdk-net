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
    /// A Recovery Instance is a replica of a Source Server running on EC2.
    /// </summary>
    public partial class RecoveryInstance
    {
        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of the DRS agent installed on the recovery instance
        /// </para>
        /// </summary>
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DataReplicationInfo. 
        /// <para>
        /// The Data Replication Info of the Recovery Instance.
        /// </para>
        /// </summary>
        public RecoveryInstanceDataReplicationInfo DataReplicationInfo { get; set; }

        /// <summary>
        /// Checks to see if the DataReplicationInfo property is set.
        /// </summary>
        internal bool IsSetDataReplicationInfo() => this.DataReplicationInfo != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceID. 
        /// <para>
        /// The EC2 instance ID of the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Ec2InstanceID { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceID property is set.
        /// </summary>
        internal bool IsSetEc2InstanceID() => this.Ec2InstanceID != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceState. 
        /// <para>
        /// The state of the EC2 instance for this Recovery Instance.
        /// </para>
        /// </summary>
        public EC2InstanceState Ec2InstanceState { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceState property is set.
        /// </summary>
        internal bool IsSetEc2InstanceState() => this.Ec2InstanceState != null;

        /// <summary>
        /// Gets and sets the property Failback. 
        /// <para>
        /// An object representing failback related information of the Recovery Instance.
        /// </para>
        /// </summary>
        public RecoveryInstanceFailback Failback { get; set; }

        /// <summary>
        /// Checks to see if the Failback property is set.
        /// </summary>
        internal bool IsSetFailback() => this.Failback != null;

        /// <summary>
        /// Gets and sets the property IsDrill. 
        /// <para>
        /// Whether this Recovery Instance was created for a drill or for an actual Recovery event.
        /// </para>
        /// </summary>
        public bool? IsDrill { get; set; }

        /// <summary>
        /// Checks to see if the IsDrill property is set.
        /// </summary>
        internal bool IsSetIsDrill() => this.IsDrill.HasValue;

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The ID of the Job that created the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 24, Max = 24)]
        public string JobID { get; set; }

        /// <summary>
        /// Checks to see if the JobID property is set.
        /// </summary>
        internal bool IsSetJobID() => this.JobID != null;

        /// <summary>
        /// Gets and sets the property OriginAvailabilityZone. 
        /// <para>
        /// AWS availability zone associated with the recovery instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string OriginAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the OriginAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetOriginAvailabilityZone() => this.OriginAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property OriginEnvironment. 
        /// <para>
        /// Environment (On Premises / AWS) of the instance that the recovery instance originated
        /// from.
        /// </para>
        /// </summary>
        public OriginEnvironment OriginEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the OriginEnvironment property is set.
        /// </summary>
        internal bool IsSetOriginEnvironment() => this.OriginEnvironment != null;

        /// <summary>
        /// Gets and sets the property PointInTimeSnapshotDateTime. 
        /// <para>
        /// The date and time of the Point in Time (PIT) snapshot that this Recovery Instance
        /// was launched from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string PointInTimeSnapshotDateTime { get; set; }

        /// <summary>
        /// Checks to see if the PointInTimeSnapshotDateTime property is set.
        /// </summary>
        internal bool IsSetPointInTimeSnapshotDateTime() => this.PointInTimeSnapshotDateTime != null;

        /// <summary>
        /// Gets and sets the property RecoveryInstanceID. 
        /// <para>
        /// The ID of the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 19)]
        public string RecoveryInstanceID { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryInstanceID property is set.
        /// </summary>
        internal bool IsSetRecoveryInstanceID() => this.RecoveryInstanceID != null;

        /// <summary>
        /// Gets and sets the property RecoveryInstanceProperties. 
        /// <para>
        /// Properties of the Recovery Instance machine.
        /// </para>
        /// </summary>
        public RecoveryInstanceProperties RecoveryInstanceProperties { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryInstanceProperties property is set.
        /// </summary>
        internal bool IsSetRecoveryInstanceProperties() => this.RecoveryInstanceProperties != null;

        /// <summary>
        /// Gets and sets the property SourceOutpostArn. 
        /// <para>
        /// The ARN of the source Outpost
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 255)]
        public string SourceOutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceOutpostArn property is set.
        /// </summary>
        internal bool IsSetSourceOutpostArn() => this.SourceOutpostArn != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The Source Server ID that this Recovery Instance is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags that are associated with the Recovery Instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
