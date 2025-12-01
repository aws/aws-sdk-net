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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Detailed information about a specific connection type within a connection.
    /// </summary>
    public partial class ConnectionTypeDetail
    {
        private DateTime? _canceledAt;
        private string _canceledBy;
        private DateTime? _createdAt;
        private string _inviterEmail;
        private string _inviterName;
        private Participant _otherParticipant;
        private ConnectionTypeStatus _status;

        /// <summary>
        /// Gets and sets the property CanceledAt. 
        /// <para>
        /// The timestamp when this connection type was cancelled, if applicable.
        /// </para>
        /// </summary>
        public DateTime CanceledAt
        {
            get { return this._canceledAt.GetValueOrDefault(); }
            set { this._canceledAt = value; }
        }

        // Check to see if CanceledAt property is set
        internal bool IsSetCanceledAt()
        {
            return this._canceledAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CanceledBy. 
        /// <para>
        /// The AWS account ID of the participant who cancelled this connection type.
        /// </para>
        /// </summary>
        public string CanceledBy
        {
            get { return this._canceledBy; }
            set { this._canceledBy = value; }
        }

        // Check to see if CanceledBy property is set
        internal bool IsSetCanceledBy()
        {
            return this._canceledBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when this connection type was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InviterEmail. 
        /// <para>
        /// The email address of the person who initiated this connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=320)]
        public string InviterEmail
        {
            get { return this._inviterEmail; }
            set { this._inviterEmail = value; }
        }

        // Check to see if InviterEmail property is set
        internal bool IsSetInviterEmail()
        {
            return this._inviterEmail != null;
        }

        /// <summary>
        /// Gets and sets the property InviterName. 
        /// <para>
        /// The name of the person who initiated this connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=80)]
        public string InviterName
        {
            get { return this._inviterName; }
            set { this._inviterName = value; }
        }

        // Check to see if InviterName property is set
        internal bool IsSetInviterName()
        {
            return this._inviterName != null;
        }

        /// <summary>
        /// Gets and sets the property OtherParticipant. 
        /// <para>
        /// Information about the other participant in this connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Participant OtherParticipant
        {
            get { return this._otherParticipant; }
            set { this._otherParticipant = value; }
        }

        // Check to see if OtherParticipant property is set
        internal bool IsSetOtherParticipant()
        {
            return this._otherParticipant != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionTypeStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}