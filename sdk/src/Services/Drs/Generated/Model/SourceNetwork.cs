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
    /// The ARN of the Source Network.
    /// </summary>
    public partial class SourceNetwork
    {
        private string _arn;
        private string _cfnStackName;
        private RecoveryLifeCycle _lastRecovery;
        private string _launchedVpcID;
        private ReplicationStatus _replicationStatus;
        private string _replicationStatusDetails;
        private string _sourceAccountID;
        private string _sourceNetworkID;
        private string _sourceRegion;
        private string _sourceVpcID;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CfnStackName. 
        /// <para>
        /// CloudFormation stack name that was deployed for recovering the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string CfnStackName
        {
            get { return this._cfnStackName; }
            set { this._cfnStackName = value; }
        }

        // Check to see if CfnStackName property is set
        internal bool IsSetCfnStackName()
        {
            return this._cfnStackName != null;
        }

        /// <summary>
        /// Gets and sets the property LastRecovery. 
        /// <para>
        /// An object containing information regarding the last recovery of the Source Network.
        /// </para>
        /// </summary>
        public RecoveryLifeCycle LastRecovery
        {
            get { return this._lastRecovery; }
            set { this._lastRecovery = value; }
        }

        // Check to see if LastRecovery property is set
        internal bool IsSetLastRecovery()
        {
            return this._lastRecovery != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchedVpcID. 
        /// <para>
        /// ID of the recovered VPC following Source Network recovery.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=21)]
        public string LaunchedVpcID
        {
            get { return this._launchedVpcID; }
            set { this._launchedVpcID = value; }
        }

        // Check to see if LaunchedVpcID property is set
        internal bool IsSetLaunchedVpcID()
        {
            return this._launchedVpcID != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// Status of Source Network Replication. Possible values: (a) STOPPED - Source Network
        /// is not replicating. (b) IN_PROGRESS - Source Network is being replicated. (c) PROTECTED
        /// - Source Network was replicated successfully and is being synchronized for changes.
        /// (d) ERROR - Source Network replication has failed
        /// </para>
        /// </summary>
        public ReplicationStatus ReplicationStatus
        {
            get { return this._replicationStatus; }
            set { this._replicationStatus = value; }
        }

        // Check to see if ReplicationStatus property is set
        internal bool IsSetReplicationStatus()
        {
            return this._replicationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatusDetails. 
        /// <para>
        /// Error details in case Source Network replication status is ERROR.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string ReplicationStatusDetails
        {
            get { return this._replicationStatusDetails; }
            set { this._replicationStatusDetails = value; }
        }

        // Check to see if ReplicationStatusDetails property is set
        internal bool IsSetReplicationStatusDetails()
        {
            return this._replicationStatusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAccountID. 
        /// <para>
        /// Account ID containing the VPC protected by the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string SourceAccountID
        {
            get { return this._sourceAccountID; }
            set { this._sourceAccountID = value; }
        }

        // Check to see if SourceAccountID property is set
        internal bool IsSetSourceAccountID()
        {
            return this._sourceAccountID != null;
        }

        /// <summary>
        /// Gets and sets the property SourceNetworkID. 
        /// <para>
        /// Source Network ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string SourceNetworkID
        {
            get { return this._sourceNetworkID; }
            set { this._sourceNetworkID = value; }
        }

        // Check to see if SourceNetworkID property is set
        internal bool IsSetSourceNetworkID()
        {
            return this._sourceNetworkID != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// Region containing the VPC protected by the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVpcID. 
        /// <para>
        /// VPC ID protected by the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=21)]
        public string SourceVpcID
        {
            get { return this._sourceVpcID; }
            set { this._sourceVpcID = value; }
        }

        // Check to see if SourceVpcID property is set
        internal bool IsSetSourceVpcID()
        {
            return this._sourceVpcID != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the Source Network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}