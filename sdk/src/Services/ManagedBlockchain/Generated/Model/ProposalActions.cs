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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// The actions to carry out if a proposal is <code>APPROVED</code>. 
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class ProposalActions
    {
        private List<InviteAction> _invitations = new List<InviteAction>();
        private List<RemoveAction> _removals = new List<RemoveAction>();

        /// <summary>
        /// Gets and sets the property Invitations. 
        /// <para>
        ///  The actions to perform for an <code>APPROVED</code> proposal to invite an AWS account
        /// to create a member and join the network. 
        /// </para>
        /// </summary>
        public List<InviteAction> Invitations
        {
            get { return this._invitations; }
            set { this._invitations = value; }
        }

        // Check to see if Invitations property is set
        internal bool IsSetInvitations()
        {
            return this._invitations != null && this._invitations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Removals. 
        /// <para>
        ///  The actions to perform for an <code>APPROVED</code> proposal to remove a member from
        /// the network, which deletes the member and all associated member resources from the
        /// network. 
        /// </para>
        /// </summary>
        public List<RemoveAction> Removals
        {
            get { return this._removals; }
            set { this._removals = value; }
        }

        // Check to see if Removals property is set
        internal bool IsSetRemovals()
        {
            return this._removals != null && this._removals.Count > 0; 
        }

    }
}