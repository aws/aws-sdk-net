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
    /// Represents the data payload of an Engagement Invitation for a specific opportunity.
    /// This contains detailed information that partners use to evaluate the engagement.
    /// </summary>
    public partial class OpportunityInvitationPayload
    {
        private EngagementCustomer _customer;
        private ProjectDetails _project;
        private List<string> _receiverResponsibilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<SenderContact> _senderContacts = AWSConfigs.InitializeCollections ? new List<SenderContact>() : null;

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// Contains information about the customer related to the opportunity in the Engagement
        /// Invitation. This data helps partners understand the customer’s profile and requirements.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EngagementCustomer Customer
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
        /// Gets and sets the property Project. 
        /// <para>
        /// Describes the project details associated with the opportunity, including the customer’s
        /// needs and the scope of work expected to be performed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProjectDetails Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiverResponsibilities. 
        /// <para>
        /// Outlines the responsibilities or expectations of the receiver in the context of the
        /// invitation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ReceiverResponsibilities
        {
            get { return this._receiverResponsibilities; }
            set { this._receiverResponsibilities = value; }
        }

        // Check to see if ReceiverResponsibilities property is set
        internal bool IsSetReceiverResponsibilities()
        {
            return this._receiverResponsibilities != null && (this._receiverResponsibilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SenderContacts. 
        /// <para>
        /// Represents the contact details of the AWS representatives involved in sending the
        /// Engagement Invitation. These contacts are opportunity stakeholders.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<SenderContact> SenderContacts
        {
            get { return this._senderContacts; }
            set { this._senderContacts = value; }
        }

        // Check to see if SenderContacts property is set
        internal bool IsSetSenderContacts()
        {
            return this._senderContacts != null && (this._senderContacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}