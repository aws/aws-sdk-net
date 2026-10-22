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
    /// The ARN of the Source Network.
    /// </summary>
    public partial class SourceNetwork
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CfnStackName. 
        /// <para>
        /// CloudFormation stack name that was deployed for recovering the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string CfnStackName { get; set; }

        /// <summary>
        /// Checks to see if the CfnStackName property is set.
        /// </summary>
        internal bool IsSetCfnStackName() => this.CfnStackName != null;

        /// <summary>
        /// Gets and sets the property LastRecovery. 
        /// <para>
        /// An object containing information regarding the last recovery of the Source Network.
        /// </para>
        /// </summary>
        public RecoveryLifeCycle LastRecovery { get; set; }

        /// <summary>
        /// Checks to see if the LastRecovery property is set.
        /// </summary>
        internal bool IsSetLastRecovery() => this.LastRecovery != null;

        /// <summary>
        /// Gets and sets the property LaunchedVpcID. 
        /// <para>
        /// ID of the recovered VPC following Source Network recovery.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 21)]
        public string LaunchedVpcID { get; set; }

        /// <summary>
        /// Checks to see if the LaunchedVpcID property is set.
        /// </summary>
        internal bool IsSetLaunchedVpcID() => this.LaunchedVpcID != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// Status of Source Network Replication. Possible values: (a) STOPPED - Source Network
        /// is not replicating. (b) IN_PROGRESS - Source Network is being replicated. (c) PROTECTED
        /// - Source Network was replicated successfully and is being synchronized for changes.
        /// (d) ERROR - Source Network replication has failed
        /// </para>
        /// </summary>
        public ReplicationStatus ReplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationStatus property is set.
        /// </summary>
        internal bool IsSetReplicationStatus() => this.ReplicationStatus != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatusDetails. 
        /// <para>
        /// Error details in case Source Network replication status is ERROR.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string ReplicationStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationStatusDetails property is set.
        /// </summary>
        internal bool IsSetReplicationStatusDetails() => this.ReplicationStatusDetails != null;

        /// <summary>
        /// Gets and sets the property SourceAccountID. 
        /// <para>
        /// Account ID containing the VPC protected by the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string SourceAccountID { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccountID property is set.
        /// </summary>
        internal bool IsSetSourceAccountID() => this.SourceAccountID != null;

        /// <summary>
        /// Gets and sets the property SourceNetworkID. 
        /// <para>
        /// Source Network ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string SourceNetworkID { get; set; }

        /// <summary>
        /// Checks to see if the SourceNetworkID property is set.
        /// </summary>
        internal bool IsSetSourceNetworkID() => this.SourceNetworkID != null;

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// Region containing the VPC protected by the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceRegion property is set.
        /// </summary>
        internal bool IsSetSourceRegion() => this.SourceRegion != null;

        /// <summary>
        /// Gets and sets the property SourceVpcID. 
        /// <para>
        /// VPC ID protected by the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 21)]
        public string SourceVpcID { get; set; }

        /// <summary>
        /// Checks to see if the SourceVpcID property is set.
        /// </summary>
        internal bool IsSetSourceVpcID() => this.SourceVpcID != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the Source Network.
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
