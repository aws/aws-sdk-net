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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains information that must be exchanged to securely establish a relationship between
    /// two accounts (an <i>originator</i> and a <i>recipient</i>). For example, when a management
    /// account (the originator) invites another account (the recipient) to join its organization,
    /// the two accounts exchange information as a series of handshake requests and responses.
    /// 
    ///  
    /// <para>
    ///  <b>Note:</b> Handshakes that are <c>CANCELED</c>, <c>ACCEPTED</c>, <c>DECLINED</c>,
    /// or <c>EXPIRED</c> show up in lists for only 30 days after entering that state After
    /// that they are deleted.
    /// </para>
    /// </summary>
    public partial class Handshake
    {
        private ActionType _action;
        private string _arn;
        private DateTime? _expirationTimestamp;
        private string _id;
        private List<HandshakeParty> _parties = AWSConfigs.InitializeCollections ? new List<HandshakeParty>() : null;
        private DateTime? _requestedTimestamp;
        private List<HandshakeResource> _resources = AWSConfigs.InitializeCollections ? new List<HandshakeResource>() : null;
        private HandshakeState _state;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of handshake, indicating what action occurs when the recipient accepts the
        /// handshake. The following handshake types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>INVITE</b>: This type of handshake represents a request to join an organization.
        /// It is always sent from the management account to only non-member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ENABLE_ALL_FEATURES</b>: This type of handshake represents a request to enable
        /// all features in an organization. It is always sent from the management account to
        /// only <i>invited</i> member accounts. Created accounts do not receive this because
        /// those accounts were created by the organization's management account and approval
        /// is inferred.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>APPROVE_ALL_FEATURES</b>: This type of handshake is sent from the Organizations
        /// service when all member accounts have approved the <c>ENABLE_ALL_FEATURES</c> invitation.
        /// It is sent only to the management account and signals the master that it can finalize
        /// the process to enable all features.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ActionType Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a handshake.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs in Organizations, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsorganizations.html#awsorganizations-resources-for-iam-policies">ARN
        /// Formats Supported by Organizations</a> in the <i>Amazon Web Services Service Authorization
        /// Reference</i>.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTimestamp. 
        /// <para>
        /// The date and time that the handshake expires. If the recipient of the handshake request
        /// fails to respond before the specified date and time, the handshake becomes inactive
        /// and is no longer valid.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTimestamp
        {
            get { return this._expirationTimestamp; }
            set { this._expirationTimestamp = value; }
        }

        // Check to see if ExpirationTimestamp property is set
        internal bool IsSetExpirationTimestamp()
        {
            return this._expirationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) of a handshake. The originating account creates the ID
        /// when it initiates the handshake.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for handshake ID string
        /// requires "h-" followed by from 8 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Max=34)]
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
        /// Gets and sets the property Parties. 
        /// <para>
        /// Information about the two accounts that are participating in the handshake.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HandshakeParty> Parties
        {
            get { return this._parties; }
            set { this._parties = value; }
        }

        // Check to see if Parties property is set
        internal bool IsSetParties()
        {
            return this._parties != null && (this._parties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestedTimestamp. 
        /// <para>
        /// The date and time that the handshake request was made.
        /// </para>
        /// </summary>
        public DateTime? RequestedTimestamp
        {
            get { return this._requestedTimestamp; }
            set { this._requestedTimestamp = value; }
        }

        // Check to see if RequestedTimestamp property is set
        internal bool IsSetRequestedTimestamp()
        {
            return this._requestedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Additional information that is needed to process the handshake.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HandshakeResource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the handshake. Use the state to trace the flow of the handshake
        /// through the process from its creation to its acceptance. The meaning of each of the
        /// valid values is as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>REQUESTED</b>: This handshake was sent to multiple recipients (applicable to only
        /// some handshake types) and not all recipients have responded yet. The request stays
        /// in this state until all recipients respond.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OPEN</b>: This handshake was sent to multiple recipients (applicable to only some
        /// policy types) and all recipients have responded, allowing the originator to complete
        /// the handshake action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CANCELED</b>: This handshake is no longer active because it was canceled by the
        /// originating account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACCEPTED</b>: This handshake is complete because it has been accepted by the recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DECLINED</b>: This handshake is no longer active because it was declined by the
        /// recipient account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EXPIRED</b>: This handshake is no longer active because the originator did not
        /// receive a response of any kind from the recipient before the expiration time (15 days).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HandshakeState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}