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
    /// Contains the insight scores (engagement score and opportunity quality score) returned
    /// for an opportunity in search results.
    /// </summary>
    public partial class OpportunitySearchInsights
    {
        /// <summary>
        /// Gets and sets the property EngagementScore. 
        /// <para>
        /// The level of engagement with the opportunity. The value is <c>High</c>, <c>Medium</c>,
        /// or <c>Low</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SearchEngagementScore EngagementScore { get; set; }

        /// <summary>
        /// Checks to see if the EngagementScore property is set.
        /// </summary>
        internal bool IsSetEngagementScore() => this.EngagementScore != null;

        /// <summary>
        /// Gets and sets the property OpportunityQuality. 
        /// <para>
        /// The opportunity quality score. Null when the opportunity has not yet been scored.
        /// </para>
        /// </summary>
        public OpportunitySearchOpportunityQuality OpportunityQuality { get; set; }

        /// <summary>
        /// Checks to see if the OpportunityQuality property is set.
        /// </summary>
        internal bool IsSetOpportunityQuality() => this.OpportunityQuality != null;
    }
}
