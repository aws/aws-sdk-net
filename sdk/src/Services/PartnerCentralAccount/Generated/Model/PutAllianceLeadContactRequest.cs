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
    /// Container for the parameters to the PutAllianceLeadContact operation.
    /// Creates or updates the alliance lead contact information for a partner account.
    /// </summary>
    public partial class PutAllianceLeadContactRequest : AmazonPartnerCentralAccountRequest
    {
        private AllianceLeadContact _allianceLeadContact;
        private string _catalog;
        private string _emailVerificationCode;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property AllianceLeadContact. 
        /// <para>
        /// The alliance lead contact information to set for the partner account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllianceLeadContact AllianceLeadContact
        {
            get { return this._allianceLeadContact; }
            set { this._allianceLeadContact = value; }
        }

        // Check to see if AllianceLeadContact property is set
        internal bool IsSetAllianceLeadContact()
        {
            return this._allianceLeadContact != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier for the partner account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property EmailVerificationCode. 
        /// <para>
        /// The verification code sent to the alliance lead contact's email to confirm the update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=6, Max=6)]
        public string EmailVerificationCode
        {
            get { return this._emailVerificationCode; }
            set { this._emailVerificationCode = value; }
        }

        // Check to see if EmailVerificationCode property is set
        internal bool IsSetEmailVerificationCode()
        {
            return this._emailVerificationCode != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the partner account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}