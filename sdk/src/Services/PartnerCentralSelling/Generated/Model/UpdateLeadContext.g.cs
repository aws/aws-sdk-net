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
    /// Updates the context information for a lead with qualification status, customer details,
    /// and interaction data.
    /// </summary>
    public partial class UpdateLeadContext
    {
        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// Updated customer information associated with the lead.
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
        /// analysis to help partners assess the lead quality and readiness.
        /// </para>
        /// </summary>
        public LeadInsights Insights { get; set; }

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null;

        /// <summary>
        /// Gets and sets the property Interaction. 
        /// <para>
        /// Updated interaction details for the lead context.
        /// </para>
        /// </summary>
        public LeadInteraction Interaction { get; set; }

        /// <summary>
        /// Checks to see if the Interaction property is set.
        /// </summary>
        internal bool IsSetInteraction() => this.Interaction != null;

        /// <summary>
        /// Gets and sets the property QualificationStatus. 
        /// <para>
        /// The updated qualification status of the lead.
        /// </para>
        /// </summary>
        public string QualificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the QualificationStatus property is set.
        /// </summary>
        internal bool IsSetQualificationStatus() => this.QualificationStatus != null;
    }
}
