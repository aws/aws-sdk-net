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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about an appliance attached to a NAT Gateway, providing managed security
    /// solutions for traffic filtering and inspection.
    /// </summary>
    public partial class NatGatewayAttachedAppliance
    {
        private string _applianceArn;
        private NatGatewayApplianceState _attachmentState;
        private string _failureCode;
        private string _failureMessage;
        private NatGatewayApplianceModifyState _modificationState;
        private NatGatewayApplianceType _type;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property ApplianceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the attached appliance, identifying the specific
        /// proxy or security appliance resource.
        /// </para>
        /// </summary>
        public string ApplianceArn
        {
            get { return this._applianceArn; }
            set { this._applianceArn = value; }
        }

        // Check to see if ApplianceArn property is set
        internal bool IsSetApplianceArn()
        {
            return this._applianceArn != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentState. 
        /// <para>
        /// The current attachment state of the appliance.
        /// </para>
        /// </summary>
        public NatGatewayApplianceState AttachmentState
        {
            get { return this._attachmentState; }
            set { this._attachmentState = value; }
        }

        // Check to see if AttachmentState property is set
        internal bool IsSetAttachmentState()
        {
            return this._attachmentState != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code if the appliance attachment or modification operation failed.
        /// </para>
        /// </summary>
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// A descriptive message explaining the failure if the appliance attachment or modification
        /// operation failed.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ModificationState. 
        /// <para>
        /// The current modification state of the appliance.
        /// </para>
        /// </summary>
        public NatGatewayApplianceModifyState ModificationState
        {
            get { return this._modificationState; }
            set { this._modificationState = value; }
        }

        // Check to see if ModificationState property is set
        internal bool IsSetModificationState()
        {
            return this._modificationState != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of appliance attached to the NAT Gateway. For network firewall proxy functionality,
        /// this will be "network-firewall-proxy".
        /// </para>
        /// </summary>
        public NatGatewayApplianceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The VPC endpoint ID used to route traffic from application VPCs to the proxy for inspection
        /// and filtering.
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