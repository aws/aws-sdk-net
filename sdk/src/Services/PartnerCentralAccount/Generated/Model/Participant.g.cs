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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Represents a participant in a partner connection, containing their profile and account
    /// information.
    /// </summary>
    public partial class Participant
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The AWS account information for the participant.
        /// </para>
        /// </summary>
        public AccountSummary Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property PartnerProfile. 
        /// <para>
        /// The partner profile information for the participant.
        /// </para>
        /// </summary>
        public PartnerProfileSummary PartnerProfile { get; set; }

        /// <summary>
        /// Checks to see if the PartnerProfile property is set.
        /// </summary>
        internal bool IsSetPartnerProfile() => this.PartnerProfile != null;

        /// <summary>
        /// Gets and sets the property SellerProfile. 
        /// <para>
        /// The seller profile information for the participant.
        /// </para>
        /// </summary>
        public SellerProfileSummary SellerProfile { get; set; }

        /// <summary>
        /// Checks to see if the SellerProfile property is set.
        /// </summary>
        internal bool IsSetSellerProfile() => this.SellerProfile != null;
    }
}
