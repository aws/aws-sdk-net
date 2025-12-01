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
    /// Represents a specific interaction or touchpoint with a lead customer. This structure
    /// captures details about communications, meetings, or other engagement activities that
    /// help track the lead's progression and engagement history.
    /// </summary>
    public partial class LeadInteraction
    {
        private string _businessProblem;
        private LeadContact _contact;
        private string _customerAction;
        private DateTime? _interactionDate;
        private string _sourceId;
        private string _sourceName;
        private string _sourceType;
        private string _usecase;

        /// <summary>
        /// Gets and sets the property BusinessProblem. 
        /// <para>
        /// Describes the business problem or challenge that the customer discussed during the
        /// interaction. This information helps qualify the lead and identify appropriate solutions.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string BusinessProblem
        {
            get { return this._businessProblem; }
            set { this._businessProblem = value; }
        }

        // Check to see if BusinessProblem property is set
        internal bool IsSetBusinessProblem()
        {
            return this._businessProblem != null;
        }

        /// <summary>
        /// Gets and sets the property Contact. 
        /// <para>
        /// Contains contact information for the customer representative involved in the lead
        /// interaction, including their name, title, and contact details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LeadContact Contact
        {
            get { return this._contact; }
            set { this._contact = value; }
        }

        // Check to see if Contact property is set
        internal bool IsSetContact()
        {
            return this._contact != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerAction. 
        /// <para>
        /// Describes the action taken by the customer during or as a result of the interaction,
        /// such as requesting information, scheduling a meeting, or expressing interest in a
        /// solution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CustomerAction
        {
            get { return this._customerAction; }
            set { this._customerAction = value; }
        }

        // Check to see if CustomerAction property is set
        internal bool IsSetCustomerAction()
        {
            return this._customerAction != null;
        }

        /// <summary>
        /// Gets and sets the property InteractionDate. 
        /// <para>
        /// The date and time when the lead interaction occurred, in ISO 8601 format (UTC). This
        /// timestamp helps track the chronology of lead engagement activities.
        /// </para>
        /// </summary>
        public DateTime? InteractionDate
        {
            get { return this._interactionDate; }
            set { this._interactionDate = value; }
        }

        // Check to see if InteractionDate property is set
        internal bool IsSetInteractionDate()
        {
            return this._interactionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The unique identifier of the specific source that generated the lead interaction.
        /// This ID provides traceability back to the original lead generation activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The descriptive name of the source that generated the lead interaction, providing
        /// a human-readable identifier for the lead generation channel or activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Specifies the type of source that generated the lead interaction, such as "Event",
        /// "Website", "Referral", or "Campaign". This categorization helps track lead generation
        /// effectiveness across different channels.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Usecase. 
        /// <para>
        /// Describes the specific use case or business scenario discussed during the lead interaction.
        /// This helps categorize the customer's interests and potential solutions.
        /// </para>
        /// </summary>
        public string Usecase
        {
            get { return this._usecase; }
            set { this._usecase = value; }
        }

        // Check to see if Usecase property is set
        internal bool IsSetUsecase()
        {
            return this._usecase != null;
        }

    }
}