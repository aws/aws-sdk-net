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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
        private CreateNetworkAclAction _createNetworkAclAction;
        private CreateNetworkAclEntriesAction _createNetworkAclEntriesAction;
        private DeleteNetworkAclEntriesAction _deleteNetworkAclEntriesAction;
        private string _description;
        private EC2AssociateRouteTableAction _ec2AssociateRouteTableAction;
        private EC2CopyRouteTableAction _ec2CopyRouteTableAction;
        private EC2CreateRouteAction _ec2CreateRouteAction;
        private EC2CreateRouteTableAction _ec2CreateRouteTableAction;
        private EC2DeleteRouteAction _ec2DeleteRouteAction;
        private EC2ReplaceRouteAction _ec2ReplaceRouteAction;
        private EC2ReplaceRouteTableAssociationAction _ec2ReplaceRouteTableAssociationAction;
        private FMSPolicyUpdateFirewallCreationConfigAction _fmsPolicyUpdateFirewallCreationConfigAction;
        private ReplaceNetworkAclAssociationAction _replaceNetworkAclAssociationAction;

        /// <summary>
        /// Gets and sets the property CreateNetworkAclAction. 
        /// <para>
        /// Information about the <c>CreateNetworkAcl</c> action in Amazon EC2.
        /// </para>
        /// </summary>
        public CreateNetworkAclAction CreateNetworkAclAction
        {
            get { return this._createNetworkAclAction; }
            set { this._createNetworkAclAction = value; }
        }

        // Check to see if CreateNetworkAclAction property is set
        internal bool IsSetCreateNetworkAclAction()
        {
            return this._createNetworkAclAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateNetworkAclEntriesAction. 
        /// <para>
        /// Information about the <c>CreateNetworkAclEntries</c> action in Amazon EC2.
        /// </para>
        /// </summary>
        public CreateNetworkAclEntriesAction CreateNetworkAclEntriesAction
        {
            get { return this._createNetworkAclEntriesAction; }
            set { this._createNetworkAclEntriesAction = value; }
        }

        // Check to see if CreateNetworkAclEntriesAction property is set
        internal bool IsSetCreateNetworkAclEntriesAction()
        {
            return this._createNetworkAclEntriesAction != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteNetworkAclEntriesAction. 
        /// <para>
        /// Information about the <c>DeleteNetworkAclEntries</c> action in Amazon EC2.
        /// </para>
        /// </summary>
        public DeleteNetworkAclEntriesAction DeleteNetworkAclEntriesAction
        {
            get { return this._deleteNetworkAclEntriesAction; }
            set { this._deleteNetworkAclEntriesAction = value; }
        }

        // Check to see if DeleteNetworkAclEntriesAction property is set
        internal bool IsSetDeleteNetworkAclEntriesAction()
        {
            return this._deleteNetworkAclEntriesAction != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of a remediation action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EC2AssociateRouteTableAction. 
        /// <para>
        /// Information about the AssociateRouteTable action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2AssociateRouteTableAction EC2AssociateRouteTableAction
        {
            get { return this._ec2AssociateRouteTableAction; }
            set { this._ec2AssociateRouteTableAction = value; }
        }

        // Check to see if EC2AssociateRouteTableAction property is set
        internal bool IsSetEC2AssociateRouteTableAction()
        {
            return this._ec2AssociateRouteTableAction != null;
        }

        /// <summary>
        /// Gets and sets the property EC2CopyRouteTableAction. 
        /// <para>
        /// Information about the CopyRouteTable action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2CopyRouteTableAction EC2CopyRouteTableAction
        {
            get { return this._ec2CopyRouteTableAction; }
            set { this._ec2CopyRouteTableAction = value; }
        }

        // Check to see if EC2CopyRouteTableAction property is set
        internal bool IsSetEC2CopyRouteTableAction()
        {
            return this._ec2CopyRouteTableAction != null;
        }

        /// <summary>
        /// Gets and sets the property EC2CreateRouteAction. 
        /// <para>
        /// Information about the CreateRoute action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2CreateRouteAction EC2CreateRouteAction
        {
            get { return this._ec2CreateRouteAction; }
            set { this._ec2CreateRouteAction = value; }
        }

        // Check to see if EC2CreateRouteAction property is set
        internal bool IsSetEC2CreateRouteAction()
        {
            return this._ec2CreateRouteAction != null;
        }

        /// <summary>
        /// Gets and sets the property EC2CreateRouteTableAction. 
        /// <para>
        /// Information about the CreateRouteTable action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2CreateRouteTableAction EC2CreateRouteTableAction
        {
            get { return this._ec2CreateRouteTableAction; }
            set { this._ec2CreateRouteTableAction = value; }
        }

        // Check to see if EC2CreateRouteTableAction property is set
        internal bool IsSetEC2CreateRouteTableAction()
        {
            return this._ec2CreateRouteTableAction != null;
        }

        /// <summary>
        /// Gets and sets the property EC2DeleteRouteAction. 
        /// <para>
        /// Information about the DeleteRoute action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2DeleteRouteAction EC2DeleteRouteAction
        {
            get { return this._ec2DeleteRouteAction; }
            set { this._ec2DeleteRouteAction = value; }
        }

        // Check to see if EC2DeleteRouteAction property is set
        internal bool IsSetEC2DeleteRouteAction()
        {
            return this._ec2DeleteRouteAction != null;
        }

        /// <summary>
        /// Gets and sets the property EC2ReplaceRouteAction. 
        /// <para>
        /// Information about the ReplaceRoute action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2ReplaceRouteAction EC2ReplaceRouteAction
        {
            get { return this._ec2ReplaceRouteAction; }
            set { this._ec2ReplaceRouteAction = value; }
        }

        // Check to see if EC2ReplaceRouteAction property is set
        internal bool IsSetEC2ReplaceRouteAction()
        {
            return this._ec2ReplaceRouteAction != null;
        }

        /// <summary>
        /// Gets and sets the property EC2ReplaceRouteTableAssociationAction. 
        /// <para>
        /// Information about the ReplaceRouteTableAssociation action in the Amazon EC2 API.
        /// </para>
        /// </summary>
        public EC2ReplaceRouteTableAssociationAction EC2ReplaceRouteTableAssociationAction
        {
            get { return this._ec2ReplaceRouteTableAssociationAction; }
            set { this._ec2ReplaceRouteTableAssociationAction = value; }
        }

        // Check to see if EC2ReplaceRouteTableAssociationAction property is set
        internal bool IsSetEC2ReplaceRouteTableAssociationAction()
        {
            return this._ec2ReplaceRouteTableAssociationAction != null;
        }

        /// <summary>
        /// Gets and sets the property FMSPolicyUpdateFirewallCreationConfigAction. 
        /// <para>
        /// The remedial action to take when updating a firewall configuration.
        /// </para>
        /// </summary>
        public FMSPolicyUpdateFirewallCreationConfigAction FMSPolicyUpdateFirewallCreationConfigAction
        {
            get { return this._fmsPolicyUpdateFirewallCreationConfigAction; }
            set { this._fmsPolicyUpdateFirewallCreationConfigAction = value; }
        }

        // Check to see if FMSPolicyUpdateFirewallCreationConfigAction property is set
        internal bool IsSetFMSPolicyUpdateFirewallCreationConfigAction()
        {
            return this._fmsPolicyUpdateFirewallCreationConfigAction != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceNetworkAclAssociationAction. 
        /// <para>
        /// Information about the <c>ReplaceNetworkAclAssociation</c> action in Amazon EC2. 
        /// </para>
        /// </summary>
        public ReplaceNetworkAclAssociationAction ReplaceNetworkAclAssociationAction
        {
            get { return this._replaceNetworkAclAssociationAction; }
            set { this._replaceNetworkAclAssociationAction = value; }
        }

        // Check to see if ReplaceNetworkAclAssociationAction property is set
        internal bool IsSetReplaceNetworkAclAssociationAction()
        {
            return this._replaceNetworkAclAssociationAction != null;
        }

    }
}