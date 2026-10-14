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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Information about an individual action you can take to remediate a violation.
    /// </summary>
    public partial class RemediationAction
    {
        /// <summary>
        /// Gets and sets the property CreateNetworkAclAction. 
        /// <para>
        /// Information about the <c>CreateNetworkAcl</c> action in Amazon EC2.
        /// </para>
        /// </summary>
        public CreateNetworkAclAction CreateNetworkAclAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateNetworkAclAction property is set.
        /// </summary>
        internal bool IsSetCreateNetworkAclAction() => this.CreateNetworkAclAction != null;

        /// <summary>
        /// Gets and sets the property CreateNetworkAclEntriesAction. 
        /// <para>
        /// Information about the <c>CreateNetworkAclEntries</c> action in Amazon EC2.
        /// </para>
        /// </summary>
        public CreateNetworkAclEntriesAction CreateNetworkAclEntriesAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateNetworkAclEntriesAction property is set.
        /// </summary>
        internal bool IsSetCreateNetworkAclEntriesAction() => this.CreateNetworkAclEntriesAction != null;

        /// <summary>
        /// Gets and sets the property DeleteNetworkAclEntriesAction. 
        /// <para>
        /// Information about the <c>DeleteNetworkAclEntries</c> action in Amazon EC2.
        /// </para>
        /// </summary>
        public DeleteNetworkAclEntriesAction DeleteNetworkAclEntriesAction { get; set; }

        /// <summary>
        /// Checks to see if the DeleteNetworkAclEntriesAction property is set.
        /// </summary>
        internal bool IsSetDeleteNetworkAclEntriesAction() => this.DeleteNetworkAclEntriesAction != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of a remediation action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EC2AssociateRouteTableAction. 
        /// <para>
        /// Information about the AssociateRouteTable action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2AssociateRouteTableAction EC2AssociateRouteTableAction { get; set; }

        /// <summary>
        /// Checks to see if the EC2AssociateRouteTableAction property is set.
        /// </summary>
        internal bool IsSetEC2AssociateRouteTableAction() => this.EC2AssociateRouteTableAction != null;

        /// <summary>
        /// Gets and sets the property EC2CopyRouteTableAction. 
        /// <para>
        /// Information about the CopyRouteTable action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2CopyRouteTableAction EC2CopyRouteTableAction { get; set; }

        /// <summary>
        /// Checks to see if the EC2CopyRouteTableAction property is set.
        /// </summary>
        internal bool IsSetEC2CopyRouteTableAction() => this.EC2CopyRouteTableAction != null;

        /// <summary>
        /// Gets and sets the property EC2CreateRouteAction. 
        /// <para>
        /// Information about the CreateRoute action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2CreateRouteAction EC2CreateRouteAction { get; set; }

        /// <summary>
        /// Checks to see if the EC2CreateRouteAction property is set.
        /// </summary>
        internal bool IsSetEC2CreateRouteAction() => this.EC2CreateRouteAction != null;

        /// <summary>
        /// Gets and sets the property EC2CreateRouteTableAction. 
        /// <para>
        /// Information about the CreateRouteTable action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2CreateRouteTableAction EC2CreateRouteTableAction { get; set; }

        /// <summary>
        /// Checks to see if the EC2CreateRouteTableAction property is set.
        /// </summary>
        internal bool IsSetEC2CreateRouteTableAction() => this.EC2CreateRouteTableAction != null;

        /// <summary>
        /// Gets and sets the property EC2DeleteRouteAction. 
        /// <para>
        /// Information about the DeleteRoute action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2DeleteRouteAction EC2DeleteRouteAction { get; set; }

        /// <summary>
        /// Checks to see if the EC2DeleteRouteAction property is set.
        /// </summary>
        internal bool IsSetEC2DeleteRouteAction() => this.EC2DeleteRouteAction != null;

        /// <summary>
        /// Gets and sets the property EC2ReplaceRouteAction. 
        /// <para>
        /// Information about the ReplaceRoute action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2ReplaceRouteAction EC2ReplaceRouteAction { get; set; }

        /// <summary>
        /// Checks to see if the EC2ReplaceRouteAction property is set.
        /// </summary>
        internal bool IsSetEC2ReplaceRouteAction() => this.EC2ReplaceRouteAction != null;

        /// <summary>
        /// Gets and sets the property EC2ReplaceRouteTableAssociationAction. 
        /// <para>
        /// Information about the ReplaceRouteTableAssociation action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2ReplaceRouteTableAssociationAction EC2ReplaceRouteTableAssociationAction { get; set; }

        /// <summary>
        /// Checks to see if the EC2ReplaceRouteTableAssociationAction property is set.
        /// </summary>
        internal bool IsSetEC2ReplaceRouteTableAssociationAction() => this.EC2ReplaceRouteTableAssociationAction != null;

        /// <summary>
        /// Gets and sets the property FMSPolicyUpdateFirewallCreationConfigAction. 
        /// <para>
        /// The remedial action to take when updating a firewall configuration.
        /// </para>
        /// </summary>
        public FMSPolicyUpdateFirewallCreationConfigAction FMSPolicyUpdateFirewallCreationConfigAction { get; set; }

        /// <summary>
        /// Checks to see if the FMSPolicyUpdateFirewallCreationConfigAction property is set.
        /// </summary>
        internal bool IsSetFMSPolicyUpdateFirewallCreationConfigAction() => this.FMSPolicyUpdateFirewallCreationConfigAction != null;

        /// <summary>
        /// Gets and sets the property ReplaceNetworkAclAssociationAction. 
        /// <para>
        /// Information about the <c>ReplaceNetworkAclAssociation</c> action in Amazon EC2. 
        /// </para>
        /// </summary>
        public ReplaceNetworkAclAssociationAction ReplaceNetworkAclAssociationAction { get; set; }

        /// <summary>
        /// Checks to see if the ReplaceNetworkAclAssociationAction property is set.
        /// </summary>
        internal bool IsSetReplaceNetworkAclAssociationAction() => this.ReplaceNetworkAclAssociationAction != null;
    }
}
