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
    /// Contains enrichment data for engagement invitations. You can view propensity scores,
    /// program eligibility, and lead readiness insights directly in the invitation, before
    /// you take action on the invitation.
    /// </summary>
    public partial class EnrichmentContext
    {
        private LeadInsights _leadInsights;
        private InvitationProspectingResultAws _prospectingResultAws;

        /// <summary>
        /// Gets and sets the property LeadInsights. 
        /// <para>
        /// The AI-generated lead readiness score for this lead. Use this score to assess lead
        /// quality and prioritize engagement efforts.
        /// </para>
        /// </summary>
        public LeadInsights LeadInsights
        {
            get { return this._leadInsights; }
            set { this._leadInsights = value; }
        }

        // Check to see if LeadInsights property is set
        internal bool IsSetLeadInsights()
        {
            return this._leadInsights != null;
        }

        /// <summary>
        /// Gets and sets the property ProspectingResultAws. 
        /// <para>
        /// The customer account data and propensity insights for the prospected account. It includes
        /// geographic, industry, and segment classifications, along with engagement and solution
        /// scoring.
        /// </para>
        /// </summary>
        public InvitationProspectingResultAws ProspectingResultAws
        {
            get { return this._prospectingResultAws; }
            set { this._prospectingResultAws = value; }
        }

        // Check to see if ProspectingResultAws property is set
        internal bool IsSetProspectingResultAws()
        {
            return this._prospectingResultAws != null;
        }

    }
}