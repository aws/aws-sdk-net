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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// A collection of attributes of the host from which the finding is generated.
    /// </summary>
    public partial class AssetAttributes
    {
        private string _agentId;
        private string _amiId;
        private string _autoScalingGroup;
        private string _hostname;
        private List<string> _ipv4Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<NetworkInterface> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private int? _schemaVersion;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The ID of the agent that is installed on the EC2 instance where the finding is generated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The ID of the Amazon Machine Image (AMI) that is installed on the EC2 instance where
        /// the finding is generated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string AmiId
        {
            get { return this._amiId; }
            set { this._amiId = value; }
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroup. 
        /// <para>
        /// The Auto Scaling group of the EC2 instance where the finding is generated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AutoScalingGroup
        {
            get { return this._autoScalingGroup; }
            set { this._autoScalingGroup = value; }
        }

        // Check to see if AutoScalingGroup property is set
        internal bool IsSetAutoScalingGroup()
        {
            return this._autoScalingGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The hostname of the EC2 instance where the finding is generated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4Addresses. 
        /// <para>
        /// The list of IP v4 addresses of the EC2 instance where the finding is generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> Ipv4Addresses
        {
            get { return this._ipv4Addresses; }
            set { this._ipv4Addresses = value; }
        }

        // Check to see if Ipv4Addresses property is set
        internal bool IsSetIpv4Addresses()
        {
            return this._ipv4Addresses != null && (this._ipv4Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// An array of the network interfaces interacting with the EC2 instance where the finding
        /// is generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && (this._networkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of this data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags related to the EC2 instance where the finding is generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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