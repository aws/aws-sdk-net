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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The settings for a VPC Source.
    /// </summary>
    public partial class VpcInterface
    {
        private string _name;
        private List<string> _networkInterfaceIds = new List<string>();
        private NetworkInterfaceType _networkInterfaceType;
        private string _roleArn;
        private List<string> _securityGroupIds = new List<string>();
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property Name. Immutable and has to be a unique against other VpcInterfaces
        /// in this Flow
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceIds. IDs of the network interfaces created
        /// in customer's account by MediaConnect.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> NetworkInterfaceIds
        {
            get { return this._networkInterfaceIds; }
            set { this._networkInterfaceIds = value; }
        }

        // Check to see if NetworkInterfaceIds property is set
        internal bool IsSetNetworkInterfaceIds()
        {
            return this._networkInterfaceIds != null && this._networkInterfaceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceType. The type of network interface.
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkInterfaceType NetworkInterfaceType
        {
            get { return this._networkInterfaceType; }
            set { this._networkInterfaceType = value; }
        }

        // Check to see if NetworkInterfaceType property is set
        internal bool IsSetNetworkInterfaceType()
        {
            return this._networkInterfaceType != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. Role Arn MediaConnect can assumes to create ENIs
        /// in customer's account
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. Security Group IDs to be used on ENI.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. Subnet must be in the AZ of the Flow
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}