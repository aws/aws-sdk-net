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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about an appliance attached to a NAT Gateway, providing managed security
    /// solutions for traffic filtering and inspection.
    /// </summary>
    public partial class NatGatewayAttachedAppliance
    {
        /// <summary>
        /// Gets and sets the property ApplianceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the attached appliance, identifying the specific
        /// proxy or security appliance resource.
        /// </para>
        /// </summary>
        public string ApplianceArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplianceArn property is set.
        /// </summary>
        internal bool IsSetApplianceArn() => this.ApplianceArn != null;

        /// <summary>
        /// Gets and sets the property AttachmentState. 
        /// <para>
        /// The current attachment state of the appliance.
        /// </para>
        /// </summary>
        public NatGatewayApplianceState AttachmentState { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentState property is set.
        /// </summary>
        internal bool IsSetAttachmentState() => this.AttachmentState != null;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code if the appliance attachment or modification operation failed.
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// A descriptive message explaining the failure if the appliance attachment or modification
        /// operation failed.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property ModificationState. 
        /// <para>
        /// The current modification state of the appliance.
        /// </para>
        /// </summary>
        public NatGatewayApplianceModifyState ModificationState { get; set; }

        /// <summary>
        /// Checks to see if the ModificationState property is set.
        /// </summary>
        internal bool IsSetModificationState() => this.ModificationState != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of appliance attached to the NAT Gateway. For network firewall proxy functionality,
        /// this will be "network-firewall-proxy".
        /// </para>
        /// </summary>
        public NatGatewayApplianceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The VPC endpoint ID used to route traffic from application VPCs to the proxy for inspection
        /// and filtering.
        /// </para>
        /// </summary>
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;
    }
}
