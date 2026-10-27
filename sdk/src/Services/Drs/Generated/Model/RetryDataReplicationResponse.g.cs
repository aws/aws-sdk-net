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
    /// This is the response object from the RetryDataReplication operation.
    /// </summary>
    public partial class RetryDataReplicationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of the DRS agent installed on the source server
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
        /// The ARN of the Source Server.
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
        /// The Data Replication Info of the Source Server.
        /// </para>
        /// </summary>
        public DataReplicationInfo DataReplicationInfo { get; set; }

        /// <summary>
        /// Checks to see if the DataReplicationInfo property is set.
        /// </summary>
        internal bool IsSetDataReplicationInfo() => this.DataReplicationInfo != null;

        /// <summary>
        /// Gets and sets the property LastLaunchResult. 
        /// <para>
        /// The status of the last recovery launch of this Source Server.
        /// </para>
        /// </summary>
        public LastLaunchResult LastLaunchResult { get; set; }

        /// <summary>
        /// Checks to see if the LastLaunchResult property is set.
        /// </summary>
        internal bool IsSetLastLaunchResult() => this.LastLaunchResult != null;

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// The lifecycle information of this Source Server.
        /// </para>
        /// </summary>
        public LifeCycle LifeCycle { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycle property is set.
        /// </summary>
        internal bool IsSetLifeCycle() => this.LifeCycle != null;

        /// <summary>
        /// Gets and sets the property RecoveryInstanceId. 
        /// <para>
        /// The ID of the Recovery Instance associated with this Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 19)]
        public string RecoveryInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryInstanceId property is set.
        /// </summary>
        internal bool IsSetRecoveryInstanceId() => this.RecoveryInstanceId != null;

        /// <summary>
        /// Gets and sets the property ReplicationDirection. 
        /// <para>
        /// Replication direction of the Source Server.
        /// </para>
        /// </summary>
        public ReplicationDirection ReplicationDirection { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationDirection property is set.
        /// </summary>
        internal bool IsSetReplicationDirection() => this.ReplicationDirection != null;

        /// <summary>
        /// Gets and sets the property ReversedDirectionSourceServerArn. 
        /// <para>
        /// For EC2-originated Source Servers which have been failed over and then failed back,
        /// this value will mean the ARN of the Source Server on the opposite replication direction.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ReversedDirectionSourceServerArn { get; set; }

        /// <summary>
        /// Checks to see if the ReversedDirectionSourceServerArn property is set.
        /// </summary>
        internal bool IsSetReversedDirectionSourceServerArn() => this.ReversedDirectionSourceServerArn != null;

        /// <summary>
        /// Gets and sets the property SourceCloudProperties. 
        /// <para>
        /// Source cloud properties of the Source Server.
        /// </para>
        /// </summary>
        public SourceCloudProperties SourceCloudProperties { get; set; }

        /// <summary>
        /// Checks to see if the SourceCloudProperties property is set.
        /// </summary>
        internal bool IsSetSourceCloudProperties() => this.SourceCloudProperties != null;

        /// <summary>
        /// Gets and sets the property SourceNetworkID. 
        /// <para>
        /// ID of the Source Network which is protecting this Source Server's network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string SourceNetworkID { get; set; }

        /// <summary>
        /// Checks to see if the SourceNetworkID property is set.
        /// </summary>
        internal bool IsSetSourceNetworkID() => this.SourceNetworkID != null;

        /// <summary>
        /// Gets and sets the property SourceProperties. 
        /// <para>
        /// The source properties of the Source Server.
        /// </para>
        /// </summary>
        public SourceProperties SourceProperties { get; set; }

        /// <summary>
        /// Checks to see if the SourceProperties property is set.
        /// </summary>
        internal bool IsSetSourceProperties() => this.SourceProperties != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The ID of the Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;

        /// <summary>
        /// Gets and sets the property StagingArea. 
        /// <para>
        /// The staging area of the source server.
        /// </para>
        /// </summary>
        public StagingArea StagingArea { get; set; }

        /// <summary>
        /// Checks to see if the StagingArea property is set.
        /// </summary>
        internal bool IsSetStagingArea() => this.StagingArea != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the Source Server.
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
