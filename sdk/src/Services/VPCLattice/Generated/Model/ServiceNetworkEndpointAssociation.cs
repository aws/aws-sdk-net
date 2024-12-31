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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Describes the association between a service network and a VPC endpoint.
    /// </summary>
    public partial class ServiceNetworkEndpointAssociation
    {
        private DateTime? _createdAt;
        private string _id;
        private string _serviceNetworkArn;
        private string _state;
        private string _vpcEndpointId;
        private string _vpcEndpointOwnerId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the association was created, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=2048)]
        public string ServiceNetworkArn
        {
            get { return this._serviceNetworkArn; }
            set { this._serviceNetworkArn = value; }
        }

        // Check to see if ServiceNetworkArn property is set
        internal bool IsSetServiceNetworkArn()
        {
            return this._serviceNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the association.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint associated with the service network.
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
        /// Gets and sets the property VpcEndpointOwnerId. 
        /// <para>
        /// The owner of the VPC endpoint associated with the service network.
        /// </para>
        /// </summary>
        public string VpcEndpointOwnerId
        {
            get { return this._vpcEndpointOwnerId; }
            set { this._vpcEndpointOwnerId = value; }
        }

        // Check to see if VpcEndpointOwnerId property is set
        internal bool IsSetVpcEndpointOwnerId()
        {
            return this._vpcEndpointOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC for the association.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}