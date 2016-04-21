/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private List<string> _ipv4Addresses = new List<string>();
        private int? _schemaVersion;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The id of the agent that is installed on the EC2 instance where the finding is generated.
        /// </para>
        /// </summary>
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
        /// Amazon Machine Image(AMI) ID installed on the EC2 instance where the finding is generated.
        /// </para>
        /// </summary>
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
        /// The auto-scaling group of the EC2 instance where the finding is generated. 
        /// </para>
        /// </summary>
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
        /// </summary>
        public List<string> Ipv4Addresses
        {
            get { return this._ipv4Addresses; }
            set { this._ipv4Addresses = value; }
        }

        // Check to see if Ipv4Addresses property is set
        internal bool IsSetIpv4Addresses()
        {
            return this._ipv4Addresses != null && this._ipv4Addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of this data type.
        /// </para>
        /// </summary>
        public int SchemaVersion
        {
            get { return this._schemaVersion.GetValueOrDefault(); }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion.HasValue; 
        }

    }
}