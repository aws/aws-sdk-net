/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the AcceptHandshake operation.
    /// Sends a response to the originator of a handshake agreeing to the action proposed
    /// by the handshake request. 
    /// 
    ///  
    /// <para>
    /// This operation can be called only by the following principals when they also have
    /// the relevant IAM permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Invitation to join</b> or <b>Approve all features request</b> handshakes: only
    /// a principal from the member account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Enable all features final confirmation</b> handshake: only a principal from the
    /// master account.
    /// </para>
    ///  
    /// <para>
    /// For more information about invitations, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_invites.html">Inviting
    /// an AWS Account to Join Your Organization</a> in the <i>AWS Organizations User Guide</i>.
    /// For more information about requests to enable all features in the organization, see
    /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
    /// All Features in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After you accept a handshake, it continues to appear in the results of relevant APIs
    /// for only 30 days. After that it is deleted.
    /// </para>
    /// </summary>
    public partial class AcceptHandshakeRequest : AmazonOrganizationsRequest
    {
        private string _handshakeId;

        /// <summary>
        /// Gets and sets the property HandshakeId. 
        /// <para>
        /// The unique identifier (ID) of the handshake that you want to accept.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for handshake ID string
        /// requires "h-" followed by from 8 to 32 lower-case letters or digits.
        /// </para>
        /// </summary>
        public string HandshakeId
        {
            get { return this._handshakeId; }
            set { this._handshakeId = value; }
        }

        // Check to see if HandshakeId property is set
        internal bool IsSetHandshakeId()
        {
            return this._handshakeId != null;
        }

    }
}