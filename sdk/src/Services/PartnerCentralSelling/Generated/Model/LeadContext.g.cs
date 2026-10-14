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
    /// Provides comprehensive details about a lead associated with an engagement. This structure
    /// contains information about lead qualification status, customer details, and interaction
    /// history to facilitate lead management and tracking within the engagement.
    /// </summary>
    public partial class LeadContext
    {
        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// Contains detailed information about the customer associated with the lead, including
        /// company information, contact details, and other relevant customer data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LeadCustomer Customer { get; set; }

        /// <summary>
        /// Checks to see if the Customer property is set.
        /// </summary>
        internal bool IsSetCustomer() => this.Customer != null;

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// Insights that AI generates and associates with the lead. These insights provide automated
        /// analysis such as lead readiness scoring to help partners assess the lead quality.
        /// </para>
        /// </summary>
        public LeadInsights Insights { get; set; }

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null;

        /// <summary>
        /// Gets and sets the property Interactions. 
        /// <para>
        /// An array of interactions that have occurred with the lead, providing a history of
        /// communications, meetings, and other engagement activities related to the lead.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<LeadInteraction> Interactions { get; set; } = AWSConfigs.InitializeCollections ? new List<LeadInteraction>() : null;

        /// <summary>
        /// Checks to see if the Interactions property is set.
        /// </summary>
        internal bool IsSetInteractions() => this.Interactions != null && (this.Interactions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QualificationStatus. 
        /// <para>
        /// Indicates the current qualification status of the lead, such as whether it has been
        /// qualified, disqualified, or is still under evaluation. This helps track the lead's
        /// progression through the qualification process.
        /// </para>
        /// </summary>
        public string QualificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the QualificationStatus property is set.
        /// </summary>
        internal bool IsSetQualificationStatus() => this.QualificationStatus != null;
    }
}
