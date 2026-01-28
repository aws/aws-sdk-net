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
    /// Represents the data payload of an engagement invitation for a lead opportunity. This
    /// contains detailed information about the customer and interaction history that partners
    /// use to evaluate whether to accept the lead engagement invitation.
    /// </summary>
    public partial class LeadInvitationPayload
    {
        private LeadInvitationCustomer _customer;
        private LeadInvitationInteraction _interaction;

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// Contains information about the customer associated with the lead invitation. This
        /// data helps partners understand the customer's profile, industry, and business context
        /// to assess the lead opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LeadInvitationCustomer Customer
        {
            get { return this._customer; }
            set { this._customer = value; }
        }

        // Check to see if Customer property is set
        internal bool IsSetCustomer()
        {
            return this._customer != null;
        }

        /// <summary>
        /// Gets and sets the property Interaction. 
        /// <para>
        /// Describes the interaction details associated with the lead, including the source of
        /// the lead generation and customer engagement information. This context helps partners
        /// evaluate the lead quality and engagement approach.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LeadInvitationInteraction Interaction
        {
            get { return this._interaction; }
            set { this._interaction = value; }
        }

        // Check to see if Interaction property is set
        internal bool IsSetInteraction()
        {
            return this._interaction != null;
        }

    }
}