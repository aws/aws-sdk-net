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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Information about an email identity.
    /// </summary>
    public partial class IdentityInfo
    {
        private string _identityName;
        private IdentityType _identityType;
        private bool? _sendingEnabled;

        /// <summary>
        /// Gets and sets the property IdentityName. 
        /// <para>
        /// The address or domain of the identity.
        /// </para>
        /// </summary>
        public string IdentityName
        {
            get { return this._identityName; }
            set { this._identityName = value; }
        }

        // Check to see if IdentityName property is set
        internal bool IsSetIdentityName()
        {
            return this._identityName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The email identity type. The identity type can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EMAIL_ADDRESS</c> – The identity is an email address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DOMAIN</c> – The identity is a domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MANAGED_DOMAIN</c> – The identity is a domain that is managed by AWS.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IdentityType IdentityType
        {
            get { return this._identityType; }
            set { this._identityType = value; }
        }

        // Check to see if IdentityType property is set
        internal bool IsSetIdentityType()
        {
            return this._identityType != null;
        }

        /// <summary>
        /// Gets and sets the property SendingEnabled. 
        /// <para>
        /// Indicates whether or not you can send email from the identity.
        /// </para>
        ///  
        /// <para>
        /// In Amazon Pinpoint, an identity is an email address or domain that you send email
        /// from. Before you can send email from an identity, you have to demostrate that you
        /// own the identity, and that you authorize Amazon Pinpoint to send email from that identity.
        /// </para>
        /// </summary>
        public bool? SendingEnabled
        {
            get { return this._sendingEnabled; }
            set { this._sendingEnabled = value; }
        }

        // Check to see if SendingEnabled property is set
        internal bool IsSetSendingEnabled()
        {
            return this._sendingEnabled.HasValue; 
        }

    }
}