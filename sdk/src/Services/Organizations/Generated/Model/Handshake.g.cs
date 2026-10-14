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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains details for a handshake. A handshake is the secure exchange of information
    /// between two Amazon Web Services accounts: a sender and a recipient.
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
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of handshake:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>INVITE</b>: Handshake sent to a standalone account requesting that it to join
        /// the sender's organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ENABLE_ALL_FEATURES</b>: Handshake sent to invited member accounts to enable all
        /// features for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>APPROVE_ALL_FEATURES</b>: Handshake sent to the management account when all invited
        /// member accounts have approved to enable all features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TRANSFER_RESPONSIBILITY</b>: Handshake sent to another organization's management
        /// account requesting that it designate the sender with the specified responsibilities
        /// for recipient's organization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ActionType Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the handshake.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs in Organizations, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsorganizations.html#awsorganizations-resources-for-iam-policies">ARN
        /// Formats Supported by Organizations</a> in the <i>Amazon Web Services Service Authorization
        /// Reference</i>.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ExpirationTimestamp. 
        /// <para>
        /// Timestamp when the handshake expires.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTimestamp property is set.
        /// </summary>
        internal bool IsSetExpirationTimestamp() => this.ExpirationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID for the handshake.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for handshake ID string
        /// requires "h-" followed by from 8 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 34)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Parties. 
        /// <para>
        /// An array of <c>HandshakeParty</c> objects. Contains details for participant in a handshake.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HandshakeParty> Parties { get; set; } = AWSConfigs.InitializeCollections ? new List<HandshakeParty>() : null;

        /// <summary>
        /// Checks to see if the Parties property is set.
        /// </summary>
        internal bool IsSetParties() => this.Parties != null && (this.Parties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestedTimestamp. 
        /// <para>
        /// Timestamp when the handshake request was made.
        /// </para>
        /// </summary>
        public DateTime? RequestedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the RequestedTimestamp property is set.
        /// </summary>
        internal bool IsSetRequestedTimestamp() => this.RequestedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// An array of <c>HandshakeResource</c> objects. When needed, contains additional details
        /// for a handshake. For example, the email address for the sender.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HandshakeResource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<HandshakeResource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Current state for the handshake.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>REQUESTED</b>: Handshake awaiting a response from the recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OPEN</b>: Handshake sent to multiple recipients and all recipients have responded.
        /// The sender can now complete the handshake action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CANCELED</b>: Handshake canceled by the sender.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACCEPTED</b>: Handshake accepted by the recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DECLINED</b>: Handshake declined by the recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EXPIRED</b>: Handshake has expired.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HandshakeState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
