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
    /// A subset of prospecting result data visible to invitation receivers. It includes customer
    /// account details and AI-generated insights.
    /// </summary>
    public partial class InvitationProspectingResultAws
    {
        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// The prospected customer account details, including geographic classification, industry
        /// segmentation, company size, and program eligibility.
        /// </para>
        /// </summary>
        public ProspectingResultCustomer Customer { get; set; }

        /// <summary>
        /// Checks to see if the Customer property is set.
        /// </summary>
        internal bool IsSetCustomer() => this.Customer != null;

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// The AI-generated insights from the prospecting analysis, including marketplace engagement
        /// scoring, solution fit assessments, and solution categorization.
        /// </para>
        /// </summary>
        public ProspectingInsights Insights { get; set; }

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null;
    }
}
