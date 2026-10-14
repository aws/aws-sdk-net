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
    /// Represents a specific interaction or touchpoint with a lead customer. This structure
    /// captures details about communications, meetings, or other engagement activities that
    /// help track the lead's progression and engagement history.
    /// </summary>
    public partial class LeadInteraction
    {
        /// <summary>
        /// Gets and sets the property BusinessProblem. 
        /// <para>
        /// Describes the business problem or challenge that the customer discussed during the
        /// interaction. This information helps qualify the lead and identify appropriate solutions.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2000)]
        public string BusinessProblem { get; set; }

        /// <summary>
        /// Checks to see if the BusinessProblem property is set.
        /// </summary>
        internal bool IsSetBusinessProblem() => this.BusinessProblem != null;

        /// <summary>
        /// Gets and sets the property Contact. 
        /// <para>
        /// Contains contact information for the customer representative involved in the lead
        /// interaction, including their name, title, and contact details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LeadContact Contact { get; set; }

        /// <summary>
        /// Checks to see if the Contact property is set.
        /// </summary>
        internal bool IsSetContact() => this.Contact != null;

        /// <summary>
        /// Gets and sets the property CustomerAction. 
        /// <para>
        /// Describes the action taken by the customer during or as a result of the interaction,
        /// such as requesting information, scheduling a meeting, or expressing interest in a
        /// solution.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string CustomerAction { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAction property is set.
        /// </summary>
        internal bool IsSetCustomerAction() => this.CustomerAction != null;

        /// <summary>
        /// Gets and sets the property InteractionDate. 
        /// <para>
        /// The date and time when the lead interaction occurred, in ISO 8601 format (UTC). This
        /// timestamp helps track the chronology of lead engagement activities.
        /// </para>
        /// </summary>
        public DateTime? InteractionDate { get; set; }

        /// <summary>
        /// Checks to see if the InteractionDate property is set.
        /// </summary>
        internal bool IsSetInteractionDate() => this.InteractionDate.HasValue;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The unique identifier of the specific source that generated the lead interaction.
        /// This ID provides traceability back to the original lead generation activity.
        /// </para>
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId != null;

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The descriptive name of the source that generated the lead interaction, providing
        /// a human-readable identifier for the lead generation channel or activity.
        /// </para>
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceName property is set.
        /// </summary>
        internal bool IsSetSourceName() => this.SourceName != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Specifies the type of source that generated the lead interaction, such as "Event",
        /// "Website", "Referral", or "Campaign". This categorization helps track lead generation
        /// effectiveness across different channels.
        /// </para>
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property Usecase. 
        /// <para>
        /// Describes the specific use case or business scenario discussed during the lead interaction.
        /// This helps categorize the customer's interests and potential solutions.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Usecase { get; set; }

        /// <summary>
        /// Checks to see if the Usecase property is set.
        /// </summary>
        internal bool IsSetUsecase() => this.Usecase != null;
    }
}
