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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMember operation.
    /// Creates a member within a Managed Blockchain network.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class CreateMemberRequest : AmazonManagedBlockchainRequest
    {
        private string _clientRequestToken;
        private string _invitationId;
        private MemberConfiguration _memberConfiguration;
        private string _networkId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the operation. An idempotent operation completes no more than one time. This identifier
        /// is required only if you make a service request directly using an HTTP client. It is
        /// generated automatically if you use an Amazon Web Services SDK or the CLI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property InvitationId. 
        /// <para>
        /// The unique identifier of the invitation that is sent to the member to join the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string InvitationId
        {
            get { return this._invitationId; }
            set { this._invitationId = value; }
        }

        // Check to see if InvitationId property is set
        internal bool IsSetInvitationId()
        {
            return this._invitationId != null;
        }

        /// <summary>
        /// Gets and sets the property MemberConfiguration. 
        /// <para>
        /// Member configuration parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemberConfiguration MemberConfiguration
        {
            get { return this._memberConfiguration; }
            set { this._memberConfiguration = value; }
        }

        // Check to see if MemberConfiguration property is set
        internal bool IsSetMemberConfiguration()
        {
            return this._memberConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network in which the member is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

    }
}