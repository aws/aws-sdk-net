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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// The content of an account-planning invitation. It carries what the invited party needs
    /// to identify which account the plan concerns, because the receiver can't read the account
    /// resource directly. The account can be named by its identifier, by a customer identity
    /// snapshot, or both.
    /// </summary>
    public partial class AccountPlanningInvitationPayload
    {
        /// <summary>
        /// Gets and sets the property AccountIdentifier. 
        /// <para>
        /// The identifier of the customer account that the plan concerns, as an Amazon Resource
        /// Name (ARN) or a customer account identifier.
        /// </para>
        /// </summary>
        public string AccountIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AccountIdentifier property is set.
        /// </summary>
        internal bool IsSetAccountIdentifier() => this.AccountIdentifier != null;

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// A caller-supplied snapshot of the customer company's identity, so that the receiver
        /// can tell which account the plan concerns even when the account isn't yet mapped to
        /// an AWS account.
        /// </para>
        /// </summary>
        public AccountCustomer Customer { get; set; }

        /// <summary>
        /// Checks to see if the Customer property is set.
        /// </summary>
        internal bool IsSetCustomer() => this.Customer != null;

        /// <summary>
        /// Gets and sets the property PreferredContact. 
        /// <para>
        /// When the sender prefers to be contacted about this account plan. This information
        /// is advisory.
        /// </para>
        /// </summary>
        public PreferredContactWindow PreferredContact { get; set; }

        /// <summary>
        /// Checks to see if the PreferredContact property is set.
        /// </summary>
        internal bool IsSetPreferredContact() => this.PreferredContact != null;

        /// <summary>
        /// Gets and sets the property SenderContacts. 
        /// <para>
        /// The sender's contact information for this account plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<SenderContact> SenderContacts { get; set; } = AWSConfigs.InitializeCollections ? new List<SenderContact>() : null;

        /// <summary>
        /// Checks to see if the SenderContacts property is set.
        /// </summary>
        internal bool IsSetSenderContacts() => this.SenderContacts != null && (this.SenderContacts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
