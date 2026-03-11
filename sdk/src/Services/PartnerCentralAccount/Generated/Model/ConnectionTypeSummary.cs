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
    /// Summary information about a specific connection type between partners.
    /// </summary>
    public partial class ConnectionTypeSummary
    {
        private Participant _otherParticipant;
        private ConnectionTypeStatus _status;

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
        /// The current status of this connection type (active, canceled, etc.).
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