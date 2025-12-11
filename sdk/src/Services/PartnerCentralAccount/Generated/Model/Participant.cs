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
    /// Represents a participant in a partner connection, containing their profile and account
    /// information.
    /// </summary>
    public partial class Participant
    {
        private AccountSummary _account;
        private PartnerProfileSummary _partnerProfile;
        private SellerProfileSummary _sellerProfile;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The AWS account information for the participant.
        /// </para>
        /// </summary>
        public AccountSummary Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerProfile. 
        /// <para>
        /// The partner profile information for the participant.
        /// </para>
        /// </summary>
        public PartnerProfileSummary PartnerProfile
        {
            get { return this._partnerProfile; }
            set { this._partnerProfile = value; }
        }

        // Check to see if PartnerProfile property is set
        internal bool IsSetPartnerProfile()
        {
            return this._partnerProfile != null;
        }

        /// <summary>
        /// Gets and sets the property SellerProfile. 
        /// <para>
        /// The seller profile information for the participant.
        /// </para>
        /// </summary>
        public SellerProfileSummary SellerProfile
        {
            get { return this._sellerProfile; }
            set { this._sellerProfile = value; }
        }

        // Check to see if SellerProfile property is set
        internal bool IsSetSellerProfile()
        {
            return this._sellerProfile != null;
        }

    }
}