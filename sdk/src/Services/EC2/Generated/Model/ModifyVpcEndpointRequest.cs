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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVpcEndpoint operation.
    /// Modifies attributes of a specified VPC endpoint. The attributes that you can modify
    /// depend on the type of VPC endpoint (interface or gateway). For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-endpoints.html">VPC
    /// Endpoints</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </summary>
    public partial class ModifyVpcEndpointRequest : AmazonEC2Request
    {
        private List<string> _addRouteTableIds = new List<string>();
        private List<string> _addSecurityGroupIds = new List<string>();
        private List<string> _addSubnetIds = new List<string>();
        private string _policyDocument;
        private bool? _privateDnsEnabled;
        private List<string> _removeRouteTableIds = new List<string>();
        private List<string> _removeSecurityGroupIds = new List<string>();
        private List<string> _removeSubnetIds = new List<string>();
        private bool? _resetPolicy;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property AddRouteTableIds. 
        /// <para>
        /// (Gateway endpoint) One or more route tables IDs to associate with the endpoint.
        /// </para>
        /// </summary>
        public List<string> AddRouteTableIds
        {
            get { return this._addRouteTableIds; }
            set { this._addRouteTableIds = value; }
        }

        // Check to see if AddRouteTableIds property is set
        internal bool IsSetAddRouteTableIds()
        {
            return this._addRouteTableIds != null && this._addRouteTableIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AddSecurityGroupIds. 
        /// <para>
        /// (Interface endpoint) One or more security group IDs to associate with the network
        /// interface.
        /// </para>
        /// </summary>
        public List<string> AddSecurityGroupIds
        {
            get { return this._addSecurityGroupIds; }
            set { this._addSecurityGroupIds = value; }
        }

        // Check to see if AddSecurityGroupIds property is set
        internal bool IsSetAddSecurityGroupIds()
        {
            return this._addSecurityGroupIds != null && this._addSecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AddSubnetIds. 
        /// <para>
        /// (Interface endpoint) One or more subnet IDs in which to serve the endpoint.
        /// </para>
        /// </summary>
        public List<string> AddSubnetIds
        {
            get { return this._addSubnetIds; }
            set { this._addSubnetIds = value; }
        }

        // Check to see if AddSubnetIds property is set
        internal bool IsSetAddSubnetIds()
        {
            return this._addSubnetIds != null && this._addSubnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// A policy to attach to the endpoint that controls access to the service. The policy
        /// must be in valid JSON format. If this parameter is not specified, we attach a default
        /// policy that allows full access to the service.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsEnabled. 
        /// <para>
        /// (Interface endpoint) Indicate whether a private hosted zone is associated with the
        /// VPC.
        /// </para>
        /// </summary>
        public bool PrivateDnsEnabled
        {
            get { return this._privateDnsEnabled.GetValueOrDefault(); }
            set { this._privateDnsEnabled = value; }
        }

        // Check to see if PrivateDnsEnabled property is set
        internal bool IsSetPrivateDnsEnabled()
        {
            return this._privateDnsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveRouteTableIds. 
        /// <para>
        /// (Gateway endpoint) One or more route table IDs to disassociate from the endpoint.
        /// </para>
        /// </summary>
        public List<string> RemoveRouteTableIds
        {
            get { return this._removeRouteTableIds; }
            set { this._removeRouteTableIds = value; }
        }

        // Check to see if RemoveRouteTableIds property is set
        internal bool IsSetRemoveRouteTableIds()
        {
            return this._removeRouteTableIds != null && this._removeRouteTableIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveSecurityGroupIds. 
        /// <para>
        /// (Interface endpoint) One or more security group IDs to disassociate from the network
        /// interface.
        /// </para>
        /// </summary>
        public List<string> RemoveSecurityGroupIds
        {
            get { return this._removeSecurityGroupIds; }
            set { this._removeSecurityGroupIds = value; }
        }

        // Check to see if RemoveSecurityGroupIds property is set
        internal bool IsSetRemoveSecurityGroupIds()
        {
            return this._removeSecurityGroupIds != null && this._removeSecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveSubnetIds. 
        /// <para>
        /// (Interface endpoint) One or more subnets IDs in which to remove the endpoint.
        /// </para>
        /// </summary>
        public List<string> RemoveSubnetIds
        {
            get { return this._removeSubnetIds; }
            set { this._removeSubnetIds = value; }
        }

        // Check to see if RemoveSubnetIds property is set
        internal bool IsSetRemoveSubnetIds()
        {
            return this._removeSubnetIds != null && this._removeSubnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResetPolicy. 
        /// <para>
        /// (Gateway endpoint) Specify <code>true</code> to reset the policy document to the default
        /// policy. The default policy allows full access to the service.
        /// </para>
        /// </summary>
        public bool ResetPolicy
        {
            get { return this._resetPolicy.GetValueOrDefault(); }
            set { this._resetPolicy = value; }
        }

        // Check to see if ResetPolicy property is set
        internal bool IsSetResetPolicy()
        {
            return this._resetPolicy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

    }
}