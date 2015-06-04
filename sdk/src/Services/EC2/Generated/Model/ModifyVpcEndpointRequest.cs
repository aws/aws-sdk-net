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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
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
    /// Modifies attributes of a specified VPC endpoint. You can modify the policy associated
    /// with the endpoint, and you can add and remove route tables associated with the endpoint.
    /// </summary>
    public partial class ModifyVpcEndpointRequest : AmazonEC2Request
    {
        private List<string> _addRouteTableIds = new List<string>();
        private string _policyDocument;
        private List<string> _removeRouteTableIds = new List<string>();
        private bool? _resetPolicy;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property AddRouteTableIds. 
        /// <para>
        /// One or more route tables IDs to associate with the endpoint.
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
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// A policy document to attach to the endpoint. The policy must be in valid JSON format.
        /// 
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
        /// Gets and sets the property RemoveRouteTableIds. 
        /// <para>
        /// One or more route table IDs to disassociate from the endpoint.
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
        /// Gets and sets the property ResetPolicy. 
        /// <para>
        /// Specify <code>true</code> to reset the policy document to the default policy. The
        /// default policy allows access to the service.
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