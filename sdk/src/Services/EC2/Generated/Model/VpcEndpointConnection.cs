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
    /// Describes a VPC endpoint connection to a service.
    /// </summary>
    public partial class VpcEndpointConnection
    {
        private DateTime? _creationTimestamp;
        private string _serviceId;
        private string _vpcEndpointId;
        private string _vpcEndpointOwner;
        private State _vpcEndpointState;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The date and time the VPC endpoint was created.
        /// </para>
        /// </summary>
        public DateTime CreationTimestamp
        {
            get { return this._creationTimestamp.GetValueOrDefault(); }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service to which the endpoint is connected.
        /// </para>
        /// </summary>
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint.
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

        /// <summary>
        /// Gets and sets the property VpcEndpointOwner. 
        /// <para>
        /// The AWS account ID of the owner of the VPC endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointOwner
        {
            get { return this._vpcEndpointOwner; }
            set { this._vpcEndpointOwner = value; }
        }

        // Check to see if VpcEndpointOwner property is set
        internal bool IsSetVpcEndpointOwner()
        {
            return this._vpcEndpointOwner != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointState. 
        /// <para>
        /// The state of the VPC endpoint.
        /// </para>
        /// </summary>
        public State VpcEndpointState
        {
            get { return this._vpcEndpointState; }
            set { this._vpcEndpointState = value; }
        }

        // Check to see if VpcEndpointState property is set
        internal bool IsSetVpcEndpointState()
        {
            return this._vpcEndpointState != null;
        }

    }
}