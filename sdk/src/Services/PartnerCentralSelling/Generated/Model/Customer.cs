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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
    /// An object that contains the customer's <c>Account</c> and <c>Contact</c>.
    /// </summary>
    public partial class Customer
    {
        private Account _account;
        private List<Contact> _contacts = AWSConfigs.InitializeCollections ? new List<Contact>() : null;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// An object that contains the customer's account details.
        /// </para>
        /// </summary>
        public Account Account
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
        /// Gets and sets the property Contacts. 
        /// <para>
        /// Represents the contact details for individuals associated with the customer of the
        /// <c>Opportunity</c>. This field captures relevant contacts, including decision-makers,
        /// influencers, and technical stakeholders within the customer organization. These contacts
        /// are key to progressing the opportunity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Contact> Contacts
        {
            get { return this._contacts; }
            set { this._contacts = value; }
        }

        // Check to see if Contacts property is set
        internal bool IsSetContacts()
        {
            return this._contacts != null && (this._contacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}